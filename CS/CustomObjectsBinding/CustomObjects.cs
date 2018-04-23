using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections;
using System.Drawing;

namespace CustomObjectsBinding {

#region #customappointment
    public class CustomAppointment
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Subject { get; set; }
        public int Status { get; set; }
        public string Description { get; set; }
        public int Label { get; set; }
        public string Location { get; set; }
        public bool AllDay { get; set; }
        public int EventType { get; set; }
        public string RecurrenceInfo { get; set; }
        public string ReminderInfo { get; set; }
        public object OwnerId { get; set; }
    }
#endregion  #customappointment

#region #customresource
    public class CustomResource {
        public string Name { get; set; }
        public int ResID { get; set; }
        public Color ResColor { get; set; }
        // Set the SchedulerStorage.Resources.ColorSaving property to ColorSavingType.Color to display resources using the specified color. 
    }
    #endregion #customresource

}