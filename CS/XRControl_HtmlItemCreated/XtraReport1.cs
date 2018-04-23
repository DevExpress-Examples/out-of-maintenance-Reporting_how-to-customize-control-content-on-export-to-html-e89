using DevExpress.XtraPrinting.HtmlExport;
using DevExpress.XtraPrinting.HtmlExport.Controls;
using DevExpress.XtraReports.UI;
// ...

namespace XRControl_HtmlItemCreated {

    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void xrLabel1_HtmlItemCreated(object sender, HtmlEventArgs e) {
            // Clear content of the currently processed item.
            e.ContentCell.Controls.Clear();

            // Create a check box. 
            DXHtmlGenericControl checkBox1 = new DXHtmlGenericControl(DXHtmlTextWriterTag.Input);
            checkBox1.Attributes["checked"] = "true";
            checkBox1.Attributes["type"] = "CheckBox";

            // Create a hyperlink. 
            DXHtmlAnchor hypLink = new DXHtmlAnchor();
            hypLink.InnerText = "XtraReports Web Page";
            hypLink.HRef = "https://www.devexpress.com/Subscriptions/Reporting/";

            // Add the created elements to the item's content. 
            e.ContentCell.Controls.Add(checkBox1);
            e.ContentCell.Controls.Add(hypLink);
        }
    }
}
