using System;
using System.Collections.Generic;
using System.Text;

namespace SammyCloudData.Entities
{
    interface ICodedValue
    {
        int id { get; set; }

        string Code { get; set; }

        string Value { get; set; }
    }
}
