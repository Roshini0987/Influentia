using Influentia.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Influentia.Api.Controllers.AccountManagementModule
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefectsController : ControllerBase
    {
        private readonly IDefectsService defectsService;

        public DefectsController(IDefectsService defectsService)
        {
            this.defectsService = defectsService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await this.defectsService.GetMessage();
            return Ok(response);
        }
    }
}
