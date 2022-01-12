'''' Desenvolvido por Siael Carvalho. Última atualização: 04/06/2015 20:21
'''' Contato: siaelalves@outlook.com | (32) 9122-3016
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtSt = New System.Windows.Forms.RichTextBox()
        Me.lblDwnLc = New System.Windows.Forms.Label()
        Me.cmdOrg = New System.Windows.Forms.Button()
        Me.lstClas = New System.Windows.Forms.ListView()
        Me.clmTp = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmPst = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.cmdAltLc = New System.Windows.Forms.LinkLabel()
        Me.txtDwnLc = New System.Windows.Forms.Label()
        Me.dlgDwnLc = New System.Windows.Forms.FolderBrowserDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.prgAtu = New System.Windows.Forms.ToolStripProgressBar()
        Me.lblPrg = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSt
        '
        Me.txtSt.Location = New System.Drawing.Point(364, 67)
        Me.txtSt.Name = "txtSt"
        Me.txtSt.Size = New System.Drawing.Size(252, 262)
        Me.txtSt.TabIndex = 0
        Me.txtSt.Text = ""
        '
        'lblDwnLc
        '
        Me.lblDwnLc.AutoSize = True
        Me.lblDwnLc.Location = New System.Drawing.Point(12, 9)
        Me.lblDwnLc.Name = "lblDwnLc"
        Me.lblDwnLc.Size = New System.Drawing.Size(136, 13)
        Me.lblDwnLc.TabIndex = 3
        Me.lblDwnLc.Text = "Local da pasta Downloads:"
        '
        'cmdOrg
        '
        Me.cmdOrg.Location = New System.Drawing.Point(248, 306)
        Me.cmdOrg.Name = "cmdOrg"
        Me.cmdOrg.Size = New System.Drawing.Size(110, 23)
        Me.cmdOrg.TabIndex = 4
        Me.cmdOrg.Text = "&Organizar agora"
        Me.cmdOrg.UseVisualStyleBackColor = True
        '
        'lstClas
        '
        Me.lstClas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmTp, Me.clmPst})
        Me.lstClas.FullRowSelect = True
        Me.lstClas.GridLines = True
        Me.lstClas.LabelEdit = True
        Me.lstClas.Location = New System.Drawing.Point(15, 51)
        Me.lstClas.MultiSelect = False
        Me.lstClas.Name = "lstClas"
        Me.lstClas.Size = New System.Drawing.Size(343, 249)
        Me.lstClas.TabIndex = 5
        Me.lstClas.UseCompatibleStateImageBehavior = False
        Me.lstClas.View = System.Windows.Forms.View.Details
        '
        'clmTp
        '
        Me.clmTp.Text = "Tipos de arquivo"
        Me.clmTp.Width = 108
        '
        'clmPst
        '
        Me.clmPst.Text = "Pasta"
        Me.clmPst.Width = 219
        '
        'lblMsg
        '
        Me.lblMsg.AutoSize = True
        Me.lblMsg.Location = New System.Drawing.Point(361, 51)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(65, 13)
        Me.lblMsg.TabIndex = 6
        Me.lblMsg.Text = "Mensagens:"
        '
        'cmdAltLc
        '
        Me.cmdAltLc.AutoSize = True
        Me.cmdAltLc.Location = New System.Drawing.Point(364, 32)
        Me.cmdAltLc.Name = "cmdAltLc"
        Me.cmdAltLc.Size = New System.Drawing.Size(80, 13)
        Me.cmdAltLc.TabIndex = 7
        Me.cmdAltLc.TabStop = True
        Me.cmdAltLc.Text = "Alterar local . . ."
        '
        'txtDwnLc
        '
        Me.txtDwnLc.AutoSize = True
        Me.txtDwnLc.Location = New System.Drawing.Point(12, 32)
        Me.txtDwnLc.Name = "txtDwnLc"
        Me.txtDwnLc.Size = New System.Drawing.Size(115, 13)
        Me.txtDwnLc.TabIndex = 8
        Me.txtDwnLc.Text = "Pasta a ser organizada"
        '
        'dlgDwnLc
        '
        Me.dlgDwnLc.Description = "Selecione a pasta que você deseja organizar"
        Me.dlgDwnLc.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.prgAtu, Me.lblPrg})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 343)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(628, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.IsLink = True
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(37, 17)
        Me.ToolStripStatusLabel1.Text = "Sobre"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.IsLink = True
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(53, 17)
        Me.ToolStripStatusLabel2.Text = "Atualizar"
        '
        'prgAtu
        '
        Me.prgAtu.Name = "prgAtu"
        Me.prgAtu.Size = New System.Drawing.Size(100, 16)
        '
        'lblPrg
        '
        Me.lblPrg.Name = "lblPrg"
        Me.lblPrg.Size = New System.Drawing.Size(0, 17)
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(628, 365)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.txtDwnLc)
        Me.Controls.Add(Me.cmdAltLc)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.lstClas)
        Me.Controls.Add(Me.cmdOrg)
        Me.Controls.Add(Me.lblDwnLc)
        Me.Controls.Add(Me.txtSt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Folder Manager"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSt As System.Windows.Forms.RichTextBox
    Friend WithEvents lblDwnLc As System.Windows.Forms.Label
    Friend WithEvents cmdOrg As System.Windows.Forms.Button
    Friend WithEvents lstClas As System.Windows.Forms.ListView
    Friend WithEvents clmTp As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmPst As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents cmdAltLc As System.Windows.Forms.LinkLabel
    Friend WithEvents txtDwnLc As System.Windows.Forms.Label
    Friend WithEvents dlgDwnLc As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents prgAtu As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents lblPrg As System.Windows.Forms.ToolStripStatusLabel

End Class
