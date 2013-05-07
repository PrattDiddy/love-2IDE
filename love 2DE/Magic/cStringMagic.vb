Public Class cStringMagic
    Public Function get_lines(ByVal number_of_lines As Integer) As String
        Dim line_num As Integer = 1
        Dim return_str As String = ""

        Do Until line_num = number_of_lines + 1
            Dim line_num_form As String = line_num
            Do Until line_num_form.Length = 3
                line_num_form = "0" & line_num_form
            Loop
            return_str += line_num_form & vbCrLf
            line_num += 1
        Loop

        Return return_str
    End Function
End Class
