using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores_ordenados__Catalogo_de_autos
{
    class Auto
    {
        private string _placa;
        private string _marca;
        private string _modelo;
        private string _telefono;
        private string _año;

        public string placa
            { get { return _placa; } }
        public string marca
            { get { return _marca; } }
        public string modelo
            { get { return _modelo; } }
        public string telefono
            { get { return _telefono; } }
        public string año
            { get { return _año; } }

        public Auto(string placa, string marca, string modelo, string telefono, string año)
        {
            _placa = placa;
            _marca = marca;
            _modelo = modelo;
            _telefono = telefono;
            _año = año;
        }

        public override string ToString()
        {
            return "Placa: " +_placa + " Marca: " + _marca +
                   " Modelo: " + _modelo + " Telefono: " + _telefono +
                   " Año: " + _año + Environment.NewLine;
        }
    }
}
