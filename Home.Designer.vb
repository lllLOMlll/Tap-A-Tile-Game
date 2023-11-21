<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Home))
        label_title = New Label()
        label_name = New Label()
        txtbox_name = New TextBox()
        btn_easy = New Button()
        btn_medium = New Button()
        btn_hard = New Button()
        SuspendLayout()
        ' 
        ' label_title
        ' 
        label_title.AutoSize = True
        label_title.Font = New Font("Stencil", 36F, FontStyle.Bold, GraphicsUnit.Point)
        label_title.Location = New Point(0, 9)
        label_title.Name = "label_title"
        label_title.Size = New Size(342, 57)
        label_title.TabIndex = 0
        label_title.Text = "Lucky Guess"
        ' 
        ' label_name
        ' 
        label_name.AutoSize = True
        label_name.Font = New Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point)
        label_name.Location = New Point(12, 193)
        label_name.Name = "label_name"
        label_name.Size = New Size(316, 38)
        label_name.TabIndex = 1
        label_name.Text = "Enter your name"
        ' 
        ' txtbox_name
        ' 
        txtbox_name.Font = New Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point)
        txtbox_name.Location = New Point(365, 190)
        txtbox_name.Name = "txtbox_name"
        txtbox_name.Size = New Size(335, 45)
        txtbox_name.TabIndex = 2
        ' 
        ' btn_easy
        ' 
        btn_easy.Font = New Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point)
        btn_easy.Location = New Point(61, 485)
        btn_easy.Name = "btn_easy"
        btn_easy.Size = New Size(183, 62)
        btn_easy.TabIndex = 3
        btn_easy.Text = "Easy"
        btn_easy.UseVisualStyleBackColor = True
        ' 
        ' btn_medium
        ' 
        btn_medium.Font = New Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point)
        btn_medium.Location = New Point(321, 485)
        btn_medium.Name = "btn_medium"
        btn_medium.Size = New Size(183, 62)
        btn_medium.TabIndex = 4
        btn_medium.Text = "Medium"
        btn_medium.UseVisualStyleBackColor = True
        ' 
        ' btn_hard
        ' 
        btn_hard.Font = New Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point)
        btn_hard.Location = New Point(572, 485)
        btn_hard.Name = "btn_hard"
        btn_hard.Size = New Size(183, 62)
        btn_hard.TabIndex = 5
        btn_hard.Text = "Hard"
        btn_hard.UseVisualStyleBackColor = True
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.dice_black_and_white
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 605)
        Controls.Add(btn_hard)
        Controls.Add(btn_medium)
        Controls.Add(btn_easy)
        Controls.Add(txtbox_name)
        Controls.Add(label_name)
        Controls.Add(label_title)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Home"
        Text = "Home"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_to_panel_2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbox_name As TextBox
    Friend WithEvents btn_easy As Button
    Friend WithEvents btn_hard As Button
    Friend WithEvents label_title As Label
    Friend WithEvents label_name As Label
    Friend WithEvents btn_medium As Button
End Class
