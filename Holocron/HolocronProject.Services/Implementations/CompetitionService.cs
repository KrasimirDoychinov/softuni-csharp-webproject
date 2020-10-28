using HolocronProject.Data;
using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services.Implementations
{
    public class CompetitionService : ICompetitionService
    {
        private readonly HolocronDbContext context;

        public CompetitionService(HolocronDbContext context)
        {
            this.context = context;
        }


        public async Task CreateCompetition(string title, string description, DateTime startDate, DateTime endDate)
        {
            var competition = new Competition
            {
                Title = title,
                Description = description,
                StartDate = startDate,
                EndDate = endDate
            };

            await this.context.Competitions.AddAsync(competition);
            await this.context.SaveChangesAsync();
        }

        public Competition GetCompetitionById(string competitionId)
            => this.context.Competitions.FirstOrDefault(x => x.Id == competitionId);
    }
}
