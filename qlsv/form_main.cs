using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Lỗi khi kết nối dữ liệu: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void form_main_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbx_sex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {

        }

        private void dtg_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}