Public Class Kujundid

    Private Sub tootleKujund(kujund As Kujund)
        lblTyyp.Text = kujund.annaTyyp

        txtPindala.Text = kujund.leiaPindala
        txtYmbermoot.Text = kujund.leiaYmberMoot
    End Sub

    Private Sub btnKolmnurk_Click(sender As Object, e As EventArgs) Handles btnKolmnurk.Click
        'System.InvalidCastException' 
        Dim objectKolmnurk As New Kolmnurk(0, 0, 0)
        Try
            objectKolmnurk = New Kolmnurk(txtKylgA.Text, txtKylgB.Text, ComboBox1.SelectedIndex)
        Catch ex As Exception
            MsgBox("Some of the values are invalid")
        End Try

        tootleKujund(objectKolmnurk)
    End Sub

    Private Sub btnRuut_Click(sender As Object, e As EventArgs) Handles btnRuut.Click
        Dim objektRuut As New Ruut(0, 0)
        Try
            objektRuut = New Ruut(txtKylgA.Text, ComboBox1.SelectedIndex)
        Catch ex As Exception
            MsgBox("Some of the values are invalid")
        End Try
        tootleKujund(objektRuut)
    End Sub

    Private Sub btnRistkulik_Click(sender As Object, e As EventArgs) Handles btnRistkulik.Click
        Try
            tootleKujund(New Ristkylik(txtKylgA.Text, txtKylgB.Text, ComboBox1.SelectedIndex))
        Catch ex As Exception
            MsgBox("Some of the values are invalid")
        End Try
    End Sub

    Private Sub Kujundid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        txtYmbermoot.ReadOnly = True
        txtPindala.ReadOnly = True
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("0")
        ComboBox1.Items.Add("1")
        ComboBox1.Items.Add("2")
        ComboBox1.Items.Add("3")
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub btnRoopkulik_Click(sender As Object, e As EventArgs) Handles btnRoopkulik.Click
        Try
            tootleKujund(New Roopkulik(txtKylgA.Text, txtKylgB.Text, txtKorgus.Text, ComboBox1.SelectedIndex))
        Catch ex As Exception
            MsgBox("Some of the values are invalid")
        End Try
    End Sub

    Private Sub btnRomb_Click(sender As Object, e As EventArgs) Handles btnRomb.Click
        Try
            tootleKujund(New Romb(txtKylgA.Text, txtKorgus.Text, ComboBox1.SelectedIndex))
        Catch ex As Exception
            MsgBox("Some of the values are invalid")
        End Try
    End Sub

    Private Sub txtYmbermoot_TextChanged(sender As Object, e As EventArgs) Handles txtYmbermoot.TextChanged

    End Sub
End Class
