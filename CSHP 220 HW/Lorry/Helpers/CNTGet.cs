using System;
using System.Collections.Generic;
using System.Text;

namespace Lorry.Helpers
{
    class CNTGet
    {
        public void GetCouplet()
        {
            Couplet newCouplet = new Couplet();
            string[] line = { newCouplet.CoupletContent };
            Random rnd = new Random();

            int coupletLine = rnd.Next(line.Length);

            string newLine = line[coupletLine];
        }
    }
}
