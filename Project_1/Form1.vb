'Imports System.Drawing.Imaging

Imports System.Drawing.Drawing2D

Public Class Form1

    Dim grid(,) = {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
                  }

    Dim Initcount As Integer = 0 ' used to know whether the first click of the game has happened
    Dim clockDigit As Integer = 0 ' used to alter substring when minutes become double digits



    ' handles the timer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Clock.Text = "60:00" Then
            LostGame()
            Exit Sub
        End If

        Dim ones, tens, min As Integer
        ones = CInt(Clock.Text.Substring(clockDigit + 3, 1))
        tens = CInt(Clock.Text.Substring(clockDigit + 2, 1))
        min = CInt(Clock.Text.Substring(0, clockDigit + 1))

        If ones < 9 Then
            ones += 1
        Else
            ones = 0
            If tens < 5 Then
                tens += 1
            Else
                tens = 0
                min += 1
                If min = 10 Then
                    clockDigit += 1
                End If
            End If
        End If



        Clock.Text = min & ":" & tens & ones
    End Sub

    ' handles the play buttton
    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        PlayButton.Visible = False
        For Each btn As Button In Me.Controls.OfType(Of Button)
            btn.Enabled = True ' enables all buttons 
        Next
        Timer1.Enabled = True ' enables the timer

        RandomFillGrid()
        AssignClickFunction()

    End Sub


    Private Sub AssignClickFunction()
        For Each btn As Button In Me.Controls.OfType(Of Button)
            If btn.Name.StartsWith("B") Then
                AddHandler btn.MouseDown, AddressOf Button_Clicked

            End If
        Next
    End Sub



    Sub Button_Clicked(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        Dim x As Integer = btn.Name.Substring(1, 2)
        Dim y As Integer = btn.Name.Substring(3, 2)
        Dim MinesLabel As Integer = CInt(MinesCountLabel.Text)

        If e.Button = MouseButtons.Right Then

            If MinesLabel > -1 Then
                If btn.BackgroundImageLayout = 0 And MinesLabel > 0 Then

                    btn.BackgroundImageLayout = 3

                    MinesLabel -= 1
                ElseIf btn.BackgroundImageLayout = 3 Then
                    btn.BackgroundImageLayout = 0
                    MinesLabel += 1
                End If

            End If
            MinesCountLabel.Text = MinesLabel.ToString()

        ElseIf btn.BackgroundImageLayout <> 3 Then
            If grid(x, y) = -1 Then
                LostGame()
            Else
                CheckSurroundingSpaces(x, y)
                CheckWin()
            End If
        End If



    End Sub

    Private Sub CheckSurroundingSpaces(x As Integer, y As Integer)
        Dim rand As New Random()


        ' display numbers around button for one first time only
        If Initcount < 1 Then
            For i = rand.Next(-8, -1) To rand.Next(1, 8)
                For j = rand.Next(-8, -1) To rand.Next(1, 8)
                    Dim tempX As Integer = x + i
                    Dim tempY As Integer = y + j

                    ' check if location is within grid bounds
                    If tempX >= 0 And tempX <= 21 And tempY >= 0 And tempY <= 24 Then

                        ' if location contains no bomb 
                        If grid(tempX, tempY) <> -1 Then
                            Dim btn As Button = Me.Controls("B" & tempX.ToString("D2") & tempY.ToString("D2"))
                            If btn.Enabled = True Then
                                If grid(tempX, tempY) <> 0 Then
                                    btn.Text = grid(tempX, tempY).ToString()
                                End If


                                RemoveHandler btn.MouseDown, AddressOf Button_Clicked
                                btn.BackColor = Color.FromArgb(35, 35, 35)

                                ' set font color for each number
                                If grid(tempX, tempY) = 1 Then
                                    btn.ForeColor = Color.Red
                                ElseIf grid(tempX, tempY) = 2 Then
                                    btn.ForeColor = Color.Yellow
                                ElseIf grid(tempX, tempY) = 3 Then
                                    btn.ForeColor = Color.Green
                                ElseIf grid(tempX, tempY) = 4 Then
                                    btn.ForeColor = Color.Aqua
                                ElseIf grid(tempX, tempY) = 5 Then
                                    btn.ForeColor = Color.Magenta
                                ElseIf grid(tempX, tempY) = 6 Then
                                    btn.ForeColor = Color.Pink
                                End If
                            End If


                        End If
                    End If
                Next
            Next
            Initcount += 1
        Else
            ' if location contains no bomb 
            If grid(x, y) <> -1 Then
                Dim btn As Button = Me.Controls("B" & x.ToString("D2") & y.ToString("D2"))

                If grid(x, y) > 0 Then
                    btn.Text = grid(x, y).ToString()
                Else

                    FillZeroSpaces(x, y)

                End If


                RemoveHandler btn.MouseDown, AddressOf Button_Clicked
                btn.BackColor = Color.FromArgb(35, 35, 35)

                ' set font color for each number
                If grid(x, y) = 1 Then
                    btn.ForeColor = Color.Red
                ElseIf grid(x, y) = 2 Then
                    btn.ForeColor = Color.Yellow
                ElseIf grid(x, y) = 3 Then
                    btn.ForeColor = Color.Green
                ElseIf grid(x, y) = 4 Then
                    btn.ForeColor = Color.Aqua
                ElseIf grid(x, y) = 5 Then
                    btn.ForeColor = Color.Magenta
                ElseIf grid(x, y) = 6 Then
                    btn.ForeColor = Color.Pink
                End If

            End If
        End If




    End Sub


    Private Sub FillZeroSpaces(x As Integer, y As Integer)
        grid(x, y) = -2
        For i = -1 To 1
            For j = -1 To 1
                If x + i >= 0 And x + i <= 21 And y + j >= 0 And y + j <= 24 Then
                    Dim btn As Button = Me.Controls("B" & (x + i).ToString("D2") & (y + j).ToString("D2"))
                    RemoveHandler btn.MouseDown, AddressOf Button_Clicked
                    btn.BackColor = Color.FromArgb(35, 35, 35)
                    If grid(x + i, y + j) = 0 Then

                        FillZeroSpaces(x + i, y + j)
                    ElseIf grid(x + i, y + j) > 0 Then
                        btn.Text = grid(x + i, y + j).ToString()

                        ' set font color for each number
                        If grid(x + i, y + j) = 1 Then
                            btn.ForeColor = Color.Red
                        ElseIf grid(x + i, y + j) = 2 Then
                            btn.ForeColor = Color.Yellow
                        ElseIf grid(x + i, y + j) = 3 Then
                            btn.ForeColor = Color.Green
                        ElseIf grid(x + i, y + j) = 4 Then
                            btn.ForeColor = Color.Aqua
                        ElseIf grid(x + i, y + j) = 5 Then
                            btn.ForeColor = Color.Magenta
                        ElseIf grid(x + i, y + j) = 6 Then
                            btn.ForeColor = Color.Pink
                        End If
                    End If
                End If

            Next
        Next
    End Sub


    Sub RandomFillGrid()
        Dim rand As New Random()
        Dim count As Integer = 0

        ' fill grid with 125 mines in random locations
        While count < 125
            Dim x As Integer = rand.Next(0, 22)
            Dim y As Integer = rand.Next(0, 25)

            If grid(x, y) <> -1 Then
                grid(x, y) = -1
                count += 1
            End If

        End While

        For i = 0 To 21
            For j = 0 To 24
                If grid(i, j) <> -1 Then
                    CheckForBombs(i, j)
                End If
            Next
        Next

    End Sub

    Private Sub CheckForBombs(x As Integer, y As Integer)
        Dim count As Integer = 0

        ' check within a 1 index radius
        For i = -1 To 1
            For j = -1 To 1
                Dim tempX As Integer = x + i
                Dim tempY As Integer = y + j

                ' check if location is within grid bounds
                If tempX >= 0 And tempX <= 21 And tempY >= 0 And tempY <= 24 Then

                    ' check if location contains a bomb (-1)
                    If grid(tempX, tempY) = -1 Then
                        count += 1
                    End If
                End If
            Next
        Next
        grid(x, y) = count
    End Sub


    Private Sub LostGame()
        Timer1.Enabled = False
        LostButton.Visible = True
        PlayAgainButton.Visible = True
        QuitButton.Visible = True

        ' disables all buttons in grid
        For Each btn As Button In Me.Controls.OfType(Of Button)
            If btn.Name.StartsWith("B") Then
                btn.Enabled = False
            End If

        Next
    End Sub

    Private Sub CheckWin()
        Dim count As Integer = 0
        For Each btn As Button In Me.Controls.OfType(Of Button)

            If btn.Name.StartsWith("B") And btn.BackColor = Color.FromArgb(35, 35, 35) Then
                count += 1

            End If

        Next

        If count = 425 Then
            ' disables all buttons in grid
            For Each btn As Button In Me.Controls.OfType(Of Button)
                If btn.Name.StartsWith("B") Then
                    btn.Enabled = False
                End If
                If btn.BackColor = Color.FromArgb(55, 55, 55) Then
                    btn.BackgroundImageLayout = 3
                End If

            Next

            MinesCountLabel.Text = "0"
            WinButton.Visible = True
            Timer1.Enabled = False
            PlayAgainButton.Visible = True
            QuitButton.Visible = True
        End If
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Me.Close()
    End Sub

    Private Sub PlayAgainButton_Click(sender As Object, e As EventArgs) Handles PlayAgainButton.Click
        QuitButton.Visible = False
        LostButton.Visible = False
        PlayAgainButton.Visible = False
        WinButton.Visible = False

        MinesCountLabel.Text = "125"

        Clock.Text = "0:00"
        clockDigit = 0

        Timer1.Enabled = True


        For Each btn As Button In Me.Controls.OfType(Of Button)
            If btn.Name.StartsWith("B") Then
                RemoveHandler btn.MouseDown, AddressOf Button_Clicked
                btn.Text = ""
                btn.BackgroundImageLayout = 0
                btn.BackColor = Color.FromArgb(55, 55, 55)
                btn.Enabled = True
            End If
        Next

        ' reset variables and grid
        grid = {{0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                   {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
                    }

        Initcount = 0
        RandomFillGrid()
        AssignClickFunction()
    End Sub
End Class
