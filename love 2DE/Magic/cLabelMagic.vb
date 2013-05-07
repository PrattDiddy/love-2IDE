Public Class cLabelMagic

#Region "Title"
    Public Sub update_form_title(ByVal sTitle As String)
        'Update Form Title
        Main.Text = sTitle
    End Sub
#End Region

#Region "Status"
    Public Sub update_form_status(ByVal sStatus As String)
        Main.stsLbl.Text = sStatus
    End Sub

    Public Sub reset_form_status()
        If current_project_name = "" Then
            Main.stsLbl.Text = app_name & " v" & app_version
        Else
            Main.stsLbl.Text = "CURRENT PROJECT:: " & current_project_name.ToUpper
        End If
    End Sub
#End Region

End Class
