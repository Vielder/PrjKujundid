Public Class Kujundid

    Private Sub tootleKujund(kujund As Kujund)
        lblTyyp.Text = kujund.annaTyyp

        txtPindala.Text = kujund.leiaPindala
        txtYmbermoot.Text = kujund.leiaYmberMoot
    End Sub

    Private Sub btnKolmnurk_Click(sender As Object, e As EventArgs) Handles btnKolmnurk.Click
        Dim objectKolmnurk As New Kolmnurk(txtKylgA.Text, txtKylgB.Text, ComboBox1.SelectedIndex)
        tootleKujund(objectKolmnurk)
    End Sub

    Private Sub btnRuut_Click(sender As Object, e As EventArgs) Handles btnRuut.Click
        Dim objektRuut As New Ruut(txtKylgA.Text, ComboBox1.SelectedIndex)
        tootleKujund(objektRuut)
    End Sub

    Private Sub btnRistkulik_Click(sender As Object, e As EventArgs) Handles btnRistkulik.Click
        tootleKujund(New Ristkylik(txtKylgA.Text, txtKylgB.Text, ComboBox1.SelectedIndex))
    End Sub

    Private Sub Kujundid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("0")
        ComboBox1.Items.Add("1")
        ComboBox1.Items.Add("2")
        ComboBox1.Items.Add("3")
        ComboBox1.Text = "Valige tapsus..."
    End Sub

    Private Sub btnRoopkulik_Click(sender As Object, e As EventArgs) Handles btnRoopkulik.Click
        tootleKujund(New Roopkulik(txtKylgA.Text, txtKylgB.Text, txtKorgus.Text, ComboBox1.SelectedIndex))
    End Sub

    Private Sub btnRomb_Click(sender As Object, e As EventArgs) Handles btnRomb.Click
        tootleKujund(New Romb(txtKylgA.Text, txtKorgus.Text, ComboBox1.SelectedIndex))
    End Sub
End Class
