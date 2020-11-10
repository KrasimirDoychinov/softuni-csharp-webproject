using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface ICompetitionService
    {
        Task CreateCompetitionAsync(string title, string description, DateTime startDate, DateTime endDate);

        Task FinishCompetitionAsync(string competitionId);

        Competition GetCompetitionById(string competitionId);
    }
}
