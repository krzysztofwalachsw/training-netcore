using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KWSW.Training.CharApp.Contracts;
using KWSW.Training.ChatApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace KWSW.Training.ChatApp.Controllers
{
    public class ChatController : Controller
    {
        private readonly IChatService _chatService;

        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }

        public IActionResult List()
        {
            var model = _chatService.GetAll();
            return View(model);
        }

        public IActionResult Details(int chatId)
        {
            var model = _chatService.Get(chatId);
            return View(model);
        }
    }
}