using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    public class XeKhach:Car
    {
        public XeKhach(string brank, string model, string year) : base(brank, model, year)
        {
        }

        public override void display_info()
        {
            throw new NotImplementedException();
        }
    }
}
