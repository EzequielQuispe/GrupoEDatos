﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ModuloStock
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Producto> listaProductos = new List<Producto>(); //llamo al constructor para crear una instancia
            //Producto alfajor = new Producto(1, "Alfajor Jorgito", 10.5);
            //Producto gaseosa = new Producto(2, "Coca-Cola", 30);
            //Producto galletitas = new Producto(3, "Galletitas Chocolinas", 35);

            //listaProductos.Add(alfajor);
            //listaProductos.Add(gaseosa);
            //listaProductos.Add(galletitas);
            //listaProductos[0].AgregarElemento("Alfajor Jorgito 1");
            //listaProductos[0].AgregarElemento("Alfajor Jorgito 2");
            //listaProductos[0].AgregarElemento("Alfajor Jorgito 3");


            //for (int i = 0; i < listaProductos.Count; i++)
            //{
            //    Console.WriteLine(listaProductos[i].MostrarCodigo()
            //        + " " + listaProductos[i].MostrarNombre()
            //        + " " + listaProductos[i].MostrarPrecio()
            //        + " " + listaProductos[i].MostrarCantidad());


            //}
            //Console.WriteLine("Que producto desea?");
            //int codigo = int.Parse(Console.ReadLine());
            //listaProductos.First(x => x.MostrarCodigo() == codigo).QuitarElemento();
            //for (int i = 0; i < listaProductos.Count; i++)
            //{
            //    Console.WriteLine(listaProductos[i].MostrarCodigo()
            //        + " " + listaProductos[i].MostrarNombre()
            //        + " " + listaProductos[i].MostrarPrecio()
            //        + " " + listaProductos[i].MostrarCantidad());


            //}

            Stock.stock.InicializarStock();
            //Stock producto = new Stock();
            //producto.InicializarStock();
            VentanaInicio inicio = new VentanaInicio();
            inicio.IniciarAplicacion();
            
            //Console.ReadLine();
        }
    }
}
