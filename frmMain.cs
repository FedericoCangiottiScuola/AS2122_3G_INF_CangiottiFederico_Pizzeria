using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2122_3G_INF_CangiottiFederico_Pizzeria
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        int nMargherita = 0;
        int n4Stagioni = 0;
        int nVerdure = 0;

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            string scelta = cmbPizze.Text;
            int quantita = Convert.ToInt32(txtNumPizze.Text);

            switch (scelta)
            {
                case "MARGHERITA":
                    lstPizze.Items.Add($"{scelta}, {quantita}");
                    break;

                case "4 STAGIONI":
                    lstPizze.Items.Add($"{scelta}, {quantita}");
                    break;

                case "VERDURE":
                    lstPizze.Items.Add($"{scelta}, {quantita}");
                    break;
            }
        }
    }
}
