//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PizzaStoreData.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class VegetableTopping
    {
        public int VegetableToppingID { get; set; }
        public int PizzaID { get; set; }
        public int VegetableID { get; set; }
        public bool Active { get; set; }
    
        public virtual Pizza Pizza { get; set; }
        public virtual Vegetable Vegetable { get; set; }
    }
}
