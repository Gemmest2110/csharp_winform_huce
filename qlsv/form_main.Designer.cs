namespace qlsv
{
    partial class form_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null; 

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.cbx_class = new System.Windows.Forms.ComboBox();
            this.cbx_sex = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbx_id = new System.Windows.Forms.TextBox();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_class = new System.Windows.Forms.Label();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.dtg_list = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.tbx_search = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.btn_mnclass = new System.Windows.Forms.Button();
            this.lbl_page = new System.Windows.Forms.Label();
            this.btn_lastleft = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_lastright = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_list)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_refresh);
            this.splitContainer1.Panel1.Controls.Add(this.btn_update);
            this.splitContainer1.Panel1.Controls.Add(this.btn_delete);
            this.splitContainer1.Panel1.Controls.Add(this.btn_add);
            this.splitContainer1.Panel1.Controls.Add(this.cbx_class);
            this.splitContainer1.Panel1.Controls.Add(this.cbx_sex);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.tbx_id);
            this.splitContainer1.Panel1.Controls.Add(this.tbx_name);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_id);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_name);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_date);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_class);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_sex);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_info);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_right);
            this.splitContainer1.Panel2.Controls.Add(this.btn_lastright);
            this.splitContainer1.Panel2.Controls.Add(this.btn_left);
            this.splitContainer1.Panel2.Controls.Add(this.btn_lastleft);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_page);
            this.splitContainer1.Panel2.Controls.Add(this.dtg_list);
            this.splitContainer1.Panel2.Controls.Add(this.btn_mnclass);
            this.splitContainer1.Panel2.Controls.Add(this.button5);
            this.splitContainer1.Panel2.Controls.Add(this.tbx_search);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_search);
            this.splitContainer1.Size = new System.Drawing.Size(800, 505);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(146, 424);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(107, 46);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.Text = "Làm mới";
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(146, 362);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(107, 46);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(15, 424);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(107, 46);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(15, 362);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(107, 46);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // cbx_class
            // 
            this.cbx_class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_class.FormattingEnabled = true;
            this.cbx_class.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbx_class.Location = new System.Drawing.Point(15, 291);
            this.cbx_class.Name = "cbx_class";
            this.cbx_class.Size = new System.Drawing.Size(238, 21);
            this.cbx_class.TabIndex = 3;
            // 
            // cbx_sex
            // 
            this.cbx_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_sex.FormattingEnabled = true;
            this.cbx_sex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbx_sex.Location = new System.Drawing.Point(15, 235);
            this.cbx_sex.Name = "cbx_sex";
            this.cbx_sex.Size = new System.Drawing.Size(238, 21);
            this.cbx_sex.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 173);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // tbx_id
            // 
            this.tbx_id.Location = new System.Drawing.Point(15, 58);
            this.tbx_id.Name = "tbx_id";
            this.tbx_id.ReadOnly = true;
            this.tbx_id.Size = new System.Drawing.Size(238, 20);
            this.tbx_id.TabIndex = 1;
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(15, 114);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(238, 20);
            this.tbx_name.TabIndex = 1;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(12, 42);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(67, 13);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "Mã sinh viên";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 98);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(54, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Họ và tên";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(12, 157);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(54, 13);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "Ngày sinh";
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.Location = new System.Drawing.Point(12, 275);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(25, 13);
            this.lbl_class.TabIndex = 0;
            this.lbl_class.Text = "Lớp";
            // 
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Location = new System.Drawing.Point(12, 219);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(47, 13);
            this.lbl_sex.TabIndex = 0;
            this.lbl_sex.Text = "Giới tính";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(12, 17);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(97, 13);
            this.lbl_info.TabIndex = 0;
            this.lbl_info.Text = "Thông tin sinh viên";
            // 
            // dtg_list
            // 
            this.dtg_list.BackgroundColor = System.Drawing.Color.White;
            this.dtg_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.sex,
            this.date,
            this.lop});
            this.dtg_list.Location = new System.Drawing.Point(14, 64);
            this.dtg_list.Name = "dtg_list";
            this.dtg_list.RowHeadersVisible = false;
            this.dtg_list.Size = new System.Drawing.Size(504, 390);
            this.dtg_list.TabIndex = 5;
            // 
            // id
            // 
            this.id.DataPropertyName = "stu_id";
            this.id.HeaderText = "Mã SV";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.DataPropertyName = "stu_name";
            this.name.HeaderText = "Họ và tên";
            this.name.Name = "name";
            // 
            // sex
            // 
            this.sex.DataPropertyName = "stu_gender";
            this.sex.HeaderText = "Giới tính";
            this.sex.Name = "sex";
            // 
            // date
            // 
            this.date.DataPropertyName = "stu_date";
            this.date.HeaderText = "Ngày sinh";
            this.date.Name = "date";
            // 
            // lop
            // 
            this.lop.DataPropertyName = "class_name";
            this.lop.HeaderText = "Lớp";
            this.lop.Name = "lop";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(307, 27);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 31);
            this.button5.TabIndex = 4;
            this.button5.Text = "Tìm kiếm";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tbx_search
            // 
            this.tbx_search.Location = new System.Drawing.Point(14, 37);
            this.tbx_search.Name = "tbx_search";
            this.tbx_search.Size = new System.Drawing.Size(287, 20);
            this.tbx_search.TabIndex = 1;
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(11, 17);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(165, 13);
            this.lbl_search.TabIndex = 0;
            this.lbl_search.Text = "Tìm kiếm (Tên/Mã sinh viên/Lớp)";
            // 
            // btn_mnclass
            // 
            this.btn_mnclass.Location = new System.Drawing.Point(397, 27);
            this.btn_mnclass.Name = "btn_mnclass";
            this.btn_mnclass.Size = new System.Drawing.Size(121, 30);
            this.btn_mnclass.TabIndex = 4;
            this.btn_mnclass.Text = "Quản lý lớp học";
            this.btn_mnclass.UseVisualStyleBackColor = true;
            // 
            // lbl_page
            // 
            this.lbl_page.AutoSize = true;
            this.lbl_page.Location = new System.Drawing.Point(216, 472);
            this.lbl_page.Name = "lbl_page";
            this.lbl_page.Size = new System.Drawing.Size(107, 13);
            this.lbl_page.TabIndex = 6;
            this.lbl_page.Text = "Trang 1/1 | 0 bản ghi";
            // 
            // btn_lastleft
            // 
            this.btn_lastleft.Location = new System.Drawing.Point(35, 460);
            this.btn_lastleft.Name = "btn_lastleft";
            this.btn_lastleft.Size = new System.Drawing.Size(51, 37);
            this.btn_lastleft.TabIndex = 7;
            this.btn_lastleft.Text = "<<";
            this.btn_lastleft.UseVisualStyleBackColor = true;
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(92, 460);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(51, 37);
            this.btn_left.TabIndex = 7;
            this.btn_left.Text = "<";
            this.btn_left.UseVisualStyleBackColor = true;
            // 
            // btn_lastright
            // 
            this.btn_lastright.Location = new System.Drawing.Point(439, 460);
            this.btn_lastright.Name = "btn_lastright";
            this.btn_lastright.Size = new System.Drawing.Size(51, 37);
            this.btn_lastright.TabIndex = 7;
            this.btn_lastright.Text = ">>";
            this.btn_lastright.UseVisualStyleBackColor = true;
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(382, 460);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(51, 37);
            this.btn_right.TabIndex = 7;
            this.btn_right.Text = ">";
            this.btn_right.UseVisualStyleBackColor = true;
            // 
            // form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.splitContainer1);
            this.Name = "form_main";
            this.Text = "Trang chủ";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.TextBox tbx_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbx_sex;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tbx_search;
        private System.Windows.Forms.DataGridView dtg_list;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.ComboBox cbx_class;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.Button btn_mnclass;
        private System.Windows.Forms.Button btn_lastright;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_lastleft;
        private System.Windows.Forms.Label lbl_page;
        private System.Windows.Forms.Button btn_right;
    }
}