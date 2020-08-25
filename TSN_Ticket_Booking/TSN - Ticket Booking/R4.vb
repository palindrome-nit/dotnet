Imports CrystalDecisions.CrystalReports.Engine
Public Class R4
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.Location = New System.Drawing.Point(10, 10)
        Me.crv.Name = "crv"
        Me.crv.ReportSource = Nothing
        Me.crv.Size = New System.Drawing.Size(784, 480)
        Me.crv.TabIndex = 3
        '
        'R4
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(804, 501)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.crv})
        Me.Name = "R4"
        Me.Text = "R4"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private HasConnected As Boolean = False
    Private ServerName As String = "orcl"

    Private Sub R3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim tbCurrent As CrystalDecisions.CrystalReports.Engine.Table
        Dim tliCurrent As CrystalDecisions.Shared.TableLogOnInfo
        Dim rptExpensiveProducts As New ReportDocument()

        Try
            rptExpensiveProducts.Load("..\CrystalReport4.rpt")
            For Each tbCurrent In rptExpensiveProducts.Database.Tables
                tliCurrent = tbCurrent.LogOnInfo
                With tliCurrent.ConnectionInfo
                    .ServerName = ServerName
                    .UserID = "lp"
                    .Password = "lp"
                End With
                tbCurrent.ApplyLogOnInfo(tliCurrent)
            Next tbCurrent

            crv.ReportSource = rptExpensiveProducts
        Catch Exp As LoadSaveReportException
            MsgBox("Incorrect path for loading report.", _
                    MsgBoxStyle.Critical, "Load Report Error")
        Catch Exp As Exception
            MsgBox(Exp.Message, MsgBoxStyle.Critical, "General Error")
        End Try

    End Sub
End Class
