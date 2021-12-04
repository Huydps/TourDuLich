using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Model;

namespace Tour.DAO
{
    public class TourDAO
    {
        static QuanlyTourEntities1 db = new QuanlyTourEntities1();
        private static TourDAO Instance;
        public List<TOURDULICH> AddData(TOURDULICH Tour)
        {
           // using (var db = new QuanlyTourEntities1())
            {
                if (db.TOURDULICHes.Count(a => a.MaTour == Tour.MaTour) == 0)
                {
                    db.TOURDULICHes.Add(new TOURDULICH()
                    {
                        MaTour = Tour.MaTour,
                        TenTour = Tour.TenTour,
                        DacDiem = Tour.DacDiem,
                        IDGiaTour = Tour.IDGiaTour,
                        MaDOANDL = Tour.MaDOANDL,
                        MaLoaiHinh = Tour.MaLoaiHinh,
                        MaDiaDiem = Tour.MaDiaDiem,
                    }
                    );
                    db.SaveChanges();
                }
            }
            return LoadTour();
        }
        public  List<TOURDULICH> DeleteTour(string MaTour)
        {
           // using (var db = new QuanlyTourEntities1())
            {
                TOURDULICH Tour = db.TOURDULICHes.Where(p => p.MaTour == MaTour).SingleOrDefault();
                db.TOURDULICHes.Remove(Tour);
                db.SaveChanges();
            }
            return LoadTour();
        }
        public bool checkMaTour(TOURDULICH Tour)
        {
            using (var db = new QuanlyTourEntities1())
            {
                if (db.TOURDULICHes.Any(a => a.MaTour == Tour.MaTour))
                {
                    return true;
                }
            }
                
            return false;
        }
        public List<DOANDL> getDoanDL()
        {
          //  using (var db = new QuanlyTourEntities1())
            {
                return db.DOANDLs.ToList();
            }

        }
        public List<LOAIHINHDULICH> getMaLH()
        {
            //  using (var db = new QuanlyTourEntities1())
            {
                return db.LOAIHINHDULICHes.ToList();
            }

        }
        public List<GIATOUR> getGiaTour()
        {
            //  using (var db = new QuanlyTourEntities1())
            {
                return db.GIATOURs.ToList();
            }

        }

        public  List<TOURDULICH> LoadTour()
        {
           // using (var db = new QuanlyTourEntities1())
            {
               return db.TOURDULICHes.ToList(); 
            }
        }
        
      /*  public static List<TOURDULICH> EditData(string MaTour, string TenTour, string DacDiem, string GiaTour, string MaDoan, string LoaiHinh, string DiaDiem)
        {
                 using (var db = new QuanlyTourEntities1())
            {

                var Tour = db.TOURDULICHes.Where(x => x.MaTour == MaTour).FirstOrDefault();
                Tour.MaTour = MaTour;
                Tour.TenTour = TenTour;
                Tour.DacDiem = DacDiem;
                Tour.IDGiaTour = GiaTour;
                Tour.MaDOANDL = MaTour;
                Tour.MaLoaiHinh = LoaiHinh;
                Tour.MaDiaDiem = DiaDiem;

                db.SaveChanges();
            }
            return LoadTour();
        } */
    }
}
