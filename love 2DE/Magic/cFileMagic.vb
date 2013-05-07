Public Class cFileMagic
    Dim oWrite As System.IO.StreamWriter
    Dim oRead As System.IO.StreamReader
    Dim oStream As System.IO.FileStream

#Region "File Operations"
    Public Sub file_create(ByVal sFilePath As String, ByVal sContents As String)
        oWrite = IO.File.CreateText(sFilePath)

        oWrite.WriteLine(sContents)
        oWrite.Close()
    End Sub

    Public Function file_return_text(ByVal sFilePath As String) As String
        If System.IO.File.Exists(sFilePath) Then
            Return IO.File.ReadAllText(sFilePath)
        Else
            Return String.Empty
        End If
    End Function

    Public Sub file_save(ByVal sFilePath As String, ByVal sContents As String)
        IO.File.WriteAllText(sFilePath, sContents)

        oLabelMagic.update_form_status("SAVED:: " & sFilePath.ToUpper)
    End Sub

    Public Sub file_copy(ByVal sSource As String, ByVal sDestination As String)
        If System.IO.File.Exists(sSource) Then
            System.IO.File.Copy(sSource, sDestination, True)
        End If
    End Sub

    Public Sub file_move()
        global_modal_type = modal_types.new_project
    End Sub

    'Public Sub file_delete()

    'End Sub
#End Region



End Class
