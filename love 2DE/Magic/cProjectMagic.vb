Imports System.IO
Public Class cProjectMagic

#Region "Directory Operations"
    Public Sub directory_create(ByVal sPath As String)
        If (Not System.IO.Directory.Exists(sProjectsDirectoryPath)) Then
            System.IO.Directory.CreateDirectory(sProjectsDirectoryPath)
        End If

        If (Not System.IO.Directory.Exists(sPath)) Then
            System.IO.Directory.CreateDirectory(sPath)
        End If
    End Sub

    Public Sub directory_commit()
        Dim strTEST As String = String.Empty

        'RESET WORKING PATHS?
        working_paths.Clear()

        'get directories
        Get_Directories(sCurrentProjectWorkingPath, working_paths)

        'loop file copy for directories
        For Each current_object As String In working_paths
            Dim current_filename As String = Split(current_object, sCurrentProjectWorkingPath)(1)

            oFileMagic.file_copy(current_object, sCurrentProjectStablePath & current_filename)
        Next
    End Sub

    Public Sub directory_pull()
        Dim strTEST As String = String.Empty

        stable_paths.Clear()

        'get directories
        Get_Directories(sCurrentProjectStablePath, stable_paths)

        'loop file copy for directories
        For Each current_object As String In stable_paths
            Dim current_filename As String = Split(current_object, sCurrentProjectStablePath)(1)

            oFileMagic.file_copy(current_object, sCurrentProjectWorkingPath & current_filename)
        Next
    End Sub

    Public Sub Get_Directories(ByVal directoryValue As String, ByRef string_paths As List(Of String), Optional ByVal blnSkipFiles As Boolean = False)

        Dim directoryArray As String() = Directory.GetDirectories(directoryValue)

        If Not blnSkipFiles Then Get_Files(directoryValue, string_paths)

        If directoryArray.Length <> 0 Then
            Dim currentDirectory As String

            For Each currentDirectory In directoryArray
                If string_paths.Equals(stable_paths) Then If currentDirectory.Contains("\working") Then Exit For 'This needs to be done in a better way

                string_paths.Add(currentDirectory)
                Get_Directories(currentDirectory, string_paths, blnSkipFiles)
            Next
        End If
    End Sub

    Public Sub Get_Files(ByVal directoryValue As String, ByRef string_paths As List(Of String))
        Dim directoryArray As String() = Directory.GetFiles(directoryValue)

        If directoryArray.Length <> 0 Then
            Dim currentDirectory As String

            For Each currentDirectory In directoryArray
                string_paths.Add(currentDirectory)
            Next
        End If
    End Sub

    Public Sub Get_Project_Directories(ByVal directoryValue As String, ByRef string_paths As List(Of String))

        Dim directoryArray As String() = Directory.GetDirectories(directoryValue)

        If directoryArray.Length <> 0 Then
            Dim currentDirectory As String

            For Each currentDirectory In directoryArray
                If string_paths.Equals(stable_paths) Then If currentDirectory.Contains("\working") Then Exit For 'This needs to be done in a better way

                string_paths.Add(currentDirectory)
            Next
        End If
    End Sub
#End Region

#Region "Project Operations"

    Public Sub project_reset_current_directory()
        sCurrentProjectPath = sProjectsDirectoryPath & "\" & current_project_name
        sCurrentProjectStablePath = sProjectsDirectoryPath & "\" & current_project_name & "\stable"
        sCurrentProjectWorkingPath = sProjectsDirectoryPath & "\" & current_project_name & "\working"
    End Sub

#Region "New"
    Public Sub project_new()
        'Get Project Name
        'oLabelMagic.update_form_status("OPEN PROJECT")
        global_modal_type = modal_types.new_project
        modal_input_form.modal_initialize()
    End Sub

    Public Sub project_create(ByVal project_name As String)
        'Set Global Project Name
        current_project_name = project_name

        'Update title
        oLabelMagic.update_form_title(app_name & " - " & current_project_name)

        'Reset directory path
        project_reset_current_directory()

        'Create Game Directory
        directory_create(sCurrentProjectStablePath)

        'Create Stable Directory
        project_create_stable()

        'Create Working Directory
        project_create_working()

        'Fill out Tree
        oTreeMagic.Populate_TreeView(sCurrentProjectPath, current_project_name)

        'Open main.lua in tab for edit
        flex_tab_control.TabPages.Clear()

        'hide it
        flex_tab_control.Visible = False

        'expand and select in tree

        'Need to add Love EXE at some point
    End Sub

    Public Sub project_create_main()
        Dim sMain As String

        sMain = "--Project Name: {PROJECT_NAME}" & vbCrLf
        sMain = sMain & "--Creation: {CREATION}" & vbCrLf
        sMain = sMain & vbCrLf

        sMain = sMain & "function love.load()" & vbCrLf
        sMain = sMain & vbCrLf
        sMain = sMain & "end" & vbCrLf
        sMain = sMain & vbCrLf

        sMain = sMain & "function love.update(dt)" & vbCrLf
        sMain = sMain & vbCrLf
        sMain = sMain & "end" & vbCrLf
        sMain = sMain & vbCrLf

        sMain = sMain & "function love.draw()" & vbCrLf
        sMain = sMain & vbCrLf
        sMain = sMain & "end" & vbCrLf
        sMain = sMain & vbCrLf

        sMain = sMain.Replace("{PROJECT_NAME}", current_project_name)
        sMain = sMain.Replace("{CREATION}", Date.Now())

        oFileMagic.file_create(sCurrentProjectStablePath & "\main.lua", sMain)
    End Sub

    Public Sub project_create_stable()
        directory_create(sCurrentProjectStablePath)

        sCurrentProjectWorkingMainPath = sCurrentProjectStablePath & "\main.lua"

        'create main
        project_create_main()
    End Sub

    Public Sub project_create_working()
        directory_create(sCurrentProjectWorkingPath)

        sCurrentProjectWorkingMainPath = sCurrentProjectWorkingPath & "\main.lua"

        'Copy main to working
        oFileMagic.file_copy(sCurrentProjectStablePath & "\main.lua", sCurrentProjectWorkingMainPath)
    End Sub
#End Region

#Region "Open"
    Public Sub project_open()
        'Get Project Name
        global_modal_type = modal_types.open_project
        modal_input_form.modal_initialize()
    End Sub
#End Region

#Region "Version Control"
    Public Sub project_Commit()
        If MsgBox("Are you sure you want to commit the working version?", MsgBoxStyle.YesNo, app_name) = MsgBoxResult.Yes Then directory_commit()
    End Sub

    Public Sub project_Pull()
        If MsgBox("Are you sure you want to lose the working version?", MsgBoxStyle.YesNo, app_name) = MsgBoxResult.Yes Then directory_pull()
    End Sub
#End Region

#End Region

End Class
