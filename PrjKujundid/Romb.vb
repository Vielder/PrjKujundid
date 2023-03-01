Public Class Romb
    Inherits Nelinurk

    Private korgus As Double

    Public Sub New(kylg As Double, korgus As Double, accur As Integer)
        MyBase.New(kylg, kylg, kylg, kylg, korgus, accur)
        Me.korgus = korgus
    End Sub

    Public Overrides Function leiaYmberMoot() As Double
        Return 4 * kylgA
    End Function

    Public Overrides Function leiaPindala() As Double
        Return kylgA * korgus
    End Function
End Class
