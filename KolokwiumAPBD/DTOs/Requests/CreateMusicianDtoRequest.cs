using KolokwiumAPBD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumAPBD.DTOs.Requests
{
    public class TrackDtoRequest
    {
        public string Track { get; set; }
    }

    public class CreateMusicianDtoRequest
    {
        public CreateMusicianDtoRequest()
        {
            Track = new HashSet<TrackDtoRequest>();
        }
        public ICollection<TrackDtoRequest> Tracks { get; set; }
        public HashSet<TrackDtoRequest> Track { get; }
    }
}
