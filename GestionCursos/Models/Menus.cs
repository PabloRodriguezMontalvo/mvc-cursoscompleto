//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionCursos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Menus
    {
        public Menus()
        {
            this.Menus1 = new HashSet<Menus>();
        }
    
        public int idMenu { get; set; }
        public string Nombre { get; set; }
        public string controlador { get; set; }
        public string accion { get; set; }
        public bool visible { get; set; }
        public Nullable<int> idPadre { get; set; }
        public string url { get; set; }
    
        public virtual ICollection<Menus> Menus1 { get; set; }
        public virtual Menus Menus2 { get; set; }
    }
}
