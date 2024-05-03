using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProtectedApi.Presentation.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ValueController : ControllerBase
    {

        [HttpGet("about/me")]
        public IActionResult GetAboutMe()
        {
            var randomInfo = GenerateRandomInfo();

            return Ok(randomInfo);
        }

        [HttpGet("about")]
        public IActionResult GetAbout()
        {

            string creatorName = "Gabriel Angelo Salazar";
            return Ok(new { CreatorName = creatorName });
        }

        [HttpPost("about")]
        public IActionResult PostAbout([FromBody] string name)
        {

            string ownerName = "Gabriel Salazar";

            string greetingMessage = $"Hi {name} from {ownerName}";
            return Ok(new { Message = greetingMessage });
        }

        private string GenerateRandomInfo()
        {
            string randomInfo = "Did you know Vilgax is an intergalactic alien warlord and conqueror, a Chimera Sui Generis who serves as Ben's archenemy with a super duper thick neck even four arms can't choke him";
            return randomInfo;
        }

        [HttpGet("userinfo")]
        public IActionResult GetUserInfo()
        {
            var name = User.FindFirstValue(ClaimTypes.Name);
            var section = "32A1";
            var course = "BSIT"; 


            var userInfo = new
            {
                Name = name,
                Section = section,
                Course = course
            };

            return Ok(userInfo);
        }

        [HttpGet("funfacts")]
        public IActionResult GetFunFacts()
        {
            
            var funFacts = new List<string>
            {
                "My name is Gabriel Angelo Salazar.",
                "I am a coffee enthusiast.",
                "I don't know how to play musical instruments.",
                "I am an avid reader.",
                "I am tired",
                "I am worn out",
                "I am exhuasted",
                "I am drowsy",
                "I am weary",
                "I am frazzled",

            };

            return Ok(funFacts);
        }
    }
}
