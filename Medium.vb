Public Class Medium
    Public rdmNum1To25 As Integer
    Public isGameRunning As Boolean = True
    Public numTry As Integer = 5
    Public numWin As Integer = 0
    Public numLost As Integer = 0

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Call the method to update the player name label
        DisplayNameOfThePlayer()

        'Display stuff
        DisplayNumberOfTries()
        DisplayNumberOfWin()
        DisplayNumberOfLost()

        ' Generate a random number from 1 to 9
        RandomNumber1To25()

        ' Assign the NumberButton_Click event handler to all number buttons
        AddHandler btn_1.Click, AddressOf NumberButton_Click
        AddHandler btn_2.Click, AddressOf NumberButton_Click
        AddHandler btn_3.Click, AddressOf NumberButton_Click
        AddHandler btn_4.Click, AddressOf NumberButton_Click
        AddHandler btn_5.Click, AddressOf NumberButton_Click
        AddHandler btn_6.Click, AddressOf NumberButton_Click
        AddHandler btn_7.Click, AddressOf NumberButton_Click
        AddHandler btn_8.Click, AddressOf NumberButton_Click
        AddHandler btn_9.Click, AddressOf NumberButton_Click
        AddHandler btn_10.Click, AddressOf NumberButton_Click
        AddHandler btn_11.Click, AddressOf NumberButton_Click
        AddHandler btn_12.Click, AddressOf NumberButton_Click
        AddHandler btn_13.Click, AddressOf NumberButton_Click
        AddHandler btn_14.Click, AddressOf NumberButton_Click
        AddHandler btn_15.Click, AddressOf NumberButton_Click
        AddHandler btn_16.Click, AddressOf NumberButton_Click
        AddHandler btn_17.Click, AddressOf NumberButton_Click
        AddHandler btn_18.Click, AddressOf NumberButton_Click
        AddHandler btn_19.Click, AddressOf NumberButton_Click
        AddHandler btn_20.Click, AddressOf NumberButton_Click
        AddHandler btn_21.Click, AddressOf NumberButton_Click
        AddHandler btn_22.Click, AddressOf NumberButton_Click
        AddHandler btn_23.Click, AddressOf NumberButton_Click
        AddHandler btn_24.Click, AddressOf NumberButton_Click
        AddHandler btn_25.Click, AddressOf NumberButton_Click




    End Sub

    'DISPLAY SUBS
    Private Sub DisplayNameOfThePlayer()
        'player_name is a "Public Shared" variable
        label_player_name.Text = Home.player_name
    End Sub

    Private Sub DisplayNumberOfTries()
        'Display the tries
        label_number_of_tries.Text = numTry
    End Sub

    Private Sub DisplayNumberOfWin()
        label_win_games.Text = numWin
    End Sub

    Private Sub DisplayNumberOfLost()
        label_lost_games.Text = numLost
    End Sub

    'RANDOM
    Private Sub RandomNumber1To25()
        ' Create a new instance of the Random class.
        Dim rand As New Random()

        ' Generate a random number between 1 and 9.
        rdmNum1To25 = rand.Next(1, 26) ' The upper bound is exclusive.

        'Display the random number for Testing purpose
        label_random_number.Text = rdmNum1To25.ToString()
    End Sub

    'CLICK ON A BUTTON
    Private Sub NumberButton_Click(sender As Object, e As EventArgs)
        If isGameRunning = True Then
            ' Cast the sender to a Button to get which button was clicked
            Dim clickedButton As Button = CType(sender, Button)

            ' Extract the number from the button's name.
            ' This assumes that the button's name starts with "btn_" followed by the number.
            Dim buttonNumberString As String = clickedButton.Name.Substring(4)
            Dim buttonNumber As Integer

            If Integer.TryParse(buttonNumberString, buttonNumber) Then
                ' The parse was successful, now you can compare the button number with the random number
                If buttonNumber = rdmNum1To25 Then
                    clickedButton.Text = "YES!"
                    ' Set the font size to 14. You need to create a new Font object.
                    ' The first argument is the font family name, and the second is the size.
                    clickedButton.Font = New Font(clickedButton.Font.FontFamily, 14, FontStyle.Bold)

                    ' Set the background color of the button to green.
                    clickedButton.BackColor = Color.Green
                    MsgBox("You win!", MsgBoxStyle.Exclamation, "WIN!")
                    'Display number of games win
                    numWin += 1
                    DisplayNumberOfWin()
                    'Stop the game when there is a WIN
                    isGameRunning = False


                Else
                    clickedButton.Text = "NO!"
                    ' Set the font size to 14. You need to create a new Font object.
                    ' The first argument is the font family name, and the second is the size.
                    clickedButton.Font = New Font(clickedButton.Font.FontFamily, 14, FontStyle.Bold)

                    ' Set the background color of the button to green.
                    clickedButton.BackColor = Color.Red
                    numTry -= 1
                    DisplayNumberOfTries()
                    'Lost the game afer 3 tries
                    If numTry = 0 Then
                        'Display number of lost games
                        numLost += 1
                        DisplayNumberOfLost()
                        isGameRunning = False
                        MsgBox("You lost!", MsgBoxStyle.Exclamation, "LOST!")
                    End If
                End If
            End If
        Else
            MsgBox("Click on the 'Play Again' button to start a new game", MsgBoxStyle.Exclamation, "Play again")
        End If

    End Sub

    'PLAY AGAIN
    Private Sub Btn_play_again_Click(sender As Object, e As EventArgs) Handles btn_play_again.Click
        If isGameRunning = True Then
            MsgBox("You cannot reset an active game", MsgBoxStyle.Critical, "Reset Game")
        Else
            isGameRunning = True
            ' Reset number of tries
            numTry = 5
            DisplayNumberOfTries()

            ' Assume originalFont and originalBackColor are the default font and back color
            Dim originalFont As Font = New Font("Tahoma", 21.75, FontStyle.Bold)
            Dim originalBackColor As Color = SystemColors.ControlLight

            ' Reset the buttons
            ResetButton(btn_1, originalFont, originalBackColor)
            ResetButton(btn_2, originalFont, originalBackColor)
            ResetButton(btn_3, originalFont, originalBackColor)
            ResetButton(btn_4, originalFont, originalBackColor)
            ResetButton(btn_5, originalFont, originalBackColor)
            ResetButton(btn_6, originalFont, originalBackColor)
            ResetButton(btn_7, originalFont, originalBackColor)
            ResetButton(btn_8, originalFont, originalBackColor)
            ResetButton(btn_9, originalFont, originalBackColor)
            ResetButton(btn_10, originalFont, originalBackColor)
            ResetButton(btn_11, originalFont, originalBackColor)
            ResetButton(btn_12, originalFont, originalBackColor)
            ResetButton(btn_13, originalFont, originalBackColor)
            ResetButton(btn_14, originalFont, originalBackColor)
            ResetButton(btn_15, originalFont, originalBackColor)
            ResetButton(btn_16, originalFont, originalBackColor)
            ResetButton(btn_17, originalFont, originalBackColor)
            ResetButton(btn_18, originalFont, originalBackColor)
            ResetButton(btn_19, originalFont, originalBackColor)
            ResetButton(btn_20, originalFont, originalBackColor)
            ResetButton(btn_21, originalFont, originalBackColor)
            ResetButton(btn_22, originalFont, originalBackColor)
            ResetButton(btn_23, originalFont, originalBackColor)
            ResetButton(btn_24, originalFont, originalBackColor)
            ResetButton(btn_25, originalFont, originalBackColor)


            RandomNumber1To25()
        End If

    End Sub

    Private Sub ResetButton(btn As Button, font As Font, backColor As Color)
        btn.Text = "?"
        btn.Font = font
        btn.BackColor = backColor
        ' Reset any other properties you want to return to the default state
    End Sub


    'EXIT
    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click
        ' Ask the user for confirmation before leaving the current form.
        Dim result As DialogResult = MessageBox.Show("Do you really want to go back to the Home screen?" & vbCrLf & "Everything will be reset (win/lost/tries)", "Confirm", MessageBoxButtons.YesNo)

        ' If the user clicked 'Yes', then proceed to show the Home form and hide the current form.
        If result = DialogResult.Yes Then
            numTry = 5
            numWin = 0
            numLost = 0

            Dim home As New Home()
            home.StartPosition = FormStartPosition.CenterScreen
            home.Show()
            Me.Hide()
        End If
    End Sub


    Private Sub label_games_lost_Click(sender As Object, e As EventArgs) Handles label_lost_games.Click

    End Sub


End Class