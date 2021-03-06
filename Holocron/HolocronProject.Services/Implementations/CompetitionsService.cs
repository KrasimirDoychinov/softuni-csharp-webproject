﻿using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

using AutoMapper;

using HolocronProject.Data;
using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;

namespace HolocronProject.Services.Implementations
{
    public class CompetitionsService : ICompetitionsService
    {
        private readonly ApplicationDbContext context;
        private readonly IAchievementsService achievementService;
        private readonly ICompetitionCharactersService competitionCharactersService;

        public CompetitionsService(ApplicationDbContext context,
            IAchievementsService achievementService,
            ICompetitionCharactersService competitionCharactersService)
        {
            this.context = context;
            this.achievementService = achievementService;
            this.competitionCharactersService = competitionCharactersService;
        }


        public async Task<string> CreateCompetitionAsync(string title, string description, DateTime startDate, DateTime endDate)
        {
            var achievements = this.achievementService.CreateAchievement(title);

            var competition = new Competition
            {
                Title = title,
                Description = description,
                StartDate = startDate,
                EndDate = endDate,
                Achievements = achievements.ToList()
            };

            await this.context.Competitions.AddAsync(competition);
            await this.context.SaveChangesAsync();

            return competition.Id;
        }

        public async Task FinishCompetitionAsync(string competitionId)
        {
            var competition = GetCompetitionById(competitionId);

            competition.IsFinished = true;
            competition.FinishedOn = DateTime.UtcNow;

            var winners = competition.Characters
                .OrderByDescending(x => x.Votes)
                .Take(3)
                .ToList();

            var firstPlaceAchievement = competition.Achievements.FirstOrDefault(x => x.Name.Contains("First place"));
            var secondPlaceAchievement = competition.Achievements.FirstOrDefault(x => x.Name.Contains("Second place"));
            var thirdPlaceAchievement = competition.Achievements.FirstOrDefault(x => x.Name.Contains("Third place"));

            if (winners.Count() >= 1)
            {
                var firstPlaceWinner = winners[0].Character;
                firstPlaceWinner.Achievements.Add(firstPlaceAchievement);
            }

            if (winners.Count() >= 2)
            {
                var secondPlaceWinner = winners[1].Character;
                secondPlaceWinner.Achievements.Add(secondPlaceAchievement);
            }

            if (winners.Count() >= 3)
            {
                var thirdPlaceWinner = winners[2].Character;
                thirdPlaceWinner.Achievements.Add(thirdPlaceAchievement);
            }

            await this.context.SaveChangesAsync();
        }

        public Competition GetCompetitionById(string competitionId)
        {
            var competition = this.context.Competitions
             .FirstOrDefault(x => x.Id == competitionId);

            competition.Characters = this.competitionCharactersService.GetAllNotDeletedCharacters(competitionId).ToList();

            return competition;
        }

        public IEnumerable<T> GetAllOngoing<T>(IMapper mapper = null)
            => this.context.Competitions
            .Where(x => !x.IsFinished)
            .To<T>(mapper)
            .ToList();

        public IEnumerable<T> GetAllFinished<T>(IMapper mapper = null)
            => this.context.Competitions
            .Where(x => x.IsFinished && x.Characters.Count() > 0)
            .To<T>(mapper)
            .ToList();
        public T GetCompetitionByIdGeneric<T>(string competitionId, IMapper mapper = null)
            => this.context.Competitions
            .Where(x => x.Id == competitionId)
            .To<T>(mapper)
            .FirstOrDefault();

        public int GetCharactersSignedUp(string competitionId)
            => this.context.Competitions
            .FirstOrDefault(x => x.Id == competitionId)
            .Characters.Count();

        public string GetWinner(string competitionId)
        {
            var competition = this.context.Competitions
                .FirstOrDefault(x => x.Id == competitionId);

            if (competition.Characters.Count() <= 0)
            {
                throw new ArgumentNullException($"There are no characters in competition with ID {competitionId}");
            }
            
            return competition.Characters
                .OrderByDescending(x => x.Votes)
                .FirstOrDefault()
                .Character.Name;
        }
    }
}
