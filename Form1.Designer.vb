<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnOpenFile = New Button()
        btnSearch = New Button()
        txtContent = New TextBox()
        txtSearch = New TextBox()
        lstResults = New ListBox()
        SuspendLayout()
        ' 
        ' btnOpenFile
        ' 
        btnOpenFile.Location = New Point(12, 9)
        btnOpenFile.Name = "btnOpenFile"
        btnOpenFile.Size = New Size(94, 29)
        btnOpenFile.TabIndex = 0
        btnOpenFile.Text = "Buka File"
        btnOpenFile.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(152, 9)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(94, 29)
        btnSearch.TabIndex = 1
        btnSearch.Text = "Cari"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtContent
        ' 
        txtContent.Location = New Point(12, 44)
        txtContent.Multiline = True
        txtContent.Name = "txtContent"
        txtContent.ScrollBars = ScrollBars.Vertical
        txtContent.Size = New Size(400, 200)
        txtContent.TabIndex = 2
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(287, 12)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(125, 27)
        txtSearch.TabIndex = 3
        ' 
        ' lstResults
        ' 
        lstResults.FormattingEnabled = True
        lstResults.Location = New Point(12, 257)
        lstResults.Name = "lstResults"
        lstResults.Size = New Size(400, 84)
        lstResults.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(582, 353)
        Controls.Add(lstResults)
        Controls.Add(txtSearch)
        Controls.Add(txtContent)
        Controls.Add(btnSearch)
        Controls.Add(btnOpenFile)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnOpenFile As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtContent As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lstResults As ListBox

End Class
