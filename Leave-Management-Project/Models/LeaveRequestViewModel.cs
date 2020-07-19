using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Management_Project.Models
{
    public class LeaveRequestViewModel
    {
        public int Id { get; set; }

        public EmployeeViewModel RequestingEmployee { get; set; }

        public string RequestingEmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public LeaveTypeViewModel LeaveType { get; set; }

        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime? DateActioned { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }

        [Display(Name = "Employee Comments")]
        [MaxLength(500)]
        public string RequestComments { get; set; }

        public EmployeeViewModel ApprovedBy { get; set; }

        public string ApprovedById { get; set; }
    }

    public class AdminLeaveRequestViewModel
    {
        [Display(Name = "Total Number Of Requests")]
        public int TotalRequests { get; set; }

        [Display(Name = "Approved Requests")]
        public int ApprovedRequests { get; set; }

        [Display(Name = "Pending Requests")]
        public int PendingRequests { get; set; }

        [Display(Name = "Rejected Requests")]
        public int RejectedRequests { get; set; }

        public List<LeaveRequestViewModel> LeaveRequests { get; set; }
    }
}