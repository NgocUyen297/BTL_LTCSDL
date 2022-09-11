using Microsoft.AspNetCore.Mvc;
using CuaHangVatTu.BLL;
using CuaHangVatTu.Common.Request;
using CuaHangVatTu.Common.Response;

namespace CuaHangVatTu.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhieuXuatController : ControllerBase
    {
        private PhieuXuatService phieuXuatService;
        public PhieuXuatController()
        {
            phieuXuatService = new PhieuXuatService();
        }
        [HttpPost("Tim-PhieuXuat-by-Sopx")]
        public IActionResult SearchProduct([FromBody] SearchPhieuXuatRequest Sopx)
        {
            var res = new SingleResponse();
            res = phieuXuatService.SearchPhieuXuatBySoPX(Sopx);
            return Ok(res);
        }

    }
}
