﻿using AutoMapper;
using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface ICompetitionsService
    {
        Task<string> CreateCompetitionAsync(string title, string description, DateTime startDate, DateTime endDate);

        Task FinishCompetitionAsync(string competitionId);

        Competition GetCompetitionById(string competitionId);

        IEnumerable<T> GetAllOngoing<T>(IMapper mapper = null);

        IEnumerable<T> GetAllFinished<T>(IMapper mapper = null);

        T GetCompetitionByIdGeneric<T>(string competitionId, IMapper mapper = null);

        string GetWinner(string competitionId);

        int GetCharactersSignedUp(string competitionId);
    }
}
