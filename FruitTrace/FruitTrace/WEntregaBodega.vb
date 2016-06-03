Imports System.ComponentModel
Imports ReaderB
Imports System.Text.RegularExpressions

Public Class WEntregaBodega

    Private fComAdr As Byte = &HFF
    Private fBaud As Byte
    Private frmcomportindex As Integer
    Private fOpenComIndex As Integer
    Private ComOpen As Boolean = False
    Private fIsInventoryScan As Boolean
    Private fCmdRet As Integer = 30
    Private fAppClosed As Boolean
    Private sData As String

    Private Sub WEntregaBodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = ""
        sData = ""
    End Sub

    Public Sub abrirLector()
        Dim port As Integer = 0
        Dim openresult, i As Integer
        openresult = 30
        Cursor = Cursors.WaitCursor
        Try
            fBaud = Convert.ToByte(3)
            If (fBaud > 2) Then
                fBaud = Convert.ToByte(fBaud + 2)
            End If
            openresult = StaticClassReaderB.AutoOpenComPort(port, fComAdr, fBaud, frmcomportindex)
            fOpenComIndex = frmcomportindex
            Label1.Text = "PUERTO COM: " & fOpenComIndex
            If (openresult = 0) Then
                ComOpen = True
                If ((openresult = &H35) Or (openresult = &H30)) Then
                    MessageBox.Show("El lector está ocupado o error en comunicación serial", "Información")
                    StaticClassReaderB.CloseSpecComPort(frmcomportindex)
                    ComOpen = False
                End If
            End If
        Finally
            Cursor = Cursors.Default
        End Try
        If ((fOpenComIndex <> -1) And (openresult <> &H35) And (openresult <> &H30)) Then
            ComOpen = True
            button10.Text = "Capturar"
        End If
        If ((fOpenComIndex = -1) And (openresult = &H30)) Then
            MessageBox.Show("El lector está ocupado o error en comunicación serial", "Información")
        End If

    End Sub

    Private Sub button10_Click(sender As Object, e As EventArgs) Handles button10.Click
        sData = ""
        timer1.Enabled = Not timer1.Enabled
        If (Not timer1.Enabled) Then
            button10.Text = "Capturar"
            cerrarLector()
        Else
            abrirLector()
            button10.Text = "Detener"
        End If
    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        If (fIsInventoryScan) Then
            fIsInventoryScan = True
        End If
        GetData()
        If (fAppClosed) Then
            Close()
        End If
        fIsInventoryScan = False
    End Sub

    Private Sub GetData()
        Dim ScanModeData(40960) As Byte
        Dim ValidDatalength, i As Integer
        Dim temp, temps As String
        ValidDatalength = 0
        fCmdRet = StaticClassReaderB.ReadActiveModeData(ScanModeData, ValidDatalength, frmcomportindex)
        If (fCmdRet = 0) Then
            temp = ""
            temps = C_Functions.ByteArrayToHexString(ScanModeData)
            For i = 0 To ValidDatalength - 1
                temp = temp + temps.Substring(i * 2, 2)
            Next i
            sData = sData + temp
            Dim pattern As String = "1100EE00(E0201509A0B2C3D.{9}).{4}"
            For Each match As Match In Regex.Matches(sData, pattern, RegexOptions.IgnoreCase)
                addData(match.Groups(1).Value.ToString)
            Next
        End If
    End Sub

    Public Sub addData(temp As String)
        Dim bNew As Boolean
        bNew = True

        For Each item As String In listBox3.Items
            If item.Equals(temp) Then
                bNew = False
                Exit For
            End If
        Next
        If bNew Then
            listBox3.Items.Add(temp)
            listBox3.SelectedIndex = listBox3.Items.Count - 1
        End If
    End Sub

    Private Sub cerrarLector()
        Try
            fCmdRet = StaticClassReaderB.CloseSpecComPort(fOpenComIndex)
            If (fCmdRet <> 0) Then
                MessageBox.Show("Error en comunicación serial", "Información")
            Else
                Label1.Text = "PUERTO COM: DESCONECTADO"
            End If
        Finally

        End Try
    End Sub

    Private Sub WEntregaBodega_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        cerrarLector()
    End Sub

    Private Sub button11_Click(sender As Object, e As EventArgs) Handles button11.Click
        listBox3.Items.Clear()
        sData = ""
        Label2.Text = "Total IDs = " & listBox3.Items.Count
    End Sub

    Private Sub listBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBox3.SelectedIndexChanged
        Label2.Text = "Total IDs = " & listBox3.Items.Count
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each item As String In listBox3.Items
            MsgBox(item)
        Next
    End Sub
End Class