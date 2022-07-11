﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeDetails.Models;

namespace EmployeeDetails.Data
{
    public class EmployeeDetailsContext : DbContext
    {
        public EmployeeDetailsContext (DbContextOptions<EmployeeDetailsContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeDetails.Models.Employee> Employee { get; set; }
    }
}
