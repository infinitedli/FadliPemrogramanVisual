Imports System.IO

Public Class Form1

    Private fileContent As String = ""

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            fileContent = File.ReadAllText(openFileDialog.FileName)
            txtContent.Text = fileContent
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim searchTerm As String = txtSearch.Text
        lstResults.Items.Clear()

        If fileContent <> "" AndAlso searchTerm <> "" Then
            Dim lines() As String = fileContent.Split(Environment.NewLine)

            For Each line As String In lines
                If line.Contains(searchTerm) Then
                    lstResults.Items.Add(line)
                End If
            Next

            If lstResults.Items.Count = 0 Then
                lstResults.Items.Add("Tidak ditemukan.")
            End If
        Else
            MessageBox.Show("Silakan pilih file dan masukkan kata pencarian.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class
