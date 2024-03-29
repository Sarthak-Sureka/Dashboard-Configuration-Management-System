﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardConfig.Entities
{
    public class Dashboard
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Username { get; set; }
        public string Component { get; set; }
        public string Datapoint { get; set; }
    }
}
