//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tour.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class CHITIET
    {
        static QuanlyTourEntities1 db = new QuanlyTourEntities1();
        public string IDCHITIET { get; set; }
        public string MaTour { get; set; }
        public string MaDiaDiem { get; set; }
        public Nullable<int> thutu { get; set; }
    
        public virtual DIADIEM DIADIEM { get; set; }
        public virtual TOURDULICH TOURDULICH { get; set; }
        public static List<CHITIET> LoadDataChiTiet(string MaTour)
        {
           // using (var db = new QuanlyTourEntities1())
            {
                // CHITIET chitiet = db.CHITIETs.Where(p => p.MaTour == MaTour).FirstOrDefault();
                var result = db.CHITIETs.ToList();
                return result;
            }
        }

        
    }
}
