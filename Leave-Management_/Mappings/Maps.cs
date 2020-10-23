using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Leave_Management_.Data;
using Leave_Management_.Models;


namespace Leave_Management_.Mappings
{
    public class Maps : Profile
    {

        public Maps()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
            CreateMap<LeaveHistory, LeaveHistoryVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();

            CreateMap<Employee, EmployeeVM>().ReverseMap();


            //CreateMap<LeaveType, CreateLeaveTypeVM>().ReverseMap();
        }
    }
}
