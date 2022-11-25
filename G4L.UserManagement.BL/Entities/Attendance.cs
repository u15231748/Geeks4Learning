﻿using G4L.UserManagement.BL.Enum;
using G4L.UserManagement.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G4L.UserManagement.BL.Entities
{
    public class Attendance : BaseEntity
    {

       
        public Guid UserId { get; set; }
        public  string Date { get; set; }
        public AttendanceStatus Status { get; set; }
        public DateTime Clockin_Time { get; set; }
        public DateTime Clockout_Time { get; set; }
        public string Goal_summary { get; set; }
        public string Goal_Description { get; set; }
        public string Time_Limit { get; set; }
        public Leave Leave { get; set; }
        public Status Leave_Status { get; set; }


    }
}
