﻿namespace Demo03_Versioning_2.Models.DTOs
{
    public class CountryDtoV1
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class CountryDtoV2
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
    }
}