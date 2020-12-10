﻿using HolocronProject.Data.Models;
using HolocronProject.Services.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolocronProject.Web.ViewModels.Competitions
{
    public class CompetitionListViewModel : IMapFrom<Competition>
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string ShortTitle => this.Title.Length <= 50 ? this.Title : this.Title.Substring(0, 50) + "...";

        public string Description { get; set; }

        public string ShortDescription => this.Description.Length <= 75 ? this.Description : this.Description.Substring(0, 75) + "...";

        public DateTime StartDate { get; set; }

        public string NormalizedStartDate => this.StartDate.ToString("MM/dd/yyyy h:mm tt");

        public DateTime EndDate { get; set; }

        public string NormalizedEndDate => this.EndDate.ToString("MM/dd/yyyy h:mm tt");

        public Pager.Pager Pager { get; set; }
    }
}
