Public Class Main

#Region "Load"
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        oLabelMagic.reset_form_status()

        'Should maybe do something?
        oThemeMagic.set_defaults_IDE()
        oThemeMagic.set_defaults_Editor()

        'Uppercase those menus
        oThemeMagic.menu_case(True)

        'set key words
        oSyntaxMagic.set_words()
    End Sub
#End Region

#Region "Tool Strip Items"
#Region "File Items"
    Private Sub smnuNewFile_Click(sender As Object, e As EventArgs) Handles smnuNewFile.Click
        oTabMagic.add_tab("", "Untitled")
    End Sub

    Private Sub smnuNewConf_Click(sender As Object, e As EventArgs) Handles smnuNewConf.Click
        If current_project_name <> "" Then
            Dim conf As New add_conf

            conf.initialize()
        Else
            MsgBox("You must have a project open to create a conf.", , app_name)
        End If
    End Sub

    Private Sub mnuOpenFile_Click(sender As Object, e As EventArgs) Handles mnuOpenFile.Click
        MsgBox("Sorry, this isn't finished yet.", , "love 2IDE")
    End Sub

    Private Sub mnuSaveFile_Click(sender As Object, e As EventArgs) Handles mnuSaveFile.Click
        If current_project_name <> String.Empty Then
            'Save current tab
            oTabMagic.file_save_tab(oTabMagic.get_tab_path(flex_tab_control.SelectedTab), flex_tab_control.SelectedTab)
        Else
            MsgBox("No Project Present", , app_name)
        End If
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub
#End Region

#Region "Project Items"
    Private Sub mnuNewProject_Click(sender As Object, e As EventArgs) Handles mnuNewProject.Click
        oProjectMagic.project_new()
    End Sub

    Private Sub mnuOpenProject_Click(sender As Object, e As EventArgs) Handles mnuOpenProject.Click
        oLabelMagic.update_form_status("OPEN PROJECT")
        oProjectMagic.project_open()
    End Sub

    Private Sub mnuSaveProject_Click(sender As Object, e As EventArgs) Handles mnuSaveProject.Click
        If current_project_name <> String.Empty Then
            For Each rTab As TabPage In TabControl.TabPages
                oTabMagic.file_save_tab(oTabMagic.get_tab_path(rTab), rTab)

                oLabelMagic.update_form_status("SAVED PROJECT:: " & sCurrentProjectPath.ToUpper)
            Next
        Else
            MsgBox("No Project Present", , app_name)
        End If
    End Sub

    Private Sub mnuRun_Click(sender As Object, e As EventArgs) Handles mnuRun.Click
        MsgBox("Sorry, this isn't finished yet.", , "love 2IDE")
    End Sub

    Private Sub mnuProjectPath_Click(sender As Object, e As EventArgs) Handles mnuProjectPath.Click
        Dim projPath As New ProjectPath
        projPath.Show()
    End Sub

    Private Sub smnuCommit_Click(sender As Object, e As EventArgs) Handles smnuCommit.Click
        If current_project_name <> String.Empty Then
            oProjectMagic.project_Commit()
            oTreeMagic.refresh_tree()
        Else
            MsgBox("No Project Present", , app_name)
        End If
    End Sub

    Private Sub smnuPull_Click(sender As Object, e As EventArgs) Handles smnuPull.Click
        If current_project_name <> String.Empty Then
            oProjectMagic.project_Pull()
            oTreeMagic.refresh_tree()
        Else
            MsgBox("No Project Present", , app_name)
        End If
    End Sub
#End Region

#Region "Theme Items"
    Private Sub mnuThemeSelect_Click(sender As Object, e As EventArgs) Handles mnuThemeSelect.Click
        theme.ShowDialog()
    End Sub
#End Region

#Region "Help Items"
    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        Dim about As New About

        about.Show()
    End Sub

    Private Sub mnuDocumentation_Click(sender As Object, e As EventArgs) Handles mnuDocumentation.Click
        MsgBox("Sorry, this isn't finished yet.", , "love 2IDE")
    End Sub
#End Region

#Region "Buttons"
    Private Sub mBtnNewFile_Click(sender As Object, e As EventArgs) Handles mBtnNewFile.Click
        If current_project_name <> "" Then
            Dim conf As New add_conf

            conf.initialize()
        Else
            MsgBox("You must have a project open to create a conf.", , app_name)
        End If
    End Sub

    Private Sub mBtnOpenFile_Click(sender As Object, e As EventArgs) Handles mBtnOpenFile.Click
        MsgBox("Sorry, this isn't finished yet.", , "love 2IDE")
    End Sub

    Private Sub mBtnSaveFile_Click(sender As Object, e As EventArgs) Handles mBtnSaveFile.Click
        If current_project_name <> String.Empty Then
            'Save current tab
            oTabMagic.file_save_tab(oTabMagic.get_tab_path(flex_tab_control.SelectedTab), flex_tab_control.SelectedTab)
        Else
            MsgBox("No Project Present", , app_name)
        End If
    End Sub

    Private Sub mBtnNewProject_Click(sender As Object, e As EventArgs) Handles mBtnNewProject.Click
        oProjectMagic.project_new()
    End Sub

    Private Sub mBtnOpenProject_Click(sender As Object, e As EventArgs) Handles mBtnOpenProject.Click
        oLabelMagic.update_form_status("OPEN PROJECT")
        oProjectMagic.project_open()
    End Sub

    Private Sub mBtnSaveProject_Click(sender As Object, e As EventArgs) Handles mBtnSaveProject.Click
        If current_project_name <> String.Empty Then
            For Each rTab As TabPage In TabControl.TabPages
                oTabMagic.file_save_tab(oTabMagic.get_tab_path(rTab), rTab)

                oLabelMagic.update_form_status("SAVED PROJECT:: " & sCurrentProjectPath.ToUpper)
            Next
        Else
            MsgBox("No Project Present", , app_name)
        End If
    End Sub

    Private Sub mBtnRun_Click(sender As Object, e As EventArgs) Handles mBtnRun.Click
        MsgBox("Sorry, this isn't finished yet.", , "love 2IDE")
    End Sub

    Private Sub mBtnCommit_Click(sender As Object, e As EventArgs) Handles mBtnCommit.Click
        If current_project_name <> String.Empty Then
            oProjectMagic.project_Commit()
            oTreeMagic.refresh_tree()
        Else
            MsgBox("No Project Present", , app_name)
        End If
    End Sub

    Private Sub mBtnPull_Click(sender As Object, e As EventArgs) Handles mBtnPull.Click
        If current_project_name <> String.Empty Then
            oProjectMagic.project_Pull()
            oTreeMagic.refresh_tree()
        Else
            MsgBox("No Project Present", , app_name)
        End If
    End Sub

    Private Sub mBtnFind_Click(sender As Object, e As EventArgs) Handles mBtnFind.Click
        MsgBox("Sorry, this isn't finished yet.", , "love 2IDE")
    End Sub

    Private Sub mBtnTheme_Click(sender As Object, e As EventArgs) Handles mBtnTheme.Click
        Theme.ShowDialog()
    End Sub

    Private Sub mBtnHelp_Click(sender As Object, e As EventArgs) Handles mBtnHelp.Click
        MsgBox("Sorry, this isn't finished yet.", , "love 2IDE")
    End Sub

    Private Sub mBtnAbout_Click(sender As Object, e As EventArgs) Handles mBtnAbout.Click
        Dim about As New About

        about.Show()
    End Sub

    Private Sub mBtnNewTab_Click(sender As Object, e As EventArgs) Handles mBtnNewTab.Click
        oTabMagic.close_tab()
    End Sub

    Private Sub mBtnCloseTab_Click(sender As Object, e As EventArgs) Handles mBtnCloseTab.Click
        oTabMagic.add_tab("", "Untitled")
    End Sub
#End Region
#End Region

#Region "TreeView"
    Private Sub TreeView_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView.NodeMouseDoubleClick
        oTreeMagic.treeview_double_click(TreeView.SelectedNode)
    End Sub
#End Region

#Region "Tab Control"
    Private Sub TabControl_KeyDown(sender As Object, e As KeyEventArgs) Handles TabControl.KeyDown
        If e.KeyCode = Keys.S AndAlso e.Control Then
            'save file
            oTabMagic.file_save_tab(oTabMagic.get_tab_path(flex_tab_control.SelectedTab), flex_tab_control.SelectedTab)
        End If
    End Sub

    Private Sub TabControl_MouseClick(sender As Object, e As MouseEventArgs) Handles TabControl.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Middle Then
            oTabMagic.close_tab()
        End If
    End Sub

    Public Sub RichTextBox_Scroll(sender As Object, e As EventArgs)
        'select current tab page
        'If flex_tab_control.TabPages.Count > 0 Then
        '    For Each ctrl As Control In flex_tab_control.SelectedTab.Controls
        '        If TypeOf ctrl Is RichTextBox Then
        '            If ctrl.Tag = "line" Then
        '                DirectCast(ctrl, RichTextBox).ScrollBars.Equals()
        '            End If
        '        End If
        '    Next
        'End If

    End Sub
#End Region

#Region "Syntax Highlighting"
    Private Sub mnuSyntax_Click(sender As Object, e As EventArgs) Handles mnuSyntax.Click
        If mnuSyntax.Checked Then
            blnSyntax = False
            mnuSyntax.Checked = False
        Else
            blnSyntax = True
            mnuSyntax.Checked = True
        End If
    End Sub

    Public Sub RichTextBox_KeyUp(ByVal sender As System.Object, ByVal e As KeyEventArgs)
        'Needs to catch arrow keys as well
        'If (e.KeyCode = Keys.Space Or e.KeyCode = Keys.Enter) And blnSyntax Then oSyntaxMagic.highlight_last_word3(sender)

        If blnSyntax Then
            Select Case e.KeyCode
                Case Keys.Space, Keys.Enter, Keys.Left, Keys.Right, Keys.Up, Keys.Down
                    oSyntaxMagic.highlight_last_word3(sender)

                Case Keys.Left, Keys.Right, Keys.Up, Keys.Down
                    oSyntaxMagic.highlight_last_word3(sender)
                    'Check for the symbols not surrounded by spaces

                Case Else
                    'Check for the symbols not surrounded by spaces
            End Select
        End If
    End Sub
#End Region

#Region "Resize"
    Private Sub TabControl_Resize(sender As Object, e As EventArgs) Handles TabControl.Resize
        'THIS CREATES ERRORS
        'For Each sTab In TabControl.TabPages
        '    For Each ctrl As Control In sTab.controls
        '        If TypeOf ctrl Is RichTextBox Then
        '            ctrl.Left = flex_tab_control.Left + 25
        '            ctrl.Width = flex_tab_control.Width - 25
        '        End If
        '    Next
        'Next
        'If Not first_run Then
        '    resize_it()
        'Else
        '    first_run = False
        'End If

    End Sub

    Private Sub resize_it()
        For Each sTab In TabControl.TabPages
            For Each ctrl As Control In sTab.controls
                If TypeOf ctrl Is RichTextBox Then
                    ctrl.Left = flex_tab_control.Left + 25
                    ctrl.Width = flex_tab_control.Width - 25
                End If
            Next
        Next
    End Sub
#End Region



    
End Class
