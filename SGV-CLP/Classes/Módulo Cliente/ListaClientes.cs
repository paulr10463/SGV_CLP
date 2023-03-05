using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes.Módulo_Cliente
{
    public static class ListaClientes
    {
        public static List<Cliente> clientes { get; set; }
        static ListaClientes() { 
            clientes= new List<Cliente>();
        }

        //retorna 0 si se encontro el cliente en la lista
        //retorna 1 si se cambio algun atributo del cliente
        //retorna -1 si no se encontró
        public static int findExistentClient(List<Cliente> listaClientes ,Cliente cliente)
        {
            foreach(Cliente item in listaClientes)
            {
                if (item.isEqual(cliente))
                   return 0;
                if (item.Cc_Cliente.Equals(cliente.Cc_Cliente))
                    return 1;  
            }
            return -1;
        }
    }
}
