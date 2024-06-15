using Gift_server.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gift_server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class GiftsController : ControllerBase
    {
        // GET: api/<GiftsController>
        [HttpGet]
        public List<Gift> Get()
        {
            return GiftsList.getGifts();
        }

        // GET api/<GiftsController>/5
        [HttpGet("{id}")]
        public Gift Get(int id)
        {
            return GiftsList.getGiftById(id);
        }

        // POST api/<GiftsController>
        [HttpPost]
        public void Post([FromBody] Gift g )
        {
             GiftsList.addGift(g);
        }

        // PUT api/<GiftsController>/5
        [HttpPut("{id}")]
        public void Put(Gift giftToUpdate)
        {
            GiftsList.updateGift(giftToUpdate);
        }

        // DELETE api/<GiftsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            GiftsList.deleteGift(id);
        }
    }
}
