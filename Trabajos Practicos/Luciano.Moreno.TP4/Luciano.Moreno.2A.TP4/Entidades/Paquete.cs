using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {

        #region Delegados

        /// <summary>
        /// Delegado del Estado.
        /// </summary>
        public delegate void DelegadoEstado(object sender, EventArgs e);

        #endregion



        #region Eventos

        public event DelegadoEstado InformaEstado;

        #endregion



        #region Enumerado

        /// <summary>
        /// Enumerado para Estados.
        /// </summary>
        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }

        #endregion



        #region Atributos

        // String privado de direccion de entrega.
        private string direccionEntrega;
        
        // Enumeado privado de estado.
        private EEstado estado;
       
        // String privado de tracking.
        private string trackingID;


        #endregion



        #region Propiedades

        /// <summary>
        /// Propiedad de lecutura y escritura de direccion de entrega.
        /// </summary>

        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }

            set
            {
                this.direccionEntrega = value;
            }
        }


        /// <summary>
        /// Propiedad de lecutura y escritura de Estado. 
        /// </summary>

        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }


        /// <summary>
        /// Propiedad de lecutura y escritura de TrackingID.
        /// </summary>

        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;

            }
        }

        #endregion



        #region Constructores

        /// <summary>
        /// Constructor que setea 2 atributos de la clase Paquete.
        /// </summary>
        /// <param name="direccionEntrega"> Direccion de entrega </param>
        /// <param name="trackingID"> Traking ID</param>
        /// 
        public Paquete(string direccionEntrega,string trackingID)
        {
            this.direccionEntrega = direccionEntrega;
            this.trackingID = trackingID;
        }


        #endregion



        #region Metodos


        /// <summary>
        /// Muestra los datos de un paquete espewcifico pasado como parametro.
        /// </summary>
        /// <param name="elemento"> Paquete a mostrar datos </param>
        /// <returns> Cadena con todos los datos del paquete </returns>
        /// 

        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            return string.Format("{0} para {1}", ((Paquete)elemento).trackingID, ((Paquete)elemento).direccionEntrega);
        }


        /// <summary>
        /// MockCicloDeVida hará que el paquete cambie de estado de la siguiente forma: 
        /// a. Colocar una demora de 4 segundos. 
        /// b. Pasar al siguiente estado. 
        /// c. Informar el estado a través de InformarEstado. EventArgs no tendrá ningún dato extra. 
        /// d. Repetir las acciones desde el punto A hasta que el estado sea Entregado. 
        /// e. Finalmente guardar los datos del paquete en la base de datos.
        /// </summary>
        /// 

        public void MockCicloDeVida()
        {
            do
            {

                Thread.Sleep(4000);


                if (this.estado == EEstado.Ingresado)
                {
                    this.estado = EEstado.EnViaje;
                }
                else if (this.estado == EEstado.EnViaje)
                {
                    this.estado = EEstado.Entregado;
                }

                this.InformaEstado(this.estado, EventArgs.Empty);
            } while (this.estado != EEstado.Entregado);

            try
            {
                PaqueteDAO.Insertar(this);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        /// <summary>
        /// sobrecarga de ToString para que muestre los datos de la clase paquete.
        /// </summary>
        /// <returns> Retorna un string con todos los datos del paquete </returns>


        public override string ToString()
        {
            return this.MostrarDatos(this);
        }

        #endregion



        #region SobrecargaOperadores

        /// <summary>
        /// Sobrecarga del operador == para saber si son iguales o no mediante el trackingID.
        /// </summary>
        /// <param name="p1"> Paquete uno </param>
        /// <param name="p2"> Paquete dos </param>
        /// <returns> True -> Son iguales / False -> Son distintos </returns>

        public static bool operator ==(Paquete p1 , Paquete p2)
        {
            bool retorno = false;

            if(p1.trackingID==p2.trackingID)
            {
                retorno = true;
            }

            return retorno;
        }


        /// <summary>
        /// Sobrecarga del operador != para saber si son iguales o no mediante trackingID.
        /// </summary>
        /// <param name="p1"> Paquete uno </param>
        /// <param name="p2"> Paquete dos </param>
        /// <returns> True .> Son distintos / False -> Son iguales </returns>

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        #endregion
    }
}
