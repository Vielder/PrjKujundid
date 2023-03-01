Public Class Ristkylik
    Inherits Nelinurk

    Public Sub New(ByVal alus As Double, ByVal korgus As Double, accur As Integer)
        MyBase.New("Ristkülik", alus, korgus, alus, korgus, accur)
    End Sub
    Public Overrides Function leiaPindala() As Double
        Return kylgA * kylgB
    End Function
End Class