Public Class Form1


    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim strIncome As String
        Dim decIncome As Decimal
        Dim decFica As Decimal
        Dim decFederal As Decimal
        Dim decState As Decimal
        Dim decNet As Decimal
        Const cdecFica = 0.0765D
        Const cdecFederal = 0.22D
        Const cdecState = 0.04D

        strIncome = txtInput.Text
        decIncome = Convert.ToDecimal(strIncome)
        decFica = cdecFica * decIncome
        lblFicaNum.Text = decFica.ToString("C")
        decState = cdecState * decIncome
        lblStateTaxNum.Text = decState.ToString("C")
        decFederal = cdecFederal * decIncome
        lblFedTaxNum.Text = decFederal.ToString("C")
        decNet = decIncome - decFica - decState - decFederal
        lblNetPayNum.Text = decNet.ToString("C")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblFicaNum.Text = ""
        lblNetPayNum.Text = "$"
        lblFedTaxNum.Text = ""
        lblStateTaxNum.Text = ""
        txtInput.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
