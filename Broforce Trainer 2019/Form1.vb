'Imports
Imports System
Imports System.IO
Imports System.Collections
Imports System.Runtime.InteropServices

Public Class frmMain

    'Public Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As System.Windows.Forms.Keys) As Short
    Public Declare Function GetKeyPress Lib "user32" Alias "GetAsyncKeyState" (ByVal key As Integer) As Integer
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Short
    Private hack1State As Boolean = False
    Private hack2State As Boolean = False
    Private lastTimeToggled1 As DateTime = Date.Now
    Private lastTimeToggled2 As DateTime = Date.Now

    Dim F1 As Boolean = GetAsyncKeyState(Keys.F1)
    Dim F2 As Boolean = GetAsyncKeyState(Keys.F2)
    'Dim F1enabled As Short = 0
    'Dim F2enabled As Short = 0

    'Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Long) As Integer

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If (GetAsyncKeyState(Keys.F1) And 1) > 0 Then
            If (Date.Now.Subtract(lastTimeToggled1).TotalMilliseconds > 1000) Then
                hack1State = Not hack1State '' toggle the value

                If hack1State Then
                    '' TODO: call Hack1Enable() here
                    'Timer1.Start()
                    Lifes()
                    Timer2.Enabled = True
                    lblLifesSwitch.Text = "ON"
                    lblLifesSwitch.ForeColor = Color.LightGreen
                    lblLifesSwitch.BackColor = Color.Black
                Else
                    ''TODO: call Hack1Disable() here
                    'Timer1.Stop()
                    lblLifesSwitch.Text = "OFF"
                    lblLifesSwitch.ForeColor = Color.Blue
                    lblLifesSwitch.BackColor = Color.Red
                End If
                lastTimeToggled1 = Date.Now
            End If
        End If

        If (GetAsyncKeyState(Keys.F2) And 1) > 0 Then
            If (Date.Now.Subtract(lastTimeToggled2).TotalMilliseconds > 1000) Then
                hack2State = Not hack2State '' toggle the value

                If hack2State Then
                    '' TODO: call Hack1Enable() here
                    Grenades()
                    Timer2.Enabled = True
                    lblGrenadesSwitch.Text = "ON"
                    lblGrenadesSwitch.ForeColor = Color.LightGreen
                    lblGrenadesSwitch.BackColor = Color.Black
                Else
                    ''TODO: call Hack1Disable() here
                    'Timer1.Stop()
                    lblGrenadesSwitch.Text = "OFF"
                    lblGrenadesSwitch.ForeColor = Color.Blue
                    lblGrenadesSwitch.BackColor = Color.Red
                End If
                lastTimeToggled2 = Date.Now
            End If
        End If

        '    If (GetAsyncKeyState(Keys.F2) And F2) Then
        '   F2 = Not F2 'toggle the value
        'If F2 Then
        ' Lifes()
        '  lblGrenadesSwitch.Text = "ON"
        ' lblGrenadesSwitch.ForeColor = Color.Green
        ' lblGrenadesSwitch.BackColor = Color.Black

        'MsgBox("Infinite lifes enabled")
        'Timer1.Start()
        '  Else
        ''Timer1.Stop()
        '  lblGrenadesSwitch.Text = "OFF"
        'lblGrenadesSwitch.ForeColor = Color.Blue
        '  lblGrenadesSwitch.BackColor = Color.Red
        ' End If
        '  End If
    End Sub

    'Handle dll
    Function GetModuleHandle(ByVal processx As String, ByVal modulex As String) As IntPtr
        Dim prs As Process() = Process.GetProcessesByName(processx)
        If prs.Length > 0 Then
            On Error Resume Next
            Dim pi As ProcessModuleCollection = prs(0).Modules
            For Each pmod As ProcessModule In pi
                If pmod.ModuleName = (modulex) Then
                    Return pmod.BaseAddress
                Else
                End If
            Next

        End If
    End Function

    Sub Grenades()
        Try
            'WritePointerInteger("Broforce_beta", &H318A6C18, 99, {&H58, &H80, &H24, &H38, &H418})
            'WritePointerInteger("Broforce_beta", "mono.dll+001F795C 58 80 24 38 418", 64)
            'WritePointerInteger("Broforce_beta", "mono.dll+001F795C 58 80 24 38 418", 64)
            'WritePointerInteger("Broforce_beta", &H318A6C18, 64, {&H58, &H80, &H24, &H38, &H418})

            'WritePointerInteger("Broforce_beta", &H5335F50, 99, {&H58, &H80, &H24, &H38, &H418})
            'WritePointerInteger("Broforce_beta", "mono.dll+001F795C 58 80 24 38 418", 64)
            'WritePointerInteger("Broforce_beta", "mono.dll+001F795C 58 80 24 38 418", 64)
            'WritePointerInteger("Broforce_beta", &H5335F50, 64, {&H58, &H80, &H24, &H38, &H418})

            'WritePointerInteger("Broforce_beta", "mono.dll+001F795C", 99, {&H58, &H80, &H24, &H38, &H418})
            'WritePointerInteger("Broforce_beta", "mono.dll+001F795C 58 80 24 38 418", 64)
            'WritePointerInteger("Broforce_beta", "mono.dll+001F795C 58 80 24 38 418", 64)
            'WritePointerInteger("Broforce_beta", "mono.dll+001F795C", 64, &H58, &H80, &H24, &H38, &H418)

            'WritePointerInteger("Broforce_beta", "mono.dll+001F795C", 99, &H418)
            'WritePointerInteger("Broforce_beta", "mono.dll+001F795C 58 80 24 38 418", 64)
            'WritePointerInteger("Broforce_beta", "mono.dll+001F795C 58 80 24 38 418", 64)
            'WritePointerInteger("Broforce_beta", "mono.dll+001F795C", 64, &H418)

            'WritePointerInteger("Broforce_beta", "mono.dll+001F795C", 99, {&H30, &H50, &H24, &H3C, &H418})
            'WritePointerInteger("Broforce_beta", "mono.dll+001F795C", 99, {&H30, &H50, &H24, &H3C, &H418})
            'WritePointerInteger("Broforce_beta", "mono.dll+001F795C", 99, {&H30, &H50, &H24, &H3C, &H418})
            'WritePointerInteger("Broforce_beta", "mono.dll+001F795C", 99, {&H30, &H50, &H24, &H3C, &H418})

            'WritePointerInteger("Broforce_beta", &H5335F50, 99, {&H30, &H50, &H24, &H3C, &H418})
            'WritePointerInteger("Broforce_beta", &H5335F50, 99, {&H30, &H50, &H24, &H3C, &H418})
            'WritePointerInteger("Broforce_beta", &H5335F50, 99, {&H30, &H50, &H24, &H3C, &H418})
            'WritePointerInteger("Broforce_beta", &H5335F50, 99, {&H30, &H50, &H24, &H3C, &H418})

            'WriteDMAInteger("Broforce_beta", "mono.dll" + &H318A6C18, {&H30, &H50, &H24, &H3C, &H418}, 99, 5)
            'WritePointerInteger("Broforce_beta", "mono.dll" + &H1F5680, 99, {&H28, &H34, &H110, &H64, &H418})

            'WriteDMAInteger("Broforce_beta", &H4F1795C, {&H30, &H50, &H24, &H3C, &H418}, 99, 5)

            'Infinite Grenades
            ReadDMAInteger("Broforce_beta", GetModuleHandle("Broforce_beta", "mono.dll") + &H1F5680, {&H28, &H34, &H110, &H64, &H418}, 5)
            If vBuffertemp = Nothing Then
                TextBox2.Text = vBuffertemp.ToString
                Exit Sub
            ElseIf vBuffertemp < 30 Then
                WriteDMAInteger("Broforce_beta", GetModuleHandle("Broforce_beta", "mono.dll") + &H1F5680, {&H28, &H34, &H110, &H64, &H418}, 99, 5)
                TextBox2.Text = vBuffertemp.ToString
                Exit Sub
            ElseIf vBuffertemp > 99 Then
                TextBox2.Text = vBuffertemp.ToString
                Exit Sub
            End If

            'WriteDMAInteger("Broforce_beta", GetModuleHandle("Broforce_beta", "mono.dll") + &H1F795C, {&H30, &H50, &H24, &H3C, &H418}, 99, 5)
            ' WritePointerInteger("Broforce_beta", GetModuleHandle("Broforce_beta", "mono.dll") + &H1F795C,, 99)
            'WriteDMAInteger("Broforce_beta", &H5335F50, {&H30, &H50, &H24, &H3C, &H418}, 99, 5)
            'WritePointerInteger("Broforce_beta", &H4F1795C, 99, {&H418, &H70, &H24, &H7E8, &H58})

            'WritePointerByte("Broforce_beta", &H4F1795C, 99, {&H58, &H7E8, &H24, &H70, &H418})
            'WritePointerByte("Broforce_beta", &H5045680, 99, {&H28, &H34, &H110, &H64, &H418})

        Catch ex As Exception
            Timer1.Stop()
            'MsgBox("Error: " + ex.Message)


        End Try
    End Sub

    Sub Lifes()
        Try

            'Infinite Lifes
            ReadDMAInteger("Broforce_beta", GetModuleHandle("Broforce_beta", "mono.dll") + &H2040EC, {&H38, &H50, &H10, &H674, &HB0}, 5)
            If vBuffertemp = Nothing Then
                Exit Sub
            ElseIf vBuffertemp < 30 Then
                WriteDMAInteger("Broforce_beta", GetModuleHandle("Broforce_beta", "mono.dll") + &H2040EC, {&H38, &H50, &H10, &H674, &HB0}, 99, 5)
            ElseIf vBuffertemp > 99 Then
                Exit Sub
            End If

            TextBox1.Text = vBuffertemp.ToString

        Catch ex As Exception
            Timer1.Stop()
            'MsgBox("Error: " + ex.Message)


        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'Grenades()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hotkey.Start()
        lblLifesSwitch.Text = "OFF"
        lblLifesSwitch.ForeColor = Color.Blue
        lblLifesSwitch.BackColor = Color.Red

        lblGrenadesSwitch.Text = "OFF"
        lblGrenadesSwitch.ForeColor = Color.Blue
        lblGrenadesSwitch.BackColor = Color.Red

        Timer2.Interval = 2000 '2 seconds
        Timer2.Enabled = False

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If hack1State Then
            Timer2.Enabled = True
            'Lifes()
        End If

        If hack2State Then
            Timer2.Enabled = True
            Grenades()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
