﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.WebApplication.Entities
{
    public class Team
    {
        public string FullName { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string? Twitter { get; set; } 
        public string? Linkedin { get; set; } 
        public string? Facebook { get; set; } 
        public string? Instagram { get; set; } 
    }
}
