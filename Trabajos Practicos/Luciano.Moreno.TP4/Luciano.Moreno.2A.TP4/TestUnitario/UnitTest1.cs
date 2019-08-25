using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
namespace TestUnitario
{
    [TestClass]public class UnitTest1
    {

        /// <summary>
        /// Prueba que intenta verificar que una instancia de paquete no sea NULL.
        /// </summary>

        [TestMethod] public void VerificarInstaciaListaPaquetesCorreo()
        {
            Correo c = new Correo();
            Assert.IsNotNull(c);
        }


        /// <summary>
        /// Prueba que internat verificar dos cargas con el mismo tracking.
        /// </summary>

        [TestMethod] public void VerificarCargaDosPaquetesMimosTrackingId()
        {
            Paquete paqueteUno = new Paquete("España", "123");
            Paquete paqueteDos = new Paquete("Argentina", "123");
            Correo correoNuevo = new Correo();

            try
            {
                correoNuevo += paqueteUno;
                correoNuevo += paqueteDos;
                Assert.Fail("Estoy intentando añadir 2 paquetes del mismo tracking. Tendria que lanzar una exception.");
            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(TrackingIdRepetidoException));
            }
        }
    }
}
