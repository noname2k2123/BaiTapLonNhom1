
namespace BaiTapLonNhom1
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTendn = new System.Windows.Forms.TextBox();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.lbltb = new System.Windows.Forms.Label();
            this.btnx = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Đăng Nhập :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu:";
            // 
            // txtTendn
            // 
            this.txtTendn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTendn.Location = new System.Drawing.Point(358, 90);
            this.txtTendn.Multiline = true;
            this.txtTendn.Name = "txtTendn";
            this.txtTendn.Size = new System.Drawing.Size(263, 35);
            this.txtTendn.TabIndex = 3;
            // 
            // txtMk
            // 
            this.txtMk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMk.Location = new System.Drawing.Point(358, 131);
            this.txtMk.Multiline = true;
            this.txtMk.Name = "txtMk";
            this.txtMk.PasswordChar = '*';
            this.txtMk.Size = new System.Drawing.Size(263, 31);
            this.txtMk.TabIndex = 4;
            // 
            // lbltb
            // 
            this.lbltb.AutoSize = true;
            this.lbltb.ForeColor = System.Drawing.Color.Red;
            this.lbltb.Location = new System.Drawing.Point(251, 59);
            this.lbltb.Name = "lbltb";
            this.lbltb.Size = new System.Drawing.Size(86, 17);
            this.lbltb.TabIndex = 6;
            this.lbltb.Text = "Thông Báo :";
            this.lbltb.Visible = false;
            // 
            // btnx
            // 
            this.btnx.BackgroundImage = global::BaiTapLonNhom1.Properties.Resources.c;
            this.btnx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnx.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnx.Location = new System.Drawing.Point(502, 168);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(54, 47);
            this.btnx.TabIndex = 8;
            this.btnx.UseVisualStyleBackColor = true;
            this.btnx.Click += new System.EventHandler(this.btnx_Click);
            // 
            // btnok
            // 
            this.btnok.BackgroundImage = global::BaiTapLonNhom1.Properties.Resources.ok;
            this.btnok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnok.Location = new System.Drawing.Point(422, 168);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(54, 47);
            this.btnok.TabIndex = 7;
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::BaiTapLonNhom1.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(141, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(441, 45);
            this.label10.TabIndex = 23;
            this.label10.Text = "Đăng Nhập Tài Khoản";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btnok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BaiTapLonNhom1.Properties.Resources.hinh_nen_dep_cho_powerpoint_115856259;
            this.CancelButton = this.btnx;
            this.ClientSize = new System.Drawing.Size(633, 215);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnx);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.lbltb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMk);
            this.Controls.Add(this.txtTendn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTendn;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbltb;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnx;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ImageList imageList1;
    }
}