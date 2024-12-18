using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ktra1.Attributes
{
    public class AuthorizeAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var maSV = context.HttpContext.Session.GetString("MaSV");
            if (string.IsNullOrEmpty(maSV))
            {
                // Chuyển hướng đến trang đăng nhập nếu không có session "MaSV"
                context.Result = new RedirectToActionResult("DangNhap", "NguoiDung", null);
            }
        }
    }
}
