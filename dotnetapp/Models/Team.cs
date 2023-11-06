using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetapp.Models
{
    
    public class Team{
        [Key]
        public int TeamId{get;set;}
        [ForeignKey("Player")]
        public int PlayerId{get;set;}
        public ICollection<Player> Player{get;set;}
        

    }
}
