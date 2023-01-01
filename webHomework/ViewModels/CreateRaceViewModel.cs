﻿using webHomework.Data.Enum;
using webHomework.Models;

namespace webHomework.ViewModels
{
    public class CreateRaceViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Address Address { get; set; }

        public IFormFile Image { get; set; }

        public RaceCategory RaceCategory { get; set; }
        public string AppUserId { get; set; }
    }
}
