﻿using System.ComponentModel.DataAnnotations;

namespace BDSA2016.Lecture10.Entities
{
    public class Album
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        public int? ArtistId { get; set; }

        public virtual Artist Artist { get; set; }

        public int? Year { get; set; }

        public byte[] Cover { get; set; }
    }
}