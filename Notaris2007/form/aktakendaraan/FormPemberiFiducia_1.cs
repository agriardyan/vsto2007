using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Notaris2007.form.aktakendaraan
{
    public partial class FormPemberiFiducia_1 : Form
    {
        public FormPemberiFiducia_1()
        {
            InitializeComponent();
        }

        private void lanjutButton_Click(object sender, EventArgs e)
        {
            Globals.ThisAddIn.findReplace("$NAMAPEMBERIFIDUCIA", prefixNama(prefix1CB.SelectedIndex) + nama1TB.Text);
            Globals.ThisAddIn.findReplace("$KOTAKELAHIRANPEMBERIFIDUCIA", kota1TB.Text);
            Globals.ThisAddIn.findReplace("$NIKPEMBERIFIDUCIA", nik1TB.Text);
            Globals.ThisAddIn.findReplace("$PEKERJAANPEMBERIFIDUCIA", pekerjaan1TB.Text);
            Globals.ThisAddIn.findReplace("$RELASIPEMBERIFIDUCIA", relasiRTB.Text);
            Globals.ThisAddIn.findReplace("$PENYETUJUFIDUCIA", prefixNama(prefix2CB.SelectedIndex) + nama2TB.Text);
            Globals.ThisAddIn.findReplace("$KOTAKELAHIRANPENYETUJUFIDUCIA", kota2TB.Text);
            Globals.ThisAddIn.findReplace("$NIKPENYETUJUFIDUCIA", nik2TB.Text);
            Globals.ThisAddIn.findReplace("$PENYETUJUFIDUCIA", nama2TB.Text);
            Globals.ThisAddIn.findReplace("$PEKERJAANPENYETUJUFIDUCIA", pekerjaan2TB.Text);

            new FormPenerimaFiducia_2().Visible = true;
            this.Visible = false;
        }

        private String prefixNama(int pIndex)
        {
            String prefixNama = "";
            switch (pIndex)
            {
                case 0:
                    prefixNama = "Tuan ";
                    break;
                case 1:
                    prefixNama = "Nyonya ";
                    break;
                case 3:
                    prefixNama = "Nona ";
                    break;
                default:
                    break;
            }

            return prefixNama;
        }
    }
}
