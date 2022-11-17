using Fakturowanie.UserInterface.Forms.Client;
using Fakturowanie.UserInterface.Forms.Invoice;
using Fakturowanie.UserInterface.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fakturowanie.UserInterface.Forms
{
    public partial class MainForm : Form
    {
        #region Fields

        private TabPage _tpInvoice;
        private TabPage _tpClient;

        #endregion
        #region Constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion
        #region Events
        private void btnInvoice_Click(object sender, EventArgs e)
        {
            if (InvoiceForm.IsNull)
            {
                _tpInvoice = new TabPage();
                ShowFormInTabPage(_tpInvoice, InvoiceForm.Instance);
            }
            else
            {
                tcTabs.SelectedTab = _tpInvoice;
            }
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            if (ClientForm.IsNull)
            {
                _tpClient = new TabPage();
                ShowFormInTabPage(_tpClient, ClientForm.Instance);
            }
            else
            {
                tcTabs.SelectedTab = _tpClient;
            }
        }

        private void tcTabs_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                var tabPage = this.tcTabs.TabPages[e.Index];
                var tabRect = this.tcTabs.GetTabRect(e.Index);

                var closeImage = new Bitmap($"{ResourcesHelper.ResourcesFilePath}\\{ResourcesHelper.CloseButtonName}");
                e.Graphics.DrawImage(closeImage,
                    (tabRect.Right - closeImage.Width),
                     tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                     tabRect, tabPage.ForeColor, TextFormatFlags.Left);

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        private void tcTabs_MouseDown(object sender, MouseEventArgs e)
        {
            // Process MouseDown event only till (tabControl.TabPages.Count - 1) excluding the last TabPage
            for (var i = 0; i < this.tcTabs.TabPages.Count; i++)
            {
                var tabRect = this.tcTabs.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var closeImage = new Bitmap($"{ResourcesHelper.ResourcesFilePath}\\{ResourcesHelper.CloseButtonName}");
                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    var frm = tcTabs.TabPages[i].Controls[0] as Form;
                    frm.Close();
                    this.tcTabs.TabPages.RemoveAt(i);
                    break;
                }
            }
        }

        #endregion
        #region Private Methods
        private void ShowFormInTabPage(TabPage tpTab, Form frm)
        {

            tcTabs.Controls.Add(tpTab);

            tpTab.Text = frm.Text;
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tpTab.Controls.Add(frm);
            tcTabs.SelectedTab = tpTab;
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tpConfiguration_Click(object sender, EventArgs e)
        {

        }

    }
}
