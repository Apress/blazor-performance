using System.Collections.Generic;
using System.Threading.Tasks;

namespace UsingKey.Services
{
  public class Trainer
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string PictureUrl { get; set; }

    public string Likes { get; set; }
  }

  public class TrainerService
  {
    //private readonly List<Trainer> trainers = new List<Trainer>
    //  {
    //    new Trainer { 
    //      Id = 1, 
    //      Name = "Lander", 
    //      PictureUrl = "https://randomuser.me/api/portraits/men/39.jpg",
    //      Likes = "play music"
    //    },
    //    new Trainer { 
    //      Id = 2, 
    //      Name = "Anniek", 
    //      PictureUrl = "https://randomuser.me/api/portraits/women/34.jpg",
    //    Likes = "dance"
    //    },
    //    new Trainer { 
    //      Id = 3, 
    //      Name = "Tommy", 
    //      PictureUrl = "https://randomuser.me/api/portraits/men/31.jpg",
    //      Likes = "eat out"
    //    },
    //    new Trainer { 
    //      Id = 4, 
    //      Name = "Bram", 
    //      PictureUrl = "https://randomuser.me/api/portraits/men/32.jpg",
    //      Likes = "tinker with his motorcycle"
    //    }
    //  };

    public ValueTask<List<Trainer>> GetTrainers()
    {
      List<Trainer> trainers = new List<Trainer>
      {
        new Trainer {
          Id = 1,
          Name = "Lander",
          PictureUrl = "https://randomuser.me/api/portraits/men/39.jpg",
          Likes = "play music"
        },
        new Trainer {
          Id = 2,
          Name = "Anniek",
          PictureUrl = "https://randomuser.me/api/portraits/women/34.jpg",
        Likes = "dance"
        },
        new Trainer {
          Id = 3,
          Name = "Tommy",
          PictureUrl = "https://randomuser.me/api/portraits/men/31.jpg",
          Likes = "eat out"
        },
        new Trainer {
          Id = 4,
          Name = "Bram",
          PictureUrl = "https://randomuser.me/api/portraits/men/32.jpg",
          Likes = "fly"
        }
      };
      return new ValueTask<List<Trainer>>(trainers);
    }
  }
}
