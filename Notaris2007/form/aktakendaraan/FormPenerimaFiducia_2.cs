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
    public partial class FormPenerimaFiducia_2 : Form
    {
        public FormPenerimaFiducia_2()
        {
            InitializeComponent();
        }

        private void lanjutButton_Click(object sender, EventArgs e)
        {
            new FormObjekFiducia_3().Visible = true;
            this.Visible = false;
        }
    }
}
