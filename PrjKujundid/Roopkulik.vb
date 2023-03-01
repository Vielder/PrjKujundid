Public Class Roopkulik
    Inherits Nelinurk

    Private korgus As Double

    Public Sub New(alus As Double, kulg As Double, korgus As Double, accur As Integer)
        MyBase.New(alus, kulg, kulg, kulg, korgus, accur)

        Me.korgus = korgus
    End Sub

    Public Overrides Function leiaYmberMoot() As Double
        Return 2 * (kylgA + kylgB)
    End Function

    Public Overrides Function leiaPindala() As Double
        Return kylgA * korgus
    End Function
End Class
