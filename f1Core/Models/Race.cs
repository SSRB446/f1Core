using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace f1Core.Models
{
    public class Race
    {
        [Key]
        public int RaceId { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = "";

        public DateTime Date { get; set; }

        [ForeignKey("Circuit")]
        public int CircuitId { get; set; }
        public Circuit? Circuit { get; set; }

        [ForeignKey("Season")]
        public int SeasonId { get; set; }
        public Season? Season { get; set; }
    }
}
