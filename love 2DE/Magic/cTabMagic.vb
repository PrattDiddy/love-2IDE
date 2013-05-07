Public Class cTabMagic

#Region "TabOps"
    Public Sub add_tab(ByVal sFilePath As String, ByVal sText As String)
        'Dim mouseCursor As IMouseCursor = New MouseCursor
        'mouseCursor.SetCursor 2

        System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

        'create tab page
        Dim myTab As New TabPage
        myTab.Text = sText
        myTab.Tag = sFilePath

        'add rich text box
        Dim rtbNew As New RichTextBox
        myTab.Controls.Add(rtbNew)

        ''NO LINE NUMBERS
        'rtbNew.Dock = DockStyle.Fill

        ''FOR LINE NUMBERS
        rtbNew.Left = flex_tab_control.Left + line_number_width - 10
        rtbNew.Width = flex_tab_control.Width - line_number_width + 10
        rtbNew.Height = flex_tab_control.Height

        rtbNew.Dock = DockStyle.Right


        rtbNew.Tag = "rtb"
        rtbNew.BackColor = color_code_back_current
        rtbNew.ForeColor = color_code_text_current
        rtbNew.Font = New System.Drawing.Font("Courier New", 9)
        rtbNew.AcceptsTab = True
        AddHandler rtbNew.KeyUp, AddressOf Main.RichTextBox_KeyUp '''''SYNTAX HIGHLIGHTING
        AddHandler rtbNew.VScroll, AddressOf Main.RichTextBox_Scroll

        'Load file into rtb
        rtbNew.Text = oFileMagic.file_return_text(myTab.Tag)

        'syntax highlight
        oSyntaxMagic.highlight_text(rtbNew)

        'add tabpage to tabcontrol
        flex_tab_control.TabPages.Add(myTab)

        'LINE NUMBERS
        Dim rtbLn As New RichTextBox
        myTab.Controls.Add(rtbLn)
        rtbLn.Tag = "line"
        rtbLn.Dock = DockStyle.Left
        rtbLn.Width = line_number_width
        rtbLn.BackColor = color_code_back_current
        rtbLn.ForeColor = color_code_text_current
        rtbLn.Font = New System.Drawing.Font("Courier New", 9)
        rtbLn.Text = oStringMagic.get_lines(Split(rtbNew.Text, Chr(10)).Length)
        'rtbLn.Enabled = False
        'rtbLn.ScrollBars.None = 0
        'rtbLn.ScrollBars.ForcedHorizontal = True
        rtbLn.SendToBack()

        'Select tab
        flex_tab_control.SelectTab(myTab)

        If flex_tab_control.Visible = False Then flex_tab_control.Visible = True

        System.Windows.Forms.Cursor.Current = Cursors.Default
    End Sub

    Public Sub close_tab()
        If flex_tab_control.TabPages.Count > 0 Then flex_tab_control.TabPages.Remove(flex_tab_control.SelectedTab)

        If flex_tab_control.TabPages.Count = 0 Then flex_tab_control.Visible = False
    End Sub

    Public Sub file_save_tab(ByVal sFilePath As String, ByVal selected_tab As TabPage)
        Dim selected_tab_text As String

        oLabelMagic.update_form_status("SAVING")

        selected_tab_text = get_rtb_text(selected_tab)

        If System.IO.File.Exists(sFilePath) Then oFileMagic.file_save(sFilePath, selected_tab_text)
    End Sub
#End Region

#Region "TextOps"
    Public Function get_tab_path(ByVal selected_tab As TabPage) As String
        Return selected_tab.Tag
    End Function

    Public Function get_rtb_text(ByVal selected_tab As TabPage) As String
        For Each ctrl As Control In selected_tab.Controls
            If ctrl.Tag = "rtb" Then
                Return ctrl.Text
                Exit Function
            End If
        Next

        Return String.Empty
    End Function
#End Region

End Class
