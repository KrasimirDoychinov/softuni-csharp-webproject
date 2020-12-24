﻿using HolocronProject.Data.Models;
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

        IEnumerable<T> GetAll<T>();

        IEnumerable<T> GetAllFinished<T>();

        T GetCompetitionByIdGeneric<T>(string competitionId);

        string GetWinner(string competitionId);

        int GetCharactersSignedId(string competitionId);
    }
}
