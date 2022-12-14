using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fakturowanie.UserInterface.Forms.Invoice
{
    public partial class InvoiceForm : Form
    {
        private static InvoiceForm _instance = null;

        public static InvoiceForm Instance
        {
            get
            {
                if( _instance == null )
                {
                    _instance = new InvoiceForm();
                }
                return _instance;
            }
        }

        public static bool IsNull
        {
            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;
            }
        }

        private InvoiceForm()
        {
            InitializeComponent();
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {

        }

        private void InvoiceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
