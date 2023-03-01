Imports System.Math
Public Class Kolmnurk
    Inherits Kujund

    Private korgus As Double

    Public Sub New(alus As Double, haar As Double, accur As Integer)
        MyBase.New("Vordhaarne kolmnurk", alus, haar, haar, accur)

        Me.korgus = Sqrt(haar * haar - (alus * alus / 4))
    End Sub

    Public Overrides Function leiaPindala() As Double
        Return Math.Round(kylgA * korgus / 2, accur)
    End Function

    Public Overrides Function leiaYmberMoot() As Double
        Return kylgA + kylgB + kylgC
    End Function
End Class
