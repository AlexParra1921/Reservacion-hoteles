Public Class Cancelacion
    Public Sub New(getSetIdreservacion As Integer, getSetRembolso As Integer, getSetFecha As String)
        Me.getSetIdreservacion = getSetIdreservacion
        Me.getSetRembolso = getSetRembolso
        Me.getSetFecha = getSetFecha
    End Sub

    Public Sub New(getSetIdcancelacion As Integer, getSetIdreservacion As Integer, getSetRembolso As Integer, getSetFecha As String)
        Me.getSetIdcancelacion = getSetIdcancelacion
        Me.getSetIdreservacion = getSetIdreservacion
        Me.getSetRembolso = getSetRembolso
        Me.getSetFecha = getSetFecha
    End Sub

    Public Property getSetIdcancelacion As Integer
    Public Property getSetIdreservacion As Integer
    Public Property getSetRembolso As Integer
    Public Property getSetFecha As String
End Class
