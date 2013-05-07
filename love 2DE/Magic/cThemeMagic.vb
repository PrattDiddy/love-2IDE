Public Class cThemeMagic

    Private theme_contents As String = String.Empty

#Region "IDE"
    Public Sub set_defaults_IDE()
        color_back001_default = SystemColors.Control
        color_back002_default = SystemColors.Control
        color_text_default = Color.Black

        color_code_back_default = Color.White
        color_code_text_default = Color.Black
        color_code_syntax_default = Color.Blue
        color_code_comment_default = Color.Red
    End Sub

    Public Sub update_to_current(Optional ByVal blnReset As Boolean = False)
        set_theme(color_back001_current, color_back002_current, color_text_current, blnReset)
        set_main(color_back001_current, color_back002_current, color_text_current)
    End Sub

    Public Sub reset_IDE()
        color_back001_current = color_back001_default
        color_back002_current = color_back002_default
        color_text_current = color_text_default

        update_to_current(True)
    End Sub

    Public Sub set_theme(ByVal color001 As Color, ByVal color002 As Color, ByVal textColor As Color, Optional ByVal blnReset As Boolean = False)
        Theme.BackColor = color001
        Theme.ForeColor = textColor

        For Each ctrl As Control In Theme.Controls
            ctrl.BackColor = color001
            ctrl.ForeColor = textColor

            If ctrl.Controls.Count > 0 Then
                For Each lilCtrl As Control In ctrl.Controls
                    If lilCtrl.Text <> "choose" OrElse blnReset Then
                        lilCtrl.BackColor = color002
                        lilCtrl.ForeColor = textColor
                    End If
                Next
            End If
        Next
    End Sub

    Public Sub set_main(ByVal color001 As Color, ByVal color002 As Color, ByVal textColor As Color)
        Main.BackColor = color001
        Main.ForeColor = textColor

        For Each ctrl As Control In Main.Controls
            ctrl.BackColor = color001
            ctrl.ForeColor = textColor
        Next

        Main.SplitContainer1.BackColor = color001
        Main.SplitContainer1.ForeColor = textColor
        Main.SplitContainer1.Panel2.BackColor = color002

        directory_treeview.BackColor = color002
        directory_treeview.ForeColor = textColor

        For Each rTab As TabPage In flex_tab_control.TabPages
            rTab.BackColor = color002
            rTab.ForeColor = textColor
        Next

        ''''''''''''''''''
        '' Dig-Boy MSDN ''
        ''''''''''''''''''
        Dim menues As New List(Of ToolStripItem)
        For Each t As ToolStripItem In Main.MenuStrip.Items
            GetMenues(t, menues)
        Next

        For Each t As ToolStripItem In menues
            t.BackColor = color_back001_current
            t.ForeColor = color_text_current
        Next
        ''''''''''''''''''

        '' Code
        For Each stab As TabPage In Main.TabControl.TabPages
            For Each ctrl As Control In stab.Controls
                If TypeOf (ctrl) Is RichTextBox Then
                    ctrl.BackColor = color_code_back_current
                    ctrl.ForeColor = color_code_text_current
                    oSyntaxMagic.highlight_text(ctrl)
                End If
            Next
        Next
    End Sub

    Private Sub GetMenues(ByVal Current As ToolStripItem, ByRef menues As List(Of ToolStripItem))
        menues.Add(Current)
        If TypeOf (Current) Is ToolStripMenuItem Then
            For Each menu As ToolStripItem In DirectCast(Current, ToolStripMenuItem).DropDownItems
                GetMenues(menu, menues)
            Next
        End If
    End Sub

    Public Sub menu_case(ByVal upper As Boolean)
        Dim menues As New List(Of ToolStripItem)
        For Each t As ToolStripItem In Main.MenuStrip.Items
            GetMenues(t, menues)
        Next

        For Each t As ToolStripItem In menues
            If upper Then
                t.Text = t.Text.ToUpper
            Else
                t.Text = t.Text.ToLower
            End If
        Next

        If blnSyntax Then
            Main.mnuSyntax.Checked = True
        Else
            Main.mnuSyntax.Checked = False
        End If
    End Sub
#End Region

#Region "Editor"
    Public Sub set_defaults_Editor()
        color_code_back_current = color_code_back_default
        color_code_text_current = color_code_text_default
        color_code_syntax_current = color_code_syntax_default
    End Sub

    Public Sub update_code(Optional ByVal blnDefault As Boolean = False)
        If blnDefault Then
            color_code_back_current = color_code_back_default
            color_code_text_current = color_code_text_default
            color_code_syntax_current = color_code_syntax_default
        End If

        update_code_to_current(color_code_back_current, color_code_text_current, color_code_syntax_current)
    End Sub

    Public Sub update_code_to_current(ByVal color_back As Color, ByVal color_text As Color, ByVal color_syntax As Color)
        For Each rTab As TabPage In flex_tab_control.TabPages
            For Each rtb As Control In rTab.Controls
                If (TypeOf rtb Is RichTextBox) Then
                    rtb.BackColor = color_back
                    rtb.ForeColor = color_text

                    'backfill syntax
                    'oSyntaxMagic.backfill_highlight_text(rtb)
                End If
            Next
        Next
    End Sub

    Public Sub reset_Editor()
        Theme.btnCodeBack.BackColor = color_back001_default
        Theme.btnCodeText.BackColor = color_back001_default

        oThemeMagic.update_code(True)
    End Sub
#End Region

#Region "Themes"
    Private Sub check_for_theme_file()
        If IO.Directory.Exists(sThemesDirectoryPath) = False Then
            IO.Directory.CreateDirectory(sThemesDirectoryPath)
        End If

        If IO.File.Exists(sThemesFilePath) = False Then
            Dim default_theme As String

            default_theme = "light|back001:-986896,back002:-986896,text:-16777216,code_back:-1,code_text:-16777216,code_syntax:-16776961,code_comment:-65536"
            default_theme += "~dark|back001:-16777216,back002:-5658199,text:-1,code_back:-5658199,code_text:-16777216,code_syntax:-1,code_comment:-16711681"
            default_theme += "~jelly|back001:-16777216,back002:-16777216,text:-16711681,code_back:-16777216,code_text:-1,code_syntax:-16711681,code_comment:-7278960"
            default_theme += "~purple|back001:-16777216,back002:-16777216,text:-8388353,code_back:-16777216,code_text:-8388353,code_syntax:-256,code_comment:-8355712"
            default_theme += "~matrix|back001:-16777216,back002:-16777216,text:-16711936,code_back:-16777216,code_text:-8355712,code_syntax:-16711936,code_comment:-32768"
            default_theme += "~watermelon|back001:-32576,back002:-16711936,text:-16777216,code_back:-16777216,code_text:-16711936,code_syntax:-32576,code_comment:-986896"
            default_theme += "~browns|back001:-8372224,back002:-32768,text:-1,code_back:-8372224,code_text:-1,code_syntax:-32768,code_comment:-16777216"
            default_theme += "~cavaliers|back001:-8388544,back002:-16777056,text:-256,code_back:-8388544,code_text:-1,code_syntax:-256,code_comment:-16777056"
            default_theme += "~dolphins|back001:-12550016,back002:-32768,text:-1,code_back:-12550016,code_text:-1,code_syntax:-32768,code_comment:-16777216"

            oFileMagic.file_create(sThemesFilePath, default_theme)
        End If
    End Sub

    Public Sub load_themes()
        check_for_theme_file()

        theme_contents = oFileMagic.file_return_text(sThemesFilePath)

        load_em_up(theme_contents.Split("~"))
        fill_combo()
    End Sub

    Private Sub load_em_up(ByVal themes() As String)
        global_theme_objs.Clear()

        For Each section In themes
            Dim newTheme As New theme_obj
            Dim first_loop As Boolean = True

            If first_loop Then
                newTheme.name += section.Split("|")(0)
                first_loop = False
            Else
                newTheme.name += "|" & section.Split("|")(0)
            End If

            newTheme.back001 = load_color_from_int(section.Split("|")(1).Split(",")(0).Split(":")(1))
            newTheme.back002 = load_color_from_int(section.Split("|")(1).Split(",")(1).Split(":")(1))
            newTheme.text = load_color_from_int(section.Split("|")(1).Split(",")(2).Split(":")(1))
            newTheme.code_back = load_color_from_int(section.Split("|")(1).Split(",")(3).Split(":")(1))
            newTheme.code_text = load_color_from_int(section.Split("|")(1).Split(",")(4).Split(":")(1))
            newTheme.code_syntax = load_color_from_int(section.Split("|")(1).Split(",")(5).Split(":")(1))
            newTheme.code_comment = load_color_from_int(section.Split("|")(1).Split(",")(6).Split(":")(1))

            global_theme_objs.Add(newTheme)
        Next
    End Sub

    Private Sub fill_combo()
        For Each currentTheme In global_theme_objs
            Theme.cboTheme.Items.Add(currentTheme.name)
        Next
    End Sub

    Public Sub load_template(ByVal template_name As String)
        For Each current_theme In global_theme_objs
            If current_theme.name = template_name Then
                color_back001_current = current_theme.back001
                Theme.btnBack001.BackColor = color_back001_current

                color_back002_current = current_theme.back002
                Theme.btnBack002.BackColor = color_back002_current

                color_text_current = current_theme.text
                Theme.btnText.BackColor = color_text_current

                color_code_back_current = current_theme.code_back
                Theme.btnCodeBack.BackColor = color_code_back_current

                color_code_text_current = current_theme.code_text
                Theme.btnCodeText.BackColor = color_code_text_current

                color_code_syntax_current = current_theme.code_syntax
                Theme.btnCodeSyntax.BackColor = color_code_syntax_current

                color_code_comment_current = current_theme.code_comment
                Theme.btnCodeComments.BackColor = color_code_comment_current
            End If
        Next
    End Sub

    Public Sub save_theme(ByRef thmNew As theme_obj)
        Dim strSave As String = String.Empty

        strSave = "~" & thmNew.name & "|"
        strSave = strSave & "back001:" & thmNew.back001.ToArgb & ","
        strSave = strSave & "back002:" & thmNew.back002.ToArgb & ","
        strSave = strSave & "text:" & thmNew.text.ToArgb & ","
        strSave = strSave & "code_back:" & thmNew.code_back.ToArgb & ","
        strSave = strSave & "code_text:" & thmNew.code_text.ToArgb & ","
        strSave = strSave & "code_syntax:" & thmNew.code_syntax.ToArgb & ","
        strSave = strSave & "code_comment:" & thmNew.code_comment.ToArgb

        strSave = oFileMagic.file_return_text(sThemesFilePath) & strSave

        oFileMagic.file_create(sThemesFilePath, strSave)
    End Sub

    Private Function load_color_from_text(ByVal strColor As String) As Color
        Dim c As Color = Color.FromName(strColor)
        Return c
    End Function

    Private Function load_color_from_int(ByVal i As Integer) As Color
        Dim c As Color = Color.FromArgb(i)
        Return c
    End Function

    Private Function load_rgb_from_name(ByVal str As String) As String
        Dim c As Color = load_color_from_text(str)
        Return c.ToArgb.ToString
    End Function
#End Region

End Class