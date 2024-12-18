using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QLThuChiAPI.Connection;
using QLThuChiAPI.Data;
using QLThuChiAPI.Model.DTO;
using QLThuChiAPI.Model.Command;
using static QLThuChiAPI.Data.Connect;
using QLThuChiAPI.Utils;

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
        [HttpGet("ChiTieuNguoiDung")]
        public ActionResult<List<ChiTieu>> GetAllChiTieu([FromBody] Dictionary<string, int> data)
        {
            data.TryGetValue("UserID", out var userId);
            Constants.UserID = userId;
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
        public ActionResult<int> GetWalletAmount([FromBody] Dictionary<string, object> data)
        {
            int userId = JsonConvert.DeserializeObject<int>(data["UserID"].ToString());
            Constants.UserID = userId;
            return QLCTDAO.GetAmountWallet();
        }

        [HttpPut("Wallet")]
        public IActionResult UpdateWallet([FromBody] Dictionary<string, object> data)
        {
            int userId = JsonConvert.DeserializeObject<int>(data["UserID"].ToString());
            Constants.UserID = userId;
            int amount = JsonConvert.DeserializeObject<int>(data["amount"].ToString());
            QLCTDAO.UpdateWallet(amount);
            return Ok();
        }

        // NguoiDung Methods
        [HttpGet("GetAllUsers")]
        public ActionResult<List<QLThuChiAPI.Data.NguoiDung>> GetAllUsers()
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

        [HttpPost("NguoiDung")]
        public ActionResult<List<QLThuChiAPI.Data.NguoiDung>> GetAllNguoiDung([FromBody] Dictionary<string, object> data)
        {
            if (!data.TryGetValue("emailInput", out var emailInput) || !data.TryGetValue("passwordInput", out var passwordInput))
            {
                return BadRequest("Missing email or password");
            }
            string query = $"SELECT * FROM NguoiDung WHERE Email = '{emailInput}' AND Password = '{passwordInput}'";

            return _connect.NguoiDung(query);
        }

        [HttpPut("NguoiDung")]
        public ActionResult<List<QLThuChiAPI.Data.NguoiDung>> UpdateNguoiDung([FromBody] Dictionary<string, object> data)
        {
            int userId = JsonConvert.DeserializeObject<int>(data["UserID"].ToString());
            Constants.UserID = userId;
            string hoTen = data["HoTen"].ToString();
            string gioiTinh = data["GioiTinh"].ToString();
            DateTime ngaySinh = DateTime.Parse(data["NgaySinh"].ToString());
            string email = data["Email"].ToString();
            string diaChi = data["DiaChi"].ToString();
            string password = data["Password"].ToString();

            string message = QLCTDAO.UpdateAccount(userId, hoTen, gioiTinh, ngaySinh, email, diaChi, password);
            return Ok(message);
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

            string a = _connect.RegisterUser(hoTen, gioiTinh, ngaySinh, email, diaChi, password, confirmPassword);
            return Ok(a);
        }

        // Thu Methods
        [HttpGet("Thu")]
        public ActionResult<int> GetTotalIncomeForCategory([FromBody] Dictionary<string, object> data)
        {
            int category = Convert.ToInt32(data["Category"]);
            IncomeType incomeType = JsonConvert.DeserializeObject<IncomeType>(data["IncomeType"].ToString());
            int userId = JsonConvert.DeserializeObject<int>(data["UserID"].ToString());
            Constants.UserID = userId;

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