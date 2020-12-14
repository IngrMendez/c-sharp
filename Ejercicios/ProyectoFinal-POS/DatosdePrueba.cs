using System;
using System.Collections.Generic;
public class DatosdePrueba
{
    public List<Producto> ListadeProductos { get; set; }
    public List<Cliente> ListadeClientes { get; set; }
    public List<Vendedor> ListadeVendedores { get; set; }
    public List<Orden> ListaOrdenes { get; set; }

    public DatosdePrueba()
    {
        ListadeProductos = new List<Producto>();
        cargarProductos();

        ListadeClientes = new List<Cliente>();
        cargarClientes();

        ListadeVendedores = new List<Vendedor>();
        cargarVendedores();

        ListaOrdenes = new List<Orden>();
    }

    private void cargarProductos()
    {
        Producto p1 = new Producto(1, "Camisa de Dama", 250);
        ListadeProductos.Add(p1);

        Producto p2 = new Producto(2, "Camisa de Caballero", 350);
        ListadeProductos.Add(p2);

        Producto p3 = new Producto(3, "Camiseta de Dama", 200);
        ListadeProductos.Add(p3);

        Producto p4 = new Producto(4, "Camiseta de Caballero", 250);
        ListadeProductos.Add(p4);

        Producto p5 = new Producto(5, "Pantalon de Dama", 350);
        ListadeProductos.Add(p5);

        Producto p6 = new Producto(6, "Pantalon de Caballero", 500);
        ListadeProductos.Add(p6);

        Producto p7 = new Producto(7, "Jeans de Dama", 250);
        ListadeProductos.Add(p7);

        Producto p8 = new Producto(8, "Jeans de Caballero", 350);
        ListadeProductos.Add(p8);

        Producto p9 = new Producto(9, "Short de Dama", 300);
        ListadeProductos.Add(p9);

        Producto p10 = new Producto(10, "Short de Caballero", 450);
        ListadeProductos.Add(p10);

        Producto p11 = new Producto(11, "Conjunto deportivo de Dama", 550);
        ListadeProductos.Add(p11);

        Producto p12 = new Producto(12, "Conjunto deportivo de Caballero", 700);
        ListadeProductos.Add(p12);

        Producto p13 = new Producto(13, "Zapato de Dama", 350);
        ListadeProductos.Add(p13);

        Producto p14 = new Producto(14, "Zapato de Caballero", 450);
        ListadeProductos.Add(p14);

        Producto p15 = new Producto(15, "Botas de Dama", 400);
        ListadeProductos.Add(p15);

        Producto p16 = new Producto(16, "Botas de Cabellero", 650);
        ListadeProductos.Add(p16);

        Producto p17 = new Producto(17, "Tenis de Dama", 350);
        ListadeProductos.Add(p17);

        Producto p18 = new Producto(18, "Tenis de Caballero", 400);
        ListadeProductos.Add(p18);

        Producto p19 = new Producto(19, "Sandalia de Dama", 250);
        ListadeProductos.Add(p19);

        Producto p20 = new Producto(20, "Sandalia de Cabellero", 350);
        ListadeProductos.Add(p20);

    }

    private void cargarClientes()
    {
        Cliente c1 = new Cliente(1, "Ana", "001");
        ListadeClientes.Add(c1);

        Cliente c2 = new Cliente(2, "Bayron", "002");
        ListadeClientes.Add(c2);

        Cliente c3 = new Cliente(3, "Carol", "003");
        ListadeClientes.Add(c3);

        Cliente c4 = new Cliente(4, "Danny", "004");
        ListadeClientes.Add(c4);

        Cliente c5 = new Cliente(5, "Esther", "005");
        ListadeClientes.Add(c5);

        Cliente c6 = new Cliente(6, "Fernin", "006");
        ListadeClientes.Add(c6);

        Cliente c7 = new Cliente(7, "Grecy", "007");
        ListadeClientes.Add(c7);

        Cliente c8 = new Cliente(8, "Herminio", "008");
        ListadeClientes.Add(c8);

        Cliente c9 = new Cliente(9, "Idania", "009");
        ListadeClientes.Add(c9);

        Cliente c10 = new Cliente(10, "Josue", "010");
        ListadeClientes.Add(c10);
    }

    private void cargarVendedores()
    {
        Vendedor v1 = new Vendedor(1, "Alex", "V001");
        ListadeVendedores.Add(v1);

        Vendedor v2 = new Vendedor(2, "Bessy", "V002");
        ListadeVendedores.Add(v2);

         Vendedor v3 = new Vendedor(3, "Carlos", "V003");
        ListadeVendedores.Add(v3);

        Vendedor v4 = new Vendedor(4, "Dania", "V004");
        ListadeVendedores.Add(v4);
    }

    public void ListarProductos()
    {
        Console.Clear();
        Console.WriteLine("******************");
        Console.WriteLine("Lista de Productos");
        Console.WriteLine("******************");
        Console.WriteLine("");
        Console.WriteLine(" Codigo | Nombre | Precio");
        Console.WriteLine("==========================");
        Console.WriteLine("");
        
        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Precio);
        }
        Console.WriteLine("");
        Console.Write("Presione la tecla enter para salir.");
        
        Console.ReadLine();
    }

    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("*****************");
        Console.WriteLine("Lista de Clientes");
        Console.WriteLine("*****************");
        Console.WriteLine("");
        Console.WriteLine(" Codigo | Nombre | Telefono");
        Console.WriteLine("============================");
        Console.WriteLine("");
        
        foreach (var cliente in ListadeClientes)
        {
            Console.WriteLine(cliente.Codigo + " | " + cliente.Nombre + " | " + cliente.Telefono);
        }
        Console.WriteLine("");
        Console.Write("Presione la tecla enter para salir.");
        
        Console.ReadLine();
    }

    public void ListarVendedores()
    {
        Console.Clear();
        Console.WriteLine("*******************");
        Console.WriteLine("Lista de Vendedores");
        Console.WriteLine("*******************");
        Console.WriteLine("");
        Console.WriteLine(" Codigo | Nombre | Codigo Vendedor");
        Console.WriteLine("============================");
        Console.WriteLine("");
        
        foreach (var vendedor in ListadeVendedores)
        {
            Console.WriteLine(vendedor.Codigo + " | " + vendedor.Nombre + " | " + vendedor.CodigoVendedor);
        }
        Console.WriteLine("");
        Console.Write("Presione la tecla enter para salir.");
        
        Console.ReadLine();
    }

    public void CrearOrden()
    {   
        Console.Clear();
        Console.WriteLine("*************");
        Console.WriteLine("Creando Orden");
        Console.WriteLine("*************");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el codigo del cliente: ");
        string codigoCliente = Console.ReadLine();

        Cliente cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigoCliente);        
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

        Console.WriteLine("Ingrese el codigo del vendedor: ");
        string codigoVendedor = Console.ReadLine();

        Vendedor vendedor = ListadeVendedores.Find(v => v.Codigo.ToString() == codigoVendedor);
        if (vendedor == null) 
        {
            Console.WriteLine("Vendedor no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Vendedor: " + vendedor.Nombre);
            Console.WriteLine("");
        }

        int nuevoCodigo = ListaOrdenes.Count + 1;

        Orden nuevaOrden = new Orden(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente, vendedor);
        ListaOrdenes.Add(nuevaOrden);

        while(true)
        {
            Console.WriteLine("Ingrese el producto: ");
            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);        
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                nuevaOrden.AgregarProducto(producto);
            }

            Console.WriteLine();
            Console.WriteLine("Desea continuar? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("SubTotal de la orden es de: " + nuevaOrden.SubTotal);
        Console.WriteLine("Impuesto de la orden es de: " + nuevaOrden.OrdenImpuesto);
        Console.WriteLine("Total de la orden es de: " + nuevaOrden.Total);
        Console.WriteLine("");
        Console.Write("Presione la tecla enter para salir.");
        Console.ReadLine();
    }

    public void ListarOrdenes()
    {
        Console.Clear();
        Console.WriteLine("****************");
        Console.WriteLine("Lista de Ordenes");
        Console.WriteLine("****************");
        Console.WriteLine("");  
        Console.WriteLine(" Codigo | Fecha | | SubTotal | Impuestos | Total");
        Console.WriteLine("=================================================");
        Console.WriteLine("");  

        foreach (var orden in ListaOrdenes)
        {
            Console.WriteLine(orden.Codigo + " | " + orden.Fecha + " | " + orden.SubTotal + " | " + orden.OrdenImpuesto + " | " + orden.Total);
            Console.WriteLine();
            Console.WriteLine("******************");
            Console.WriteLine("Cliente | Vendedor");
            Console.WriteLine("******************");
            Console.WriteLine(orden.Cliente.Nombre + " | " + orden.Vendedor.Nombre);
            Console.WriteLine("");  
            
            foreach (var detalle in orden.ListaOrdenDetalle)
            {
                Console.WriteLine("     " + detalle.Producto.Descripcion + " | " + detalle.Cantidad + " | " + detalle.Precio);
            }
        
            Console.WriteLine();
            
        } 

        Console.Write("Presione la tecla enter para salir.");
        Console.ReadLine();
    }
}