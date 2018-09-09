using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    ///<Summary>
    /// Classe FaltWhite
    ///</Summary>
    public class FaltWhite : Kaffe , Imælk
    {
        ///<Summary>
        /// constutor skaber obejkter af faltwhite
        ///</Summary>
        public FaltWhite()
        {

        }

        ///<Summary>
        /// Gets the MlMælk need for a FaltWhite
        ///</Summary>
        public int MlMælk()
        {
            return 160;
        }
        ///<Summary>
        /// Gets the Pice need for a FaltWhite
        ///</Summary>
        public override int Pris()
        {
            return 45;
        }
        ///<Summary>
        /// Gets the Styrke need for a FaltWhite
        ///</Summary>
        public override string Styrke()
        {
            return "mild";
        }


    }
}
