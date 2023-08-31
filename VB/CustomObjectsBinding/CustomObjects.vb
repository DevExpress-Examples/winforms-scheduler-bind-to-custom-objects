Imports System.ComponentModel
Imports System.Drawing

Namespace CustomObjectsBinding

'#Region "#customappointment"
    Public Class CustomAppointment

        Public Property StartTime As Date

        Public Property EndTime As Date

        Public Property Subject As String

        Public Property Status As Integer

        Public Property Description As String

        Public Property Label As Integer

        Public Property Location As String

        Public Property AllDay As Boolean

        Public Property EventType As Integer

        Public Property RecurrenceInfo As String

        Public Property ReminderInfo As String

        Public Property OwnerId As Object
    End Class

'#End Region  ' #customappointment
'#Region "#customresource"
    Public Class CustomResource

        Public Property Name As String

        Public Property ResID As Integer

        Public Property ResColor As Color
    ' Set the SchedulerStorage.Resources.ColorSaving property to ColorSavingType.Color to display resources using the specified color. 
    End Class
'#End Region  ' #customresource
End Namespace
