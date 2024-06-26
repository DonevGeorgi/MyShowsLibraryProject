﻿using Microsoft.EntityFrameworkCore;
using MyShowsLibraryProject.Infrastructure.Constants;
using System.ComponentModel.DataAnnotations;

namespace MyShowsLibraryProject.Infrastructure.Data.Models
{
    [Comment("Shows crew")]
    public class Crew
    {
        [Key]
        [Comment("Crew identifier")]
        public int CrewId { get; set; }
        [Required]
        [MaxLength(DataConstants.CrewNameMaxLength)]
        [Comment("Crew name")]
        public string Name { get; set; } = string.Empty;
        [MaxLength(DataConstants.CrewPseudonymMaxLength)]
        [Comment("Crew pseudonym")]
        public string Pseudonyms { get; set; } = string.Empty;
        [Required]
        [MaxLength(DataConstants.CrewBirthdayMaxLength)]
        [Comment("Crew birthdate")]
        public string Birthdate { get; set; } = string.Empty;
        [Required]
        [MaxLength(DataConstants.CrewNationalityMaxLength)]
        [Comment("Crew nationality")]
        public string Nationality {  get; set; } = string.Empty;
        [MaxLength(DataConstants.UrlsMaxLength)]
        [Comment("Crew picture link")]
        public string PictureUrl { get; set; } = string.Empty;
        [Required]
        [MaxLength(DataConstants.CrewBiographyMaxLength)]
        [Comment("Crew biography")]
        public string Biography { get; set; } = string.Empty;
        [MaxLength(DataConstants.UrlsMaxLength)]
        [Comment("Crew link for more biography")]
        public string MoreInfo { get; set; } = string.Empty;
        public IEnumerable<CrewRole> Roles { get; set; } = new List<CrewRole>();
        public IEnumerable<SerieCrew> SerieCrew { get; set; } = new List<SerieCrew>();
        public IEnumerable<MovieCrew> MovieCrew { get; set; } = new List<MovieCrew>();
    }
}
