<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.label_status = New System.Windows.Forms.Label()
        Me.timer_send = New System.Windows.Forms.Timer(Me.components)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.timer_checkwindow = New System.Windows.Forms.Timer(Me.components)
        Me.timer_checkkeys = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.label_won = New System.Windows.Forms.Label()
        Me.label_amountwon = New System.Windows.Forms.Label()
        Me.label_gamesplayed = New System.Windows.Forms.Label()
        Me.label_welcome = New System.Windows.Forms.Label()
        Me.label_welcomename = New System.Windows.Forms.Label()
        Me.label_moneyset = New System.Windows.Forms.Label()
        Me.label_profit = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label_status
        '
        Me.label_status.AutoSize = True
        Me.label_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_status.Location = New System.Drawing.Point(37, 9)
        Me.label_status.Name = "label_status"
        Me.label_status.Size = New System.Drawing.Size(63, 20)
        Me.label_status.TabIndex = 0
        Me.label_status.Text = "Label1"
        '
        'timer_send
        '
        Me.timer_send.Interval = 500
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(125, 250)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(138, 13)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "forum.irresistiblegaming.com"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Visit our forums:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 275)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "(C)opyright 2017 by Runner v1.2 BETA"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.SAMP_Gambler.My.Resources.Resources.casino__3_
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.ImageLocation = ""
        Me.PictureBox1.Location = New System.Drawing.Point(171, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 146)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Press F11 ingame"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "to start / stop"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "the bot."
        '
        'timer_checkwindow
        '
        Me.timer_checkwindow.Interval = 80
        '
        'timer_checkkeys
        '
        Me.timer_checkkeys.Interval = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(110, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 18)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Statistics:"
        '
        'label_won
        '
        Me.label_won.AutoSize = True
        Me.label_won.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_won.Location = New System.Drawing.Point(180, 161)
        Me.label_won.Name = "label_won"
        Me.label_won.Size = New System.Drawing.Size(83, 15)
        Me.label_won.TabIndex = 10
        Me.label_won.Text = "0 Games won"
        '
        'label_amountwon
        '
        Me.label_amountwon.AutoSize = True
        Me.label_amountwon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_amountwon.Location = New System.Drawing.Point(190, 189)
        Me.label_amountwon.Name = "label_amountwon"
        Me.label_amountwon.Size = New System.Drawing.Size(49, 15)
        Me.label_amountwon.TabIndex = 11
        Me.label_amountwon.Text = "$0 Won"
        '
        'label_gamesplayed
        '
        Me.label_gamesplayed.AutoSize = True
        Me.label_gamesplayed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_gamesplayed.Location = New System.Drawing.Point(7, 161)
        Me.label_gamesplayed.Name = "label_gamesplayed"
        Me.label_gamesplayed.Size = New System.Drawing.Size(96, 15)
        Me.label_gamesplayed.TabIndex = 12
        Me.label_gamesplayed.Text = "0 Games played"
        '
        'label_welcome
        '
        Me.label_welcome.AutoSize = True
        Me.label_welcome.Location = New System.Drawing.Point(12, 48)
        Me.label_welcome.Name = "label_welcome"
        Me.label_welcome.Size = New System.Drawing.Size(82, 13)
        Me.label_welcome.TabIndex = 13
        Me.label_welcome.Text = "Welcome back,"
        '
        'label_welcomename
        '
        Me.label_welcomename.AutoSize = True
        Me.label_welcomename.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_welcomename.Location = New System.Drawing.Point(90, 48)
        Me.label_welcomename.Name = "label_welcomename"
        Me.label_welcomename.Size = New System.Drawing.Size(39, 13)
        Me.label_welcomename.TabIndex = 14
        Me.label_welcomename.Text = "Label8"
        '
        'label_moneyset
        '
        Me.label_moneyset.AutoSize = True
        Me.label_moneyset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_moneyset.Location = New System.Drawing.Point(12, 189)
        Me.label_moneyset.Name = "label_moneyset"
        Me.label_moneyset.Size = New System.Drawing.Size(75, 15)
        Me.label_moneyset.TabIndex = 15
        Me.label_moneyset.Text = "$0 totally bet"
        '
        'label_profit
        '
        Me.label_profit.AutoSize = True
        Me.label_profit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_profit.Location = New System.Drawing.Point(110, 219)
        Me.label_profit.Name = "label_profit"
        Me.label_profit.Size = New System.Drawing.Size(61, 15)
        Me.label_profit.TabIndex = 16
        Me.label_profit.Text = "$0 Profit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(308, 297)
        Me.Controls.Add(Me.label_profit)
        Me.Controls.Add(Me.label_moneyset)
        Me.Controls.Add(Me.label_welcomename)
        Me.Controls.Add(Me.label_welcome)
        Me.Controls.Add(Me.label_gamesplayed)
        Me.Controls.Add(Me.label_amountwon)
        Me.Controls.Add(Me.label_won)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.label_status)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "SFCNR Gambling Bot"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label_status As Label
    Friend WithEvents timer_send As Timer
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents timer_checkwindow As Timer
    Friend WithEvents timer_checkkeys As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents label_won As Label
    Friend WithEvents label_amountwon As Label
    Friend WithEvents label_gamesplayed As Label
    Friend WithEvents label_welcome As Label
    Friend WithEvents label_welcomename As Label
    Friend WithEvents label_moneyset As Label
    Friend WithEvents label_profit As Label
End Class
