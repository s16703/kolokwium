using KolokwiumAPBD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumAPBD.Services
{
    public interface IDbServices
    {
        public Task<Musician> GetMusician(int id);
        public Task<Track> GetTrack(int id);
        public Task AddMusician(string FirstName, string LastName, string NickName);
    }
}
