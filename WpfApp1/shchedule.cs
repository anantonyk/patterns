//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class shchedule
    {
        public string day_week { get; set; }
        public int pair_num { get; set; }
        public int id_group { get; set; }
        public int id_subject { get; set; }
        public int id_lecturer { get; set; }
        public int id_campus { get; set; }
        public int id_audience { get; set; }
    
        public virtual group group { get; set; }
        public virtual lecturer lecturer { get; set; }
        public virtual campu campu { get; set; }
        public virtual subject subject { get; set; }
    }
}
