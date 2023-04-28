using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie.masina.model
{
    public class Masina
    {
        // Atribute 
        private string _marca;
        private string _model;
        private string _numarInmatriculare;
        private string _numeDetinator;
        private string _culoare;
        private int _an;
        private int _greutate;
        private int _id;

        // Constructor

        public Masina()
        {
            Console.WriteLine("Eu sunt un constructor fara parametrii");
        }

        public Masina(string ceva)
        {
            Console.WriteLine($"Eu {ceva} sunt un constructor cu un");
        }

        public Masina(string marca, string model, string numarInmatriculare, string numeDetinator, string culoare, int an, int greutate, int id)
        {
            _marca = marca;
            _model = model;
            _numarInmatriculare = numarInmatriculare;
            _numeDetinator = numeDetinator;
            _culoare = culoare;
            _an = an;
            _greutate = greutate;
            _id = id;
        }

        // Accesorii

        public string Marca
        {
            get { return _marca; }
            set
            {
                if (value.Equals("Dacia"))
                {
                    _marca = "undefined";
                }
                else
                {
                    _marca = value;
                }
            }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string NumarInmatriculare
        {
            get { return _numarInmatriculare; }
            set
            {
                if (value.Equals("BV00ABC"))
                {
                    _numarInmatriculare = "undefined";
                }
                else
                {
                    _numarInmatriculare = value;
                }
            }
        }

        public string NumeDetinator
        {
            get { return _numeDetinator; }
            set { _numeDetinator = value; }
        }

        public string Culoare
        {
            get { return _culoare; }
            set
            {
                if (value.Equals("mov") || value.Equals("roz"))
                {
                    _culoare = "undefined";
                }
                else
                {
                    _culoare = value;
                }
            }
        }

        public int An
        {
            get { return _an; }
            set
            {
                if (value < 2000)
                {
                    _an = -1;
                }
                else
                {
                    _an = value;
                }
            }
        }

        public int Greutate
        {
            get { return _greutate; }
            set
            {
                if (value > 2000)
                {
                    _greutate = -1;
                }
                else
                {
                    _greutate = value;
                }
            }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        // Metode

        public string Describe()
        {
            string desc = "";
            desc += "Marca : " + _marca + "\n";
            desc += "Model : " + _model + "\n";
            desc += "Numar Inmatriculare : " + _numarInmatriculare + "\n";
            desc += "Nume detinator : " + _numeDetinator + "\n";
            desc += "Culoare : " + _culoare + "\n";
            desc += "An : " + _an + "\n";
            desc += "Greutate : " + _greutate + "\n";
            desc += "Id : " + _id + "\n";

            return desc;
        }
    }
}