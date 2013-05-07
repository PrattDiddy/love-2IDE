Public Class modal_input_form
    Public Sub modal_initialize()

        Me.Text = app_name

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

        Select Case global_modal_type
            Case modal_types.new_project
                lblMain.Text = "Project (Game) Name:"
                txtMain.Visible = True
                cboMain.Visible = False
                btnAccept.Text = "Create"
                oLabelMagic.update_form_status("NEW PROJECT")

            Case modal_types.open_project
                lblMain.Text = "Select Project Folder:"
                txtMain.Visible = False
                cboMain.Visible = True
                cboMain.Top = txtMain.Top
                btnAccept.Text = "Open"
                oLabelMagic.update_form_status("OPEN PROJECT")

                fill_cbo()
            Case Else

        End Select

        Me.ShowDialog()

        txtMain.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        oLabelMagic.reset_form_status()
        Me.Close()
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        accept()
    End Sub

    Public Sub accept()
        Select Case global_modal_type
            Case modal_types.new_project
                create_project()

            Case modal_types.open_project
                If cboMain.Text <> "No Projects Found" Then
                    open_project()
                Else
                    MsgBox("Nothing to open.", , app_name)
                End If

            Case Else

        End Select

        Me.Close()
    End Sub

    Private Sub create_project()
        'Verify Project Name
        If txtMain.TextLength < 1 Then
            MsgBox("Please enter a name to get started.", , app_name)
            txtMain.Focus()
            Exit Sub
        End If

        'Create New Project
        oProjectMagic.project_create(txtMain.Text)
        oLabelMagic.update_form_status("CREATED PROJECT:: " & sCurrentProjectPath.ToUpper)
    End Sub

    Public Sub open_project()
        current_project_name = cboMain.Text

        oLabelMagic.update_form_title(app_name & " - " & current_project_name)

        oProjectMagic.project_reset_current_directory()

        'Clear the tree
        oTreeMagic.clear_tree()

        'Clear the Flex
        flex_tab_control.TabPages.Clear()

        'hide it
        flex_tab_control.Visible = False

        'Fill the tree
        oTreeMagic.Populate_TreeView(sProjectsDirectoryPath & "\" & cboMain.Text, cboMain.Text)

        'open the working main

        oLabelMagic.update_form_status("OPENED PROJECT:: " & current_project_name.ToUpper)
    End Sub

    Private Sub fill_cbo()
        cboMain.Items.Clear()

        Select Case global_modal_type
            Case modal_types.open_project
                If System.IO.Directory.Exists(sProjectsDirectoryPath) Then
                    Dim sProjects As New List(Of String)
                    oProjectMagic.Get_Project_Directories(sProjectsDirectoryPath, sProjects)

                    For Each proj As String In sProjects
                        cboMain.Items.Add(Split(proj, sProjectsDirectoryPath & "\")(1))
                    Next
                Else
                    cboMain.Items.Add("No Projects Found")
                End If

                cboMain.SelectedIndex = 0
        End Select
    End Sub
End Class