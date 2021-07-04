using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Jokes.Models
{
    public class Joke
    {
        public int Id { get; set; }

        [Required] // Makes field non nullable
        [DisplayName("Joke Question")] // Displays " "'s in the Web Labels
        public string JokeQuestion { get; set; }

        [Required]
        [DisplayName("Joke Answer")]
        public string JokeAnswer { get; set; }

        [Required]
        [DisplayName("Joke Creator")]
        public string JokeCreator { get; set; }

        public Joke()
        {

        }
    }
}
