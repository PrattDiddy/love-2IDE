Imports System.IO

Public Class cTreeMagic
    Public Sub Populate_TreeView(ByVal sPath As String, ByVal sRoot As String)
        clear_tree()

        Dim myNode As New TreeNode(sRoot)
        Populate_TreeView_Directories(sPath, myNode)

        directory_treeview.Nodes.Add(myNode)
    End Sub

    'Load Project Tree
    Public Sub Populate_TreeView_Directories(ByVal directoryValue As String, ByRef parentNode As TreeNode)

        Dim directoryArray As String() = Directory.GetDirectories(directoryValue)

        Populate_TreeView_Files(directoryValue, parentNode)

        If directoryArray.Length <> 0 Then
            Dim currentDirectory As String

            For Each currentDirectory In directoryArray
                Dim myNode As TreeNode = New TreeNode(Split(currentDirectory, current_project_name)(1))
                myNode.Tag = currentDirectory
                parentNode.Nodes.Add(myNode)
                Populate_TreeView_Directories(currentDirectory, myNode)
            Next
        End If
    End Sub

    Public Sub Populate_TreeView_Files(ByVal directoryValue As String, ByRef parentNode As TreeNode)
        Dim directoryArray As String() = Directory.GetFiles(directoryValue)

        If directoryArray.Length <> 0 Then
            Dim currentDirectory As String

            For Each currentDirectory In directoryArray
                Dim myNode As TreeNode = New TreeNode(Split(currentDirectory, current_project_name)(1))
                myNode.Tag = currentDirectory
                parentNode.Nodes.Add(myNode)
            Next
        End If
    End Sub

    'Clear Tree
    Public Sub clear_tree()
        directory_treeview.Nodes.Clear()
    End Sub

    Public Sub refresh_tree()
        oTreeMagic.Populate_TreeView(sCurrentProjectPath, current_project_name)
    End Sub

    Public Sub treeview_double_click(ByVal clicked_node As TreeNode)
        If clicked_node IsNot Nothing Then If clicked_node.Text.Contains(".") Then oTabMagic.add_tab(clicked_node.Tag, clicked_node.Text)
    End Sub
End Class
