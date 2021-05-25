using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace _1988216_DOANLTHDT.Entities
{
    public class MatHang
    {
        private int _MaMatHang;
        public int MA_MAT_HANG
        {
            get
            {
                return this._MaMatHang;
            }
            set
            {
                // Kiểm tra phải số nguyên hợp lệ hay không
                if (int.TryParse(value.ToString(), out int n))
                {
                    // Nếu là số nguyên thì kiểm tra tiếp phải là số > 0 thì mới set
                    if (n > 0) this._MaMatHang = n;
                    else this._MaMatHang = 1;
                }
                else
                {
                    this._MaMatHang = 1;
                }
            }
        }

        private string _TenMatHang;
        public string TEN_MAT_HANG
        {
            get
            {
                return this._TenMatHang;
            }
            set
            {
                // Kiểm tra có chứa ký tự đặc biệt nào hay không. Nếu không có thì mới set
                var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
                if (!regexItem.IsMatch(value)) this._TenMatHang = value;
                else this._TenMatHang = "";

            }
        }

        private DateTime _HanSuDung;

        public DateTime HAN_SU_DUNG
        {
            get
            {
                return this._HanSuDung;
            }
            set
            {
                // Nếu thời gian sử dụng < thời gian hiện tại thì không set
                var nowTime = DateTime.Now;
                if (value > nowTime) this._HanSuDung = value;
                else this._HanSuDung = nowTime;
            }
        }

        private DateTime _NamSX;

        public DateTime NAM_SX
        {
            get
            {
                return this._NamSX;
            }
            set
            {
                // Nếu thời gian sản xuất <= thời gian hiện tại thì set
                var nowTime = DateTime.Now;
                if (value <= nowTime) this._NamSX = value;
                else this._NamSX = nowTime;
            }
        }

        private string _CongTySX;
        public string CONG_TY_SX
        {
            get
            {
                return this._CongTySX;
            }
            set
            {
                // Kiểm tra có chứa ký tự đặc biệt nào hay không. Nếu không có thì mới set
                var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
                if (!regexItem.IsMatch(value)) this._CongTySX = value;
                else this._CongTySX = "";

            }
        }

        private int _LoaiHang;

        public int LOAI_HANG
        {
            get
            {
                return this._LoaiHang;
            }
            set
            {
                // Kiểm tra phải số nguyên hợp lệ hay không
                if(int.TryParse(value.ToString(), out int n))
                {
                    // Nếu là số nguyên thì kiểm tra tiếp phải là số > 0 thì mới set
                    if (n > 0) this._LoaiHang = n;
                    else this._LoaiHang = 1;
                }
                else
                {
                    this._LoaiHang = 1;
                }
            }
        }

    }
}