using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeManager.DAOCafe;
using CoffeManager.DTOCafe;

namespace CoffeManager
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogInButton_Click(object sender, EventArgs e)
        {
            string TenTK = fUsernameInput.Text;
            
            string MatKhau = fPassInput.Text;

            if (Login(TenTK, MatKhau))
            {
                AccDTO DangNhapTK = AccDAO.Instance.DangNhapVoiUSN(TenTK);
                
                fTableManager f = new fTableManager(DangNhapTK);

                this.Hide();

                f.ShowDialog();

                this.Show();
            }
            else
            {
                fNotice.Show();
                
                fNotice.Text = "Sai tên đăng nhập hoặc mật khẩu!";
            }
        }

        bool Login(string UserName, string PassWord)
        {
            return AccDAO.Instance.Login(UserName, PassWord);
        }
        
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Exit", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fUsernameInput_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void fUsernameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void fPassInput_Click(object sender, EventArgs e)
        {

        }

        private void fUsernameShowText_Click(object sender, EventArgs e)
        {
            
        }

        private void fUsernameShowText_CursorChanged(object sender, EventArgs e)
        {

        }

        private void fUsernameShowText_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void fUsernameShowText_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void fUsernameShowText_MouseLeave(object sender, EventArgs e)
        {

        }

        private void fPassShowText_Click(object sender, EventArgs e)
        {
            
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void fPassForgor_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void fNotice_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
