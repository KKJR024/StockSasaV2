<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDashboard))
        ProfitPanel = New Panel()
        ReportsPanel = New Panel()
        StockPanel = New Panel()
        ChartsPanel = New Panel()
        Label1 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        ProfitPanel.SuspendLayout()
        StockPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' ProfitPanel
        ' 
        ProfitPanel.BackColor = Color.Green
        ProfitPanel.Controls.Add(Label2)
        ProfitPanel.Controls.Add(Label1)
        ProfitPanel.Location = New Point(62, 35)
        ProfitPanel.Name = "ProfitPanel"
        ProfitPanel.Size = New Size(250, 125)
        ProfitPanel.TabIndex = 0
        ' 
        ' ReportsPanel
        ' 
        ReportsPanel.BackColor = Color.Azure
        ReportsPanel.BackgroundImage = CType(resources.GetObject("ReportsPanel.BackgroundImage"), Image)
        ReportsPanel.BackgroundImageLayout = ImageLayout.Stretch
        ReportsPanel.Location = New Point(62, 203)
        ReportsPanel.Name = "ReportsPanel"
        ReportsPanel.Size = New Size(328, 223)
        ReportsPanel.TabIndex = 1
        ' 
        ' StockPanel
        ' 
        StockPanel.BackColor = Color.Azure
        StockPanel.Controls.Add(Label4)
        StockPanel.Controls.Add(Label3)
        StockPanel.Location = New Point(445, 35)
        StockPanel.Name = "StockPanel"
        StockPanel.Size = New Size(250, 125)
        StockPanel.TabIndex = 2
        ' 
        ' ChartsPanel
        ' 
        ChartsPanel.BackgroundImage = CType(resources.GetObject("ChartsPanel.BackgroundImage"), Image)
        ChartsPanel.BackgroundImageLayout = ImageLayout.Stretch
        ChartsPanel.Location = New Point(445, 229)
        ChartsPanel.Name = "ChartsPanel"
        ChartsPanel.Size = New Size(356, 223)
        ChartsPanel.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(24, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 28)
        Label1.TabIndex = 0
        Label1.Text = "PROFIT "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(31, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 28)
        Label3.TabIndex = 0
        Label3.Text = "STOCK "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(116, 20)
        Label2.TabIndex = 1
        Label2.Text = "Todays Profit is :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(31, 48)
        Label4.Name = "Label4"
        Label4.Size = New Size(137, 20)
        Label4.TabIndex = 1
        Label4.Text = "Stock remaining is :"
        ' 
        ' FormDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SlateGray
        ClientSize = New Size(800, 450)
        Controls.Add(ChartsPanel)
        Controls.Add(StockPanel)
        Controls.Add(ReportsPanel)
        Controls.Add(ProfitPanel)
        Name = "FormDashboard"
        Text = "Dashboard"
        ProfitPanel.ResumeLayout(False)
        ProfitPanel.PerformLayout()
        StockPanel.ResumeLayout(False)
        StockPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ProfitPanel As Panel
    Friend WithEvents ReportsPanel As Panel
    Friend WithEvents StockPanel As Panel
    Friend WithEvents ChartsPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
