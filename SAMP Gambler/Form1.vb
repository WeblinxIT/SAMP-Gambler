Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Environment


Module Win32API
    Public Structure Window
        Dim Coordinates As Rectangle
        Dim Handle As IntPtr
        Dim TitleText As String
    End Structure

    Declare Function GetForegroundWindow Lib "user32.dll" () As IntPtr
    Declare Function GetWindowRect Lib "user32.dll" (ByVal hwnd As IntPtr, ByRef lpRect As Rect) As IntPtr
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Ansi)>
    Public Function GetWindowText(hwnd As IntPtr, <MarshalAs(UnmanagedType.LPStr)> lpString As System.Text.StringBuilder, cch As Integer) As Integer
    End Function

    Public Structure Rect
        Dim left, top, right, bottom As Integer
    End Structure

    Public Function GetFocusWindow() As Window
        Dim ret As New Window

        Dim hwnd As IntPtr = GetForegroundWindow
        ret.Handle = hwnd

        Dim MyRect As Rect
        GetWindowRect(hwnd, MyRect)
        ret.Coordinates = Rectangle.FromLTRB(MyRect.left, MyRect.top, MyRect.right, MyRect.bottom)

        ret.TitleText = GetText(hwnd)

        Return ret
    End Function

    Function GetText(ByVal hWnd As IntPtr) As String
        Dim length As Integer
        If hWnd.ToInt32 <= 0 Then
            Return Nothing
        End If
        length = 256
        Dim sb As New System.Text.StringBuilder("", length + 1)

        GetWindowText(hWnd, sb, sb.Capacity)
        Return sb.ToString()
    End Function
End Module
Public Class Form1
    Private Declare Sub keybd_event Lib "user32.dll" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Integer, ByVal dwExtraInfo As Integer)
    Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Const KEYEVENTF_KEYUP As Byte = &H2
    Private Const Key_NONE As Integer = &H0
    Private Const WM_HOTKEY As Integer = &H312
    Dim pressed As Short = -32767

    Dim ena As Boolean
    Dim gtawindow As Boolean
    Dim rungamecounter As Boolean = False
    Dim topen As Boolean
    Dim username As String

    Dim gambled As Integer = 0
    Dim gambled_won As Integer = 0
    Dim gamble_amount As Integer = 0
    Dim gamble_bet As Integer = 0
    Dim gamble_profit As Integer = 0
    Dim gamble_notcalc As Integer = 0
    Dim casino As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ena = False
        topen = False
        username = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\SAMP", "PlayerName", Nothing)
        label_welcomename.Text = username

        ThreadPool.QueueUserWorkItem(AddressOf thread_checkkeys)
        ThreadPool.QueueUserWorkItem(AddressOf thread_checkwindow)
        ThreadPool.QueueUserWorkItem(AddressOf thread_getstats)
        ThreadPool.QueueUserWorkItem(AddressOf thread_gamecounter)

        label_status.BackColor = Color.IndianRed
        label_profit.BackColor = Color.LightGreen
        label_status.Text = "INACTIVE"
    End Sub

    Private Sub timer_send_Tick(sender As Object, e As EventArgs) Handles timer_send.Tick
        If gtawindow = True And topen = False Then
            keybd_event(Keys.F, 0, 0, 0) ' Down
            Threading.Thread.Sleep(400)
            keybd_event(Keys.F, 0, KEYEVENTF_KEYUP, 0) 'Generates a KEY_UP
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://forum.irresistiblegaming.com")
    End Sub

    Sub thread_checkkeys()
        While True
            If GetAsyncKeyState(Keys.F11) = pressed Then
                If ena = True Then
                    rungamecounter = False
                    Me.Invoke(Sub() timer_send.Stop())
                    casino = 0
                    ena = False
                    Me.Invoke(Sub() label_status.Text = "INACTIVE")
                    Me.Invoke(Sub() label_status.BackColor = Color.IndianRed)
                    If gtawindow = True And topen = False Then
                        SendKeys.SendWait("t/w GAMBLING BOT STOPPED{ENTER}")
                    End If
                Else
                    If gtawindow = True Then
                        ena = True
                        Me.Invoke(Sub() timer_send.Start())
                        rungamecounter = True
                        Me.Invoke(Sub() label_status.Text = "ACTIVE")
                        Me.Invoke(Sub() label_status.BackColor = Color.LightGreen)
                        username = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\SAMP", "PlayerName", Nothing)
                        label_welcomename.Text = username
                        SendKeys.SendWait("t/w GAMBLING BOT STARTED. PLEASE AVOID PRESSING C{ENTER}")
                    End If
                End If
            End If

            If gtawindow = True Then
                If GetAsyncKeyState(Keys.T) = pressed Or GetAsyncKeyState(Keys.F6) Then
                    topen = True
                    rungamecounter = False
                End If

                If GetAsyncKeyState(Keys.Escape) = pressed Then
                    If topen = True And gtawindow = True Then
                        topen = False
                        rungamecounter = True
                    End If
                End If

                If GetAsyncKeyState(Keys.Enter) = pressed Then
                    If topen = True And gtawindow = True Then
                        topen = False
                        rungamecounter = True
                    End If
                End If

            End If
            Thread.Sleep(10)
        End While
    End Sub

    Sub thread_checkwindow()
        While True
            Dim window As Window = Win32API.GetFocusWindow()
            If window.TitleText = "GTA:SA:MP" Then
                'If window.TitleText = "Unbenannt - Editor" Then
                gtawindow = True
            Else
                gtawindow = False
            End If
            Thread.Sleep(250)
        End While
    End Sub

    Sub thread_getstats()
        Dim lastline As String = ""
        While True
            If My.Computer.FileSystem.GetFileInfo(GetFolderPath(SpecialFolder.CommonDocuments) & "\GTA San Andreas User Files\SAMP\chatlog.txt").LastWriteTime > My.Computer.FileSystem.GetFileInfo(GetFolderPath(SpecialFolder.MyDocuments) & "\GTA San Andreas User Files\SAMP\chatlog.txt").LastWriteTime Then
                'MsgBox("Public")
                If ena = True Then
                    Dim text() As String = IO.File.ReadAllLines(GetFolderPath(SpecialFolder.CommonDocuments) & "\GTA San Andreas User Files\SAMP\chatlog.txt")
                    If Not (lastline = text(text.Length - 2)) Then
                        lastline = text(text.Length - 2)
                        If lastline.Contains("[CASINO]") And lastline.Contains(username) Then
                            If lastline.Contains("Caligula") Then casino = 1
                            If lastline.Contains("Four Dragons") Then casino = 2
                            gambled_won += 1
                            Me.Invoke(Sub() label_won.Text = gambled_won & " Games won")
                            Dim split As String
                            split = lastline.Split("}")(3)
                            split = split.Split("{")(0)
                            gamble_amount += split.Substring(1) * 1000
                            Me.Invoke(Sub() label_amountwon.Text = "$" & gamble_amount & " Won")
                            gamble_profit = gamble_amount - gamble_bet
                            Me.Invoke(Sub() label_profit.Text = "$" & gamble_profit & " Profit")
                            If gamble_profit < 0 Then
                                Me.Invoke(Sub() label_profit.BackColor = Color.IndianRed)
                            Else
                                Me.Invoke(Sub() label_profit.BackColor = Color.LightGreen)
                            End If
                        End If
                    End If
                End If
            Else
                'MsgBox("Private")
                If ena = True Then
                    Dim text() As String = IO.File.ReadAllLines(GetFolderPath(SpecialFolder.MyDocuments) & "\GTA San Andreas User Files\SAMP\chatlog.txt")
                    If Not (lastline = text(text.Length - 2)) Then
                        lastline = text(text.Length - 2)
                        If lastline.Contains("[CASINO]") And lastline.Contains(username) Then
                            If lastline.Contains("Caligula") Then casino = 1
                            If lastline.Contains("Four Dragons") Then casino = 2
                            gambled_won += 1
                            Me.Invoke(Sub() label_won.Text = gambled_won & " Games won")
                            Dim split As String
                            split = lastline.Split("}")(3)
                            split = split.Split("{")(0)
                            gamble_amount += split.Substring(1) * 1000
                            Me.Invoke(Sub() label_amountwon.Text = "$" & gamble_amount & " Won")
                            gamble_profit = gamble_amount - gamble_bet
                            Me.Invoke(Sub() label_profit.Text = "$" & gamble_profit & " Profit")
                            If gamble_profit < 0 Then
                                Me.Invoke(Sub() label_profit.BackColor = Color.IndianRed)
                            Else
                                Me.Invoke(Sub() label_profit.BackColor = Color.LightGreen)
                            End If
                        End If
                    End If
                End If
            End If
            Thread.Sleep(250)
        End While
    End Sub

    Sub thread_gamecounter()
        While True
            While rungamecounter = True
                If topen = False And gtawindow = True And ena = True Then
                    gambled += 1
                    Me.Invoke(Sub() label_gamesplayed.Text = gambled & " Games played")

                    Dim gamble_cost As Integer
                    If casino = 1 Then
                        gamble_cost = 1000
                        If gamble_notcalc > 0 Then
                            gamble_cost = gamble_notcalc * 1000
                            gamble_notcalc = 0
                        End If

                    ElseIf casino = 2 Then
                        gamble_cost = 10000
                        If gamble_notcalc > 0 Then
                            gamble_cost = gamble_notcalc * 10000
                            gamble_notcalc = 0
                        End If
                    ElseIf casino = 0 Then
                        gamble_notcalc += 1
                    End If
                    gamble_bet = gamble_bet + gamble_cost
                    Me.Invoke(Sub() label_moneyset.Text = "$" & gamble_bet & " totally bet")

                    gamble_profit = gamble_amount - gamble_bet
                    Me.Invoke(Sub() label_profit.Text = "$" & gamble_profit & " Profit")
                    If gamble_profit < 0 Then
                        Me.Invoke(Sub() label_profit.BackColor = Color.IndianRed)
                    Else
                        Me.Invoke(Sub() label_profit.BackColor = Color.LightGreen)
                    End If
                End If
                Thread.Sleep(7800)
            End While
            Thread.Sleep(100)
        End While
    End Sub
End Class
