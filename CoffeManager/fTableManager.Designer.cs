namespace CoffeManager
{
    partial class fTableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
            this.fTableControlPanel = new System.Windows.Forms.Panel();
            this.fCheck = new Guna.UI2.WinForms.Guna2Button();
            this.fDiscountValue = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.f3T = new Guna.UI2.WinForms.Guna2TextBox();
            this.fAddMenu = new Guna.UI2.WinForms.Guna2Button();
            this.fMenuValue = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.fMergeTable = new Guna.UI2.WinForms.Guna2Button();
            this.fBevName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.fBevMenu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.fTableCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.fSwitchTable = new Guna.UI2.WinForms.Guna2Button();
            this.fBillPanel = new System.Windows.Forms.Panel();
            this.fBillInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.fUserAcc = new System.Windows.Forms.ToolStripMenuItem();
            this.accountInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fHome = new System.Windows.Forms.ToolStripMenuItem();
            this.quayVềTrangĐăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fTableList = new System.Windows.Forms.FlowLayoutPanel();
            this.fTableControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fDiscountValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fMenuValue)).BeginInit();
            this.fBillPanel.SuspendLayout();
            this.fMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fTableControlPanel
            // 
            this.fTableControlPanel.Controls.Add(this.fCheck);
            this.fTableControlPanel.Controls.Add(this.fDiscountValue);
            this.fTableControlPanel.Controls.Add(this.label2);
            this.fTableControlPanel.Controls.Add(this.label3);
            this.fTableControlPanel.Controls.Add(this.label1);
            this.fTableControlPanel.Controls.Add(this.f3T);
            this.fTableControlPanel.Controls.Add(this.fAddMenu);
            this.fTableControlPanel.Controls.Add(this.fMenuValue);
            this.fTableControlPanel.Controls.Add(this.fMergeTable);
            this.fTableControlPanel.Controls.Add(this.fBevName);
            this.fTableControlPanel.Controls.Add(this.fBevMenu);
            this.fTableControlPanel.Controls.Add(this.fTableCB);
            this.fTableControlPanel.Controls.Add(this.fSwitchTable);
            this.fTableControlPanel.Location = new System.Drawing.Point(12, 465);
            this.fTableControlPanel.Name = "fTableControlPanel";
            this.fTableControlPanel.Padding = new System.Windows.Forms.Padding(10);
            this.fTableControlPanel.Size = new System.Drawing.Size(628, 291);
            this.fTableControlPanel.TabIndex = 2;
            this.fTableControlPanel.TabStop = true;
            this.fTableControlPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.fTableControlPanel_Paint);
            // 
            // fCheck
            // 
            this.fCheck.BorderRadius = 5;
            this.fCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.fCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.fCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.fCheck.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.fCheck.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fCheck.ForeColor = System.Drawing.Color.White;
            this.fCheck.Location = new System.Drawing.Point(403, 243);
            this.fCheck.Name = "fCheck";
            this.fCheck.Size = new System.Drawing.Size(199, 43);
            this.fCheck.TabIndex = 10;
            this.fCheck.Text = "Thanh toán";
            this.fCheck.Click += new System.EventHandler(this.fCheck_Click);
            // 
            // fDiscountValue
            // 
            this.fDiscountValue.BackColor = System.Drawing.Color.Transparent;
            this.fDiscountValue.BorderRadius = 5;
            this.fDiscountValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fDiscountValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fDiscountValue.Location = new System.Drawing.Point(117, 243);
            this.fDiscountValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fDiscountValue.Name = "fDiscountValue";
            this.fDiscountValue.Size = new System.Drawing.Size(266, 43);
            this.fDiscountValue.TabIndex = 13;
            this.fDiscountValue.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fDiscountValue.ValueChanged += new System.EventHandler(this.fDiscountValue_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(0, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Giảm giá";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(0, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Số lượng";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tổng tiền tạm tính";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // f3T
            // 
            this.f3T.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.f3T.BorderRadius = 5;
            this.f3T.BorderThickness = 2;
            this.f3T.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.f3T.DefaultText = "0000";
            this.f3T.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.f3T.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.f3T.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.f3T.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.f3T.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.f3T.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f3T.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.f3T.Location = new System.Drawing.Point(224, 193);
            this.f3T.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.f3T.Name = "f3T";
            this.f3T.PasswordChar = '\0';
            this.f3T.PlaceholderText = "";
            this.f3T.ReadOnly = true;
            this.f3T.SelectedText = "";
            this.f3T.Size = new System.Drawing.Size(378, 42);
            this.f3T.TabIndex = 0;
            this.f3T.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.f3T.TextChanged += new System.EventHandler(this.f3T_TextChanged);
            // 
            // fAddMenu
            // 
            this.fAddMenu.BorderRadius = 5;
            this.fAddMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.fAddMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.fAddMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fAddMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.fAddMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.fAddMenu.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fAddMenu.ForeColor = System.Drawing.Color.White;
            this.fAddMenu.Location = new System.Drawing.Point(277, 137);
            this.fAddMenu.Name = "fAddMenu";
            this.fAddMenu.Size = new System.Drawing.Size(325, 49);
            this.fAddMenu.TabIndex = 9;
            this.fAddMenu.Text = "Thêm món";
            this.fAddMenu.Click += new System.EventHandler(this.fAddMenu_Click);
            // 
            // fMenuValue
            // 
            this.fMenuValue.BackColor = System.Drawing.Color.Transparent;
            this.fMenuValue.BorderRadius = 5;
            this.fMenuValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fMenuValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fMenuValue.Location = new System.Drawing.Point(117, 136);
            this.fMenuValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fMenuValue.Name = "fMenuValue";
            this.fMenuValue.Size = new System.Drawing.Size(150, 49);
            this.fMenuValue.TabIndex = 6;
            this.fMenuValue.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fMenuValue.ValueChanged += new System.EventHandler(this.fMenuValue_ValueChanged);
            // 
            // fMergeTable
            // 
            this.fMergeTable.BorderRadius = 5;
            this.fMergeTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.fMergeTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.fMergeTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fMergeTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.fMergeTable.FillColor = System.Drawing.Color.Gray;
            this.fMergeTable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.fMergeTable.ForeColor = System.Drawing.Color.White;
            this.fMergeTable.Location = new System.Drawing.Point(268, 22);
            this.fMergeTable.Margin = new System.Windows.Forms.Padding(0);
            this.fMergeTable.Name = "fMergeTable";
            this.fMergeTable.Size = new System.Drawing.Size(138, 49);
            this.fMergeTable.TabIndex = 12;
            this.fMergeTable.Text = "Gộp bàn";
            this.fMergeTable.Click += new System.EventHandler(this.fMergeTable_Click);
            // 
            // fBevName
            // 
            this.fBevName.BackColor = System.Drawing.Color.Transparent;
            this.fBevName.BorderRadius = 5;
            this.fBevName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.fBevName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fBevName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fBevName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fBevName.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fBevName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.fBevName.IntegralHeight = false;
            this.fBevName.ItemHeight = 30;
            this.fBevName.ItemsAppearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fBevName.Location = new System.Drawing.Point(277, 80);
            this.fBevName.Name = "fBevName";
            this.fBevName.Size = new System.Drawing.Size(325, 36);
            this.fBevName.TabIndex = 11;
            this.fBevName.SelectedIndexChanged += new System.EventHandler(this.fBevName_SelectedIndexChanged);
            // 
            // fBevMenu
            // 
            this.fBevMenu.BackColor = System.Drawing.Color.Transparent;
            this.fBevMenu.BorderRadius = 5;
            this.fBevMenu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.fBevMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fBevMenu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fBevMenu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fBevMenu.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.fBevMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.fBevMenu.ItemHeight = 30;
            this.fBevMenu.ItemsAppearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fBevMenu.Location = new System.Drawing.Point(0, 80);
            this.fBevMenu.Margin = new System.Windows.Forms.Padding(20);
            this.fBevMenu.Name = "fBevMenu";
            this.fBevMenu.Size = new System.Drawing.Size(268, 36);
            this.fBevMenu.TabIndex = 10;
            this.fBevMenu.SelectedIndexChanged += new System.EventHandler(this.fBevMenu_SelectedIndexChanged);
            // 
            // fTableCB
            // 
            this.fTableCB.BackColor = System.Drawing.Color.Transparent;
            this.fTableCB.BorderRadius = 5;
            this.fTableCB.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.fTableCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.fTableCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fTableCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fTableCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fTableCB.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fTableCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.fTableCB.FormattingEnabled = true;
            this.fTableCB.IntegralHeight = false;
            this.fTableCB.ItemHeight = 30;
            this.fTableCB.ItemsAppearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fTableCB.Location = new System.Drawing.Point(0, 22);
            this.fTableCB.Margin = new System.Windows.Forms.Padding(0);
            this.fTableCB.MaxDropDownItems = 4;
            this.fTableCB.Name = "fTableCB";
            this.fTableCB.Size = new System.Drawing.Size(255, 36);
            this.fTableCB.TabIndex = 6;
            this.fTableCB.SelectedIndexChanged += new System.EventHandler(this.fTableCB_SelectedIndexChanged);
            // 
            // fSwitchTable
            // 
            this.fSwitchTable.BorderRadius = 5;
            this.fSwitchTable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.fSwitchTable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.fSwitchTable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fSwitchTable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.fSwitchTable.FillColor = System.Drawing.Color.Gray;
            this.fSwitchTable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.fSwitchTable.ForeColor = System.Drawing.Color.White;
            this.fSwitchTable.ImageSize = new System.Drawing.Size(0, 0);
            this.fSwitchTable.Location = new System.Drawing.Point(418, 22);
            this.fSwitchTable.Margin = new System.Windows.Forms.Padding(0);
            this.fSwitchTable.Name = "fSwitchTable";
            this.fSwitchTable.Size = new System.Drawing.Size(182, 49);
            this.fSwitchTable.TabIndex = 8;
            this.fSwitchTable.TabStop = false;
            this.fSwitchTable.Text = "Chuyển bàn";
            this.fSwitchTable.Click += new System.EventHandler(this.fSwitchTable_Click);
            // 
            // fBillPanel
            // 
            this.fBillPanel.Controls.Add(this.fBillInfo);
            this.fBillPanel.Location = new System.Drawing.Point(646, 465);
            this.fBillPanel.Name = "fBillPanel";
            this.fBillPanel.Size = new System.Drawing.Size(708, 291);
            this.fBillPanel.TabIndex = 3;
            // 
            // fBillInfo
            // 
            this.fBillInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.fBillInfo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fBillInfo.GridLines = true;
            this.fBillInfo.HideSelection = false;
            this.fBillInfo.Location = new System.Drawing.Point(3, 22);
            this.fBillInfo.Name = "fBillInfo";
            this.fBillInfo.Size = new System.Drawing.Size(702, 264);
            this.fBillInfo.TabIndex = 0;
            this.fBillInfo.UseCompatibleStateImageBehavior = false;
            this.fBillInfo.View = System.Windows.Forms.View.Details;
            this.fBillInfo.SelectedIndexChanged += new System.EventHandler(this.fBillInfo_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên thực đơn";
            this.columnHeader1.Width = 252;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 170;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tổng tiền";
            this.columnHeader4.Width = 226;
            // 
            // fAdmin
            // 
            this.fAdmin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.fAdmin.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.fAdmin.Name = "fAdmin";
            this.fAdmin.Size = new System.Drawing.Size(80, 26);
            this.fAdmin.Text = "Quản lý";
            this.fAdmin.Click += new System.EventHandler(this.fAdmin1_Click);
            // 
            // fUserAcc
            // 
            this.fUserAcc.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.fUserAcc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountInfoToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.fUserAcc.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fUserAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.fUserAcc.Name = "fUserAcc";
            this.fUserAcc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fUserAcc.Size = new System.Drawing.Size(102, 26);
            this.fUserAcc.Text = "Tài khoản";
            // 
            // accountInfoToolStripMenuItem
            // 
            this.accountInfoToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountInfoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.accountInfoToolStripMenuItem.Name = "accountInfoToolStripMenuItem";
            this.accountInfoToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.accountInfoToolStripMenuItem.Text = "Thông tin tài khoản";
            this.accountInfoToolStripMenuItem.Click += new System.EventHandler(this.accountInfoToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.logOutToolStripMenuItem.Text = "Đăng xuất";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // fHome
            // 
            this.fHome.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.fHome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quayVềTrangĐăngNhậpToolStripMenuItem});
            this.fHome.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fHome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.fHome.Name = "fHome";
            this.fHome.Size = new System.Drawing.Size(145, 26);
            this.fHome.Text = "Màn hình chính";
            this.fHome.Click += new System.EventHandler(this.fHome_Click);
            this.fHome.TextChanged += new System.EventHandler(this.fHome_TextChanged);
            // 
            // quayVềTrangĐăngNhậpToolStripMenuItem
            // 
            this.quayVềTrangĐăngNhậpToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quayVềTrangĐăngNhậpToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.quayVềTrangĐăngNhậpToolStripMenuItem.Name = "quayVềTrangĐăngNhậpToolStripMenuItem";
            this.quayVềTrangĐăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.quayVềTrangĐăngNhậpToolStripMenuItem.Text = "Thoát";
            this.quayVềTrangĐăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.quayVềTrangĐăngNhậpToolStripMenuItem_Click);
            // 
            // fMenuStrip
            // 
            this.fMenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fHome,
            this.fUserAcc,
            this.fAdmin});
            this.fMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.fMenuStrip.Name = "fMenuStrip";
            this.fMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fMenuStrip.Size = new System.Drawing.Size(1366, 30);
            this.fMenuStrip.TabIndex = 0;
            this.fMenuStrip.Text = "menuStrip1";
            // 
            // fTableList
            // 
            this.fTableList.AutoScroll = true;
            this.fTableList.Location = new System.Drawing.Point(12, 41);
            this.fTableList.Name = "fTableList";
            this.fTableList.Size = new System.Drawing.Size(1342, 418);
            this.fTableList.TabIndex = 4;
            this.fTableList.Paint += new System.Windows.Forms.PaintEventHandler(this.fTableList_Paint);
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.fTableControlPanel);
            this.Controls.Add(this.fTableList);
            this.Controls.Add(this.fBillPanel);
            this.Controls.Add(this.fMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.fMenuStrip;
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caffe Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fTableManager_FormClosing);
            this.Load += new System.EventHandler(this.fTableManager_Load);
            this.fTableControlPanel.ResumeLayout(false);
            this.fTableControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fDiscountValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fMenuValue)).EndInit();
            this.fBillPanel.ResumeLayout(false);
            this.fMenuStrip.ResumeLayout(false);
            this.fMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel fTableControlPanel;
        private System.Windows.Forms.Panel fBillPanel;
        private System.Windows.Forms.ListView fBillInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Guna.UI2.WinForms.Guna2Button fSwitchTable;
        private Guna.UI2.WinForms.Guna2Button fAddMenu;
        private Guna.UI2.WinForms.Guna2Button fCheck;
        private Guna.UI2.WinForms.Guna2ComboBox fBevMenu;
        private Guna.UI2.WinForms.Guna2ComboBox fTableCB;
        private Guna.UI2.WinForms.Guna2ComboBox fBevName;
        private Guna.UI2.WinForms.Guna2Button fMergeTable;
        private Guna.UI2.WinForms.Guna2NumericUpDown fMenuValue;
        private System.Windows.Forms.MenuStrip fMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fAdmin;
        private System.Windows.Forms.ToolStripMenuItem fUserAcc;
        private System.Windows.Forms.ToolStripMenuItem accountInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fHome;
        private System.Windows.Forms.FlowLayoutPanel fTableList;
        private Guna.UI2.WinForms.Guna2TextBox f3T;
        private Guna.UI2.WinForms.Guna2NumericUpDown fDiscountValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem quayVềTrangĐăngNhậpToolStripMenuItem;
    }
}