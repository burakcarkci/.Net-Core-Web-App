using Leave_Management_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_Project.Contracts
{
    internal interface ILeaveAllocationRepository : IRepositoryBase<LeaveAllocation>
    {
    }
}