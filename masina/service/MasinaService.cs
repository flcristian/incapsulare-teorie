using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie.Masina.service
{
    public class MasinaService
    {
        private List<Masina> _listMasina;

        public MasinaService()
        {
            _listMasina = new List<Masina>();
            Load();
        }

        // Metode

        public void Load()
        {
            Masina m1 = new Masina("Nissan", "Quest", "39926", "Burke Elgie", "Teal", 1995, 1769, 1);
            Masina m2 = new Masina("Saab", "9000", "43804", "Adoree Aspey", "Puce", 1993, 1457, 2);
            Masina m3 = new Masina("Lamborghini", "Murciélago", "121101", "Rosemary Leyden", "Mauv", 2010, 1441, 3);
            Masina m4 = new Masina("GMC", "1500 Club Coupe", "6094", "Seumas Spurret", "Crimson", 1994, 1634, 4);
            Masina m5 = new Masina("BMW", "745", "48672", "Penn Benkhe", "Mauv", 2003, 1742, 5);
            Masina m6 = new Masina("Toyota", "Tacoma", "34440", "Thurstan Buterton", "Indigo", 2003, 1644, 6);

            _listMasina.Add(m1);
            _listMasina.Add(m2);
            _listMasina.Add(m3);
            _listMasina.Add(m4);
            _listMasina.Add(m5);
            _listMasina.Add(m6);
        }

        public void Afisare()
        {
            Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            foreach (Masina m in _listMasina)
            {
                Console.WriteLine(m.Describe());
            }
        }


        //todo metoda ce primeste ca parametru un id si returneaza masina 

        public Masina FindMasinaById(int id)
        {
            foreach (Masina m in _listMasina)
            {
                if (m.Id == id)
                {
                    return m;
                }
            }

            return null;
        }
    }
}
