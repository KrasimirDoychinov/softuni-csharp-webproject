﻿using HolocronProject.Data.Models;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface IBaseThreadService 
    {
        // Admin services
        Task CreateNewBaseThread(string title);

        BaseThread GetBaseThreadByName(string title);
    }
}
