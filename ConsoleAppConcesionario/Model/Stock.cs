//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleAppConcesionario.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock
    {
        public int stockID { get; set; }
        public Nullable<int> concesionarioID { get; set; }
        public Nullable<int> vehiculoID { get; set; }
    
        public virtual Concesionarios Concesionarios { get; set; }
        public virtual Vehiculos Vehiculos { get; set; }
    }
}
