﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.Recharge
{
    public interface IWorker
    {
        public string Id { get; }

        public int WorkingHours { get; }

        public void Work(int hours);
    }
}
