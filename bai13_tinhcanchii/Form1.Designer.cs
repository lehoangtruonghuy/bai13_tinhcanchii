namespace bai13_tinhcanchii
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
            this.btnTinh = new System.Windows.Forms.Button();
            this.lstNam = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(308, 15);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(102, 42);
            this.btnTinh.TabIndex = 0;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // lstNam
            // 
            this.lstNam.FormattingEnabled = true;
            this.lstNam.Location = new System.Drawing.Point(468, 15);
            this.lstNam.Name = "lstNam";
            this.lstNam.Size = new System.Drawing.Size(177, 212);
            this.lstNam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kết Quả";
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(97, 26);
            this.txtNam.Multiline = true;
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(150, 30);
            this.txtNam.TabIndex = 3;
            this.txtNam.TextChanged += new System.EventHandler(this.txtNam_TextChanged);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(97, 86);
            this.txtKQ.Multiline = true;
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(150, 30);
            this.txtKQ.TabIndex = 3;
            // 
            // btnKetQua
            // 
            this.btnKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetQua.Location = new System.Drawing.Point(308, 86);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(102, 42);
            this.btnKetQua.TabIndex = 0;
            this.btnKetQua.Text = "Exit";
            this.btnKetQua.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(702, 273);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstNam);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.btnTinh);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.ListBox lstNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnKetQua;
    }
}

