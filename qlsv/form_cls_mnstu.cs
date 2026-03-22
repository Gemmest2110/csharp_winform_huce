using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace qlsv
{
    public partial class form_cls_mnstu : Form
    {
        string connectionString = @"Data Source=DESKTOP-787HRO1;Initial Catalog=qlsv_csharp;User ID=sa;Password=123456";

        private int currentClassId = -1;
        private string currentClassName = "";

        public form_cls_mnstu()
        {
            InitializeComponent();
            this.Load += Form_cls_mnstu_Load;
        }

        public form_cls_mnstu(int classId, string className)
        {
            InitializeComponent();
            currentClassId = classId;
            currentClassName = className;
            this.Load += Form_cls_mnstu_Load;
        }

        private void Form_cls_mnstu_Load(object sender, EventArgs e)
        {
            stu_id.DataPropertyName = "stu_id";
            stu_name.DataPropertyName = "stu_name";
            stu_gender.DataPropertyName = "stu_gender";
            stu_date.DataPropertyName = "stu_date";
            class_name.DataPropertyName = "class_name";

            stu_date.DefaultCellStyle.Format = "dd/MM/yyyy";

            LoadStudentData();
        }

        private void LoadStudentData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Dùng INNER JOIN để lấy được cột class_name từ bảng class
                    string query = @"
                        SELECT s.stu_id, s.stu_name, s.stu_gender, s.stu_date, c.class_name 
                        FROM student s
                        INNER JOIN class c ON s.class_id = c.class_id ";

                    // Nếu có truyền class_id vào thì lọc sinh viên theo lớp đó
                    if (currentClassId != -1)
                    {
                        query += " WHERE s.class_id = @class_id";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (currentClassId != -1)
                        {
                            cmd.Parameters.AddWithValue("@class_id", currentClassId);
                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Đổ dữ liệu lên DataGridView
                        dataGridView1.AutoGenerateColumns = false;
                        dataGridView1.DataSource = dt;

                        // Cập nhật các Label hiển thị thông tin
                        if (currentClassId != -1)
                        {
                            lbl_mnstu.Text = "Danh sách sinh viên - " + currentClassName;
                        }
                        else
                        {
                            lbl_mnstu.Text = "Danh sách toàn bộ sinh viên";
                        }

                        lbl_mnstu_count.Text = $"Tổng số: {dt.Rows.Count} sinh viên";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Giữ lại hàm rác này để file Designer không báo lỗi
        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}