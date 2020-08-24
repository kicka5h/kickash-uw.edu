using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Rest.Service.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rest.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public static List<User> users = new List<User>();
        private IUserRepository userRepository;

        public UsersController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;

            // constructor gets called on EVERY request
        }

        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<User> GetUsers(string fields = null)
        {
            return userRepository.Users;
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return userRepository.Get(id);
        }

        /// <summary>
        /// This is a post message
        /// </summary>
        /// <param name="value">with a value parameter</param>
        /// <returns>an httpresponsemessage object</returns>
        // POST: api/Contacts
        [HttpPost]
        public HttpResponseMessage Post([FromBody] User value)
        {
            if (value == null)
            {
                return new HttpResponseMessage();
            }

            userRepository.Save(value);

            var result = new { Id = value.Id, Candy = true };

            var newJson = JsonConvert.SerializeObject(result);

            var postContent = new StringContent(newJson, System.Text.Encoding.UTF8, "application/json");

            return new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.Created,
                Content = postContent
            };
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
