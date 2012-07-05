Public Class frmMain
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents ofDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents lblFileName As System.Windows.Forms.Label
    Friend WithEvents cmdSplit As System.Windows.Forms.Button
    Friend WithEvents pbProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents tmrTimer As System.Windows.Forms.Timer
    Friend WithEvents tmrCheck As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
        Me.ofDialog = New System.Windows.Forms.OpenFileDialog
        Me.txtFileName = New System.Windows.Forms.TextBox
        Me.cmdBrowse = New System.Windows.Forms.Button
        Me.lblFileName = New System.Windows.Forms.Label
        Me.cmdSplit = New System.Windows.Forms.Button
        Me.pbProgress = New System.Windows.Forms.ProgressBar
        Me.tmrTimer = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCheck = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ofDialog
        '
        Me.ofDialog.Filter = resources.GetString("ofDialog.Filter")
        Me.ofDialog.Title = resources.GetString("ofDialog.Title")
        '
        'txtFileName
        '
        Me.txtFileName.AccessibleDescription = resources.GetString("txtFileName.AccessibleDescription")
        Me.txtFileName.AccessibleName = resources.GetString("txtFileName.AccessibleName")
        Me.txtFileName.Anchor = CType(resources.GetObject("txtFileName.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.txtFileName.AutoSize = CType(resources.GetObject("txtFileName.AutoSize"), Boolean)
        Me.txtFileName.BackgroundImage = CType(resources.GetObject("txtFileName.BackgroundImage"), System.Drawing.Image)
        Me.txtFileName.Dock = CType(resources.GetObject("txtFileName.Dock"), System.Windows.Forms.DockStyle)
        Me.txtFileName.Enabled = CType(resources.GetObject("txtFileName.Enabled"), Boolean)
        Me.txtFileName.Font = CType(resources.GetObject("txtFileName.Font"), System.Drawing.Font)
        Me.txtFileName.ImeMode = CType(resources.GetObject("txtFileName.ImeMode"), System.Windows.Forms.ImeMode)
        Me.txtFileName.Location = CType(resources.GetObject("txtFileName.Location"), System.Drawing.Point)
        Me.txtFileName.MaxLength = CType(resources.GetObject("txtFileName.MaxLength"), Integer)
        Me.txtFileName.Multiline = CType(resources.GetObject("txtFileName.Multiline"), Boolean)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.PasswordChar = CType(resources.GetObject("txtFileName.PasswordChar"), Char)
        Me.txtFileName.RightToLeft = CType(resources.GetObject("txtFileName.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.txtFileName.ScrollBars = CType(resources.GetObject("txtFileName.ScrollBars"), System.Windows.Forms.ScrollBars)
        Me.txtFileName.Size = CType(resources.GetObject("txtFileName.Size"), System.Drawing.Size)
        Me.txtFileName.TabIndex = CType(resources.GetObject("txtFileName.TabIndex"), Integer)
        Me.txtFileName.Text = resources.GetString("txtFileName.Text")
        Me.txtFileName.TextAlign = CType(resources.GetObject("txtFileName.TextAlign"), System.Windows.Forms.HorizontalAlignment)
        Me.txtFileName.Visible = CType(resources.GetObject("txtFileName.Visible"), Boolean)
        Me.txtFileName.WordWrap = CType(resources.GetObject("txtFileName.WordWrap"), Boolean)
        '
        'cmdBrowse
        '
        Me.cmdBrowse.AccessibleDescription = resources.GetString("cmdBrowse.AccessibleDescription")
        Me.cmdBrowse.AccessibleName = resources.GetString("cmdBrowse.AccessibleName")
        Me.cmdBrowse.Anchor = CType(resources.GetObject("cmdBrowse.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cmdBrowse.BackgroundImage = CType(resources.GetObject("cmdBrowse.BackgroundImage"), System.Drawing.Image)
        Me.cmdBrowse.Dock = CType(resources.GetObject("cmdBrowse.Dock"), System.Windows.Forms.DockStyle)
        Me.cmdBrowse.Enabled = CType(resources.GetObject("cmdBrowse.Enabled"), Boolean)
        Me.cmdBrowse.FlatStyle = CType(resources.GetObject("cmdBrowse.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.cmdBrowse.Font = CType(resources.GetObject("cmdBrowse.Font"), System.Drawing.Font)
        Me.cmdBrowse.Image = CType(resources.GetObject("cmdBrowse.Image"), System.Drawing.Image)
        Me.cmdBrowse.ImageAlign = CType(resources.GetObject("cmdBrowse.ImageAlign"), System.Drawing.ContentAlignment)
        Me.cmdBrowse.ImageIndex = CType(resources.GetObject("cmdBrowse.ImageIndex"), Integer)
        Me.cmdBrowse.ImeMode = CType(resources.GetObject("cmdBrowse.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cmdBrowse.Location = CType(resources.GetObject("cmdBrowse.Location"), System.Drawing.Point)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.RightToLeft = CType(resources.GetObject("cmdBrowse.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cmdBrowse.Size = CType(resources.GetObject("cmdBrowse.Size"), System.Drawing.Size)
        Me.cmdBrowse.TabIndex = CType(resources.GetObject("cmdBrowse.TabIndex"), Integer)
        Me.cmdBrowse.Text = resources.GetString("cmdBrowse.Text")
        Me.cmdBrowse.TextAlign = CType(resources.GetObject("cmdBrowse.TextAlign"), System.Drawing.ContentAlignment)
        Me.cmdBrowse.Visible = CType(resources.GetObject("cmdBrowse.Visible"), Boolean)
        '
        'lblFileName
        '
        Me.lblFileName.AccessibleDescription = resources.GetString("lblFileName.AccessibleDescription")
        Me.lblFileName.AccessibleName = resources.GetString("lblFileName.AccessibleName")
        Me.lblFileName.Anchor = CType(resources.GetObject("lblFileName.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.lblFileName.AutoSize = CType(resources.GetObject("lblFileName.AutoSize"), Boolean)
        Me.lblFileName.Dock = CType(resources.GetObject("lblFileName.Dock"), System.Windows.Forms.DockStyle)
        Me.lblFileName.Enabled = CType(resources.GetObject("lblFileName.Enabled"), Boolean)
        Me.lblFileName.Font = CType(resources.GetObject("lblFileName.Font"), System.Drawing.Font)
        Me.lblFileName.Image = CType(resources.GetObject("lblFileName.Image"), System.Drawing.Image)
        Me.lblFileName.ImageAlign = CType(resources.GetObject("lblFileName.ImageAlign"), System.Drawing.ContentAlignment)
        Me.lblFileName.ImageIndex = CType(resources.GetObject("lblFileName.ImageIndex"), Integer)
        Me.lblFileName.ImeMode = CType(resources.GetObject("lblFileName.ImeMode"), System.Windows.Forms.ImeMode)
        Me.lblFileName.Location = CType(resources.GetObject("lblFileName.Location"), System.Drawing.Point)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.RightToLeft = CType(resources.GetObject("lblFileName.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.lblFileName.Size = CType(resources.GetObject("lblFileName.Size"), System.Drawing.Size)
        Me.lblFileName.TabIndex = CType(resources.GetObject("lblFileName.TabIndex"), Integer)
        Me.lblFileName.Text = resources.GetString("lblFileName.Text")
        Me.lblFileName.TextAlign = CType(resources.GetObject("lblFileName.TextAlign"), System.Drawing.ContentAlignment)
        Me.lblFileName.Visible = CType(resources.GetObject("lblFileName.Visible"), Boolean)
        '
        'cmdSplit
        '
        Me.cmdSplit.AccessibleDescription = resources.GetString("cmdSplit.AccessibleDescription")
        Me.cmdSplit.AccessibleName = resources.GetString("cmdSplit.AccessibleName")
        Me.cmdSplit.Anchor = CType(resources.GetObject("cmdSplit.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.cmdSplit.BackgroundImage = CType(resources.GetObject("cmdSplit.BackgroundImage"), System.Drawing.Image)
        Me.cmdSplit.Dock = CType(resources.GetObject("cmdSplit.Dock"), System.Windows.Forms.DockStyle)
        Me.cmdSplit.Enabled = CType(resources.GetObject("cmdSplit.Enabled"), Boolean)
        Me.cmdSplit.FlatStyle = CType(resources.GetObject("cmdSplit.FlatStyle"), System.Windows.Forms.FlatStyle)
        Me.cmdSplit.Font = CType(resources.GetObject("cmdSplit.Font"), System.Drawing.Font)
        Me.cmdSplit.Image = CType(resources.GetObject("cmdSplit.Image"), System.Drawing.Image)
        Me.cmdSplit.ImageAlign = CType(resources.GetObject("cmdSplit.ImageAlign"), System.Drawing.ContentAlignment)
        Me.cmdSplit.ImageIndex = CType(resources.GetObject("cmdSplit.ImageIndex"), Integer)
        Me.cmdSplit.ImeMode = CType(resources.GetObject("cmdSplit.ImeMode"), System.Windows.Forms.ImeMode)
        Me.cmdSplit.Location = CType(resources.GetObject("cmdSplit.Location"), System.Drawing.Point)
        Me.cmdSplit.Name = "cmdSplit"
        Me.cmdSplit.RightToLeft = CType(resources.GetObject("cmdSplit.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.cmdSplit.Size = CType(resources.GetObject("cmdSplit.Size"), System.Drawing.Size)
        Me.cmdSplit.TabIndex = CType(resources.GetObject("cmdSplit.TabIndex"), Integer)
        Me.cmdSplit.Text = resources.GetString("cmdSplit.Text")
        Me.cmdSplit.TextAlign = CType(resources.GetObject("cmdSplit.TextAlign"), System.Drawing.ContentAlignment)
        Me.cmdSplit.Visible = CType(resources.GetObject("cmdSplit.Visible"), Boolean)
        '
        'pbProgress
        '
        Me.pbProgress.AccessibleDescription = resources.GetString("pbProgress.AccessibleDescription")
        Me.pbProgress.AccessibleName = resources.GetString("pbProgress.AccessibleName")
        Me.pbProgress.Anchor = CType(resources.GetObject("pbProgress.Anchor"), System.Windows.Forms.AnchorStyles)
        Me.pbProgress.BackgroundImage = CType(resources.GetObject("pbProgress.BackgroundImage"), System.Drawing.Image)
        Me.pbProgress.Dock = CType(resources.GetObject("pbProgress.Dock"), System.Windows.Forms.DockStyle)
        Me.pbProgress.Enabled = CType(resources.GetObject("pbProgress.Enabled"), Boolean)
        Me.pbProgress.Font = CType(resources.GetObject("pbProgress.Font"), System.Drawing.Font)
        Me.pbProgress.ImeMode = CType(resources.GetObject("pbProgress.ImeMode"), System.Windows.Forms.ImeMode)
        Me.pbProgress.Location = CType(resources.GetObject("pbProgress.Location"), System.Drawing.Point)
        Me.pbProgress.Name = "pbProgress"
        Me.pbProgress.RightToLeft = CType(resources.GetObject("pbProgress.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.pbProgress.Size = CType(resources.GetObject("pbProgress.Size"), System.Drawing.Size)
        Me.pbProgress.TabIndex = CType(resources.GetObject("pbProgress.TabIndex"), Integer)
        Me.pbProgress.Text = resources.GetString("pbProgress.Text")
        Me.pbProgress.Visible = CType(resources.GetObject("pbProgress.Visible"), Boolean)
        '
        'tmrTimer
        '
        Me.tmrTimer.Interval = 20
        '
        'tmrCheck
        '
        Me.tmrCheck.Enabled = True
        '
        'frmMain
        '
        Me.AccessibleDescription = resources.GetString("$this.AccessibleDescription")
        Me.AccessibleName = resources.GetString("$this.AccessibleName")
        Me.AutoScaleBaseSize = CType(resources.GetObject("$this.AutoScaleBaseSize"), System.Drawing.Size)
        Me.AutoScroll = CType(resources.GetObject("$this.AutoScroll"), Boolean)
        Me.AutoScrollMargin = CType(resources.GetObject("$this.AutoScrollMargin"), System.Drawing.Size)
        Me.AutoScrollMinSize = CType(resources.GetObject("$this.AutoScrollMinSize"), System.Drawing.Size)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = CType(resources.GetObject("$this.ClientSize"), System.Drawing.Size)
        Me.Controls.Add(Me.pbProgress)
        Me.Controls.Add(Me.cmdSplit)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.txtFileName)
        Me.Enabled = CType(resources.GetObject("$this.Enabled"), Boolean)
        Me.Font = CType(resources.GetObject("$this.Font"), System.Drawing.Font)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = CType(resources.GetObject("$this.ImeMode"), System.Windows.Forms.ImeMode)
        Me.Location = CType(resources.GetObject("$this.Location"), System.Drawing.Point)
        Me.MaximizeBox = False
        Me.MaximumSize = CType(resources.GetObject("$this.MaximumSize"), System.Drawing.Size)
        Me.MinimumSize = CType(resources.GetObject("$this.MinimumSize"), System.Drawing.Size)
        Me.Name = "frmMain"
        Me.RightToLeft = CType(resources.GetObject("$this.RightToLeft"), System.Windows.Forms.RightToLeft)
        Me.StartPosition = CType(resources.GetObject("$this.StartPosition"), System.Windows.Forms.FormStartPosition)
        Me.Text = resources.GetString("$this.Text")
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub lblFileName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFileName.Click
        txtFileName.Focus()
    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
        ofDialog.ShowDialog()
    End Sub

    Private Sub ofDialog_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ofDialog.FileOk
        txtFileName.Text = ofDialog.FileName
    End Sub

    Private Sub cmdSplit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSplit.Click
        With Me
            .tmrCheck.Enabled = False
            .txtFileName.Enabled = False
            .cmdBrowse.Enabled = False
            .cmdSplit.Enabled = False
            .lblFileName.Enabled = False
            .tmrTimer.Enabled = True
            Dim I As Integer, mline As String, Fn As Integer
            Dim rFile As New System.IO.StreamReader(.txtFileName.Text)
            Dim wFile As New System.IO.StreamWriter(.txtFileName.Text & "part #1.scd")
            Fn = 1
            Do
                mline = rFile.ReadLine()
                wFile.WriteLine(mline)
                I = I + 1
                If (I > 1000) Then
                    Fn = Fn + 1
                    I = 0
                    wFile.Close()
                    wFile = New System.IO.StreamWriter(txtFileName.Text & "part #" & Fn & ".scd")
                    Application.DoEvents()
                End If

            Loop While (mline <> "")
            wFile.Close()
            rFile.Close()
            .pbProgress.Value = 0
            .tmrTimer.Enabled = False
            .lblFileName.Enabled = True
            .cmdSplit.Enabled = True
            .cmdBrowse.Enabled = True
            .txtFileName.Enabled = True
            .tmrCheck.Enabled = True
        End With
    End Sub

    Private Sub tmrTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrTimer.Tick
        Static Value = 0, Mode = 1
        Value = Value + 1 * Mode
        If Value > 99 Then Mode = -1
        If Value < 1 Then Mode = 1
        Me.pbProgress.Value = Value
    End Sub

    Private Sub txtFileName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFileName.TextChanged
        If Len(Me.txtFileName.Text) < 1 Then Exit Sub
        Dim fInfo As New System.IO.FileInfo(txtFileName.Text)
        Dim b As Boolean
        b = fInfo.Exists()
        If (b <> Me.cmdSplit.Enabled) Then _
            Me.cmdSplit.Enabled = b
    End Sub

    Private Sub frmMain_HelpRequested(ByVal sender As Object, ByVal hlpevent As System.Windows.Forms.HelpEventArgs) Handles MyBase.HelpRequested
        Dim Text As String
        Text = "SkyCD Split 1.0"
        Text &= "--------------------------------" & vbCrLf
        Text &= "Part of SkyCD OpenSource Project" & vbCrLf
        Text &= "Project can be found:" & vbCrLf
        Text &= " http://skycd.sourceforge.net/"
        MsgBox(Text, MsgBoxStyle.Information, "About...")
    End Sub
End Class
