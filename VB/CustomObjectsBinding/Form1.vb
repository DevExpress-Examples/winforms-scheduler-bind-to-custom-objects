Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports System.Diagnostics

Namespace CustomObjectsBinding

    Public Partial Class Form1
        Inherits Form

        Public Shared RandomInstance As Random = New Random()

        Private CustomResourceCollection As BindingList(Of CustomResource) = New BindingList(Of CustomResource)()

        Private CustomEventList As BindingList(Of CustomAppointment) = New BindingList(Of CustomAppointment)()

        Public Sub New()
            InitializeComponent()
            schedulerStorage1.Resources.ColorSaving = ColorSavingType.Color
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            InitResources()
            InitAppointments()
            schedulerControl1.Start = Date.Now
            UpdateControls()
        End Sub

        Private Sub InitResources()
            Dim mappings As ResourceMappingInfo = schedulerStorage1.Resources.Mappings
            mappings.Id = "ResID"
            mappings.Color = "ResColor"
            mappings.Caption = "Name"
            CustomResourceCollection.Add(CreateCustomResource(1, "Max Fowler", Color.PowderBlue))
            CustomResourceCollection.Add(CreateCustomResource(2, "Nancy Drewmore", Color.PaleVioletRed))
            CustomResourceCollection.Add(CreateCustomResource(3, "Pak Jang", Color.PeachPuff))
            schedulerStorage1.Resources.DataSource = CustomResourceCollection
        End Sub

        Private Function CreateCustomResource(ByVal res_id As Integer, ByVal caption As String, ByVal ResColor As Color) As CustomResource
            Dim cr As CustomResource = New CustomResource()
            cr.ResID = res_id
            cr.Name = caption
            cr.ResColor = ResColor
            Return cr
        End Function

        Private Sub InitAppointments()
            Dim mappings As AppointmentMappingInfo = schedulerStorage1.Appointments.Mappings
            mappings.Start = "StartTime"
            mappings.End = "EndTime"
            mappings.Subject = "Subject"
            mappings.AllDay = "AllDay"
            mappings.Description = "Description"
            mappings.Label = "Label"
            mappings.Location = "Location"
            mappings.RecurrenceInfo = "RecurrenceInfo"
            mappings.ReminderInfo = "ReminderInfo"
            mappings.ResourceId = "OwnerId"
            mappings.Status = "Status"
            mappings.Type = "EventType"
            GenerateEvents(CustomEventList)
            schedulerStorage1.Appointments.DataSource = CustomEventList
        End Sub

        Private Sub GenerateEvents(ByVal eventList As BindingList(Of CustomAppointment))
            Dim count As Integer = schedulerStorage1.Resources.Count
            For i As Integer = 0 To count - 1
                Dim resource As Resource = schedulerStorage1.Resources(i)
                Dim subjPrefix As String = resource.Caption & "'s "
                eventList.Add(CreateEvent(subjPrefix & "meeting", resource.Id, 2, 5))
                eventList.Add(CreateEvent(subjPrefix & "travel", resource.Id, 3, 6))
                eventList.Add(CreateEvent(subjPrefix & "phone call", resource.Id, 0, 10))
            Next
        End Sub

        Private Function CreateEvent(ByVal subject As String, ByVal resourceId As Object, ByVal status As Integer, ByVal label As Integer) As CustomAppointment
            Dim apt As CustomAppointment = New CustomAppointment()
            apt.Subject = subject
            apt.OwnerId = resourceId
            Dim rnd As Random = RandomInstance
            Dim rangeInMinutes As Integer = 60 * 24
            apt.StartTime = Date.Today + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes))
            apt.EndTime = apt.StartTime + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes \ 4))
            apt.Status = status
            apt.Label = label
            Return apt
        End Function

        Private Sub UpdateControls()
            radioGroup1.EditValue = CInt(schedulerControl1.GroupType)
        End Sub

        Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            schedulerControl1.GroupType = CType(radioGroup1.EditValue, SchedulerGroupType)
        End Sub
    End Class
End Namespace
