﻿using System.ComponentModel.DataAnnotations;

namespace EmployeeSystem.Models
{
    public class Department
    {

        [Key]
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }
    }
}
