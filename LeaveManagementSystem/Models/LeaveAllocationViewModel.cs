﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Models
{
    public class LeaveAllocationViewModel
    {
        public int Id { get; set; }

        [Required]
        public int NoOfDays { get; set; }

        public DateTime DateCreated { get; set; }

        public EmployeeViewModel Employee { get; set; }

        public string EmployeeId { get; set; }

        public LeaveTypeViewModel LeaveType { get; set; }

        public int LeaveTypeId { get; set; }

        //to populate dropdownlist used to select employees
        public IEnumerable<SelectListItem> Employees { get; set; }

        public IEnumerable<SelectListItem> LeaveTypes { get; set; }
    }
}