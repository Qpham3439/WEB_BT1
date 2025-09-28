using System;
using System.Web;
using System.Web.Script.Serialization;
using MathLibrary;

namespace WebApp_CheckSquare
{
    public partial class api : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.ContentType = "application/json";
            Response.Charset = "utf-8";

            string input = Request.QueryString["number"];
            var js = new JavaScriptSerializer();

            if (string.IsNullOrEmpty(input))
            {
                Response.Write(js.Serialize(new { success = false, message = "Không có dữ liệu" }));
                Response.End();
                return;
            }

            if (!long.TryParse(input, out long n))
            {
                Response.Write(js.Serialize(new { success = false, message = "Vui lòng nhập số hợp lệ!" }));
                Response.End();
                return;
            }

            bool isSquare = NumberChecks.IsPerfectSquare(n);
            string msg = isSquare ? $"{n} là số chính phương." : $"{n} không phải là số chính phương.";
            Response.Write(js.Serialize(new { success = true, message = msg }));
            Response.End();

        }
    }
}
