using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace qlsv
{
    public partial class form_main : Form
    {
        string connectionString = @"Data Source=DESKTOP-787HRO1;Initial Catalog=qlsv_csharp;User ID=sa;Password=123456";

        private int currentPage = 1;
        private int pageSize = 10;
        private int totalRecords = 0;
        private int totalPages = 0;

        public form_main()
        {
            InitializeComponent();

            this.Load += new EventHandler(form_main_Load);

            dtg_list.CellClick += Dtg_list_CellClick;
            btn_add.Click += Btn_add_Click;
            btn_update.Click += Btn_update_Click;
            btn_delete.Click += Btn_delete_Click;
            btn_refresh.Click += Btn_refresh_Click;
            button5.Click += Button5_Click;

            btn_lastleft.Click += Btn_lastleft_Click;
            btn_left.Click += Btn_left_Click;
            btn_right.Click += Btn_right_Click;
            btn_lastright.Click += Btn_lastright_Click;

            btn_mnclass.Click += Btn_mnclass_Click;
        }

        private void form_main_Load(object sender, EventArgs e)
        {
            LoadClasses();
            LoadData();
            GenerateNextId();
        }

        private void LoadClasses()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT class_id, class_name FROM class", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cbx_class.DataSource = dt;
                    cbx_class.DisplayMember = "class_name";
                    cbx_class.ValueMember = "class_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách lớp: " + ex.Message);
            }
        }

        private void GenerateNextId()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ISNULL(MAX(stu_id), 0) + 1 FROM student";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        tbx_id.Text = cmd.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo mã sinh viên tự động: " + ex.Message);
            }
        }

        private void LoadData(string keyword = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Đếm tổng số bản ghi
                    string countQuery = "SELECT COUNT(*) FROM student s INNER JOIN class c ON s.class_id = c.class_id ";
                    if (!string.IsNullOrWhiteSpace(keyword))
                    {
                        countQuery += "WHERE CAST(s.stu_id AS VARCHAR) LIKE @keyword OR s.stu_name LIKE @keyword OR c.class_name LIKE @keyword";
                    }

                    using (SqlCommand countCmd = new SqlCommand(countQuery, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(keyword))
                            countCmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                        totalRecords = (int)countCmd.ExecuteScalar();
                    }

                    // Tính toán trang
                    totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);
                    if (totalPages == 0) totalPages = 1;
                    if (currentPage > totalPages) currentPage = totalPages;

                    lbl_page.Text = $"Trang {currentPage}/{totalPages} | {totalRecords} bản ghi";

                    // Lấy dữ liệu phân trang
                    string query = @"
                SELECT s.stu_id, s.stu_name, s.stu_gender, s.stu_date, s.class_id, c.class_name 
                FROM student s 
                INNER JOIN class c ON s.class_id = c.class_id ";

                    if (!string.IsNullOrWhiteSpace(keyword))
                    {
                        query += "WHERE CAST(s.stu_id AS VARCHAR) LIKE @keyword OR s.stu_name LIKE @keyword OR c.class_name LIKE @keyword ";
                    }

                    query += @"ORDER BY s.stu_id 
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

                        dtg_list.AutoGenerateColumns = false;
                        dtg_list.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Dtg_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataRowView rowView = (DataRowView)dtg_list.Rows[e.RowIndex].DataBoundItem;

                if (rowView != null)
                {
                    tbx_id.Text = rowView["stu_id"].ToString();
                    tbx_name.Text = rowView["stu_name"].ToString();

                    string gioiTinh = rowView["stu_gender"].ToString().Trim();
                    cbx_sex.SelectedIndex = cbx_sex.FindStringExact(gioiTinh);

                    if (rowView["stu_date"] != DBNull.Value && rowView["stu_date"].ToString() != "")
                    {
                        dateTimePicker1.Value = Convert.ToDateTime(rowView["stu_date"]);
                    }

                    cbx_class.SelectedValue = rowView["class_id"];
                }
            }
        }

        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            tbx_name.Clear();
            cbx_sex.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            if (cbx_class.Items.Count > 0) cbx_class.SelectedIndex = 0;

            tbx_search.Clear();
            currentPage = 1;

            GenerateNextId();
            tbx_name.Focus();
            LoadData();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_name.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Sinh Viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Kiểm tra trùng lặp
                    string checkQuery = "SELECT COUNT(*) FROM student WHERE stu_name = @check_name AND stu_date = @check_date";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@check_name", tbx_name.Text.Trim());
                        checkCmd.Parameters.AddWithValue("@check_date", dateTimePicker1.Value.Date);

                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Sinh viên đã tồn tại trong hệ thống!", "Cảnh báo trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Btn_refresh_Click(null, null);
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO student (stu_name, stu_gender, stu_date, class_id) VALUES (@stu_name, @stu_gender, @stu_date, @class_id)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@stu_name", tbx_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@stu_gender", cbx_sex.Text);
                        cmd.Parameters.AddWithValue("@stu_date", dateTimePicker1.Value.Date);
                        cmd.Parameters.AddWithValue("@class_id", cbx_class.SelectedValue);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Btn_refresh_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_name.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa từ bảng bên phải!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE student SET stu_name = @stu_name, stu_gender = @stu_gender, stu_date = @stu_date, class_id = @class_id WHERE stu_id = @stu_id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@stu_id", tbx_id.Text);
                        cmd.Parameters.AddWithValue("@stu_name", tbx_name.Text);
                        cmd.Parameters.AddWithValue("@stu_gender", cbx_sex.Text);
                        cmd.Parameters.AddWithValue("@stu_date", dateTimePicker1.Value.Date);
                        cmd.Parameters.AddWithValue("@class_id", cbx_class.SelectedValue);

                        int kq = cmd.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên mã {tbx_id.Text} không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM student WHERE stu_id = @stu_id";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@stu_id", tbx_id.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Btn_refresh_Click(null, null);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadData(tbx_search.Text.Trim());
        }

        private void Btn_mnclass_Click(object sender, EventArgs e)
        {
            // Khởi tạo form Quản lý lớp học
            form_mnclass frmClass = new form_mnclass();

            // Hiển thị form Quản lý lớp
            frmClass.Show();

            // Ẩn form Trang chủ hiện tại đi
            this.Hide();
        }

        private void Btn_lastleft_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage = 1;
                LoadData(tbx_search.Text.Trim());
            }
        }

        private void Btn_left_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData(tbx_search.Text.Trim());
            }
        }

        private void Btn_right_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadData(tbx_search.Text.Trim());
            }
        }

        private void Btn_lastright_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage = totalPages;
                LoadData(tbx_search.Text.Trim());
            }
        }
    }
}