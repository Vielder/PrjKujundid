Imports System.Math
Public Class Nelinurk
    Inherits Kujund

    Private kylgD As Double

    Public Sub New(tyyp As String, kylgA As Double, kylgB As Double, kylgC As Double, kylgD As Double, accur As Integer)
        MyBase.New(tyyp, kylgA, kylgB, kylgC, accur)

        Me.kylgD = kylgD
    End Sub

    Public Overrides Function leiaPindala() As Double
        Return 0
    End Function

    Public Overrides Function leiaYmberMoot() As Double
        Return kylgA + kylgB + kylgC + kylgD
    End Function
End Class
