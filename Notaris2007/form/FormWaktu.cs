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
            String[] read = dateTimePicker1.Text.Split('-');
            String day = "";
            String hari = Convert.ToString(dateTimePicker1.Value.DayOfWeek);

            switch (hari)
            {
                case "Monday":
                    day = "Senin";
                    break;
                case "Tuesday":
                    day = "Selasa";
                    break;
                case "Wednesday":
                    day = "Rabu";
                    break;
                case "Thursday":
                    day = "Kamis";
                    break;
                case "Friday":
                    day = "Jumat";
                    break;
                case "Saturday":
                    day = "Sabtu";
                    break;
                case "Sunday":
                    day = "Minggu";
                    break;
                default :
                    break;
            }

            String time = comboBox1.Text + "." + comboBox2.Text;

            String pembacaan = BacaBilangan.changeNumericToWords(read[0]) + 
                BacaBilangan.changeNumericToMonth(read[1]) +
                BacaBilangan.changeNumericToWords(read[2]);

            Globals.ThisAddIn.findReplace("$HARIAKTA", day);
            Globals.ThisAddIn.findReplace("$TANGGALAKTA", dateTimePicker1.Text);
            Globals.ThisAddIn.findReplace("$PEMBACAANTANGGALAKTA", pembacaan);
            
            new FormPemberiFiducia_1().Visible = true;
            this.Visible = false;
        }

    }
}
