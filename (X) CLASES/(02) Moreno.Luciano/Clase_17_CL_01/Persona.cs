using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_17_CL_01
{
    public class Persona : Humano, ISerializableXML, ISerializableBinario
    {
    #region Atributos

    public string apellido;
    public string nombre;

    #endregion


    #region Constructores

    public Persona() 
    {

    }

    public Persona(string nombre, string apellido) : this()
    {
      this.nombre = nombre;
      this.apellido = apellido;
    }


    #endregion


    #region Metodos


    public int Propiedad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


    public bool deserializarXML()
    {
      throw new NotImplementedException();
    }


    public bool serializarXML()
    {
      throw new NotImplementedException();
    }

    public override string ToString()
    {
      return base.ToString() + string.Format(" -- Nombre: {0} -- Apellido: {1}", this.nombre, this.apellido);
    }


    #endregion

    


  }
}
