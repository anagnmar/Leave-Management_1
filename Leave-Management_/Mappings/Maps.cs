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
            CreateMap<LeaveType, DetailsLeaveTypeVM>().ReverseMap();
            CreateMap<LeaveType, CreateLeaveTypeVM>().ReverseMap();

            CreateMap<LeaveHistory, LeaveHistoryVM>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();

        }
    }
}
