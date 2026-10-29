namespace CIE_1.Models
{
    public class Event
    {
        public int EventId 
        { 
            get; set; 
        }

        public string? EventName 
        { 
            get; set; 
        }

        public int MaxParticipants 
        { 
            get; set; 
        }

        public decimal RegistrationFee 
        { 
            get; set; 
        }
    }
}