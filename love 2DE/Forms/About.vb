Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblAppName.Text = app_name
        lblVersionNum.Text = app_version
        lblStudio.Text = app_studio
        lblYear.Text = app_version_date

        Me.BackColor = color_back001_current
        Me.ForeColor = color_text_current

        For Each ctrl As Control In Me.Controls
            If (TypeOf ctrl Is Label) Then
                ctrl.BackColor = color_back001_current
                ctrl.ForeColor = Color.FromArgb((255 - color_back001_current.R), (255 - color_back001_current.G), (255 - color_back001_current.B)) 'color_text_current
            Else
                ctrl.BackColor = color_back002_current
                ctrl.ForeColor = color_text_current
            End If

            If ctrl.Name = "lblVersionNum" OrElse ctrl.Name = "lblStudio" Then
                ctrl.ForeColor = color_code_syntax_current
            End If
        Next
    End Sub
End Class