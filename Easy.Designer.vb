<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Easy
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Easy))
        label_player_name = New Label()
        btn_home = New Button()
        btn_play_again = New Button()
        btn_1 = New Button()
        btn_2 = New Button()
        btn_3 = New Button()
        btn_4 = New Button()
        btn_7 = New Button()
        btn_5 = New Button()
        btn_8 = New Button()
        btn_6 = New Button()
        btn_9 = New Button()
        label_random_number = New Label()
        label_win = New Label()
        label_lost = New Label()
        label_win_games = New Label()
        label_lost_games = New Label()
        label_tries = New Label()
        label_number_of_tries = New Label()
        SuspendLayout()
        ' 
        ' label_player_name
        ' 
        label_player_name.Font = New Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point)
        label_player_name.Location = New Point(245, 41)
        label_player_name.Name = "label_player_name"
        label_player_name.Size = New Size(285, 29)
        label_player_name.TabIndex = 0
        label_player_name.Text = "Your name here"
        label_player_name.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btn_home
        ' 
        btn_home.BackColor = Color.White
        btn_home.FlatAppearance.MouseDownBackColor = Color.Red
        btn_home.FlatAppearance.MouseOverBackColor = Color.Red
        btn_home.FlatStyle = FlatStyle.Flat
        btn_home.Font = New Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point)
        btn_home.Location = New Point(439, 459)
        btn_home.Name = "btn_home"
        btn_home.Size = New Size(91, 49)
        btn_home.TabIndex = 1
        btn_home.Text = "Exit"
        btn_home.UseVisualStyleBackColor = False
        ' 
        ' btn_play_again
        ' 
        btn_play_again.BackColor = Color.White
        btn_play_again.FlatAppearance.MouseDownBackColor = Color.Lime
        btn_play_again.FlatAppearance.MouseOverBackColor = Color.Lime
        btn_play_again.FlatStyle = FlatStyle.Flat
        btn_play_again.Font = New Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point)
        btn_play_again.Location = New Point(245, 459)
        btn_play_again.Name = "btn_play_again"
        btn_play_again.Size = New Size(182, 49)
        btn_play_again.TabIndex = 2
        btn_play_again.Text = "Play Again"
        btn_play_again.UseVisualStyleBackColor = False
        ' 
        ' btn_1
        ' 
        btn_1.BackColor = SystemColors.ControlLight
        btn_1.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_1.Location = New Point(245, 167)
        btn_1.Name = "btn_1"
        btn_1.Size = New Size(91, 86)
        btn_1.TabIndex = 5
        btn_1.Text = "?"
        btn_1.UseVisualStyleBackColor = False
        ' 
        ' btn_2
        ' 
        btn_2.BackColor = SystemColors.ControlLight
        btn_2.Font = New Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn_2.Location = New Point(342, 167)
        btn_2.Name = "btn_2"
        btn_2.Size = New Size(91, 86)
        btn_2.TabIndex = 6
        btn_2.Text = "?"
        btn_2.UseVisualStyleBackColor = False
        ' 
        ' btn_3
        ' 
        btn_3.BackColor = SystemColors.ControlLight
        btn_3.Font = New Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn_3.Location = New Point(439, 167)
        btn_3.Name = "btn_3"
        btn_3.Size = New Size(91, 86)
        btn_3.TabIndex = 7
        btn_3.Text = "?"
        btn_3.UseVisualStyleBackColor = False
        ' 
        ' btn_4
        ' 
        btn_4.BackColor = SystemColors.ControlLight
        btn_4.Font = New Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn_4.Location = New Point(245, 258)
        btn_4.Name = "btn_4"
        btn_4.Size = New Size(91, 86)
        btn_4.TabIndex = 8
        btn_4.Text = "?"
        btn_4.UseVisualStyleBackColor = False
        ' 
        ' btn_7
        ' 
        btn_7.BackColor = SystemColors.ControlLight
        btn_7.Font = New Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn_7.Location = New Point(245, 350)
        btn_7.Name = "btn_7"
        btn_7.Size = New Size(91, 86)
        btn_7.TabIndex = 9
        btn_7.Text = "?"
        btn_7.UseVisualStyleBackColor = False
        ' 
        ' btn_5
        ' 
        btn_5.BackColor = SystemColors.ControlLight
        btn_5.Font = New Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn_5.Location = New Point(342, 259)
        btn_5.Name = "btn_5"
        btn_5.Size = New Size(91, 86)
        btn_5.TabIndex = 10
        btn_5.Text = "?"
        btn_5.UseVisualStyleBackColor = False
        ' 
        ' btn_8
        ' 
        btn_8.BackColor = SystemColors.ControlLight
        btn_8.Font = New Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn_8.Location = New Point(342, 351)
        btn_8.Name = "btn_8"
        btn_8.Size = New Size(91, 86)
        btn_8.TabIndex = 11
        btn_8.Text = "?"
        btn_8.UseVisualStyleBackColor = False
        ' 
        ' btn_6
        ' 
        btn_6.BackColor = SystemColors.ControlLight
        btn_6.Font = New Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn_6.Location = New Point(439, 259)
        btn_6.Name = "btn_6"
        btn_6.Size = New Size(91, 86)
        btn_6.TabIndex = 12
        btn_6.Text = "?"
        btn_6.UseVisualStyleBackColor = False
        ' 
        ' btn_9
        ' 
        btn_9.BackColor = SystemColors.ControlLight
        btn_9.Font = New Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn_9.Location = New Point(439, 351)
        btn_9.Name = "btn_9"
        btn_9.Size = New Size(91, 86)
        btn_9.TabIndex = 13
        btn_9.Text = "?"
        btn_9.UseVisualStyleBackColor = False
        ' 
        ' label_random_number
        ' 
        label_random_number.AutoSize = True
        label_random_number.Location = New Point(27, 522)
        label_random_number.Name = "label_random_number"
        label_random_number.Size = New Size(32, 15)
        label_random_number.TabIndex = 14
        label_random_number.Text = "Rdm"
        ' 
        ' label_win
        ' 
        label_win.AutoSize = True
        label_win.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        label_win.Font = New Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        label_win.Location = New Point(89, 190)
        label_win.Name = "label_win"
        label_win.Size = New Size(68, 32)
        label_win.TabIndex = 15
        label_win.Text = "Win"
        ' 
        ' label_lost
        ' 
        label_lost.AutoSize = True
        label_lost.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        label_lost.Font = New Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        label_lost.Location = New Point(609, 190)
        label_lost.Name = "label_lost"
        label_lost.Size = New Size(80, 32)
        label_lost.TabIndex = 16
        label_lost.Text = "Lost"
        ' 
        ' label_win_games
        ' 
        label_win_games.AutoSize = True
        label_win_games.BackColor = Color.White
        label_win_games.Font = New Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point)
        label_win_games.Location = New Point(89, 239)
        label_win_games.Name = "label_win_games"
        label_win_games.Size = New Size(69, 76)
        label_win_games.TabIndex = 17
        label_win_games.Text = "0"
        ' 
        ' label_lost_games
        ' 
        label_lost_games.AutoSize = True
        label_lost_games.BackColor = Color.White
        label_lost_games.Font = New Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point)
        label_lost_games.Location = New Point(615, 239)
        label_lost_games.Name = "label_lost_games"
        label_lost_games.Size = New Size(69, 76)
        label_lost_games.TabIndex = 18
        label_lost_games.Text = "0"
        ' 
        ' label_tries
        ' 
        label_tries.AutoSize = True
        label_tries.Font = New Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        label_tries.Location = New Point(311, 110)
        label_tries.Name = "label_tries"
        label_tries.Size = New Size(122, 32)
        label_tries.TabIndex = 19
        label_tries.Text = "Tries : "
        ' 
        ' label_number_of_tries
        ' 
        label_number_of_tries.AutoSize = True
        label_number_of_tries.Font = New Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        label_number_of_tries.Location = New Point(424, 110)
        label_number_of_tries.Name = "label_number_of_tries"
        label_number_of_tries.Size = New Size(31, 32)
        label_number_of_tries.TabIndex = 20
        label_number_of_tries.Text = "0"
        ' 
        ' Easy
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.dice_black_and_white
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 555)
        Controls.Add(label_number_of_tries)
        Controls.Add(label_tries)
        Controls.Add(label_lost_games)
        Controls.Add(label_win_games)
        Controls.Add(label_lost)
        Controls.Add(label_win)
        Controls.Add(label_random_number)
        Controls.Add(btn_9)
        Controls.Add(btn_6)
        Controls.Add(btn_8)
        Controls.Add(btn_5)
        Controls.Add(btn_7)
        Controls.Add(btn_4)
        Controls.Add(btn_3)
        Controls.Add(btn_2)
        Controls.Add(btn_1)
        Controls.Add(btn_play_again)
        Controls.Add(btn_home)
        Controls.Add(label_player_name)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Easy"
        Text = "Easy"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents label_player_name As Label
    Friend WithEvents btn_home As Button
    Friend WithEvents btn_play_again As Button
    Friend WithEvents btn_1 As Button
    Friend WithEvents btn_2 As Button
    Friend WithEvents btn_3 As Button
    Friend WithEvents btn_4 As Button
    Friend WithEvents btn_7 As Button
    Friend WithEvents btn_5 As Button
    Friend WithEvents btn_8 As Button
    Friend WithEvents btn_6 As Button
    Friend WithEvents btn_9 As Button
    Friend WithEvents label_random_number As Label
    Friend WithEvents label_win As Label
    Friend WithEvents label_lost As Label
    Friend WithEvents label_win_games As Label
    Friend WithEvents label_lost_games As Label
    Friend WithEvents label_tries As Label
    Friend WithEvents label_number_of_tries As Label
End Class
