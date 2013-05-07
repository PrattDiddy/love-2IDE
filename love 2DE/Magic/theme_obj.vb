Public Class theme_obj

#Region "Privates"
    Private _name As String
    Private _back001 As Color
    Private _back002 As Color
    Private _text As Color
    Private _code_back As Color
    Private _code_text As Color
    Private _code_syntax As Color
    Private _code_comment As Color
#End Region

#Region "Public Properties"
    Public Property name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property back001() As Color
        Get
            Return _back001
        End Get
        Set(value As Color)
            _back001 = value
        End Set
    End Property

    Public Property back002() As Color
        Get
            Return _back002
        End Get
        Set(value As Color)
            _back002 = value
        End Set
    End Property

    Public Property text() As Color
        Get
            Return _text
        End Get
        Set(value As Color)
            _text = value
        End Set
    End Property

    Public Property code_back() As Color
        Get
            Return _code_back
        End Get
        Set(value As Color)
            _code_back = value
        End Set
    End Property

    Public Property code_text() As Color
        Get
            Return _code_text
        End Get
        Set(value As Color)
            _code_text = value
        End Set
    End Property

    Public Property code_syntax() As Color
        Get
            Return _code_syntax
        End Get
        Set(value As Color)
            _code_syntax = value
        End Set
    End Property

    Public Property code_comment() As Color
        Get
            Return _code_comment
        End Get
        Set(value As Color)
            _code_comment = value
        End Set
    End Property
#End Region

End Class
