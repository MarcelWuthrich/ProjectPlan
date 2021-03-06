﻿'Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient



Public Class myExecuteResource


    Private _ID_Resource As Integer
    Private _CE_ID_ProjectMember As Integer
    Private _CE_ID_Project As Integer
    Private _CE_ID_AdminResource As Integer
    Private _CE_ID_Task As Integer
    Private _IsAdminResource As Boolean
    Private _IsProjectResource As Boolean
    Private _PlanDate As Date
    Private _HalfDay As Integer
    Private _Timestamp As DateTime
    Private _MinPlanDate As Date
    Private _MaxPlanDate As Date
    Private _ExecutedProjectResourcesPerTaskAndProject As Single



    Public Property ExecutedProjectResourcesPerTaskAndProject As Single
        Get
            Return _ExecutedProjectResourcesPerTaskAndProject
        End Get
        Set(value As Single)
            _ExecutedProjectResourcesPerTaskAndProject = value
        End Set
    End Property




    Public Property CE_ID_Task As Integer
        Get
            Return _CE_ID_Task
        End Get
        Set(ByVal value As Integer)
            _CE_ID_Task = value
        End Set
    End Property



    Public Property IsProjectResource As Boolean
        Get
            Return _IsProjectResource
        End Get
        Set(value As Boolean)
            _IsProjectResource = value
        End Set
    End Property

    Public Property IsAdminResource As Boolean
        Get
            Return _IsAdminResource
        End Get
        Set(value As Boolean)
            _IsAdminResource = value
        End Set
    End Property

    Public Property MaxPlanDate As Date
        Get
            Return _MaxPlanDate
        End Get
        Set(value As Date)
            _MaxPlanDate = value
        End Set
    End Property
    Public Property MinPlanDate As Date
        Get
            Return _MinPlanDate
        End Get
        Set(value As Date)
            _MinPlanDate = value
        End Set
    End Property

    Public Property HalfDay As Integer
        Get
            Return _HalfDay
        End Get
        Set(value As Integer)
            _HalfDay = value
        End Set
    End Property

    Public Property Timestamp As DateTime
        Get
            Return _Timestamp
        End Get
        Set(value As DateTime)
            _Timestamp = value
        End Set
    End Property

    Public Property PlanDate As Date
        Get
            Return _PlanDate
        End Get
        Set(value As Date)
            _PlanDate = value
        End Set
    End Property

    Public Property ID_Resource As Integer
        Get
            Return _ID_Resource
        End Get
        Set(value As Integer)
            _ID_Resource = value
        End Set
    End Property

    Public Property CE_ID_ProjectMember As Integer
        Get
            Return _CE_ID_ProjectMember
        End Get
        Set(value As Integer)
            _CE_ID_ProjectMember = value
        End Set
    End Property

    Public Property CE_ID_Project As Integer
        Get
            Return _CE_ID_Project
        End Get
        Set(value As Integer)
            _CE_ID_Project = value
        End Set
    End Property

    Public Property CE_ID_AdminResource As Integer
        Get
            Return _CE_ID_AdminResource
        End Get
        Set(value As Integer)
            _CE_ID_AdminResource = value
        End Set
    End Property

    Public Function Read() As myExecuteResource

        ''Recherche les données d'une ressource exécutée en fonction de son ID_Resource



        Try

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Resource, CE_ID_ProjectMember, CE_ID_Project, CE_ID_AdminResource, PlanDate, HalfDay, Timestamp FROM ExecutedResources WHERE ID_Resource=" & Me.ID_Resource

            'Remise à zéro des variables
            ID_Resource = Nothing
            CE_ID_ProjectMember = Nothing
            CE_ID_Project = Nothing
            CE_ID_AdminResource = Nothing
            PlanDate = Nothing
            HalfDay = Nothing
            Timestamp = Nothing


            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre 
                Try
                    Me.ID_Resource = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

                'Lecture du 2e paramètre
                Try
                    Me.CE_ID_ProjectMember = myDBDataReader.GetValue(1)
                Catch ex As Exception
                End Try

                'Lecture du 3e paramètre
                Try
                    Me.CE_ID_Project = myDBDataReader.GetValue(2)
                Catch ex As Exception
                End Try

                'Lecture du 4e paramètre 
                Try
                    Me.CE_ID_AdminResource = myDBDataReader.GetValue(3)
                Catch ex As Exception
                End Try

                'Lecture du 5e paramètre 
                Try
                    Me.PlanDate = myDBDataReader.GetDateTime(4)
                Catch ex As Exception
                End Try

                'Lecture du 6e paramètre 
                Try
                    Me.HalfDay = myDBDataReader.GetValue(5)
                Catch ex As Exception
                End Try

                'Lecture du 7e paramètre 
                Try
                    Me.Timestamp = myDBDataReader.GetDateTime(6)
                Catch ex As Exception
                End Try


            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

            'On détermine si c'est une ressource de projet
            If Me.CE_ID_Project = 0 Then
                Me.IsProjectResource = False
            Else
                Me.IsProjectResource = True
            End If

            'On détermine si c'est une ressource administrative
            If Me.CE_ID_AdminResource = 0 Then
                Me.IsAdminResource = False
            Else
                Me.IsAdminResource = True
            End If

        Catch ex As Exception

            Debug.WriteLine(ex.ToString)

        End Try

        Return Me


    End Function
    Public Function GetMaxPlanDate() As myExecuteResource

        Me.MaxPlanDate = Nothing

        Try

            'Recherche la PlanDate la plus récente
            'INPUT : nothing
            'OUTPUT : PlanDate


            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader
            Dim SQL As String = "SELECT PlanDate FROM ExecutedResources ORDER BY plandate DESC LIMIT 1;"
            'Me.MaxPlanDate = Nothing


            MyDBConnection.ConnectionString = cnProjectPlan

            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre ID_Resource
                Try
                    Me.MaxPlanDate = myDBDataReader.GetDateTime(0)
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

        Catch ex As Exception

        End Try

        Return Me

    End Function

    Public Function GetMinPlanDate() As myExecuteResource

        Me.MinPlanDate = Nothing

        Try


            'Recherche la PlanDate la plus ancienne
            'INPUT : nothing
            'OUTPUT : PlanDate


            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader
            Dim SQL As String = "SELECT PlanDate FROM ExecutedResources ORDER BY plandate ASC LIMIT 1;"
            Me.MinPlanDate = Nothing


            MyDBConnection.ConnectionString = cnProjectPlan

            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre ID_Resource
                Try
                    Me.MinPlanDate = myDBDataReader.GetDateTime(0)
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

        Catch ex As Exception

        End Try

        Return Me

    End Function

    Public Function GetIDResourceFromDateAndMember() As myExecuteResource

        Try
            'Recherche le ID_Resource en fonction du CE_ID_Membre, d'une date PlanDate et d'une HalfDay
            'INPUT : CE_ID_ProjectMember
            'INPUT : PlanDate
            'INPUT : HalfDay
            'OUTPUT : ID_Resource

            Dim MyDBConnection As New MySqlConnection

            Dim myDBDataReader As MySqlDataReader
            Dim Sql As String = "SELECT ID_Resource FROM ExecutedResources WHERE CE_ID_ProjectMember = " & Me.CE_ID_ProjectMember & " AND PlanDate = '" & fConvertDateOnlyMySQL(Me.PlanDate) & "' AND HalfDay = " & Me.HalfDay & ";"

            MyDBConnection.ConnectionString = cnProjectPlan


            MyDBConnection.Open()

            Dim myDBCommand As MySqlCommand = New MySqlCommand(Sql, MyDBConnection)

            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du premier paramètre ID_Resource
                Try
                    Me.ID_Resource = myDBDataReader.GetValue(0)
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()


        Catch ex As Exception

        End Try


        Return Me

    End Function

    Public Function GetExecutedProjectResourcesPerTaskAndProject() As myExecuteResource

        'Renvoi le nombre de jours exécutées pour un projet donné et pour les membres d'une tâches données
        'INPUT : CE_ID_Project
        'INPUT : CE_ID_Task
        'OUTPUT : EstimatedProjectResources

        Dim ProjectResources As Single = 0

        Try

            Dim MyDBConnection As New MySqlConnection
            Dim myDBDataReader As MySqlDataReader
            Dim SQL As String = ""

            SQL = "SELECT COUNT(ID_Resource) FROM ExecutedResources where CE_ID_Project=" & Me.CE_ID_Project & " AND CE_ID_ProjectMember IN (SELECT ID_ProjectMember FROM ProjectsMembers WHERE CE_ID_Task=" & Me.CE_ID_Task & ") "

            MyDBConnection.ConnectionString = cnProjectPlan
            MyDBConnection.Open()
            Dim myDBCommand As MySqlCommand = New MySqlCommand(SQL, MyDBConnection)
            myDBDataReader = myDBCommand.ExecuteReader()

            While myDBDataReader.Read

                'Lecture du paramètre HalfDay
                Try
                    'On lit et on divise par 2 parce que les valeurs de la DB sont des demi-jours
                    ProjectResources = myDBDataReader.GetValue(0) / 2
                Catch ex As Exception
                End Try

            End While

            myDBDataReader.Close()
            MyDBConnection.Close()

        Catch ex As Exception
            If DebugFlag = True Then MessageBox.Show(ex.ToString)
        End Try

        Me.ExecutedProjectResourcesPerTaskAndProject = ProjectResources
        Return Me

    End Function

End Class
