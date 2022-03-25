﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Streamy.Infrastructure.Models
{
    public class SongArtist
    {
        [ForeignKey(nameof(Song))]
        public Guid SongId { get; set; }

        public virtual Song Song { get; set; }

       
        [ForeignKey(nameof(Artist))]
        public Guid ArtistId { get; set; }

        public virtual Artist Artist { get; set; }
    }
}