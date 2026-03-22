using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace qlsv
{
    public partial class form_mnclass : Form
    {
        string connectionString = @"Data Source=DESKTOP-787HRO1;Initial Catalog=qlsv_csharp;User ID=sa;Password=123456";

        private int currentPage = 1;
        private int pageSize = 10;
        private int totalRecords = 0;
        private int totalPages = 0;

        public form_mnclass()
        {
            InitializeComponent();

            // Gắn sự kiện cho các nút CRUD còn lại
            dtg_cls_list.CellClick += Dtg_cls_list_CellClick;
            btn_cls_update.Click += Btn_cls_update_Click;
            btn_cls_delete.Click += Btn_cls_delete_Click;
            btn_cls_refresh.Click += Btn_cls_refresh_Click;

            // Gắn sự kiện tìm kiếm
            btn_cls_search.Click += Btn_cls_search_Click;

            // Gắn sự kiện phân trang
            btn_cls_lastleft.Click += Btn_cls_lastleft_Click;
            btn_cls_left.Click += Btn_cls_left_Click;
            btn_cls_right.Click += Btn_cls_right_Click;
            btn_cls_lastright.Click += Btn_cls_lastright_Click;

            // Gắn sự kiện cho nút chuyển trang chủ
            btn_cls_main.Click += btn_cls_main_Click;
        }

        private void form_mnclass_Load(object sender, EventArgs e)
        {
            tbx_cls_id.ReadOnly = true; // Khóa ô ID không cho người dùng tự sửa
            LoadData();
            GenerateNextId();
        }

        private void GenerateNextId()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ISNULL(MAX(class_id), 0) + 1 FROM class";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        tbx_cls_id.Text = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo mã lớp tự động: " + ex.Message);
            }
        }

        private void LoadData(string keyword = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // 1. Đếm tổng số bản ghi
                    string countQuery = "SELECT COUNT(*) FROM class ";
                    if (!string.IsNullOrWhiteSpace(keyword))
                    {
                        countQuery += "WHERE CAST(class_id AS VARCHAR) LIKE @keyword OR class_name LIKE @keyword";
                    }

                    using (SqlCommand countCmd = new SqlCommand(countQuery, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(keyword))
                            countCmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                        totalRecords = (int)countCmd.ExecuteScalar();
                    }

                    // Tính toán số trang
                    totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                    if (totalPages == 0) totalPages = 1;
                    if (currentPage > totalPages) currentPage = totalPages;

                    lbl_cls_page.Text = $"Trang {currentPage}/{totalPages} | {totalRecords} bản ghi";

                    // 2. Lấy dữ liệu phân trang
                    string query = "SELECT class_id, class_name, class_note FROM class ";

                    if (!string.IsNullOrWhiteSpace(keyword))
                    {
                        query += "WHERE CAST(class_id AS VARCHAR) LIKE @keyword OR class_name LIKE @keyword ";
                    }

                    query += @"ORDER BY class_id 
                               OFFSET @offset ROWS 
                               FETCH NEXT @pageSize ROWS ONLY";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(keyword))
                            cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                        int offset = (currentPage - 1) * pageSize;
                        cmd.Parameters.AddWithValue("@offset", offset);
                        cmd.Parameters.AddWithValue("@pageSize", pageSize);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dtg_cls_list.AutoGenerateColumns = false;
                        dtg_cls_list.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dtg_cls_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRowView rowView = (DataRowView)dtg_cls_list.Rows[e.RowIndex].DataBoundItem;

                if (rowView != null)
                {
                    tbx_cls_id.Text = rowView["class_id"].ToString();
                    tbx_cls_name.Text = rowView["class_name"].ToString();
                    tbx_cls_note.Text = rowView["class_note"].ToString();
                }
            }
        }

        private void Btn_cls_refresh_Click(object sender, EventArgs e)
        {
            tbx_cls_name.Clear();
            tbx_cls_note.Clear();

            tbx_cls_search.Clear();
            currentPage = 1;

            GenerateNextId();
            tbx_cls_name.Focus();
            LoadData();
        }

        private void btn_cls_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_cls_name.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Lớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Kiểm tra trùng lặp tên lớp
                    string checkQuery = "SELECT COUNT(*) FROM class WHERE class_name = @class_name";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@class_name", tbx_cls_name.Text.Trim());

                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Tên lớp này đã tồn tại trong hệ thống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Btn_cls_refresh_Click(null, null);
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO class (class_id, class_name, class_note) VALUES (@class_id, @class_name, @class_note)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@class_id", tbx_cls_id.Text.Trim());
                        cmd.Parameters.AddWithValue("@class_name", tbx_cls_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@class_note", tbx_cls_note.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Btn_cls_refresh_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_cls_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_cls_name.Text))
            {
                MessageBox.Show("Vui lòng chọn lớp học cần sửa từ bảng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE class SET class_name = @class_name, class_note = @class_note WHERE class_id = @class_id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@class_id", tbx_cls_id.Text);
                        cmd.Parameters.AddWithValue("@class_name", tbx_cls_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@class_note", tbx_cls_note.Text.Trim());

                        int kq = cmd.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            MessageBox.Show("Sửa thông tin lớp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(tbx_cls_search.Text.Trim());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_cls_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa lớp học có mã {tbx_cls_id.Text} không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM class WHERE class_id = @class_id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@class_id", tbx_cls_id.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Xóa lớp học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Btn_cls_refresh_Click(null, null);
                        }
                    }
                }
                catch (SqlException sqlEx)
                {
                    if (sqlEx.Number == 547)
                    {
                        MessageBox.Show("Không thể xóa lớp học này vì đang có sinh viên thuộc lớp. Vui lòng chuyển hoặc xóa các sinh viên đó trước!", "Lỗi ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi CSDL khi xóa: " + sqlEx.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hệ thống khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_cls_search_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadData(tbx_cls_search.Text.Trim());
        }

        private void btn_cls_main_Click(object sender, EventArgs e)
        {
            form_main frmMain = new form_main();
            frmMain.Show();
            this.Hide(); // Ẩn form hiện tại
        }

        private void btn_cls_list_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã click chọn lớp nào trên bảng chưa
            if (string.IsNullOrWhiteSpace(tbx_cls_id.Text))
            {
                MessageBox.Show("Vui lòng click chọn một lớp học từ bảng để xem danh sách sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy ID và Tên lớp đang hiển thị ở TextBox
            int classId = Convert.ToInt32(tbx_cls_id.Text);
            string className = tbx_cls_name.Text;

            // Gọi form mới và truyền ID, Tên lớp sang Constructor 2 mà ta vừa tạo
            form_cls_mnstu frmMnStu = new form_cls_mnstu(classId, className);
            frmMnStu.Show();
        }

        private void Btn_cls_lastleft_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage = 1;
                LoadData(tbx_cls_search.Text.Trim());
            }
        }

        private void Btn_cls_left_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData(tbx_cls_search.Text.Trim());
            }
        }

        private void Btn_cls_right_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadData(tbx_cls_search.Text.Trim());
            }
        }

        private void Btn_cls_lastright_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage = totalPages;
                LoadData(tbx_cls_search.Text.Trim());
            }
        }

        private void lbl_clsnote_Click(object sender, EventArgs e) { }
        private void lbl_clsinf_Click(object sender, EventArgs e) { }
        private void tbx_cls_search_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e) { }
    }
}