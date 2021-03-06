﻿using System.Linq;

using NUnit.Framework;

using HolocronProject.Services.Implementations;

namespace HolocronProject.Tests.Services
{
    public class AchievementsServiceTests
    {
        [Test]
        public void CreateAchievementsShouldReturnListWithThreeEntities()
        {
            var achievementsService = new AchievementsService();

            var achievements = achievementsService.CreateAchievement("Test").ToList();

            Assert.AreEqual(achievements[0].Name, "First place - Test");
            Assert.AreEqual(achievements[1].Name, "Second place - Test");
            Assert.AreEqual(achievements[2].Name, "Third place - Test");
        }
    }
}
