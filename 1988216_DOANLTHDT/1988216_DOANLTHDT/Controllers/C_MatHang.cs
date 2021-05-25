using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _1988216_DOANLTHDT.Entities;
using System.IO;

namespace _1988216_DOANLTHDT.Controllers
{
    public class C_MatHang
    {
        public List<MatHang> getDanhSachMatHang()
        {
            StreamReader file = new StreamReader("~/Models/DB_MatHang.txt");
            List<MatHang> dsMH = new List<MatHang>();

            return dsMH;
        }
    }
}