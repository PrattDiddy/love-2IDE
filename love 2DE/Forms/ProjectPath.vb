Public Class ProjectPath

    Private Sub ProjectPath_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.Text = sProjectsDirectoryPath

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
    End Sub
End Class