using Microsoft.AspNetCore.Mvc;
using CuaHangVatTu.BLL;
using CuaHangVatTu.Common.Request;
using CuaHangVatTu.Common.Response;

namespace CuaHangVatTu.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonDHController : ControllerBase
    {
        private DonDHService donDHService;
        public DonDHController()
        {
            donDHService = new DonDHService();
        }
        [HttpPost("Tim-DonDH-by-SoDH")]
        public IActionResult SearchProduct([FromBody] int Sopx)
        {
            var res = new SingleResponse();
            res = donDHService.SearchDonDHBySoDH(Sopx);
            return Ok(res);
        }
    }
}
