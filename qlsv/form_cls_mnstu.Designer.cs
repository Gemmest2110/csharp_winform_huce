namespace qlsv
{
    partial class form_cls_mnstu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_mnstu = new System.Windows.Forms.Label();
            this.lbl_mnstu_count = new System.Windows.Forms.Label();
            this.stu_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stu_id,
            this.stu_name,
            this.stu_gender,
            this.stu_date,
            this.class_name});
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(701, 381);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_mnstu
            // 
            this.lbl_mnstu.AutoSize = true;
            this.lbl_mnstu.Location = new System.Drawing.Point(22, 10);
            this.lbl_mnstu.Name = "lbl_mnstu";
            this.lbl_mnstu.Size = new System.Drawing.Size(168, 13);
            this.lbl_mnstu.TabIndex = 1;
            this.lbl_mnstu.Text = "Danh sách sinh viên - Lớp 68PM4";
            // 
            // lbl_mnstu_count
            // 
            this.lbl_mnstu_count.AutoSize = true;
            this.lbl_mnstu_count.Location = new System.Drawing.Point(22, 32);
            this.lbl_mnstu_count.Name = "lbl_mnstu_count";
            this.lbl_mnstu_count.Size = new System.Drawing.Size(103, 13);
            this.lbl_mnstu_count.TabIndex = 1;
            this.lbl_mnstu_count.Text = "Tổng số: 2 sinh viên";
            this.lbl_mnstu_count.Click += new System.EventHandler(this.label1_Click);
            // 
            // stu_id
            // 
            this.stu_id.HeaderText = "Mã SV";
            this.stu_id.Name = "stu_id";
            this.stu_id.ReadOnly = true;
            // 
            // stu_name
            // 
            this.stu_name.HeaderText = "Họ và tên";
            this.stu_name.Name = "stu_name";
            this.stu_name.ReadOnly = true;
            // 
            // stu_gender
            // 
            this.stu_gender.HeaderText = "Giới tính";
            this.stu_gender.Name = "stu_gender";
            this.stu_gender.ReadOnly = true;
            // 
            // stu_date
            // 
            this.stu_date.HeaderText = "Ngày sinh";
            this.stu_date.Name = "stu_date";
            this.stu_date.ReadOnly = true;
            // 
            // class_name
            // 
            this.class_name.HeaderText = "Lớp";
            this.class_name.Name = "class_name";
            this.class_name.ReadOnly = true;
            // 
            // form_cls_mnstu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 450);
            this.Controls.Add(this.lbl_mnstu_count);
            this.Controls.Add(this.lbl_mnstu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "form_cls_mnstu";
            this.Text = "Quản lý sinh viên lớp học";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_mnstu;
        private System.Windows.Forms.Label lbl_mnstu_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_name;
    }
}