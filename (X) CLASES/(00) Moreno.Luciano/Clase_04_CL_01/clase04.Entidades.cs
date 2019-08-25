using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04_CL_01
{
    public class cosa
    {
      public int entero;
      public string cadena;
      public DateTime fecha;

      public string Mostrar()
      {
        //string retorno = (this.entero + this.cadena + this.fecha).ToString();
        //return retorno; // METODO 1, PERO ASUME MUCHAS COSAS.
        return this.entero.ToString() + " - " + this.cadena + " - " + this.fecha.ToString(); 
      }

      public static string Mostrar(cosa objeto)
      {
        //return objeto.entero.ToString() + "-" + objeto.cadena + "-" + objeto.fecha.ToString();
        return objeto.Mostrar();
      }


    public void EstablecerValor(int parametro)
      {
      this.entero = parametro;
      }

    public void EstablecerValor(string parametro)
      {
      this.cadena = parametro;
      }

    public void EstablecerValor(DateTime parametro)
      {
      this.fecha = parametro;
      }


    public cosa() // NIVEL 0
      {
        this.entero = 10;
        this.cadena = "Sin valor";
        this.fecha = DateTime.Now;
      }

    public cosa(int enteroParametro) : this()  // NIVEL 1
      {
        this.entero = enteroParametro;
        //this.cadena = "Sin valor";
        //this.fecha = DateTime.Now;
      }

    public cosa(int enteroParametro, DateTime fechaParametro) : this(enteroParametro) // NIVEL 2
      {
       // this.entero = enteroParametro;
        //this.cadena = "Sin valor";
        this.fecha = fechaParametro;
      }

    public cosa(int enteroParametro, string cadenaParametro, DateTime fechaParametro) : this (enteroParametro, fechaParametro) // NIVEL 3
      {
        //this.entero = enteroParametro;
        this.cadena = cadenaParametro;
        //this.fecha = fechaParametro;
      }

  }
}
