<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnPath = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.lblOri = New System.Windows.Forms.Label()
        Me.lvOri = New System.Windows.Forms.ListView()
        Me.chFileName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExtension = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAttribute = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCreated = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAccessed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chModified = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TpFIleName = New System.Windows.Forms.TabPage()
        Me.cbCaseF = New System.Windows.Forms.ComboBox()
        Me.txtRightCropNCharF = New System.Windows.Forms.TextBox()
        Me.txtInsertAfterF = New System.Windows.Forms.TextBox()
        Me.txtWithThisF = New System.Windows.Forms.TextBox()
        Me.rbRightCropNCharF = New System.Windows.Forms.RadioButton()
        Me.RadioButton13 = New System.Windows.Forms.RadioButton()
        Me.lblWithThisF = New System.Windows.Forms.Label()
        Me.lblCaseF = New System.Windows.Forms.Label()
        Me.txtLeftCropNCharF = New System.Windows.Forms.TextBox()
        Me.txtInsertBeforeF = New System.Windows.Forms.TextBox()
        Me.txtReplaceThisF = New System.Windows.Forms.TextBox()
        Me.txtReplaceWithF = New System.Windows.Forms.TextBox()
        Me.rbLeftCropNCharF = New System.Windows.Forms.RadioButton()
        Me.rbinsertAfterF = New System.Windows.Forms.RadioButton()
        Me.rbReplaceThisF = New System.Windows.Forms.RadioButton()
        Me.rbReplaceWithF = New System.Windows.Forms.RadioButton()
        Me.TpExtension = New System.Windows.Forms.TabPage()
        Me.cbCaseE = New System.Windows.Forms.ComboBox()
        Me.txtRightCropNCharE = New System.Windows.Forms.TextBox()
        Me.txtInsertAfterE = New System.Windows.Forms.TextBox()
        Me.txtWithThisE = New System.Windows.Forms.TextBox()
        Me.rbRightCropNCharE = New System.Windows.Forms.RadioButton()
        Me.rbInsertAfterE = New System.Windows.Forms.RadioButton()
        Me.lblWithThisE = New System.Windows.Forms.Label()
        Me.lblCaseE = New System.Windows.Forms.Label()
        Me.txtLeftCropNCharE = New System.Windows.Forms.TextBox()
        Me.txtInsertBeforeE = New System.Windows.Forms.TextBox()
        Me.txtReplaceThisE = New System.Windows.Forms.TextBox()
        Me.txtReplaceWithE = New System.Windows.Forms.TextBox()
        Me.rbLeftCropNCharE = New System.Windows.Forms.RadioButton()
        Me.RrbInsertBeforeE = New System.Windows.Forms.RadioButton()
        Me.rbReplaceThisE = New System.Windows.Forms.RadioButton()
        Me.rbReplaceWithE = New System.Windows.Forms.RadioButton()
        Me.TpAutoNumber = New System.Windows.Forms.TabPage()
        Me.gbWith = New System.Windows.Forms.GroupBox()
        Me.nudIncrementBy = New System.Windows.Forms.NumericUpDown()
        Me.nudStartWithNumber = New System.Windows.Forms.NumericUpDown()
        Me.lblIncrementBy = New System.Windows.Forms.Label()
        Me.lblStartWithNumber = New System.Windows.Forms.Label()
        Me.gbPlace = New System.Windows.Forms.GroupBox()
        Me.rbBeforeFileName = New System.Windows.Forms.RadioButton()
        Me.rbAfterFileName = New System.Windows.Forms.RadioButton()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtExt = New System.Windows.Forms.TextBox()
        Me.lvPreview = New System.Windows.Forms.ListView()
        Me.chFileName2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExtension2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAttribute2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCreated2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAccessed2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chModified2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TpFIleName.SuspendLayout()
        Me.TpExtension.SuspendLayout()
        Me.TpAutoNumber.SuspendLayout()
        Me.gbWith.SuspendLayout()
        CType(Me.nudIncrementBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStartWithNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPlace.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPath
        '
        Me.btnPath.Location = New System.Drawing.Point(751, 66)
        Me.btnPath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPath.Name = "btnPath"
        Me.btnPath.Size = New System.Drawing.Size(53, 30)
        Me.btnPath.TabIndex = 0
        Me.btnPath.Text = ". . ."
        Me.btnPath.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtPath.Location = New System.Drawing.Point(125, 66)
        Me.txtPath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPath.Multiline = True
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(616, 29)
        Me.txtPath.TabIndex = 1
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(71, 74)
        Me.lblPath.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(40, 16)
        Me.lblPath.TabIndex = 2
        Me.lblPath.Text = "Path :"
        '
        'lblOri
        '
        Me.lblOri.AutoSize = True
        Me.lblOri.Location = New System.Drawing.Point(71, 111)
        Me.lblOri.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOri.Name = "lblOri"
        Me.lblOri.Size = New System.Drawing.Size(84, 16)
        Me.lblOri.TabIndex = 3
        Me.lblOri.Text = "Original FIle :"
        '
        'lvOri
        '
        Me.lvOri.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chFileName, Me.chExtension, Me.chAttribute, Me.chCreated, Me.chAccessed, Me.chModified})
        Me.lvOri.GridLines = True
        Me.lvOri.HideSelection = False
        Me.lvOri.Location = New System.Drawing.Point(75, 144)
        Me.lvOri.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lvOri.Name = "lvOri"
        Me.lvOri.Size = New System.Drawing.Size(449, 280)
        Me.lvOri.TabIndex = 4
        Me.lvOri.UseCompatibleStateImageBehavior = False
        Me.lvOri.View = System.Windows.Forms.View.Details
        '
        'chFileName
        '
        Me.chFileName.Text = "chFileName"
        '
        'chExtension
        '
        Me.chExtension.Text = "Extension"
        '
        'chAttribute
        '
        Me.chAttribute.Text = "Attributes"
        '
        'chCreated
        '
        Me.chCreated.Text = "Date Created"
        '
        'chAccessed
        '
        Me.chAccessed.Text = "Date Accessed"
        '
        'chModified
        '
        Me.chModified.Text = "Date Modified"
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.Location = New System.Drawing.Point(548, 111)
        Me.lblPreview.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(89, 16)
        Me.lblPreview.TabIndex = 5
        Me.lblPreview.Text = "Preview File  :"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TpFIleName)
        Me.TabControl1.Controls.Add(Me.TpExtension)
        Me.TabControl1.Controls.Add(Me.TpAutoNumber)
        Me.TabControl1.Location = New System.Drawing.Point(16, 441)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(831, 236)
        Me.TabControl1.TabIndex = 7
        '
        'TpFIleName
        '
        Me.TpFIleName.Controls.Add(Me.cbCaseF)
        Me.TpFIleName.Controls.Add(Me.txtRightCropNCharF)
        Me.TpFIleName.Controls.Add(Me.txtInsertAfterF)
        Me.TpFIleName.Controls.Add(Me.txtWithThisF)
        Me.TpFIleName.Controls.Add(Me.rbRightCropNCharF)
        Me.TpFIleName.Controls.Add(Me.RadioButton13)
        Me.TpFIleName.Controls.Add(Me.lblWithThisF)
        Me.TpFIleName.Controls.Add(Me.lblCaseF)
        Me.TpFIleName.Controls.Add(Me.txtLeftCropNCharF)
        Me.TpFIleName.Controls.Add(Me.txtInsertBeforeF)
        Me.TpFIleName.Controls.Add(Me.txtReplaceThisF)
        Me.TpFIleName.Controls.Add(Me.txtReplaceWithF)
        Me.TpFIleName.Controls.Add(Me.rbLeftCropNCharF)
        Me.TpFIleName.Controls.Add(Me.rbinsertAfterF)
        Me.TpFIleName.Controls.Add(Me.rbReplaceThisF)
        Me.TpFIleName.Controls.Add(Me.rbReplaceWithF)
        Me.TpFIleName.Location = New System.Drawing.Point(4, 25)
        Me.TpFIleName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TpFIleName.Name = "TpFIleName"
        Me.TpFIleName.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TpFIleName.Size = New System.Drawing.Size(823, 207)
        Me.TpFIleName.TabIndex = 0
        Me.TpFIleName.Text = "Filename"
        Me.TpFIleName.UseVisualStyleBackColor = True
        '
        'cbCaseF
        '
        Me.cbCaseF.FormattingEnabled = True
        Me.cbCaseF.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        Me.cbCaseF.Location = New System.Drawing.Point(641, 23)
        Me.cbCaseF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbCaseF.Name = "cbCaseF"
        Me.cbCaseF.Size = New System.Drawing.Size(140, 24)
        Me.cbCaseF.TabIndex = 15
        '
        'txtRightCropNCharF
        '
        Me.txtRightCropNCharF.Location = New System.Drawing.Point(623, 151)
        Me.txtRightCropNCharF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRightCropNCharF.Name = "txtRightCropNCharF"
        Me.txtRightCropNCharF.ReadOnly = True
        Me.txtRightCropNCharF.Size = New System.Drawing.Size(159, 22)
        Me.txtRightCropNCharF.TabIndex = 14
        '
        'txtInsertAfterF
        '
        Me.txtInsertAfterF.Location = New System.Drawing.Point(579, 107)
        Me.txtInsertAfterF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInsertAfterF.Name = "txtInsertAfterF"
        Me.txtInsertAfterF.ReadOnly = True
        Me.txtInsertAfterF.Size = New System.Drawing.Size(203, 22)
        Me.txtInsertAfterF.TabIndex = 13
        '
        'txtWithThisF
        '
        Me.txtWithThisF.Location = New System.Drawing.Point(579, 66)
        Me.txtWithThisF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtWithThisF.Name = "txtWithThisF"
        Me.txtWithThisF.ReadOnly = True
        Me.txtWithThisF.Size = New System.Drawing.Size(203, 22)
        Me.txtWithThisF.TabIndex = 12
        '
        'rbRightCropNCharF
        '
        Me.rbRightCropNCharF.AutoSize = True
        Me.rbRightCropNCharF.Location = New System.Drawing.Point(468, 155)
        Me.rbRightCropNCharF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbRightCropNCharF.Name = "rbRightCropNCharF"
        Me.rbRightCropNCharF.Size = New System.Drawing.Size(131, 20)
        Me.rbRightCropNCharF.TabIndex = 11
        Me.rbRightCropNCharF.TabStop = True
        Me.rbRightCropNCharF.Text = "Right crop n char:"
        Me.rbRightCropNCharF.UseVisualStyleBackColor = True
        '
        'RadioButton13
        '
        Me.RadioButton13.AutoSize = True
        Me.RadioButton13.Location = New System.Drawing.Point(468, 113)
        Me.RadioButton13.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioButton13.Name = "RadioButton13"
        Me.RadioButton13.Size = New System.Drawing.Size(95, 20)
        Me.RadioButton13.TabIndex = 10
        Me.RadioButton13.TabStop = True
        Me.RadioButton13.Text = "Insert after :"
        Me.RadioButton13.UseVisualStyleBackColor = True
        '
        'lblWithThisF
        '
        Me.lblWithThisF.AutoSize = True
        Me.lblWithThisF.Location = New System.Drawing.Point(495, 70)
        Me.lblWithThisF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWithThisF.Name = "lblWithThisF"
        Me.lblWithThisF.Size = New System.Drawing.Size(52, 16)
        Me.lblWithThisF.TabIndex = 9
        Me.lblWithThisF.Text = "with this"
        '
        'lblCaseF
        '
        Me.lblCaseF.AutoSize = True
        Me.lblCaseF.Location = New System.Drawing.Point(588, 28)
        Me.lblCaseF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCaseF.Name = "lblCaseF"
        Me.lblCaseF.Size = New System.Drawing.Size(42, 16)
        Me.lblCaseF.TabIndex = 8
        Me.lblCaseF.Text = "Case:"
        '
        'txtLeftCropNCharF
        '
        Me.txtLeftCropNCharF.Location = New System.Drawing.Point(176, 155)
        Me.txtLeftCropNCharF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLeftCropNCharF.Name = "txtLeftCropNCharF"
        Me.txtLeftCropNCharF.ReadOnly = True
        Me.txtLeftCropNCharF.Size = New System.Drawing.Size(132, 22)
        Me.txtLeftCropNCharF.TabIndex = 7
        '
        'txtInsertBeforeF
        '
        Me.txtInsertBeforeF.Location = New System.Drawing.Point(176, 111)
        Me.txtInsertBeforeF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInsertBeforeF.Name = "txtInsertBeforeF"
        Me.txtInsertBeforeF.ReadOnly = True
        Me.txtInsertBeforeF.Size = New System.Drawing.Size(269, 22)
        Me.txtInsertBeforeF.TabIndex = 6
        '
        'txtReplaceThisF
        '
        Me.txtReplaceThisF.Location = New System.Drawing.Point(176, 66)
        Me.txtReplaceThisF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtReplaceThisF.Name = "txtReplaceThisF"
        Me.txtReplaceThisF.ReadOnly = True
        Me.txtReplaceThisF.Size = New System.Drawing.Size(295, 22)
        Me.txtReplaceThisF.TabIndex = 5
        '
        'txtReplaceWithF
        '
        Me.txtReplaceWithF.Location = New System.Drawing.Point(176, 25)
        Me.txtReplaceWithF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtReplaceWithF.Name = "txtReplaceWithF"
        Me.txtReplaceWithF.ReadOnly = True
        Me.txtReplaceWithF.Size = New System.Drawing.Size(389, 22)
        Me.txtReplaceWithF.TabIndex = 4
        '
        'rbLeftCropNCharF
        '
        Me.rbLeftCropNCharF.AutoSize = True
        Me.rbLeftCropNCharF.Location = New System.Drawing.Point(29, 155)
        Me.rbLeftCropNCharF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbLeftCropNCharF.Name = "rbLeftCropNCharF"
        Me.rbLeftCropNCharF.Size = New System.Drawing.Size(118, 20)
        Me.rbLeftCropNCharF.TabIndex = 3
        Me.rbLeftCropNCharF.TabStop = True
        Me.rbLeftCropNCharF.Text = "Left crop n char"
        Me.rbLeftCropNCharF.UseVisualStyleBackColor = True
        '
        'rbinsertAfterF
        '
        Me.rbinsertAfterF.AutoSize = True
        Me.rbinsertAfterF.Location = New System.Drawing.Point(29, 111)
        Me.rbinsertAfterF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbinsertAfterF.Name = "rbinsertAfterF"
        Me.rbinsertAfterF.Size = New System.Drawing.Size(102, 20)
        Me.rbinsertAfterF.TabIndex = 2
        Me.rbinsertAfterF.TabStop = True
        Me.rbinsertAfterF.Text = "Insert before"
        Me.rbinsertAfterF.UseVisualStyleBackColor = True
        '
        'rbReplaceThisF
        '
        Me.rbReplaceThisF.AutoSize = True
        Me.rbReplaceThisF.Location = New System.Drawing.Point(29, 66)
        Me.rbReplaceThisF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbReplaceThisF.Name = "rbReplaceThisF"
        Me.rbReplaceThisF.Size = New System.Drawing.Size(103, 20)
        Me.rbReplaceThisF.TabIndex = 1
        Me.rbReplaceThisF.TabStop = True
        Me.rbReplaceThisF.Text = "Replace this"
        Me.rbReplaceThisF.UseVisualStyleBackColor = True
        '
        'rbReplaceWithF
        '
        Me.rbReplaceWithF.AutoSize = True
        Me.rbReplaceWithF.Location = New System.Drawing.Point(29, 25)
        Me.rbReplaceWithF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbReplaceWithF.Name = "rbReplaceWithF"
        Me.rbReplaceWithF.Size = New System.Drawing.Size(108, 20)
        Me.rbReplaceWithF.TabIndex = 0
        Me.rbReplaceWithF.TabStop = True
        Me.rbReplaceWithF.Text = "Replace with:"
        Me.rbReplaceWithF.UseVisualStyleBackColor = True
        '
        'TpExtension
        '
        Me.TpExtension.Controls.Add(Me.cbCaseE)
        Me.TpExtension.Controls.Add(Me.txtRightCropNCharE)
        Me.TpExtension.Controls.Add(Me.txtInsertAfterE)
        Me.TpExtension.Controls.Add(Me.txtWithThisE)
        Me.TpExtension.Controls.Add(Me.rbRightCropNCharE)
        Me.TpExtension.Controls.Add(Me.rbInsertAfterE)
        Me.TpExtension.Controls.Add(Me.lblWithThisE)
        Me.TpExtension.Controls.Add(Me.lblCaseE)
        Me.TpExtension.Controls.Add(Me.txtLeftCropNCharE)
        Me.TpExtension.Controls.Add(Me.txtInsertBeforeE)
        Me.TpExtension.Controls.Add(Me.txtReplaceThisE)
        Me.TpExtension.Controls.Add(Me.txtReplaceWithE)
        Me.TpExtension.Controls.Add(Me.rbLeftCropNCharE)
        Me.TpExtension.Controls.Add(Me.RrbInsertBeforeE)
        Me.TpExtension.Controls.Add(Me.rbReplaceThisE)
        Me.TpExtension.Controls.Add(Me.rbReplaceWithE)
        Me.TpExtension.Location = New System.Drawing.Point(4, 25)
        Me.TpExtension.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TpExtension.Name = "TpExtension"
        Me.TpExtension.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TpExtension.Size = New System.Drawing.Size(823, 207)
        Me.TpExtension.TabIndex = 1
        Me.TpExtension.Text = "Extension"
        Me.TpExtension.UseVisualStyleBackColor = True
        '
        'cbCaseE
        '
        Me.cbCaseE.FormattingEnabled = True
        Me.cbCaseE.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        Me.cbCaseE.Location = New System.Drawing.Point(625, 25)
        Me.cbCaseE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbCaseE.Name = "cbCaseE"
        Me.cbCaseE.Size = New System.Drawing.Size(160, 24)
        Me.cbCaseE.TabIndex = 15
        '
        'txtRightCropNCharE
        '
        Me.txtRightCropNCharE.Location = New System.Drawing.Point(639, 144)
        Me.txtRightCropNCharE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRightCropNCharE.Name = "txtRightCropNCharE"
        Me.txtRightCropNCharE.Size = New System.Drawing.Size(152, 22)
        Me.txtRightCropNCharE.TabIndex = 14
        '
        'txtInsertAfterE
        '
        Me.txtInsertAfterE.Location = New System.Drawing.Point(596, 105)
        Me.txtInsertAfterE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInsertAfterE.Name = "txtInsertAfterE"
        Me.txtInsertAfterE.Size = New System.Drawing.Size(195, 22)
        Me.txtInsertAfterE.TabIndex = 13
        '
        'txtWithThisE
        '
        Me.txtWithThisE.Location = New System.Drawing.Point(548, 64)
        Me.txtWithThisE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtWithThisE.Name = "txtWithThisE"
        Me.txtWithThisE.Size = New System.Drawing.Size(243, 22)
        Me.txtWithThisE.TabIndex = 12
        '
        'rbRightCropNCharE
        '
        Me.rbRightCropNCharE.AutoSize = True
        Me.rbRightCropNCharE.Location = New System.Drawing.Point(484, 148)
        Me.rbRightCropNCharE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbRightCropNCharE.Name = "rbRightCropNCharE"
        Me.rbRightCropNCharE.Size = New System.Drawing.Size(131, 20)
        Me.rbRightCropNCharE.TabIndex = 11
        Me.rbRightCropNCharE.TabStop = True
        Me.rbRightCropNCharE.Text = "Rgith crop n char:"
        Me.rbRightCropNCharE.UseVisualStyleBackColor = True
        '
        'rbInsertAfterE
        '
        Me.rbInsertAfterE.AutoSize = True
        Me.rbInsertAfterE.Location = New System.Drawing.Point(484, 108)
        Me.rbInsertAfterE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbInsertAfterE.Name = "rbInsertAfterE"
        Me.rbInsertAfterE.Size = New System.Drawing.Size(92, 20)
        Me.rbInsertAfterE.TabIndex = 10
        Me.rbInsertAfterE.TabStop = True
        Me.rbInsertAfterE.Text = "Insert after:"
        Me.rbInsertAfterE.UseVisualStyleBackColor = True
        '
        'lblWithThisE
        '
        Me.lblWithThisE.AutoSize = True
        Me.lblWithThisE.Location = New System.Drawing.Point(480, 66)
        Me.lblWithThisE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWithThisE.Name = "lblWithThisE"
        Me.lblWithThisE.Size = New System.Drawing.Size(52, 16)
        Me.lblWithThisE.TabIndex = 9
        Me.lblWithThisE.Text = "with this"
        '
        'lblCaseE
        '
        Me.lblCaseE.AutoSize = True
        Me.lblCaseE.Location = New System.Drawing.Point(567, 25)
        Me.lblCaseE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCaseE.Name = "lblCaseE"
        Me.lblCaseE.Size = New System.Drawing.Size(45, 16)
        Me.lblCaseE.TabIndex = 8
        Me.lblCaseE.Text = "Case :"
        '
        'txtLeftCropNCharE
        '
        Me.txtLeftCropNCharE.Location = New System.Drawing.Point(177, 148)
        Me.txtLeftCropNCharE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLeftCropNCharE.Name = "txtLeftCropNCharE"
        Me.txtLeftCropNCharE.Size = New System.Drawing.Size(148, 22)
        Me.txtLeftCropNCharE.TabIndex = 7
        '
        'txtInsertBeforeE
        '
        Me.txtInsertBeforeE.Location = New System.Drawing.Point(177, 105)
        Me.txtInsertBeforeE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInsertBeforeE.Name = "txtInsertBeforeE"
        Me.txtInsertBeforeE.Size = New System.Drawing.Size(289, 22)
        Me.txtInsertBeforeE.TabIndex = 6
        '
        'txtReplaceThisE
        '
        Me.txtReplaceThisE.Location = New System.Drawing.Point(177, 64)
        Me.txtReplaceThisE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtReplaceThisE.Name = "txtReplaceThisE"
        Me.txtReplaceThisE.Size = New System.Drawing.Size(289, 22)
        Me.txtReplaceThisE.TabIndex = 5
        '
        'txtReplaceWithE
        '
        Me.txtReplaceWithE.Location = New System.Drawing.Point(177, 25)
        Me.txtReplaceWithE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtReplaceWithE.Name = "txtReplaceWithE"
        Me.txtReplaceWithE.Size = New System.Drawing.Size(361, 22)
        Me.txtReplaceWithE.TabIndex = 4
        '
        'rbLeftCropNCharE
        '
        Me.rbLeftCropNCharE.AutoSize = True
        Me.rbLeftCropNCharE.Location = New System.Drawing.Point(31, 151)
        Me.rbLeftCropNCharE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbLeftCropNCharE.Name = "rbLeftCropNCharE"
        Me.rbLeftCropNCharE.Size = New System.Drawing.Size(121, 20)
        Me.rbLeftCropNCharE.TabIndex = 3
        Me.rbLeftCropNCharE.TabStop = True
        Me.rbLeftCropNCharE.Text = "Left crop n char:"
        Me.rbLeftCropNCharE.UseVisualStyleBackColor = True
        '
        'RrbInsertBeforeE
        '
        Me.RrbInsertBeforeE.AutoSize = True
        Me.RrbInsertBeforeE.Location = New System.Drawing.Point(31, 108)
        Me.RrbInsertBeforeE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RrbInsertBeforeE.Name = "RrbInsertBeforeE"
        Me.RrbInsertBeforeE.Size = New System.Drawing.Size(105, 20)
        Me.RrbInsertBeforeE.TabIndex = 2
        Me.RrbInsertBeforeE.TabStop = True
        Me.RrbInsertBeforeE.Text = "Insert before:"
        Me.RrbInsertBeforeE.UseVisualStyleBackColor = True
        '
        'rbReplaceThisE
        '
        Me.rbReplaceThisE.AutoSize = True
        Me.rbReplaceThisE.Location = New System.Drawing.Point(31, 64)
        Me.rbReplaceThisE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbReplaceThisE.Name = "rbReplaceThisE"
        Me.rbReplaceThisE.Size = New System.Drawing.Size(103, 20)
        Me.rbReplaceThisE.TabIndex = 1
        Me.rbReplaceThisE.TabStop = True
        Me.rbReplaceThisE.Text = "Replace this"
        Me.rbReplaceThisE.UseVisualStyleBackColor = True
        '
        'rbReplaceWithE
        '
        Me.rbReplaceWithE.AutoSize = True
        Me.rbReplaceWithE.Location = New System.Drawing.Point(31, 25)
        Me.rbReplaceWithE.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbReplaceWithE.Name = "rbReplaceWithE"
        Me.rbReplaceWithE.Size = New System.Drawing.Size(108, 20)
        Me.rbReplaceWithE.TabIndex = 0
        Me.rbReplaceWithE.TabStop = True
        Me.rbReplaceWithE.Text = "Replace with:"
        Me.rbReplaceWithE.UseVisualStyleBackColor = True
        '
        'TpAutoNumber
        '
        Me.TpAutoNumber.Controls.Add(Me.gbWith)
        Me.TpAutoNumber.Controls.Add(Me.gbPlace)
        Me.TpAutoNumber.Location = New System.Drawing.Point(4, 25)
        Me.TpAutoNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TpAutoNumber.Name = "TpAutoNumber"
        Me.TpAutoNumber.Size = New System.Drawing.Size(823, 207)
        Me.TpAutoNumber.TabIndex = 2
        Me.TpAutoNumber.Text = "Autonumber"
        Me.TpAutoNumber.UseVisualStyleBackColor = True
        '
        'gbWith
        '
        Me.gbWith.Controls.Add(Me.nudIncrementBy)
        Me.gbWith.Controls.Add(Me.nudStartWithNumber)
        Me.gbWith.Controls.Add(Me.lblIncrementBy)
        Me.gbWith.Controls.Add(Me.lblStartWithNumber)
        Me.gbWith.Location = New System.Drawing.Point(429, 25)
        Me.gbWith.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbWith.Name = "gbWith"
        Me.gbWith.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbWith.Size = New System.Drawing.Size(353, 154)
        Me.gbWith.TabIndex = 1
        Me.gbWith.TabStop = False
        Me.gbWith.Text = "With :"
        '
        'nudIncrementBy
        '
        Me.nudIncrementBy.Location = New System.Drawing.Point(164, 79)
        Me.nudIncrementBy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudIncrementBy.Name = "nudIncrementBy"
        Me.nudIncrementBy.Size = New System.Drawing.Size(160, 22)
        Me.nudIncrementBy.TabIndex = 3
        '
        'nudStartWithNumber
        '
        Me.nudStartWithNumber.Location = New System.Drawing.Point(164, 36)
        Me.nudStartWithNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudStartWithNumber.Name = "nudStartWithNumber"
        Me.nudStartWithNumber.Size = New System.Drawing.Size(160, 22)
        Me.nudStartWithNumber.TabIndex = 2
        '
        'lblIncrementBy
        '
        Me.lblIncrementBy.AutoSize = True
        Me.lblIncrementBy.Location = New System.Drawing.Point(37, 81)
        Me.lblIncrementBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIncrementBy.Name = "lblIncrementBy"
        Me.lblIncrementBy.Size = New System.Drawing.Size(86, 16)
        Me.lblIncrementBy.TabIndex = 1
        Me.lblIncrementBy.Text = "Increment by:"
        '
        'lblStartWithNumber
        '
        Me.lblStartWithNumber.AutoSize = True
        Me.lblStartWithNumber.Location = New System.Drawing.Point(33, 38)
        Me.lblStartWithNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStartWithNumber.Name = "lblStartWithNumber"
        Me.lblStartWithNumber.Size = New System.Drawing.Size(110, 16)
        Me.lblStartWithNumber.TabIndex = 0
        Me.lblStartWithNumber.Text = "Start with number:"
        '
        'gbPlace
        '
        Me.gbPlace.Controls.Add(Me.rbBeforeFileName)
        Me.gbPlace.Controls.Add(Me.rbAfterFileName)
        Me.gbPlace.Location = New System.Drawing.Point(29, 25)
        Me.gbPlace.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbPlace.Name = "gbPlace"
        Me.gbPlace.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbPlace.Size = New System.Drawing.Size(353, 154)
        Me.gbPlace.TabIndex = 0
        Me.gbPlace.TabStop = False
        Me.gbPlace.Text = "Place :"
        '
        'rbBeforeFileName
        '
        Me.rbBeforeFileName.AutoSize = True
        Me.rbBeforeFileName.Location = New System.Drawing.Point(24, 81)
        Me.rbBeforeFileName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbBeforeFileName.Name = "rbBeforeFileName"
        Me.rbBeforeFileName.Size = New System.Drawing.Size(122, 20)
        Me.rbBeforeFileName.TabIndex = 1
        Me.rbBeforeFileName.Text = "Before filename"
        Me.rbBeforeFileName.UseVisualStyleBackColor = True
        '
        'rbAfterFileName
        '
        Me.rbAfterFileName.AutoSize = True
        Me.rbAfterFileName.Location = New System.Drawing.Point(24, 38)
        Me.rbAfterFileName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbAfterFileName.Name = "rbAfterFileName"
        Me.rbAfterFileName.Size = New System.Drawing.Size(109, 20)
        Me.rbAfterFileName.TabIndex = 0
        Me.rbAfterFileName.Text = "After filename"
        Me.rbAfterFileName.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(873, 484)
        Me.btnPreview.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(100, 28)
        Me.btnPreview.TabIndex = 8
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'btnRename
        '
        Me.btnRename.Location = New System.Drawing.Point(873, 538)
        Me.btnRename.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(100, 28)
        Me.btnRename.TabIndex = 9
        Me.btnRename.Text = "Rename"
        Me.btnRename.UseVisualStyleBackColor = True
        '
        'btnUndo
        '
        Me.btnUndo.Location = New System.Drawing.Point(873, 593)
        Me.btnUndo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(100, 28)
        Me.btnUndo.TabIndex = 10
        Me.btnUndo.Text = "Undo"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(829, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "File Mask : "
        '
        'txtExt
        '
        Me.txtExt.Location = New System.Drawing.Point(907, 70)
        Me.txtExt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtExt.Name = "txtExt"
        Me.txtExt.Size = New System.Drawing.Size(83, 22)
        Me.txtExt.TabIndex = 12
        Me.txtExt.Text = "*.*"
        '
        'lvPreview
        '
        Me.lvPreview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chFileName2, Me.chExtension2, Me.chAttribute2, Me.chCreated2, Me.chAccessed2, Me.chModified2})
        Me.lvPreview.GridLines = True
        Me.lvPreview.HideSelection = False
        Me.lvPreview.Location = New System.Drawing.Point(579, 144)
        Me.lvPreview.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lvPreview.Name = "lvPreview"
        Me.lvPreview.Size = New System.Drawing.Size(449, 280)
        Me.lvPreview.TabIndex = 13
        Me.lvPreview.UseCompatibleStateImageBehavior = False
        Me.lvPreview.View = System.Windows.Forms.View.Details
        '
        'chFileName2
        '
        Me.chFileName2.Text = "chFileName"
        '
        'chExtension2
        '
        Me.chExtension2.Text = "Extension"
        '
        'chAttribute2
        '
        Me.chAttribute2.Text = "Attributes"
        '
        'chCreated2
        '
        Me.chCreated2.Text = "Date Created"
        '
        'chAccessed2
        '
        Me.chAccessed2.Text = "Date Accessed"
        '
        'chModified2
        '
        Me.chModified2.Text = "Date Modified"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 690)
        Me.Controls.Add(Me.lvPreview)
        Me.Controls.Add(Me.txtExt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.lvOri)
        Me.Controls.Add(Me.lblOri)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.btnPath)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mass Renamer"
        Me.TabControl1.ResumeLayout(False)
        Me.TpFIleName.ResumeLayout(False)
        Me.TpFIleName.PerformLayout()
        Me.TpExtension.ResumeLayout(False)
        Me.TpExtension.PerformLayout()
        Me.TpAutoNumber.ResumeLayout(False)
        Me.gbWith.ResumeLayout(False)
        Me.gbWith.PerformLayout()
        CType(Me.nudIncrementBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStartWithNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPlace.ResumeLayout(False)
        Me.gbPlace.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents btnPath As Button
    Friend WithEvents txtPath As TextBox
    Friend WithEvents lblPath As Label
    Friend WithEvents lblOri As Label
    Friend WithEvents lvOri As ListView
    Friend WithEvents lblPreview As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TpFIleName As TabPage
    Friend WithEvents cbCaseF As ComboBox
    Friend WithEvents txtRightCropNCharF As TextBox
    Friend WithEvents txtInsertAfterF As TextBox
    Friend WithEvents txtWithThisF As TextBox
    Friend WithEvents rbRightCropNCharF As RadioButton
    Friend WithEvents RadioButton13 As RadioButton
    Friend WithEvents lblWithThisF As Label
    Friend WithEvents lblCaseF As Label
    Friend WithEvents txtLeftCropNCharF As TextBox
    Friend WithEvents txtInsertBeforeF As TextBox
    Friend WithEvents txtReplaceThisF As TextBox
    Friend WithEvents txtReplaceWithF As TextBox
    Friend WithEvents rbLeftCropNCharF As RadioButton
    Friend WithEvents rbinsertAfterF As RadioButton
    Friend WithEvents rbReplaceThisF As RadioButton
    Friend WithEvents rbReplaceWithF As RadioButton
    Friend WithEvents TpExtension As TabPage
    Friend WithEvents cbCaseE As ComboBox
    Friend WithEvents txtRightCropNCharE As TextBox
    Friend WithEvents txtInsertAfterE As TextBox
    Friend WithEvents txtWithThisE As TextBox
    Friend WithEvents rbRightCropNCharE As RadioButton
    Friend WithEvents rbInsertAfterE As RadioButton
    Friend WithEvents lblWithThisE As Label
    Friend WithEvents lblCaseE As Label
    Friend WithEvents txtLeftCropNCharE As TextBox
    Friend WithEvents txtInsertBeforeE As TextBox
    Friend WithEvents txtReplaceThisE As TextBox
    Friend WithEvents txtReplaceWithE As TextBox
    Friend WithEvents rbLeftCropNCharE As RadioButton
    Friend WithEvents RrbInsertBeforeE As RadioButton
    Friend WithEvents rbReplaceThisE As RadioButton
    Friend WithEvents rbReplaceWithE As RadioButton
    Friend WithEvents TpAutoNumber As TabPage
    Friend WithEvents gbWith As GroupBox
    Friend WithEvents nudIncrementBy As NumericUpDown
    Friend WithEvents nudStartWithNumber As NumericUpDown
    Friend WithEvents lblIncrementBy As Label
    Friend WithEvents lblStartWithNumber As Label
    Friend WithEvents gbPlace As GroupBox
    Friend WithEvents rbBeforeFileName As RadioButton
    Friend WithEvents rbAfterFileName As RadioButton
    Friend WithEvents btnPreview As Button
    Friend WithEvents btnRename As Button
    Friend WithEvents btnUndo As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtExt As TextBox
    Friend WithEvents chFileName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chAttribute As ColumnHeader
    Friend WithEvents chCreated As ColumnHeader
    Friend WithEvents chAccessed As ColumnHeader
    Friend WithEvents chModified As ColumnHeader
    Friend WithEvents lvPreview As ListView
    Friend WithEvents chFileName2 As ColumnHeader
    Friend WithEvents chExtension2 As ColumnHeader
    Friend WithEvents chAttribute2 As ColumnHeader
    Friend WithEvents chCreated2 As ColumnHeader
    Friend WithEvents chAccessed2 As ColumnHeader
    Friend WithEvents chModified2 As ColumnHeader
    Friend WithEvents ImageList1 As ImageList
End Class
