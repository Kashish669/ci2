using CIE_1.Models;

namespace CIE_1.Extensions
{
    public static class ParticipantExtensions
    {
        public static string GetRegistrationStatus(this Participant p)
        {
            if (!string.IsNullOrEmpty(p.ParticipantName))
                return "Confirmed";

            return "Pending";
        }

        public static string GetFeeCategory(this Participant p)
        {
            if (p.EventName == "Quiz")
                return "Free Event";

            if (p.EventName == "Coding")
                return "Standard Event";

            return "Premium Event";
        }
    }
}