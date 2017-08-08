using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_proj
{
    public class Cpu : Player
    {
        public Cpu()
        {

        }
        public override void getChoice()
        {
            Random random = new Random();
            number = random.Next(1, 5);
        }

    }

}
