using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP1
{
    public class HinhTron
    {
        private double _BanKinh;
        public double BanKinh { 
            get { return _BanKinh; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Ban kinh am");
                }
                //else { _BanKinh = value; }
                _BanKinh = value;
            } 
        }

        public double DienTich { get; set; }
        public double ChuVi { get; set; }
        public HinhTron (double bk = 1) // nếu ko gán giá trị thì lúc new mới bk thì nó báo lỗi
        {
            BanKinh = bk;
        }
        public void TinhDienTichChuVi()
        {
            this.DienTich = Math.Round((Math.Pow(BanKinh, 2) * Math.PI), 2);
            this.ChuVi = Math.Round(2 * BanKinh * Math.PI, 2);
            //Console.WriteLine($"S = {DienTich}, P = {ChuVi}");
        }

        public override string ToString()
        {
            return $"Tron co R = {this.BanKinh}; S={this.DienTich}; P={this.ChuVi}";
        }
    }
}
