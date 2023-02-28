﻿using SGV_CLP.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGV_CLP.Classes.Modulo_Ventas
{
    public class NotaVenta
    {
        public List<DetalleNotaVenta> listaDetalleNotaVenta;
        public Cliente? cliente;
        public Usuario? usuario;
        public string? codFactura;
        public double precioFinal;
        public DateTime? fechaVenta;

        public NotaVenta(Cliente cliente, string codFactura, double precioFinal, DateTime fechaVenta)
        {
            this.listaDetalleNotaVenta = new List<DetalleNotaVenta>();
            this.cliente = cliente;
            this.codFactura = codFactura;
            this.precioFinal = precioFinal;
            this.fechaVenta = fechaVenta;
        }

        public NotaVenta(string codFactura, string cc_cliente, string user_Name, double precioFinal, DateTime fechaVenta)
        {
            this.listaDetalleNotaVenta = new List<DetalleNotaVenta>();
            this.cliente = new Cliente();
            this.usuario = new Usuario();
            this.cliente.Cc_Cliente = cc_cliente;
            this.codFactura = codFactura;
            this.usuario.userName = user_Name;
            this.precioFinal = precioFinal;
            this.fechaVenta = fechaVenta;
        }

        public NotaVenta()
        {
            this.listaDetalleNotaVenta = new List<DetalleNotaVenta>();
            precioFinal = 0;
        }

        public double? calcularTotalVentas()
        {
            double? total = 0;
            foreach (DetalleNotaVenta item in listaDetalleNotaVenta)
            {
                total += item.subtotal;
            }
            return total;
        }
        public void setTotalVentas()
        {
            this.precioFinal = (double)calcularTotalVentas();
        }
        public void addOrUpdateDetalleVenta(DetalleNotaVenta detalleNotaVenta)
        {

            bool flag = false;
            int counter = 0;
            foreach (DetalleNotaVenta item in listaDetalleNotaVenta)
            {
                if (item.producto != null)
                {
                    if (item.producto.Nombre.Equals(detalleNotaVenta.producto.Nombre))
                    {
                        listaDetalleNotaVenta[counter].cantidad = detalleNotaVenta.cantidad;
                        this.setTotalVentas();
                        flag = true;
                    }
                }
                else
                {
                    break;
                }
                counter++;
            }
            if (!flag)
            {
                listaDetalleNotaVenta.Add(detalleNotaVenta);
            }
        }

        public void deleteDetailbyProductName(string productName)
        {
            for(int i = 0; i < listaDetalleNotaVenta.Count; i++)
            {
                if (listaDetalleNotaVenta[i].producto.Nombre.Equals(productName))
                {
                    listaDetalleNotaVenta.RemoveAt(i);
                }
            }
        }
    }
}