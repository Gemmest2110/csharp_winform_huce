using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace qlsv
{
    public partial class form_main : Form
    {
        string connectionString = @"Data Source=DESKTOP-787HRO1;Initial Catalog=qlsv_csharp;User ID=sa;Password=123456";

        public form_main()
        {
            InitializeComponent();

            this.Load += new EventHandler(form_main_Load);

            dtg_list.CellClick += Dtg_list_CellClick; // Bấm vào DataGridView
            btn_add.Click += Btn_add_Click;           // Nút Thêm
            btn_update.Click += Btn_update_Click;     // Nút Sửa
            btn_delete.Click += Btn_delete_Click;     // Nút Xóa
            btn_refresh.Click += Btn_refresh_Click;   // Nút Làm mới
            button5.Click += Button5_Click;           // Nút Tìm kiếm
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT mssv, hoten, gioitinh, ngaysinh, lop FROM qlsv";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dtg_list.AutoGenerateColumns = false;
                    dtg_list.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void form_main_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        // --- 1. SỰ KIỆN CLICK VÀO BẢNG ĐỔ DỮ LIỆU LÊN TEXTBOX ---
        private void Dtg_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_list.Rows[e.RowIndex];

                tbx_id.Text = row.Cells["id"].Value?.ToString();
                tbx_name.Text = row.Cells["name"].Value?.ToString();

                string gioiTinh = row.Cells["sex"].Value?.ToString().Trim();

                cbx_sex.SelectedIndex = cbx_sex.FindStringExact(gioiTinh);

                if (row.Cells["date"].Value != null && row.Cells["date"].Value.ToString() != "")
                {
                    dateTimePicker1.Value = Convert.ToDateTime(row.Cells["date"].Value);
                }

                tbx_class.Text = row.Cells["lop"].Value?.ToString();

                tbx_id.ReadOnly = true;
            }
        }

        // --- 2. CHỨC NĂNG LÀM MỚI ---
        private void Btn_refresh_Click(object sender, EventArgs e)
        {
            tbx_id.Clear();
            tbx_name.Clear();
            cbx_sex.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            tbx_class.Clear();
            textBox4.Clear();

            tbx_id.ReadOnly = false;

            tbx_id.Focus();
            LoadData();
        }

        // --- 3. CHỨC NĂNG THÊM ---
        private void Btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_id.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã Sinh Viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM qlsv WHERE mssv = @mssv";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@mssv", tbx_id.Text);
                        int count = (int)checkCmd.ExecuteScalar(); 

                        if (count > 0)
                        {
                            MessageBox.Show("Mã sinh viên này đã tồn tại! Nếu muốn thêm mới, vui lòng bấm 'Làm mới' trước.", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string insertQuery = "INSERT INTO qlsv (mssv, hoten, gioitinh, ngaysinh, lop) VALUES (@mssv, @hoten, @gioitinh, @ngaysinh, @lop)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@mssv", tbx_id.Text);
                        cmd.Parameters.AddWithValue("@hoten", tbx_name.Text);
                        cmd.Parameters.AddWithValue("@gioitinh", cbx_sex.Text);
                        cmd.Parameters.AddWithValue("@ngaysinh", dateTimePicker1.Value.Date);
                        cmd.Parameters.AddWithValue("@lop", tbx_class.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadData();
                        Btn_refresh_Click(null, null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- 4. CHỨC NĂNG SỬA ---
        private void Btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_id.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa từ bảng bên phải!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE qlsv SET hoten = @hoten, gioitinh = @gioitinh, ngaysinh = @ngaysinh, lop = @lop WHERE mssv = @mssv";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@mssv", tbx_id.Text);
                        cmd.Parameters.AddWithValue("@hoten", tbx_name.Text);
                        cmd.Parameters.AddWithValue("@gioitinh", cbx_sex.Text);
                        cmd.Parameters.AddWithValue("@ngaysinh", dateTimePicker1.Value.Date);
                        cmd.Parameters.AddWithValue("@lop", tbx_class.Text);

                        int kq = cmd.ExecuteNonQuery();
                        if (kq > 0)
                        {
                            MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy Mã SV này để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- 5. CHỨC NĂNG XÓA ---
        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_id.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên mã {tbx_id.Text} không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM qlsv WHERE mssv = @mssv";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@mssv", tbx_id.Text);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
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

        // --- 6. CHỨC NĂNG TÌM KIẾM ---
        private void Button5_Click(object sender, EventArgs e)
        {
            string keyword = textBox4.Text.Trim(); 
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT mssv, hoten, gioitinh, ngaysinh, lop FROM qlsv WHERE mssv LIKE @keyword OR hoten LIKE @keyword OR lop LIKE @keyword";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dtg_list.DataSource = dt; 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}