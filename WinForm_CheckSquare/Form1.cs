using System;
using System.Windows.Forms;
using MathLibrary;

namespace WinForm_CheckSquare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            input.Click += kiem_tra_Click;
            clear.Click += clear_Click;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kiem_tra_Click(object sender, EventArgs e)
        {
            if (long.TryParse(input.Text, out long n))
            {
                bool result = NumberChecks.IsPerfectSquare(n);
                show.Text = result
                    ? $"{n} là số chính phương."
                    : $"{n} không phải là số chính phương.";
            }
            else
            {
                show.Text = "Vui lòng nhập số hợp lệ!";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void clear_Click(object sender, EventArgs e)
        {
            input.Text = string.Empty;  // xoá ô nhập
            show.Text = string.Empty;   // xoá ô kết quả
            input.Focus();              // đưa con trỏ về ô nhập
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
