using Microsoft.AspNetCore.Mvc;
using CuaHangVatTu.BLL;
using CuaHangVatTu.Common.Request;
using CuaHangVatTu.Common.Response;

namespace CuaHangVatTu.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhieuNhapController : ControllerBase
    {
        private PhieuNhapService phieuNhapService;
        public PhieuNhapController()
        {
            phieuNhapService = new PhieuNhapService();
        }
        [HttpPost("Tim-PhieuNhap-by-Sopn")]
        public IActionResult SearchProduct([FromBody] int Sopn)
        {
            var res = new SingleResponse();
            res = phieuNhapService.SearchPhieuNhapBySoPX(Sopn);
            return Ok(res);
        }
    }
}
