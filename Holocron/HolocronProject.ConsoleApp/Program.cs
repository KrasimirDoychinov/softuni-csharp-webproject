﻿using HolocronProject.Data;
using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var context = new HolocronDbContext();

            var accounts = context.Accounts.FirstOrDefault();

        }
    }
}
