using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sitel_test.Models
{
    public class ViewModelAgent
    {

        [DisplayName("AgentId")]
        public int Id { get; set; }

        [DisplayName("AgentName")]
        public string Name { get; set; }

        [DisplayName("Hiringdate")]
        public string HiringDate { get; set; }

        [DisplayName("CampaignName")]
        public string CampaignName { get; set; }

        [DisplayName("TrainerName")]
        public string TrainerName { get; set; }
    }
}
