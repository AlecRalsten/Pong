Public Class pongMain

    Dim speed As Single = 10 ' Ball Speed
    Dim rndInst As New Random() ' Random instance
    Dim xVel As Single = Math.Cos(rndInst.Next(7, 10)) * speed
    Dim yVel As Single = Math.Sin(rndInst.Next(7, 10)) * speed
    ' The player's scores.
    Dim compScore As Integer = 0
    Dim plrScore As Integer = 0

    ' Set up the game.
    Private Sub pongMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Windows.Forms.Cursor.Hide()
    End Sub
    ' Move the paddle according to the mouse position.
    Private Sub pongMain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Y > 5 And e.Y < Me.Height - 40 - paddlePlayer.Height Then _
        paddlePlayer.Location = New Point(paddlePlayer.Location.X, e.Y)
    End Sub

    Private Sub gameTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gameTimer.Tick

        'If gameBall.Location.Y > 5 And gameBall.Location.Y < Me.Height - 40 _
        '- paddleComputer.Height Then _
        'paddlePlayer.Location = New Point(paddlePlayer.Location.X, gameBall.Location.Y)

        'If gameBall.Bounds.IntersectsWith(midle.Bounds) Then
        '    paddleComputer.Location = New Point(paddleComputer.Location.X, gameBall.Location.Y)
        'End If

        ' Move the game ball.
        gameBall.Location = New Point(gameBall.Location.X + xVel, gameBall.Location.Y + yVel)

        ' Check for top wall.
        If gameBall.Location.Y < 0 Then
            gameBall.Location = New Point(gameBall.Location.X, 0)
            yVel = -yVel
        End If

        ' Check for bottom wall.
        If gameBall.Location.Y > Me.Height - gameBall.Size.Height - 45 Then
            gameBall.Location = New Point(gameBall.Location.X, Me.Height - gameBall.Size.Height - 45)
            yVel = -yVel
        End If

        ' Check for player paddle.
        If gameBall.Bounds.IntersectsWith(paddlePlayer.Bounds) Then
            xVel = -xVel
        End If

        ' Check for computer paddle.
        If gameBall.Bounds.IntersectsWith(paddleComputer.Bounds) Then
            xVel = -xVel
        End If

        ' Check for left wall.
        If gameBall.Location.X < 0 Then
            plrScore += 1
            gameBall.Location = New Point(Me.Size.Width / 2, Me.Size.Height / 2)
            plrScoreDraw.Text = Convert.ToString(plrScore)
        End If

        ' Check for right wall.
        If gameBall.Location.X > Me.Width - gameBall.Size.Width - paddlePlayer.Width Then
            compScore += 1
            gameBall.Location = New Point(Me.Size.Width / 2, Me.Size.Height / 2)
            compScoreDraw.Text = Convert.ToString(compScore)
        End If

    End Sub

    ' Escape the game when escape has been pressed.
    Private Sub pongMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub compTimer_Tick(sender As System.Object, e As System.EventArgs) Handles compTimer.Tick

        'Set the computer player to move according to the ball's position."
        If gameBall.Location.Y > 5 And gameBall.Location.Y < Me.Height - 40 _
        - paddlePlayer.Height Then _
        paddleComputer.Location = New Point(paddleComputer.Location.X, gameBall.Location.Y)
        Me.Refresh()

        'If gameBall.Bounds.IntersectsWith(midle.Bounds) Then
        ' paddleComputer.Location = New Point(paddleComputer.Location.X, gameBall.Location.Y)
        'End If

    End Sub
End Class
