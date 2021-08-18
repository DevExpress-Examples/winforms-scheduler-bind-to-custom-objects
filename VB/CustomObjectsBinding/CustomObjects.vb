Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel
Imports System.Collections
Imports System.Drawing

Namespace CustomObjectsBinding

#Region "#customappointment"
    Public Class CustomAppointment
        Public Property StartTime() As Date
        Public Property EndTime() As Date
        Public Property Subject() As String
        Public Property Status() As Integer
        Public Property Description() As String
        Public Property Label() As Integer
        Public Property Location() As String
        Public Property AllDay() As Boolean
        Public Property EventType() As Integer
        Public Property RecurrenceInfo() As String
        Public Property ReminderInfo() As String
        Public Property OwnerId() As Object
    End Class
#End Region '  #customappointment

#Region "#customresource"
    Public Class CustomResource
        Public Property Name() As String
        Public Property ResID() As Integer
        Public Property ResColor() As Color
        ' Set the SchedulerStorage.Resources.ColorSaving property to ColorSavingType.Color to display resources using the specified color. 
    End Class
#End Region ' #customresource

    Public Class CustomLabel
        Private m_name As String
        Private _id As Integer
        Private _color As Color

        Public Property Name() As String
            Get
                Return m_name
            End Get
            Set(ByVal value As String)
                m_name = value
            End Set
        End Property
        Public Property ID() As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                _id = value
            End Set
        End Property
        Public Property ColorLabel() As Color
            Get
                Return _color
            End Get
            Set(ByVal value As Color)
                _color = value
            End Set
        End Property

        Public Sub New()
        End Sub
    End Class


    Public Class CustomStatus
        Private m_name As String
        Private _id As Integer
        Private _color As Color
        Public Property Name() As String
            Get
                Return m_name
            End Get
            Set(ByVal value As String)
                m_name = value
            End Set
        End Property
        Public Property ID() As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                _id = value
            End Set
        End Property
        Public Property ColorStatus() As Color
            Get
                Return _color
            End Get
            Set(ByVal value As Color)
                _color = value
            End Set
        End Property

        Public Sub New()
        End Sub
    End Class

End Namespace