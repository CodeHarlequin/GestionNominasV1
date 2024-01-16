using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GestionNominasV1
{
   public class Nomina
   {
      // Miembros pribados de la clase 
      private string _nombre;
      private string _apellido;
      private string _puesto;
      private int _horasTrabajadas;
      private float _salarioHora;

      // Propiedades 
      /// <summary>
      /// Nombre del empleado
      /// </summary>
      public string NombreEmpelado
      {
         get
         {
            // Cotrol de contendido
            if (string.IsNullOrEmpty(_nombre))
            {
               throw new Exception("Nombre del trabajador no establecido");
            }

            // Devolucion del Valor
            return _nombre;
         }

         set
         {
            // Validacion de lso datos a establecer
            if (string.IsNullOrEmpty(value))
            {
               throw new Exception("El nombre del trabajador no puede ser null o la cadena vacia");
            }

            // Establecimiento del valor al miembro privado
            _nombre = value;
         }
      }
   }
}
