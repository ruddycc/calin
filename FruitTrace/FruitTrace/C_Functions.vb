Imports System.Text
Imports ReaderB

Public Class C_Functions

    Shared Sub abrirLector(lbl As String, result As Integer)
        Dim port As Integer = 0
        Dim openresult, i As Integer
        Dim fComAdr As Byte = &HFF
        Dim fBaud As Byte
        Dim frmcomportindex As Integer
        Dim fOpenComIndex As Integer
        Dim ComOpen As Boolean = False
        Dim fCmdRet As Integer = 30
        openresult = 30
        Try
            fBaud = Convert.ToByte(3)
            If (fBaud > 2) Then
                fBaud = Convert.ToByte(fBaud + 2)
            End If
            openresult = StaticClassReaderB.AutoOpenComPort(port, fComAdr, fBaud, frmcomportindex)
            fOpenComIndex = frmcomportindex
            result = fOpenComIndex
            lbl = "COM: " & fOpenComIndex & " = " & fOpenComIndex
            If (openresult = 0) Then
                ComOpen = True

                If ((openresult = &H35) Or (openresult = &H30)) Then
                    MessageBox.Show("Serial Communication Error or Occupied", "Information")
                    StaticClassReaderB.CloseSpecComPort(frmcomportindex)
                    ComOpen = False
                End If
            End If
        Finally

        End Try
        If ((fOpenComIndex <> -1) And (openresult <> &H35) And (openresult <> &H30)) Then

            ComOpen = True
        End If
        If ((fOpenComIndex = -1) And (openresult = &H30)) Then
            MessageBox.Show("Serial Communication Error or Occupied", "Information")
        End If

    End Sub

    Shared Function ByteArrayToHexString(ByVal data() As Byte) As String
        Dim sb As New StringBuilder(data.Length * 3)
        Dim b As Byte
        For Each b In data
            sb.Append(Convert.ToString(b, 16).PadLeft(2, "0").PadRight(3, " "))
        Next
        sb = sb.Replace(" ", "")
        Return sb.ToString().ToUpper()
    End Function

    Shared Function pointOnVertex(point As C_Gps, vertices As C_Gps()) As Boolean
        For Each vertex As C_Gps In vertices
            If (point.Equals(vertex)) Then
                Return True
            End If
        Next
        Return False
    End Function

    Shared Function pointInPolygon(point As C_Gps, vertices As C_Gps()) As Integer

        '0 - Outside
        '1 - Inside
        '2 - Vertex
        '3 - Boundary

        If (pointOnVertex(point, vertices)) Then
            Return 2
        End If

        Dim intersections, vertices_count, i As Integer
        intersections = 0
        vertices_count = vertices.Count
        Dim vertex1, vertex2 As C_Gps
        Dim xinters As Double

        For i = 1 To vertices_count - 1
            vertex1 = vertices(i - 1)
            vertex2 = vertices(i)
            If (vertex1.dLong = vertex2.dLong And vertex1.dLong = point.dLong And point.dLat > Math.Min(vertex1.dLat, vertex2.dLat) And point.dLat < Math.Max(vertex1.dLat, vertex2.dLat)) Then '{ // Checar si el punto está en un segmento horizontal
                Return 3
            End If
            If (point.dLong > Math.Min(vertex1.dLong, vertex2.dLong) And point.dLong <= Math.Max(vertex1.dLong, vertex2.dLong) And point.dLat <= Math.Max(vertex1.dLat, vertex2.dLat) And vertex1.dLong <> vertex2.dLong) Then
                xinters = (point.dLong - vertex1.dLong) * (vertex2.dLat - vertex1.dLat) / (vertex2.dLong - vertex1.dLong) + vertex1.dLat
                If (xinters = point.dLat) Then '{ // Checar si el punto está en un segmento (otro que horizontal)
                    Return 3
                End If
                If (vertex1.dLat = vertex2.dLat Or point.dLat <= xinters) Then
                    intersections = intersections + 1
                End If
            End If
        Next i

        If (intersections Mod 2 <> 0) Then
            Return 1
        End If

        Return 0
    End Function
End Class
