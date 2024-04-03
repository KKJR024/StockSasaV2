<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PanelMenu2 = New Panel()
        PanelBtns = New Panel()
        IconButtonLogout = New FontAwesome.Sharp.IconButton()
        IconButtonReport = New FontAwesome.Sharp.IconButton()
        IconButtonSO = New FontAwesome.Sharp.IconButton()
        IconButtonPurchace = New FontAwesome.Sharp.IconButton()
        IconButtonSales = New FontAwesome.Sharp.IconButton()
        IconButtonInventory = New FontAwesome.Sharp.IconButton()
        IconButtonDashboard = New FontAwesome.Sharp.IconButton()
        PanelLogo = New Panel()
        PictureBoxLogo = New PictureBox()
        PanelMenu = New Panel()
        LabelHome = New Label()
        IconNotifications = New FontAwesome.Sharp.IconPictureBox()
        IconSettings = New FontAwesome.Sharp.IconPictureBox()
        IconHome = New FontAwesome.Sharp.IconPictureBox()
        Panel1 = New Panel()
        PanelMenu2.SuspendLayout()
        PanelBtns.SuspendLayout()
        PanelLogo.SuspendLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        PanelMenu.SuspendLayout()
        CType(IconNotifications, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconSettings, ComponentModel.ISupportInitialize).BeginInit()
        CType(IconHome, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelMenu2
        ' 
        PanelMenu2.BackColor = Color.DarkSlateGray
        PanelMenu2.Controls.Add(PanelBtns)
        PanelMenu2.Controls.Add(IconButtonDashboard)
        PanelMenu2.Controls.Add(PanelLogo)
        PanelMenu2.Dock = DockStyle.Left
        PanelMenu2.Location = New Point(0, 0)
        PanelMenu2.Name = "PanelMenu2"
        PanelMenu2.Size = New Size(200, 569)
        PanelMenu2.TabIndex = 0
        ' 
        ' PanelBtns
        ' 
        PanelBtns.BackColor = Color.DarkSlateGray
        PanelBtns.Controls.Add(IconButtonLogout)
        PanelBtns.Controls.Add(IconButtonReport)
        PanelBtns.Controls.Add(IconButtonSO)
        PanelBtns.Controls.Add(IconButtonPurchace)
        PanelBtns.Controls.Add(IconButtonSales)
        PanelBtns.Controls.Add(IconButtonInventory)
        PanelBtns.Dock = DockStyle.Left
        PanelBtns.Location = New Point(0, 139)
        PanelBtns.Name = "PanelBtns"
        PanelBtns.Size = New Size(200, 430)
        PanelBtns.TabIndex = 2
        ' 
        ' IconButtonLogout
        ' 
        IconButtonLogout.Dock = DockStyle.Bottom
        IconButtonLogout.FlatAppearance.BorderSize = 0
        IconButtonLogout.FlatStyle = FlatStyle.Flat
        IconButtonLogout.IconChar = FontAwesome.Sharp.IconChar.SignOut
        IconButtonLogout.IconColor = Color.Black
        IconButtonLogout.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButtonLogout.IconSize = 25
        IconButtonLogout.ImageAlign = ContentAlignment.MiddleLeft
        IconButtonLogout.Location = New Point(0, 401)
        IconButtonLogout.Name = "IconButtonLogout"
        IconButtonLogout.Size = New Size(200, 29)
        IconButtonLogout.TabIndex = 7
        IconButtonLogout.Text = "Log Out"
        IconButtonLogout.TextAlign = ContentAlignment.MiddleLeft
        IconButtonLogout.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButtonLogout.UseVisualStyleBackColor = True
        ' 
        ' IconButtonReport
        ' 
        IconButtonReport.Dock = DockStyle.Top
        IconButtonReport.FlatAppearance.BorderSize = 0
        IconButtonReport.FlatStyle = FlatStyle.Flat
        IconButtonReport.IconChar = FontAwesome.Sharp.IconChar.Print
        IconButtonReport.IconColor = Color.Black
        IconButtonReport.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButtonReport.IconSize = 25
        IconButtonReport.ImageAlign = ContentAlignment.TopLeft
        IconButtonReport.Location = New Point(0, 116)
        IconButtonReport.Name = "IconButtonReport"
        IconButtonReport.Padding = New Padding(0, 0, 20, 0)
        IconButtonReport.Size = New Size(200, 29)
        IconButtonReport.TabIndex = 6
        IconButtonReport.Text = "Reports"
        IconButtonReport.TextAlign = ContentAlignment.MiddleLeft
        IconButtonReport.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButtonReport.UseVisualStyleBackColor = True
        ' 
        ' IconButtonSO
        ' 
        IconButtonSO.Dock = DockStyle.Top
        IconButtonSO.FlatAppearance.BorderSize = 0
        IconButtonSO.FlatStyle = FlatStyle.Flat
        IconButtonSO.IconChar = FontAwesome.Sharp.IconChar.Trash
        IconButtonSO.IconColor = Color.Black
        IconButtonSO.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButtonSO.IconSize = 25
        IconButtonSO.ImageAlign = ContentAlignment.TopLeft
        IconButtonSO.Location = New Point(0, 87)
        IconButtonSO.Name = "IconButtonSO"
        IconButtonSO.Padding = New Padding(0, 0, 20, 0)
        IconButtonSO.Size = New Size(200, 29)
        IconButtonSO.TabIndex = 5
        IconButtonSO.Text = "Stockout"
        IconButtonSO.TextAlign = ContentAlignment.MiddleLeft
        IconButtonSO.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButtonSO.UseVisualStyleBackColor = True
        ' 
        ' IconButtonPurchace
        ' 
        IconButtonPurchace.Dock = DockStyle.Top
        IconButtonPurchace.FlatAppearance.BorderSize = 0
        IconButtonPurchace.FlatStyle = FlatStyle.Flat
        IconButtonPurchace.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt
        IconButtonPurchace.IconColor = Color.Black
        IconButtonPurchace.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButtonPurchace.IconSize = 25
        IconButtonPurchace.ImageAlign = ContentAlignment.TopLeft
        IconButtonPurchace.Location = New Point(0, 58)
        IconButtonPurchace.Name = "IconButtonPurchace"
        IconButtonPurchace.Padding = New Padding(0, 0, 20, 0)
        IconButtonPurchace.Size = New Size(200, 29)
        IconButtonPurchace.TabIndex = 4
        IconButtonPurchace.Text = "Purchase"
        IconButtonPurchace.TextAlign = ContentAlignment.MiddleLeft
        IconButtonPurchace.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButtonPurchace.UseVisualStyleBackColor = True
        ' 
        ' IconButtonSales
        ' 
        IconButtonSales.Dock = DockStyle.Top
        IconButtonSales.FlatAppearance.BorderSize = 0
        IconButtonSales.FlatStyle = FlatStyle.Flat
        IconButtonSales.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar
        IconButtonSales.IconColor = Color.Black
        IconButtonSales.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButtonSales.IconSize = 25
        IconButtonSales.ImageAlign = ContentAlignment.TopLeft
        IconButtonSales.Location = New Point(0, 29)
        IconButtonSales.Name = "IconButtonSales"
        IconButtonSales.Padding = New Padding(0, 0, 20, 0)
        IconButtonSales.Size = New Size(200, 29)
        IconButtonSales.TabIndex = 3
        IconButtonSales.Text = "Sales"
        IconButtonSales.TextAlign = ContentAlignment.MiddleLeft
        IconButtonSales.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButtonSales.UseVisualStyleBackColor = True
        ' 
        ' IconButtonInventory
        ' 
        IconButtonInventory.Dock = DockStyle.Top
        IconButtonInventory.FlatAppearance.BorderSize = 0
        IconButtonInventory.FlatStyle = FlatStyle.Flat
        IconButtonInventory.ForeColor = SystemColors.ActiveCaptionText
        IconButtonInventory.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked
        IconButtonInventory.IconColor = Color.Black
        IconButtonInventory.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButtonInventory.IconSize = 25
        IconButtonInventory.ImageAlign = ContentAlignment.TopLeft
        IconButtonInventory.Location = New Point(0, 0)
        IconButtonInventory.Name = "IconButtonInventory"
        IconButtonInventory.Padding = New Padding(0, 0, 20, 0)
        IconButtonInventory.Size = New Size(200, 29)
        IconButtonInventory.TabIndex = 2
        IconButtonInventory.Text = "Inventory"
        IconButtonInventory.TextAlign = ContentAlignment.MiddleLeft
        IconButtonInventory.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButtonInventory.UseVisualStyleBackColor = True
        ' 
        ' IconButtonDashboard
        ' 
        IconButtonDashboard.Dock = DockStyle.Top
        IconButtonDashboard.FlatAppearance.BorderSize = 0
        IconButtonDashboard.FlatStyle = FlatStyle.Flat
        IconButtonDashboard.IconChar = FontAwesome.Sharp.IconChar.Navicon
        IconButtonDashboard.IconColor = Color.Black
        IconButtonDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconButtonDashboard.IconSize = 25
        IconButtonDashboard.ImageAlign = ContentAlignment.MiddleLeft
        IconButtonDashboard.Location = New Point(0, 110)
        IconButtonDashboard.Name = "IconButtonDashboard"
        IconButtonDashboard.Padding = New Padding(0, 0, 20, 0)
        IconButtonDashboard.Size = New Size(200, 29)
        IconButtonDashboard.TabIndex = 1
        IconButtonDashboard.Text = "Dashboard"
        IconButtonDashboard.TextAlign = ContentAlignment.MiddleLeft
        IconButtonDashboard.TextImageRelation = TextImageRelation.ImageBeforeText
        IconButtonDashboard.UseVisualStyleBackColor = True
        ' 
        ' PanelLogo
        ' 
        PanelLogo.Controls.Add(PictureBoxLogo)
        PanelLogo.Dock = DockStyle.Top
        PanelLogo.Location = New Point(0, 0)
        PanelLogo.Name = "PanelLogo"
        PanelLogo.Size = New Size(200, 110)
        PanelLogo.TabIndex = 0
        ' 
        ' PictureBoxLogo
        ' 
        PictureBoxLogo.BackgroundImage = CType(resources.GetObject("PictureBoxLogo.BackgroundImage"), Image)
        PictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom
        PictureBoxLogo.Dock = DockStyle.Fill
        PictureBoxLogo.Location = New Point(0, 0)
        PictureBoxLogo.Name = "PictureBoxLogo"
        PictureBoxLogo.Size = New Size(200, 110)
        PictureBoxLogo.TabIndex = 0
        PictureBoxLogo.TabStop = False
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.Teal
        PanelMenu.Controls.Add(LabelHome)
        PanelMenu.Controls.Add(IconNotifications)
        PanelMenu.Controls.Add(IconSettings)
        PanelMenu.Controls.Add(IconHome)
        PanelMenu.Dock = DockStyle.Top
        PanelMenu.Location = New Point(200, 0)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(796, 30)
        PanelMenu.TabIndex = 1
        ' 
        ' LabelHome
        ' 
        LabelHome.AutoSize = True
        LabelHome.Location = New Point(32, 9)
        LabelHome.Name = "LabelHome"
        LabelHome.Size = New Size(50, 20)
        LabelHome.TabIndex = 3
        LabelHome.Text = "Home"
        ' 
        ' IconNotifications
        ' 
        IconNotifications.BackColor = Color.Teal
        IconNotifications.Dock = DockStyle.Right
        IconNotifications.ForeColor = SystemColors.ControlText
        IconNotifications.IconChar = FontAwesome.Sharp.IconChar.PaperPlane
        IconNotifications.IconColor = SystemColors.ControlText
        IconNotifications.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconNotifications.IconSize = 30
        IconNotifications.Location = New Point(716, 0)
        IconNotifications.Name = "IconNotifications"
        IconNotifications.Size = New Size(40, 30)
        IconNotifications.TabIndex = 2
        IconNotifications.TabStop = False
        ' 
        ' IconSettings
        ' 
        IconSettings.BackColor = Color.Teal
        IconSettings.Dock = DockStyle.Right
        IconSettings.ForeColor = SystemColors.ControlText
        IconSettings.IconChar = FontAwesome.Sharp.IconChar.Sliders
        IconSettings.IconColor = SystemColors.ControlText
        IconSettings.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconSettings.IconSize = 30
        IconSettings.Location = New Point(756, 0)
        IconSettings.Name = "IconSettings"
        IconSettings.Size = New Size(40, 30)
        IconSettings.TabIndex = 1
        IconSettings.TabStop = False
        ' 
        ' IconHome
        ' 
        IconHome.BackColor = Color.Teal
        IconHome.Dock = DockStyle.Left
        IconHome.ForeColor = SystemColors.ControlText
        IconHome.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt
        IconHome.IconColor = SystemColors.ControlText
        IconHome.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconHome.IconSize = 30
        IconHome.Location = New Point(0, 0)
        IconHome.Name = "IconHome"
        IconHome.Size = New Size(40, 30)
        IconHome.TabIndex = 0
        IconHome.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.SlateGray
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(200, 30)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(796, 539)
        Panel1.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(996, 569)
        Controls.Add(Panel1)
        Controls.Add(PanelMenu)
        Controls.Add(PanelMenu2)
        Name = "Form1"
        Text = "Home"
        PanelMenu2.ResumeLayout(False)
        PanelBtns.ResumeLayout(False)
        PanelLogo.ResumeLayout(False)
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        PanelMenu.ResumeLayout(False)
        PanelMenu.PerformLayout()
        CType(IconNotifications, ComponentModel.ISupportInitialize).EndInit()
        CType(IconSettings, ComponentModel.ISupportInitialize).EndInit()
        CType(IconHome, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMenu2 As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents IconButtonDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelBtns As Panel
    Friend WithEvents IconButtonSO As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonPurchace As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonSales As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonInventory As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButtonReport As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents IconHome As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconSettings As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconNotifications As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconButtonLogout As FontAwesome.Sharp.IconButton
    Friend WithEvents LabelHome As Label
    Friend WithEvents Panel1 As Panel

End Class
