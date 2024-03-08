//Dùng ForEach, khi không quan tâm tới chỉ số thứ tự của từng phần tử trong mảng
// chỉ lấy phần tử tập thể 

using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
string[] tenSvs = { "Tèo", "Tý", "Mận", "Đào", "Quýt", "Ổi" };
foreach (string ten in tenSvs)
{
    Console.WriteLine(ten);
}