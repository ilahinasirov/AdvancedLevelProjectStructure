using Business.Abstract;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestViewController : ControllerBase
    {
        ITestViewService _testViewService;

        public TestViewController(ITestViewService testViewService)
        {
            _testViewService = testViewService;
        }

        [HttpGet("getview")]
        public IActionResult GetAllView()
        {
            var result = _testViewService.GetViewList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
    }
}
