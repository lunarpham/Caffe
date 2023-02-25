using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using CoffeManager.DAOCafe;
using CoffeManager.DTOCafe;
using Button = System.Windows.Forms.Button;

namespace CoffeManager
{
    public partial class fTableManager : Form
    {
        private AccDTO dntk;

        public AccDTO DangNhapTK
        {
            get { return dntk; }

            set { dntk = value; ChuyenTK(dntk.LoaiTK); }
        }
        
        public fTableManager(AccDTO acc)
        {
            InitializeComponent();

            this.DangNhapTK = acc;

            TaoBanAn();

            LoaiDoUong();

            TaoCBBanAn(fTableCB);
        }

        #region Method

        void ChuyenTK(int ltk)
        {
            fAdmin.Enabled = ltk == 1;

            accountInfoToolStripMenuItem.Text += " (" + DangNhapTK.TenTK + ")";
        }
        private void TaoBanAn()
        {
            fTableList.Controls.Clear();
            
            List<TableDTO> tableList = TableDAO.Instance.TaoBanAn();

            //for (int i = 0; i < tableList.Count; i++)

            foreach (TableDTO item in tableList)

            {
                //var item = tableList[i];

                Button btn = new Button() { Width = TableDAO.ChieuRongBan, Height = TableDAO.ChieuCaoBan };

                //btn.Text = i + Environment.NewLine + item.TabStat;

                btn.Text = item.TabNum + Environment.NewLine + item.TabStat;

                btn.Click += btn_Click;

                btn.Tag = item;

                switch (item.TabStat)
                {
                    case "Bàn trống":
                        btn.BackColor = Color.Azure;
                        break;
                    default:
                        btn.BackColor = Color.LightGreen;
                        break;
                }

                fTableList.Controls.Add(btn);

            }
        }

        void HienHoaDon(int id)
        {
            float TongThanhToan = 0;

            fBillInfo.Items.Clear();

            List<CoffeManager.DTOCafe.MenuDTO> listBInfo = MenuDAO.Instance.LayDSTDTheoBan(id);

            foreach (CoffeManager.DTOCafe.MenuDTO item in listBInfo)
            {
                ListViewItem LVI = new ListViewItem(item.TenThucDon.ToString());

                LVI.SubItems.Add(item.SoLuong.ToString());

                LVI.SubItems.Add(item.GiaTien.ToString());

                LVI.SubItems.Add(item.TongGiaTien.ToString());

                TongThanhToan += item.TongGiaTien;

                fBillInfo.Items.Add(LVI);
            }

            CultureInfo vnd = new CultureInfo("vi-VN");

            //Thread.CurrentThread.CurrentCulture = vnd;

            f3T.Text = TongThanhToan.ToString("c", vnd);

        }

        void LoaiDoUong()
        {
            List<CateDTO> listLoaiTD = CateDAO.Instance.LayDanhSachTD();

            fBevMenu.DataSource = listLoaiTD;

            fBevMenu.DisplayMember = "LoaiDoUong";
        }

        void IDDanhSachThucDon(int id)
        {
            List<BevDTO> listTD = BevDAO.Instance.IDDanhSachTD(id);

            fBevName.DataSource = listTD;

            fBevName.DisplayMember = "TenDoUong";
        }

        void TaoCBBanAn (ComboBox cbt)
        {
            cbt.DataSource = TableDAO.Instance.TaoBanAn();
            cbt.DisplayMember = "TabNum";
        }

        #endregion

        #region Event

        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as TableDTO).ID;

            fBillInfo.Tag = (sender as Button).Tag;

            HienHoaDon(tableID);
        }
        private void fTableManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn quay trở lại màn hình đăng nhập?", "Exit", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void fTableManager_Load(object sender, EventArgs e)
        {

        }

        
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fAdmin1_Click(object sender, EventArgs e)
        {
            fAdmin1 f = new fAdmin1();

            f.dntk = DangNhapTK;

            f.NhapTD += f_NhapTD;

            f.SuaTD += f_SuaTD;

            f.XoaTD += f_XoaTD;

            f.ThemBanan += f_ThemBan;

            f.XoaBanan += f_XoaBan;

            f.ShowDialog();
        }

        void f_NhapTD(object sender, EventArgs e)
        {
            IDDanhSachThucDon((fBevMenu.SelectedItem as CateDTO).CateID);

            if (fBillInfo.Tag != null)
                HienHoaDon((fBillInfo.Tag as TableDTO).ID);
        }

        void f_SuaTD(object sender, EventArgs e)
        {
            IDDanhSachThucDon((fBevMenu.SelectedItem as CateDTO).CateID);
            
            if (fBillInfo.Tag != null)
                HienHoaDon((fBillInfo.Tag as TableDTO).ID);
        }

        void f_XoaTD(object sender, EventArgs e)
        {
            IDDanhSachThucDon((fBevMenu.SelectedItem as CateDTO).CateID);

            if (fBillInfo.Tag != null)
                HienHoaDon((fBillInfo.Tag as TableDTO).ID);

            TaoBanAn();
        }

        void f_ThemBan(object sender, EventArgs e)
        {
            TaoBanAn();
        }

        void f_XoaBan(object sender, EventArgs e)
        {
            TaoBanAn();
        }

        private void fBillInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fBevMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            CateDTO selected = cb.SelectedItem as CateDTO;

            id = selected.CateID;

            IDDanhSachThucDon(id);
        }

        private void fBevName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fTableControlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fAddMenu_Click(object sender, EventArgs e)
        {
            TableDTO table = fBillInfo.Tag as TableDTO;

            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn");

                return;
            }

            int idhd = BillDAO.Instance.IDHoaDonTheoBanAn(table.ID);

            int idtd = (fBevName.SelectedItem as BevDTO).IDDoUong;

            int sl = (int)fMenuValue.Value;

            if (idhd == -1)
            {
                BillDAO.Instance.NhapHoaDon(table.ID);

                BInfoDAO.Instance.NhapTTHD(BillDAO.Instance.MaxIDHD(), idtd, sl);
            }

            else
            {
                BInfoDAO.Instance.NhapTTHD(idhd, idtd, sl);
            }

            HienHoaDon(table.ID);

            TaoBanAn();
        }

        private void fMenuValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fCheck_Click(object sender, EventArgs e)
        {
            TableDTO table = fBillInfo.Tag as TableDTO;

            int idhd = BillDAO.Instance.IDHoaDonTheoBanAn(table.ID);

            int km = (int)fDiscountValue.Value;

            double TongTien = Convert.ToDouble(f3T.Text.Split(',')[0].Replace(".", ""));

            double ThanhTien = TongTien - (TongTien / 100) * km;

            if (idhd != -1)
            {
                if (MessageBox.Show(string.Format("Thanh toán hóa đơn cho bàn này? \nTổng tiền = {1} VND", table.ID, ThanhTien), "Notify", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CkOut(idhd, km, (float)ThanhTien);

                    HienHoaDon(table.ID);
                }
            }

            TaoBanAn();
        }

        private void fSwitchTable_Click(object sender, EventArgs e)
        {
            int id1 = (fBillInfo.Tag as TableDTO).ID;

            int id2 = (fTableCB.SelectedItem as TableDTO).ID;

            if (MessageBox.Show(string.Format("Chuyển sang bàn đã chọn?", id1, id2), "Notify", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.ChuyenBan(id1, id2);

                TaoBanAn();
            }
        }

        private void fMergeTable_Click(object sender, EventArgs e)
        {
            int id1 = (fBillInfo.Tag as TableDTO).ID;

            int id2 = (fTableCB.SelectedItem as TableDTO).ID;

            if (MessageBox.Show(string.Format("Gộp 2 bàn với nhau?", id1, id2), "Notify", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.GopBan(id1, id2);

                TaoBanAn();
            }
        }

        private void accountInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccProfile f = new fAccProfile(DangNhapTK);

            f.CNTK += f_CNTK;

            f.ShowDialog();
        }

        void f_CNTK (object sender, AccEvent e)
        {
            accountInfoToolStripMenuItem.Text = "Thông tin tài khoản (" + e.TaiKhoan.TenTK + ")";
        }

        private void fTableCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void thêmThựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAddMenu_Click(this, new EventArgs());
        }

        private void chuyểnBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSwitchTable_Click(this, new EventArgs());
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCheck_Click(this, new EventArgs());
        }

        private void fPowerOffBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fHome_Click(object sender, EventArgs e)
        {

        }

        private void fTableList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fDiscountValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void quayVềTrangĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fHome_TextChanged(object sender, EventArgs e)
        {

        }

        private void f3T_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
#endregion


