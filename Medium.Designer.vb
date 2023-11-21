<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Medium
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Medium))
        label_number_of_tries = New Label()
        label_tries = New Label()
        label_lost_games = New Label()
        label_win_games = New Label()
        label_lost = New Label()
        label_win = New Label()
        label_random_number = New Label()
        btn_1 = New Button()
        btn_play_again = New Button()
        btn_home = New Button()
        label_player_name = New Label()
        btn_2 = New Button()
        btn_6 = New Button()
        btn_11 = New Button()
        btn_16 = New Button()
        btn_21 = New Button()
        btn_3 = New Button()
        btn_4 = New Button()
        btn_5 = New Button()
        btn_7 = New Button()
        btn_8 = New Button()
        btn_9 = New Button()
        btn_10 = New Button()
        btn_12 = New Button()
        btn_13 = New Button()
        btn_14 = New Button()
        btn_15 = New Button()
        btn_17 = New Button()
        btn_18 = New Button()
        btn_19 = New Button()
        btn_20 = New Button()
        btn_22 = New Button()
        btn_23 = New Button()
        btn_24 = New Button()
        btn_25 = New Button()
        SuspendLayout()
        ' 
        ' label_number_of_tries
        ' 
        label_number_of_tries.AutoSize = True
        label_number_of_tries.Font = New Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        label_number_of_tries.Location = New Point(466, 88)
        label_number_of_tries.Name = "label_number_of_tries"
        label_number_of_tries.Size = New Size(31, 32)
        label_number_of_tries.TabIndex = 39
        label_number_of_tries.Text = "0"
        ' 
        ' label_tries
        ' 
        label_tries.AutoSize = True
        label_tries.Font = New Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        label_tries.Location = New Point(353, 88)
        label_tries.Name = "label_tries"
        label_tries.Size = New Size(122, 32)
        label_tries.TabIndex = 38
        label_tries.Text = "Tries : "
        ' 
        ' label_lost_games
        ' 
        label_lost_games.AutoSize = True
        label_lost_games.BackColor = Color.White
        label_lost_games.Font = New Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point)
        label_lost_games.Location = New Point(652, 217)
        label_lost_games.Name = "label_lost_games"
        label_lost_games.Size = New Size(69, 76)
        label_lost_games.TabIndex = 37
        label_lost_games.Text = "0"
        ' 
        ' label_win_games
        ' 
        label_win_games.AutoSize = True
        label_win_games.BackColor = Color.White
        label_win_games.Font = New Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point)
        label_win_games.Location = New Point(131, 217)
        label_win_games.Name = "label_win_games"
        label_win_games.Size = New Size(69, 76)
        label_win_games.TabIndex = 36
        label_win_games.Text = "0"
        ' 
        ' label_lost
        ' 
        label_lost.AutoSize = True
        label_lost.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        label_lost.Font = New Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        label_lost.Location = New Point(646, 168)
        label_lost.Name = "label_lost"
        label_lost.Size = New Size(80, 32)
        label_lost.TabIndex = 35
        label_lost.Text = "Lost"
        ' 
        ' label_win
        ' 
        label_win.AutoSize = True
        label_win.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        label_win.Font = New Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        label_win.Location = New Point(131, 168)
        label_win.Name = "label_win"
        label_win.Size = New Size(68, 32)
        label_win.TabIndex = 34
        label_win.Text = "Win"
        ' 
        ' label_random_number
        ' 
        label_random_number.AutoSize = True
        label_random_number.Location = New Point(26, 560)
        label_random_number.Name = "label_random_number"
        label_random_number.Size = New Size(32, 15)
        label_random_number.TabIndex = 33
        label_random_number.Text = "Rdm"
        ' 
        ' btn_1
        ' 
        btn_1.BackColor = SystemColors.ControlLight
        btn_1.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_1.Location = New Point(232, 144)
        btn_1.Name = "btn_1"
        btn_1.Size = New Size(71, 68)
        btn_1.TabIndex = 24
        btn_1.Text = "?"
        btn_1.UseVisualStyleBackColor = False
        ' 
        ' btn_play_again
        ' 
        btn_play_again.BackColor = Color.White
        btn_play_again.FlatAppearance.MouseDownBackColor = Color.Lime
        btn_play_again.FlatAppearance.MouseOverBackColor = Color.Lime
        btn_play_again.FlatStyle = FlatStyle.Flat
        btn_play_again.Font = New Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point)
        btn_play_again.Location = New Point(275, 526)
        btn_play_again.Name = "btn_play_again"
        btn_play_again.Size = New Size(182, 49)
        btn_play_again.TabIndex = 23
        btn_play_again.Text = "Play Again"
        btn_play_again.UseVisualStyleBackColor = False
        ' 
        ' btn_home
        ' 
        btn_home.BackColor = Color.White
        btn_home.FlatAppearance.MouseDownBackColor = Color.Red
        btn_home.FlatAppearance.MouseOverBackColor = Color.Red
        btn_home.FlatStyle = FlatStyle.Flat
        btn_home.Font = New Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point)
        btn_home.Location = New Point(466, 526)
        btn_home.Name = "btn_home"
        btn_home.Size = New Size(91, 49)
        btn_home.TabIndex = 22
        btn_home.Text = "Exit"
        btn_home.UseVisualStyleBackColor = False
        ' 
        ' label_player_name
        ' 
        label_player_name.Font = New Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point)
        label_player_name.Location = New Point(287, 19)
        label_player_name.Name = "label_player_name"
        label_player_name.Size = New Size(285, 29)
        label_player_name.TabIndex = 21
        label_player_name.Text = "Your name here"
        label_player_name.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btn_2
        ' 
        btn_2.BackColor = SystemColors.ControlLight
        btn_2.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_2.Location = New Point(309, 144)
        btn_2.Name = "btn_2"
        btn_2.Size = New Size(71, 68)
        btn_2.TabIndex = 40
        btn_2.Text = "?"
        btn_2.UseVisualStyleBackColor = False
        ' 
        ' btn_6
        ' 
        btn_6.BackColor = SystemColors.ControlLight
        btn_6.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_6.Location = New Point(232, 218)
        btn_6.Name = "btn_6"
        btn_6.Size = New Size(71, 68)
        btn_6.TabIndex = 41
        btn_6.Text = "?"
        btn_6.UseVisualStyleBackColor = False
        ' 
        ' btn_11
        ' 
        btn_11.BackColor = SystemColors.ControlLight
        btn_11.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_11.Location = New Point(232, 292)
        btn_11.Name = "btn_11"
        btn_11.Size = New Size(71, 68)
        btn_11.TabIndex = 42
        btn_11.Text = "?"
        btn_11.UseVisualStyleBackColor = False
        ' 
        ' btn_16
        ' 
        btn_16.BackColor = SystemColors.ControlLight
        btn_16.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_16.Location = New Point(232, 362)
        btn_16.Name = "btn_16"
        btn_16.Size = New Size(71, 68)
        btn_16.TabIndex = 43
        btn_16.Text = "?"
        btn_16.UseVisualStyleBackColor = False
        ' 
        ' btn_21
        ' 
        btn_21.BackColor = SystemColors.ControlLight
        btn_21.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_21.Location = New Point(232, 436)
        btn_21.Name = "btn_21"
        btn_21.Size = New Size(71, 68)
        btn_21.TabIndex = 44
        btn_21.Text = "?"
        btn_21.UseVisualStyleBackColor = False
        ' 
        ' btn_3
        ' 
        btn_3.BackColor = SystemColors.ControlLight
        btn_3.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_3.Location = New Point(386, 144)
        btn_3.Name = "btn_3"
        btn_3.Size = New Size(71, 68)
        btn_3.TabIndex = 45
        btn_3.Text = "?"
        btn_3.UseVisualStyleBackColor = False
        ' 
        ' btn_4
        ' 
        btn_4.BackColor = SystemColors.ControlLight
        btn_4.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_4.Location = New Point(463, 144)
        btn_4.Name = "btn_4"
        btn_4.Size = New Size(71, 68)
        btn_4.TabIndex = 46
        btn_4.Text = "?"
        btn_4.UseVisualStyleBackColor = False
        ' 
        ' btn_5
        ' 
        btn_5.BackColor = SystemColors.ControlLight
        btn_5.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_5.Location = New Point(540, 144)
        btn_5.Name = "btn_5"
        btn_5.Size = New Size(71, 68)
        btn_5.TabIndex = 47
        btn_5.Text = "?"
        btn_5.UseVisualStyleBackColor = False
        ' 
        ' btn_7
        ' 
        btn_7.BackColor = SystemColors.ControlLight
        btn_7.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_7.Location = New Point(309, 218)
        btn_7.Name = "btn_7"
        btn_7.Size = New Size(71, 68)
        btn_7.TabIndex = 48
        btn_7.Text = "?"
        btn_7.UseVisualStyleBackColor = False
        ' 
        ' btn_8
        ' 
        btn_8.BackColor = SystemColors.ControlLight
        btn_8.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_8.Location = New Point(386, 217)
        btn_8.Name = "btn_8"
        btn_8.Size = New Size(71, 68)
        btn_8.TabIndex = 49
        btn_8.Text = "?"
        btn_8.UseVisualStyleBackColor = False
        ' 
        ' btn_9
        ' 
        btn_9.BackColor = SystemColors.ControlLight
        btn_9.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_9.Location = New Point(463, 217)
        btn_9.Name = "btn_9"
        btn_9.Size = New Size(71, 68)
        btn_9.TabIndex = 50
        btn_9.Text = "?"
        btn_9.UseVisualStyleBackColor = False
        ' 
        ' btn_10
        ' 
        btn_10.BackColor = SystemColors.ControlLight
        btn_10.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_10.Location = New Point(540, 217)
        btn_10.Name = "btn_10"
        btn_10.Size = New Size(71, 68)
        btn_10.TabIndex = 51
        btn_10.Text = "?"
        btn_10.UseVisualStyleBackColor = False
        ' 
        ' btn_12
        ' 
        btn_12.BackColor = SystemColors.ControlLight
        btn_12.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_12.Location = New Point(309, 292)
        btn_12.Name = "btn_12"
        btn_12.Size = New Size(71, 68)
        btn_12.TabIndex = 52
        btn_12.Text = "?"
        btn_12.UseVisualStyleBackColor = False
        ' 
        ' btn_13
        ' 
        btn_13.BackColor = SystemColors.ControlLight
        btn_13.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_13.Location = New Point(386, 291)
        btn_13.Name = "btn_13"
        btn_13.Size = New Size(71, 68)
        btn_13.TabIndex = 53
        btn_13.Text = "?"
        btn_13.UseVisualStyleBackColor = False
        ' 
        ' btn_14
        ' 
        btn_14.BackColor = SystemColors.ControlLight
        btn_14.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_14.Location = New Point(463, 291)
        btn_14.Name = "btn_14"
        btn_14.Size = New Size(71, 68)
        btn_14.TabIndex = 54
        btn_14.Text = "?"
        btn_14.UseVisualStyleBackColor = False
        ' 
        ' btn_15
        ' 
        btn_15.BackColor = SystemColors.ControlLight
        btn_15.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_15.Location = New Point(540, 292)
        btn_15.Name = "btn_15"
        btn_15.Size = New Size(71, 68)
        btn_15.TabIndex = 55
        btn_15.Text = "?"
        btn_15.UseVisualStyleBackColor = False
        ' 
        ' btn_17
        ' 
        btn_17.BackColor = SystemColors.ControlLight
        btn_17.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_17.Location = New Point(309, 362)
        btn_17.Name = "btn_17"
        btn_17.Size = New Size(71, 68)
        btn_17.TabIndex = 56
        btn_17.Text = "?"
        btn_17.UseVisualStyleBackColor = False
        ' 
        ' btn_18
        ' 
        btn_18.BackColor = SystemColors.ControlLight
        btn_18.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_18.Location = New Point(386, 362)
        btn_18.Name = "btn_18"
        btn_18.Size = New Size(71, 68)
        btn_18.TabIndex = 57
        btn_18.Text = "?"
        btn_18.UseVisualStyleBackColor = False
        ' 
        ' btn_19
        ' 
        btn_19.BackColor = SystemColors.ControlLight
        btn_19.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_19.Location = New Point(463, 362)
        btn_19.Name = "btn_19"
        btn_19.Size = New Size(71, 68)
        btn_19.TabIndex = 58
        btn_19.Text = "?"
        btn_19.UseVisualStyleBackColor = False
        ' 
        ' btn_20
        ' 
        btn_20.BackColor = SystemColors.ControlLight
        btn_20.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_20.Location = New Point(540, 362)
        btn_20.Name = "btn_20"
        btn_20.Size = New Size(71, 68)
        btn_20.TabIndex = 59
        btn_20.Text = "?"
        btn_20.UseVisualStyleBackColor = False
        ' 
        ' btn_22
        ' 
        btn_22.BackColor = SystemColors.ControlLight
        btn_22.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_22.Location = New Point(309, 436)
        btn_22.Name = "btn_22"
        btn_22.Size = New Size(71, 68)
        btn_22.TabIndex = 60
        btn_22.Text = "?"
        btn_22.UseVisualStyleBackColor = False
        ' 
        ' btn_23
        ' 
        btn_23.BackColor = SystemColors.ControlLight
        btn_23.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_23.Location = New Point(386, 436)
        btn_23.Name = "btn_23"
        btn_23.Size = New Size(71, 68)
        btn_23.TabIndex = 61
        btn_23.Text = "?"
        btn_23.UseVisualStyleBackColor = False
        ' 
        ' btn_24
        ' 
        btn_24.BackColor = SystemColors.ControlLight
        btn_24.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_24.Location = New Point(463, 436)
        btn_24.Name = "btn_24"
        btn_24.Size = New Size(71, 68)
        btn_24.TabIndex = 62
        btn_24.Text = "?"
        btn_24.UseVisualStyleBackColor = False
        ' 
        ' btn_25
        ' 
        btn_25.BackColor = SystemColors.ControlLight
        btn_25.Font = New Font("Tahoma", 21.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_25.Location = New Point(540, 436)
        btn_25.Name = "btn_25"
        btn_25.Size = New Size(71, 68)
        btn_25.TabIndex = 63
        btn_25.Text = "?"
        btn_25.UseVisualStyleBackColor = False
        ' 
        ' Medium
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.dice_black_and_white
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(843, 602)
        Controls.Add(btn_25)
        Controls.Add(btn_24)
        Controls.Add(btn_23)
        Controls.Add(btn_22)
        Controls.Add(btn_20)
        Controls.Add(btn_19)
        Controls.Add(btn_18)
        Controls.Add(btn_17)
        Controls.Add(btn_15)
        Controls.Add(btn_14)
        Controls.Add(btn_13)
        Controls.Add(btn_12)
        Controls.Add(btn_10)
        Controls.Add(btn_9)
        Controls.Add(btn_8)
        Controls.Add(btn_7)
        Controls.Add(btn_5)
        Controls.Add(btn_4)
        Controls.Add(btn_3)
        Controls.Add(btn_21)
        Controls.Add(btn_16)
        Controls.Add(btn_11)
        Controls.Add(btn_6)
        Controls.Add(btn_2)
        Controls.Add(label_number_of_tries)
        Controls.Add(label_tries)
        Controls.Add(label_lost_games)
        Controls.Add(label_win_games)
        Controls.Add(label_lost)
        Controls.Add(label_win)
        Controls.Add(label_random_number)
        Controls.Add(btn_1)
        Controls.Add(btn_play_again)
        Controls.Add(btn_home)
        Controls.Add(label_player_name)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Medium"
        Text = "Medium"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents label_number_of_tries As Label
    Friend WithEvents label_tries As Label
    Friend WithEvents label_lost_games As Label
    Friend WithEvents label_win_games As Label
    Friend WithEvents label_lost As Label
    Friend WithEvents label_win As Label
    Friend WithEvents label_random_number As Label
    Friend WithEvents btn_1 As Button
    Friend WithEvents btn_play_again As Button
    Friend WithEvents btn_home As Button
    Friend WithEvents label_player_name As Label
    Friend WithEvents btn_2 As Button
    Friend WithEvents btn_6 As Button
    Friend WithEvents btn_11 As Button
    Friend WithEvents btn_16 As Button
    Friend WithEvents btn_21 As Button
    Friend WithEvents btn_3 As Button
    Friend WithEvents btn_4 As Button
    Friend WithEvents btn_5 As Button
    Friend WithEvents btn_7 As Button
    Friend WithEvents btn_8 As Button
    Friend WithEvents btn_9 As Button
    Friend WithEvents btn_10 As Button
    Friend WithEvents btn_12 As Button
    Friend WithEvents btn_13 As Button
    Friend WithEvents btn_14 As Button
    Friend WithEvents btn_15 As Button
    Friend WithEvents btn_17 As Button
    Friend WithEvents btn_18 As Button
    Friend WithEvents btn_19 As Button
    Friend WithEvents btn_20 As Button
    Friend WithEvents btn_22 As Button
    Friend WithEvents btn_23 As Button
    Friend WithEvents btn_24 As Button
    Friend WithEvents btn_25 As Button
End Class
