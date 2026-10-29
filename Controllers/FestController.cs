using Microsoft.AspNetCore.Mvc;

namespace CIE_1.Controllers
{
    public class FestController : Controller
    {
        static List<Participant> participants = new List<Participant>();

        // First page
        public IActionResult Welcome()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View(participants);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Participant participant)
        {
            if (ModelState.IsValid)
            {
                participant.ParticipantId = participants.Count + 1;
                participants.Add(participant);

                return RedirectToAction("Index");
            }

            return View(participant);
        }

        public IActionResult Details(int id)
        {
            var participant = participants.Find(
                x => x.ParticipantId == id);

            return View(participant);
        }
    }
}