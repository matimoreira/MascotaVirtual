using System;
using System.Collections.Generic;
using System.Text;

namespace MascotaVirtual
{
    public class Mascota
    {
        private bool _apetito;
        public Mascota()
        {
            _apetito = true;
            this.Name = "Coca";
        }
        public Mascota(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public string Estado { get; set; }
        public void Comer()
        {
            if (!_apetito)
            {
                throw new Exception($"{this.Name} no tiene hambre.");
            }
            throwIfState("Durmiendo", $"{this.Name} esta durmiendo.");
            this.Estado = "Comiendo";
            _apetito = false;
        }

        public void Jugar()
        {
            if (_apetito)
            {
                throw new Exception($"{this.Name} no tiene energias para jugar.");
            }
            throwIfState("Durmiendo", $"{this.Name} esta durmiendo.");
            this.Estado = "Jugando";
            _apetito = true;
        }

        public void Dormir()
        {
            throwIfState("Durmiendo", $"{this.Name} ya esta durmiendo.");
            this.Estado = "Durmiendo";
        }

        public void Despertar()
        {
            if (this.Estado != "Durmiendo")
            {
                throw new Exception($"{this.Name} ya esta Despierto.");
            }
            this.Estado = "Despertando";
        }

        public void IrAlBaño()
        {
            if (_apetito)
            {
                throw new Exception($"{this.Name} tiene una lija, que va tener ganas de ir al baño.");
            }
            throwIfState("Durmiendo", $"{this.Name} esta durmiendo.");
            this.Estado = "***ando";
            this._apetito = true;
        }

        public void throwIfState(string state, string message)
        {
            if (this.Estado == state)
            {
                throw new Exception(message);
            }
        }
    }
}
