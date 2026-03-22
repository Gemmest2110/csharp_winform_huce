namespace qlsv
{
    partial class form_mnclass
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
            this.btn_cls_delete = new System.Windows.Forms.Button();
            this.btn_cls_add = new System.Windows.Forms.Button();
            this.btn_cls_list = new System.Windows.Forms.Button();
            this.btn_cls_refresh = new System.Windows.Forms.Button();
            this.btn_cls_update = new System.Windows.Forms.Button();
            this.tbx_cls_note = new System.Windows.Forms.TextBox();
            this.tbx_cls_name = new System.Windows.Forms.TextBox();
            this.tbx_cls_id = new System.Windows.Forms.TextBox();
            this.lbl_cls_note = new System.Windows.Forms.Label();
            this.lbl_cls_name = new System.Windows.Forms.Label();
            this.lbl_cls_id = new System.Windows.Forms.Label();
            this.lbl_cls_inf = new System.Windows.Forms.Label();
            this.dtg_cls_list = new System.Windows.Forms.DataGridView();
            this.lbl_cls_search = new System.Windows.Forms.Label();
            this.btn_cls_search = new System.Windows.Forms.Button();
            this.tbx_cls_search = new System.Windows.Forms.TextBox();
            this.btn_cls_lastleft = new System.Windows.Forms.Button();
            this.btn_cls_left = new System.Windows.Forms.Button();
            this.btn_cls_right = new System.Windows.Forms.Button();
            this.btn_cls_lastright = new System.Windows.Forms.Button();
            this.lbl_cls_page = new System.Windows.Forms.Label();
            this.class_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cls_main = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_cls_list)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btn_cls_delete);
            this.splitContainer1.Panel1.Controls.Add(this.btn_cls_add);
            this.splitContainer1.Panel1.Controls.Add(this.btn_cls_list);
            this.splitContainer1.Panel1.Controls.Add(this.btn_cls_refresh);
            this.splitContainer1.Panel1.Controls.Add(this.btn_cls_update);
            this.splitContainer1.Panel1.Controls.Add(this.tbx_cls_note);
            this.splitContainer1.Panel1.Controls.Add(this.tbx_cls_name);
            this.splitContainer1.Panel1.Controls.Add(this.tbx_cls_id);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_cls_note);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_cls_name);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_cls_id);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_cls_inf);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_cls_main);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_cls_page);
            this.splitContainer1.Panel2.Controls.Add(this.btn_cls_lastright);
            this.splitContainer1.Panel2.Controls.Add(this.btn_cls_right);
            this.splitContainer1.Panel2.Controls.Add(this.btn_cls_left);
            this.splitContainer1.Panel2.Controls.Add(this.btn_cls_lastleft);
            this.splitContainer1.Panel2.Controls.Add(this.dtg_cls_list);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_cls_search);
            this.splitContainer1.Panel2.Controls.Add(this.btn_cls_search);
            this.splitContainer1.Panel2.Controls.Add(this.tbx_cls_search);
            this.splitContainer1.Size = new System.Drawing.Size(800, 490);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // btn_cls_delete
            // 
            this.btn_cls_delete.Location = new System.Drawing.Point(15, 311);
            this.btn_cls_delete.Name = "btn_cls_delete";
            this.btn_cls_delete.Size = new System.Drawing.Size(107, 46);
            this.btn_cls_delete.TabIndex = 2;
            this.btn_cls_delete.Text = "Xóa";
            this.btn_cls_delete.UseVisualStyleBackColor = true;
            // 
            // btn_cls_add
            // 
            this.btn_cls_add.Location = new System.Drawing.Point(15, 243);
            this.btn_cls_add.Name = "btn_cls_add";
            this.btn_cls_add.Size = new System.Drawing.Size(107, 46);
            this.btn_cls_add.TabIndex = 2;
            this.btn_cls_add.Text = "Thêm";
            this.btn_cls_add.UseVisualStyleBackColor = true;
            this.btn_cls_add.Click += new System.EventHandler(this.btn_cls_add_Click);
            // 
            // btn_cls_list
            // 
            this.btn_cls_list.Location = new System.Drawing.Point(42, 380);
            this.btn_cls_list.Name = "btn_cls_list";
            this.btn_cls_list.Size = new System.Drawing.Size(179, 68);
            this.btn_cls_list.TabIndex = 2;
            this.btn_cls_list.Text = "Xem danh sách sinh viên";
            this.btn_cls_list.UseVisualStyleBackColor = true;
            this.btn_cls_list.Click += new System.EventHandler(this.btn_cls_list_Click);
            // 
            // btn_cls_refresh
            // 
            this.btn_cls_refresh.Location = new System.Drawing.Point(142, 311);
            this.btn_cls_refresh.Name = "btn_cls_refresh";
            this.btn_cls_refresh.Size = new System.Drawing.Size(107, 46);
            this.btn_cls_refresh.TabIndex = 2;
            this.btn_cls_refresh.Text = "Làm mới";
            this.btn_cls_refresh.UseVisualStyleBackColor = true;
            // 
            // btn_cls_update
            // 
            this.btn_cls_update.Location = new System.Drawing.Point(142, 243);
            this.btn_cls_update.Name = "btn_cls_update";
            this.btn_cls_update.Size = new System.Drawing.Size(107, 46);
            this.btn_cls_update.TabIndex = 2;
            this.btn_cls_update.Text = "Sửa";
            this.btn_cls_update.UseVisualStyleBackColor = true;
            // 
            // tbx_cls_note
            // 
            this.tbx_cls_note.Location = new System.Drawing.Point(15, 166);
            this.tbx_cls_note.Name = "tbx_cls_note";
            this.tbx_cls_note.Size = new System.Drawing.Size(234, 20);
            this.tbx_cls_note.TabIndex = 1;
            // 
            // tbx_cls_name
            // 
            this.tbx_cls_name.Location = new System.Drawing.Point(15, 107);
            this.tbx_cls_name.Name = "tbx_cls_name";
            this.tbx_cls_name.Size = new System.Drawing.Size(234, 20);
            this.tbx_cls_name.TabIndex = 1;
            // 
            // tbx_cls_id
            // 
            this.tbx_cls_id.Location = new System.Drawing.Point(15, 59);
            this.tbx_cls_id.Name = "tbx_cls_id";
            this.tbx_cls_id.Size = new System.Drawing.Size(234, 20);
            this.tbx_cls_id.TabIndex = 1;
            // 
            // lbl_cls_note
            // 
            this.lbl_cls_note.AutoSize = true;
            this.lbl_cls_note.Location = new System.Drawing.Point(12, 140);
            this.lbl_cls_note.Name = "lbl_cls_note";
            this.lbl_cls_note.Size = new System.Drawing.Size(44, 13);
            this.lbl_cls_note.TabIndex = 0;
            this.lbl_cls_note.Text = "Ghi chú";
            this.lbl_cls_note.Click += new System.EventHandler(this.lbl_clsnote_Click);
            // 
            // lbl_cls_name
            // 
            this.lbl_cls_name.AutoSize = true;
            this.lbl_cls_name.Location = new System.Drawing.Point(12, 91);
            this.lbl_cls_name.Name = "lbl_cls_name";
            this.lbl_cls_name.Size = new System.Drawing.Size(43, 13);
            this.lbl_cls_name.TabIndex = 0;
            this.lbl_cls_name.Text = "Tên lớp";
            // 
            // lbl_cls_id
            // 
            this.lbl_cls_id.AutoSize = true;
            this.lbl_cls_id.Location = new System.Drawing.Point(12, 43);
            this.lbl_cls_id.Name = "lbl_cls_id";
            this.lbl_cls_id.Size = new System.Drawing.Size(36, 13);
            this.lbl_cls_id.TabIndex = 0;
            this.lbl_cls_id.Text = "Mã ID";
            // 
            // lbl_cls_inf
            // 
            this.lbl_cls_inf.AutoSize = true;
            this.lbl_cls_inf.Location = new System.Drawing.Point(12, 19);
            this.lbl_cls_inf.Name = "lbl_cls_inf";
            this.lbl_cls_inf.Size = new System.Drawing.Size(90, 13);
            this.lbl_cls_inf.TabIndex = 0;
            this.lbl_cls_inf.Text = "Thông tin lớp học";
            this.lbl_cls_inf.Click += new System.EventHandler(this.lbl_clsinf_Click);
            // 
            // dtg_cls_list
            // 
            this.dtg_cls_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_cls_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.class_id,
            this.class_name,
            this.class_note});
            this.dtg_cls_list.Location = new System.Drawing.Point(15, 69);
            this.dtg_cls_list.Name = "dtg_cls_list";
            this.dtg_cls_list.RowHeadersVisible = false;
            this.dtg_cls_list.Size = new System.Drawing.Size(505, 365);
            this.dtg_cls_list.TabIndex = 2;
            // 
            // lbl_cls_search
            // 
            this.lbl_cls_search.AutoSize = true;
            this.lbl_cls_search.Location = new System.Drawing.Point(12, 19);
            this.lbl_cls_search.Name = "lbl_cls_search";
            this.lbl_cls_search.Size = new System.Drawing.Size(165, 13);
            this.lbl_cls_search.TabIndex = 0;
            this.lbl_cls_search.Text = "Tìm kiếm (Mã ID/Mã lớp/Tên lớp)";
            this.lbl_cls_search.Click += new System.EventHandler(this.lbl_clsinf_Click);
            // 
            // btn_cls_search
            // 
            this.btn_cls_search.Location = new System.Drawing.Point(440, 38);
            this.btn_cls_search.Name = "btn_cls_search";
            this.btn_cls_search.Size = new System.Drawing.Size(80, 23);
            this.btn_cls_search.TabIndex = 2;
            this.btn_cls_search.Text = "Tìm kiếm";
            this.btn_cls_search.UseVisualStyleBackColor = true;
            // 
            // tbx_cls_search
            // 
            this.tbx_cls_search.Location = new System.Drawing.Point(15, 40);
            this.tbx_cls_search.Name = "tbx_cls_search";
            this.tbx_cls_search.Size = new System.Drawing.Size(419, 20);
            this.tbx_cls_search.TabIndex = 1;
            this.tbx_cls_search.TextChanged += new System.EventHandler(this.tbx_cls_search_TextChanged);
            // 
            // btn_cls_lastleft
            // 
            this.btn_cls_lastleft.Location = new System.Drawing.Point(30, 440);
            this.btn_cls_lastleft.Name = "btn_cls_lastleft";
            this.btn_cls_lastleft.Size = new System.Drawing.Size(51, 37);
            this.btn_cls_lastleft.TabIndex = 3;
            this.btn_cls_lastleft.Text = "<<";
            this.btn_cls_lastleft.UseVisualStyleBackColor = true;
            // 
            // btn_cls_left
            // 
            this.btn_cls_left.Location = new System.Drawing.Point(87, 440);
            this.btn_cls_left.Name = "btn_cls_left";
            this.btn_cls_left.Size = new System.Drawing.Size(51, 37);
            this.btn_cls_left.TabIndex = 3;
            this.btn_cls_left.Text = "<";
            this.btn_cls_left.UseVisualStyleBackColor = true;
            // 
            // btn_cls_right
            // 
            this.btn_cls_right.Location = new System.Drawing.Point(397, 440);
            this.btn_cls_right.Name = "btn_cls_right";
            this.btn_cls_right.Size = new System.Drawing.Size(51, 37);
            this.btn_cls_right.TabIndex = 3;
            this.btn_cls_right.Text = ">";
            this.btn_cls_right.UseVisualStyleBackColor = true;
            // 
            // btn_cls_lastright
            // 
            this.btn_cls_lastright.Location = new System.Drawing.Point(454, 440);
            this.btn_cls_lastright.Name = "btn_cls_lastright";
            this.btn_cls_lastright.Size = new System.Drawing.Size(51, 37);
            this.btn_cls_lastright.TabIndex = 3;
            this.btn_cls_lastright.Text = ">>";
            this.btn_cls_lastright.UseVisualStyleBackColor = true;
            this.btn_cls_lastright.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbl_cls_page
            // 
            this.lbl_cls_page.AutoSize = true;
            this.lbl_cls_page.Location = new System.Drawing.Point(215, 452);
            this.lbl_cls_page.Name = "lbl_cls_page";
            this.lbl_cls_page.Size = new System.Drawing.Size(107, 13);
            this.lbl_cls_page.TabIndex = 4;
            this.lbl_cls_page.Text = "Trang 1/1 | 0 bản ghi";
            this.lbl_cls_page.Click += new System.EventHandler(this.label1_Click);
            // 
            // class_id
            // 
            this.class_id.DataPropertyName = "class_id";
            this.class_id.HeaderText = "Mã lớp";
            this.class_id.Name = "class_id";
            this.class_id.ReadOnly = true;
            // 
            // class_name
            // 
            this.class_name.DataPropertyName = "class_name";
            this.class_name.HeaderText = "Tên lớp";
            this.class_name.Name = "class_name";
            this.class_name.ReadOnly = true;
            // 
            // class_note
            // 
            this.class_note.DataPropertyName = "class_note";
            this.class_note.HeaderText = "Ghi chú";
            this.class_note.Name = "class_note";
            this.class_note.ReadOnly = true;
            // 
            // btn_cls_main
            // 
            this.btn_cls_main.Location = new System.Drawing.Point(440, 10);
            this.btn_cls_main.Name = "btn_cls_main";
            this.btn_cls_main.Size = new System.Drawing.Size(80, 24);
            this.btn_cls_main.TabIndex = 2;
            this.btn_cls_main.Text = "Trang chủ";
            this.btn_cls_main.UseVisualStyleBackColor = true;
            // 
            // form_mnclass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.splitContainer1);
            this.Name = "form_mnclass";
            this.Text = "Quản lý lớp học";
            this.Load += new System.EventHandler(this.form_mnclass_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_cls_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbl_cls_inf;
        private System.Windows.Forms.Label lbl_cls_note;
        private System.Windows.Forms.Label lbl_cls_name;
        private System.Windows.Forms.Label lbl_cls_id;
        private System.Windows.Forms.TextBox tbx_cls_note;
        private System.Windows.Forms.TextBox tbx_cls_name;
        private System.Windows.Forms.TextBox tbx_cls_id;
        private System.Windows.Forms.Label lbl_cls_search;
        private System.Windows.Forms.TextBox tbx_cls_search;
        private System.Windows.Forms.DataGridView dtg_cls_list;
        private System.Windows.Forms.Button btn_cls_delete;
        private System.Windows.Forms.Button btn_cls_add;
        private System.Windows.Forms.Button btn_cls_list;
        private System.Windows.Forms.Button btn_cls_refresh;
        private System.Windows.Forms.Button btn_cls_update;
        private System.Windows.Forms.Button btn_cls_search;
        private System.Windows.Forms.Button btn_cls_lastleft;
        private System.Windows.Forms.Label lbl_cls_page;
        private System.Windows.Forms.Button btn_cls_lastright;
        private System.Windows.Forms.Button btn_cls_right;
        private System.Windows.Forms.Button btn_cls_left;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_note;
        private System.Windows.Forms.Button btn_cls_main;
    }
}