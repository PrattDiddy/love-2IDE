Module Globals

#Region "The Magic"
    Public oFileMagic As New cFileMagic
    Public oTreeMagic As New cTreeMagic
    Public oLabelMagic As New cLabelMagic
    Public oProjectMagic As New cProjectMagic
    Public oTabMagic As New cTabMagic
    Public oThemeMagic As New cThemeMagic
    Public oSyntaxMagic As New cSyntaxMagic
    Public oStringMagic As New cStringMagic
#End Region

#Region "App"
    Public app_name As String = "love 2IDE"
    Public app_version As String = "0.1.0"
    Public app_studio As String = "raindance"
    Public app_version_date As String = "2013"
#End Region

#Region "Paths"
    Public sAppPath As String = Application.StartupPath
    Public sProjectsDirectoryPath As String = sAppPath & "\Projects"
    Public sThemesDirectoryPath As String = sAppPath & "\Themes"
    Public sThemesFilePath As String = sThemesDirectoryPath & "\themes.txt"
    Public sCurrentProjectPath As String = sProjectsDirectoryPath
    Public sCurrentProjectStablePath As String = sCurrentProjectPath
    Public sCurrentProjectWorkingPath As String = sCurrentProjectPath
    Public sCurrentProjectWorkingMainPath As String = sCurrentProjectWorkingPath
#End Region

#Region "Strings"
    Public current_project_name As String
#End Region

#Region "Integers"
    'Public line_number_width As Integer = 55
    Public line_number_width As Integer = 45
#End Region

#Region "Lists"
    Public working_paths As New List(Of String)
    Public stable_paths As New List(Of String)

    Public key_words As New List(Of String)
    Public key_symbols_math As New List(Of String)
    Public key_symbols As New List(Of String)

    Public key_words_one As New List(Of String)
    Public key_words_two As New List(Of String)
    Public key_words_three As New List(Of String)

    Public themes_IDE As New List(Of String)
    Public themes_Editor As New List(Of String)

    Public global_theme_objs As New List(Of theme_obj)
#End Region

#Region "Booleans"
    Public blnSyntax As Boolean = True
    Public blnCAPS As Boolean = True

    Public first_run As Boolean = True
#End Region

#Region "Enums"
    Public Enum modal_types
        new_project = 1
        open_project = 2
    End Enum
#End Region

#Region "Colors"
    Public color_back001_current As Color
    Public color_back001_default As Color

    Public color_back002_current As Color
    Public color_back002_default As Color

    Public color_text_current As Color
    Public color_text_default As Color

    Public color_code_back_current As Color
    Public color_code_back_default As Color = Color.White

    Public color_code_text_current As Color
    Public color_code_text_default As Color = Color.Black

    Public color_code_syntax_current As Color
    Public color_code_syntax_default As Color = Color.Blue

    Public color_code_comment_current As Color
    Public color_code_comment_default As Color = Color.Red
#End Region

#Region "Theme"
    'Public theme As New Theme
#End Region

#Region "Modal Type for modal_input_form"
    Public global_modal_type As New modal_types
#End Region

#Region "TreeView"
    Public directory_treeview As TreeView = Main.TreeView
#End Region

#Region "Tab Control"
    Public flex_tab_control As TabControl = Main.TabControl
#End Region

End Module
