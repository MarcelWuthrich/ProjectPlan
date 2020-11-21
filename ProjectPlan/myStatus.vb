'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class myStatus


    Private _ID_Status As Integer
    Private _Status As String
    Private _Enable As Boolean


    Public Property Enable As Boolean
        Get
            Return _Enable
        End Get
        Set(value As Boolean)
            _Enable = value
        End Set
    End Property

    Public Property ID_Status As Integer
        Get
            Return _ID_Status
        End Get
        Set(ByVal value As Integer)
            _ID_Status = value
        End Set
    End Property

    Public Property Status As String
        Get
            Return _Status
        End Get

        Set(ByVal value As String)
            _Status = value
        End Set
    End Property


    Public Function Read() As myStatus

        'Recherche les données d'un statut en fonction de son ID_Status


        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Status, Status, Enable from Status where ID_Status =" & Me.ID_Status

            MyDBConnection.ConnectionString = cnProjectPlan



            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre
                Try
                    Me.ID_Status = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                'Lecture du 2e paramètre
                Try
                    Me.Status = myDBDataReader.GetString(1)
                Catch ex As Exception
                End Try

                'Lecture du 3e paramètre
                Try
                    Me.Enable = myDBDataReader.GetValue(2)
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()


        Catch ex As Exception

            Debug.WriteLine(ex.ToString)

        End Try

        Return Me


    End Function

    Public Function Find_ID_From_Status() As myStatus

        'Recherche les données d'un statut en fonction de son status


        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Status from Status where CONVERT(VARCHAR, Status) = '" & Me.Status & "';"

            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre
                Try
                    Me.ID_Status = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try


            End While

            myDBDataReader.Close()
            MyDBConnection.Close()


        Catch ex As Exception

            Debug.WriteLine(ex.ToString)

        End Try

        Return Me


    End Function

End Class
