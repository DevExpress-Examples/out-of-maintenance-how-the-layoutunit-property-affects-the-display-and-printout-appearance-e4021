Imports Microsoft.VisualBasic
Imports System
Namespace LayoutUnitExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
			Me.printBarManager1 = New DevExpress.XtraPrinting.Preview.PrintBarManager(Me.components)
			Me.previewBar1 = New DevExpress.XtraPrinting.Preview.PreviewBar()
			Me.printPreviewBarItem2 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem3 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem4 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem5 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem6 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem7 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem8 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem9 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem10 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem11 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem12 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem13 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem14 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem15 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.zoomBarEditItem1 = New DevExpress.XtraPrinting.Preview.ZoomBarEditItem()
			Me.printPreviewRepositoryItemComboBox1 = New DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox()
			Me.printPreviewBarItem16 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem17 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem18 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem19 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem20 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem21 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem22 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem23 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem24 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem25 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem26 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.previewBar2 = New DevExpress.XtraPrinting.Preview.PreviewBar()
			Me.printPreviewStaticItem1 = New DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem()
			Me.barStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
			Me.progressBarEditItem1 = New DevExpress.XtraPrinting.Preview.ProgressBarEditItem()
			Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
			Me.printPreviewBarItem1 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.printPreviewStaticItem2 = New DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem()
			Me.zoomTrackBarEditItem1 = New DevExpress.XtraPrinting.Preview.ZoomTrackBarEditItem()
			Me.repositoryItemZoomTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar()
			Me.previewBar3 = New DevExpress.XtraPrinting.Preview.PreviewBar()
			Me.printPreviewSubItem1 = New DevExpress.XtraPrinting.Preview.PrintPreviewSubItem()
			Me.printPreviewSubItem2 = New DevExpress.XtraPrinting.Preview.PrintPreviewSubItem()
			Me.printPreviewSubItem4 = New DevExpress.XtraPrinting.Preview.PrintPreviewSubItem()
			Me.printPreviewBarItem27 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem28 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.barToolbarsListItem1 = New DevExpress.XtraBars.BarToolbarsListItem()
			Me.printPreviewSubItem3 = New DevExpress.XtraPrinting.Preview.PrintPreviewSubItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.printControl1 = New DevExpress.XtraPrinting.Control.PrintControl()
			Me.printingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
			Me.printableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
			Me.printPreviewBarCheckItem1 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem2 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem3 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem4 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem5 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem6 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem7 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem8 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem9 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem10 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem11 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem12 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem13 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem14 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem15 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem16 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem17 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.richEditControl2 = New DevExpress.XtraRichEdit.RichEditControl()
			Me.barDockControl1 = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControl2 = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControl3 = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControl4 = New DevExpress.XtraBars.BarDockControl()
			Me.printControl2 = New DevExpress.XtraPrinting.Control.PrintControl()
			Me.barDockControl7 = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControl8 = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControl6 = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControl5 = New DevExpress.XtraBars.BarDockControl()
			Me.printingSystem2 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
			Me.printableComponentLink2 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
			Me.printBarManager2 = New DevExpress.XtraPrinting.Preview.PrintBarManager(Me.components)
			Me.previewBar4 = New DevExpress.XtraPrinting.Preview.PreviewBar()
			Me.printPreviewBarItem30 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem31 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem32 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem33 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem34 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem35 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem36 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem37 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem38 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem39 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem40 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem41 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem42 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem43 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.zoomBarEditItem2 = New DevExpress.XtraPrinting.Preview.ZoomBarEditItem()
			Me.printPreviewRepositoryItemComboBox2 = New DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox()
			Me.printPreviewBarItem44 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem45 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem46 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem47 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem48 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem49 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem50 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem51 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem52 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem53 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem54 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.previewBar5 = New DevExpress.XtraPrinting.Preview.PreviewBar()
			Me.printPreviewStaticItem3 = New DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem()
			Me.barStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
			Me.progressBarEditItem2 = New DevExpress.XtraPrinting.Preview.ProgressBarEditItem()
			Me.repositoryItemProgressBar2 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
			Me.printPreviewBarItem29 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.printPreviewStaticItem4 = New DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem()
			Me.zoomTrackBarEditItem2 = New DevExpress.XtraPrinting.Preview.ZoomTrackBarEditItem()
			Me.repositoryItemZoomTrackBar2 = New DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar()
			Me.previewBar6 = New DevExpress.XtraPrinting.Preview.PreviewBar()
			Me.printPreviewSubItem5 = New DevExpress.XtraPrinting.Preview.PrintPreviewSubItem()
			Me.printPreviewSubItem6 = New DevExpress.XtraPrinting.Preview.PrintPreviewSubItem()
			Me.printPreviewSubItem8 = New DevExpress.XtraPrinting.Preview.PrintPreviewSubItem()
			Me.printPreviewBarItem55 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.printPreviewBarItem56 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarItem()
			Me.barToolbarsListItem2 = New DevExpress.XtraBars.BarToolbarsListItem()
			Me.printPreviewSubItem7 = New DevExpress.XtraPrinting.Preview.PrintPreviewSubItem()
			Me.printPreviewBarCheckItem18 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem19 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem20 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem21 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem22 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem23 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem24 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem25 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem26 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem27 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem28 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem29 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem30 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem31 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem32 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem33 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			Me.printPreviewBarCheckItem34 = New DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem()
			CType(Me.printBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.printPreviewRepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemZoomTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.printControl1.SuspendLayout()
			CType(Me.printingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.printControl2.SuspendLayout()
			CType(Me.printingSystem2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.printBarManager2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.printPreviewRepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemProgressBar2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemZoomTrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' richEditControl1
			' 
			Me.richEditControl1.Location = New System.Drawing.Point(0, 1)
			Me.richEditControl1.MenuManager = Me.printBarManager1
			Me.richEditControl1.Name = "richEditControl1"
			Me.richEditControl1.Size = New System.Drawing.Size(512, 362)
			Me.richEditControl1.TabIndex = 0
			Me.richEditControl1.Text = "richEditControl1"
'			Me.richEditControl1.ContentChanged += New System.EventHandler(Me.richEditControl1_ContentChanged);
			' 
			' printBarManager1
			' 
			Me.printBarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.previewBar1, Me.previewBar2, Me.previewBar3})
			Me.printBarManager1.DockControls.Add(Me.barDockControlTop)
			Me.printBarManager1.DockControls.Add(Me.barDockControlBottom)
			Me.printBarManager1.DockControls.Add(Me.barDockControlLeft)
			Me.printBarManager1.DockControls.Add(Me.barDockControlRight)
			Me.printBarManager1.Form = Me.printControl1
			Me.printBarManager1.ImageStream = (CType(resources.GetObject("printBarManager1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.printBarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.printPreviewStaticItem1, Me.barStaticItem1, Me.progressBarEditItem1, Me.printPreviewBarItem1, Me.barButtonItem1, Me.printPreviewStaticItem2, Me.zoomTrackBarEditItem1, Me.printPreviewBarItem2, Me.printPreviewBarItem3, Me.printPreviewBarItem4, Me.printPreviewBarItem5, Me.printPreviewBarItem6, Me.printPreviewBarItem7, Me.printPreviewBarItem8, Me.printPreviewBarItem9, Me.printPreviewBarItem10, Me.printPreviewBarItem11, Me.printPreviewBarItem12, Me.printPreviewBarItem13, Me.printPreviewBarItem14, Me.printPreviewBarItem15, Me.zoomBarEditItem1, Me.printPreviewBarItem16, Me.printPreviewBarItem17, Me.printPreviewBarItem18, Me.printPreviewBarItem19, Me.printPreviewBarItem20, Me.printPreviewBarItem21, Me.printPreviewBarItem22, Me.printPreviewBarItem23, Me.printPreviewBarItem24, Me.printPreviewBarItem25, Me.printPreviewBarItem26, Me.printPreviewSubItem1, Me.printPreviewSubItem2, Me.printPreviewSubItem3, Me.printPreviewSubItem4, Me.printPreviewBarItem27, Me.printPreviewBarItem28, Me.barToolbarsListItem1, Me.printPreviewBarCheckItem1, Me.printPreviewBarCheckItem2, Me.printPreviewBarCheckItem3, Me.printPreviewBarCheckItem4, Me.printPreviewBarCheckItem5, Me.printPreviewBarCheckItem6, Me.printPreviewBarCheckItem7, Me.printPreviewBarCheckItem8, Me.printPreviewBarCheckItem9, Me.printPreviewBarCheckItem10, Me.printPreviewBarCheckItem11, Me.printPreviewBarCheckItem12, Me.printPreviewBarCheckItem13, Me.printPreviewBarCheckItem14, Me.printPreviewBarCheckItem15, Me.printPreviewBarCheckItem16, Me.printPreviewBarCheckItem17})
			Me.printBarManager1.MainMenu = Me.previewBar3
			Me.printBarManager1.MaxItemId = 57
			Me.printBarManager1.PreviewBar = Me.previewBar1
			Me.printBarManager1.PrintControl = Me.printControl1
			Me.printBarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemProgressBar1, Me.repositoryItemZoomTrackBar1, Me.printPreviewRepositoryItemComboBox1})
			Me.printBarManager1.StatusBar = Me.previewBar2
			Me.printBarManager1.TransparentEditors = True
			' 
			' previewBar1
			' 
			Me.previewBar1.BarName = "Toolbar"
			Me.previewBar1.DockCol = 0
			Me.previewBar1.DockRow = 1
			Me.previewBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.previewBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem4), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem5, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem6, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem7), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem9), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem10), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem11), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem12), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem13, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem14), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem15, True), New DevExpress.XtraBars.LinkPersistInfo(Me.zoomBarEditItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem16), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem17, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem18), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem19), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem20), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem21, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem22), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem23), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem24, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem25), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem26, True)})
			Me.previewBar1.Text = "Toolbar"
			' 
			' printPreviewBarItem2
			' 
			Me.printPreviewBarItem2.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.printPreviewBarItem2.Caption = "Document Map"
			Me.printPreviewBarItem2.Command = DevExpress.XtraPrinting.PrintingSystemCommand.DocumentMap
			Me.printPreviewBarItem2.Enabled = False
			Me.printPreviewBarItem2.Hint = "Document Map"
			Me.printPreviewBarItem2.Id = 7
			Me.printPreviewBarItem2.ImageIndex = 19
			Me.printPreviewBarItem2.Name = "printPreviewBarItem2"
			Me.printPreviewBarItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
			' 
			' printPreviewBarItem3
			' 
			Me.printPreviewBarItem3.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.printPreviewBarItem3.Caption = "Parameters"
			Me.printPreviewBarItem3.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Parameters
			Me.printPreviewBarItem3.Enabled = False
			Me.printPreviewBarItem3.Hint = "Parameters"
			Me.printPreviewBarItem3.Id = 8
			Me.printPreviewBarItem3.ImageIndex = 22
			Me.printPreviewBarItem3.Name = "printPreviewBarItem3"
			Me.printPreviewBarItem3.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
			' 
			' printPreviewBarItem4
			' 
			Me.printPreviewBarItem4.Caption = "Search"
			Me.printPreviewBarItem4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Find
			Me.printPreviewBarItem4.Enabled = False
			Me.printPreviewBarItem4.Hint = "Search"
			Me.printPreviewBarItem4.Id = 9
			Me.printPreviewBarItem4.ImageIndex = 20
			Me.printPreviewBarItem4.Name = "printPreviewBarItem4"
			' 
			' printPreviewBarItem5
			' 
			Me.printPreviewBarItem5.Caption = "Customize"
			Me.printPreviewBarItem5.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Customize
			Me.printPreviewBarItem5.Enabled = False
			Me.printPreviewBarItem5.Hint = "Customize"
			Me.printPreviewBarItem5.Id = 10
			Me.printPreviewBarItem5.ImageIndex = 14
			Me.printPreviewBarItem5.Name = "printPreviewBarItem5"
			' 
			' printPreviewBarItem6
			' 
			Me.printPreviewBarItem6.Caption = "Open"
			Me.printPreviewBarItem6.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Open
			Me.printPreviewBarItem6.Hint = "Open a document"
			Me.printPreviewBarItem6.Id = 11
			Me.printPreviewBarItem6.ImageIndex = 23
			Me.printPreviewBarItem6.Name = "printPreviewBarItem6"
			' 
			' printPreviewBarItem7
			' 
			Me.printPreviewBarItem7.Caption = "Save"
			Me.printPreviewBarItem7.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Save
			Me.printPreviewBarItem7.Enabled = False
			Me.printPreviewBarItem7.Hint = "Save the document"
			Me.printPreviewBarItem7.Id = 12
			Me.printPreviewBarItem7.ImageIndex = 24
			Me.printPreviewBarItem7.Name = "printPreviewBarItem7"
			' 
			' printPreviewBarItem8
			' 
			Me.printPreviewBarItem8.Caption = "&Print..."
			Me.printPreviewBarItem8.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Print
			Me.printPreviewBarItem8.Enabled = False
			Me.printPreviewBarItem8.Hint = "Print"
			Me.printPreviewBarItem8.Id = 13
			Me.printPreviewBarItem8.ImageIndex = 0
			Me.printPreviewBarItem8.Name = "printPreviewBarItem8"
			' 
			' printPreviewBarItem9
			' 
			Me.printPreviewBarItem9.Caption = "P&rint"
			Me.printPreviewBarItem9.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect
			Me.printPreviewBarItem9.Enabled = False
			Me.printPreviewBarItem9.Hint = "Quick Print"
			Me.printPreviewBarItem9.Id = 14
			Me.printPreviewBarItem9.ImageIndex = 1
			Me.printPreviewBarItem9.Name = "printPreviewBarItem9"
			' 
			' printPreviewBarItem10
			' 
			Me.printPreviewBarItem10.Caption = "Page Set&up..."
			Me.printPreviewBarItem10.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageSetup
			Me.printPreviewBarItem10.Enabled = False
			Me.printPreviewBarItem10.Hint = "Page Setup"
			Me.printPreviewBarItem10.Id = 15
			Me.printPreviewBarItem10.ImageIndex = 2
			Me.printPreviewBarItem10.Name = "printPreviewBarItem10"
			' 
			' printPreviewBarItem11
			' 
			Me.printPreviewBarItem11.Caption = "Header And Footer"
			Me.printPreviewBarItem11.Command = DevExpress.XtraPrinting.PrintingSystemCommand.EditPageHF
			Me.printPreviewBarItem11.Enabled = False
			Me.printPreviewBarItem11.Hint = "Header And Footer"
			Me.printPreviewBarItem11.Id = 16
			Me.printPreviewBarItem11.ImageIndex = 15
			Me.printPreviewBarItem11.Name = "printPreviewBarItem11"
			' 
			' printPreviewBarItem12
			' 
			Me.printPreviewBarItem12.ActAsDropDown = True
			Me.printPreviewBarItem12.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.printPreviewBarItem12.Caption = "Scale"
			Me.printPreviewBarItem12.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Scale
			Me.printPreviewBarItem12.Enabled = False
			Me.printPreviewBarItem12.Hint = "Scale"
			Me.printPreviewBarItem12.Id = 17
			Me.printPreviewBarItem12.ImageIndex = 25
			Me.printPreviewBarItem12.Name = "printPreviewBarItem12"
			' 
			' printPreviewBarItem13
			' 
			Me.printPreviewBarItem13.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.printPreviewBarItem13.Caption = "Hand Tool"
			Me.printPreviewBarItem13.Command = DevExpress.XtraPrinting.PrintingSystemCommand.HandTool
			Me.printPreviewBarItem13.Enabled = False
			Me.printPreviewBarItem13.Hint = "Hand Tool"
			Me.printPreviewBarItem13.Id = 18
			Me.printPreviewBarItem13.ImageIndex = 16
			Me.printPreviewBarItem13.Name = "printPreviewBarItem13"
			' 
			' printPreviewBarItem14
			' 
			Me.printPreviewBarItem14.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.printPreviewBarItem14.Caption = "Magnifier"
			Me.printPreviewBarItem14.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Magnifier
			Me.printPreviewBarItem14.Enabled = False
			Me.printPreviewBarItem14.Hint = "Magnifier"
			Me.printPreviewBarItem14.Id = 19
			Me.printPreviewBarItem14.ImageIndex = 3
			Me.printPreviewBarItem14.Name = "printPreviewBarItem14"
			' 
			' printPreviewBarItem15
			' 
			Me.printPreviewBarItem15.Caption = "Zoom Out"
			Me.printPreviewBarItem15.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomOut
			Me.printPreviewBarItem15.Enabled = False
			Me.printPreviewBarItem15.Hint = "Zoom Out"
			Me.printPreviewBarItem15.Id = 20
			Me.printPreviewBarItem15.ImageIndex = 5
			Me.printPreviewBarItem15.Name = "printPreviewBarItem15"
			' 
			' zoomBarEditItem1
			' 
			Me.zoomBarEditItem1.Caption = "Zoom"
			Me.zoomBarEditItem1.Edit = Me.printPreviewRepositoryItemComboBox1
			Me.zoomBarEditItem1.EditValue = "100%"
			Me.zoomBarEditItem1.Enabled = False
			Me.zoomBarEditItem1.Hint = "Zoom"
			Me.zoomBarEditItem1.Id = 21
			Me.zoomBarEditItem1.Name = "zoomBarEditItem1"
			Me.zoomBarEditItem1.Width = 70
			' 
			' printPreviewRepositoryItemComboBox1
			' 
			Me.printPreviewRepositoryItemComboBox1.AutoComplete = False
			Me.printPreviewRepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.printPreviewRepositoryItemComboBox1.DropDownRows = 11
			Me.printPreviewRepositoryItemComboBox1.Name = "printPreviewRepositoryItemComboBox1"
			Me.printPreviewRepositoryItemComboBox1.UseParentBackground = True
			' 
			' printPreviewBarItem16
			' 
			Me.printPreviewBarItem16.Caption = "Zoom In"
			Me.printPreviewBarItem16.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomIn
			Me.printPreviewBarItem16.Enabled = False
			Me.printPreviewBarItem16.Hint = "Zoom In"
			Me.printPreviewBarItem16.Id = 22
			Me.printPreviewBarItem16.ImageIndex = 4
			Me.printPreviewBarItem16.Name = "printPreviewBarItem16"
			' 
			' printPreviewBarItem17
			' 
			Me.printPreviewBarItem17.Caption = "First Page"
			Me.printPreviewBarItem17.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowFirstPage
			Me.printPreviewBarItem17.Enabled = False
			Me.printPreviewBarItem17.Hint = "First Page"
			Me.printPreviewBarItem17.Id = 23
			Me.printPreviewBarItem17.ImageIndex = 7
			Me.printPreviewBarItem17.Name = "printPreviewBarItem17"
			' 
			' printPreviewBarItem18
			' 
			Me.printPreviewBarItem18.Caption = "Previous Page"
			Me.printPreviewBarItem18.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowPrevPage
			Me.printPreviewBarItem18.Enabled = False
			Me.printPreviewBarItem18.Hint = "Previous Page"
			Me.printPreviewBarItem18.Id = 24
			Me.printPreviewBarItem18.ImageIndex = 8
			Me.printPreviewBarItem18.Name = "printPreviewBarItem18"
			' 
			' printPreviewBarItem19
			' 
			Me.printPreviewBarItem19.Caption = "Next Page"
			Me.printPreviewBarItem19.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowNextPage
			Me.printPreviewBarItem19.Enabled = False
			Me.printPreviewBarItem19.Hint = "Next Page"
			Me.printPreviewBarItem19.Id = 25
			Me.printPreviewBarItem19.ImageIndex = 9
			Me.printPreviewBarItem19.Name = "printPreviewBarItem19"
			' 
			' printPreviewBarItem20
			' 
			Me.printPreviewBarItem20.Caption = "Last Page"
			Me.printPreviewBarItem20.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowLastPage
			Me.printPreviewBarItem20.Enabled = False
			Me.printPreviewBarItem20.Hint = "Last Page"
			Me.printPreviewBarItem20.Id = 26
			Me.printPreviewBarItem20.ImageIndex = 10
			Me.printPreviewBarItem20.Name = "printPreviewBarItem20"
			' 
			' printPreviewBarItem21
			' 
			Me.printPreviewBarItem21.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.printPreviewBarItem21.Caption = "Multiple Pages"
			Me.printPreviewBarItem21.Command = DevExpress.XtraPrinting.PrintingSystemCommand.MultiplePages
			Me.printPreviewBarItem21.Enabled = False
			Me.printPreviewBarItem21.Hint = "Multiple Pages"
			Me.printPreviewBarItem21.Id = 27
			Me.printPreviewBarItem21.ImageIndex = 11
			Me.printPreviewBarItem21.Name = "printPreviewBarItem21"
			' 
			' printPreviewBarItem22
			' 
			Me.printPreviewBarItem22.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.printPreviewBarItem22.Caption = "&Color..."
			Me.printPreviewBarItem22.Command = DevExpress.XtraPrinting.PrintingSystemCommand.FillBackground
			Me.printPreviewBarItem22.Enabled = False
			Me.printPreviewBarItem22.Hint = "Background"
			Me.printPreviewBarItem22.Id = 28
			Me.printPreviewBarItem22.ImageIndex = 12
			Me.printPreviewBarItem22.Name = "printPreviewBarItem22"
			' 
			' printPreviewBarItem23
			' 
			Me.printPreviewBarItem23.Caption = "&Watermark..."
			Me.printPreviewBarItem23.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Watermark
			Me.printPreviewBarItem23.Enabled = False
			Me.printPreviewBarItem23.Hint = "Watermark"
			Me.printPreviewBarItem23.Id = 29
			Me.printPreviewBarItem23.ImageIndex = 21
			Me.printPreviewBarItem23.Name = "printPreviewBarItem23"
			' 
			' printPreviewBarItem24
			' 
			Me.printPreviewBarItem24.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.printPreviewBarItem24.Caption = "Export Document..."
			Me.printPreviewBarItem24.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportFile
			Me.printPreviewBarItem24.Enabled = False
			Me.printPreviewBarItem24.Hint = "Export Document..."
			Me.printPreviewBarItem24.Id = 30
			Me.printPreviewBarItem24.ImageIndex = 18
			Me.printPreviewBarItem24.Name = "printPreviewBarItem24"
			' 
			' printPreviewBarItem25
			' 
			Me.printPreviewBarItem25.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.printPreviewBarItem25.Caption = "Send via E-Mail..."
			Me.printPreviewBarItem25.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendFile
			Me.printPreviewBarItem25.Enabled = False
			Me.printPreviewBarItem25.Hint = "Send via E-Mail..."
			Me.printPreviewBarItem25.Id = 31
			Me.printPreviewBarItem25.ImageIndex = 17
			Me.printPreviewBarItem25.Name = "printPreviewBarItem25"
			' 
			' printPreviewBarItem26
			' 
			Me.printPreviewBarItem26.Caption = "E&xit"
			Me.printPreviewBarItem26.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ClosePreview
			Me.printPreviewBarItem26.Hint = "Close Preview"
			Me.printPreviewBarItem26.Id = 32
			Me.printPreviewBarItem26.ImageIndex = 13
			Me.printPreviewBarItem26.Name = "printPreviewBarItem26"
			' 
			' previewBar2
			' 
			Me.previewBar2.BarName = "Status Bar"
			Me.previewBar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
			Me.previewBar2.DockCol = 0
			Me.previewBar2.DockRow = 0
			Me.previewBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
			Me.previewBar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barStaticItem1, True), New DevExpress.XtraBars.LinkPersistInfo(Me.progressBarEditItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewStaticItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.zoomTrackBarEditItem1)})
			Me.previewBar2.OptionsBar.AllowQuickCustomization = False
			Me.previewBar2.OptionsBar.DrawDragBorder = False
			Me.previewBar2.OptionsBar.UseWholeRow = True
			Me.previewBar2.Text = "Status Bar"
			' 
			' printPreviewStaticItem1
			' 
			Me.printPreviewStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.printPreviewStaticItem1.Caption = "Nothing"
			Me.printPreviewStaticItem1.Id = 0
			Me.printPreviewStaticItem1.LeftIndent = 1
			Me.printPreviewStaticItem1.Name = "printPreviewStaticItem1"
			Me.printPreviewStaticItem1.RightIndent = 1
			Me.printPreviewStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
			Me.printPreviewStaticItem1.Type = "PageOfPages"
			' 
			' barStaticItem1
			' 
			Me.barStaticItem1.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.barStaticItem1.Id = 1
			Me.barStaticItem1.Name = "barStaticItem1"
			Me.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
			Me.barStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime
			' 
			' progressBarEditItem1
			' 
			Me.progressBarEditItem1.Edit = Me.repositoryItemProgressBar1
			Me.progressBarEditItem1.EditHeight = 12
			Me.progressBarEditItem1.Id = 2
			Me.progressBarEditItem1.Name = "progressBarEditItem1"
			Me.progressBarEditItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
			Me.progressBarEditItem1.Width = 150
			' 
			' repositoryItemProgressBar1
			' 
			Me.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
			Me.repositoryItemProgressBar1.UseParentBackground = True
			' 
			' printPreviewBarItem1
			' 
			Me.printPreviewBarItem1.Caption = "Stop"
			Me.printPreviewBarItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.StopPageBuilding
			Me.printPreviewBarItem1.Enabled = False
			Me.printPreviewBarItem1.Hint = "Stop"
			Me.printPreviewBarItem1.Id = 3
			Me.printPreviewBarItem1.Name = "printPreviewBarItem1"
			Me.printPreviewBarItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
			Me.barButtonItem1.Enabled = False
			Me.barButtonItem1.Id = 4
			Me.barButtonItem1.Name = "barButtonItem1"
			Me.barButtonItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime
			' 
			' printPreviewStaticItem2
			' 
			Me.printPreviewStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.printPreviewStaticItem2.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.printPreviewStaticItem2.Caption = "100%"
			Me.printPreviewStaticItem2.Id = 5
			Me.printPreviewStaticItem2.Name = "printPreviewStaticItem2"
			Me.printPreviewStaticItem2.TextAlignment = System.Drawing.StringAlignment.Far
			Me.printPreviewStaticItem2.Type = "ZoomFactor"
			Me.printPreviewStaticItem2.Width = 40
			' 
			' zoomTrackBarEditItem1
			' 
			Me.zoomTrackBarEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.zoomTrackBarEditItem1.Edit = Me.repositoryItemZoomTrackBar1
			Me.zoomTrackBarEditItem1.EditValue = 90
			Me.zoomTrackBarEditItem1.Enabled = False
			Me.zoomTrackBarEditItem1.Id = 6
			Me.zoomTrackBarEditItem1.Name = "zoomTrackBarEditItem1"
			Me.zoomTrackBarEditItem1.Range = New Integer() { 10, 500}
			Me.zoomTrackBarEditItem1.Width = 140
			' 
			' repositoryItemZoomTrackBar1
			' 
			Me.repositoryItemZoomTrackBar1.Alignment = DevExpress.Utils.VertAlignment.Center
			Me.repositoryItemZoomTrackBar1.AllowFocused = False
			Me.repositoryItemZoomTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemZoomTrackBar1.Maximum = 180
			Me.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1"
			Me.repositoryItemZoomTrackBar1.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
			Me.repositoryItemZoomTrackBar1.UseParentBackground = True
			' 
			' previewBar3
			' 
			Me.previewBar3.BarName = "Main Menu"
			Me.previewBar3.DockCol = 0
			Me.previewBar3.DockRow = 0
			Me.previewBar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.previewBar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewSubItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewSubItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewSubItem3)})
			Me.previewBar3.OptionsBar.MultiLine = True
			Me.previewBar3.OptionsBar.UseWholeRow = True
			Me.previewBar3.Text = "Main Menu"
			' 
			' printPreviewSubItem1
			' 
			Me.printPreviewSubItem1.Caption = "&File"
			Me.printPreviewSubItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.File
			Me.printPreviewSubItem1.Id = 33
			Me.printPreviewSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem10), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem8), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem9), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem24, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem25), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem26, True)})
			Me.printPreviewSubItem1.Name = "printPreviewSubItem1"
			' 
			' printPreviewSubItem2
			' 
			Me.printPreviewSubItem2.Caption = "&View"
			Me.printPreviewSubItem2.Command = DevExpress.XtraPrinting.PrintingSystemCommand.View
			Me.printPreviewSubItem2.Id = 34
			Me.printPreviewSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewSubItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barToolbarsListItem1, True)})
			Me.printPreviewSubItem2.Name = "printPreviewSubItem2"
			' 
			' printPreviewSubItem4
			' 
			Me.printPreviewSubItem4.Caption = "&Page Layout"
			Me.printPreviewSubItem4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayout
			Me.printPreviewSubItem4.Id = 36
			Me.printPreviewSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem27), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem28)})
			Me.printPreviewSubItem4.Name = "printPreviewSubItem4"
			' 
			' printPreviewBarItem27
			' 
			Me.printPreviewBarItem27.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.printPreviewBarItem27.Caption = "&Facing"
			Me.printPreviewBarItem27.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutFacing
			Me.printPreviewBarItem27.Enabled = False
			Me.printPreviewBarItem27.GroupIndex = 100
			Me.printPreviewBarItem27.Id = 37
			Me.printPreviewBarItem27.Name = "printPreviewBarItem27"
			' 
			' printPreviewBarItem28
			' 
			Me.printPreviewBarItem28.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.printPreviewBarItem28.Caption = "&Continuous"
			Me.printPreviewBarItem28.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutContinuous
			Me.printPreviewBarItem28.Enabled = False
			Me.printPreviewBarItem28.GroupIndex = 100
			Me.printPreviewBarItem28.Id = 38
			Me.printPreviewBarItem28.Name = "printPreviewBarItem28"
			' 
			' barToolbarsListItem1
			' 
			Me.barToolbarsListItem1.Caption = "Bars"
			Me.barToolbarsListItem1.Id = 39
			Me.barToolbarsListItem1.Name = "barToolbarsListItem1"
			' 
			' printPreviewSubItem3
			' 
			Me.printPreviewSubItem3.Caption = "&Background"
			Me.printPreviewSubItem3.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Background
			Me.printPreviewSubItem3.Id = 35
			Me.printPreviewSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem22), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem23)})
			Me.printPreviewSubItem3.Name = "printPreviewSubItem3"
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(488, 53)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 331)
			Me.barDockControlBottom.Size = New System.Drawing.Size(488, 28)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 53)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 278)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(488, 53)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 278)
			' 
			' printControl1
			' 
			Me.printControl1.BackColor = System.Drawing.Color.Empty
			Me.printControl1.Controls.Add(Me.barDockControlLeft)
			Me.printControl1.Controls.Add(Me.barDockControlRight)
			Me.printControl1.Controls.Add(Me.barDockControlBottom)
			Me.printControl1.Controls.Add(Me.barDockControlTop)
			Me.printControl1.ForeColor = System.Drawing.Color.Empty
			Me.printControl1.IsMetric = False
			Me.printControl1.Location = New System.Drawing.Point(518, 4)
			Me.printControl1.Name = "printControl1"
			Me.printControl1.PrintingSystem = Me.printingSystem1
			Me.printControl1.Size = New System.Drawing.Size(488, 359)
			Me.printControl1.TabIndex = 2
			Me.printControl1.TooltipFont = New System.Drawing.Font("Tahoma", 8.25F)
			' 
			' printingSystem1
			' 
			Me.printingSystem1.Links.AddRange(New Object() { Me.printableComponentLink1})
			' 
			' printableComponentLink1
			' 
			Me.printableComponentLink1.Component = Me.richEditControl1
			' 
			' 
			' 
			Me.printableComponentLink1.ImageCollection.ImageStream = (CType(resources.GetObject("printableComponentLink1.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.printableComponentLink1.PrintingSystem = Me.printingSystem1
			Me.printableComponentLink1.PrintingSystemBase = Me.printingSystem1
			' 
			' printPreviewBarCheckItem1
			' 
			Me.printPreviewBarCheckItem1.Caption = "PDF File"
			Me.printPreviewBarCheckItem1.Checked = True
			Me.printPreviewBarCheckItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportPdf
			Me.printPreviewBarCheckItem1.Enabled = False
			Me.printPreviewBarCheckItem1.GroupIndex = 2
			Me.printPreviewBarCheckItem1.Hint = "PDF File"
			Me.printPreviewBarCheckItem1.Id = 40
			Me.printPreviewBarCheckItem1.Name = "printPreviewBarCheckItem1"
			' 
			' printPreviewBarCheckItem2
			' 
			Me.printPreviewBarCheckItem2.Caption = "HTML File"
			Me.printPreviewBarCheckItem2.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportHtm
			Me.printPreviewBarCheckItem2.Enabled = False
			Me.printPreviewBarCheckItem2.GroupIndex = 2
			Me.printPreviewBarCheckItem2.Hint = "HTML File"
			Me.printPreviewBarCheckItem2.Id = 41
			Me.printPreviewBarCheckItem2.Name = "printPreviewBarCheckItem2"
			' 
			' printPreviewBarCheckItem3
			' 
			Me.printPreviewBarCheckItem3.Caption = "MHT File"
			Me.printPreviewBarCheckItem3.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportMht
			Me.printPreviewBarCheckItem3.Enabled = False
			Me.printPreviewBarCheckItem3.GroupIndex = 2
			Me.printPreviewBarCheckItem3.Hint = "MHT File"
			Me.printPreviewBarCheckItem3.Id = 42
			Me.printPreviewBarCheckItem3.Name = "printPreviewBarCheckItem3"
			' 
			' printPreviewBarCheckItem4
			' 
			Me.printPreviewBarCheckItem4.Caption = "RTF File"
			Me.printPreviewBarCheckItem4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportRtf
			Me.printPreviewBarCheckItem4.Enabled = False
			Me.printPreviewBarCheckItem4.GroupIndex = 2
			Me.printPreviewBarCheckItem4.Hint = "RTF File"
			Me.printPreviewBarCheckItem4.Id = 43
			Me.printPreviewBarCheckItem4.Name = "printPreviewBarCheckItem4"
			' 
			' printPreviewBarCheckItem5
			' 
			Me.printPreviewBarCheckItem5.Caption = "XLS File"
			Me.printPreviewBarCheckItem5.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXls
			Me.printPreviewBarCheckItem5.Enabled = False
			Me.printPreviewBarCheckItem5.GroupIndex = 2
			Me.printPreviewBarCheckItem5.Hint = "XLS File"
			Me.printPreviewBarCheckItem5.Id = 44
			Me.printPreviewBarCheckItem5.Name = "printPreviewBarCheckItem5"
			' 
			' printPreviewBarCheckItem6
			' 
			Me.printPreviewBarCheckItem6.Caption = "XLSX File"
			Me.printPreviewBarCheckItem6.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXlsx
			Me.printPreviewBarCheckItem6.Enabled = False
			Me.printPreviewBarCheckItem6.GroupIndex = 2
			Me.printPreviewBarCheckItem6.Hint = "XLSX File"
			Me.printPreviewBarCheckItem6.Id = 45
			Me.printPreviewBarCheckItem6.Name = "printPreviewBarCheckItem6"
			' 
			' printPreviewBarCheckItem7
			' 
			Me.printPreviewBarCheckItem7.Caption = "CSV File"
			Me.printPreviewBarCheckItem7.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportCsv
			Me.printPreviewBarCheckItem7.Enabled = False
			Me.printPreviewBarCheckItem7.GroupIndex = 2
			Me.printPreviewBarCheckItem7.Hint = "CSV File"
			Me.printPreviewBarCheckItem7.Id = 46
			Me.printPreviewBarCheckItem7.Name = "printPreviewBarCheckItem7"
			' 
			' printPreviewBarCheckItem8
			' 
			Me.printPreviewBarCheckItem8.Caption = "Text File"
			Me.printPreviewBarCheckItem8.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportTxt
			Me.printPreviewBarCheckItem8.Enabled = False
			Me.printPreviewBarCheckItem8.GroupIndex = 2
			Me.printPreviewBarCheckItem8.Hint = "Text File"
			Me.printPreviewBarCheckItem8.Id = 47
			Me.printPreviewBarCheckItem8.Name = "printPreviewBarCheckItem8"
			' 
			' printPreviewBarCheckItem9
			' 
			Me.printPreviewBarCheckItem9.Caption = "Image File"
			Me.printPreviewBarCheckItem9.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportGraphic
			Me.printPreviewBarCheckItem9.Enabled = False
			Me.printPreviewBarCheckItem9.GroupIndex = 2
			Me.printPreviewBarCheckItem9.Hint = "Image File"
			Me.printPreviewBarCheckItem9.Id = 48
			Me.printPreviewBarCheckItem9.Name = "printPreviewBarCheckItem9"
			' 
			' printPreviewBarCheckItem10
			' 
			Me.printPreviewBarCheckItem10.Caption = "PDF File"
			Me.printPreviewBarCheckItem10.Checked = True
			Me.printPreviewBarCheckItem10.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendPdf
			Me.printPreviewBarCheckItem10.Enabled = False
			Me.printPreviewBarCheckItem10.GroupIndex = 1
			Me.printPreviewBarCheckItem10.Hint = "PDF File"
			Me.printPreviewBarCheckItem10.Id = 49
			Me.printPreviewBarCheckItem10.Name = "printPreviewBarCheckItem10"
			' 
			' printPreviewBarCheckItem11
			' 
			Me.printPreviewBarCheckItem11.Caption = "MHT File"
			Me.printPreviewBarCheckItem11.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendMht
			Me.printPreviewBarCheckItem11.Enabled = False
			Me.printPreviewBarCheckItem11.GroupIndex = 1
			Me.printPreviewBarCheckItem11.Hint = "MHT File"
			Me.printPreviewBarCheckItem11.Id = 50
			Me.printPreviewBarCheckItem11.Name = "printPreviewBarCheckItem11"
			' 
			' printPreviewBarCheckItem12
			' 
			Me.printPreviewBarCheckItem12.Caption = "RTF File"
			Me.printPreviewBarCheckItem12.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendRtf
			Me.printPreviewBarCheckItem12.Enabled = False
			Me.printPreviewBarCheckItem12.GroupIndex = 1
			Me.printPreviewBarCheckItem12.Hint = "RTF File"
			Me.printPreviewBarCheckItem12.Id = 51
			Me.printPreviewBarCheckItem12.Name = "printPreviewBarCheckItem12"
			' 
			' printPreviewBarCheckItem13
			' 
			Me.printPreviewBarCheckItem13.Caption = "XLS File"
			Me.printPreviewBarCheckItem13.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXls
			Me.printPreviewBarCheckItem13.Enabled = False
			Me.printPreviewBarCheckItem13.GroupIndex = 1
			Me.printPreviewBarCheckItem13.Hint = "XLS File"
			Me.printPreviewBarCheckItem13.Id = 52
			Me.printPreviewBarCheckItem13.Name = "printPreviewBarCheckItem13"
			' 
			' printPreviewBarCheckItem14
			' 
			Me.printPreviewBarCheckItem14.Caption = "XLSX File"
			Me.printPreviewBarCheckItem14.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXlsx
			Me.printPreviewBarCheckItem14.Enabled = False
			Me.printPreviewBarCheckItem14.GroupIndex = 1
			Me.printPreviewBarCheckItem14.Hint = "XLSX File"
			Me.printPreviewBarCheckItem14.Id = 53
			Me.printPreviewBarCheckItem14.Name = "printPreviewBarCheckItem14"
			' 
			' printPreviewBarCheckItem15
			' 
			Me.printPreviewBarCheckItem15.Caption = "CSV File"
			Me.printPreviewBarCheckItem15.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendCsv
			Me.printPreviewBarCheckItem15.Enabled = False
			Me.printPreviewBarCheckItem15.GroupIndex = 1
			Me.printPreviewBarCheckItem15.Hint = "CSV File"
			Me.printPreviewBarCheckItem15.Id = 54
			Me.printPreviewBarCheckItem15.Name = "printPreviewBarCheckItem15"
			' 
			' printPreviewBarCheckItem16
			' 
			Me.printPreviewBarCheckItem16.Caption = "Text File"
			Me.printPreviewBarCheckItem16.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendTxt
			Me.printPreviewBarCheckItem16.Enabled = False
			Me.printPreviewBarCheckItem16.GroupIndex = 1
			Me.printPreviewBarCheckItem16.Hint = "Text File"
			Me.printPreviewBarCheckItem16.Id = 55
			Me.printPreviewBarCheckItem16.Name = "printPreviewBarCheckItem16"
			' 
			' printPreviewBarCheckItem17
			' 
			Me.printPreviewBarCheckItem17.Caption = "Image File"
			Me.printPreviewBarCheckItem17.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendGraphic
			Me.printPreviewBarCheckItem17.Enabled = False
			Me.printPreviewBarCheckItem17.GroupIndex = 1
			Me.printPreviewBarCheckItem17.Hint = "Image File"
			Me.printPreviewBarCheckItem17.Id = 56
			Me.printPreviewBarCheckItem17.Name = "printPreviewBarCheckItem17"
			' 
			' richEditControl2
			' 
			Me.richEditControl2.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel
			Me.richEditControl2.Location = New System.Drawing.Point(1, 365)
			Me.richEditControl2.MenuManager = Me.printBarManager1
			Me.richEditControl2.Name = "richEditControl2"
			Me.richEditControl2.ReadOnly = True
			Me.richEditControl2.Size = New System.Drawing.Size(512, 362)
			Me.richEditControl2.TabIndex = 1
			Me.richEditControl2.Text = "richEditControl2"
			' 
			' barDockControl1
			' 
			Me.barDockControl1.CausesValidation = False
			Me.barDockControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControl1.Location = New System.Drawing.Point(0, 53)
			Me.barDockControl1.Size = New System.Drawing.Size(0, 282)
			' 
			' barDockControl2
			' 
			Me.barDockControl2.CausesValidation = False
			Me.barDockControl2.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControl2.Location = New System.Drawing.Point(487, 53)
			Me.barDockControl2.Size = New System.Drawing.Size(0, 282)
			' 
			' barDockControl3
			' 
			Me.barDockControl3.CausesValidation = False
			Me.barDockControl3.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControl3.Location = New System.Drawing.Point(0, 335)
			Me.barDockControl3.Size = New System.Drawing.Size(487, 28)
			' 
			' barDockControl4
			' 
			Me.barDockControl4.CausesValidation = False
			Me.barDockControl4.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControl4.Location = New System.Drawing.Point(0, 0)
			Me.barDockControl4.Size = New System.Drawing.Size(487, 53)
			' 
			' printControl2
			' 
			Me.printControl2.BackColor = System.Drawing.Color.Empty
			Me.printControl2.Controls.Add(Me.barDockControl7)
			Me.printControl2.Controls.Add(Me.barDockControl8)
			Me.printControl2.Controls.Add(Me.barDockControl6)
			Me.printControl2.Controls.Add(Me.barDockControl5)
			Me.printControl2.ForeColor = System.Drawing.Color.Empty
			Me.printControl2.IsMetric = False
			Me.printControl2.Location = New System.Drawing.Point(519, 382)
			Me.printControl2.Name = "printControl2"
			Me.printControl2.PrintingSystem = Me.printingSystem2
			Me.printControl2.Size = New System.Drawing.Size(489, 345)
			Me.printControl2.TabIndex = 3
			Me.printControl2.TooltipFont = New System.Drawing.Font("Tahoma", 8.25F)
			' 
			' barDockControl7
			' 
			Me.barDockControl7.CausesValidation = False
			Me.barDockControl7.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControl7.Location = New System.Drawing.Point(0, 53)
			Me.barDockControl7.Size = New System.Drawing.Size(0, 264)
			' 
			' barDockControl8
			' 
			Me.barDockControl8.CausesValidation = False
			Me.barDockControl8.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControl8.Location = New System.Drawing.Point(489, 53)
			Me.barDockControl8.Size = New System.Drawing.Size(0, 264)
			' 
			' barDockControl6
			' 
			Me.barDockControl6.CausesValidation = False
			Me.barDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControl6.Location = New System.Drawing.Point(0, 317)
			Me.barDockControl6.Size = New System.Drawing.Size(489, 28)
			' 
			' barDockControl5
			' 
			Me.barDockControl5.CausesValidation = False
			Me.barDockControl5.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControl5.Location = New System.Drawing.Point(0, 0)
			Me.barDockControl5.Size = New System.Drawing.Size(489, 53)
			' 
			' printingSystem2
			' 
			Me.printingSystem2.Links.AddRange(New Object() { Me.printableComponentLink2})
			' 
			' printableComponentLink2
			' 
			Me.printableComponentLink2.Component = Me.richEditControl2
			' 
			' 
			' 
			Me.printableComponentLink2.ImageCollection.ImageStream = (CType(resources.GetObject("printableComponentLink2.ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.printableComponentLink2.PrintingSystem = Me.printingSystem2
			Me.printableComponentLink2.PrintingSystemBase = Me.printingSystem2
			' 
			' printBarManager2
			' 
			Me.printBarManager2.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.previewBar4, Me.previewBar5, Me.previewBar6})
			Me.printBarManager2.DockControls.Add(Me.barDockControl5)
			Me.printBarManager2.DockControls.Add(Me.barDockControl6)
			Me.printBarManager2.DockControls.Add(Me.barDockControl7)
			Me.printBarManager2.DockControls.Add(Me.barDockControl8)
			Me.printBarManager2.Form = Me.printControl2
			Me.printBarManager2.ImageStream = (CType(resources.GetObject("printBarManager2.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.printBarManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.printPreviewStaticItem3, Me.barStaticItem2, Me.progressBarEditItem2, Me.printPreviewBarItem29, Me.barButtonItem2, Me.printPreviewStaticItem4, Me.zoomTrackBarEditItem2, Me.printPreviewBarItem30, Me.printPreviewBarItem31, Me.printPreviewBarItem32, Me.printPreviewBarItem33, Me.printPreviewBarItem34, Me.printPreviewBarItem35, Me.printPreviewBarItem36, Me.printPreviewBarItem37, Me.printPreviewBarItem38, Me.printPreviewBarItem39, Me.printPreviewBarItem40, Me.printPreviewBarItem41, Me.printPreviewBarItem42, Me.printPreviewBarItem43, Me.zoomBarEditItem2, Me.printPreviewBarItem44, Me.printPreviewBarItem45, Me.printPreviewBarItem46, Me.printPreviewBarItem47, Me.printPreviewBarItem48, Me.printPreviewBarItem49, Me.printPreviewBarItem50, Me.printPreviewBarItem51, Me.printPreviewBarItem52, Me.printPreviewBarItem53, Me.printPreviewBarItem54, Me.printPreviewSubItem5, Me.printPreviewSubItem6, Me.printPreviewSubItem7, Me.printPreviewSubItem8, Me.printPreviewBarItem55, Me.printPreviewBarItem56, Me.barToolbarsListItem2, Me.printPreviewBarCheckItem18, Me.printPreviewBarCheckItem19, Me.printPreviewBarCheckItem20, Me.printPreviewBarCheckItem21, Me.printPreviewBarCheckItem22, Me.printPreviewBarCheckItem23, Me.printPreviewBarCheckItem24, Me.printPreviewBarCheckItem25, Me.printPreviewBarCheckItem26, Me.printPreviewBarCheckItem27, Me.printPreviewBarCheckItem28, Me.printPreviewBarCheckItem29, Me.printPreviewBarCheckItem30, Me.printPreviewBarCheckItem31, Me.printPreviewBarCheckItem32, Me.printPreviewBarCheckItem33, Me.printPreviewBarCheckItem34})
			Me.printBarManager2.MainMenu = Me.previewBar6
			Me.printBarManager2.MaxItemId = 57
			Me.printBarManager2.PreviewBar = Me.previewBar4
			Me.printBarManager2.PrintControl = Me.printControl2
			Me.printBarManager2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemProgressBar2, Me.repositoryItemZoomTrackBar2, Me.printPreviewRepositoryItemComboBox2})
			Me.printBarManager2.StatusBar = Me.previewBar5
			Me.printBarManager2.TransparentEditors = True
			' 
			' previewBar4
			' 
			Me.previewBar4.BarName = "Toolbar"
			Me.previewBar4.DockCol = 0
			Me.previewBar4.DockRow = 1
			Me.previewBar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.previewBar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem30), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem31), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem32), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem33, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem34, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem35), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem36, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem37), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem38), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem39), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem40), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem41, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem42), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem43, True), New DevExpress.XtraBars.LinkPersistInfo(Me.zoomBarEditItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem44), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem45, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem46), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem47), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem48), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem49, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem50), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem51), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem52, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem53), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem54, True)})
			Me.previewBar4.Text = "Toolbar"
			' 
			' printPreviewBarItem30
			' 
			Me.printPreviewBarItem30.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.printPreviewBarItem30.Caption = "Document Map"
			Me.printPreviewBarItem30.Command = DevExpress.XtraPrinting.PrintingSystemCommand.DocumentMap
			Me.printPreviewBarItem30.Enabled = False
			Me.printPreviewBarItem30.Hint = "Document Map"
			Me.printPreviewBarItem30.Id = 7
			Me.printPreviewBarItem30.ImageIndex = 19
			Me.printPreviewBarItem30.Name = "printPreviewBarItem30"
			Me.printPreviewBarItem30.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
			' 
			' printPreviewBarItem31
			' 
			Me.printPreviewBarItem31.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.printPreviewBarItem31.Caption = "Parameters"
			Me.printPreviewBarItem31.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Parameters
			Me.printPreviewBarItem31.Enabled = False
			Me.printPreviewBarItem31.Hint = "Parameters"
			Me.printPreviewBarItem31.Id = 8
			Me.printPreviewBarItem31.ImageIndex = 22
			Me.printPreviewBarItem31.Name = "printPreviewBarItem31"
			Me.printPreviewBarItem31.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
			' 
			' printPreviewBarItem32
			' 
			Me.printPreviewBarItem32.Caption = "Search"
			Me.printPreviewBarItem32.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Find
			Me.printPreviewBarItem32.Enabled = False
			Me.printPreviewBarItem32.Hint = "Search"
			Me.printPreviewBarItem32.Id = 9
			Me.printPreviewBarItem32.ImageIndex = 20
			Me.printPreviewBarItem32.Name = "printPreviewBarItem32"
			' 
			' printPreviewBarItem33
			' 
			Me.printPreviewBarItem33.Caption = "Customize"
			Me.printPreviewBarItem33.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Customize
			Me.printPreviewBarItem33.Enabled = False
			Me.printPreviewBarItem33.Hint = "Customize"
			Me.printPreviewBarItem33.Id = 10
			Me.printPreviewBarItem33.ImageIndex = 14
			Me.printPreviewBarItem33.Name = "printPreviewBarItem33"
			' 
			' printPreviewBarItem34
			' 
			Me.printPreviewBarItem34.Caption = "Open"
			Me.printPreviewBarItem34.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Open
			Me.printPreviewBarItem34.Hint = "Open a document"
			Me.printPreviewBarItem34.Id = 11
			Me.printPreviewBarItem34.ImageIndex = 23
			Me.printPreviewBarItem34.Name = "printPreviewBarItem34"
			' 
			' printPreviewBarItem35
			' 
			Me.printPreviewBarItem35.Caption = "Save"
			Me.printPreviewBarItem35.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Save
			Me.printPreviewBarItem35.Enabled = False
			Me.printPreviewBarItem35.Hint = "Save the document"
			Me.printPreviewBarItem35.Id = 12
			Me.printPreviewBarItem35.ImageIndex = 24
			Me.printPreviewBarItem35.Name = "printPreviewBarItem35"
			' 
			' printPreviewBarItem36
			' 
			Me.printPreviewBarItem36.Caption = "&Print..."
			Me.printPreviewBarItem36.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Print
			Me.printPreviewBarItem36.Enabled = False
			Me.printPreviewBarItem36.Hint = "Print"
			Me.printPreviewBarItem36.Id = 13
			Me.printPreviewBarItem36.ImageIndex = 0
			Me.printPreviewBarItem36.Name = "printPreviewBarItem36"
			' 
			' printPreviewBarItem37
			' 
			Me.printPreviewBarItem37.Caption = "P&rint"
			Me.printPreviewBarItem37.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect
			Me.printPreviewBarItem37.Enabled = False
			Me.printPreviewBarItem37.Hint = "Quick Print"
			Me.printPreviewBarItem37.Id = 14
			Me.printPreviewBarItem37.ImageIndex = 1
			Me.printPreviewBarItem37.Name = "printPreviewBarItem37"
			' 
			' printPreviewBarItem38
			' 
			Me.printPreviewBarItem38.Caption = "Page Set&up..."
			Me.printPreviewBarItem38.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageSetup
			Me.printPreviewBarItem38.Enabled = False
			Me.printPreviewBarItem38.Hint = "Page Setup"
			Me.printPreviewBarItem38.Id = 15
			Me.printPreviewBarItem38.ImageIndex = 2
			Me.printPreviewBarItem38.Name = "printPreviewBarItem38"
			' 
			' printPreviewBarItem39
			' 
			Me.printPreviewBarItem39.Caption = "Header And Footer"
			Me.printPreviewBarItem39.Command = DevExpress.XtraPrinting.PrintingSystemCommand.EditPageHF
			Me.printPreviewBarItem39.Enabled = False
			Me.printPreviewBarItem39.Hint = "Header And Footer"
			Me.printPreviewBarItem39.Id = 16
			Me.printPreviewBarItem39.ImageIndex = 15
			Me.printPreviewBarItem39.Name = "printPreviewBarItem39"
			' 
			' printPreviewBarItem40
			' 
			Me.printPreviewBarItem40.ActAsDropDown = True
			Me.printPreviewBarItem40.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.printPreviewBarItem40.Caption = "Scale"
			Me.printPreviewBarItem40.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Scale
			Me.printPreviewBarItem40.Enabled = False
			Me.printPreviewBarItem40.Hint = "Scale"
			Me.printPreviewBarItem40.Id = 17
			Me.printPreviewBarItem40.ImageIndex = 25
			Me.printPreviewBarItem40.Name = "printPreviewBarItem40"
			' 
			' printPreviewBarItem41
			' 
			Me.printPreviewBarItem41.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.printPreviewBarItem41.Caption = "Hand Tool"
			Me.printPreviewBarItem41.Command = DevExpress.XtraPrinting.PrintingSystemCommand.HandTool
			Me.printPreviewBarItem41.Enabled = False
			Me.printPreviewBarItem41.Hint = "Hand Tool"
			Me.printPreviewBarItem41.Id = 18
			Me.printPreviewBarItem41.ImageIndex = 16
			Me.printPreviewBarItem41.Name = "printPreviewBarItem41"
			' 
			' printPreviewBarItem42
			' 
			Me.printPreviewBarItem42.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.printPreviewBarItem42.Caption = "Magnifier"
			Me.printPreviewBarItem42.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Magnifier
			Me.printPreviewBarItem42.Enabled = False
			Me.printPreviewBarItem42.Hint = "Magnifier"
			Me.printPreviewBarItem42.Id = 19
			Me.printPreviewBarItem42.ImageIndex = 3
			Me.printPreviewBarItem42.Name = "printPreviewBarItem42"
			' 
			' printPreviewBarItem43
			' 
			Me.printPreviewBarItem43.Caption = "Zoom Out"
			Me.printPreviewBarItem43.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomOut
			Me.printPreviewBarItem43.Enabled = False
			Me.printPreviewBarItem43.Hint = "Zoom Out"
			Me.printPreviewBarItem43.Id = 20
			Me.printPreviewBarItem43.ImageIndex = 5
			Me.printPreviewBarItem43.Name = "printPreviewBarItem43"
			' 
			' zoomBarEditItem2
			' 
			Me.zoomBarEditItem2.Caption = "Zoom"
			Me.zoomBarEditItem2.Edit = Me.printPreviewRepositoryItemComboBox2
			Me.zoomBarEditItem2.EditValue = "100%"
			Me.zoomBarEditItem2.Enabled = False
			Me.zoomBarEditItem2.Hint = "Zoom"
			Me.zoomBarEditItem2.Id = 21
			Me.zoomBarEditItem2.Name = "zoomBarEditItem2"
			Me.zoomBarEditItem2.Width = 70
			' 
			' printPreviewRepositoryItemComboBox2
			' 
			Me.printPreviewRepositoryItemComboBox2.AutoComplete = False
			Me.printPreviewRepositoryItemComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.printPreviewRepositoryItemComboBox2.DropDownRows = 11
			Me.printPreviewRepositoryItemComboBox2.Name = "printPreviewRepositoryItemComboBox2"
			Me.printPreviewRepositoryItemComboBox2.UseParentBackground = True
			' 
			' printPreviewBarItem44
			' 
			Me.printPreviewBarItem44.Caption = "Zoom In"
			Me.printPreviewBarItem44.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomIn
			Me.printPreviewBarItem44.Enabled = False
			Me.printPreviewBarItem44.Hint = "Zoom In"
			Me.printPreviewBarItem44.Id = 22
			Me.printPreviewBarItem44.ImageIndex = 4
			Me.printPreviewBarItem44.Name = "printPreviewBarItem44"
			' 
			' printPreviewBarItem45
			' 
			Me.printPreviewBarItem45.Caption = "First Page"
			Me.printPreviewBarItem45.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowFirstPage
			Me.printPreviewBarItem45.Enabled = False
			Me.printPreviewBarItem45.Hint = "First Page"
			Me.printPreviewBarItem45.Id = 23
			Me.printPreviewBarItem45.ImageIndex = 7
			Me.printPreviewBarItem45.Name = "printPreviewBarItem45"
			' 
			' printPreviewBarItem46
			' 
			Me.printPreviewBarItem46.Caption = "Previous Page"
			Me.printPreviewBarItem46.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowPrevPage
			Me.printPreviewBarItem46.Enabled = False
			Me.printPreviewBarItem46.Hint = "Previous Page"
			Me.printPreviewBarItem46.Id = 24
			Me.printPreviewBarItem46.ImageIndex = 8
			Me.printPreviewBarItem46.Name = "printPreviewBarItem46"
			' 
			' printPreviewBarItem47
			' 
			Me.printPreviewBarItem47.Caption = "Next Page"
			Me.printPreviewBarItem47.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowNextPage
			Me.printPreviewBarItem47.Enabled = False
			Me.printPreviewBarItem47.Hint = "Next Page"
			Me.printPreviewBarItem47.Id = 25
			Me.printPreviewBarItem47.ImageIndex = 9
			Me.printPreviewBarItem47.Name = "printPreviewBarItem47"
			' 
			' printPreviewBarItem48
			' 
			Me.printPreviewBarItem48.Caption = "Last Page"
			Me.printPreviewBarItem48.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowLastPage
			Me.printPreviewBarItem48.Enabled = False
			Me.printPreviewBarItem48.Hint = "Last Page"
			Me.printPreviewBarItem48.Id = 26
			Me.printPreviewBarItem48.ImageIndex = 10
			Me.printPreviewBarItem48.Name = "printPreviewBarItem48"
			' 
			' printPreviewBarItem49
			' 
			Me.printPreviewBarItem49.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.printPreviewBarItem49.Caption = "Multiple Pages"
			Me.printPreviewBarItem49.Command = DevExpress.XtraPrinting.PrintingSystemCommand.MultiplePages
			Me.printPreviewBarItem49.Enabled = False
			Me.printPreviewBarItem49.Hint = "Multiple Pages"
			Me.printPreviewBarItem49.Id = 27
			Me.printPreviewBarItem49.ImageIndex = 11
			Me.printPreviewBarItem49.Name = "printPreviewBarItem49"
			' 
			' printPreviewBarItem50
			' 
			Me.printPreviewBarItem50.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.printPreviewBarItem50.Caption = "&Color..."
			Me.printPreviewBarItem50.Command = DevExpress.XtraPrinting.PrintingSystemCommand.FillBackground
			Me.printPreviewBarItem50.Enabled = False
			Me.printPreviewBarItem50.Hint = "Background"
			Me.printPreviewBarItem50.Id = 28
			Me.printPreviewBarItem50.ImageIndex = 12
			Me.printPreviewBarItem50.Name = "printPreviewBarItem50"
			' 
			' printPreviewBarItem51
			' 
			Me.printPreviewBarItem51.Caption = "&Watermark..."
			Me.printPreviewBarItem51.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Watermark
			Me.printPreviewBarItem51.Enabled = False
			Me.printPreviewBarItem51.Hint = "Watermark"
			Me.printPreviewBarItem51.Id = 29
			Me.printPreviewBarItem51.ImageIndex = 21
			Me.printPreviewBarItem51.Name = "printPreviewBarItem51"
			' 
			' printPreviewBarItem52
			' 
			Me.printPreviewBarItem52.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.printPreviewBarItem52.Caption = "Export Document..."
			Me.printPreviewBarItem52.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportFile
			Me.printPreviewBarItem52.Enabled = False
			Me.printPreviewBarItem52.Hint = "Export Document..."
			Me.printPreviewBarItem52.Id = 30
			Me.printPreviewBarItem52.ImageIndex = 18
			Me.printPreviewBarItem52.Name = "printPreviewBarItem52"
			' 
			' printPreviewBarItem53
			' 
			Me.printPreviewBarItem53.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.printPreviewBarItem53.Caption = "Send via E-Mail..."
			Me.printPreviewBarItem53.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendFile
			Me.printPreviewBarItem53.Enabled = False
			Me.printPreviewBarItem53.Hint = "Send via E-Mail..."
			Me.printPreviewBarItem53.Id = 31
			Me.printPreviewBarItem53.ImageIndex = 17
			Me.printPreviewBarItem53.Name = "printPreviewBarItem53"
			' 
			' printPreviewBarItem54
			' 
			Me.printPreviewBarItem54.Caption = "E&xit"
			Me.printPreviewBarItem54.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ClosePreview
			Me.printPreviewBarItem54.Hint = "Close Preview"
			Me.printPreviewBarItem54.Id = 32
			Me.printPreviewBarItem54.ImageIndex = 13
			Me.printPreviewBarItem54.Name = "printPreviewBarItem54"
			' 
			' previewBar5
			' 
			Me.previewBar5.BarName = "Status Bar"
			Me.previewBar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
			Me.previewBar5.DockCol = 0
			Me.previewBar5.DockRow = 0
			Me.previewBar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
			Me.previewBar5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewStaticItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.barStaticItem2, True), New DevExpress.XtraBars.LinkPersistInfo(Me.progressBarEditItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem29), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewStaticItem4, True), New DevExpress.XtraBars.LinkPersistInfo(Me.zoomTrackBarEditItem2)})
			Me.previewBar5.OptionsBar.AllowQuickCustomization = False
			Me.previewBar5.OptionsBar.DrawDragBorder = False
			Me.previewBar5.OptionsBar.UseWholeRow = True
			Me.previewBar5.Text = "Status Bar"
			' 
			' printPreviewStaticItem3
			' 
			Me.printPreviewStaticItem3.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.printPreviewStaticItem3.Caption = "Nothing"
			Me.printPreviewStaticItem3.Id = 0
			Me.printPreviewStaticItem3.LeftIndent = 1
			Me.printPreviewStaticItem3.Name = "printPreviewStaticItem3"
			Me.printPreviewStaticItem3.RightIndent = 1
			Me.printPreviewStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near
			Me.printPreviewStaticItem3.Type = "PageOfPages"
			' 
			' barStaticItem2
			' 
			Me.barStaticItem2.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.barStaticItem2.Id = 1
			Me.barStaticItem2.Name = "barStaticItem2"
			Me.barStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near
			Me.barStaticItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime
			' 
			' progressBarEditItem2
			' 
			Me.progressBarEditItem2.Edit = Me.repositoryItemProgressBar2
			Me.progressBarEditItem2.EditHeight = 12
			Me.progressBarEditItem2.Id = 2
			Me.progressBarEditItem2.Name = "progressBarEditItem2"
			Me.progressBarEditItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
			Me.progressBarEditItem2.Width = 150
			' 
			' repositoryItemProgressBar2
			' 
			Me.repositoryItemProgressBar2.Name = "repositoryItemProgressBar2"
			Me.repositoryItemProgressBar2.UseParentBackground = True
			' 
			' printPreviewBarItem29
			' 
			Me.printPreviewBarItem29.Caption = "Stop"
			Me.printPreviewBarItem29.Command = DevExpress.XtraPrinting.PrintingSystemCommand.StopPageBuilding
			Me.printPreviewBarItem29.Enabled = False
			Me.printPreviewBarItem29.Hint = "Stop"
			Me.printPreviewBarItem29.Id = 3
			Me.printPreviewBarItem29.Name = "printPreviewBarItem29"
			Me.printPreviewBarItem29.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
			Me.barButtonItem2.Enabled = False
			Me.barButtonItem2.Id = 4
			Me.barButtonItem2.Name = "barButtonItem2"
			Me.barButtonItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.OnlyInRuntime
			' 
			' printPreviewStaticItem4
			' 
			Me.printPreviewStaticItem4.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.printPreviewStaticItem4.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.printPreviewStaticItem4.Caption = "100%"
			Me.printPreviewStaticItem4.Id = 5
			Me.printPreviewStaticItem4.Name = "printPreviewStaticItem4"
			Me.printPreviewStaticItem4.TextAlignment = System.Drawing.StringAlignment.Far
			Me.printPreviewStaticItem4.Type = "ZoomFactor"
			Me.printPreviewStaticItem4.Width = 40
			' 
			' zoomTrackBarEditItem2
			' 
			Me.zoomTrackBarEditItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.zoomTrackBarEditItem2.Edit = Me.repositoryItemZoomTrackBar2
			Me.zoomTrackBarEditItem2.EditValue = 90
			Me.zoomTrackBarEditItem2.Enabled = False
			Me.zoomTrackBarEditItem2.Id = 6
			Me.zoomTrackBarEditItem2.Name = "zoomTrackBarEditItem2"
			Me.zoomTrackBarEditItem2.Range = New Integer() { 10, 500}
			Me.zoomTrackBarEditItem2.Width = 140
			' 
			' repositoryItemZoomTrackBar2
			' 
			Me.repositoryItemZoomTrackBar2.Alignment = DevExpress.Utils.VertAlignment.Center
			Me.repositoryItemZoomTrackBar2.AllowFocused = False
			Me.repositoryItemZoomTrackBar2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemZoomTrackBar2.Maximum = 180
			Me.repositoryItemZoomTrackBar2.Name = "repositoryItemZoomTrackBar2"
			Me.repositoryItemZoomTrackBar2.ScrollThumbStyle = DevExpress.XtraEditors.Repository.ScrollThumbStyle.ArrowDownRight
			Me.repositoryItemZoomTrackBar2.UseParentBackground = True
			' 
			' previewBar6
			' 
			Me.previewBar6.BarName = "Main Menu"
			Me.previewBar6.DockCol = 0
			Me.previewBar6.DockRow = 0
			Me.previewBar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.previewBar6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewSubItem5), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewSubItem6), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewSubItem7)})
			Me.previewBar6.OptionsBar.MultiLine = True
			Me.previewBar6.OptionsBar.UseWholeRow = True
			Me.previewBar6.Text = "Main Menu"
			' 
			' printPreviewSubItem5
			' 
			Me.printPreviewSubItem5.Caption = "&File"
			Me.printPreviewSubItem5.Command = DevExpress.XtraPrinting.PrintingSystemCommand.File
			Me.printPreviewSubItem5.Id = 33
			Me.printPreviewSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem38), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem36), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem37), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem52, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem53), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem54, True)})
			Me.printPreviewSubItem5.Name = "printPreviewSubItem5"
			' 
			' printPreviewSubItem6
			' 
			Me.printPreviewSubItem6.Caption = "&View"
			Me.printPreviewSubItem6.Command = DevExpress.XtraPrinting.PrintingSystemCommand.View
			Me.printPreviewSubItem6.Id = 34
			Me.printPreviewSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewSubItem8, True), New DevExpress.XtraBars.LinkPersistInfo(Me.barToolbarsListItem2, True)})
			Me.printPreviewSubItem6.Name = "printPreviewSubItem6"
			' 
			' printPreviewSubItem8
			' 
			Me.printPreviewSubItem8.Caption = "&Page Layout"
			Me.printPreviewSubItem8.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayout
			Me.printPreviewSubItem8.Id = 36
			Me.printPreviewSubItem8.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem55), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem56)})
			Me.printPreviewSubItem8.Name = "printPreviewSubItem8"
			' 
			' printPreviewBarItem55
			' 
			Me.printPreviewBarItem55.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.printPreviewBarItem55.Caption = "&Facing"
			Me.printPreviewBarItem55.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutFacing
			Me.printPreviewBarItem55.Enabled = False
			Me.printPreviewBarItem55.GroupIndex = 100
			Me.printPreviewBarItem55.Id = 37
			Me.printPreviewBarItem55.Name = "printPreviewBarItem55"
			' 
			' printPreviewBarItem56
			' 
			Me.printPreviewBarItem56.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			Me.printPreviewBarItem56.Caption = "&Continuous"
			Me.printPreviewBarItem56.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutContinuous
			Me.printPreviewBarItem56.Enabled = False
			Me.printPreviewBarItem56.GroupIndex = 100
			Me.printPreviewBarItem56.Id = 38
			Me.printPreviewBarItem56.Name = "printPreviewBarItem56"
			' 
			' barToolbarsListItem2
			' 
			Me.barToolbarsListItem2.Caption = "Bars"
			Me.barToolbarsListItem2.Id = 39
			Me.barToolbarsListItem2.Name = "barToolbarsListItem2"
			' 
			' printPreviewSubItem7
			' 
			Me.printPreviewSubItem7.Caption = "&Background"
			Me.printPreviewSubItem7.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Background
			Me.printPreviewSubItem7.Id = 35
			Me.printPreviewSubItem7.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem50), New DevExpress.XtraBars.LinkPersistInfo(Me.printPreviewBarItem51)})
			Me.printPreviewSubItem7.Name = "printPreviewSubItem7"
			' 
			' printPreviewBarCheckItem18
			' 
			Me.printPreviewBarCheckItem18.Caption = "PDF File"
			Me.printPreviewBarCheckItem18.Checked = True
			Me.printPreviewBarCheckItem18.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportPdf
			Me.printPreviewBarCheckItem18.Enabled = False
			Me.printPreviewBarCheckItem18.GroupIndex = 2
			Me.printPreviewBarCheckItem18.Hint = "PDF File"
			Me.printPreviewBarCheckItem18.Id = 40
			Me.printPreviewBarCheckItem18.Name = "printPreviewBarCheckItem18"
			' 
			' printPreviewBarCheckItem19
			' 
			Me.printPreviewBarCheckItem19.Caption = "HTML File"
			Me.printPreviewBarCheckItem19.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportHtm
			Me.printPreviewBarCheckItem19.Enabled = False
			Me.printPreviewBarCheckItem19.GroupIndex = 2
			Me.printPreviewBarCheckItem19.Hint = "HTML File"
			Me.printPreviewBarCheckItem19.Id = 41
			Me.printPreviewBarCheckItem19.Name = "printPreviewBarCheckItem19"
			' 
			' printPreviewBarCheckItem20
			' 
			Me.printPreviewBarCheckItem20.Caption = "MHT File"
			Me.printPreviewBarCheckItem20.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportMht
			Me.printPreviewBarCheckItem20.Enabled = False
			Me.printPreviewBarCheckItem20.GroupIndex = 2
			Me.printPreviewBarCheckItem20.Hint = "MHT File"
			Me.printPreviewBarCheckItem20.Id = 42
			Me.printPreviewBarCheckItem20.Name = "printPreviewBarCheckItem20"
			' 
			' printPreviewBarCheckItem21
			' 
			Me.printPreviewBarCheckItem21.Caption = "RTF File"
			Me.printPreviewBarCheckItem21.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportRtf
			Me.printPreviewBarCheckItem21.Enabled = False
			Me.printPreviewBarCheckItem21.GroupIndex = 2
			Me.printPreviewBarCheckItem21.Hint = "RTF File"
			Me.printPreviewBarCheckItem21.Id = 43
			Me.printPreviewBarCheckItem21.Name = "printPreviewBarCheckItem21"
			' 
			' printPreviewBarCheckItem22
			' 
			Me.printPreviewBarCheckItem22.Caption = "XLS File"
			Me.printPreviewBarCheckItem22.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXls
			Me.printPreviewBarCheckItem22.Enabled = False
			Me.printPreviewBarCheckItem22.GroupIndex = 2
			Me.printPreviewBarCheckItem22.Hint = "XLS File"
			Me.printPreviewBarCheckItem22.Id = 44
			Me.printPreviewBarCheckItem22.Name = "printPreviewBarCheckItem22"
			' 
			' printPreviewBarCheckItem23
			' 
			Me.printPreviewBarCheckItem23.Caption = "XLSX File"
			Me.printPreviewBarCheckItem23.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXlsx
			Me.printPreviewBarCheckItem23.Enabled = False
			Me.printPreviewBarCheckItem23.GroupIndex = 2
			Me.printPreviewBarCheckItem23.Hint = "XLSX File"
			Me.printPreviewBarCheckItem23.Id = 45
			Me.printPreviewBarCheckItem23.Name = "printPreviewBarCheckItem23"
			' 
			' printPreviewBarCheckItem24
			' 
			Me.printPreviewBarCheckItem24.Caption = "CSV File"
			Me.printPreviewBarCheckItem24.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportCsv
			Me.printPreviewBarCheckItem24.Enabled = False
			Me.printPreviewBarCheckItem24.GroupIndex = 2
			Me.printPreviewBarCheckItem24.Hint = "CSV File"
			Me.printPreviewBarCheckItem24.Id = 46
			Me.printPreviewBarCheckItem24.Name = "printPreviewBarCheckItem24"
			' 
			' printPreviewBarCheckItem25
			' 
			Me.printPreviewBarCheckItem25.Caption = "Text File"
			Me.printPreviewBarCheckItem25.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportTxt
			Me.printPreviewBarCheckItem25.Enabled = False
			Me.printPreviewBarCheckItem25.GroupIndex = 2
			Me.printPreviewBarCheckItem25.Hint = "Text File"
			Me.printPreviewBarCheckItem25.Id = 47
			Me.printPreviewBarCheckItem25.Name = "printPreviewBarCheckItem25"
			' 
			' printPreviewBarCheckItem26
			' 
			Me.printPreviewBarCheckItem26.Caption = "Image File"
			Me.printPreviewBarCheckItem26.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportGraphic
			Me.printPreviewBarCheckItem26.Enabled = False
			Me.printPreviewBarCheckItem26.GroupIndex = 2
			Me.printPreviewBarCheckItem26.Hint = "Image File"
			Me.printPreviewBarCheckItem26.Id = 48
			Me.printPreviewBarCheckItem26.Name = "printPreviewBarCheckItem26"
			' 
			' printPreviewBarCheckItem27
			' 
			Me.printPreviewBarCheckItem27.Caption = "PDF File"
			Me.printPreviewBarCheckItem27.Checked = True
			Me.printPreviewBarCheckItem27.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendPdf
			Me.printPreviewBarCheckItem27.Enabled = False
			Me.printPreviewBarCheckItem27.GroupIndex = 1
			Me.printPreviewBarCheckItem27.Hint = "PDF File"
			Me.printPreviewBarCheckItem27.Id = 49
			Me.printPreviewBarCheckItem27.Name = "printPreviewBarCheckItem27"
			' 
			' printPreviewBarCheckItem28
			' 
			Me.printPreviewBarCheckItem28.Caption = "MHT File"
			Me.printPreviewBarCheckItem28.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendMht
			Me.printPreviewBarCheckItem28.Enabled = False
			Me.printPreviewBarCheckItem28.GroupIndex = 1
			Me.printPreviewBarCheckItem28.Hint = "MHT File"
			Me.printPreviewBarCheckItem28.Id = 50
			Me.printPreviewBarCheckItem28.Name = "printPreviewBarCheckItem28"
			' 
			' printPreviewBarCheckItem29
			' 
			Me.printPreviewBarCheckItem29.Caption = "RTF File"
			Me.printPreviewBarCheckItem29.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendRtf
			Me.printPreviewBarCheckItem29.Enabled = False
			Me.printPreviewBarCheckItem29.GroupIndex = 1
			Me.printPreviewBarCheckItem29.Hint = "RTF File"
			Me.printPreviewBarCheckItem29.Id = 51
			Me.printPreviewBarCheckItem29.Name = "printPreviewBarCheckItem29"
			' 
			' printPreviewBarCheckItem30
			' 
			Me.printPreviewBarCheckItem30.Caption = "XLS File"
			Me.printPreviewBarCheckItem30.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXls
			Me.printPreviewBarCheckItem30.Enabled = False
			Me.printPreviewBarCheckItem30.GroupIndex = 1
			Me.printPreviewBarCheckItem30.Hint = "XLS File"
			Me.printPreviewBarCheckItem30.Id = 52
			Me.printPreviewBarCheckItem30.Name = "printPreviewBarCheckItem30"
			' 
			' printPreviewBarCheckItem31
			' 
			Me.printPreviewBarCheckItem31.Caption = "XLSX File"
			Me.printPreviewBarCheckItem31.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXlsx
			Me.printPreviewBarCheckItem31.Enabled = False
			Me.printPreviewBarCheckItem31.GroupIndex = 1
			Me.printPreviewBarCheckItem31.Hint = "XLSX File"
			Me.printPreviewBarCheckItem31.Id = 53
			Me.printPreviewBarCheckItem31.Name = "printPreviewBarCheckItem31"
			' 
			' printPreviewBarCheckItem32
			' 
			Me.printPreviewBarCheckItem32.Caption = "CSV File"
			Me.printPreviewBarCheckItem32.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendCsv
			Me.printPreviewBarCheckItem32.Enabled = False
			Me.printPreviewBarCheckItem32.GroupIndex = 1
			Me.printPreviewBarCheckItem32.Hint = "CSV File"
			Me.printPreviewBarCheckItem32.Id = 54
			Me.printPreviewBarCheckItem32.Name = "printPreviewBarCheckItem32"
			' 
			' printPreviewBarCheckItem33
			' 
			Me.printPreviewBarCheckItem33.Caption = "Text File"
			Me.printPreviewBarCheckItem33.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendTxt
			Me.printPreviewBarCheckItem33.Enabled = False
			Me.printPreviewBarCheckItem33.GroupIndex = 1
			Me.printPreviewBarCheckItem33.Hint = "Text File"
			Me.printPreviewBarCheckItem33.Id = 55
			Me.printPreviewBarCheckItem33.Name = "printPreviewBarCheckItem33"
			' 
			' printPreviewBarCheckItem34
			' 
			Me.printPreviewBarCheckItem34.Caption = "Image File"
			Me.printPreviewBarCheckItem34.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendGraphic
			Me.printPreviewBarCheckItem34.Enabled = False
			Me.printPreviewBarCheckItem34.GroupIndex = 1
			Me.printPreviewBarCheckItem34.Hint = "Image File"
			Me.printPreviewBarCheckItem34.Id = 56
			Me.printPreviewBarCheckItem34.Name = "printPreviewBarCheckItem34"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1008, 730)
			Me.Controls.Add(Me.printControl2)
			Me.Controls.Add(Me.printControl1)
			Me.Controls.Add(Me.richEditControl2)
			Me.Controls.Add(Me.richEditControl1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.printBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.printPreviewRepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemZoomTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.printControl1.ResumeLayout(False)
			CType(Me.printingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.printControl2.ResumeLayout(False)
			CType(Me.printingSystem2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.printBarManager2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.printPreviewRepositoryItemComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemProgressBar2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemZoomTrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
		Private printBarManager1 As DevExpress.XtraPrinting.Preview.PrintBarManager
		Private previewBar1 As DevExpress.XtraPrinting.Preview.PreviewBar
		Private printPreviewBarItem2 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem3 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem4 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem5 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem6 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem7 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem8 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem9 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem10 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem11 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem12 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem13 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem14 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem15 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private zoomBarEditItem1 As DevExpress.XtraPrinting.Preview.ZoomBarEditItem
		Private printPreviewRepositoryItemComboBox1 As DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox
		Private printPreviewBarItem16 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem17 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem18 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem19 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem20 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem21 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem22 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem23 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem24 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem25 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem26 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private previewBar2 As DevExpress.XtraPrinting.Preview.PreviewBar
		Private printPreviewStaticItem1 As DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem
		Private barStaticItem1 As DevExpress.XtraBars.BarStaticItem
		Private progressBarEditItem1 As DevExpress.XtraPrinting.Preview.ProgressBarEditItem
		Private repositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
		Private printPreviewBarItem1 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private printPreviewStaticItem2 As DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem
		Private zoomTrackBarEditItem1 As DevExpress.XtraPrinting.Preview.ZoomTrackBarEditItem
		Private repositoryItemZoomTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar
		Private previewBar3 As DevExpress.XtraPrinting.Preview.PreviewBar
		Private printPreviewSubItem1 As DevExpress.XtraPrinting.Preview.PrintPreviewSubItem
		Private printPreviewSubItem2 As DevExpress.XtraPrinting.Preview.PrintPreviewSubItem
		Private printPreviewSubItem4 As DevExpress.XtraPrinting.Preview.PrintPreviewSubItem
		Private printPreviewBarItem27 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem28 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private barToolbarsListItem1 As DevExpress.XtraBars.BarToolbarsListItem
		Private printPreviewSubItem3 As DevExpress.XtraPrinting.Preview.PrintPreviewSubItem
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private printControl1 As DevExpress.XtraPrinting.Control.PrintControl
		Private printPreviewBarCheckItem1 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem2 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem3 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem4 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem5 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem6 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem7 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem8 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem9 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem10 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem11 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem12 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem13 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem14 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem15 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem16 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem17 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private richEditControl2 As DevExpress.XtraRichEdit.RichEditControl
		Private printingSystem1 As DevExpress.XtraPrinting.PrintingSystem
		Private printableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
		Private barDockControl1 As DevExpress.XtraBars.BarDockControl
		Private barDockControl2 As DevExpress.XtraBars.BarDockControl
		Private barDockControl3 As DevExpress.XtraBars.BarDockControl
		Private barDockControl4 As DevExpress.XtraBars.BarDockControl
		Private printControl2 As DevExpress.XtraPrinting.Control.PrintControl
		Private barDockControl7 As DevExpress.XtraBars.BarDockControl
		Private barDockControl8 As DevExpress.XtraBars.BarDockControl
		Private barDockControl6 As DevExpress.XtraBars.BarDockControl
		Private barDockControl5 As DevExpress.XtraBars.BarDockControl
		Private printBarManager2 As DevExpress.XtraPrinting.Preview.PrintBarManager
		Private previewBar4 As DevExpress.XtraPrinting.Preview.PreviewBar
		Private printPreviewBarItem30 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem31 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem32 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem33 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem34 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem35 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem36 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem37 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem38 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem39 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem40 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem41 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem42 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem43 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private zoomBarEditItem2 As DevExpress.XtraPrinting.Preview.ZoomBarEditItem
		Private printPreviewRepositoryItemComboBox2 As DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox
		Private printPreviewBarItem44 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem45 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem46 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem47 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem48 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem49 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem50 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem51 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem52 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem53 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem54 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private previewBar5 As DevExpress.XtraPrinting.Preview.PreviewBar
		Private printPreviewStaticItem3 As DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem
		Private barStaticItem2 As DevExpress.XtraBars.BarStaticItem
		Private progressBarEditItem2 As DevExpress.XtraPrinting.Preview.ProgressBarEditItem
		Private repositoryItemProgressBar2 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
		Private printPreviewBarItem29 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private printPreviewStaticItem4 As DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem
		Private zoomTrackBarEditItem2 As DevExpress.XtraPrinting.Preview.ZoomTrackBarEditItem
		Private repositoryItemZoomTrackBar2 As DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar
		Private previewBar6 As DevExpress.XtraPrinting.Preview.PreviewBar
		Private printPreviewSubItem5 As DevExpress.XtraPrinting.Preview.PrintPreviewSubItem
		Private printPreviewSubItem6 As DevExpress.XtraPrinting.Preview.PrintPreviewSubItem
		Private printPreviewSubItem8 As DevExpress.XtraPrinting.Preview.PrintPreviewSubItem
		Private printPreviewBarItem55 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private printPreviewBarItem56 As DevExpress.XtraPrinting.Preview.PrintPreviewBarItem
		Private barToolbarsListItem2 As DevExpress.XtraBars.BarToolbarsListItem
		Private printPreviewSubItem7 As DevExpress.XtraPrinting.Preview.PrintPreviewSubItem
		Private printPreviewBarCheckItem18 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem19 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem20 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem21 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem22 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem23 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem24 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem25 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem26 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem27 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem28 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem29 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem30 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem31 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem32 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem33 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printPreviewBarCheckItem34 As DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem
		Private printingSystem2 As DevExpress.XtraPrinting.PrintingSystem
		Private printableComponentLink2 As DevExpress.XtraPrinting.PrintableComponentLink
	End Class
End Namespace

