namespace Fakturowanie.UserInterface.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsslVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tpHelp = new System.Windows.Forms.TabPage();
            this.tpConfiguration = new System.Windows.Forms.TabPage();
            this.btnUsers = new System.Windows.Forms.Button();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.btnListOfGoods = new System.Windows.Forms.Button();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.btnArchives = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnClient = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.pMain = new System.Windows.Forms.Panel();
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.ssMain.SuspendLayout();
            this.tpConfiguration.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslVersion,
            this.tsslDatabase,
            this.tsslUser});
            this.ssMain.Location = new System.Drawing.Point(0, 539);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(874, 22);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // tsslVersion
            // 
            this.tsslVersion.Name = "tsslVersion";
            this.tsslVersion.Size = new System.Drawing.Size(60, 17);
            this.tsslVersion.Text = "Wersja 1.1";
            // 
            // tsslDatabase
            // 
            this.tsslDatabase.Image = global::Fakturowanie.UserInterface.Properties.Resources.database;
            this.tsslDatabase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsslDatabase.Name = "tsslDatabase";
            this.tsslDatabase.Size = new System.Drawing.Size(124, 17);
            this.tsslDatabase.Text = "Baza: Fakturowanie";
            // 
            // tsslUser
            // 
            this.tsslUser.Image = global::Fakturowanie.UserInterface.Properties.Resources.kobieta;
            this.tsslUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsslUser.Name = "tsslUser";
            this.tsslUser.Size = new System.Drawing.Size(152, 17);
            this.tsslUser.Text = "Użytkownik: Filip Nowak";
            // 
            // tpHelp
            // 
            this.tpHelp.Location = new System.Drawing.Point(4, 24);
            this.tpHelp.Name = "tpHelp";
            this.tpHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tpHelp.Size = new System.Drawing.Size(866, 62);
            this.tpHelp.TabIndex = 2;
            this.tpHelp.Text = "Pomoc";
            this.tpHelp.UseVisualStyleBackColor = true;
            this.tpHelp.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tpConfiguration
            // 
            this.tpConfiguration.Controls.Add(this.btnUsers);
            this.tpConfiguration.Location = new System.Drawing.Point(4, 24);
            this.tpConfiguration.Name = "tpConfiguration";
            this.tpConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tpConfiguration.Size = new System.Drawing.Size(866, 62);
            this.tpConfiguration.TabIndex = 1;
            this.tpConfiguration.Text = "Konfiguracja";
            this.tpConfiguration.UseVisualStyleBackColor = true;
            this.tpConfiguration.Click += new System.EventHandler(this.tpConfiguration_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.White;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUsers.Image = global::Fakturowanie.UserInterface.Properties.Resources.gosc;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(3, 3);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(125, 56);
            this.btnUsers.TabIndex = 26;
            this.btnUsers.Text = "Użytkownicy";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsers.UseVisualStyleBackColor = false;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpGeneral);
            this.tcMain.Controls.Add(this.tpConfiguration);
            this.tcMain.Controls.Add(this.tpHelp);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(874, 90);
            this.tcMain.TabIndex = 0;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.btnListOfGoods);
            this.tpGeneral.Controls.Add(this.splitter3);
            this.tpGeneral.Controls.Add(this.btnArchives);
            this.tpGeneral.Controls.Add(this.splitter1);
            this.tpGeneral.Controls.Add(this.btnClient);
            this.tpGeneral.Controls.Add(this.splitter2);
            this.tpGeneral.Controls.Add(this.btnInvoice);
            this.tpGeneral.Location = new System.Drawing.Point(4, 24);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(866, 62);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "Ogólne";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // btnListOfGoods
            // 
            this.btnListOfGoods.BackColor = System.Drawing.Color.White;
            this.btnListOfGoods.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnListOfGoods.Image = global::Fakturowanie.UserInterface.Properties.Resources.towary;
            this.btnListOfGoods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListOfGoods.Location = new System.Drawing.Point(368, 3);
            this.btnListOfGoods.Name = "btnListOfGoods";
            this.btnListOfGoods.Size = new System.Drawing.Size(110, 56);
            this.btnListOfGoods.TabIndex = 23;
            this.btnListOfGoods.Text = "Towary";
            this.btnListOfGoods.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListOfGoods.UseVisualStyleBackColor = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(363, 3);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(5, 56);
            this.splitter3.TabIndex = 22;
            this.splitter3.TabStop = false;
            // 
            // btnArchives
            // 
            this.btnArchives.BackColor = System.Drawing.Color.White;
            this.btnArchives.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnArchives.Image = global::Fakturowanie.UserInterface.Properties.Resources._previmg11111121212121212;
            this.btnArchives.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchives.Location = new System.Drawing.Point(238, 3);
            this.btnArchives.Name = "btnArchives";
            this.btnArchives.Size = new System.Drawing.Size(125, 56);
            this.btnArchives.TabIndex = 20;
            this.btnArchives.Text = "Archiwum";
            this.btnArchives.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnArchives.UseVisualStyleBackColor = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(233, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 56);
            this.splitter1.TabIndex = 19;
            this.splitter1.TabStop = false;
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.White;
            this.btnClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClient.Image = global::Fakturowanie.UserInterface.Properties.Resources.Facet;
            this.btnClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClient.Location = new System.Drawing.Point(118, 3);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(115, 56);
            this.btnClient.TabIndex = 14;
            this.btnClient.Text = "Kontrahenci";
            this.btnClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(113, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 56);
            this.splitter2.TabIndex = 13;
            this.splitter2.TabStop = false;
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.White;
            this.btnInvoice.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInvoice.Image = global::Fakturowanie.UserInterface.Properties.Resources._previmg77777;
            this.btnInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInvoice.Location = new System.Drawing.Point(3, 3);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(110, 56);
            this.btnInvoice.TabIndex = 10;
            this.btnInvoice.Text = "Faktura";
            this.btnInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.White;
            this.pMain.Controls.Add(this.tcTabs);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 90);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(874, 449);
            this.pMain.TabIndex = 2;
            this.pMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tcTabs
            // 
            this.tcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcTabs.ItemSize = new System.Drawing.Size(105, 18);
            this.tcTabs.Location = new System.Drawing.Point(0, 0);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(874, 449);
            this.tcTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcTabs.TabIndex = 0;
            this.tcTabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tcTabs_DrawItem);
            this.tcTabs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tcTabs_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 561);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tcMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fakturowanie";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.tpConfiguration.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.pMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslVersion;
        private System.Windows.Forms.ToolStripStatusLabel tsslDatabase;
        private System.Windows.Forms.ToolStripStatusLabel tsslUser;
        private System.Windows.Forms.TabPage tpHelp;
        private System.Windows.Forms.TabPage tpConfiguration;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.Button btnListOfGoods;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button btnArchives;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.TabControl tcTabs;
    }
}