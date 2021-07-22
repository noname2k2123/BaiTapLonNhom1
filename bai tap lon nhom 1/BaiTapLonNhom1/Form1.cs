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
    public partial class Form1 : Form
    {
        SinhVienBLL bllsv;
        public Form1()
        {
            InitializeComponent();
            bllsv = new SinhVienBLL();
        }

        public void showaallsv()
        {
            DataTable dt = bllsv.getAllSinhVien();
            dataGridView2.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.ShowDialog();
            showaallsv();
        }
        public bool checkdata()
        {
            if (string.IsNullOrEmpty(txtMaSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaSV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập Tên sinh viên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSV.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtLop.Text))
            {
                MessageBox.Show("Bạn chưa nhập Lớp sinh viên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLop.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDiachi.Text))
            {
                MessageBox.Show("Bạn chưa nhập Địa chỉ sinh viên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiachi.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtToan.Text))
            {
                MessageBox.Show("Bạn chưa nhập Điẻm toán sinh viên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtToan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtVan.Text))
            {
                MessageBox.Show("Bạn chưa nhập ĐIểm Văn sinh viên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtAnh.Text))
            {
                MessageBox.Show("Bạn chưa nhập Điểm Anh sinh viên ", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnh.Focus();
                return false;
            }
            return true;

        }

        private void btnnhap_Click(object sender, EventArgs e)
        {
            if (checkdata())
            {
                tblSinhVien sv = new tblSinhVien();
                sv.MaSV = txtMaSV.Text;
                sv.TenSV = txtTenSV.Text;
                sv.Lop = txtLop.Text;
                sv.Diachi = txtDiachi.Text;
                sv.Toan = float.Parse(txtToan.Text);
                sv.Anh = float.Parse(txtAnh.Text);
                sv.Van = float.Parse(txtVan.Text);
                if (sv.Toan <= 10 && sv.Van >= 0 && sv.Anh >= 0 && sv.Anh <= 10 && sv.Toan >= 0 && sv.Van <= 10)
                {                                  
                    if (bllsv.Insert(sv))
                    {
                        showaallsv();
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra !", "Thông báo lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Số điểm bạn nhập phải từ 0 - 10!", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        int ID;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int nhap = e.RowIndex;
                if (nhap >= 0)
                {
                    ID = Int32.Parse(dataGridView2.Rows[nhap].Cells["id"].Value.ToString());
                    txtMaSV.Text = dataGridView2.Rows[nhap].Cells["MaSV"].Value.ToString();
                    txtTenSV.Text = dataGridView2.Rows[nhap].Cells["TenSV"].Value.ToString();
                    txtLop.Text = dataGridView2.Rows[nhap].Cells["Lop"].Value.ToString();
                    txtDiachi.Text = dataGridView2.Rows[nhap].Cells["Diachi"].Value.ToString();
                    txtToan.Text = dataGridView2.Rows[nhap].Cells["Toan"].Value.ToString();
                    txtAnh.Text = dataGridView2.Rows[nhap].Cells["Anh"].Value.ToString();
                    txtVan.Text = dataGridView2.Rows[nhap].Cells["Van"].Value.ToString();
                }
            }
            catch
            { }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (checkdata())
            {

                tblSinhVien sv = new tblSinhVien();
                sv.ID = ID;
                sv.MaSV = txtMaSV.Text;
                sv.TenSV = txtTenSV.Text;
                sv.Lop = txtLop.Text;
                sv.Diachi = txtDiachi.Text;
                sv.Toan = float.Parse(txtToan.Text);
                sv.Anh = float.Parse(txtAnh.Text);
                sv.Van = float.Parse(txtVan.Text);
                if (sv.Toan <= 10 && sv.Van >= 0 && sv.Anh >= 0 && sv.Anh <= 10 && sv.Toan >= 0 && sv.Van <= 10)
                {
                    if (bllsv.update(sv))
                    {
                        showaallsv();
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra !", "Thông báo lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Số điểm bạn nhập phải từ 0 - 10!", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có Muốn xóa hay ko !","Thông báo!", MessageBoxButtons.OKCancel,MessageBoxIcon.Information)==DialogResult.OK)
            {
                tblSinhVien sv = new tblSinhVien();
                sv.ID = ID;
                if (bllsv.delete(sv))
                
                    showaallsv();
                
                else
                
                    MessageBox.Show("Đã có lỗi xảy ra !", "Thông báo lỗi !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                


            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhập thoát chương trình !", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void txtdata_TextChanged(object sender, EventArgs e)
        {
            string value = txtdata.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllsv.timkiem(value);
                dataGridView2.DataSource = dt;
            }
            else
                showaallsv();
                
                  
        }
    }
}
