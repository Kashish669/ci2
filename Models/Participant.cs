using System.ComponentModel.DataAnnotations;

namespace CIE_1.Models
{
    public class Participant
    {
        public int ParticipantId 
        { 
            get; set; 
        }

        [Required]
        public string? ParticipantName 
        { 
            get; set; 
        }

        [Required ]
        [EmailAddress]
        public string? Email 
        { 
            get; set; 
        }

        [Required]
        public string? Department 
        { 
            get; set; 
        }

        [Required]
        public string? Year 
        { 
            get; set; 
        }

        [Required]
        public string? EventName 
        { 
            get; set; 
        }

        public bool IsTeamEvent 
        { 
            get; set; 
        }
    }
}