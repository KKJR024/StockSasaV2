<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInventory
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label6 = New Label()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label7 = New Label()
        TextBox6 = New TextBox()
        Label8 = New Label()
        SaveButton = New Button()
        CancelButton = New Button()
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, 0)
        Label1.Location = New Point(29, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(207, 46)
        Label1.TabIndex = 0
        Label1.Text = "INVENTORY"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(29, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 20)
        Label2.TabIndex = 1
        Label2.Text = "Product ID "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(29, 175)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 20)
        Label3.TabIndex = 2
        Label3.Text = "Product Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(29, 219)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 20)
        Label4.TabIndex = 3
        Label4.Text = "Quantity"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(29, 261)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 20)
        Label5.TabIndex = 4
        Label5.Text = "Buying price"
        ' 
        ' IconPictureBox1
        ' 
        IconPictureBox1.BackColor = Color.SlateGray
        IconPictureBox1.Dock = DockStyle.Right
        IconPictureBox1.ForeColor = SystemColors.ControlText
        IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.BoxesStacked
        IconPictureBox1.IconColor = SystemColors.ControlText
        IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto
        IconPictureBox1.IconSize = 242
        IconPictureBox1.Location = New Point(558, 0)
        IconPictureBox1.Name = "IconPictureBox1"
        IconPictureBox1.Size = New Size(242, 450)
        IconPictureBox1.TabIndex = 5
        IconPictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(118, 127)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(207, 27)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(139, 175)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(186, 27)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(100, 219)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(231, 222)
        Label6.Name = "Label6"
        Label6.Size = New Size(42, 20)
        Label6.TabIndex = 9
        Label6.Text = "Units"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(270, 222)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(55, 27)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(126, 258)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(125, 27)
        TextBox5.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(29, 302)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 20)
        Label7.TabIndex = 12
        Label7.Text = "Selling price"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(126, 299)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(125, 27)
        TextBox6.TabIndex = 13
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(257, 306)
        Label8.Name = "Label8"
        Label8.Size = New Size(33, 20)
        Label8.TabIndex = 14
        Label8.Text = ".ksh"
        ' 
        ' SaveButton
        ' 
        SaveButton.FlatAppearance.BorderSize = 0
        SaveButton.FlatStyle = FlatStyle.Popup
        SaveButton.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        SaveButton.Location = New Point(54, 371)
        SaveButton.Name = "SaveButton"
        SaveButton.Size = New Size(106, 34)
        SaveButton.TabIndex = 15
        SaveButton.Text = "Save"
        SaveButton.UseVisualStyleBackColor = True
        ' 
        ' CancelButton
        ' 
        CancelButton.BackColor = Color.LightSlateGray
        CancelButton.FlatAppearance.BorderSize = 0
        CancelButton.FlatStyle = FlatStyle.Popup
        CancelButton.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        CancelButton.Location = New Point(196, 371)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(94, 34)
        CancelButton.TabIndex = 16
        CancelButton.Text = "Cancel"
        CancelButton.UseVisualStyleBackColor = False
        ' 
        ' FormInventory
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SlateGray
        ClientSize = New Size(800, 450)
        Controls.Add(CancelButton)
        Controls.Add(SaveButton)
        Controls.Add(Label8)
        Controls.Add(TextBox6)
        Controls.Add(Label7)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(Label6)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(IconPictureBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormInventory"
        Text = "Inventory"
        CType(IconPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents CancelButton As Button
End Class
