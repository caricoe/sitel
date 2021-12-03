using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sitel_test.Models
{
    public class Agent
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime HiringDate { get; set; }
        public int CampaignId { get; set; }
        public virtual Campaign? Campaign { get; set; }
    }
}
