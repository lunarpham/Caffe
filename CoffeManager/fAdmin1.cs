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
    public partial class fAdmin1 : Form
    {
            BindingSource DSTD = new BindingSource();

            BindingSource DSTK = new BindingSource();

            BindingSource DSBA = new BindingSource();

            public AccDTO dntk;

            public fAdmin1()
            {
                InitializeComponent();

                LoadDulieu();
            }

            #region method

            List<BevDTO> TraCuuThucDon(string tentd)
            {
                List<BevDTO> listtd = BevDAO.Instance.TraCuuThucDon(tentd);

                return listtd;
            }

            void LoadDulieu()
            {
                fDGVAcc.DataSource = DSTK;

                fDGVBev.DataSource = DSTD;

                fDGVTab.DataSource = DSBA;

                DSHDTheoNgay(fNgayBatDau.Value, fNgayKetThuc.Value);

                DTTrongThang();

                XemDSTD();

                LoadBanan();

                LoadTK();

                DSTDBindCBB(fcbCate);

                BindTTThucDon();

                BindTK();

                BindBanan();
            }

            void BindTK()
            {
                ftbAccname.DataBindings.Clear();

                ftbAccname.DataBindings.Add(new Binding("Text", fDGVAcc.DataSource, "TenTK", true, DataSourceUpdateMode.Never));

                ftbCV.DataBindings.Clear();

                ftbCV.DataBindings.Add(new Binding("Text", fDGVAcc.DataSource, "ChucVu", true, DataSourceUpdateMode.Never));

                fnmLoaitk.DataBindings.Clear();

                fnmLoaitk.DataBindings.Add(new Binding("Value", fDGVAcc.DataSource, "LoaiID", true, DataSourceUpdateMode.Never));
            }

            void BindBanan()
            {
                ftbTabNum.DataBindings.Clear();

                ftbTabNum.DataBindings.Add(new Binding("Text", fDGVTab.DataSource, "SoBan", true, DataSourceUpdateMode.Never));

                ftbTabID.DataBindings.Clear();

                ftbTabID.DataBindings.Add(new Binding("Text", fDGVTab.DataSource, "ID", true, DataSourceUpdateMode.Never));
            }

            void LoadTK()
            {
                DSTK.DataSource = AccDAO.Instance.DSTK();
            }

            void XemDSTD()
            {
                DSTD.DataSource = BevDAO.Instance.HthiDSTD();
            }

            void LoadBanan()
            {
                DSBA.DataSource = TableDAO.Instance.DSBA();
            }

            void DTTrongThang()
            {
                DateTime today = DateTime.Now;

                fNgayBatDau.Value = new DateTime(today.Year, today.Month, 1);

                fNgayKetThuc.Value = fNgayBatDau.Value.AddMonths(1).AddDays(-1);
            }

            void DSHDTheoNgay(DateTime tgv, DateTime tgr)
            {
                fDGVBill.DataSource = BillDAO.Instance.DSHDTheoNgay(tgv, tgr);
            }

            void BindTTThucDon()
            {
                ftbBevName.DataBindings.Clear();

                ftbBevName.DataBindings.Add(new Binding("Text", fDGVBev.DataSource, "TenDoUong", true, DataSourceUpdateMode.Never));

                ftbIDTD.DataBindings.Clear();

                ftbIDTD.DataBindings.Add(new Binding("Text", fDGVBev.DataSource, "IDDoUong", true, DataSourceUpdateMode.Never));

                ftbIDCate.DataBindings.Clear();

                ftbIDCate.DataBindings.Add(new Binding("Text", fDGVBev.DataSource, "IDThucDon", true, DataSourceUpdateMode.Never));

                fnmGiaTien.DataBindings.Clear();

                fnmGiaTien.DataBindings.Add(new Binding("Value", fDGVBev.DataSource, "DonGia", true, DataSourceUpdateMode.Never));
            }

            void DSTDBindCBB(ComboBox cb)
            {
                cb.DataSource = CateDAO.Instance.LayDanhSachTD();

                cb.DisplayMember = "LoaiDoUong";
            }

            void ThemTK(string tentk, string cv, int type)
            {
                if (AccDAO.Instance.ThemTK(tentk, cv, type))
                {
                    MessageBox.Show("Đã thêm tài khoản");
                }
                else
                {
                    MessageBox.Show("Không thể thêm tài khoản");
                }

                LoadTK();
            }

            void CapNhatTK(string tentk, int type)
            {
                if (AccDAO.Instance.CapNhatTK(tentk, type))
                {
                    MessageBox.Show("Đã cập nhật tài khoản");
                }
                else
                {
                    MessageBox.Show("Lỗi: cập nhật tài khoản thất bại");
                }

                LoadTK();
            }

            void XoaTK(string tentk)
            {
                if (dntk.TenTK.Equals(tentk))
                {
                    MessageBox.Show("Không thể xóa tk đang sử dụng");
                }
                if (AccDAO.Instance.XoaTK(tentk))
                {
                    MessageBox.Show("Đã xóa tài khoản");
                }
                else
                {
                    MessageBox.Show("Không thể xóa tài khoản");
                }

                LoadTK();
            }

            void DoiMK(string tentk)
            {
                if (AccDAO.Instance.DatlaiMK(tentk))
                {
                    MessageBox.Show("Cập nhật lại mật khẩu thành công");
                }
                else
                {
                    MessageBox.Show("Lỗi: cập nhật lại mật khẩu thất bại");
                }
            }

            void DanhsachTK()
            {

            }
            #endregion

            #region evt

            private void fAddAcc_Click(object sender, EventArgs e)
            {
                string tentk = ftbAccname.Text;

                string cv = ftbCV.Text;

                int type = (int)fnmLoaitk.Value;

                ThemTK(tentk, cv, type);
            }

            private void fEditAcc_Click(object sender, EventArgs e)
            {
                string tentk = ftbAccname.Text;

                string cv = ftbCV.Text;

                int type = (int)fnmLoaitk.Value;

                CapNhatTK(tentk, type);
            }

            private void fDelAcc_Click(object sender, EventArgs e)
            {
                string tentk = ftbAccname.Text;

                XoaTK(tentk);
            }

            private void fPassChange_Click(object sender, EventArgs e)
            {
                string tentk = ftbAccname.Text;

                DoiMK(tentk);
            }

            private void fAccinf_Click(object sender, EventArgs e)
            {
                LoadTK();
            }
            private void fSearching_Click(object sender, EventArgs e)
            {
                DSTD.DataSource = TraCuuThucDon(ftbSearch.Text);
            }

            private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
            {

            }

            private void fPowerOffBt_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void fTotalUp_Click(object sender, EventArgs e)
            {
                DSHDTheoNgay(fNgayBatDau.Value, fNgayKetThuc.Value);
            }

            private void fBevCateShow_Click(object sender, EventArgs e)
            {
                XemDSTD();
            }

            private void fAdmin_Load(object sender, EventArgs e)
            {

            }

            private void ftbIDTD_TextChanged(object sender, EventArgs e)
            {
                try
                {
                    if (fDGVBev.SelectedCells.Count > 0)
                    {
                        int id = (int)fDGVBev.SelectedCells[0].OwningRow.Cells["IDThucDon"].Value;

                        CateDTO cate = CateDAO.Instance.DSTDVoiID(id);

                        fcbCate.SelectedItem = cate;

                        int index = -1;

                        int i = 0;

                        foreach (CateDTO item in fcbCate.Items)
                        {
                            if (item.CateID == cate.CateID)
                            {
                                index = i;

                                break;
                            }
                            i++;
                        }

                        fcbCate.SelectedIndex = index;
                    }
                }
                catch { }
            }
            private void fAddItem_Click(object sender, EventArgs e)
            {
                string tentd = ftbBevName.Text;

                int idtd = (fcbCate.SelectedItem as CateDTO).CateID;

                float gt = (float)fnmGiaTien.Value;

                if (BevDAO.Instance.ThemTD(tentd, idtd, gt))
                {
                    MessageBox.Show("Thêm thực đơn thành công");

                    LoadDulieu();

                    if (nhaptd != null)
                        nhaptd(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Lỗi: không thể thêm thực đơn");
                }
            }

            private void fEditItem_Click(object sender, EventArgs e)
            {
                string tentd = ftbBevName.Text;

                int idtd = (fcbCate.SelectedItem as CateDTO).CateID;

                float gt = (float)fnmGiaTien.Value;

                int id = Convert.ToInt32(ftbIDTD.Text);

                if (BevDAO.Instance.CapNhatTD(tentd, idtd, gt, id))
                {
                    MessageBox.Show("Cập nhật thực đơn thành công");

                    LoadDulieu();

                    if (suatd != null)
                        suatd(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Lỗi: không thể cập nhật thực đơn");
                }
            }

            private void fDeleteItem_Click(object sender, EventArgs e)
            {
                int id = Convert.ToInt32(ftbIDTD.Text);

                if (BevDAO.Instance.XoaTD(id))
                {
                    MessageBox.Show("Đã xóa thực đơn");

                    LoadDulieu();

                    if (xoatd != null)
                        xoatd(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Lỗi: không thể xóa thực đơn");
                }
            }

            private void ftbCV_TextChanged(object sender, EventArgs e)
            {

            }

            private event EventHandler nhaptd;

            public event EventHandler NhapTD
            {
                add { nhaptd += value; }

                remove { nhaptd -= value; }
            }

            private event EventHandler suatd;

            public event EventHandler SuaTD
            {
                add { suatd += value; }

                remove { suatd -= value; }
            }

            private event EventHandler xoatd;

            public event EventHandler XoaTD
            {
                add { xoatd += value; }

                remove { xoatd -= value; }
            }

            private event EventHandler thembanan;

            public event EventHandler ThemBanan
            {
                add { thembanan += value; }

                remove { thembanan -= value; }
            }

            private event EventHandler suabanan;

            public event EventHandler SuaBanan
            {
                add { suabanan += value; }

                remove { suabanan -= value; }
            }

            private event EventHandler xoabanan;

            public event EventHandler XoaBanan
            {
                add { xoabanan += value; }

                remove { xoabanan -= value; }
            }

            private void fHDtrangdau_Click(object sender, EventArgs e)
            {
                ftbTrangHD.Text = "1";
            }

            private void fHDtrangcuoi_Click(object sender, EventArgs e)
            {
                int sumRecord = BillDAO.Instance.SoHD(fNgayBatDau.Value, fNgayKetThuc.Value);

                int lastPage = sumRecord / 10;

                if (sumRecord % 10 != 0)
                    lastPage++;

                ftbTrangHD.Text = lastPage.ToString();
            }

            private void ftbTrangHD_TextChanged(object sender, EventArgs e)
            {
                fDGVBill.DataSource = BillDAO.Instance.DSHDTheoNgayVaTrang(fNgayBatDau.Value, fNgayKetThuc.Value, Convert.ToInt32(ftbTrangHD.Text));
            }

            private void fHDtrangtrc_Click(object sender, EventArgs e)
            {
                int page = Convert.ToInt32(ftbTrangHD.Text);

                if (page > 1)
                    page--;

                ftbTrangHD.Text = page.ToString();
            }

            private void fHDtrangsau_Click(object sender, EventArgs e)
            {
                int page = Convert.ToInt32(ftbTrangHD.Text);
                int sumRecord = BillDAO.Instance.SoHD(fNgayBatDau.Value, fNgayKetThuc.Value);

                if (page < sumRecord)
                    page++;

                ftbTrangHD.Text = page.ToString();
            }

            private void fRev_Click(object sender, EventArgs e)
            {

            }

            private void ftbAccname_TextChanged(object sender, EventArgs e)
            {

            }

            private void ftbBevName_TextChanged(object sender, EventArgs e)
            {

            }

            private void fAddTable_Click(object sender, EventArgs e)
            {
                string tenban = ftbTabNum.Text;

                if (TableDAO.Instance.ThemBan(tenban))
                {
                    MessageBox.Show("Thêm bàn thành công");

                    LoadDulieu();

                    if (thembanan != null)
                        thembanan(this, new EventArgs());
                }
                else if (tenban == null)
                {
                    MessageBox.Show("Lỗi: không thể để trống tên bàn");
                }
                else
                {
                    MessageBox.Show("Lỗi: không thể thêm bàn");
                }


            }

            private void fEditTable_Click(object sender, EventArgs e)
            {
                string tenban = ftbTabNum.Text;

                int id = Convert.ToInt32(ftbTabID.Text);

                if (TableDAO.Instance.SuaBan(id, tenban))
                {
                    MessageBox.Show("Cập nhật bàn thành công");

                    LoadDulieu();

                    if (suabanan != null)
                        suabanan(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Lỗi: không thể cập nhật bàn");
                }
            }

            private void fDelTable_Click(object sender, EventArgs e)
            {
                int id = Convert.ToInt32(ftbTabID.Text);

                if (TableDAO.Instance.XoaBan(id))
                {
                    MessageBox.Show("Đã xóa bàn");

                    LoadDulieu();

                    if (xoabanan != null)
                        xoabanan(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Lỗi: không thể xóa bàn");
                }
            }
        #endregion

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void fDGVBev_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void fcbCate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fDGVBill1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ftbAccname_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void fAdmin1_Load(object sender, EventArgs e)
        {

        }
    }
    }
