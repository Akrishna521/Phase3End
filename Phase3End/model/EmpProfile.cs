﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Phase3End.model
{
    [Table("EmpProfile")]
    public class EmpProfile
    {
        [Key]
        public int EmpCode { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? EmpName { get; set; }
        public string? Email { get; set; }
        public int DeptCode { get; set; }
        public virtual DeptMaster? DeptMaster { get; set; }

    }
}
