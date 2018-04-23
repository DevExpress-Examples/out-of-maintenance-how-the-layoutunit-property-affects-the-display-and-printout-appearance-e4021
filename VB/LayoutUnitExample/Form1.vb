Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraRichEdit.API.Native

Namespace LayoutUnitExample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			richEditControl1.BeginUpdate()
			richEditControl2.BeginUpdate()

			richEditControl2.ReadOnly = True

			richEditControl1.LayoutUnit = DocumentLayoutUnit.Document
			richEditControl2.LayoutUnit = DocumentLayoutUnit.Pixel

			printControl1.PrintingSystem = printingSystem1
			printControl2.PrintingSystem = printingSystem2
			printableComponentLink1.PrintingSystem = printingSystem1
			printableComponentLink2.PrintingSystem = printingSystem2
			printableComponentLink1.Component = richEditControl1
			printableComponentLink2.Component = richEditControl2


			richEditControl1.LoadDocument("Styles.docx", DocumentFormat.OpenXml)
			richEditControl1.Document.Sections(0).Margins.Left = 80
			richEditControl1.Document.Sections(0).Margins.Top = 30

			richEditControl1.EndUpdate()
			richEditControl2.EndUpdate()

		End Sub

		Private Sub richEditControl1_ContentChanged(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl1.ContentChanged
			richEditControl2.BeginUpdate()
			richEditControl2.CreateNewDocument()
			richEditControl2.Document.Sections(0).Margins.Left = 80
			richEditControl2.Document.Sections(0).Margins.Top = 30
			richEditControl2.Document.AppendDocumentContent(richEditControl1.Document.Range)
			richEditControl2.EndUpdate()

			printableComponentLink1.CreateDocument(True)
			printableComponentLink2.CreateDocument(True)


		End Sub

	End Class
End Namespace
