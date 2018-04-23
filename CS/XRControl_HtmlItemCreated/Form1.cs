using System;
using System.Diagnostics;
using System.Windows.Forms;
// ...

namespace XRControl_HtmlItemCreated {

    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();
            report.ExportToHtml("Test.html");
            StartProcess("Test.html");
        }

        public void StartProcess(string path) {
            Process process = new Process();
            try {
                process.StartInfo.FileName = path;
                process.Start();
                process.WaitForInputIdle();
            }
            catch { }
        }
    }
}
