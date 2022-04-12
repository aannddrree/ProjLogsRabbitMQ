using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjLogsRabbitMQ.ApiToSQLServer.Data;
using ProjLogsRabbitMQ.Models;

namespace ProjLogsRabbitMQ.ApiToSQLServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogsController : ControllerBase
    {
        private readonly ProjLogsRabbitMQApiToSQLServerContext _context;

        public LogsController(ProjLogsRabbitMQApiToSQLServerContext context)
        {
            _context = context;
        }

        // GET: api/Logs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Log>>> GetLog()
        {
            return await _context.Log.ToListAsync();
        }

        // POST: api/Logs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Log>> PostLog(Log log)
        {
            _context.Log.Add(log);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLog", new { id = log.Id }, log);
        }
    }
}
