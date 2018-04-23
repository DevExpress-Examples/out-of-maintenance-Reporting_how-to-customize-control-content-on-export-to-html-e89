Imports System
Imports System.Diagnostics
Imports System.Windows.Forms
' ...

Namespace XRControl_HtmlItemCreated

    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            Dim report As New XtraReport1()
            report.ExportToHtml("Test.html")
            StartProcess("Test.html")
        End Sub

        Public Sub StartProcess(ByVal path As String)
            Dim process As New Process()
            Try
                process.StartInfo.FileName = path
                process.Start()
                process.WaitForInputIdle()
            Catch
            End Try
        End Sub
    End Class
End Namespace
