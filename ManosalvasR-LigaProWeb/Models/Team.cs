using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace ManosalvasR_LigaProWeb.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [DisplayName("Team Name: ")]
        [Required]
        [AllowNull]
        public string Name { get; set; }
        [Range(0, 20)]
        public int PlayedGames { get; set; }
        [Range(0, 20)]
        public int WonGames { get; set; }
        [Range(0, 20)]
        public int LostGames { get; set; }
        [Range(0, 20)]
        public int TiedGames { get; set; }

        public int Points
        {
            get
            {
                return (WonGames * 3) + TiedGames * 1;
            }
        }


    }
}
