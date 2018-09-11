﻿namespace dotnet_code_challenge.Models
{
    public class Horse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Order { get; set; }
        public RaceType Race { get; set; }
    }
}
