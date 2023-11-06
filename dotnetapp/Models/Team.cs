using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{
    [Index(nameof("Id"),IsUnique=true)]
    public class Team{
        [Key]
        public int TeamId{get;set;}
        public int PlayerId{get;set;}
        public ICollection<Player> Player{get;set;}
        

    }
}
