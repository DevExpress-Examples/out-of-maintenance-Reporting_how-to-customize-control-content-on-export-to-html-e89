<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128600060/10.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E89)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [XtraReport1.cs](./CS/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/XtraReport1.vb))
<!-- default file list end -->
# How to customize control content on export to HTML 


<p>The following example demonstrates how to use the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXRControl_HtmlItemCreatedtopic">XRControl.HtmlItemCreated</a> event to customize content of an <a href="https://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsUIXRLabeltopic">XRLabel</a> control when a report is <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument2575">exported to HTML</a>. In the event handler, create two custom HTML elements, which will display a check box and a hyperlink on a Web page, and add them to the control's content using the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIHtmlEventArgs_ContentCelltopic">ContentCell</a> property of the event parameter.<br><br></p>


<h3>Description</h3>

<p>The handler method below creates two DevExpress.XtraPrinting.HtmlExport.Controls.DXHtmlTableCell objects, which display a check box and a hyperlink on a Web page.</p>

<br/>


