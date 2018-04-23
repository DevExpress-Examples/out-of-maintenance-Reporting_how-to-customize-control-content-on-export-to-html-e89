Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting.HtmlExport
Imports DevExpress.XtraPrinting.HtmlExport.Controls
' ...


Namespace docXRControlHtmlItemCreated
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xrLabel1_HtmlItemCreated(ByVal sender As Object, ByVal e As HtmlEventArgs) _
		Handles xrLabel1.HtmlItemCreated
			' Clear the contents of the parent html row.
			Dim parentRow As DXHtmlTableRow = CType(e.ContentCell.Parent, DXHtmlTableRow)
			parentRow.Controls.Clear()

			' Create a check box cell.
			Dim checkCell As New DXHtmlTableCell()
			Dim checkBox1 As New DXHtmlGenericControl(DXHtmlTextWriterTag.Input)
			checkBox1.Attributes("checked") = "true"
			checkBox1.Attributes("type") = "CheckBox"
			checkCell.Controls.Add(checkBox1)

			' Create a hyperlink cell.
			Dim linkCell As New DXHtmlTableCell()
			Dim hypLink As New DXHtmlAnchor()
			hypLink.InnerText = "XtraReports Web Page"
			hypLink.HRef = "http://www.devexpress.com/Products/NET/Reporting/index.xml"
			linkCell.Controls.Add(hypLink)

			' Add the created cells to the parent row.
			parentRow.Cells.Add(checkCell)
			parentRow.Cells.Add(linkCell)
		End Sub

	End Class
End Namespace

