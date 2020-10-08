using HolocronProject.Data.Enums;
using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface IAccountService
    {
        Task Create(string accountName, string password, string displayName);

        Task CreateCharacter(string accountName, string characterName,
            int gender, int characterType, int faction,
            string className, string raceName, string serverName, int forceAffiliation);

        Task CreatePost(string accountName, string description, string threadName);

        Task CreateThread(string accountName, string title, string baseThreadTitle);
    }
}
