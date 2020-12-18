using HolocronProject.Services;
using HolocronProject.Web.Areas.Administration.Controllers;
using HolocronProject.Web.ViewModels.Admins;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.Controllers
{
    public class AdminsController : BaseAdminController
    {
        private readonly ICharactersService charactersService;
        private readonly IAccountsService accountsService;
        private readonly IPostsService postsService;
        private readonly IThreadsService threadsService;
        private readonly IBugReportsService bugReportsService;
        private readonly IPostReportsService postReportsService;

        public AdminsController(ICharactersService charactersService,
            IAccountsService accountsService,
            IPostsService postsService,
            IThreadsService threadsService,
            IBugReportsService bugReportsService,
            IPostReportsService postReportsService)
        {
            this.charactersService = charactersService;
            this.accountsService = accountsService;
            this.postsService = postsService;
            this.threadsService = threadsService;
            this.bugReportsService = bugReportsService;
            this.postReportsService = postReportsService;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Panel()
        {
            var panelViewModel = new PanelViewModel();

            panelViewModel.TotalAccounts = this.accountsService.TotalAccounts();
            panelViewModel.TotalCharacters = this.charactersService.TotalApprovedCharacters();
            panelViewModel.TotalPosts = this.postsService.TotalNotDeletedPosts();
            panelViewModel.TotalThreads = this.threadsService.TotalNotDeletedThreads();
            panelViewModel.TotalUnresolvedBugReports = this.bugReportsService.TotalUnresolvedBugReports();
            panelViewModel.TotalUnresolvedPostReports = this.postReportsService.TotalUnresolvedPostReports();
            panelViewModel.TotalPendingCharacters = this.charactersService.TotalPendingCharacters();

            return this.View(panelViewModel);
        }
    }
}
