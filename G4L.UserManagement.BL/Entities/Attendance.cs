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
        
       
        public DateTime Date { get; set; }
        public Attendance_Status Status { get; set; }
        public DateTime Clockin_Time { get; set; }
        public DateTime Clockout_Time { get; set; }
    
    }
}
