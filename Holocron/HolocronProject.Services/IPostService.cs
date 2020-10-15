﻿using HolocronProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Services
{
    public interface IPostService
    {
        IEnumerable<Post> GetPostByDescription(string description);
    }
}
