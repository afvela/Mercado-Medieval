using System;
using System.Collections.Generic;
using System.Text;

namespace MercadoMedieval.cs
{

    enum TipoEspectaculo
    {
        Teatro,
        Titeres,
        Magia,
        Pirotecnia,
        Duelo,
        TiroArco,
        Cesteria,
    }

    class Espectaculo
    {
        private TipoEspectaculo tipoEspectaculo;
        private String Nombre;
        private String Descripcion;
        private DateTime Fecha;
        private String Organizador;

        public Espectaculo(String tipoEspectaculo, String Nombre, String Descripcion, DateTime Fecha, String Organizador)
        {
            Asociar(tipoEspectaculo);
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Fecha = Fecha;
            this.Organizador = Organizador;
        }

        public Boolean CambiarFecha(int Hora = Fecha.Hour, int Minutos = Fecha.Minute)
        {
            int year = this.Fecha.Year;
            int month = this.Fecha.Month;
            int day = this.Fecha.Day;
            //int hour = this.Fecha.Hour;
            //int minute = this.Fecha.Minute;
            int second = this.Fecha.Second;

            if (Hora > 24 || Hora < 0 || Minutos > 60 || Minutos < 0)
            {
                return false;
            }
            else
            {
                Fecha = new DateTime(year, month, day, Hora, Minutos, second);
                return true;
            } 
        }

        // Asociación de tipo de espectaculo

        public void Asociar(String e)
        {
            switch (e)
            {
                case e.Equals("Teatro"):
                    this.tipoEspectaculo = TipoEspectaculo.Teatro;
                    break;
                case e.Equals("Titeres"):
                    this.tipoEspectaculo = TipoEspectaculo.Titeres;
                    break;
                case e.Equals("Magia"):
                    this.tipoEspectaculo = TipoEspectaculo.Magia;
                    break;
                case e.Equals("Pirotecnia"):
                    this.tipoEspectaculo = TipoEspectaculo.Pirotecnia;
                    break;
                case e.Equals("Duelo"):
                    this.tipoEspectaculo = TipoEspectaculo.Duelo;
                    break;
                case e.Equals("TiroArco"):
                    this.tipoEspectaculo = TipoEspectaculo.TiroArco;
                    break;
                case e.Equals("Cesteria"):
                    this.tipoEspectaculo = TipoEspectaculo.Cesteria;
                    break;
            }
        }
    }
}
