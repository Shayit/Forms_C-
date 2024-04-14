using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda
{
    internal class Lógica
    {
        public string Producto { get; set; }
        public int Cantidad { get; set; }   

        public double AsignarPrecios()
        {
            switch(Producto)
            {
                case "Teclado Razer": return 300000;
                case "Mouse ergonomico": return 60000;
                case "RX 7600": return 2000000;
                case "MSI B550M": return 800000;
                case "Ryzen 7 5700G": return 750000;
                case "Ryzen 7 5700X": return 920000;
                case "Ryzen 5 5600X": return 820000;
                case "Ryzen 5 5600G": return 890000;
                case "Intel Core i9": return 3000000;
                case "RX 6650": return 1500000;
                case "GTX 4080": return 6900000;
            }

            return 0;
        }

        public double CalcularSubtotal()
        {
            return AsignarPrecios() * Cantidad;
        }

        public double CalcularDescuento() { 
            
            double Subtotal = CalcularSubtotal();

            if(Subtotal <= 1000000) return 8.0 / 100 * Subtotal;
            else if (Subtotal>1000000 && Subtotal <= 3000000) return 13.0 /100 * Subtotal;
            else return 16.5 /100 * Subtotal;
        
        }

        public double CalcularNeto()
        {
            return CalcularSubtotal() - CalcularDescuento();
        }
    }
}