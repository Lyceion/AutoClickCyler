Imports System.Runtime.InteropServices
Public Class Form1
    ''BYTHECYLOPS
    <DllImport("user32")>
    Public Shared Function SetCursorPos(x As Integer, y As Integer) As Integer
    End Function
    Private Const MOUSEEVENTF_LEFTDOWN As Integer = &H2
    Private Const MOUSEEVENTF_LEFTUP As Integer = &H4
    <DllImport("user32", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Public Shared Sub mouse_event(dwFlags As Integer, dx As Integer, dy As Integer, cButtons As Integer, dwExtraInfo As Integer)
    End Sub ''BYTHECYLOPS
    <DllImport("user32.dll")>
    Public Shared Function GetAsyncKeyState(ByVal vKey As System.Windows.Forms.Keys) As Short
    End Function ''BYTHECYLOPS
    Dim tmr As New Timer
    Dim tmr2 As New Timer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tmr.Interval = 100
        AddHandler tmr.Tick, AddressOf tmr_gecti
        tmr.Start()
        tmr2.Interval = 100
        AddHandler tmr2.Tick, AddressOf tmr2_gecti
        tmr2.Start() ''BYTHECYLOPS
    End Sub
    Private Sub tmr_gecti(ByVal sender As Object, ByVal e As System.EventArgs)
        If GetAsyncKeyState(Keys.F8) Then
            Timer1.Start()
        End If ''BYTHECYLOPS
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)
        mouse_event(&H2, 0, 0, 0, 1)
        ''BYTHECYLOPS
        mouse_event(&H4, 0, 0, 0, 1)
    End Sub
    Private Sub tmr2_gecti(ByVal sender As Object, ByVal e As System.EventArgs)
        If GetAsyncKeyState(Keys.F9) Then
            Timer1.Stop()
        End If
    End Sub
End Class