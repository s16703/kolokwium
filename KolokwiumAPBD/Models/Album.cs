using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KolokwiumAPBD.Models
{
    public class Album
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdAlbum { get; set; }

        [MaxLength(200)]
        [Required]
        public string AlbumName { get; set; }
        public DateTime PublishDate { get; set; }

        public int IdMusicLabel { get; set; }

        [ForeignKey("IdMusicLabel")]
        public virtual MusicLabel MusicLabel { get; set; }

        public virtual ICollection<Track> Track { get; set; }
    }
}
