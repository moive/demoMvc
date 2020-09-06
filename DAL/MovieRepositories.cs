using demoMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demoMvc.DAL
{
    public class MovieRepositories
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie()
                {
                    Title = "Pete's Dragon",
                    IsOnTheBillboard = true,
                    Gender = "Fantasy"
                },
                new Movie()
                {
                    Title = "Mechanic: Resurrection",
                    IsOnTheBillboard = true,
                    Gender = "Action"
                },
                new Movie()
                {
                    Title = "Deadpool",
                    IsOnTheBillboard = false,
                    Gender = "Action"
                },
            };
        }
    }
}