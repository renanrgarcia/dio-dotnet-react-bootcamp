using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssignmentsAPIChallenge.Models;
using Microsoft.EntityFrameworkCore;

namespace AssignmentsAPIChallenge.Context
{
    public class AssignmentContext : DbContext
    {
        public AssignmentContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Assignment> Assignments { get; set; }
    }
}