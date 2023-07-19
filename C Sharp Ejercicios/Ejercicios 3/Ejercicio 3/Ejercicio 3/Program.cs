using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_3
    {
        public class Cliente
        {
            // Campos del cliente
            public string NombreCompleto { get; set; }
            public string Telefono { get; set; }
            public string Direccion { get; set; }
            public string Email { get; set; }
            public bool EsNuevoCliente { get; set; }

            // Constructor
            public Cliente(string nombreCompleto, string telefono, string direccion, string email, bool esNuevoCliente)
            {
                NombreCompleto = nombreCompleto;
                Telefono = telefono;
                Direccion = direccion;
                Email = email;
                EsNuevoCliente = esNuevoCliente;
            }

            // Método para presentar los datos del cliente
            public void PresentarCliente()
            {
                Console.WriteLine("Nombre completo: " + NombreCompleto);
                Console.WriteLine("Teléfono: " + Telefono);
                Console.WriteLine("Dirección: " + Direccion);
                Console.WriteLine("Email: " + Email);
                Console.WriteLine("Nuevo cliente: " + (EsNuevoCliente ? "Sí" : "No"));
            }
        }

        internal class Program
        {
            public static void Main()
            {
                // Crear un cliente
                Cliente cliente1 = new Cliente("Juan Pérez", "123456789", "Calle 123, Ciudad", "juan@example.com", true);

                // Mostrar los datos del cliente
                cliente1.PresentarCliente();
            }
        }
}

