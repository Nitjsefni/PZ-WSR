//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Wypadek
    {
        public int ID_wypadku { get; set; }
        public string miejsce_wypadku { get; set; }
        public int liczba_rannych { get; set; }
        public string typ_wypadku { get; set; }
        public System.DateTime data_godz_zgl { get; set; }
        public int ID_skladu { get; set; }
        public Nullable<int> numer_zgl { get; set; }
        public string uwagi { get; set; }
    }
}
