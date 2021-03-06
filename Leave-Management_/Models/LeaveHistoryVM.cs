﻿using System;
using System.Collections.Generic;


namespace Leave_Management_.Models
{
    public class LeaveHistoryVM
    {

        public int Id { get; set; }

        public EmployeeVM RequestingEmployee { get; set; }

        public string RequestingEmployeeId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime DateRequested { get; set; }

        public DateTime DateActioned { get; set; }

        public bool? Approved { get; set; }


        public LeaveTypeVM LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

        public EmployeeVM ApprovedBy { get; set; }
        public string ApprovedById { get; set; }

    }

}
