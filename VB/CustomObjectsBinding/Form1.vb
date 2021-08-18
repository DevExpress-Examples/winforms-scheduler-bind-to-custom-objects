Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports System.Diagnostics

Namespace CustomObjectsBinding
    Partial Public Class Form1
        Inherits Form

        Public Shared RandomInstance As New Random()

        Private CustomResourceCollection As New BindingList(Of CustomResource)()
        Private CustomEventList As New BindingList(Of CustomAppointment)()
        Dim CustomLabelList As New BindingList(Of CustomLabel)()
        Dim CustomStatusList As New BindingList(Of CustomStatus)()

        Public Sub New()
            InitializeComponent()
            WindowState = System.Windows.Forms.FormWindowState.Maximized
            SchedulerDataStorage1.Resources.ColorSaving = DXColorSavingType.ColorInstance

        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            InitResources()
            InitAppointments()
            InitLabels(CustomLabelList)
            InitStatus(CustomStatusList)
            schedulerControl1.Start = Date.Now
            UpdateControls()
        End Sub

        Private Sub InitResources()
            Dim mappings As ResourceMappingInfo = SchedulerDataStorage1.Resources.Mappings
            mappings.Id = "ResID"
            mappings.Color = "ResColor"
            mappings.Caption = "Name"

            CustomResourceCollection.Add(CreateCustomResource(1, "Max Fowler", Color.PowderBlue))
            CustomResourceCollection.Add(CreateCustomResource(2, "Nancy Drewmore", Color.PaleVioletRed))
            CustomResourceCollection.Add(CreateCustomResource(3, "Pak Jang", Color.PeachPuff))
            SchedulerDataStorage1.Resources.DataSource = CustomResourceCollection
        End Sub

        Private Function CreateCustomResource(ByVal res_id As Integer, ByVal caption As String, ByVal ResColor As Color) As CustomResource
            Dim cr As New CustomResource()
            cr.ResID = res_id
            cr.Name = caption
            cr.ResColor = ResColor
            Return cr
        End Function



        Private Sub InitAppointments()
            Dim mappings As AppointmentMappingInfo = SchedulerDataStorage1.Appointments.Mappings
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
            SchedulerDataStorage1.Appointments.DataSource = CustomEventList
        End Sub


        Private Sub GenerateEvents(ByVal eventList As BindingList(Of CustomAppointment))
            Dim count As Integer = SchedulerDataStorage1.Resources.Count

            For i As Integer = 0 To count - 1
                Dim resource As Resource = SchedulerDataStorage1.Resources(i)
                Dim subjPrefix As String = resource.Caption & "'s "
                eventList.Add(CreateEvent(subjPrefix & "meeting", resource.Id, 2, 5))
                eventList.Add(CreateEvent(subjPrefix & "travel", resource.Id, 3, 6))
                eventList.Add(CreateEvent(subjPrefix & "phone call", resource.Id, 0, 10))
            Next i
        End Sub
        Private Function CreateEvent(ByVal subject As String, ByVal resourceId As Object, ByVal status As Integer, ByVal label As Integer) As CustomAppointment
            Dim apt As New CustomAppointment()
            apt.Subject = subject
            apt.OwnerId = resourceId
            Dim rnd As Random = RandomInstance
            Dim rangeInMinutes As Integer = 60 * 24
            apt.StartTime = Date.Today + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes))
            apt.EndTime = apt.StartTime.Add(TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes \ 4)))
            apt.Status = status
            apt.Label = label
            Return apt
        End Function

        Public Sub InitLabels(ByVal labels As BindingList(Of CustomLabel))
            Dim mappingsLabel As LabelMappingInfo = schedulerDataStorage1.Labels.Mappings
            mappingsLabel.Color = "ColorLabel"
            mappingsLabel.DisplayName = "Name"
            mappingsLabel.Id = "ID"

            For i As Integer = 0 To 14
                labels.Add(CreateCustomLabel(i))
            Next i

            schedulerDataStorage1.Labels.DataSource = CustomLabelList
        End Sub

        Private Function CreateCustomLabel(ByVal id As Integer) As CustomLabel
            Dim label As New CustomLabel()
            label.ID = id
            label.Name = "Name" & id
            Dim rnd As Random = RandomInstance
            label.ColorLabel = Color.FromArgb(rnd.Next())
            Return label
        End Function

        Public Sub InitStatus(ByVal listStatus As BindingList(Of CustomStatus))
            Dim mappingsStatus As StatusMappingInfo = Me.schedulerDataStorage1.Statuses.Mappings
            mappingsStatus.Brush = "ColorStatus"
            mappingsStatus.DisplayName = "Name"
            mappingsStatus.Id = "ID"

            For i As Integer = 0 To 14
                listStatus.Add(CreateCustomStatus(i))
            Next i

            schedulerDataStorage1.Statuses.DataSource = CustomStatusList
        End Sub

        Private Function CreateCustomStatus(ByVal id As Integer) As CustomStatus
            Dim status As New CustomStatus()
            status.ID = id
            status.Name = "Status" & id
            Dim rnd As Random = RandomInstance
            status.ColorStatus = Color.FromArgb(rnd.Next())
            Return status
        End Function

        Private Sub UpdateControls()
            Me.radioGroup1.EditValue = CInt((schedulerControl1.GroupType))
        End Sub

        Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioGroup1.SelectedIndexChanged
            schedulerControl1.GroupType = CType(radioGroup1.EditValue, SchedulerGroupType)
        End Sub
    End Class
End Namespace