<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.amnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuNewFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuNewConf = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.amnuProject = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewProject = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpenProject = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveProject = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuRun = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProjectPath = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuVersion = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuCommit = New System.Windows.Forms.ToolStripMenuItem()
        Me.smnuPull = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSyntax = New System.Windows.Forms.ToolStripMenuItem()
        Me.amnuTheme = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuThemeSelect = New System.Windows.Forms.ToolStripMenuItem()
        Me.amnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDocumentation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mBtnNewFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mBtnOpenFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mBtnSaveFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mBtnFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.mBtnNewProject = New System.Windows.Forms.ToolStripMenuItem()
        Me.mBtnOpenProject = New System.Windows.Forms.ToolStripMenuItem()
        Me.mBtnSaveProject = New System.Windows.Forms.ToolStripMenuItem()
        Me.mBtnCommit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mBtnPull = New System.Windows.Forms.ToolStripMenuItem()
        Me.mBtnRun = New System.Windows.Forms.ToolStripMenuItem()
        Me.mBtnTheme = New System.Windows.Forms.ToolStripMenuItem()
        Me.mBtnHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mBtnAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mBtnNewTab = New System.Windows.Forms.ToolStripMenuItem()
        Me.mBtnCloseTab = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.stsLbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView = New System.Windows.Forms.TreeView()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.amnuFile, Me.amnuProject, Me.amnuTheme, Me.amnuHelp, Me.mBtnNewFile, Me.mBtnOpenFile, Me.mBtnSaveFile, Me.mBtnFind, Me.mBtnNewProject, Me.mBtnOpenProject, Me.mBtnSaveProject, Me.mBtnCommit, Me.mBtnPull, Me.mBtnRun, Me.mBtnTheme, Me.mBtnHelp, Me.mBtnAbout, Me.mBtnNewTab, Me.mBtnCloseTab})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1146, 24)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'amnuFile
        '
        Me.amnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewFile, Me.mnuOpenFile, Me.mnuSaveFile, Me.ToolStripSeparator2, Me.mnuExit})
        Me.amnuFile.Name = "amnuFile"
        Me.amnuFile.Size = New System.Drawing.Size(37, 20)
        Me.amnuFile.Text = "&File"
        '
        'mnuNewFile
        '
        Me.mnuNewFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smnuNewFile, Me.smnuNewConf})
        Me.mnuNewFile.Name = "mnuNewFile"
        Me.mnuNewFile.Size = New System.Drawing.Size(124, 22)
        Me.mnuNewFile.Text = "&New File"
        '
        'smnuNewFile
        '
        Me.smnuNewFile.Name = "smnuNewFile"
        Me.smnuNewFile.Size = New System.Drawing.Size(127, 22)
        Me.smnuNewFile.Text = "New Fi&le"
        '
        'smnuNewConf
        '
        Me.smnuNewConf.Name = "smnuNewConf"
        Me.smnuNewConf.Size = New System.Drawing.Size(127, 22)
        Me.smnuNewConf.Text = "New &Conf"
        '
        'mnuOpenFile
        '
        Me.mnuOpenFile.Name = "mnuOpenFile"
        Me.mnuOpenFile.Size = New System.Drawing.Size(124, 22)
        Me.mnuOpenFile.Text = "&Open File"
        '
        'mnuSaveFile
        '
        Me.mnuSaveFile.Name = "mnuSaveFile"
        Me.mnuSaveFile.Size = New System.Drawing.Size(124, 22)
        Me.mnuSaveFile.Text = "&Save File"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(121, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(124, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'amnuProject
        '
        Me.amnuProject.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewProject, Me.mnuOpenProject, Me.mnuSaveProject, Me.ToolStripSeparator3, Me.mnuRun, Me.mnuProjectPath, Me.ToolStripSeparator1, Me.mnuVersion, Me.mnuSyntax})
        Me.amnuProject.Name = "amnuProject"
        Me.amnuProject.Size = New System.Drawing.Size(56, 20)
        Me.amnuProject.Text = "&Project"
        '
        'mnuNewProject
        '
        Me.mnuNewProject.Name = "mnuNewProject"
        Me.mnuNewProject.Size = New System.Drawing.Size(161, 22)
        Me.mnuNewProject.Text = "Ne&w Project"
        '
        'mnuOpenProject
        '
        Me.mnuOpenProject.Name = "mnuOpenProject"
        Me.mnuOpenProject.Size = New System.Drawing.Size(161, 22)
        Me.mnuOpenProject.Text = "Open Pro&ject"
        '
        'mnuSaveProject
        '
        Me.mnuSaveProject.Name = "mnuSaveProject"
        Me.mnuSaveProject.Size = New System.Drawing.Size(161, 22)
        Me.mnuSaveProject.Text = "Sa&ve Project"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(158, 6)
        '
        'mnuRun
        '
        Me.mnuRun.Name = "mnuRun"
        Me.mnuRun.Size = New System.Drawing.Size(161, 22)
        Me.mnuRun.Text = "&Run"
        '
        'mnuProjectPath
        '
        Me.mnuProjectPath.Name = "mnuProjectPath"
        Me.mnuProjectPath.Size = New System.Drawing.Size(161, 22)
        Me.mnuProjectPath.Text = "Project Pat&h"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(158, 6)
        '
        'mnuVersion
        '
        Me.mnuVersion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smnuCommit, Me.smnuPull})
        Me.mnuVersion.Name = "mnuVersion"
        Me.mnuVersion.Size = New System.Drawing.Size(161, 22)
        Me.mnuVersion.Text = "&Version Control"
        '
        'smnuCommit
        '
        Me.smnuCommit.Name = "smnuCommit"
        Me.smnuCommit.Size = New System.Drawing.Size(167, 22)
        Me.smnuCommit.Text = "&Commit to Stable"
        '
        'smnuPull
        '
        Me.smnuPull.Name = "smnuPull"
        Me.smnuPull.Size = New System.Drawing.Size(167, 22)
        Me.smnuPull.Text = "P&ull from Stable"
        '
        'mnuSyntax
        '
        Me.mnuSyntax.Name = "mnuSyntax"
        Me.mnuSyntax.Size = New System.Drawing.Size(161, 22)
        Me.mnuSyntax.Text = "Synta&x Highlight"
        '
        'amnuTheme
        '
        Me.amnuTheme.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuThemeSelect})
        Me.amnuTheme.Name = "amnuTheme"
        Me.amnuTheme.Size = New System.Drawing.Size(56, 20)
        Me.amnuTheme.Text = "&Theme"
        '
        'mnuThemeSelect
        '
        Me.mnuThemeSelect.Name = "mnuThemeSelect"
        Me.mnuThemeSelect.Size = New System.Drawing.Size(156, 22)
        Me.mnuThemeSelect.Text = "Theme &Selector"
        '
        'amnuHelp
        '
        Me.amnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDocumentation, Me.mnuAbout})
        Me.amnuHelp.Name = "amnuHelp"
        Me.amnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.amnuHelp.Text = "&Help"
        '
        'mnuDocumentation
        '
        Me.mnuDocumentation.Name = "mnuDocumentation"
        Me.mnuDocumentation.Size = New System.Drawing.Size(147, 22)
        Me.mnuDocumentation.Text = "&Documention"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(147, 22)
        Me.mnuAbout.Text = "&About"
        '
        'mBtnNewFile
        '
        Me.mBtnNewFile.Image = CType(resources.GetObject("mBtnNewFile.Image"), System.Drawing.Image)
        Me.mBtnNewFile.Name = "mBtnNewFile"
        Me.mBtnNewFile.Size = New System.Drawing.Size(28, 20)
        Me.mBtnNewFile.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.mBtnNewFile.ToolTipText = "New File"
        '
        'mBtnOpenFile
        '
        Me.mBtnOpenFile.Image = CType(resources.GetObject("mBtnOpenFile.Image"), System.Drawing.Image)
        Me.mBtnOpenFile.Name = "mBtnOpenFile"
        Me.mBtnOpenFile.Size = New System.Drawing.Size(28, 20)
        Me.mBtnOpenFile.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.mBtnOpenFile.ToolTipText = "Open File"
        '
        'mBtnSaveFile
        '
        Me.mBtnSaveFile.Image = CType(resources.GetObject("mBtnSaveFile.Image"), System.Drawing.Image)
        Me.mBtnSaveFile.Name = "mBtnSaveFile"
        Me.mBtnSaveFile.Size = New System.Drawing.Size(28, 20)
        Me.mBtnSaveFile.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.mBtnSaveFile.ToolTipText = "Save File"
        '
        'mBtnFind
        '
        Me.mBtnFind.Image = CType(resources.GetObject("mBtnFind.Image"), System.Drawing.Image)
        Me.mBtnFind.Name = "mBtnFind"
        Me.mBtnFind.Size = New System.Drawing.Size(28, 20)
        Me.mBtnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.mBtnFind.ToolTipText = "Find"
        '
        'mBtnNewProject
        '
        Me.mBtnNewProject.Image = CType(resources.GetObject("mBtnNewProject.Image"), System.Drawing.Image)
        Me.mBtnNewProject.Name = "mBtnNewProject"
        Me.mBtnNewProject.Size = New System.Drawing.Size(28, 20)
        Me.mBtnNewProject.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.mBtnNewProject.ToolTipText = "New Project"
        '
        'mBtnOpenProject
        '
        Me.mBtnOpenProject.Image = CType(resources.GetObject("mBtnOpenProject.Image"), System.Drawing.Image)
        Me.mBtnOpenProject.Name = "mBtnOpenProject"
        Me.mBtnOpenProject.Size = New System.Drawing.Size(28, 20)
        Me.mBtnOpenProject.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.mBtnOpenProject.ToolTipText = "Open Project"
        '
        'mBtnSaveProject
        '
        Me.mBtnSaveProject.Image = CType(resources.GetObject("mBtnSaveProject.Image"), System.Drawing.Image)
        Me.mBtnSaveProject.Name = "mBtnSaveProject"
        Me.mBtnSaveProject.Size = New System.Drawing.Size(28, 20)
        Me.mBtnSaveProject.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.mBtnSaveProject.ToolTipText = "Save Project"
        '
        'mBtnCommit
        '
        Me.mBtnCommit.Image = CType(resources.GetObject("mBtnCommit.Image"), System.Drawing.Image)
        Me.mBtnCommit.Name = "mBtnCommit"
        Me.mBtnCommit.Size = New System.Drawing.Size(28, 20)
        Me.mBtnCommit.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.mBtnCommit.ToolTipText = "Commit to Stable"
        '
        'mBtnPull
        '
        Me.mBtnPull.Image = CType(resources.GetObject("mBtnPull.Image"), System.Drawing.Image)
        Me.mBtnPull.Name = "mBtnPull"
        Me.mBtnPull.Size = New System.Drawing.Size(28, 20)
        Me.mBtnPull.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.mBtnPull.ToolTipText = "Overwrite Working"
        '
        'mBtnRun
        '
        Me.mBtnRun.Image = CType(resources.GetObject("mBtnRun.Image"), System.Drawing.Image)
        Me.mBtnRun.Name = "mBtnRun"
        Me.mBtnRun.Size = New System.Drawing.Size(28, 20)
        Me.mBtnRun.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.mBtnRun.ToolTipText = "Run"
        '
        'mBtnTheme
        '
        Me.mBtnTheme.Image = CType(resources.GetObject("mBtnTheme.Image"), System.Drawing.Image)
        Me.mBtnTheme.Name = "mBtnTheme"
        Me.mBtnTheme.Size = New System.Drawing.Size(28, 20)
        Me.mBtnTheme.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.mBtnTheme.ToolTipText = "Theme Selecter"
        '
        'mBtnHelp
        '
        Me.mBtnHelp.Image = CType(resources.GetObject("mBtnHelp.Image"), System.Drawing.Image)
        Me.mBtnHelp.Name = "mBtnHelp"
        Me.mBtnHelp.Size = New System.Drawing.Size(28, 20)
        Me.mBtnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.mBtnHelp.ToolTipText = "Help"
        '
        'mBtnAbout
        '
        Me.mBtnAbout.Image = CType(resources.GetObject("mBtnAbout.Image"), System.Drawing.Image)
        Me.mBtnAbout.Name = "mBtnAbout"
        Me.mBtnAbout.Size = New System.Drawing.Size(28, 20)
        Me.mBtnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.mBtnAbout.ToolTipText = "About"
        '
        'mBtnNewTab
        '
        Me.mBtnNewTab.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mBtnNewTab.Image = CType(resources.GetObject("mBtnNewTab.Image"), System.Drawing.Image)
        Me.mBtnNewTab.Name = "mBtnNewTab"
        Me.mBtnNewTab.Size = New System.Drawing.Size(28, 20)
        Me.mBtnNewTab.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.mBtnNewTab.ToolTipText = "About"
        '
        'mBtnCloseTab
        '
        Me.mBtnCloseTab.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.mBtnCloseTab.Image = CType(resources.GetObject("mBtnCloseTab.Image"), System.Drawing.Image)
        Me.mBtnCloseTab.Name = "mBtnCloseTab"
        Me.mBtnCloseTab.Size = New System.Drawing.Size(28, 20)
        Me.mBtnCloseTab.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.mBtnCloseTab.ToolTipText = "About"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsLbl})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 630)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1146, 22)
        Me.StatusStrip.TabIndex = 2
        Me.StatusStrip.Text = "STATUS"
        '
        'stsLbl
        '
        Me.stsLbl.BorderStyle = System.Windows.Forms.Border3DStyle.Etched
        Me.stsLbl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.stsLbl.Name = "stsLbl"
        Me.stsLbl.Size = New System.Drawing.Size(49, 17)
        Me.stsLbl.Text = "STATUS"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl)
        Me.SplitContainer1.Size = New System.Drawing.Size(1146, 606)
        Me.SplitContainer1.SplitterDistance = 191
        Me.SplitContainer1.TabIndex = 3
        '
        'TreeView
        '
        Me.TreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView.Location = New System.Drawing.Point(0, 0)
        Me.TreeView.Name = "TreeView"
        Me.TreeView.Size = New System.Drawing.Size(191, 606)
        Me.TreeView.TabIndex = 0
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(951, 606)
        Me.TabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(943, 580)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Create or Open a project to get started."
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 652)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "love 2IDE"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents amnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNewFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpenFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TreeView As System.Windows.Forms.TreeView
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents amnuProject As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRun As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuVersion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuCommit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuPull As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents amnuTheme As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuThemeSelect As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents amnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDocumentation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNewProject As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpenProject As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSaveFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSaveProject As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents smnuNewConf As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents mnuProjectPath As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSyntax As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents stsLbl As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mBtnFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mBtnNewFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mBtnOpenFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mBtnSaveFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mBtnSaveProject As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mBtnRun As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mBtnCommit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mBtnPull As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mBtnTheme As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mBtnHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mBtnAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mBtnCloseTab As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mBtnNewTab As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mBtnNewProject As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mBtnOpenProject As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents smnuNewFile As System.Windows.Forms.ToolStripMenuItem

End Class
