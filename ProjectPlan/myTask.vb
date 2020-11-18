'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class myTask


    Private _ID_Task As Integer
    Private _Task As String
    Private _Enable As Boolean


    Public Property Enable As Boolean
        Get
            Return _Enable
        End Get
        Set(value As Boolean)
            _Enable = value
        End Set
    End Property

    Public Property ID_Task As Integer
        Get
            Return _ID_Task
        End Get
        Set(ByVal value As Integer)
            _ID_Task = value
        End Set
    End Property

    Public Property Task As String
        Get
            Return _Task
        End Get

        Set(ByVal value As String)
            _Task = value
        End Set
    End Property


    Public Function Read() As myTask

        'Recherche les données d'une tâche en fonction de son ID_Task

        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Task, Task, Enable from Tasks where ID_Task =" & Me.ID_Task

            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre
                Try
                    Me.ID_Task = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                'Lecture du 2e paramètre
                Try
                    Me.Task = myDBDataReader.GetString(1)
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

    Public Function Find_ID_From_Task() As myTask

        'Recherche les données d'un statut en fonction de son Task


        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Task from Task where CONVERT(VARCHAR, Task) = '" & Me.Task & "';"

            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre
                Try
                    Me.ID_Task = myDBDataReader.GetValue(0)
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
