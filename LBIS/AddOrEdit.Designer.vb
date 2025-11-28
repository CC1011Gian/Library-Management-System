<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddOrEdit
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
        HolderPanel = New TableLayoutPanel()
        TitleBox = New RichTextBox()
        AuthorBox = New RichTextBox()
        CategoryBox = New RichTextBox()
        YearBox = New RichTextBox()
        StatusComboBox = New ComboBox()
        SaveBtn = New Button()
        CancelBtn = New Button()
        Titlelbl = New Label()
        Authorlbl = New Label()
        Categorylbl = New Label()
        Yearlbl = New Label()
        Statuslbl = New Label()
        HolderPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' HolderPanel
        ' 
        HolderPanel.BackColor = Color.LightGray
        HolderPanel.ColumnCount = 10
        HolderPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        HolderPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        HolderPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        HolderPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        HolderPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        HolderPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        HolderPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        HolderPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        HolderPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        HolderPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
        HolderPanel.Controls.Add(TitleBox, 1, 1)
        HolderPanel.Controls.Add(AuthorBox, 1, 3)
        HolderPanel.Controls.Add(CategoryBox, 5, 3)
        HolderPanel.Controls.Add(YearBox, 1, 5)
        HolderPanel.Controls.Add(StatusComboBox, 5, 5)
        HolderPanel.Controls.Add(SaveBtn, 1, 7)
        HolderPanel.Controls.Add(CancelBtn, 5, 7)
        HolderPanel.Controls.Add(Titlelbl, 1, 0)
        HolderPanel.Controls.Add(Authorlbl, 1, 2)
        HolderPanel.Controls.Add(Categorylbl, 5, 2)
        HolderPanel.Controls.Add(Yearlbl, 1, 4)
        HolderPanel.Controls.Add(Statuslbl, 5, 4)
        HolderPanel.Dock = DockStyle.Fill
        HolderPanel.Location = New Point(0, 0)
        HolderPanel.Name = "HolderPanel"
        HolderPanel.RowCount = 8
        HolderPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        HolderPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        HolderPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        HolderPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        HolderPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        HolderPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        HolderPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        HolderPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 12.5F))
        HolderPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        HolderPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        HolderPanel.Size = New Size(702, 453)
        HolderPanel.TabIndex = 0
        ' 
        ' TitleBox
        ' 
        TitleBox.Anchor = AnchorStyles.None
        HolderPanel.SetColumnSpan(TitleBox, 8)
        TitleBox.Font = New Font("MS Gothic", 18F)
        TitleBox.Location = New Point(80, 66)
        TitleBox.Margin = New Padding(10)
        TitleBox.Multiline = False
        TitleBox.Name = "TitleBox"
        TitleBox.Size = New Size(540, 35)
        TitleBox.TabIndex = 0
        TitleBox.Text = ""
        ' 
        ' AuthorBox
        ' 
        AuthorBox.Anchor = AnchorStyles.None
        HolderPanel.SetColumnSpan(AuthorBox, 4)
        AuthorBox.Font = New Font("MS Gothic", 18F)
        AuthorBox.Location = New Point(80, 178)
        AuthorBox.Margin = New Padding(10)
        AuthorBox.Multiline = False
        AuthorBox.Name = "AuthorBox"
        AuthorBox.Size = New Size(260, 35)
        AuthorBox.TabIndex = 1
        AuthorBox.Text = ""
        ' 
        ' CategoryBox
        ' 
        CategoryBox.Anchor = AnchorStyles.None
        HolderPanel.SetColumnSpan(CategoryBox, 4)
        CategoryBox.Font = New Font("MS Gothic", 18F)
        CategoryBox.Location = New Point(360, 178)
        CategoryBox.Margin = New Padding(10)
        CategoryBox.Multiline = False
        CategoryBox.Name = "CategoryBox"
        CategoryBox.Size = New Size(260, 35)
        CategoryBox.TabIndex = 2
        CategoryBox.Text = ""
        ' 
        ' YearBox
        ' 
        YearBox.Anchor = AnchorStyles.None
        HolderPanel.SetColumnSpan(YearBox, 4)
        YearBox.Font = New Font("MS Gothic", 18F)
        YearBox.Location = New Point(80, 290)
        YearBox.Margin = New Padding(10)
        YearBox.Multiline = False
        YearBox.Name = "YearBox"
        YearBox.Size = New Size(260, 35)
        YearBox.TabIndex = 3
        YearBox.Text = ""
        ' 
        ' StatusComboBox
        ' 
        StatusComboBox.Anchor = AnchorStyles.None
        HolderPanel.SetColumnSpan(StatusComboBox, 4)
        StatusComboBox.FormattingEnabled = True
        StatusComboBox.Items.AddRange(New Object() {"active", "archived"})
        StatusComboBox.Location = New Point(360, 294)
        StatusComboBox.Name = "StatusComboBox"
        StatusComboBox.Size = New Size(260, 38)
        StatusComboBox.TabIndex = 4
        StatusComboBox.Text = "active"
        ' 
        ' SaveBtn
        ' 
        SaveBtn.BackColor = Color.White
        HolderPanel.SetColumnSpan(SaveBtn, 4)
        SaveBtn.Dock = DockStyle.Fill
        SaveBtn.FlatStyle = FlatStyle.Flat
        SaveBtn.ForeColor = Color.ForestGreen
        SaveBtn.Location = New Point(80, 402)
        SaveBtn.Margin = New Padding(10)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(260, 41)
        SaveBtn.TabIndex = 5
        SaveBtn.Text = "SAVE"
        SaveBtn.UseVisualStyleBackColor = False
        ' 
        ' CancelBtn
        ' 
        CancelBtn.BackColor = Color.White
        HolderPanel.SetColumnSpan(CancelBtn, 4)
        CancelBtn.Dock = DockStyle.Fill
        CancelBtn.FlatStyle = FlatStyle.Flat
        CancelBtn.ForeColor = Color.Red
        CancelBtn.Location = New Point(360, 402)
        CancelBtn.Margin = New Padding(10)
        CancelBtn.Name = "CancelBtn"
        CancelBtn.Size = New Size(260, 41)
        CancelBtn.TabIndex = 6
        CancelBtn.Text = "CANCEL"
        CancelBtn.UseVisualStyleBackColor = False
        ' 
        ' Titlelbl
        ' 
        Titlelbl.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Titlelbl.AutoSize = True
        HolderPanel.SetColumnSpan(Titlelbl, 4)
        Titlelbl.Location = New Point(73, 26)
        Titlelbl.Name = "Titlelbl"
        Titlelbl.Size = New Size(103, 30)
        Titlelbl.TabIndex = 7
        Titlelbl.Text = "Title:"
        ' 
        ' Authorlbl
        ' 
        Authorlbl.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Authorlbl.AutoSize = True
        HolderPanel.SetColumnSpan(Authorlbl, 4)
        Authorlbl.Location = New Point(73, 138)
        Authorlbl.Name = "Authorlbl"
        Authorlbl.Size = New Size(118, 30)
        Authorlbl.TabIndex = 8
        Authorlbl.Text = "Author:"
        ' 
        ' Categorylbl
        ' 
        Categorylbl.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Categorylbl.AutoSize = True
        HolderPanel.SetColumnSpan(Categorylbl, 4)
        Categorylbl.Location = New Point(353, 138)
        Categorylbl.Name = "Categorylbl"
        Categorylbl.Size = New Size(148, 30)
        Categorylbl.TabIndex = 9
        Categorylbl.Text = "Category:"
        ' 
        ' Yearlbl
        ' 
        Yearlbl.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Yearlbl.AutoSize = True
        HolderPanel.SetColumnSpan(Yearlbl, 4)
        Yearlbl.Location = New Point(73, 250)
        Yearlbl.Name = "Yearlbl"
        Yearlbl.Size = New Size(238, 30)
        Yearlbl.TabIndex = 10
        Yearlbl.Text = "Year Published:"
        ' 
        ' Statuslbl
        ' 
        Statuslbl.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Statuslbl.AutoSize = True
        HolderPanel.SetColumnSpan(Statuslbl, 4)
        Statuslbl.Location = New Point(353, 250)
        Statuslbl.Name = "Statuslbl"
        Statuslbl.Size = New Size(103, 30)
        Statuslbl.TabIndex = 11
        Statuslbl.Text = "Status"
        ' 
        ' AddOrEdit
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(702, 453)
        Controls.Add(HolderPanel)
        Font = New Font("MS Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "AddOrEdit"
        StartPosition = FormStartPosition.CenterParent
        Text = "Add or Edit"
        HolderPanel.ResumeLayout(False)
        HolderPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents HolderPanel As TableLayoutPanel
    Friend WithEvents TitleBox As RichTextBox
    Friend WithEvents AuthorBox As RichTextBox
    Friend WithEvents CategoryBox As RichTextBox
    Friend WithEvents YearBox As RichTextBox
    Friend WithEvents StatusComboBox As ComboBox
    Friend WithEvents SaveBtn As Button
    Friend WithEvents CancelBtn As Button
    Friend WithEvents Titlelbl As Label
    Friend WithEvents Authorlbl As Label
    Friend WithEvents Categorylbl As Label
    Friend WithEvents Yearlbl As Label
    Friend WithEvents Statuslbl As Label
End Class
