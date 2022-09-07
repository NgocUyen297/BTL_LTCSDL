using Microsoft.AspNetCore.Mvc;
using CuaHangVatTu.BLL;
using CuaHangVatTu.Common.Request;
using CuaHangVatTu.Common.Response;

namespace CuaHangVatTu.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VatTuController : ControllerBase
    {

        private VattuService vattuService;
        public VatTuController()
        {
            vattuService = new VattuService();
        }
        [HttpPost("search-vattu-by-name")]
        public IActionResult SearchProduct([FromBody] SearchVatTuRequest s)
        {
            var res = new SingleResponse();
            res = vattuService.SearchVatTuByName(s);
            return Ok(res);
        }

    }


}

