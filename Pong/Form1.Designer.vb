<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pongMain
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
        Me.components = New System.ComponentModel.Container()
        Me.paddlePlayer = New System.Windows.Forms.PictureBox()
        Me.gameBall = New System.Windows.Forms.PictureBox()
        Me.paddleComputer = New System.Windows.Forms.PictureBox()
        Me.plrScoreDraw = New System.Windows.Forms.Label()
        Me.compScoreDraw = New System.Windows.Forms.Label()
        Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.compTimer = New System.Windows.Forms.Timer(Me.components)
        Me.midle = New System.Windows.Forms.PictureBox()
        CType(Me.paddlePlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gameBall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paddleComputer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.midle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'paddlePlayer
        '
        Me.paddlePlayer.BackColor = System.Drawing.Color.White
        Me.paddlePlayer.Location = New System.Drawing.Point(12, 146)
        Me.paddlePlayer.Name = "paddlePlayer"
        Me.paddlePlayer.Size = New System.Drawing.Size(16, 128)
        Me.paddlePlayer.TabIndex = 0
        Me.paddlePlayer.TabStop = False
        '
        'gameBall
        '
        Me.gameBall.BackColor = System.Drawing.Color.White
        Me.gameBall.Location = New System.Drawing.Point(240, 196)
        Me.gameBall.Name = "gameBall"
        Me.gameBall.Size = New System.Drawing.Size(20, 20)
        Me.gameBall.TabIndex = 1
        Me.gameBall.TabStop = False
        '
        'paddleComputer
        '
        Me.paddleComputer.BackColor = System.Drawing.Color.White
        Me.paddleComputer.Location = New System.Drawing.Point(604, 146)
        Me.paddleComputer.Name = "paddleComputer"
        Me.paddleComputer.Size = New System.Drawing.Size(16, 128)
        Me.paddleComputer.TabIndex = 2
        Me.paddleComputer.TabStop = False
        '
        'plrScoreDraw
        '
        Me.plrScoreDraw.AutoSize = True
        Me.plrScoreDraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plrScoreDraw.ForeColor = System.Drawing.Color.White
        Me.plrScoreDraw.Location = New System.Drawing.Point(349, 9)
        Me.plrScoreDraw.Name = "plrScoreDraw"
        Me.plrScoreDraw.Size = New System.Drawing.Size(0, 29)
        Me.plrScoreDraw.TabIndex = 3
        '
        'compScoreDraw
        '
        Me.compScoreDraw.AutoSize = True
        Me.compScoreDraw.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compScoreDraw.ForeColor = System.Drawing.Color.White
        Me.compScoreDraw.Location = New System.Drawing.Point(219, 9)
        Me.compScoreDraw.Name = "compScoreDraw"
        Me.compScoreDraw.Size = New System.Drawing.Size(0, 29)
        Me.compScoreDraw.TabIndex = 4
        '
        'gameTimer
        '
        Me.gameTimer.Enabled = True
        Me.gameTimer.Interval = 25
        '
        'compTimer
        '
        Me.compTimer.Enabled = True
        Me.compTimer.Interval = 199
        '
        'midle
        '
        Me.midle.BackColor = System.Drawing.Color.Transparent
        Me.midle.Location = New System.Drawing.Point(319, 9)
        Me.midle.Name = "midle"
        Me.midle.Size = New System.Drawing.Size(30, 429)
        Me.midle.TabIndex = 6
        Me.midle.TabStop = False
        Me.midle.Visible = False
        '
        'pongMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.midle)
        Me.Controls.Add(Me.compScoreDraw)
        Me.Controls.Add(Me.plrScoreDraw)
        Me.Controls.Add(Me.paddleComputer)
        Me.Controls.Add(Me.gameBall)
        Me.Controls.Add(Me.paddlePlayer)
        Me.MaximizeBox = False
        Me.Name = "pongMain"
        Me.Text = "Pong"
        CType(Me.paddlePlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gameBall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paddleComputer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.midle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents paddlePlayer As System.Windows.Forms.PictureBox
    Friend WithEvents gameBall As System.Windows.Forms.PictureBox
    Friend WithEvents paddleComputer As System.Windows.Forms.PictureBox
    Friend WithEvents plrScoreDraw As System.Windows.Forms.Label
    Friend WithEvents compScoreDraw As System.Windows.Forms.Label
    Friend WithEvents gameTimer As System.Windows.Forms.Timer
    Friend WithEvents compTimer As System.Windows.Forms.Timer
    Friend WithEvents midle As System.Windows.Forms.PictureBox

End Class
