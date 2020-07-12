﻿using AutoMapper;
using Leave_Management_Project.Data;
using Leave_Management_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_Project.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<LeaveType, LeaveTypeViewModel>().ReverseMap();
            CreateMap<LeaveHistory, LeaveHistoryViewModel>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationViewModel>().ReverseMap();
            CreateMap<LeaveAllocation, EditLeaveAllocationViewModel>().ReverseMap();
            CreateMap<Employee, EmployeeViewModel>().ReverseMap();
        }
    }
}