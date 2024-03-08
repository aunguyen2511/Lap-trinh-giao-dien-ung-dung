using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP1
{
    public class Diem
    {
        public double HoanhDo { get; set; }
        public double TungDo { get; set; }
        //public Diem() { HoanhDo = 0; TungDo = 0; }

        // hoặc


        /// <summary>
        /// Hàm tạo lớp Điểm
        /// </summary>
        /// <param name="xx">tung độ</param>
        /// <param name="yy">hoành độ</param>
        public Diem(int xx = 0, int yy = 0) 
        {  
            this.HoanhDo = xx; TungDo = yy; 
        }
        public void Xuat()
        {
            Console.WriteLine($"({this.HoanhDo}, {this.TungDo})");
        }
        public override string ToString()
        {
            return $"({this.HoanhDo}, {this.TungDo})";
        }
    }

    
}
