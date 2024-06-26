﻿namespace AroundFootballService.Data.Models
{
    public class Region
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<Team> Teams { get; set; }
    }
}
