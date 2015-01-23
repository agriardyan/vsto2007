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
    public partial class FormObjekFiducia_3 : Form
    {
        public FormObjekFiducia_3()
        {
            InitializeComponent();
        }

        private void lanjutButton_Click(object sender, EventArgs e)
        {
            new FormSaksiFiducia_4().Visible = true;
            this.Visible = false;
        }
    }
}
