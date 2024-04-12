using System.ComponentModel.DataAnnotations.Schema;

namespace BakeryWeb.Domain.Models
{
    [Table("Schedules")]
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
    }
}

