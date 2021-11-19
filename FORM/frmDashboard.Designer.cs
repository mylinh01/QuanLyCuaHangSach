
namespace FORM
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.btnMaximize = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panneControlBox = new System.Windows.Forms.Panel();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStaff = new FontAwesome.Sharp.IconButton();
            this.btnRevenue = new FontAwesome.Sharp.IconButton();
            this.btnMember = new FontAwesome.Sharp.IconButton();
            this.btnDiscount = new FontAwesome.Sharp.IconButton();
            this.btnBookstore = new FontAwesome.Sharp.IconButton();
            this.btnInvoice = new FontAwesome.Sharp.IconButton();
            this.btnSale = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconButtonName = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panneControlBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(35, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(15, 15);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(10, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(15, 15);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(60, 4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(15, 15);
            this.btnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.panneControlBox);
            this.panelMenu.Controls.Add(this.iconPictureBox3);
            this.panelMenu.Controls.Add(this.btnSetting);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btnStaff);
            this.panelMenu.Controls.Add(this.btnRevenue);
            this.panelMenu.Controls.Add(this.btnMember);
            this.panelMenu.Controls.Add(this.btnDiscount);
            this.panelMenu.Controls.Add(this.btnBookstore);
            this.panelMenu.Controls.Add(this.btnInvoice);
            this.panelMenu.Controls.Add(this.btnSale);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 734);
            this.panelMenu.TabIndex = 7;
            // 
            // panneControlBox
            // 
            this.panneControlBox.Controls.Add(this.btnMaximize);
            this.panneControlBox.Controls.Add(this.btnExit);
            this.panneControlBox.Controls.Add(this.btnMinimize);
            this.panneControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panneControlBox.Location = new System.Drawing.Point(0, 0);
            this.panneControlBox.Name = "panneControlBox";
            this.panneControlBox.Size = new System.Drawing.Size(200, 55);
            this.panneControlBox.TabIndex = 10;
            this.panneControlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panneControlBox_MouseDown);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconPictureBox3.BackColor = System.Drawing.Color.White;
            this.iconPictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.Location = new System.Drawing.Point(76, 690);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox3.TabIndex = 9;
            this.iconPictureBox3.TabStop = false;
            this.iconPictureBox3.Click += new System.EventHandler(this.iconPictureBox3_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnSetting.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.IconSize = 35;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 620);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnSetting.Size = new System.Drawing.Size(200, 60);
            this.btnSetting.TabIndex = 8;
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 56);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(200, 138);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 7;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(240, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 117);
            this.panel1.TabIndex = 0;
            // 
            // btnStaff
            // 
            this.btnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStaff.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnStaff.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStaff.IconSize = 35;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(0, 560);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnStaff.Size = new System.Drawing.Size(200, 60);
            this.btnStaff.TabIndex = 6;
            this.btnStaff.Text = "Staff";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevenue.FlatAppearance.BorderSize = 0;
            this.btnRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenue.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRevenue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRevenue.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btnRevenue.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRevenue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRevenue.IconSize = 35;
            this.btnRevenue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevenue.Location = new System.Drawing.Point(0, 500);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnRevenue.Size = new System.Drawing.Size(200, 60);
            this.btnRevenue.TabIndex = 6;
            this.btnRevenue.Text = "Revenue";
            this.btnRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevenue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRevenue.UseVisualStyleBackColor = true;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // btnMember
            // 
            this.btnMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMember.FlatAppearance.BorderSize = 0;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMember.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnMember.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnMember.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMember.IconSize = 35;
            this.btnMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMember.Location = new System.Drawing.Point(0, 440);
            this.btnMember.Name = "btnMember";
            this.btnMember.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnMember.Size = new System.Drawing.Size(200, 60);
            this.btnMember.TabIndex = 6;
            this.btnMember.Text = "Member";
            this.btnMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscount.FlatAppearance.BorderSize = 0;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDiscount.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnDiscount.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDiscount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDiscount.IconSize = 35;
            this.btnDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscount.Location = new System.Drawing.Point(0, 380);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnDiscount.Size = new System.Drawing.Size(200, 60);
            this.btnDiscount.TabIndex = 6;
            this.btnDiscount.Text = "Discount";
            this.btnDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnBookstore
            // 
            this.btnBookstore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookstore.FlatAppearance.BorderSize = 0;
            this.btnBookstore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookstore.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookstore.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBookstore.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.btnBookstore.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBookstore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBookstore.IconSize = 35;
            this.btnBookstore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookstore.Location = new System.Drawing.Point(0, 320);
            this.btnBookstore.Name = "btnBookstore";
            this.btnBookstore.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnBookstore.Size = new System.Drawing.Size(200, 60);
            this.btnBookstore.TabIndex = 6;
            this.btnBookstore.Text = "Bookstore";
            this.btnBookstore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookstore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBookstore.UseVisualStyleBackColor = true;
            this.btnBookstore.Click += new System.EventHandler(this.btnBookstore_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvoice.FlatAppearance.BorderSize = 0;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnInvoice.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnInvoice.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnInvoice.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInvoice.IconSize = 35;
            this.btnInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoice.Location = new System.Drawing.Point(0, 260);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnInvoice.Size = new System.Drawing.Size(200, 60);
            this.btnInvoice.TabIndex = 6;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.White;
            this.btnSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSale.FlatAppearance.BorderSize = 0;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSale.IconChar = FontAwesome.Sharp.IconChar.Sellsy;
            this.btnSale.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSale.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSale.IconSize = 35;
            this.btnSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.Location = new System.Drawing.Point(0, 200);
            this.btnSale.Name = "btnSale";
            this.btnSale.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnSale.Size = new System.Drawing.Size(200, 60);
            this.btnSale.TabIndex = 6;
            this.btnSale.Text = "Sale";
            this.btnSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.iconButtonName);
            this.panelTitleBar.Controls.Add(this.pictureBox1);
            this.panelTitleBar.Controls.Add(this.iconPictureBox2);
            this.panelTitleBar.Controls.Add(this.iconPictureBox1);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(984, 76);
            this.panelTitleBar.TabIndex = 8;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconButtonName
            // 
            this.iconButtonName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonName.AutoSize = true;
            this.iconButtonName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonName.FlatAppearance.BorderSize = 0;
            this.iconButtonName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButtonName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButtonName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconButtonName.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconButtonName.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconButtonName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonName.IconSize = 25;
            this.iconButtonName.Location = new System.Drawing.Point(812, 18);
            this.iconButtonName.Name = "iconButtonName";
            this.iconButtonName.Size = new System.Drawing.Size(160, 37);
            this.iconButtonName.TabIndex = 5;
            this.iconButtonName.Text = "Do Quoc Viet";
            this.iconButtonName.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonName.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(756, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 25;
            this.iconPictureBox2.Location = new System.Drawing.Point(725, 23);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(25, 25);
            this.iconPictureBox2.TabIndex = 3;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 30;
            this.iconPictureBox1.Location = new System.Drawing.Point(687, 23);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 30);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitleChildForm.Location = new System.Drawing.Point(52, 28);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(45, 20);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(165)))), ((int)(((byte)(252)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(165)))), ((int)(((byte)(252)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 30;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(22, 25);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 30);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 76);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(984, 658);
            this.panelDesktop.TabIndex = 9;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1184, 734);
            this.ControlBox = false;
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panneControlBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnMaximize;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnSale;
        private FontAwesome.Sharp.IconButton btnStaff;
        private FontAwesome.Sharp.IconButton btnRevenue;
        private FontAwesome.Sharp.IconButton btnMember;
        private FontAwesome.Sharp.IconButton btnDiscount;
        private FontAwesome.Sharp.IconButton btnBookstore;
        private FontAwesome.Sharp.IconButton btnInvoice;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconButton iconButtonName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private System.Windows.Forms.Panel panneControlBox;
    }
}