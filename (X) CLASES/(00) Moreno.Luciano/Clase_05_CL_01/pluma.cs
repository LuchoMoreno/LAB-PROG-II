using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_05_CL_01
{
    public class pluma
    {
        private string _marca;
        private tinta tinta;
        private int cantidad;


        public pluma() : this("Sin marca", null, 0)
        {
        }

        public pluma(string marcaParametro) : this(marcaParametro, null, 0)
        {
        }

        public pluma(string marcaParametro, tinta tintaParametro) : this(marcaParametro, tintaParametro, 0)
        {
        }

        public pluma(string marcaParametro, tinta tintaParametro, int cantidadParametro)
        {
            this._marca = marcaParametro;
            this.tinta = tintaParametro;
            this.cantidad = cantidadParametro;
        }


        private string Mostrar()
        {
            return this._marca.ToString() + "--" + tinta.Mostrar(this.tinta) + "--" + this.cantidad.ToString();
        }


        public static bool operator ==(pluma miPluma, tinta miTinta)
        {
            return miPluma.tinta == miTinta;
        }

        public static bool operator !=(pluma miPluma, tinta miTinta)
        {
            return !(miPluma.tinta == miTinta);
        }


        public static implicit operator string(pluma ejemplo)
        {
            return ejemplo.Mostrar();
        }

        /***
        public static pluma operator +(pluma miPluma, tinta miTinta)
        {
            if (miPluma == miTinta)
            {
                do
                {
                    miPluma.cantidad = miPluma.cantidad + 10;
                } while (miPluma.cantidad < 100);
            }

        }

        public static pluma operator -(pluma miPluma, tinta miTinta)
        {
            if (miPluma == miTinta)
            {
                do
                {
                    miPluma.cantidad = miPluma.cantidad - 10;
                } while (miPluma.cantidad > 0);
            }

        }
        */


    }

}
