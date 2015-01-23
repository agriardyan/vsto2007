using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Notaris2007.form;

namespace Notaris2007
{
    public partial class RibbonNotaris
    {
        private void RibbonNotaris_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void aktaKendaraanButton_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.openDocument(0);
            new FormWaktu().Visible = true;
        }
    }
}
