using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Inheritance
{
    class Police:Human
    {
        public string Region;
        public Police(string name, string surname,byte age,string gender,string region):base(name,surname,age,gender)
        {
            Region = region;
        }

    }
}
