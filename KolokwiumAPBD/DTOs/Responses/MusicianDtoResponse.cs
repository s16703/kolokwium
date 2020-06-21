using KolokwiumAPBD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumAPBD.DTOs.Responses
{
    public class MusicianDtoResponse
    {
        public int IdMusician { get; set; }
    
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Nickname { get; set; }
    }
}
