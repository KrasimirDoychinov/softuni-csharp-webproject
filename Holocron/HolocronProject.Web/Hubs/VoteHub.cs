using HolocronProject.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Hubs
{
    [Authorize]
    public class VoteHub : Hub
    {
        private readonly ICompetitionAccountsService competitionAccountsService;
        private readonly ICompetitionCharactersService competitionCharactersService;

        public VoteHub(ICompetitionAccountsService competitionAccountsService,
            ICompetitionCharactersService competitionCharactersService)
        {
            this.competitionAccountsService = competitionAccountsService;
            this.competitionCharactersService = competitionCharactersService;
        }

        public async Task Vote(string competitionId, string accountId, string characterId, int voteNumber)
        {
            await this.competitionAccountsService.VoteAsync(characterId, competitionId, accountId);
            var voteCount = this.competitionCharactersService.GetVotesCount(characterId, competitionId);

            await this.Clients.All.SendAsync("Vote", voteCount, voteNumber);

        }

        public async Task UnVote(string competitionId, string accountId)
        {
            var characterId = this.competitionAccountsService.GetCompetitionCharacterCharacterId(competitionId, accountId);
            await this.competitionAccountsService.UnVoteAsync(competitionId, accountId);

            var voteCount = this.competitionCharactersService.GetVotesCount(characterId, competitionId);

            await this.Clients.All.SendAsync("Unvote", voteCount, characterId);

        }
    }
}
