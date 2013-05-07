Public Class Theme
#Region "Form"
    Private Sub Theme_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        oLabelMagic.reset_form_status()
    End Sub

    Private Sub Theme_Load(sender As Object, e As EventArgs) Handles Me.Load
        oLabelMagic.update_form_status("THEMING")

        cboTheme.Items.Clear()

        oThemeMagic.load_themes()

        If blnCAPS Then
            chkCAPS.Checked = True
        Else
            chkCAPS.Checked = False
        End If
    End Sub
#End Region

#Region "IDE"
    Private Sub btnBack001_Click(sender As Object, e As EventArgs) Handles btnBack001.Click
        Dim cDialog As New ColorDialog()
        cDialog.Color = color_back001_current

        If (cDialog.ShowDialog() = DialogResult.OK) Then
            color_back001_current = cDialog.Color ' update with user selected color.
        End If

        btnBack001.BackColor = color_back001_current
    End Sub

    Private Sub btnBack002_Click(sender As Object, e As EventArgs) Handles btnBack002.Click
        Dim cDialog As New ColorDialog()
        cDialog.Color = color_back002_current

        If (cDialog.ShowDialog() = DialogResult.OK) Then
            color_back002_current = cDialog.Color ' update with user selected color.
        End If

        btnBack002.BackColor = color_back002_current
    End Sub

    Private Sub btnText_Click(sender As Object, e As EventArgs) Handles btnText.Click
        Dim cDialog As New ColorDialog()
        cDialog.Color = color_text_current

        If (cDialog.ShowDialog() = DialogResult.OK) Then
            color_text_current = cDialog.Color ' update with user selected color.
        End If

        btnText.BackColor = color_text_current
    End Sub
#End Region

#Region "Editor"
    Private Sub btnCodeBack_Click(sender As Object, e As EventArgs) Handles btnCodeBack.Click
        Dim cDialog As New ColorDialog()
        cDialog.Color = color_code_back_current

        If (cDialog.ShowDialog() = DialogResult.OK) Then
            color_code_back_current = cDialog.Color ' update with user selected color.
        End If

        btnCodeBack.BackColor = color_code_back_current
    End Sub

    Private Sub btnCodeText_Click(sender As Object, e As EventArgs) Handles btnCodeText.Click
        Dim cDialog As New ColorDialog()
        cDialog.Color = color_code_text_current

        If (cDialog.ShowDialog() = DialogResult.OK) Then
            color_code_text_current = cDialog.Color ' update with user selected color.
        End If

        btnCodeText.BackColor = color_code_text_current
    End Sub

    Private Sub btnCodeSyntax_Click(sender As Object, e As EventArgs) Handles btnCodeSyntax.Click
        Dim cDialog As New ColorDialog()
        cDialog.Color = color_code_syntax_current

        If (cDialog.ShowDialog() = DialogResult.OK) Then
            color_code_syntax_current = cDialog.Color ' update with user selected color.
        End If

        btnCodeSyntax.BackColor = color_code_syntax_current
    End Sub

    Private Sub btnCodeComments_Click(sender As Object, e As EventArgs) Handles btnCodeComments.Click
        Dim cDialog As New ColorDialog()
        cDialog.Color = color_code_comment_current

        If (cDialog.ShowDialog() = DialogResult.OK) Then
            color_code_comment_current = cDialog.Color ' update with user selected color.
        End If

        btnCodeComments.BackColor = color_code_comment_current
    End Sub
#End Region

#Region "Changes"
    Private Sub btnCommit_Click(sender As Object, e As EventArgs) Handles btnCommit.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

        'Set controls
        oThemeMagic.update_to_current()

        System.Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

        oThemeMagic.reset_IDE()

        System.Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Private Sub chkCAPS_CheckedChanged(sender As Object, e As EventArgs) Handles chkCAPS.CheckedChanged
        'loop controls and change case
        If chkCAPS.Checked Then
            oThemeMagic.menu_case(True)
        Else
            oThemeMagic.menu_case(False)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
#End Region

#Region "Template"
    Private Sub btnTemplate_Click(sender As Object, e As EventArgs) Handles btnTemplate.Click
        oThemeMagic.load_template(cboTheme.Text)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim newTheme As New theme_obj

        With newTheme
            .name = cboTheme.Text
            .back001 = btnBack001.BackColor
            .back002 = btnBack002.BackColor
            .text = btnText.BackColor
            .code_back = btnCodeBack.BackColor
            .code_text = btnCodeText.BackColor
            .code_syntax = btnCodeSyntax.BackColor
            .code_comment = btnCodeComments.BackColor
        End With

        oThemeMagic.save_theme(newTheme)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub
#End Region

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cDialog As New ColorDialog()
        cDialog.Color = Button1.BackColor ' initial selection is current color.

        If (cDialog.ShowDialog() = DialogResult.OK) Then
            Button1.BackColor = cDialog.Color ' update with user selected color.
        End If
    End Sub

    Private Sub btnCodeTemplate_Click(sender As Object, e As EventArgs) Handles btnCodeTemplate.Click

    End Sub

    Private Sub btnCodeCommit_Click(sender As Object, e As EventArgs) Handles btnCodeCommit.Click
        oThemeMagic.update_code()
    End Sub

    Private Sub btnCodeReset_Click(sender As Object, e As EventArgs) Handles btnCodeReset.Click
        oThemeMagic.reset_Editor()
    End Sub

End Class