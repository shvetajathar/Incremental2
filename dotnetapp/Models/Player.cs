// Models/Player.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotnetapp.Models
{
    
    public class Player{
        [Key]
        public int Id{get;set;}
        [Required(ErrorMessage="name cannot be Blank")]
        public string Name{get;set;}
        
        public string Category{get;set;}
        [Range(1,int.MaxValue,ErrorMessage ="BiddingAmount should be positive")]
        
        public decimal BiddingAmount{get;set;}
        // [ForeignKey("Team")]
        // public int TeamId{get;set;}
        
        public Team Team{get;set;}
    }
}
