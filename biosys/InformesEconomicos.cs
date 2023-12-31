﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace biosys
{
    public partial class InformesEconomicos : Form
    {
        public Dashboard DashboardInstance { get; set; }

        public InformesEconomicos()
        {
            InitializeComponent();
        }

        private void InformesEconomicos_Load(object sender, EventArgs e)
        {
            ComprasTotal();
            VentasTotal();
            CrearGraficoArboles();
            CrearGraficoSemillas();
        }
        public void ComprasTotal()
        {
            // Obtener los datos de montos de compras por tipo (Semilla o Árbol)
            DataTable datosComprasPorTipo = Controladora.Controladora.ObtenerMontosComprasPorTipo();

            // Configurar el gráfico de torta
            CompraTotal.Series.Clear();
            CompraTotal.ChartAreas.Clear();
            CompraTotal.ChartAreas.Add(new ChartArea());

            // Agregar la serie para el gráfico de torta
            Series seriesTorta = new Series("Compras");
            seriesTorta.ChartType = SeriesChartType.Pie;
            seriesTorta.IsVisibleInLegend = false; // No mostrar leyendas

            // Asignar los puntos de datos a la serie
            foreach (DataRow row in datosComprasPorTipo.Rows)
            {
                string tipoProducto = row.Field<string>("TipoProducto");
                decimal montoTotal = row.Field<decimal>("MontoTotal");

                // Agregar un punto de datos para cada tipo de producto
                DataPoint dataPoint = new DataPoint();
                dataPoint.AxisLabel = tipoProducto; // Etiqueta en el gráfico (Semillas o Arboles)
                dataPoint.Label = tipoProducto + "\n$" + montoTotal.ToString("N2"); // Etiqueta debajo de la torta con el monto formateado
                dataPoint.YValues = new double[] { (double)montoTotal }; // Valor numérico

                // Definir colores personalizados para cada tipo de producto
                if (tipoProducto == "Semillas")
                {
                    dataPoint.Color = Color.GreenYellow;
                    dataPoint.ToolTip = "Semillas"; // Etiqueta arriba del importe
                }
                else if (tipoProducto == "Árboles")
                {
                    dataPoint.Color = Color.Orange;
                    dataPoint.ToolTip = "Arboles"; // Etiqueta arriba del importe
                }

                dataPoint.BorderWidth = 1;
                dataPoint.BorderColor = Color.Black;

                seriesTorta.Points.Add(dataPoint);
            }

            // Agregar la serie al gráfico
            CompraTotal.Series.Add(seriesTorta);

            // Establecer el tamaño de la fuente para las etiquetas personalizadas dentro del gráfico
            foreach (DataPoint dataPoint in seriesTorta.Points)
            {
                dataPoint.Font = new Font("Arial", 11, FontStyle.Regular);
            }

            // Mostrar el título del gráfico
            CompraTotal.Titles.Clear();
            CompraTotal.Titles.Add("Compras");
            CompraTotal.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);

            // Mostrar el total en la parte inferior del gráfico
            decimal totalCompras = datosComprasPorTipo.AsEnumerable().Sum(row => row.Field<decimal>("MontoTotal"));
            CompraTotal.Titles.Add($"Total: ${totalCompras.ToString("N2")}");
            CompraTotal.Titles[1].Font = new Font("Arial", 12, FontStyle.Regular);

            // Configurar el color de la serie
            CompraTotal.Palette = ChartColorPalette.None;
            CompraTotal.PaletteCustomColors = new Color[] { Color.Orange, Color.GreenYellow };

            // Actualizar el gráfico
            CompraTotal.DataBind();
        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            Informes informesForm = new Informes();
            informesForm.DashboardInstance = DashboardInstance;
            DashboardInstance.AbrirFormHijo(informesForm);
        }

        // Método para obtener la información de los gráficos de InformesEconomicos
        public string ObtenerInformacionGraficos()
        {
            ComprasTotal();
            VentasTotal();
            CrearGraficoArboles();
            CrearGraficoSemillas();

            StringBuilder sb = new StringBuilder();

            // Información del gráfico de Compras
            sb.AppendLine($"Total de Compras = ${CompraTotal.Titles[1].Text.Replace("Total: $", "")}");
            sb.AppendLine();

            // Información del gráfico de Ventas
            sb.AppendLine($"Total de Ventas = ${VentaTotal.Titles[1].Text.Replace("Total: $", "")}");
            sb.AppendLine();

            // Información de los tres árboles más vendidos
            sb.AppendLine("Los tres árboles más vendidos:");
            DataTable arbolesData = Controladora.Controladora.ObtenerTresArbolesMasVendidos();
            for (int i = 0; i < arbolesData.Rows.Count; i++)
            {
                DataRow row = arbolesData.Rows[i];
                string producto = row.Field<string>("Producto");
                decimal importe = row.Field<decimal>("MontoTotal");
                sb.AppendLine($"{i + 1}. {producto} - ${importe.ToString("N2")}");
            }
            sb.AppendLine();

            // Información de las tres semillas más compradas
            sb.AppendLine("Las tres semillas más compradas:");
            DataTable semillasData = Controladora.Controladora.ObtenerTresSemillasMasCompradas();
            for (int i = 0; i < semillasData.Rows.Count; i++)
            {
                DataRow row = semillasData.Rows[i];
                string producto = row.Field<string>("Producto");
                decimal importe = row.Field<decimal>("MontoTotal");
                sb.AppendLine($"{i + 1}. {producto} - ${importe.ToString("N2")}");
            }

            return sb.ToString();
        }

        public void VentasTotal()
        {
            // Obtener los datos de montos de ventas por tipo (Semilla o Árbol)
            DataTable datosVentasPorTipo = Controladora.Controladora.ObtenerMontosVentasPorTipo();

            // Configurar el gráfico de torta para ventas
            VentaTotal.Series.Clear();
            VentaTotal.ChartAreas.Clear();
            VentaTotal.ChartAreas.Add(new ChartArea());

            // Agregar la serie para el gráfico de torta
            Series seriesTorta = new Series("Ventas");
            seriesTorta.ChartType = SeriesChartType.Pie;
            seriesTorta.IsVisibleInLegend = false; // No mostrar leyendas

            // Asignar los puntos de datos a la serie
            foreach (DataRow row in datosVentasPorTipo.Rows)
            {
                string tipoProducto = row.Field<string>("TipoProducto");
                decimal montoTotal = row.Field<decimal>("MontoTotal");

                // Agregar un punto de datos para cada tipo de producto
                DataPoint dataPoint = new DataPoint();
                dataPoint.AxisLabel = tipoProducto; // Etiqueta en el gráfico (Semillas o Arboles)
                dataPoint.Label = tipoProducto + "\n$" + montoTotal.ToString("N2"); // Etiqueta debajo de la torta con el monto formateado
                dataPoint.YValues = new double[] { (double)montoTotal }; // Valor numérico

                // Definir colores personalizados para cada tipo de producto
                if (tipoProducto == "Semillas")
                {
                    dataPoint.Color = Color.GreenYellow;
                    dataPoint.ToolTip = "Semillas"; // Etiqueta arriba del importe
                }
                else if (tipoProducto == "Árboles")
                {
                    dataPoint.Color = Color.Orange;
                    dataPoint.ToolTip = "Arboles"; // Etiqueta arriba del importe
                }

                dataPoint.BorderWidth = 1;
                dataPoint.BorderColor = Color.Black;

                seriesTorta.Points.Add(dataPoint);
            }

            // Agregar la serie al gráfico
            VentaTotal.Series.Add(seriesTorta);

            // Establecer el tamaño de la fuente para las etiquetas personalizadas dentro del gráfico
            foreach (DataPoint dataPoint in seriesTorta.Points)
            {
                dataPoint.Font = new Font("Arial", 11, FontStyle.Regular);
            }

            // Mostrar el título del gráfico
            VentaTotal.Titles.Clear();
            VentaTotal.Titles.Add("Ventas");
            VentaTotal.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);

            // Mostrar el total en la parte inferior del gráfico
            decimal totalVentas = datosVentasPorTipo.AsEnumerable().Sum(row => row.Field<decimal>("MontoTotal"));
            VentaTotal.Titles.Add($"Total: ${totalVentas.ToString("N2")}");
            VentaTotal.Titles[1].Font = new Font("Arial", 12, FontStyle.Regular);

            // Configurar el color de la serie
            VentaTotal.Palette = ChartColorPalette.None;
            VentaTotal.PaletteCustomColors = new Color[] { Color.Orange, Color.GreenYellow };

            // Actualizar el gráfico
            VentaTotal.DataBind();
        }
        public void CrearGraficoArboles()
        {
            DataTable arbolesData = Controladora.Controladora.ObtenerTresArbolesMasVendidos();

            // Verifica si hay datos disponibles
            if (arbolesData.Rows.Count > 0)
            {
                // Configurar el gráfico de barras para los árboles más vendidos
                ConfigurarGraficoBarras(chartArboles, arbolesData, "Los tres árboles más vendidos", "Árboles", "Monto");
            }
            else
            {
                // No hay datos, mostrar un mensaje predeterminado
                chartArboles.Series.Clear();
                chartArboles.Titles.Clear();
                chartArboles.Titles.Add(new Title("Aún no hay ventas de árboles", Docking.Top, new Font("Arial", 12, FontStyle.Bold), Color.Black));
            }
        }

        public void CrearGraficoSemillas()
        {
            DataTable semillasData = Controladora.Controladora.ObtenerTresSemillasMasCompradas();

            // Verifica si hay datos disponibles
            if (semillasData.Rows.Count > 0)
            {
                // Configurar el gráfico de barras para las semillas más compradas
                ConfigurarGraficoBarras(chartSemillas, semillasData, "Las tres semillas más compradas", "Semillas", "Monto");
            }
            else
            {
                // No hay datos, mostrar un mensaje predeterminado
                chartSemillas.Series.Clear();
                chartSemillas.Titles.Clear();
                chartSemillas.Titles.Add(new Title("Aún no hay compras de semillas", Docking.Top, new Font("Arial", 12, FontStyle.Bold), Color.Black));
            }
        }

        public void ConfigurarGraficoBarras(Chart chart, DataTable data, string titulo, string ejeX, string ejeY)
        {
            chart.Series.Clear();
            chart.ChartAreas.Clear();
            chart.ChartAreas.Add(new ChartArea());

            Series seriesBarras = new Series();
            seriesBarras.ChartType = SeriesChartType.Bar;
            seriesBarras.IsVisibleInLegend = false; // Ocultar leyenda

            foreach (DataRow row in data.Rows)
            {
                string producto = row.Field<string>("Producto");
                decimal importe = row.Field<decimal>("MontoTotal");

                DataPoint dataPoint = new DataPoint();
                dataPoint.AxisLabel = producto;
                dataPoint.Label = "$" + importe.ToString("N2"); // Mostrar el monto en negrita dentro de la barra
                dataPoint.YValues = new double[] { (double)importe };

                seriesBarras.Points.Add(dataPoint);
            }

            chart.Series.Add(seriesBarras);
            chart.Titles.Clear();
            chart.Titles.Add(new Title(titulo, Docking.Top, new Font("Arial", 12, FontStyle.Bold), Color.Black));

            chart.ChartAreas[0].AxisX.Title = ejeX;
            chart.ChartAreas[0].AxisY.Title = ejeY;
            chart.ChartAreas[0].AxisX.Interval = 1;

            // Quitar las líneas de la grilla interna
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            chart.DataBind();
        }
    }
}
