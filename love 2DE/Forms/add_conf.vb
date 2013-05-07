Public Class add_conf
    Public Sub initialize()
        txtTitle.Text = current_project_name

        Me.BackColor = color_back001_current
        Me.ForeColor = color_text_current

        For Each ctrl As Control In Me.Controls
            If (TypeOf ctrl Is Label) Then
                ctrl.BackColor = color_back001_current
                ctrl.ForeColor = color_text_current
            Else
                ctrl.BackColor = color_back002_current
                ctrl.ForeColor = color_text_current
            End If
        Next

        Me.ShowDialog()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim sConf As String = String.Empty
        Dim myTab As String = "    "

        sConf = "function love.conf(t)" & vbCrLf
        sConf = myTab & sConf & "t.title = ""{TITLE}""" & vbCrLf
        sConf = myTab & sConf & "t.author = ""{AUTHOR}""" & vbCrLf
        sConf = myTab & sConf & "t.screen.width = {WIDTH}" & vbCrLf
        sConf = myTab & sConf & "t.screen.height = {HEIGHT}" & vbCrLf
        sConf = sConf & "end"

        sConf = sConf.Replace("{TITLE}", txtTitle.Text)
        sConf = sConf.Replace("{AUTHOR}", txtAuthor.Text)
        sConf = sConf.Replace("{WIDTH}", txtScreenWidth.Text)
        sConf = sConf.Replace("{HEIGHT}", txtScreenHeight.Text)

        oFileMagic.file_create(sCurrentProjectWorkingPath & "\conf.lua", sConf)
        oTabMagic.add_tab(sCurrentProjectWorkingPath & "\conf.lua", "\working\conf.lua")
        oTreeMagic.refresh_tree()

        Me.Close()
    End Sub
End Class