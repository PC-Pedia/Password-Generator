using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int total = chkListSymbols.Items.Count;
            string symbolsToUse = string.Empty;

            for (int i = 0; i < total; i++)
            {
                if (chkListSymbols.GetItemChecked(i))
                {
                    symbolsToUse += chkListSymbols.Items[i].ToString();
                }
            }
            Properties.Settings.Default.Symbols = symbolsToUse;
            Properties.Settings.Default.KeyboardLayout = lstLayouts.SelectedItem.ToString();
            Properties.Settings.Default.Save();

            ((frmMain)this.Owner).chkCharsToUse_CheckedChanged(null, null);
            

            this.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int n = chkListSymbols.Items.Count;
            bool value = sender.Equals(btnSelectAll);

            for (int i = 0; i < n; i++)
            {
                chkListSymbols.SetItemChecked(i, value);
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            lstLayouts.SelectedItem = Properties.Settings.Default.KeyboardLayout;

            string symbolsToUse = Properties.Settings.Default.Symbols;
            int n = chkListSymbols.Items.Count;

            for (int i = 0; i < n; i++)
            {
                chkListSymbols.SetItemChecked(i, symbolsToUse.Contains(chkListSymbols.Items[i].ToString()));
            }
        }
    }
}
