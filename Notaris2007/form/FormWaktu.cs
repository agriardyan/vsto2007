using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Notaris2007.form.aktakendaraan;
using Notaris2007.helper;

namespace Notaris2007.form
{
    public partial class FormWaktu : Form
    {
        public FormWaktu()
        {
            InitializeComponent();
        }

        private void lanjutButton_Click(object sender, EventArgs e)
        {
            String day = BacaBilangan.changeToIndoDay(Convert.ToString(dateTimePicker1.Value.DayOfWeek));
            String jam = comboBox1.Text + "." + comboBox2.Text;

            String pembacaanHari = BacaBilangan.readTanggal(dateTimePicker1.Text);

            String pembacaanJam = BacaBilangan.readJam(jam);

            Globals.ThisAddIn.findReplace("$HARIAKTA", day);
            Globals.ThisAddIn.findReplace("$TANGGALAKTA", dateTimePicker1.Text);
            Globals.ThisAddIn.findReplace("$PEMBACAANTANGGALAKTA", pembacaanHari);
            Globals.ThisAddIn.findReplace("$JAMAKTA", jam);
            Globals.ThisAddIn.findReplace("$PEMBACAANJAMAKTA", pembacaanJam);
            
            new FormPemberiFiducia_1().Visible = true;
            this.Visible = false;
        }

    }
}
