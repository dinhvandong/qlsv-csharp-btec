namespace QLSV_Database
{
    partial class InputDepartmentForm
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
            this.tbx_makhoa = new System.Windows.Forms.TextBox();
            this.tbx_tenkhoa = new System.Windows.Forms.TextBox();
            this.tbx_sodienthoai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_makhoa
            // 
            this.tbx_makhoa.Location = new System.Drawing.Point(156, 49);
            this.tbx_makhoa.Multiline = true;
            this.tbx_makhoa.Name = "tbx_makhoa";
            this.tbx_makhoa.Size = new System.Drawing.Size(324, 58);
            this.tbx_makhoa.TabIndex = 0;
            // 
            // tbx_tenkhoa
            // 
            this.tbx_tenkhoa.Location = new System.Drawing.Point(156, 133);
            this.tbx_tenkhoa.Multiline = true;
            this.tbx_tenkhoa.Name = "tbx_tenkhoa";
            this.tbx_tenkhoa.Size = new System.Drawing.Size(324, 58);
            this.tbx_tenkhoa.TabIndex = 1;
            // 
            // tbx_sodienthoai
            // 
            this.tbx_sodienthoai.Location = new System.Drawing.Point(156, 218);
            this.tbx_sodienthoai.Multiline = true;
            this.tbx_sodienthoai.Name = "tbx_sodienthoai";
            this.tbx_sodienthoai.Size = new System.Drawing.Size(324, 58);
            this.tbx_sodienthoai.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Điện thoại liên hệ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 72);
            this.button1.TabIndex = 6;
            this.button1.Text = "Lưu thông tin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbx_sodienthoai);
            this.panel1.Controls.Add(this.tbx_tenkhoa);
            this.panel1.Controls.Add(this.tbx_makhoa);
            this.panel1.Location = new System.Drawing.Point(94, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 416);
            this.panel1.TabIndex = 7;
            // 
            // InputDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "InputDepartmentForm";
            this.Text = "InputDepartmentForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_makhoa;
        private System.Windows.Forms.TextBox tbx_tenkhoa;
        private System.Windows.Forms.TextBox tbx_sodienthoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}