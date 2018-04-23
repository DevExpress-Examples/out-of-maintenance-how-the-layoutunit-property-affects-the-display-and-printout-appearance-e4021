using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;
using DevExpress.XtraPrinting;
using DevExpress.XtraRichEdit.API.Native;

namespace LayoutUnitExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            richEditControl1.BeginUpdate();
            richEditControl2.BeginUpdate();

            richEditControl2.ReadOnly = true;

            richEditControl1.LayoutUnit = DocumentLayoutUnit.Document;
            richEditControl2.LayoutUnit = DocumentLayoutUnit.Pixel;

            printControl1.PrintingSystem = printingSystem1;
            printControl2.PrintingSystem = printingSystem2;
            printableComponentLink1.PrintingSystem = printingSystem1;
            printableComponentLink2.PrintingSystem = printingSystem2;
            printableComponentLink1.Component = richEditControl1;
            printableComponentLink2.Component = richEditControl2;

           
            richEditControl1.LoadDocument("Styles.docx", DocumentFormat.OpenXml);
            richEditControl1.Document.Sections[0].Margins.Left = 80;
            richEditControl1.Document.Sections[0].Margins.Top = 30;

            richEditControl1.EndUpdate();
            richEditControl2.EndUpdate();

        }

        private void richEditControl1_ContentChanged(object sender, EventArgs e)
        {
            richEditControl2.BeginUpdate();
            richEditControl2.CreateNewDocument();
            richEditControl2.Document.Sections[0].Margins.Left = 80;
            richEditControl2.Document.Sections[0].Margins.Top = 30;
            richEditControl2.Document.AppendDocumentContent(richEditControl1.Document.Range);
            richEditControl2.EndUpdate();

            printableComponentLink1.CreateDocument(true);
            printableComponentLink2.CreateDocument(true);
 

        }

    }
}
