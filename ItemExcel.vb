Public Class ItemExcel
    Private FechaDesde As String
    Private FechaHasta As String
    Private TipoHabitacion As String
    Private TarifaSingle As String
    Private TarifaDoble As String
    Private TarifaTriple As String
    Private TarifaFamily As String
    Private TarifaSuite As String

    Sub New(ByVal FechaDesde As String, ByVal FechaHasta As String, ByVal TipoHabitacion As String, ByVal TarifaSingle As String, ByVal TarifaDoble As String, ByVal TarifaTriple As String, ByVal TarifaFamily As String, ByVal TarifaSuite As String)
        Me.FechaDesde = FechaDesde
        Me.FechaHasta = FechaHasta
        Me.TipoHabitacion = TipoHabitacion
        Me.TarifaSingle = TarifaSingle
        Me.TarifaDoble = TarifaDoble
        Me.TarifaTriple = TarifaTriple
        Me.TarifaFamily = TarifaFamily
        Me.TarifaSuite = TarifaSuite
    End Sub
    Sub New()

    End Sub

    Public Function GetFechaDesde() As String
        Return Me.FechaDesde
    End Function

    Public Function GetFechaHasta() As String
        Return Me.FechaHasta
    End Function

    Public Function GetTipoHabitacion() As String
        Return Me.TipoHabitacion
    End Function

    Public Function GetTarifaSingle() As String
        Return Me.TarifaSingle
    End Function

    Public Function GetTarifaDoble() As String
        Return Me.TarifaDoble
    End Function

    Public Function GetTarifaTriple() As String
        Return Me.TarifaTriple
    End Function

    Public Function GetTarifaFamily() As String
        Return Me.TarifaFamily
    End Function

    Public Function GetTarifaSuite() As String
        Return Me.TarifaSuite
    End Function

End Class