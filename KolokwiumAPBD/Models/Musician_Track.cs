﻿using Microsoft.AspNetCore.Mvc.ViewEngines;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumAPBD.Models
{
    public class Musician_Track
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdMusicianTrack { get; set; }
        public int IdTrack { get; set; }
        public int IdMusician { get; set; }
    
        [ForeignKey("IdTrack")]
        public virtual Track Track { get; set; }
        
        [ForeignKey("IdMusician")]
        public virtual Musician Musician { get; set; }
    }
}
