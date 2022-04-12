using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjLogsRabbitMQ.Models;

namespace ProjLogsRabbitMQ.ApiToSQLServer.Data
{
    public class ProjLogsRabbitMQApiToSQLServerContext : DbContext
    {
        public ProjLogsRabbitMQApiToSQLServerContext (DbContextOptions<ProjLogsRabbitMQApiToSQLServerContext> options)
            : base(options)
        {
        }

        public DbSet<ProjLogsRabbitMQ.Models.Log> Log { get; set; }
    }
}
