Public Class Home
    Public Shared player_name As String



    'Put the window in the center of the screen
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub




    Private Sub btn_easy_Click(sender As Object, e As EventArgs) Handles btn_easy.Click
        'Associate the name of the player with the txtbox
        player_name = txtbox_name.Text
        'Player cannot play if name is empty
        If String.IsNullOrEmpty(player_name) OrElse player_name.Length > 18 Then
            MsgBox("Please enter your name (no more than 18 characters)", MsgBoxStyle.Exclamation, "Input")
            'Redirect to the easy window
        Else
            Dim easy As New Easy() ' Create a new instance of Easy
            easy.StartPosition = FormStartPosition.CenterScreen
            easy.Show() ' Show Easy
            Me.Hide() ' Optional: Hide the current form
        End If
    End Sub
    Private Sub btn_medium_Click(sender As Object, e As EventArgs) Handles btn_medium.Click
        'Associate the name of the player with the txtbox
        player_name = txtbox_name.Text
        'Player cannot play if name is empty
        If String.IsNullOrEmpty(player_name) OrElse player_name.Length > 18 Then
            MsgBox("Please enter your name (no more than 18 characters)", MsgBoxStyle.Exclamation, "Input")
            'Redirect to the easy window
        Else
            Dim medium As New Medium() ' Create a new instance of Easy
            medium.StartPosition = FormStartPosition.CenterScreen
            medium.Show() ' Show Easy
            Me.Hide() ' Optional: Hide the current form
        End If
    End Sub

    Private Sub btn_hard_Click_1(sender As Object, e As EventArgs) Handles btn_hard.Click
        'Associate the name of the player with the txtbox
        player_name = txtbox_name.Text
        'Player cannot play if name is empty
        If String.IsNullOrEmpty(player_name) OrElse player_name.Length > 18 Then
            MsgBox("Please enter your name (no more than 18 characters)", MsgBoxStyle.Exclamation, "Input")
            'Redirect to the easy window
        Else
            Dim hard As New Hard() ' Create a new instance of Easy
            hard.StartPosition = FormStartPosition.CenterScreen
            hard.Show() ' Show Easy
            Me.Hide() ' Optional: Hide the current form
        End If
    End Sub


End Class

