using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{

    public class Correo : IMostrar<List<Paquete>>
    {

        #region Atributos
       
        // Thread privado.
        private List<Thread> mockPaquetes;
        // Paquete privado. 
        private List<Paquete> paquetes;

        #endregion



        #region Propiedades

        /// <summary>
        /// Propiedad de lectura y escritura para Paquetes.
        /// </summary>

        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }

        #endregion

  

        #region Constructor

        /// <summary>
        /// Constructor que inicializa 2 atributos de la clase Correo.
        /// </summary>

        public Correo()
        {
            this.mockPaquetes = new List<Thread>();
            this.paquetes = new List<Paquete>();
        }

        #endregion



        #region Metodos

        /// <summary>
        /// Guarda en una cadena todos los paquetes de un correo
        /// </summary>
        /// <param name="elemento"> Elemento casteado como paquete </param>
        /// <returns> Cadena con datos de los paquetes </returns>

        public string MostrarDatos(IMostrar<List<Paquete>> elemento)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Paquete item in ((Correo)elemento).paquetes)
            {
                sb.AppendLine(string.Format("{0} para {1} ({2}) \n", item.TrackingID, item.DireccionEntrega, item.Estado.ToString()));

            }

            return sb.ToString();
        }

        /// <summary>
        /// Cierra todos los hilos activos
        /// </summary>

        public void FinEntregas()
        {
            foreach (Thread itemsProcesando in this.mockPaquetes)
            {
                itemsProcesando.Abort();
            }
        }

        #endregion



        #region Sobrecargas

        /// <summary>
        /// Agrega paquetes en la lista de correo
        /// </summary>
        /// <param name="c"> Atributo de tipo correo </param>
        /// <param name="p"> Atributo de tipo paquete </param>
        /// <returns> Correo con paquete agregado. O sin paquetes agregados. </returns>

        public static Correo operator +(Correo c, Paquete p)
        {

            foreach (Paquete item in c.paquetes)
            {
                if (item == p)
                {
                    throw new TrackingIdRepetidoException("El Tracking ID: " + item.TrackingID + " ya está en la lista.");
                }
            }

            c.paquetes.Add(p);

            Thread nuevoThread = new Thread(p.MockCicloDeVida);

            c.mockPaquetes.Add(nuevoThread);

            nuevoThread.Start();

            return c;
        }

       

        #endregion



    }
}
