using System.Web.UI.HtmlControls;
using DevExpress.XtraReports.UI;
// ...


namespace docXRControlHtmlItemCreated {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void xrLabel1_HtmlItemCreated(object sender, HtmlEventArgs e) {
            // Clear the contents of the parent html row.
            HtmlTableRow parentRow = (HtmlTableRow)e.ContentCell.Parent;
            parentRow.Controls.Clear();

            // Create a check box cell.
            HtmlTableCell checkCell = new HtmlTableCell();
            System.Web.UI.WebControls.CheckBox checkBox1 = new System.Web.UI.WebControls.CheckBox();
            checkBox1.Checked = true;
            checkCell.Controls.Add(checkBox1);

            // Create a hyperlink cell.
            HtmlTableCell linkCell = new HtmlTableCell();
            System.Web.UI.WebControls.HyperLink hypLink = new System.Web.UI.WebControls.HyperLink();
            hypLink.Text = "XtraReports Web Page";
            hypLink.NavigateUrl = "http://www.devexpress.com/Products/NET/Reporting/index.xml";
            linkCell.Controls.Add(hypLink);

            // Add the created cells to the parent row.
            parentRow.Cells.Add(checkCell);
            parentRow.Cells.Add(linkCell);
        }

    }
}

