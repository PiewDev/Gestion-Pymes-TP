using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;
using Newtonsoft.Json;

namespace Logica.cs
{
    public class Empresa
    {
        public List<Productos> ListaProductos { get; set; }   //
        public List<Presupuestos> ListaPresupuestos { get; set; }  //
        public List<Clientes> ListaClientes { get; set; }   //
        public List<Ventas> ListaVentas { get; set; }   //
        public List<Devoluciones_Venta_Cancelada> ListaDevolucionVentasCanceladas { get; set; } //
        public List<Devolucion_Defectuosa> ListasDevolucionDefectuosa { get; set; }



        //Clientes
        private void GuardarEnDiscoCliente()
        {
            string output = JsonConvert.SerializeObject(this.ListaClientes);
            string path = Directory.GetCurrentDirectory() + "\\ListaClientes.json";
            using (StreamWriter file = new System.IO.StreamWriter(path, false))
            {
                file.Write(output);
            }               
        }

        public void DeserializarCliente()
        {
            string path = Directory.GetCurrentDirectory() + "\\ListaClientes.json";
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string contenido = reader.ReadToEnd();
                    this.ListaClientes = JsonConvert.DeserializeObject<List<Clientes>>(contenido);
                }
            }
            else
            {
                this.GuardarEnDiscoCliente();
            }
                
        }



        //Productos
        private void GuardarEnDiscoProducto()
        {
            string output = JsonConvert.SerializeObject(this.ListaProductos);
            string path = Directory.GetCurrentDirectory() + "\\ListaProductos.json";
            using (StreamWriter file = new System.IO.StreamWriter(path, false))
            {
                file.Write(output);
            }
        }

        public void DeserializarProducto()
        {
            string path = Directory.GetCurrentDirectory() + "\\ListaProductos.json";
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string contenido = reader.ReadToEnd();
                    this.ListaProductos = JsonConvert.DeserializeObject<List<Productos>>(contenido);
                }
            }
            else
            {
                this.GuardarEnDiscoProducto();
            }
            

        }

        //Presupuestos
        private void GuardarEnDiscoPresupuestos()
        {
            string output = JsonConvert.SerializeObject(this.ListaPresupuestos);
            string path = Directory.GetCurrentDirectory() + "\\ListaPresupuestos.json";
            using (StreamWriter file = new System.IO.StreamWriter(path, false))
            {
                file.Write(output);
            }
        }

        public void DeserializarPresupuestos()
        {
            string path = Directory.GetCurrentDirectory() + "\\ListaPresupuestos.json";
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string contenido = reader.ReadToEnd();
                    this.ListaPresupuestos = JsonConvert.DeserializeObject<List<Presupuestos>>(contenido);
                }
            }
            else
            {
                this.GuardarEnDiscoPresupuestos();
            }
            
        }

        //Venta
        private void GuardarEnDiscoVentas()
        {
            string output = JsonConvert.SerializeObject(this.ListaVentas);
            string path = Directory.GetCurrentDirectory() + "\\ListaVentas.json";
            using (StreamWriter file = new System.IO.StreamWriter(path, false))
            {
                file.Write(output);
            }
        }

        public void DeserializarVentas()
        {
            string path = Directory.GetCurrentDirectory() + "\\ListaVentas.json";
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string contenido = reader.ReadToEnd();
                    this.ListaVentas = JsonConvert.DeserializeObject<List<Ventas>>(contenido);
                }
            }
            else
            {
                GuardarEnDiscoVentas();
            }
            
        }


        // Devoluciones canceladas
        private void GuardarEnDiscoDevolucionesCanceladas()
        {
            string output = JsonConvert.SerializeObject(this.ListaDevolucionVentasCanceladas);
            string path = Directory.GetCurrentDirectory() + "\\ListaDevolucionesCanceladas.json";
            using (StreamWriter file = new System.IO.StreamWriter(path, false))
            {
                file.Write(output);
            }
        }

        public void DeserializarDevolucionesCanceladas()
        {
            string path = Directory.GetCurrentDirectory() + "\\ListaDevolucionesCanceladas.json";
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string contenido = reader.ReadToEnd();
                    this.ListaDevolucionVentasCanceladas = JsonConvert.DeserializeObject<List<Devoluciones_Venta_Cancelada>>(contenido);
                }
            }
            else
            {
                GuardarEnDiscoDevolucionesCanceladas();
            }
               
        
        }


        // Devoluciones defectuosa
        private void GuardarEnDiscoDevolucionesDefectuosas()
        {
            string output = JsonConvert.SerializeObject(this.ListasDevolucionDefectuosa);
            string path = Directory.GetCurrentDirectory() + "\\ListaDevolucionesDefectuosas.json";
            using (StreamWriter file = new System.IO.StreamWriter(path, false))
            {
                file.Write(output);
            }
        }

        public void DeserializarDevolucionesDefectuosas()
        {
            string path = Directory.GetCurrentDirectory() + "\\ListaDevolucionesDefectuosas.json";
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string contenido = reader.ReadToEnd();
                    this.ListasDevolucionDefectuosa = JsonConvert.DeserializeObject<List<Devolucion_Defectuosa>>(contenido);
                }
            }
            else
            {
                this.GuardarEnDiscoDevolucionesDefectuosas();
            }
           
        }
        

       
        public Empresa()
        {
            this.ListaClientes = new List<Clientes>();
            this.ListaPresupuestos = new List<Presupuestos>();
            this.ListaProductos = new List<Productos>();
            this.ListaVentas = new List<Ventas>();

        }

        public List<Presupuestos> ListaPresupuestosSinEliminados()
        {
            List<Presupuestos> ListaRetornar = new List<Presupuestos>();

            foreach (var item in this.ListaPresupuestos)
            {
                if (item.FechaBaja != DateTime.MinValue)
                {
                    ListaRetornar.Add(item);
                }
            }
            return ListaRetornar;
        }


        public Presupuestos PresupuestoBuscado(int parametro)
        {
            Presupuestos Retornar = new Presupuestos();
            foreach (var item in this.ListaPresupuestosSinEliminados())
            {
                if (item.Codigo == parametro)
                {
                    Retornar = item;
                }
            }
            return Retornar; ;
        }

        public List<Ventas> RetornarVentas()
        {
            return this.ListaVentas;
        }
        public List<Productos> ListaProductosConLosQueTienenStock()
        {
            List<Productos> ListaRetornar = new List<Productos>();

            foreach (var item in this.ListaProductos)
            {
                if (item.CantidadStock > 0)
                {
                    ListaRetornar.Add(item);
                }
            }
            return ListaRetornar;
        }

        public List<Productos> ListaProductosSinEliminados()
        {
            List<Productos> ListaRetornar = new List<Productos>();
            foreach (var item in this.ListaProductos)
            {
                if (item.FechaBaja != DateTime.MinValue)
                {
                    ListaRetornar.Add(item);
                }
            }
            return ListaRetornar;
        }

        public List<Clientes> ListaClientesSinEliminados()
        {
            List<Clientes> ListaRetornar = new List<Clientes>();
            foreach (var item in this.ListaClientes)
            {
                if (item.Fechabaja != DateTime.MinValue)
                {
                    ListaRetornar.Add(item);
                }
            }
            return ListaRetornar;
        }

        public ClienteSeleccionadoVentas ObtenerClientePorNombreYApellido(string nombre, string apellido)
        {
            ClienteSeleccionadoVentas ClienteRetornar = new ClienteSeleccionadoVentas();
            ClienteRetornar.Ok = false;

            foreach (var item in this.ListaClientes)
            {
                if (item.Apellido == apellido && item.Nombre == nombre)
                {
                    ClienteRetornar.ClienteSelect = item;
                    ClienteRetornar.Ok = true;
                }
            }

            return ClienteRetornar;
        } //Retorna un cliente por nombre y apellido

        public Productos ObtenerProductoPorNombre(string nombre)
        {
            return this.ListaProductos.Where(x => x.NombreProducto == nombre).FirstOrDefault();
        } //Retorna un producto por nombre
        public Productos ObtenerProductoPorNyC(string nombre, int codigo)
        {
            return this.ListaProductos.Where(x => x.NombreProducto == nombre && x.TipoProducto.ID == codigo).FirstOrDefault();
        } //Retorna un producto por nombre
        public string ObtenerNumeroSiguienteCliente()
        {
            return string.Format((ListaClientes.Count + 1).ToString());
        }

        public string ObtenerNumeroSiguienteProducto()
        {
            return string.Format((ListaProductos.Count + 1).ToString());
        } //Retorna el codigo del siguiente producto

        public void RestarProductosEnStock(int codigo, int cantidad)
        {
            foreach (var item in this.ListaProductos)
            {
                if (item.TipoProducto.ID == codigo)
                {
                    item.CantidadStock = item.CantidadStock - cantidad;
                }
            }
        } //Resta los productos que se vendieron

        public void CargarClientes(Clientes clientes_parametro)
        {
            Clientes NuevoCliente = new Clientes();

            NuevoCliente.Codigo = this.ListaClientes.Count + 1;
            NuevoCliente.Email = clientes_parametro.Email;
            NuevoCliente.FechaNacimiento = clientes_parametro.FechaNacimiento;
            NuevoCliente.Localidad = clientes_parametro.Localidad;
            NuevoCliente.Nombre = clientes_parametro.Nombre;
            NuevoCliente.Apellido = clientes_parametro.Apellido;
            NuevoCliente.Provincia = clientes_parametro.Provincia;
            NuevoCliente.Telefono = clientes_parametro.Telefono;
            NuevoCliente.Tipo = clientes_parametro.Tipo;
            NuevoCliente.PorcentajeDescuento = clientes_parametro.PorcentajeDescuento;
            NuevoCliente.Fechabaja = DateTime.Today;

            ListaClientes.Add(NuevoCliente);
            GuardarEnDiscoCliente();
        } //Carga un nuevo cliente


        public void Modificar_EliminarClientes(Clientes clientes_parametro)
        {
            foreach (var item in ListaClientes)
            {
                if (item.Codigo == clientes_parametro.Codigo)
                {
                    if (clientes_parametro.FechaNacimiento == DateTime.MinValue)
                    {
                        item.FechaNacimiento = DateTime.MinValue;
                    }
                    else
                    {
                        item.Email = clientes_parametro.Email;
                        item.FechaNacimiento = clientes_parametro.FechaNacimiento;
                        item.Localidad = clientes_parametro.Localidad;
                        item.Nombre = clientes_parametro.Nombre;
                        item.Apellido = clientes_parametro.Apellido;
                        item.Provincia = clientes_parametro.Provincia;
                        item.Telefono = clientes_parametro.Telefono;
                        item.Tipo = clientes_parametro.Tipo;
                        item.PorcentajeDescuento = clientes_parametro.PorcentajeDescuento;
                    }
                }
            }
            GuardarEnDiscoCliente();
        }

        public void Modificar_EliminarProductos(Productos productos_parametro)
        {
            foreach (var item in ListaProductos)
            {
                if (item.TipoProducto.ID == productos_parametro.TipoProducto.ID)
                {
                    if (productos_parametro.FechaBaja== DateTime.MinValue)
                    {
                        item.FechaBaja = DateTime.MinValue;
                    }
                    else
                    {
                        item.CantidadStock = productos_parametro.CantidadStock;
                        item.FechaBaja = productos_parametro.FechaBaja;
                        item.NombreProducto = productos_parametro.NombreProducto;
                        item.PrecioUnitario = productos_parametro.PrecioUnitario;
                        item.TipoProducto = productos_parametro.TipoProducto;
                        
                       
                    }
                }
            }
            GuardarEnDiscoProducto();
        }
                
        public void CargarProductos(Productos productos_parametro)
        {
            Productos NuevoProducto = new Productos();

            NuevoProducto.CantidadStock = productos_parametro.CantidadStock;
            NuevoProducto.NombreProducto = productos_parametro.NombreProducto;
            NuevoProducto.PrecioUnitario = productos_parametro.PrecioUnitario;
            NuevoProducto.FechaBaja = DateTime.Today;

            if (NuevoProducto.TipoProducto != null) //
            {
                NuevoProducto.TipoProducto.ID = ListaProductos.Count + 1;
                NuevoProducto.TipoProducto.Detalle = productos_parametro.TipoProducto.Detalle;
            }
            ListaProductos.Add(NuevoProducto);
            GuardarEnDiscoProducto();
        }   //Carga un nuevo producto

        public void GuardarVentas(Ventas ventas_parametro)
        {
            Ventas NuevaVenta = new Ventas();

            NuevaVenta.ClienteAsociado = ventas_parametro.ClienteAsociado;
            NuevaVenta.FechaVenta = ventas_parametro.FechaVenta;
            NuevaVenta.ListadoProductosVendidos = ventas_parametro.ListadoProductosVendidos;
            NuevaVenta.PorcentajeDescuentoAplicado = ventas_parametro.PorcentajeDescuentoAplicado;
            NuevaVenta.TotalVenta = ventas_parametro.TotalVenta;
            NuevaVenta.Codigo = this.ListaVentas.Count + 1;

            ListaVentas.Add(NuevaVenta);
            GuardarEnDiscoVentas();
        } //Carga una nueva venta

        public void CargarPresupuesto(Presupuestos parametro_presupuesto)
        {
            Presupuestos NuevoPresupuesto = new Presupuestos();
            NuevoPresupuesto.DiasDeValidez = 30; //por defecto

            NuevoPresupuesto.FechaBaja = DateTime.Today;
            NuevoPresupuesto.ClienteAsociado = parametro_presupuesto.ClienteAsociado;
            NuevoPresupuesto.DiasDeValidez = parametro_presupuesto.DiasDeValidez;
            NuevoPresupuesto.FechaPresupuesto = parametro_presupuesto.FechaPresupuesto;
            NuevoPresupuesto.FechaVenta = parametro_presupuesto.FechaVenta;
            NuevoPresupuesto.ListadoProductosVendidos = parametro_presupuesto.ListadoProductosVendidos;
            NuevoPresupuesto.PorcentajeDescuentoAplicado = parametro_presupuesto.PorcentajeDescuentoAplicado;
            NuevoPresupuesto.TotalVenta = parametro_presupuesto.TotalVenta;
            NuevoPresupuesto.Codigo = this.ListaPresupuestos.Count + 1;

            this.ListaPresupuestos.Add(NuevoPresupuesto);
            GuardarEnDiscoPresupuestos();
        } //Carga un nuevo presupuesto

        public ConverPresupuestoEnVenta ConvertirPresupuestoEnVenta(Presupuestos parametro_presupuesto)
        {
            ConverPresupuestoEnVenta realizado = new ConverPresupuestoEnVenta();
            realizado.Ok = true;
            realizado.Texto = "El presupuesto se ha convertido en venta";
            foreach (var item in this.ListaPresupuestos)
            {
                if (item.Codigo == parametro_presupuesto.Codigo)
                {
                    realizado.Presupuesto = item;
                    TimeSpan DiferenciaDias = DateTime.Today - item.FechaPresupuesto;
                    if (item.DiasDeValidez <= DiferenciaDias.Days)
                    {
                        realizado.Ok = false;
                        realizado.Texto = "El presupuesto no se puede convertir en venta porque ya pasaron los días de validez";
                    }
                    else
                    {
                        int cont;
                        foreach (var producto in this.ListaProductos)
                        {
                            cont = 0;
                            foreach (var presupuesto in item.ListadoProductosVendidos)
                            {
                                if (producto.TipoProducto.ID == presupuesto.CodigoProducto)
                                {
                                    cont = cont + 1;
                                }
                            }
                            if (cont > producto.CantidadStock)
                            {
                                realizado.Ok = false;
                                realizado.Texto = "El presupuesto no se puede convertir en venta porque no hay stock de algun producto";
                            }
                        }
                    }
                }
            }
            return realizado;
        } //Convierte el prespuesto en venta

        public void AlmacenarDevolucionVentaDefectuosa(Devolucion_Defectuosa parametro_devolucion)
        {
            Devolucion_Defectuosa NuevaDevolucionDefectuosa = new Devolucion_Defectuosa();

            NuevaDevolucionDefectuosa.CodigoVenta = parametro_devolucion.CodigoVenta;
            NuevaDevolucionDefectuosa.ComentarioCliente = parametro_devolucion.ComentarioCliente;
            NuevaDevolucionDefectuosa.FechaDevolucion = parametro_devolucion.FechaDevolucion;
            NuevaDevolucionDefectuosa.MotivoDefecto = parametro_devolucion.MotivoDefecto;

            Random generator = new Random();
            int Cod = generator.Next(1, 10000000);
            NuevaDevolucionDefectuosa.NumeroReclamo = Cod;

            this.ListasDevolucionDefectuosa.Add(NuevaDevolucionDefectuosa);
            GuardarEnDiscoDevolucionesDefectuosas();
        } //Carga de una devolucion defectuosa
       
        public void AlmacenarDevolucionesVentaCancelada(Devoluciones_Venta_Cancelada parametro_devolucion)
        {
            Devoluciones_Venta_Cancelada NuevaDevolucionVentaCancelada = new Devoluciones_Venta_Cancelada();

            NuevaDevolucionVentaCancelada.FechaDevolucion = parametro_devolucion.FechaDevolucion;
            NuevaDevolucionVentaCancelada.CodigoVenta = parametro_devolucion.CodigoVenta;

            Random generator = new Random();
            int Cod = generator.Next(1, 10000000);

            NuevaDevolucionVentaCancelada.NumeroDevolucion = Cod;

            foreach (var item in this.ListaVentas)
            {
                if (item.Codigo == parametro_devolucion.CodigoVenta)
                {
                    foreach (var producto in this.ListaProductos)
                    {
                        foreach (var productosventidos in item.ListadoProductosVendidos)
                        {
                            if (producto.TipoProducto.ID == productosventidos.CodigoProducto)
                            {
                                producto.CantidadStock = producto.CantidadStock + productosventidos.Cantidad;
                            }
                        }
                    }
                }
            }
            ListaDevolucionVentasCanceladas.Add(NuevaDevolucionVentaCancelada);
            GuardarEnDiscoDevolucionesCanceladas();
        } //Carga una devolucion por venta cancelada y devuelve los productos de la venta 

        //Reporte 1 Lista de ventas en un periodo de fechas pasado como parametro
        public List<ReporteListaEnPeriodoFechas> ReporteEnUnPeriodoDeFechasYClientePorParametro(DateTime fechadesde, DateTime fechahasta, string nombre, string apellido)
        {
            List<ReporteListaEnPeriodoFechas> ListaRetornar = new List<ReporteListaEnPeriodoFechas>();

            int codigocliente = 0;
            foreach (var item in this.ListaClientes)
            {
                if (item.Apellido == apellido && item.Nombre == nombre)
                {
                    codigocliente = item.Codigo;
                }
            }

            foreach (var item in this.ListaVentas)
            {
                if (item.ClienteAsociado == codigocliente && item.FechaVenta >= fechadesde && item.FechaVenta <= fechahasta)
                {
                    ReporteListaEnPeriodoFechas Detalle = new ReporteListaEnPeriodoFechas();
                    Detalle.Fecha = item.FechaVenta;
                    Detalle.MontoTotal = item.TotalVenta.ToString("N2");
                    Detalle.NumeroDeVenta = item.Codigo;

                    string Nombre = "";
                    foreach (var item2 in this.ListaClientes)
                    {
                        if (item2.Codigo == item.ClienteAsociado)
                        {
                            Nombre = item2.Nombre;
                        }
                    }

                    Detalle.NombreCliente = Nombre;
                    ListaRetornar.Add(Detalle);
                }
            }
            return ListaRetornar;
        }

        //Reporte 2 
        public ReporteProdVendidosContraProdDefectuosos ReporteProducVencontraDefec(string parametro_nombre)
        {
            ReporteProdVendidosContraProdDefectuosos Retornar = new ReporteProdVendidosContraProdDefectuosos();

            Retornar.NombreProducto = parametro_nombre;

            int cantven = 0, candef = 0;
            foreach (var productos in this.ListaProductos)
            {
                if (productos.NombreProducto == parametro_nombre)
                {
                    if (this.ListaVentas==null)
                    {

                    }
                    else
                    {
                        foreach (var ventas in this.ListaVentas)
                        {
                            foreach (var listaprod in ventas.ListadoProductosVendidos)
                            {
                                if (productos.TipoProducto.ID == listaprod.CodigoProducto)
                                {
                                    cantven = cantven + listaprod.Cantidad;
                                }
                            }
                        
                   
                        if (this.ListasDevolucionDefectuosa==null)
                        {
                            candef = 0;
                        }
                        else
                        {
                            foreach (var item in this.ListasDevolucionDefectuosa)
                            {
                                if (item.CodigoVenta == ventas.Codigo)
                                {
                                    foreach (var listaprod in ventas.ListadoProductosVendidos)
                                    {
                                        candef = candef + listaprod.Cantidad;
                                    }
                                }
                            }
                        }
                        }
                    }
                }
            }

            Retornar.CantidadVendidos = cantven.ToString();
            Retornar.CantidadDefectuosos = candef.ToString();

            decimal porcentaje = (cantven * candef) / 100;
            Retornar.PorcentajeDefecYVendidos = porcentaje.ToString("N2");
            return Retornar;
        }

        //Reporte 3
        public List<ReporteVendidoPorMes> ReporteVentasPorMesEnUnRangoDeFechas(DateTime fechadesde, DateTime fechahasta)
        {
            List<ReporteVendidoPorMes> ListaRetornar = new List<ReporteVendidoPorMes>();
            ReporteVendidoPorMes Agregar = new ReporteVendidoPorMes();
            Agregar.GananciaEstimada = 0.ToString();
            Agregar.TotalCosto = 0.ToString();
            Agregar.TotalVendido = 0.ToString();

            decimal[] AcuxMes = new decimal[12];

            for (int i = 0; i < AcuxMes.Length; i++)
            {
                AcuxMes[i] = 0;
            }
            
            foreach (var item in this.ListaVentas)
            {
                if (item.FechaVenta >= fechadesde && item.FechaVenta <= fechahasta)
                {
                    for (int i = 0; i < AcuxMes.Length; i++)
                    {
                        AcuxMes[item.FechaVenta.Month] = AcuxMes[item.FechaVenta.Month] + (item.TotalVenta);
                    }
                }
            }            

            for (int i = 0; i < AcuxMes.Length; i++)
            {
                if (AcuxMes[i] != 0)
                {                    
                    Agregar.Mes = RetornarMes(i.ToString());
                    Agregar.TotalVendido = ((AcuxMes[i]) / 12).ToString("N2");
                  
                }
            }

            decimal acudef = 0,ganancia=0;
            if (this.ListasDevolucionDefectuosa!=null)
            {
                foreach (var item in this.ListasDevolucionDefectuosa)
                {
                    foreach (var item2 in this.ListaVentas)
                    {
                        if (item.CodigoVenta == item2.Codigo)
                        {
                            acudef = acudef + item2.TotalVenta;
                        }
                    }
                }
            }
            
            Agregar.TotalCosto = acudef.ToString("N2");
            Agregar.GananciaEstimada= (decimal.Parse(Agregar.TotalVendido)-acudef).ToString("N2");


            ListaRetornar.Add(Agregar);
            return ListaRetornar;
        }

        private string RetornarMes(string numero)
        {
            string mes = "";

            switch (numero)
            {
                case "01":
                    mes = "Enero";
                    break;
                case "02":
                    mes = "Febrero";
                    break;
                case "03":
                    mes = "Marzo";
                    break;
                case "04":
                    mes = "Abril";
                    break;
                case "05":
                    mes = "Mayo";
                    break;
                case "06":
                    mes = "Junio";
                    break;
                case "07":
                    mes = "Julio";
                    break;
                case "08":
                    mes = "Agosto";
                    break;
                case "09":
                    mes = "Septiembre";
                    break;
                case "10":
                    mes = "Octubre";
                    break;
                case "11":
                    mes = "Noviembre";
                    break;
                case "12":
                    mes = "Diciembre";
                    break;
            }

            return mes;
        }  //Retorna nombre de mes
    }
}



