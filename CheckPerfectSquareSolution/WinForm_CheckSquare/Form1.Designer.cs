namespace WinForm_CheckSquare
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
            this.input = new System.Windows.Forms.TextBox();
            this.kiem_tra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(146, 101);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(457, 22);
            this.input.TabIndex = 0;
            this.input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // kiem_tra
            // 
            this.kiem_tra.Location = new System.Drawing.Point(146, 145);
            this.kiem_tra.Name = "kiem_tra";
            this.kiem_tra.Size = new System.Drawing.Size(194, 105);
            this.kiem_tra.TabIndex = 1;
            this.kiem_tra.Text = "Nhấn vào đây để kiểm tra";
            this.kiem_tra.UseVisualStyleBackColor = true;
            this.kiem_tra.Click += new System.EventHandler(this.kiem_tra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập số cần tìm ở đây";
            // 
            // show
            // 
            this.show.AutoSize = true;
            this.show.Location = new System.Drawing.Point(303, 270);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(133, 16);
            this.show.TabIndex = 2;
            this.show.Text = "Kết quả hiển thị ở đây";
            this.show.Click += new System.EventHandler(this.label1_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(400, 145);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(203, 105);
            this.clear.TabIndex = 4;
            this.clear.Text = "Nhấn vào đây để xóa dữ liệu";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.show);
            this.Controls.Add(this.kiem_tra);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button kiem_tra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label show;
        private System.Windows.Forms.Button clear;
    }
}

