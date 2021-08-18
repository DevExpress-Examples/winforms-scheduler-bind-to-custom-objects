Namespace CustomObjectsBinding
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.dateNavigator1 = New DevExpress.XtraScheduler.DateNavigator()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.SchedulerDataStorage1 = New DevExpress.XtraScheduler.SchedulerDataStorage(Me.components)
            CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dateNavigator1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SchedulerDataStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'schedulerControl1
            '
            Me.schedulerControl1.DataStorage = Me.SchedulerDataStorage1
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 30)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Size = New System.Drawing.Size(580, 328)
            Me.schedulerControl1.Start = New Date(2008, 10, 31, 0, 0, 0, 0)
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            TimeRuler1.TimeZoneId = "Russian Standard Time"
            TimeRuler1.UseClientTimeZone = False
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(TimeRuler1)
            TimeRuler2.TimeZoneId = "Russian Standard Time"
            TimeRuler2.UseClientTimeZone = False
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            Me.schedulerControl1.Views.YearView.UseOptimizedScrolling = False
            '
            'dateNavigator1
            '
            Me.dateNavigator1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.dateNavigator1.CellPadding = New System.Windows.Forms.Padding(2)
            Me.dateNavigator1.DateTime = New Date(2008, 10, 31, 0, 0, 0, 0)
            Me.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Right
            Me.dateNavigator1.EditValue = New Date(2008, 10, 31, 0, 0, 0, 0)
            Me.dateNavigator1.FirstDayOfWeek = System.DayOfWeek.Sunday
            Me.dateNavigator1.Location = New System.Drawing.Point(580, 30)
            Me.dateNavigator1.Name = "dateNavigator1"
            Me.dateNavigator1.SchedulerControl = Me.schedulerControl1
            Me.dateNavigator1.Size = New System.Drawing.Size(179, 328)
            Me.dateNavigator1.TabIndex = 1
            '
            'panelControl1
            '
            Me.panelControl1.Controls.Add(Me.radioGroup1)
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(759, 30)
            Me.panelControl1.TabIndex = 2
            '
            'radioGroup1
            '
            Me.radioGroup1.Dock = System.Windows.Forms.DockStyle.Left
            Me.radioGroup1.EditValue = 1
            Me.radioGroup1.Location = New System.Drawing.Point(62, 2)
            Me.radioGroup1.Name = "radioGroup1"
            Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "None"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Resource"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Date")})
            Me.radioGroup1.Size = New System.Drawing.Size(328, 26)
            Me.radioGroup1.TabIndex = 0
            '
            'labelControl1
            '
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Left
            Me.labelControl1.Location = New System.Drawing.Point(2, 2)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(60, 26)
            Me.labelControl1.TabIndex = 1
            Me.labelControl1.Text = "Group by:"
            '
            'SchedulerDataStorage1
            '
            '
            '
            '
            Me.SchedulerDataStorage1.AppointmentDependencies.AutoReload = False
            '
            '
            '
            Me.SchedulerDataStorage1.Appointments.Labels.CreateNewLabel(0, "None", "&None", System.Drawing.SystemColors.Window)
            Me.SchedulerDataStorage1.Appointments.Labels.CreateNewLabel(1, "Important", "&Important", System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(190, Byte), Integer)))
            Me.SchedulerDataStorage1.Appointments.Labels.CreateNewLabel(2, "Business", "&Business", System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(255, Byte), Integer)))
            Me.SchedulerDataStorage1.Appointments.Labels.CreateNewLabel(3, "Personal", "&Personal", System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(156, Byte), Integer)))
            Me.SchedulerDataStorage1.Appointments.Labels.CreateNewLabel(4, "Vacation", "&Vacation", System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(199, Byte), Integer)))
            Me.SchedulerDataStorage1.Appointments.Labels.CreateNewLabel(5, "Must Attend", "Must &Attend", System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(147, Byte), Integer)))
            Me.SchedulerDataStorage1.Appointments.Labels.CreateNewLabel(6, "Travel Required", "&Travel Required", System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer)))
            Me.SchedulerDataStorage1.Appointments.Labels.CreateNewLabel(7, "Needs Preparation", "&Needs Preparation", System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(152, Byte), Integer)))
            Me.SchedulerDataStorage1.Appointments.Labels.CreateNewLabel(8, "Birthday", "&Birthday", System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer)))
            Me.SchedulerDataStorage1.Appointments.Labels.CreateNewLabel(9, "Anniversary", "&Anniversary", System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(223, Byte), Integer)))
            Me.SchedulerDataStorage1.Appointments.Labels.CreateNewLabel(10, "Phone Call", "Phone &Call", System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(165, Byte), Integer)))
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(759, 358)
            Me.Controls.Add(Me.schedulerControl1)
            Me.Controls.Add(Me.dateNavigator1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dateNavigator1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SchedulerDataStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
        Private dateNavigator1 As DevExpress.XtraScheduler.DateNavigator
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private WithEvents radioGroup1 As DevExpress.XtraEditors.RadioGroup
        Friend WithEvents SchedulerDataStorage1 As DevExpress.XtraScheduler.SchedulerDataStorage
    End Class
End Namespace

