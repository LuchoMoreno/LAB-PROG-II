using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Clase_18_CL_01
{
    public class AccesoDatos
    {

        #region Atributos
        private SqlConnection _conexion;
        private SqlCommand _comando;

        #endregion


        #region Constructores

        public AccesoDatos()
        {
          this._conexion = new SqlConnection(Properties.Settings.Default.conexion_BD);
        }

        #endregion


        #region Metodos


        public List<Persona> TraerTodos ()
    {
           //List<Persona> personas = null;
           List<Persona> personas = new List<Persona>();
           SqlDataReader dataReader;
      try
      {
        this._comando = new SqlCommand();
        this._comando.Connection = this._conexion;
        this._comando.CommandType = CommandType.Text;
        this._comando.CommandText = "SELECT id,apellido,nombre,edad FROM Padron.dbo.Personas";

        this._conexion.Open();

        dataReader = this._comando.ExecuteReader();
       
        while (dataReader.Read())
        {
            Persona personaObj = new Persona((int)dataReader["id"], dataReader["apellido"].ToString(), dataReader["nombre"].ToString(), (int)dataReader["edad"]);
            personas.Add(personaObj);
        }

        this._conexion.Close();
        }

      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }

      return personas;
        
    }


        public bool AgregarPersona(Persona persona)
    {
            bool retorno = false;

      try
      {
        this._comando = new SqlCommand();
        this._comando.Connection = this._conexion;
        this._comando.CommandType = CommandType.Text;
        this._comando.CommandText = "INSERT INTO Padron.dbo.Personas (nombre,apellido,edad) VALUES ('" + persona._nombre + "','" + persona._apellido + "'," + persona._edad.ToString() + ")";

        this._conexion.Open();

        if (this._comando.ExecuteNonQuery() > 0)
        {
          retorno = true;
        }

        this._conexion.Close();

      }
      catch (Exception e)
      {

        Console.WriteLine(e.Message);
      }

     

      return retorno;
    }


    public bool ModificarPersona (Persona personaParametro)
    {
      bool retorno = false;

      try
      {
      this._comando = new SqlCommand();
      this._comando.Connection = this._conexion;
      this._comando.CommandType = CommandType.Text;
      this._comando.CommandText = "UPDATE Padron.dbo.Personas set nombre = '" + personaParametro._nombre+ "', apellido = '" + personaParametro._apellido + "', edad = " + personaParametro._edad.ToString() + " where id = " + personaParametro._id;

      this._conexion.Open();

        if (this._comando.ExecuteNonQuery() > 0)
        {
          retorno = true;
        }


        this._conexion.Close();

      }
      
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }   
    
      return retorno;

    }


    public bool EliminarPersona (int personaInt)
    {
      bool retorno = false;

      try
      {
        this._comando = new SqlCommand();
        this._comando.Connection = this._conexion;
        this._comando.CommandType = CommandType.Text;
        this._comando.CommandText = "DELETE Padron.dbo.Personas WHERE id = " + personaInt.ToString();


        this._conexion.Open();

        if (this._comando.ExecuteNonQuery() > 0)
        {
          retorno = true;
        }

        this._conexion.Close();

      }

      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }
      

      return retorno;
    }
    

    public DataTable TreaerTablaPersonas()
    {
      SqlDataReader dataReader;
      DataTable tabla = new DataTable("Personas");

      try
      {
        this._comando = new SqlCommand();
        this._comando.Connection = this._conexion;
        this._comando.CommandType = CommandType.Text;
        this._comando.CommandText = "SELECT * FROM Padron.dbo.Personas";

        this._conexion.Open();

        dataReader = this._comando.ExecuteReader();
        tabla.Load(dataReader); // 

        this._conexion.Close();

      }

      catch (Exception e)
      {

        Console.WriteLine(e.Message);
      }
      
      return tabla;
    }

    


    #endregion






  }
}
