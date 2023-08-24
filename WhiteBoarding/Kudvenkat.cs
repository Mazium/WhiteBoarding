using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoarding
{
    public struct Kudvenkat
    {
        private int _id;
        private string _name;

        public int Id { get =>this._id; set => this._id = value; }
        public string Name { get => this._name; set => this._name = value; }




    }

    interface Icustomer
    {
        void Print();
    }

    interface I2
    {
        void I2Method();
        
    }

    class Customer: Icustomer, I2
    {
        public void I2Method()
        {
            Console.WriteLine("I2 Method");
        }

        public void Print()
        {
            Console.WriteLine("interface Print Method");
        }
    }

    



}
