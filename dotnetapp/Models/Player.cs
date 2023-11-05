// Models/Player.cs
using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{
    [Index(nameof("Id"),IsUnique=true)]
    public class Player{
        public int Id{get;set;}
        [Required(ErrorMessage="name cannot be Blank")]
        public string Name{get;set;}
        
        public string Category{get;set;}
        
        public decimal BiddingPrice{get;set;}
        

    }
}
