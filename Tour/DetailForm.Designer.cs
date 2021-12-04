namespace Tour
{
    partial class DetailForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvChiTiet = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.colIDChiTIet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colthutu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvChiTiet);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 364);
            this.panel1.TabIndex = 0;
            // 
            // dtgvChiTiet
            // 
            this.dtgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDChiTIet,
            this.colMaTour,
            this.colMaDiaDiem,
            this.colthutu});
            this.dtgvChiTiet.Location = new System.Drawing.Point(0, 0);
            this.dtgvChiTiet.Name = "dtgvChiTiet";
            this.dtgvChiTiet.Size = new System.Drawing.Size(601, 294);
            this.dtgvChiTiet.TabIndex = 10;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(263, 313);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // colIDChiTIet
            // 
            this.colIDChiTIet.DataPropertyName = "IDCHITIET";
            this.colIDChiTIet.HeaderText = "ID Chi Tiết";
            this.colIDChiTIet.Name = "colIDChiTIet";
            // 
            // colMaTour
            // 
            this.colMaTour.DataPropertyName = "MaTour";
            this.colMaTour.HeaderText = "Mã Tour";
            this.colMaTour.Name = "colMaTour";
            // 
            // colMaDiaDiem
            // 
            this.colMaDiaDiem.DataPropertyName = "MaDiaDiem";
            this.colMaDiaDiem.HeaderText = "Mã Địa Điểm";
            this.colMaDiaDiem.Name = "colMaDiaDiem";
            // 
            // colthutu
            // 
            this.colthutu.DataPropertyName = "thutu";
            this.colthutu.HeaderText = "Thứ Tự";
            this.colthutu.Name = "colthutu";
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 362);
            this.Controls.Add(this.panel1);
            this.Name = "DetailForm";
            this.Text = "Chi Tiết";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dtgvChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDChiTIet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colthutu;
    }
}