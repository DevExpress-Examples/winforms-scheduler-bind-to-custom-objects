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

    public class CustomLabel {
        private string m_name;
        private int _id;
        private Color _color;

        public string Name { get { return m_name; } set { m_name = value; } }
        public int ID { get { return _id; } set { _id = value; } }
        public Color ColorLabel { get { return _color; } set { _color = value; } }

        public CustomLabel() {
        }
    }


    public class CustomStatus {
        private string m_name;
        private int _id;
        //private Brush _color;
        private Color _color;
        public string Name { get { return m_name; } set { m_name = value; } }
        public int ID { get { return _id; } set { _id = value; } }
        //public Brush ColorStatus { get { return _color; } set { _color = value; } }
        public Color ColorStatus { get { return _color; } set { _color = value; } }

        public CustomStatus() {
        }
    }

}