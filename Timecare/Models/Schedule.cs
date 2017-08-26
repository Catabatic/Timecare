﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Timecare.Models
{
    public abstract class Schedule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

    }
}