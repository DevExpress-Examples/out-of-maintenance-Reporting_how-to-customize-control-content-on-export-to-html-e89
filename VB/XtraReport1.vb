Imports System.Web.UI.HtmlControls
Imports DevExpress.XtraReports.UI
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
            Dim parentRow As HtmlTableRow = CType(e.ContentCell.Parent, HtmlTableRow)
            parentRow.Controls.Clear()

            ' Create a check box cell.
            Dim checkCell As New HtmlTableCell()
            Dim checkBox1 As New System.Web.UI.WebControls.CheckBox()
            checkBox1.Checked = True
            checkCell.Controls.Add(checkBox1)

            ' Create a hyperlink cell.
            Dim linkCell As New HtmlTableCell()
            Dim hypLink As New System.Web.UI.WebControls.HyperLink()
            hypLink.Text = "XtraReports Web Page"
            hypLink.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/index.xml"
            linkCell.Controls.Add(hypLink)

            ' Add the created cells to the parent row.
            parentRow.Cells.Add(checkCell)
            parentRow.Cells.Add(linkCell)
        End Sub

    End Class
End Namespace
