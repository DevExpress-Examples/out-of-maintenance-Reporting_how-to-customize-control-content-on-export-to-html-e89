using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting.HtmlExport;
using DevExpress.XtraPrinting.HtmlExport.Controls;
// ...


namespace docXRControlHtmlItemCreated {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void xrLabel1_HtmlItemCreated(object sender, HtmlEventArgs e) {
            // Clear the contents of the parent html row.
            DXHtmlTableRow parentRow = (DXHtmlTableRow)e.ContentCell.Parent;
            parentRow.Controls.Clear();

            // Create a check box cell.
            DXHtmlTableCell checkCell = new DXHtmlTableCell();
            DXHtmlGenericControl checkBox1 = new DXHtmlGenericControl(DXHtmlTextWriterTag.Input);
            checkBox1.Attributes["checked"] = "true";
            checkBox1.Attributes["type"] = "CheckBox";
            checkCell.Controls.Add(checkBox1);

            // Create a hyperlink cell.
            DXHtmlTableCell linkCell = new DXHtmlTableCell();
            DXHtmlAnchor hypLink = new DXHtmlAnchor();
            hypLink.InnerText = "XtraReports Web Page";
            hypLink.HRef = "http://www.devexpress.com/Products/NET/Reporting/index.xml";
            linkCell.Controls.Add(hypLink);

            // Add the created cells to the parent row.
            parentRow.Cells.Add(checkCell);
            parentRow.Cells.Add(linkCell);
        }

    }
}

