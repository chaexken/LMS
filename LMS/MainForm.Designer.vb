<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddGroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IssueBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllRentedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CustomerToolStripMenuItem, Me.ViewToolStripMenuItem, Me.WindowsToolStripMenuItem, Me.SettingToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1024, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddBooksToolStripMenuItem, Me.AddGroupToolStripMenuItem, Me.IssueBookToolStripMenuItem, Me.ReturnBookToolStripMenuItem, Me.BookReportToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.FileToolStripMenuItem.Text = "Library"
        '
        'AddBooksToolStripMenuItem
        '
        Me.AddBooksToolStripMenuItem.Name = "AddBooksToolStripMenuItem"
        Me.AddBooksToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddBooksToolStripMenuItem.Text = "&Add Books"
        '
        'AddGroupToolStripMenuItem
        '
        Me.AddGroupToolStripMenuItem.Name = "AddGroupToolStripMenuItem"
        Me.AddGroupToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AddGroupToolStripMenuItem.Text = "Add &Group"
        '
        'IssueBookToolStripMenuItem
        '
        Me.IssueBookToolStripMenuItem.Name = "IssueBookToolStripMenuItem"
        Me.IssueBookToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.IssueBookToolStripMenuItem.Text = "&Issue Book"
        '
        'ReturnBookToolStripMenuItem
        '
        Me.ReturnBookToolStripMenuItem.Name = "ReturnBookToolStripMenuItem"
        Me.ReturnBookToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReturnBookToolStripMenuItem.Text = "&Return Book"
        '
        'BookReportToolStripMenuItem
        '
        Me.BookReportToolStripMenuItem.Name = "BookReportToolStripMenuItem"
        Me.BookReportToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BookReportToolStripMenuItem.Text = "&Book Report"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 659)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1024, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'BackgroundToolStripMenuItem
        '
        Me.BackgroundToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PictureToolStripMenuItem})
        Me.BackgroundToolStripMenuItem.Name = "BackgroundToolStripMenuItem"
        Me.BackgroundToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BackgroundToolStripMenuItem.Text = "Background"
        '
        'PictureToolStripMenuItem
        '
        Me.PictureToolStripMenuItem.Checked = True
        Me.PictureToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PictureToolStripMenuItem.Name = "PictureToolStripMenuItem"
        Me.PictureToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.PictureToolStripMenuItem.Text = "Picture"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackgroundToolStripMenuItem})
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SettingToolStripMenuItem.Text = "&Setting"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CloseAllToolStripMenuItem.Text = "Close A&ll"
        '
        'WindowsToolStripMenuItem
        '
        Me.WindowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseAllToolStripMenuItem})
        Me.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        Me.WindowsToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.WindowsToolStripMenuItem.Text = "&Windows"
        '
        'AllRentedToolStripMenuItem
        '
        Me.AllRentedToolStripMenuItem.Name = "AllRentedToolStripMenuItem"
        Me.AllRentedToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AllRentedToolStripMenuItem.Text = "All Rented"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AllRentedToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'AddCustomerToolStripMenuItem
        '
        Me.AddCustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.AddCustomerToolStripMenuItem.Name = "AddCustomerToolStripMenuItem"
        Me.AddCustomerToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.AddCustomerToolStripMenuItem.Text = "A&dd/Delete/Update Customer"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.ToolStripMenuItem1.Text = "ToolStripMenuItem1"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(182, 22)
        Me.ToolStripMenuItem2.Text = "ToolStripMenuItem2"
        '
        'ViewCustomerToolStripMenuItem
        '
        Me.ViewCustomerToolStripMenuItem.Name = "ViewCustomerToolStripMenuItem"
        Me.ViewCustomerToolStripMenuItem.Size = New System.Drawing.Size(232, 22)
        Me.ViewCustomerToolStripMenuItem.Text = "&View Customer"
        '
        'CustomerToolStripMenuItem
        '
        Me.CustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCustomerToolStripMenuItem, Me.ViewCustomerToolStripMenuItem})
        Me.CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        Me.CustomerToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.CustomerToolStripMenuItem.Text = "&Customer"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 681)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LRC BIBLIOGRAPHIC ACCESS CATALOG"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IssueBookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnBookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BookReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddGroupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ViewCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllRentedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WindowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
End Class
