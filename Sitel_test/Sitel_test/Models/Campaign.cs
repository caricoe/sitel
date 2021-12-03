using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sitel_test.Models
{
    public class Campaign
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        
        public int TrainerId { get; set; }

        public virtual Trainer? Trainer { get; set; }
    }
}
