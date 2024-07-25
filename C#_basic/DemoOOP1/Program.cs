using DemoOOP1;

var x = new Diem();
//Console.WriteLine($"{x.HoanhDo}, {x.TungDo}");
x.Xuat();
var y = new Diem(7, 11);
Console.WriteLine($"{y.HoanhDo}, {y.TungDo}");
Console.WriteLine(y);






//Lớp HinhTron
//Tạo input bán kính cho người dùng nhập vào:
Console.Write("Nhap ban kinh hinh tron: ");
double value = double.Parse(Console.ReadLine());


//Tạo một đối tượng hình tròn với bán kính bằng 2
HinhTron hinhTron = new HinhTron(value);

//Tính diện tích và chu vi
hinhTron.TinhDienTichChuVi();

//Hiển thị thông báo đầy đủ của hình tròn
Console.WriteLine(hinhTron);

//Hiển thị diện tích và chu vi
Console.WriteLine("Dien tich: " + hinhTron.DienTich);
Console.WriteLine("Chu vi: " + hinhTron.ChuVi);


/* Bài của thầy
var ht1 = new HinhTron();
Console.WriteLine(ht1);
var ht2 = new HinhTron(3);
Console.WriteLine(ht2);
var ht3 = new HinhTron(-8);
Console.WriteLine(ht3);
*/

/*
//Lớp HinhHoc
var rd = new Random();
var soLuongHinh = rd.Next(1, 100);
for (int i = 0; i < soLuongHinh; i++)
{
    var rdType = rd.Next() % 2 == 0;
    if (rdType == true)
    {
        dsHinh.Add(new Tron { BanKinh =rd.NextDouble() * 100});
    }
    else
    {
        dsHinh.Add(new ChuNhat
        {
            Dai = rd.Next(1, 100),
            Rong = rd.Next(1, 100)
        });
    }
}

foreach (var hh in dsHinh)
{
    hh.TinhDTCV(); Console.WriteLine(hh);
}
*/