


'Tsagan Garyaeva
'Comp-185
'Lab 10 LookUp
Public Class Form1


    Dim strProgrammers() As String = {"Linus Torvalds", "James Gosling", "Dennis Ritchie", "Tim Berners-Lee", "Ken Thompson", "Donald Knuth", "Bill Gates"}
    Dim strPhones() As String = {"732-234-7676", "989-000-0998", "765-989-0986", "732-234-7676", "489-345-0998", "765-123-0986", "767-987-9876"}
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim strName As String = CStr(txtSearch.Text)
        Dim intIndex As Integer
        Dim strInfo As String
        lstBox.Items.Clear()
        strName = strName.ToLower()

        For intIndex = 0 To strProgrammers.Length - 1
            strInfo = strProgrammers(intIndex)
            strInfo = strInfo.ToLower()
            If strInfo.IndexOf(strName) <> -1 Then
                lstBox.Items.Add(strProgrammers(intIndex) & "  " & strPhones(intIndex))

            End If
        Next
        If lstBox.Items.Count = 0 Then
            lblResult.Text = "No entries found"
        End If

    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearch.Clear()
        lblResult.Text = " "
        lstBox.Items.Clear()
    End Sub
End Class
