using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HolocronProject.Services
{
    public interface ICompetitionCharactersService
    {
        Task AddCharacterToCompetitionAsync(string characterId, string competitionId);

        string GetCompetitionCharactersId(string characterId, string competitionId);
    }
}
