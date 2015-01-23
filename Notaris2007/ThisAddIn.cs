using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using System.IO;

namespace Notaris2007
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        public void openDocument(int pDocumentType)
        {
            String startpath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\documenttemplate";
            String path = "";
            switch (pDocumentType)
            {
                case 0: // dokumen kendaraan
                    path = startpath + "\\aktakendaraan.docx";
                    this.Application.Documents.Open(@path, ReadOnly: true);
                    break;
                case 1: // dokumen tanah
                    //menyusul ; 
                    break;
                default:
                    //menyusul ; 
                    break;
            }
        }

        public void findReplace(String pOldText, String pNewText)
        {

            if (pOldText.Length <= 0) { return; }

            Word.Find findObject = Application.Selection.Find;
            findObject.ClearFormatting();
            findObject.Text = pOldText;
            findObject.Replacement.ClearFormatting();
            findObject.Replacement.Text = pNewText;

            object replaceAll = Word.WdReplace.wdReplaceAll;
            findObject.Execute(ref missing, ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing, ref missing,
                ref replaceAll, ref missing, ref missing, ref missing, ref missing);
        }

        public void spellNumber(long number)
        {

        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
