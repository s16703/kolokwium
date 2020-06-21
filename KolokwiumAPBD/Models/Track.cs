using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KolokwiumAPBD.Models
{
    public class Track
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTrack { get; set; }
        public int IdMusicAlbum { get; set; }
        [MaxLength(20)]
        public string TrackName { get; set; }
        public float Duration { get; set; }

        [ForeignKey("IdMusicAlbum")]
        public virtual Album Album { get; set; }

    }
}
