using System;
using System.Collections.Generic;
using System.Text;

namespace Laba5_1
{
    class Second  : First
    {
        public string day { get; set; }
        public int nubmers { get; set; }
        public string comment { get; set; }

        public Second(string str)
        {
            string[] parts = str.Split(';');
            name = parts[0];
            secondname = parts[1];
            comment = parts[2];
            nubmers = int.Parse(parts[3]);
            day = (parts[4]);


        }

    }
}
