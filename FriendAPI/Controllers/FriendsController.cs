using Friends.Engine;
using Friends.Engine.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace FriendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendsController : ControllerBase
    {
        private ConnectionStrings settings;

        public FriendsController(IOptions<ConnectionStrings> settings)
        {
            this.settings = settings.Value;
        }

        // GET: api/Friends
        [HttpGet]
        public List<Friend> Get()
        {
            return new Facade(settings).GetFriendList();
        }

        // GET: api/Friends/5
        [HttpGet("{id}")]
        public Friend Get(int id)
        {
            return new Facade(settings).GetFriend(id);
        }

        // POST: api/Friends
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Friends/5
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
