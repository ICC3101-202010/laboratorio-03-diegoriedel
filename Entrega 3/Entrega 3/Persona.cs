using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega_3
{
    class Persona
    {
        private string rut;
        private string name;
        private string lastname;
        private string nation;
        private string date;
        private string altura;
        public Persona(string rut, string name, string lastname, string nation, string date, string altura)
        {
            this.rut = rut;
            this.name = name;
            this.lastname = lastname;
            this.nation = nation;
            this.date = date;
            this.altura = altura;
        }

        public string retornaNombre()
        {
            return "rut: " + rut + " nombre: " + name + " apellido: " + lastname + " Nacion: " + nation + " Fecha nacimiento: " + date + " Altura: " + altura;

        }

    }
}
