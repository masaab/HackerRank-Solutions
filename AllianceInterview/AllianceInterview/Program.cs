﻿using AllianceInterview.Domain;
using AllianceInterview.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllianceInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("ss", "dd", new Address("ss", "ss", "ss", "ff"));
            p.Save();
        }
    }
}
