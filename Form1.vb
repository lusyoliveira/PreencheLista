Public Class Form1
    Dim x, y As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregar.Click
        lstExemplo.Items.Clear()
        y = 0
        For x = 1 To 10
            lstExemplo.Items.Add(x)
            lstExemplo.Items(y).SubItems.Add("Marcos" & x)
            If y Mod 2 = 0 Then
                lstExemplo.Items(y).ForeColor = Color.Blue
                lstExemplo.Items(y).BackColor = Color.LightGray
            Else
                lstExemplo.Items(y).ForeColor = Color.Red
                lstExemplo.Items(y).BackColor = Color.White
            End If
            y += 1


        Next
    End Sub

    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        For x = 0 To lstExemplo.Items.Count - 1
            lstExemplo.Items(x).Checked = chkTodos.Checked
        Next
    End Sub

    Private Sub btnEncaminhar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncaminhar.Click
        lstDesmarcados.Items.Clear()
        lstMarcados.Items.Clear()
        For x = 0 To lstExemplo.Items.Count - 1
            If lstExemplo.Items(x).Checked = True Then
                lstMarcados.Items.Add(lstExemplo.Items(x).SubItems(1).Text)
            Else
                lstDesmarcados.Items.Add(lstExemplo.Items(x).SubItems(1).Text)
            End If
        Next
    End Sub
End Class
