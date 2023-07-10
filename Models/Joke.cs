using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokeWebApp.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string jokeQuestion { get; set; }
        public string jokeAnswer { get; set; }

        public Joke()
        {

        }
    }
}
