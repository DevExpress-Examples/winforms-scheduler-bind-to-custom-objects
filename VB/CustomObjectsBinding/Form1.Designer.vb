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
            Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
            Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.dateNavigator1 = New DevExpress.XtraScheduler.DateNavigator()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            DirectCast(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' schedulerControl1
            ' 
            Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            Me.schedulerControl1.Location = New System.Drawing.Point(0, 30)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Size = New System.Drawing.Size(584, 326)
            Me.schedulerControl1.Start = New Date(2008, 10, 31, 0, 0, 0, 0)
            Me.schedulerControl1.Storage = Me.schedulerStorage1
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            timeRuler1.TimeZoneId = "Russian Standard Time"
            timeRuler1.UseClientTimeZone = False
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
            timeRuler2.TimeZoneId = "Russian Standard Time"
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
            Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { _
                New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "None"), _
                New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Resource"), _
                New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Date") _
            })
            Me.radioGroup1.Size = New System.Drawing.Size(328, 26)
            Me.radioGroup1.TabIndex = 0
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
            DirectCast(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            DirectCast(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
        Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
        Private dateNavigator1 As DevExpress.XtraScheduler.DateNavigator
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private labelControl1 As DevExpress.XtraEditors.LabelControl
        Private WithEvents radioGroup1 As DevExpress.XtraEditors.RadioGroup
    End Class
End Namespace

