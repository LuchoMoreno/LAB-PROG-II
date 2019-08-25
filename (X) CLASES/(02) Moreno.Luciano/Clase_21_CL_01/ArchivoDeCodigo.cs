using Clase_21_CL_01;

public delegate void DelegadoSueldo(Empleado empleado, float sueldo);
public delegate void DelSueldo (EmpleadoMejorado empleado, EmpleadoSueldoArgs empleadoArgs);


public enum TipoManejador
{
  limiteSueldo,
  Log,
  Ambos,
}
