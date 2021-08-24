
namespace Bthumgltql
{
    partial class Form1
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
            this.btnNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTieptuc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNhapso = new System.Windows.Forms.TextBox();
            this.txtDayvuanhap = new System.Windows.Forms.TextBox();
            this.txtTongPTTD = new System.Windows.Forms.TextBox();
            this.txtTongchan = new System.Windows.Forms.TextBox();
            this.txtTongle = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(250, 70);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Nhập ";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập số ";
            // 
            // btnTieptuc
            // 
            this.btnTieptuc.Location = new System.Drawing.Point(106, 264);
            this.btnTieptuc.Name = "btnTieptuc";
            this.btnTieptuc.Size = new System.Drawing.Size(75, 23);
            this.btnTieptuc.TabIndex = 2;
            this.btnTieptuc.Text = "Tiếp tục ";
            this.btnTieptuc.UseVisualStyleBackColor = true;
            this.btnTieptuc.Click += new System.EventHandler(this.btnTieptuc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dãy vừa nhập ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng các phần tử trong dãy ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tổng chẵn ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tổng lẻ ";
            // 
            // txtNhapso
            // 
            this.txtNhapso.Location = new System.Drawing.Point(118, 70);
            this.txtNhapso.Name = "txtNhapso";
            this.txtNhapso.Size = new System.Drawing.Size(89, 20);
            this.txtNhapso.TabIndex = 7;
            // 
            // txtDayvuanhap
            // 
            this.txtDayvuanhap.Location = new System.Drawing.Point(147, 110);
            this.txtDayvuanhap.Name = "txtDayvuanhap";
            this.txtDayvuanhap.Size = new System.Drawing.Size(178, 20);
            this.txtDayvuanhap.TabIndex = 8;
            // 
            // txtTongPTTD
            // 
            this.txtTongPTTD.Location = new System.Drawing.Point(199, 149);
            this.txtTongPTTD.Name = "txtTongPTTD";
            this.txtTongPTTD.Size = new System.Drawing.Size(126, 20);
            this.txtTongPTTD.TabIndex = 9;
            this.txtTongPTTD.TextChanged += new System.EventHandler(this.txtTongPTTD_TextChanged);
            // 
            // txtTongchan
            // 
            this.txtTongchan.Location = new System.Drawing.Point(107, 192);
            this.txtTongchan.Name = "txtTongchan";
            this.txtTongchan.Size = new System.Drawing.Size(74, 20);
            this.txtTongchan.TabIndex = 10;
            // 
            // txtTongle
            // 
            this.txtTongle.Location = new System.Drawing.Point(259, 192);
            this.txtTongle.Name = "txtTongle";
            this.txtTongle.Size = new System.Drawing.Size(66, 20);
            this.txtTongle.TabIndex = 11;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(250, 264);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát ";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtTongle);
            this.Controls.Add(this.txtTongchan);
            this.Controls.Add(this.txtTongPTTD);
            this.Controls.Add(this.txtDayvuanhap);
            this.Controls.Add(this.txtNhapso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTieptuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNhap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTieptuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNhapso;
        private System.Windows.Forms.TextBox txtDayvuanhap;
        private System.Windows.Forms.TextBox txtTongPTTD;
        private System.Windows.Forms.TextBox txtTongchan;
        private System.Windows.Forms.TextBox txtTongle;
        private System.Windows.Forms.Button btnThoat;
    }
}

