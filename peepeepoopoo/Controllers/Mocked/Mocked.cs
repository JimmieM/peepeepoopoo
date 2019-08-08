using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using peepeepoopoo.Constants.Shop;
using peepeepoopoo.Mocked.Constants;
using peepeepoopoo.Models.Pets.Creatures;

namespace peepeepoopoo.Controllers.Mocked
{
    [Route("api/[controller]")]
    [ApiController]
    public class MockedController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var player1 = MockedPlayer.GenerateFullPlayer();
            var player2 = MockedPlayer.GenerateFullPlayer();

            // Try get Constants
            var attacks = ShopItems.GetAttacks();
            var creatures = ShopItems.GetCreatures();
            var food = ShopItems.GetFood();

            // Try give pet some attacks.
            var pet = MockedPet.Create(player1);
            pet.AddAttack(attacks[2].Item as CreatureAttack);

            // Create battle
            var battle = MockedBattle.CreateBattle(player1.Pets[0], player2.Pets[0], 30, player1.Pets[0]);

            // Create friendship
            var 

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

