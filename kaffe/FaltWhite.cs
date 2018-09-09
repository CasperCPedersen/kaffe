using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    public class FaltWhite : Kaffe , Imælk
    {
        // Return mælk in a faltwhite in Milliters 
        public int MlMælk()
        {
            return 160;
        }

        public override int Pris()
        {
            return 45;
        }

        public override string Styrke()
        {
            return "Mild";
        }


    }
}
