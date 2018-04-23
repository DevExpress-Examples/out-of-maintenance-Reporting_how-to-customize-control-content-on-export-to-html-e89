Imports DevExpress.XtraPrinting.HtmlExport
Imports DevExpress.XtraPrinting.HtmlExport.Controls
Imports DevExpress.XtraReports.UI
' ...

Namespace XRControl_HtmlItemCreated

    Partial Public Class XtraReport1
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub xrLabel1_HtmlItemCreated(ByVal sender As Object, ByVal e As HtmlEventArgs) Handles xrLabel1.HtmlItemCreated
            ' Clear content of the currently processed item.
            e.ContentCell.Controls.Clear()

            ' Create a check box. 
            Dim checkBox1 As New DXHtmlGenericControl(DXHtmlTextWriterTag.Input)
            checkBox1.Attributes("checked") = "true"
            checkBox1.Attributes("type") = "CheckBox"

            ' Create a hyperlink. 
            Dim hypLink As New DXHtmlAnchor()
            hypLink.InnerText = "XtraReports Web Page"
            hypLink.HRef = "https://www.devexpress.com/Subscriptions/Reporting/"

            ' Add the created elements to the item's content. 
            e.ContentCell.Controls.Add(checkBox1)
            e.ContentCell.Controls.Add(hypLink)
        End Sub
    End Class
End Namespace
