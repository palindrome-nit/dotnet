Module ModConnection

    Public cn As New ADODB.Connection()

    Public Sub Connect()
        cn.Open("Provider=OraOLEDB.ORACLE;User Id=lp;PAssword=lp;Data Source=orcl")
    End Sub

End Module
