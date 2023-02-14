using dotnetflix.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetflix.Data
{
    public class Dbdotnetflix : DbContext
    {
        public Dbdotnetflix(DbContextOptions<Dbdotnetflix> options) : base(options) { }


    }
}

