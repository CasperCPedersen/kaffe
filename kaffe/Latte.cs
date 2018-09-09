using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    ///<Summary>
    /// Class Latte
    ///</Summary>
    public class Latte : Kaffe , Imælk
    {
        /// <summary>
        /// Hvor meget mælk skal bruges til Latte
        /// </summary>
        /// <returns></returns>
        public int MlMælk()
        {
            return 120;
        }
        ///<Summary>
        /// Gets the Pris
        ///</Summary>
        public override int Pris()
        {
            return 40;
        }
    }
}
