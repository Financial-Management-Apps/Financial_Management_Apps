using Microsoft.AspNetCore.Mvc;
using FrmManhinhchinh.Connection;
using FrmManhinhchinh.Data;
using FrmManhinhchinh.Model.Command;
using FrmManhinhchinh.Model.DTO;
using System.Collections.Generic;
using static FrmManhinhchinh.Data.Connect;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace QLThuChiAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FinanceController : ControllerBase
    {
        private readonly QLCTDAO _qlctDao;
        private readonly Connect _connect;

        public FinanceController()
        {
            _qlctDao = new QLCTDAO();
            _connect = new Connect();
        }

        // QLCTDAO Methods
        [HttpGet("ChiTieu")]
        public ActionResult<List<ChiTieu>> GetAllChiTieu()
        {
            return QLCTDAO.GetAllQLCTDAO();
        }

        [HttpPost("ChiTieu")]
        public IActionResult AddChiTieu([FromBody] Dictionary<string, object> data)
        {
            ChiTieuCreate chiTieuCreate = JsonConvert.DeserializeObject<ChiTieuCreate>(data["ChiTieuCreate"].ToString());
            QLCTDAO.AddQLCT(chiTieuCreate);
            return Ok();
        }

        [HttpDelete("ChiTieu/{id}")]
        public IActionResult DeleteChiTieu([FromBody] Dictionary<string, object> data)
        {
            int id = Convert.ToInt32(data["ID"].ToString());
            QLCTDAO.DeleteChiTieu(id);
            return Ok();
        }

        [HttpPut("ChiTieu")]
        public IActionResult UpdateChiTieu([FromBody] Dictionary<string, object> data)
        {
            ChiTieuUpdate chiTieuUpdate = JsonConvert.DeserializeObject<ChiTieuUpdate>(data["chiTieuUpdate"].ToString());
            QLCTDAO.UpdateQLCT(chiTieuUpdate);
            return Ok();
        }

        [HttpGet("Wallet")]
        public ActionResult<int> GetWalletAmount()
        {
            return QLCTDAO.GetAmountWallet();
        }

        [HttpPut("Wallet")]
        public IActionResult UpdateWallet([FromBody] Dictionary<string, object> data)
        {
            int amount = JsonConvert.DeserializeObject<int>(data["amount"].ToString());
            QLCTDAO.UpdateWallet(amount);
            return Ok();
        }

        // NguoiDung Methods
        [HttpPost("NguoiDung")]
        public ActionResult<List<FrmManhinhchinh.Data.NguoiDung>> GetAllNguoiDung([FromBody] Dictionary<string, object> data)
        {
            if (!data.TryGetValue("emailInput", out var emailInput) || !data.TryGetValue("passwordInput", out var passwordInput))
            {
                return BadRequest("Missing email or password");
            }
            string query = $"SELECT * FROM NguoiDung WHERE Email = '{emailInput}' AND Password = '{passwordInput}'";

            return _connect.NguoiDung(query);
        }

        [HttpGet("GetAllUsers")]
        [SwaggerOperation(Summary = "Get all users", Description = "Trả về danh sách tất cả người dùng từ cơ sở dữ liệu.")]
        [SwaggerResponse(200, "Thành công", typeof(List<FrmManhinhchinh.Data.NguoiDung>))]
        [SwaggerResponse(500, "Lỗi server")]
        public ActionResult<List<FrmManhinhchinh.Data.NguoiDung>> GetAllUsers()
        {
            try
            {
                string query = "SELECT * FROM NguoiDung";
                var result = _connect.NguoiDung(query);

                if (result == null || result.Count == 0)
                {
                    return NotFound("No users found in the database.");
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost("TaiKhoan")]
        public IActionResult AddNguoiDung([FromBody] Dictionary<string, object> data)
        {
            string hoTen = data["HoTen"].ToString();
            string gioiTinh = data["GioiTinh"].ToString();
            DateTime ngaySinh = DateTime.Parse(data["NgaySinh"].ToString());
            string email = data["Email"].ToString();
            string diaChi = data["DiaChi"].ToString();
            string password = data["Password"].ToString();
            string confirmPassword = data["confirmPassword"].ToString();

            _connect.RegisterUser(hoTen, gioiTinh, ngaySinh, email, diaChi, password, confirmPassword);
            return Ok();
        }

        // Thu Methods
        [HttpGet("Thu")]
        public ActionResult<int> GetTotalIncomeForCategory([FromBody] Dictionary<string, object> data)
        {
            int category = Convert.ToInt32(data["Category"]);
            IncomeType incomeType = JsonConvert.DeserializeObject<IncomeType>(data["IncomeType"].ToString());

            return _connect.GetTotalIncomeForCategory(category, incomeType);
        }

        // Chi Methods
        [HttpGet("Chi")]
        public ActionResult<List<CategoryExpense>> GetTotalExpenseByCategory()
        {
            return _connect.GetTotalExpenseByCategory();
        }
    }
} 