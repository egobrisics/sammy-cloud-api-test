using System;
using System.Collections.Generic;
using System.Text;

namespace SammyCloudData.Entities
{
    public class PhoneNumber
    {
        private string _areaCode;
        private string _prefix;
        private string _line;
        private string _extension;

        string AreaCode
        {
            get => _areaCode;
            set
            {
                int nValue = 0;
                int.TryParse(value, out nValue);
                _areaCode = (nValue % 1000).ToString("D3");
            }
        }
        string Prefix
        {
            get => _prefix;
            set
            {
                int nValue = 0;
                int.TryParse(value, out nValue);
                _prefix = (nValue % 1000).ToString("D3");
            }
        }
        string Line
        {
            get => _line;
            set
            {
                int nValue = 0;
                int.TryParse(value, out nValue);
                _line = (nValue % 1000).ToString("D4");
            }
        }
        string Extension { get => _extension; set => _extension = value; }

        public override string ToString()
        {
            return this.AreaCode + "-" + this.Prefix + this.Line;
        }
    }
}
