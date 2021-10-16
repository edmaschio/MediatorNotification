using MediatorNotification.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MediatorNotification.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotifyController : ControllerBase
    {
        private readonly INotifierMediatorService _notifierService;

        public NotifyController(INotifierMediatorService notifierService)
        {
            _notifierService = notifierService;
        }

        // GET: api/<NotifyController>
        [HttpGet("")]
        public async Task<IActionResult> NotifyAll(CancellationToken ct)
        {
            await _notifierService.NotifyAsync("Esta é uma notificação", ct);
            return Ok();
        }
    }
}
