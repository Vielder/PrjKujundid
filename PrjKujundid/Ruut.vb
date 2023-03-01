Public Class Ruut
    Inherits Nelinurk

    Public Sub New(kylg As Double, accur As Integer)
        MyBase.New("Ruut", kylg, kylg, kylg, kylg, accur)
    End Sub

    Public Overrides Function leiaPindala() As Double
        Return kylgA * kylgB
    End Function



End Class
