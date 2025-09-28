using System;

namespace MathLibrary
{
    public class NumberChecks
    {
        // Hàm kiểm tra số chính phương
        public static bool IsPerfectSquare(long n)
        {
            if (n < 0) return false; // Số âm không phải số chính phương
            long t = (long)Math.Sqrt(n); // Lấy căn bậc hai (làm tròn xuống)
            return t * t == n; // Kiểm tra bình phương lại có bằng n không
        }
    }
}
