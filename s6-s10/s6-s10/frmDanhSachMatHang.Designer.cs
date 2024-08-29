namespace s6_s10
{
    partial class frmDanhSachMatHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nhomMatHangColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSoColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMatHangColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaNiemYetColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanSiColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanLeColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThaiColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luuYColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1286, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc và tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhóm mặt hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên và mã mặt hàng:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(129, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(131, 25);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(439, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 25);
            this.textBox1.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(627, 26);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 27);
            this.button3.TabIndex = 22;
            this.button3.Text = "Xóa bộ lọc";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(761, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Có 4 mặt hàng - Tổng số lượng: 83";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1099, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 27);
            this.button1.TabIndex = 24;
            this.button1.Text = "Thêm mặt hàng";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1286, 595);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách mặt hàng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nhomMatHangColumn1,
            this.maSoColumn1,
            this.tenMatHangColumn1,
            this.giaNiemYetColumn1,
            this.giaBanSiColumn1,
            this.giaBanLeColumn1,
            this.soLuongColumn1,
            this.trangThaiColumn1,
            this.luuYColumn1});
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(6, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1274, 564);
            this.dataGridView1.TabIndex = 0;
            // 
            // nhomMatHangColumn1
            // 
            this.nhomMatHangColumn1.FillWeight = 117.1004F;
            this.nhomMatHangColumn1.HeaderText = "Nhóm mặt hàng";
            this.nhomMatHangColumn1.MinimumWidth = 6;
            this.nhomMatHangColumn1.Name = "nhomMatHangColumn1";
            this.nhomMatHangColumn1.Width = 140;
            // 
            // maSoColumn1
            // 
            this.maSoColumn1.FillWeight = 66.10787F;
            this.maSoColumn1.HeaderText = "Mã số";
            this.maSoColumn1.MinimumWidth = 6;
            this.maSoColumn1.Name = "maSoColumn1";
            this.maSoColumn1.Width = 79;
            // 
            // tenMatHangColumn1
            // 
            this.tenMatHangColumn1.FillWeight = 120.9119F;
            this.tenMatHangColumn1.HeaderText = "Tên mặt hàng";
            this.tenMatHangColumn1.MinimumWidth = 6;
            this.tenMatHangColumn1.Name = "tenMatHangColumn1";
            this.tenMatHangColumn1.Width = 145;
            // 
            // giaNiemYetColumn1
            // 
            this.giaNiemYetColumn1.FillWeight = 101.1537F;
            this.giaNiemYetColumn1.HeaderText = "Giá niêm yết";
            this.giaNiemYetColumn1.MinimumWidth = 6;
            this.giaNiemYetColumn1.Name = "giaNiemYetColumn1";
            this.giaNiemYetColumn1.Width = 121;
            // 
            // giaBanSiColumn1
            // 
            this.giaBanSiColumn1.FillWeight = 102.5723F;
            this.giaBanSiColumn1.HeaderText = "Giá bán sỉ";
            this.giaBanSiColumn1.MinimumWidth = 6;
            this.giaBanSiColumn1.Name = "giaBanSiColumn1";
            this.giaBanSiColumn1.Width = 122;
            // 
            // giaBanLeColumn1
            // 
            this.giaBanLeColumn1.FillWeight = 102.1244F;
            this.giaBanLeColumn1.HeaderText = "Giá bán lẻ";
            this.giaBanLeColumn1.MinimumWidth = 6;
            this.giaBanLeColumn1.Name = "giaBanLeColumn1";
            this.giaBanLeColumn1.Width = 122;
            // 
            // soLuongColumn1
            // 
            this.soLuongColumn1.FillWeight = 77.58211F;
            this.soLuongColumn1.HeaderText = "Số lượng";
            this.soLuongColumn1.MinimumWidth = 6;
            this.soLuongColumn1.Name = "soLuongColumn1";
            this.soLuongColumn1.Width = 93;
            // 
            // trangThaiColumn1
            // 
            this.trangThaiColumn1.FillWeight = 105.7514F;
            this.trangThaiColumn1.HeaderText = "Trạng thái";
            this.trangThaiColumn1.MinimumWidth = 6;
            this.trangThaiColumn1.Name = "trangThaiColumn1";
            this.trangThaiColumn1.Width = 126;
            // 
            // luuYColumn1
            // 
            this.luuYColumn1.FillWeight = 106.6959F;
            this.luuYColumn1.HeaderText = "Lưu ý";
            this.luuYColumn1.MinimumWidth = 6;
            this.luuYColumn1.Name = "luuYColumn1";
            this.luuYColumn1.Width = 128;
            // 
            // frmDanhSachMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 713);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDanhSachMatHang";
            this.Text = "frmDanhSachMatHang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhomMatHangColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSoColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMatHangColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNiemYetColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanSiColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanLeColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThaiColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn luuYColumn1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}