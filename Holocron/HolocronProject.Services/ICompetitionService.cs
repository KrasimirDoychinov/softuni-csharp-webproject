using HolocronProject.Data.Models;
using HolocronProject.Services.ViewModelsTemp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface ICompetitionService
    {
        Task CreateCompetition(string title, string description, DateTime startDate, DateTime endDate);

        Competition GetCompetitionById(string competitionId);
    }
}
