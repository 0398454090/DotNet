using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace BookLibrary.Helper
{
    public static class Utilities
    {
        // Thay đổi độ truy cập của hàm IsValidEmail thành public
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || email.Trim().EndsWith("."))
            {
                return false;
            }

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email; // Trả về true nếu địa chỉ email hợp lệ
            }
            catch
            {
                return false; // Nếu có lỗi, trả về false
            }
        }

        // Các phương thức khác không thay đổi
        public static int PAGE_SIZE = 20;

        // Hàm tạo thư mục nếu nó không tồn tại
        public static void CreateIfMissing(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public static string ToTitleCase(string str)
        {
            string result = str;
            if (!string.IsNullOrEmpty(str))
            {
                var words = str.Split(' '); // Phân tách bằng khoảng trắng
                for (int index = 0; index < words.Length; index++)
                {
                    var s = words[index];
                    if (s.Length > 0)
                    {
                        words[index] = char.ToUpper(s[0]) + s.Substring(1).ToLower(); // Đưa chữ thường về sau
                    }
                }
                result = string.Join(" ", words); // Thay đổi dấu phân cách thành khoảng trắng
            }
            return result;
        }

        public static string GetRandomKey(int length = 5)
        {
            // Chuỗi mẫu (pattern)
            string pattern = @"0123456789zxcvbnmasdfghjklqwertyuiop[]{}:~!@#$%^&*()+";
            Random rd = new Random();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                sb.Append(pattern[rd.Next(0, pattern.Length)]);
            }

            return sb.ToString(); // Trả về chuỗi được tạo
        }

        public static string SEOUrl(string url)
        {
            // Chuyển đổi thành chữ thường
            url = url.ToLower();

            // Thay thế các ký tự có dấu bằng ký tự không dấu
            url = Regex.Replace(url, @"[áàảãạâấầẩẫậăắằẳẵặ]", "a");
            url = Regex.Replace(url, @"[éèẻẽẹêếềểễệ]", "e");
            url = Regex.Replace(url, @"[íìỉĩị]", "i");
            url = Regex.Replace(url, @"[óòỏõọôốồổỗộơớờởỡợ]", "o");
            url = Regex.Replace(url, @"[úùủũụưứừửữự]", "u");
            url = Regex.Replace(url, @"[ýỳỷỹỵ]", "y");
            url = Regex.Replace(url, @"[đ]", "d");

            // Chỉ cho phép nhận: [0-9a-z-\s]
            url = Regex.Replace(url.Trim(), @"[^0-9a-z-\s]", "").Trim();

            // Xử lý nhiều hơn 1 khoảng trắng thành 1 ký tự
            url = Regex.Replace(url, @"\s+", "-");

            // Xóa bỏ các dấu '-' liên tiếp
            while (url.Contains("--"))
            {
                url = url.Replace("--", "-");
            }

            return url; // Trả về URL đã được xử lý
        }

        public static async Task<string> UploadFile(Microsoft.AspNetCore.Http.IFormFile file, string sDirectory, string newname = null)
        {
            try
            {
                if (newname == null) newname = file.FileName;

                // Đường dẫn tới thư mục lưu trữ
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "assets", sDirectory);
                CreateIfMissing(path);

                // Đường dẫn đầy đủ tới file sẽ được lưu
                string pathFile = Path.Combine(path, newname);

                // Các định dạng file được hỗ trợ
                var supportedTypes = new[] { "jpg", "jpeg", "png", "gif" };
                var fileExt = Path.GetExtension(file.FileName).Substring(1);

                // Kiểm tra định dạng file
                if (!supportedTypes.Contains(fileExt.ToLower()))
                {
                    return null; // Trả về null nếu định dạng không hợp lệ
                }

                // Lưu file vào thư mục
                using (var stream = new FileStream(pathFile, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                return newname; // Trả về tên file đã lưu
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                Console.WriteLine($"Error uploading file: {ex.Message}");
                return null; // Trả về null trong trường hợp có lỗi
            }
        }
    }
}
