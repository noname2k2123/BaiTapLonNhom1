using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonNhom1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public bool check()
        {
            if(string.IsNullOrWhiteSpace(txtTendn.Text))
            {
                MessageBox.Show("Ban chưa nhập tên đăng nhập !", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTendn.Focus();
                return false;

            }
            if (string.IsNullOrWhiteSpace(txtMk.Text))
            {
                MessageBox.Show("Ban chưa nhập mặt khẩu !", "cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMk.Focus();
                return false;

            }
            return true;
        }
        private void btnok_Click(object sender, EventArgs e)
        {
            if(check())
            {
                if (txtTendn.Text.Equals("nhom1") && txtMk.Text.Equals("nhom1"))
                {
                    this.Hide();
                }

                else
                {
                    lbltb.Visible = true;
                    lbltb.Text = "Tên đăng nhập hoặc mật khẩu ko chính xác !";
                }
            }
        }


        
    }
}
