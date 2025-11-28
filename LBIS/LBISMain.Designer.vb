<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LBISMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ControlPanel = New TableLayoutPanel()
        SearchBtn = New Button()
        RefreshBtn = New Button()
        DeleteBtn = New Button()
        EditBtn = New Button()
        AddBtn = New Button()
        SearchBox = New RichTextBox()
        ViewBooks = New DataGridView()
        ControlPanel.SuspendLayout()
        CType(ViewBooks, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ControlPanel
        ' 
        ControlPanel.BackColor = Color.Black
        ControlPanel.ColumnCount = 6
        ControlPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        ControlPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        ControlPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        ControlPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        ControlPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 37.5F))
        ControlPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.5F))
        ControlPanel.Controls.Add(SearchBtn, 5, 0)
        ControlPanel.Controls.Add(RefreshBtn, 3, 0)
        ControlPanel.Controls.Add(DeleteBtn, 2, 0)
        ControlPanel.Controls.Add(EditBtn, 1, 0)
        ControlPanel.Controls.Add(AddBtn, 0, 0)
        ControlPanel.Controls.Add(SearchBox, 4, 0)
        ControlPanel.Dock = DockStyle.Top
        ControlPanel.Font = New Font("MS Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ControlPanel.ForeColor = Color.White
        ControlPanel.Location = New Point(0, 0)
        ControlPanel.Name = "ControlPanel"
        ControlPanel.RowCount = 1
        ControlPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        ControlPanel.Size = New Size(1262, 50)
        ControlPanel.TabIndex = 0
        ' 
        ' SearchBtn
        ' 
        SearchBtn.BackColor = Color.White
        SearchBtn.Dock = DockStyle.Fill
        SearchBtn.FlatStyle = FlatStyle.Flat
        SearchBtn.Font = New Font("MS Gothic", 18F, FontStyle.Bold)
        SearchBtn.ForeColor = Color.Black
        SearchBtn.Location = New Point(1104, 3)
        SearchBtn.Name = "SearchBtn"
        SearchBtn.Size = New Size(155, 44)
        SearchBtn.TabIndex = 4
        SearchBtn.Text = "SEARCH"
        SearchBtn.UseVisualStyleBackColor = False
        ' 
        ' RefreshBtn
        ' 
        RefreshBtn.BackColor = Color.White
        RefreshBtn.Dock = DockStyle.Fill
        RefreshBtn.FlatStyle = FlatStyle.Flat
        RefreshBtn.Font = New Font("MS Gothic", 18F, FontStyle.Bold)
        RefreshBtn.ForeColor = Color.Black
        RefreshBtn.Location = New Point(474, 3)
        RefreshBtn.Name = "RefreshBtn"
        RefreshBtn.Size = New Size(151, 44)
        RefreshBtn.TabIndex = 3
        RefreshBtn.Text = "REFRESH"
        RefreshBtn.UseVisualStyleBackColor = False
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.BackColor = Color.White
        DeleteBtn.Dock = DockStyle.Fill
        DeleteBtn.FlatStyle = FlatStyle.Flat
        DeleteBtn.Font = New Font("MS Gothic", 18F, FontStyle.Bold)
        DeleteBtn.ForeColor = Color.Black
        DeleteBtn.Location = New Point(317, 3)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(151, 44)
        DeleteBtn.TabIndex = 2
        DeleteBtn.Text = "DELETE"
        DeleteBtn.UseVisualStyleBackColor = False
        ' 
        ' EditBtn
        ' 
        EditBtn.BackColor = Color.White
        EditBtn.Dock = DockStyle.Fill
        EditBtn.FlatStyle = FlatStyle.Flat
        EditBtn.Font = New Font("MS Gothic", 18F, FontStyle.Bold)
        EditBtn.ForeColor = Color.Black
        EditBtn.Location = New Point(160, 3)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(151, 44)
        EditBtn.TabIndex = 1
        EditBtn.Text = "EDIT"
        EditBtn.UseVisualStyleBackColor = False
        ' 
        ' AddBtn
        ' 
        AddBtn.BackColor = Color.White
        AddBtn.Dock = DockStyle.Fill
        AddBtn.FlatStyle = FlatStyle.Flat
        AddBtn.Font = New Font("MS Gothic", 18F, FontStyle.Bold)
        AddBtn.ForeColor = Color.Black
        AddBtn.Location = New Point(3, 3)
        AddBtn.Name = "AddBtn"
        AddBtn.Size = New Size(151, 44)
        AddBtn.TabIndex = 0
        AddBtn.Text = "ADD"
        AddBtn.UseVisualStyleBackColor = False
        ' 
        ' SearchBox
        ' 
        SearchBox.Dock = DockStyle.Fill
        SearchBox.Font = New Font("MS Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SearchBox.Location = New Point(636, 8)
        SearchBox.Margin = New Padding(8)
        SearchBox.Multiline = False
        SearchBox.Name = "SearchBox"
        SearchBox.Size = New Size(457, 34)
        SearchBox.TabIndex = 5
        SearchBox.Text = ""
        ' 
        ' ViewBooks
        ' 
        ViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ViewBooks.Dock = DockStyle.Fill
        ViewBooks.Location = New Point(0, 50)
        ViewBooks.Name = "ViewBooks"
        ViewBooks.RowHeadersWidth = 51
        ViewBooks.Size = New Size(1262, 623)
        ViewBooks.TabIndex = 1
        ' 
        ' LBISMain
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1262, 673)
        Controls.Add(ViewBooks)
        Controls.Add(ControlPanel)
        Font = New Font("MS Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "LBISMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Library Book Inventory System"
        ControlPanel.ResumeLayout(False)
        CType(ViewBooks, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ControlPanel As TableLayoutPanel
    Friend WithEvents AddBtn As Button
    Friend WithEvents RefreshBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents EditBtn As Button
    Friend WithEvents SearchBtn As Button
    Friend WithEvents ViewBooks As DataGridView
    Friend WithEvents SearchBox As RichTextBox

End Class
