using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeManager.DAOCafe;
using CoffeManager.DTOCafe;

namespace CoffeManager
{
    public partial class fAccProfile : Form
    {
        private AccDTO dntk;

        public AccDTO DangNhapTK
        {
            get { return dntk; }

            set { dntk = value; ChuyenTK(dntk); }
        }

        public fAccProfile(AccDTO acc)
        {
            InitializeComponent();

            DangNhapTK = acc;
        }

        void ChuyenTK(AccDTO acc)
        {
            fTBTenDN.Text = DangNhapTK.TenTK;
        }

        void CapNhat3TK()
        {
            string tentk = fTBTenDN.Text;
           
            string mk = fTBMK.Text;
           
            string mkmoi = fTBNewMK.Text;
           
            string resetmk = fTBNhap.Text;

            if (!mkmoi.Equals(resetmk))
            {
                MessageBox.Show("Vui lòng nhập lại đúng với mật khẩu mới của bạn");
            }
            else
            {
                if (AccDAO.Instance.CapNhatTK(tentk, mk, mkmoi))
                {
                    MessageBox.Show("Bạn đã cập nhật mật khẩu thành công");

                    if (cntk != null)
                        cntk(this, new AccEvent(AccDAO.Instance.DangNhapVoiUSN(tentk)));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng mật khẩu");
                }    
            }    
        }

        private event EventHandler<AccEvent> cntk;

        public event EventHandler<AccEvent> CNTK
        {
            add { cntk += value; }

            remove { cntk -= value; }
        }

        private void fLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fUpdateAcc_Click(object sender, EventArgs e)
        {
            CapNhat3TK();
        }

        private void fTBTenDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class AccEvent:EventArgs
    {
        private AccDTO tk;

        public AccDTO TaiKhoan
        {
            get { return tk; }

            set { tk = value; }
        }

        public AccEvent (AccDTO tk)
        {
            this.TaiKhoan = tk;
        }
    }
}
