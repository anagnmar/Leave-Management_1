using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Leave_Management_.Models
{
    public class LeaveAllocationVM
    {

     // Table: AspNetUsers.Id, same type

        public int Id { get; set; }

        [Required]
        public int NumberOfDays { get; set; }

        public DateTime DateCreated { get; set; }
     //

        public EmployeeVM Employee { get; set; }
        public string EmployeeId { get; set; }

        public DetailsLeaveTypeVM LeaveType { get; set; }
        public int LeaveTypeId { get; set; }

    }
}
