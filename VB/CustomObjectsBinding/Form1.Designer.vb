Namespace CustomObjectsBinding

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim timeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.dateNavigator1 = New DevExpress.XtraScheduler.DateNavigator()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            CType((Me.schedulerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.schedulerStorage1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateNavigator1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.radioGroup1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 30)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Size = New System.Drawing.Size(584, 326)
            Me.schedulerControl1.Start = New System.DateTime(2008, 10, 31, 0, 0, 0, 0)
            Me.schedulerControl1.Storage = Me.schedulerStorage1
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            timeRuler1.TimeZone.DaylightBias = System.TimeSpan.Parse("-01:00:00")
            timeRuler1.TimeZone.DaylightZoneName = "Russian Daylight Time"
            timeRuler1.TimeZone.DisplayName = "(UTC+04:00) Moscow, St. Petersburg, Volgograd"
            timeRuler1.TimeZone.StandardZoneName = "Russian Standard Time"
            timeRuler1.TimeZone.UtcOffset = System.TimeSpan.Parse("04:00:00")
            timeRuler1.UseClientTimeZone = False
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
            timeRuler2.TimeZone.DaylightBias = System.TimeSpan.Parse("-01:00:00")
            timeRuler2.TimeZone.DaylightZoneName = "Russian Daylight Time"
            timeRuler2.TimeZone.DisplayName = "(UTC+04:00) Moscow, St. Petersburg, Volgograd"
            timeRuler2.TimeZone.StandardZoneName = "Russian Standard Time"
            timeRuler2.TimeZone.UtcOffset = System.TimeSpan.Parse("04:00:00")
            timeRuler2.UseClientTimeZone = False
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
            ' 
            ' dateNavigator1
            ' 
            Me.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Right
            Me.dateNavigator1.HotDate = Nothing
            Me.dateNavigator1.Location = New System.Drawing.Point(584, 30)
            Me.dateNavigator1.Name = "dateNavigator1"
            Me.dateNavigator1.SchedulerControl = Me.schedulerControl1
            Me.dateNavigator1.Size = New System.Drawing.Size(179, 326)
            Me.dateNavigator1.TabIndex = 1
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.radioGroup1)
            Me.panelControl1.Controls.Add(Me.labelControl1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(763, 30)
            Me.panelControl1.TabIndex = 2
            ' 
            ' radioGroup1
            ' 
            Me.radioGroup1.Dock = System.Windows.Forms.DockStyle.Left
            Me.radioGroup1.EditValue = 1
            Me.radioGroup1.Location = New System.Drawing.Point(62, 2)
            Me.radioGroup1.Name = "radioGroup1"
            Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "None"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Resource"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Date")})
            Me.radioGroup1.Size = New System.Drawing.Size(328, 26)
            Me.radioGroup1.TabIndex = 0
            AddHandler Me.radioGroup1.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroup1_SelectedIndexChanged)
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Left
            Me.labelControl1.Location = New System.Drawing.Point(2, 2)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(60, 26)
            Me.labelControl1.TabIndex = 1
            Me.labelControl1.Text = "Group by:"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(763, 356)
            Me.Controls.Add(Me.schedulerControl1)
            Me.Controls.Add(Me.dateNavigator1)
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.schedulerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.schedulerStorage1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateNavigator1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.radioGroup1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl

        Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage

        Private dateNavigator1 As DevExpress.XtraScheduler.DateNavigator

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private radioGroup1 As DevExpress.XtraEditors.RadioGroup
    End Class
End Namespace
