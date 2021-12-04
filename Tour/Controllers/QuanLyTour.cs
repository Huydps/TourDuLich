using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.DAO;
using Tour.Model;

namespace Tour.Controllers
{
    public class QuanLyTour
    {
        TourDAO tourDAO = new TourDAO();
        public bool addTour(TOURDULICH Tour)
        {
            if (!tourDAO.checkMaTour(Tour))
                tourDAO.AddData(Tour);
            else return false;
            return true;
        }
        public List<DOANDL> getDoanDL()
        {
            return tourDAO.getDoanDL();
        }
        public List<LOAIHINHDULICH> getMaLH()
        {
            return tourDAO.getMaLH();
        }
        public List<GIATOUR> getGiaTour()
        {
            return tourDAO.getGiaTour();
        }
        public void deleteTour(string MaTour)
        {
             tourDAO.DeleteTour(MaTour);
        }
        public List<TOURDULICH> LoadTour()
        {
           var result = tourDAO.LoadTour();
            return result;
        }
    }
}
