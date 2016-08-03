using EstagiarioWeb.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EstagiarioWeb.Context
{
    public class ComputerContext : DbContext
    {
        public ComputerContext() : base("ComputerContext")
        {
        }
        public DbSet<Computer> Computers { get; set; }
    } 
}