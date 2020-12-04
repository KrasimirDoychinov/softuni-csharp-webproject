using HolocronProject.Services.Models.Character;
using System;
using System.Collections.Generic;
using System.Text;

namespace HolocronProject.Services.Models.Characters
{
    public class CharacterEditDto : CharacterInputDto
    {
        public string Id { get; set; }
    }
}
