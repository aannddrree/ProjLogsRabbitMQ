using System;

namespace ProjLogsRabbitMQ.Models
{
    public class Log
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime SendDate { get; set; } = DateTime.Now;
    }
}
