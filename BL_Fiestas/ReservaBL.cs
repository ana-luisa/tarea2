using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Fiestas
{
    public class ReservaBL
    {
        public BindingList<Reserva> ListaReserva { get; set; }

        public ReservaBL()
        {
            ListaReserva = new BindingList<Reserva>();

            var reserva1 = new Reserva();
            reserva1.Id = 1;
            reserva1.Descripcion = "Mesas Cuadradas";
            reserva1.Precio = 50;
            reserva1.Existencia = 200;
            reserva1.Activo = true;

            ListaReserva.Add(reserva1);

            var reserva2 = new Reserva();
            reserva2.Id = 2;
            reserva2.Descripcion = "Mesas Redondas";
            reserva2.Precio = 55;
            reserva2.Existencia = 300;
            reserva2.Activo = true;

            ListaReserva.Add(reserva2);

            var reserva3 = new Reserva();
            reserva3.Id = 3;
            reserva3.Descripcion = "Sillas Plasticas";
            reserva3.Precio = 40;
            reserva3.Existencia = 1500;
            reserva3.Activo = true;

            ListaReserva.Add(reserva3);

            var reserva4 = new Reserva();
            reserva4.Id = 4;
            reserva4.Descripcion = "Sillas de Metal";
            reserva4.Precio = 50;
            reserva4.Existencia = 1500;
            reserva4.Activo = true;

            ListaReserva.Add(reserva4);

            var reserva5 = new Reserva();
            reserva5.Id = 5;
            reserva5.Descripcion = "Manteles Negros";
            reserva5.Precio = 55;
            reserva5.Existencia = 55;
            reserva5.Activo = true;

            ListaReserva.Add(reserva5);

            var reserva6 = new Reserva();
            reserva6.Id = 6;
            reserva6.Descripcion = "Manteles Blancos";
            reserva6.Precio = 55;
            reserva6.Existencia = 55;
            reserva6.Activo = true;

            ListaReserva.Add(reserva6);

            var reserva7 = new Reserva();
            reserva7.Id = 7;
            reserva7.Descripcion = "Manteles rojos";
            reserva7.Precio = 55;
            reserva7.Existencia = 55;
            reserva7.Activo = true;

            ListaReserva.Add(reserva7);

            var reserva8 = new Reserva();
            reserva8.Id = 8;
            reserva8.Descripcion = "Mateles Amarillos";
            reserva8.Precio = 55;
            reserva8.Existencia = 55;
            reserva8.Activo = true;

            ListaReserva.Add(reserva8);

            var reserva9 = new Reserva();
            reserva9.Id = 9;
            reserva9.Descripcion = "Salon capacidad 50";
            reserva9.Precio = 4000;
            reserva9.Existencia = 2;
            reserva9.Activo = true;

            ListaReserva.Add(reserva9);

            var reserva10 = new Reserva();
            reserva10.Id = 10;
            reserva10.Descripcion = "Salon Capacidad 100";
            reserva10.Precio = 5000;
            reserva10.Existencia = 2;
            reserva10.Activo = true;

            ListaReserva.Add(reserva10);

            var reserva11 = new Reserva();
            reserva11.Id = 11;
            reserva11.Descripcion = "Salon Capacidad 200";
            reserva11.Precio = 10000;
            reserva11.Existencia = 1;
            reserva11.Activo = true;

            ListaReserva.Add(reserva11);

            var reserva12 = new Reserva();
            reserva12.Id = 12;
            reserva12.Descripcion = "Salon Capacidad 300";
            reserva12.Precio = 15000;
            reserva12.Existencia = 1;
            reserva12.Activo = true;

            ListaReserva.Add(reserva12);
        }
        public BindingList<Reserva> ObtenerReservas()
        {
            return ListaReserva;
        }
        public Resultado GuardarResrva(Reserva reserva)
        {
            var resultado = Validar(reserva);
                if(resultado.Exitoso == false)
              {
                return resultado;
              }
            if (reserva.Id == 0)
            {
                reserva.Id = ListaReserva.Max(item => item.Id) + 1;
            }
            resultado.Exitoso = true;

            return resultado;
        }
        public void AgregarReserva()
        {


            var nuevaReserva = new Reserva();
            ListaReserva.Add(nuevaReserva);

        }

        public bool EliminarResrva(int id)
        {
            foreach (var reservalista in ListaReserva)
            {
                if (reservalista.Id == id)
                {
                    ListaReserva.Remove(reservalista);
                    return true;
                }
            }

            return false;
        }

            private Resultado Validar(Reserva reserva)
           {
            var resultado = new Resultado();
            resultado.Exitoso = true;
            if(string.IsNullOrEmpty(reserva.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una descripcion";
                resultado.Exitoso = false;
            }
            if (reserva.Existencia < 0)
            {
                resultado.Mensaje = "La existencia debe ser mayor que cero";
                resultado.Exitoso = false;
            }
            if (reserva.Precio < 0)
            {
                resultado.Mensaje = "el precio debe de ser mayor que cero";
                resultado.Exitoso = false;
            }
            return resultado;
           }
        

        public class Reserva
        {
            public int Id { get; set; }
            public string Descripcion { get; set; }
            public double Precio { get; set; }
            public int Existencia { get; set; }
            public bool Activo { get; set; }
        }

        public class Resultado
        { public bool Exitoso { get; set; }
            public string  Mensaje { get; set; }


        }
    }
}
