Public Class DeepResponse
    Public translations As List(Of DeepTranslation)
End Class

Public Class DeepTranslation
    Public detected_source_language As String
    Public text As String
End Class