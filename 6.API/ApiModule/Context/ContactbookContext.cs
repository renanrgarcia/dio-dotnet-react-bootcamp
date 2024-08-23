using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiModule.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiModule.Context
{
    public class ContactbookContext : DbContext
    {
        public ContactbookContext(DbContextOptions<ContactbookContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}