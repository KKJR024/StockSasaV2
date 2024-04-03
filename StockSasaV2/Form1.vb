Imports FontAwesome.Sharp

Public Class Form1
    'Fields'
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    'constructor'
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel With {
            .Size = New Size(5, 29)
        }
        PanelMenu.Controls.Add(leftBorderBtn)

    End Sub

    'methods'
    Private Sub ActivationButton(senderBtn As Object, customcolor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(8, 143, 143)
            currentBtn.ForeColor = customcolor
            currentBtn.IconColor = customcolor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            leftBorderBtn.BackColor = customcolor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form icon'
            IconHome.IconChar = currentBtn.IconChar
            IconHome.IconColor = customcolor

        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(95, 158, 160)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If

    End Sub

    Private Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Panel1.Controls.Add(childForm)
        Panel1.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        LabelHome.Text = childForm.Text
    End Sub

    'Events'
    Private Sub IconButtonDashboard_Click(sender As Object, e As EventArgs) Handles IconButtonDashboard.Click
        ActivateButton(sender, Color.FromArgb(9, 121, 105))
        OpenChildForm(New FormDashboard)
    End Sub

    Private Sub IconButtonInventory_Click(sender As Object, e As EventArgs) Handles IconButtonInventory.Click
        ActivateButton(sender, Color.FromArgb(2, 48, 32))
        OpenChildForm(New FormInventory)
    End Sub

    Private Sub IconButtonSales_Click(sender As Object, e As EventArgs) Handles IconButtonSales.Click
        ActivateButton(sender, Color.FromArgb(95, 133, 117))
        OpenChildForm(New FormSales)
    End Sub

    Private Sub IconButtonPurchace_Click(sender As Object, e As EventArgs) Handles IconButtonPurchace.Click
        ActivateButton(sender, Color.FromArgb(0, 163, 108))
        OpenChildForm(New FormPurchaces)
    End Sub

    Private Sub IconButtonSO_Click(sender As Object, e As EventArgs) Handles IconButtonSO.Click
        ActivateButton(sender, Color.FromArgb(71, 135, 120))
        OpenChildForm(New FormSO)
    End Sub
    Private Sub IconButtonReport_Click(sender As Object, e As EventArgs) Handles IconButtonReport.Click
        ActivateButton(sender, Color.FromArgb(193, 225, 193))
        OpenChildForm(New FormReports)
    End Sub
    Private Sub IconButtonLogout_Click(sender As Object, e As EventArgs) Handles IconButtonLogout.Click
        ActivateButton(sender, Color.FromArgb(64, 224, 206))
    End Sub
    Private Sub ActivateButton(sender As Object, color As Color)
        Dim button As Button = TryCast(sender, Button)

        If button IsNot Nothing Then
            button.Enabled = True
            button.BackColor = color
        End If
    End Sub
    Private Sub IconHome_Click(sender As Object, e As EventArgs) Handles IconHome.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        Reset()
    End Sub
    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        IconHome.IconChar = IconChar.Home
        IconHome.IconColor = Color.Black
        LabelHome.Text = "Home"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
