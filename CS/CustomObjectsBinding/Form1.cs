using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using System.Diagnostics;

namespace CustomObjectsBinding {
    public partial class Form1 : Form {
        public static Random RandomInstance = new Random();

        private BindingList<CustomResource> CustomResourceCollection = new BindingList<CustomResource>();
        private BindingList<CustomAppointment> CustomEventList = new BindingList<CustomAppointment>();
        BindingList<CustomLabel> CustomLabelList = new BindingList<CustomLabel>();
        BindingList<CustomStatus> CustomStatusList = new BindingList<CustomStatus>();

        public Form1() {
            InitializeComponent();
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            schedulerDataStorage1.Resources.ColorSaving = DXColorSavingType.ColorInstance;
        }

        private void Form1_Load(object sender, EventArgs e) {
            InitResources();
            InitAppointments();
            InitLabels(CustomLabelList);
            InitStatus(CustomStatusList);
            schedulerControl1.Start = DateTime.Now;
            UpdateControls();
        }

        private void InitResources() {
            ResourceMappingInfo mappings = this.schedulerDataStorage1.Resources.Mappings;
            mappings.Id = "ResID";
            mappings.Color = "ResColor";
            mappings.Caption = "Name";

            CustomResourceCollection.Add(CreateCustomResource(1, "Max Fowler", Color.PowderBlue));
            CustomResourceCollection.Add(CreateCustomResource(2, "Nancy Drewmore", Color.PaleVioletRed));
            CustomResourceCollection.Add(CreateCustomResource(3, "Pak Jang", Color.PeachPuff));
            this.schedulerDataStorage1.Resources.DataSource = CustomResourceCollection;
        }

        private CustomResource CreateCustomResource(int res_id, string caption, Color ResColor) {
            CustomResource cr = new CustomResource();
            cr.ResID = res_id;
            cr.Name = caption;
            cr.ResColor = ResColor;
            return cr;
        }



        private void InitAppointments() {
            AppointmentMappingInfo mappings = this.schedulerDataStorage1.Appointments.Mappings;
            mappings.Start = "StartTime";
            mappings.End = "EndTime";
            mappings.Subject = "Subject";
            mappings.AllDay = "AllDay";
            mappings.Description = "Description";
            mappings.Label = "Label";
            mappings.Location = "Location";
            mappings.RecurrenceInfo = "RecurrenceInfo";
            mappings.ReminderInfo = "ReminderInfo";
            mappings.ResourceId = "OwnerId";
            mappings.Status = "Status";
            mappings.Type = "EventType";

            GenerateEvents(CustomEventList);
            this.schedulerDataStorage1.Appointments.DataSource = CustomEventList;
        }


        private void GenerateEvents(BindingList<CustomAppointment> eventList) {
            int count = schedulerDataStorage1.Resources.Count;

            for (int i = 0; i < count; i++) {
                Resource resource = schedulerDataStorage1.Resources[i];
                string subjPrefix = resource.Caption + "'s ";
                eventList.Add(CreateEvent(subjPrefix + "meeting", resource.Id, 2, 5));
                eventList.Add(CreateEvent(subjPrefix + "travel", resource.Id, 3, 6));
                eventList.Add(CreateEvent(subjPrefix + "phone call", resource.Id, 0, 10));
            }
        }
        private CustomAppointment CreateEvent(string subject, object resourceId, int status, int label) {
            CustomAppointment apt = new CustomAppointment();
            apt.Subject = subject;
            apt.OwnerId = resourceId;
            Random rnd = RandomInstance;
            int rangeInMinutes = 60 * 24;
            apt.StartTime = DateTime.Today + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes));
            apt.EndTime = apt.StartTime + TimeSpan.FromMinutes(rnd.Next(0, rangeInMinutes / 4));
            apt.Status = status;
            apt.Label = label;
            return apt;
        }

        public void InitLabels(BindingList<CustomLabel> labels) {
            LabelMappingInfo mappingsLabel = schedulerDataStorage1.Labels.Mappings;
            mappingsLabel.Color = "ColorLabel";
            mappingsLabel.DisplayName = "Name";
            mappingsLabel.Id = "ID";

            for(int i = 0; i < 15; i++)
                labels.Add(CreateCustomLabel(i));

            schedulerDataStorage1.Labels.DataSource = CustomLabelList;
        }

        private CustomLabel CreateCustomLabel(int id) {
            CustomLabel label = new CustomLabel();
            label.ID = id;
            label.Name = "Name" + id;
            Random rnd = RandomInstance;
            label.ColorLabel = Color.FromArgb(rnd.Next());
            return label;
        }

        public void InitStatus(BindingList<CustomStatus> listStatus) {
            StatusMappingInfo mappingsStatus = this.schedulerDataStorage1.Statuses.Mappings;
            mappingsStatus.Brush = "ColorStatus";
            mappingsStatus.DisplayName = "Name";
            mappingsStatus.Id = "ID";

            for(int i = 0; i < 15; i++)
                listStatus.Add(CreateCustomStatus(i));

            schedulerDataStorage1.Statuses.DataSource = CustomStatusList;
        }

        private CustomStatus CreateCustomStatus(int id) {
            CustomStatus status = new CustomStatus();
            status.ID = id;
            status.Name = "Status" + id;
            Random rnd = RandomInstance;
            status.ColorStatus = Color.FromArgb(rnd.Next());
            return status;
        }

        private void UpdateControls() {
            this.radioGroup1.EditValue = (int)schedulerControl1.GroupType;
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e) {
            schedulerControl1.GroupType = (SchedulerGroupType)radioGroup1.EditValue;
        }
    }
}