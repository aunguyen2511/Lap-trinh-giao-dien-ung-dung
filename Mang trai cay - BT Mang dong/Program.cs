/*Mảng động, dùng để nhập chuỗi mà không cần phải lo về capacity - "sức chứa" 
của mảng vì nó tự co giãn.
DƯỚI ĐÂY LÀ VÍ DỤ VỀ:
Nhập tên các loại trái cây, dừng khi không nhập nữa hoặc stop

CÁCH LÀM NÀY CÒN CÓ THỂ ÁP DỤNG VÀO: tên người, địa điểm, địa danh hoặc thậm chí là số liệu...
Thông qua bài tập này có thể thấy mảng động không chỉ có phép nhập xuất và sắp xếp chữ - số 
theo thứ tự (A-Z) hoặc (0-9) [sort] mà nó còn cho phép đảo ngược mảng [reverse].

MỚI DÒM QUA VÀ PHÁ THỬ ĐƯỢC CÓ NHIÊU ĐÓ THÔI!
*/
using System.Runtime.CompilerServices;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;
List<string> mang = new List<string>();

while (true)
{
    Console.Write("\nNhập tên trái cây: ");
    string tenTrai = Console.ReadLine().Trim();
    if (tenTrai == "" || tenTrai.ToLower() == "stop")
    {
        Console.WriteLine("Kết thúc chương trình, đài truyền hình đến đây là hết!!!! :)");
        break;
    }
    if (mang.Contains(tenTrai, StringComparer.OrdinalIgnoreCase))
    {
        Console.WriteLine("Đã có " + tenTrai[0].ToString().ToUpper() + tenTrai.Substring(1).ToLower()+". Nhập tên trái khác đi: "); continue;
    }
    mang.Add(tenTrai[0].ToString().ToUpper() + tenTrai.Substring(1).ToLower());
    Console.WriteLine(string.Join(", ", mang));
    Console.WriteLine($"Count = {mang.Count}, Capacity = {mang.Capacity}");
}

mang.Sort();
Console.WriteLine("\nMảng trái cây sắp xếp từ (A-Z) bao gồm: " + string.Join(", ", mang));
mang.Reverse();
Console.WriteLine("\nMảng trái cây đảo ngược nè: " + string.Join(", ", mang));