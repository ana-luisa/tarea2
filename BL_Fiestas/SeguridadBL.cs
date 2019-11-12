using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Fiestas
{
    public class SeguridadBL
    {
        public bool Autorizar(string Usuario, string Contraseña)
        {
            if (Usuario == "Ana" && Contraseña == ("1813"))
            {
                return true;
            }
            else
            {
                if (Usuario == "Carlos" && Contraseña == ("123"))
                {
                    return true;
                }
                else
                {
                    if (Usuario == "Reyna" && Contraseña == ("456"))
                    {
                        return true;
                    }
                    else
                    {

                        return false;
                    }
                }
            }
        }
    }
}
