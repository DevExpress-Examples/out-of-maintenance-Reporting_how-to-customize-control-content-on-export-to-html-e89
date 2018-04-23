using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace docXRControlHtmlItemCreated {
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