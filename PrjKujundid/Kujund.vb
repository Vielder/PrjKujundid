Public MustInherit Class Kujund
    Private tyyp As String
    Protected kylgA As Double
    Protected kylgB As Double
    Protected kylgC As Double
    Protected accur As Integer

    Public Sub New(tyyp As String, kylgA As Double, kylgB As Double, kylgC As Double, accur As Integer)
        Me.tyyp = tyyp
        Me.kylgA = kylgA
        Me.kylgB = kylgB
        Me.kylgC = kylgC
        Me.accur = accur
    End Sub

    Public Function annaTyyp() As String
        Return tyyp
    End Function

    Public MustOverride Function leiaYmberMoot() As Double

    Public MustOverride Function leiaPindala() As Double

End Class
