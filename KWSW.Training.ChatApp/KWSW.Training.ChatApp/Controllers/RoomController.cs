using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KWSW.Training.CharApp.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace KWSW.Training.ChatApp.Controllers
{
    public class RoomController : Controller
    {
        public IActionResult List()
        {
            var model = new List<Room>()
            {
                new Room() {Id = 1, Name = "Room 1"},
                new Room() {Id = 2, Name = "Room 2"},
            };
            return View(model);
        }

        public IActionResult Chat(int roomId)
        {
            var model = new Room()
            {
                Name = $"Room {roomId}",
                Messages = new List<Message>()
                {
                    new Message()
                        {Id = 101, AuthorName = "Mr X", Text = "Hello from X", TimePosted = DateTime.Now.AddHours(-2)},
                    new Message()
                        {Id = 102, AuthorName = "Mr Y", Text = "Hello from Y", TimePosted = DateTime.Now.AddHours(-1)},
                    new Message()
                        {Id = 103, AuthorName = "Mr Z", Text = "Hello from Z", TimePosted = DateTime.Now.AddHours(0)},
                }
            };
            return View(model);
        }
    }
}