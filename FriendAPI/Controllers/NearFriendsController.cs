using Friends.Engine;
using Friends.Engine.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace FriendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NearFriendsController : ControllerBase
    {
        private ConnectionStrings settings;

        public NearFriendsController(IOptions<ConnectionStrings> settings)
        {
            this.settings = settings.Value;
        }

        // GET: api/NearFriends
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/NearFriends/5
        [HttpGet("{id}")]
        public List<Friend> Get(int id)
        {
            return new Facade(settings).GetNearFriends(id);
        }

        // POST: api/NearFriends
        [HttpPost]
        public void Post(Friend value)
        {
            new Facade(settings).SetNearFriends(value);
        }

        // PUT: api/NearFriends/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
