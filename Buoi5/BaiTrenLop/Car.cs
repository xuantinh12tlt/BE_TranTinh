using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    public abstract class Car
    {
        private string brank { get; set; }
        private string model { get; set; }
        private string year { get; set; }



        public Car(string brank, string model, string year)
        {
            this.brank = brank;
            this.model = model;
            this.year = year;
        }
        public virtual void display_info()
        {

        }
    }
}
