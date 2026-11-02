
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using carCheckEntities;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace carCheckFront
{
    public static class ReporteHistorialPdf
    {
        public static void Generar(
            Vehiculo vehiculo,
            IReadOnlyCollection<Servicio> servicios,
            string ruta)
        {
            if (vehiculo == null)
                throw new ArgumentNullException(nameof(vehiculo));

            if (string.IsNullOrWhiteSpace(ruta))
                throw new ArgumentException(
                    "Debe indicar dónde guardar el PDF.",
                    nameof(ruta));

            // Normalizar el historial
            var listaServicios = servicios?.ToList()
                ?? new List<Servicio>();

            // Resumen general
            int cantidadServicios = listaServicios.Count;

            decimal costoTotal = listaServicios.Sum(s => s.Costo);

            // Agrupación por tipo de servicio
            var resumenPorTipo = listaServicios
                .GroupBy(s =>
                    string.IsNullOrWhiteSpace(s.TipoServicio?.Nombre)
                        ? "Sin especificar"
                        : s.TipoServicio.Nombre)
                .Select(grupo => new
                {
                    Tipo = grupo.Key,
                    Cantidad = grupo.Count(),
                    Costo = grupo.Sum(s => s.Costo)
                })
                .OrderBy(g => g.Tipo)
                .ToList();

            QuestPDF.Settings.License = LicenseType.Community;

            Document.Create(documento =>
            {
                documento.Page(pagina =>
                {
                    pagina.Size(PageSizes.A4);
                    pagina.Margin(32);

                    pagina.DefaultTextStyle(
                        estilo => estilo.FontSize(9));

                    // ENCABEZADO
                    pagina.Header().Column(encabezado =>
                    {
                        encabezado.Item()
                            .Text("CarCheck")
                            .FontSize(22)
                            .Bold()
                            .FontColor(Colors.Blue.Medium);

                        encabezado.Item()
                            .Text("Informe de historial de mantenimiento")
                            .FontSize(15)
                            .Bold();

                        encabezado.Item()
                            .Text(
                                $"Fecha de generación: {DateTime.Now:dd/MM/yyyy HH:mm}");
                    });

                    // CONTENIDO
                    pagina.Content()
                        .PaddingVertical(18)
                        .Column(contenido =>
                        {
                            contenido.Spacing(12);

                            // DATOS DEL VEHÍCULO
                            contenido.Item()
                                .Text("DATOS DEL VEHÍCULO")
                                .Bold()
                                .FontSize(11);

                            contenido.Item().Table(tabla =>
                            {
                                tabla.ColumnsDefinition(columnas =>
                                {
                                    columnas.RelativeColumn();
                                    columnas.RelativeColumn();
                                });

                                CeldaDato(tabla, "Marca", vehiculo.Marca);
                                CeldaDato(tabla, "Modelo", vehiculo.Modelo);

                                CeldaDato(
                                    tabla,
                                    "Año",
                                    vehiculo.Anio.ToString(
                                        CultureInfo.InvariantCulture));

                                CeldaDato(
                                    tabla,
                                    "Patente",
                                    vehiculo.Patente);

                                CeldaDato(
                                    tabla,
                                    "Kilometraje actual",
                                    $"{vehiculo.Kilometraje:N0} km");
                            });

                            // RESUMEN GENERAL
                            contenido.Item()
                                .PaddingTop(8)
                                .Text("RESUMEN GENERAL")
                                .Bold()
                                .FontSize(11);

                            contenido.Item().Table(tabla =>
                            {
                                tabla.ColumnsDefinition(columnas =>
                                {
                                    columnas.RelativeColumn();
                                    columnas.RelativeColumn();
                                });

                                CeldaDato(
                                    tabla,
                                    "Cantidad total de servicios",
                                    cantidadServicios.ToString());

                                CeldaDato(
                                    tabla,
                                    "Costo total de mantenimiento",
                                    costoTotal.ToString(
                                        "C2",
                                        CultureInfo.GetCultureInfo("es-AR")));
                            });

                            // DESGLOSE POR TIPO
                            contenido.Item()
                                .PaddingTop(8)
                                .Text("RESUMEN POR TIPO DE SERVICIO")
                                .Bold()
                                .FontSize(11);

                            if (resumenPorTipo.Count == 0)
                            {
                                contenido.Item().Text(
                                    "No hay servicios para agrupar.");
                            }
                            else
                            {
                                contenido.Item().Table(tabla =>
                                {
                                    tabla.ColumnsDefinition(columnas =>
                                    {
                                        columnas.RelativeColumn(2);
                                        columnas.RelativeColumn(1);
                                        columnas.RelativeColumn(1.5f);
                                    });

                                    tabla.Header(cabecera =>
                                    {
                                        Encabezado(cabecera, "Tipo de servicio");
                                        Encabezado(cabecera, "Cantidad");
                                        Encabezado(cabecera, "Costo total");
                                    });

                                    foreach (var grupo in resumenPorTipo)
                                    {
                                        Celda(tabla, grupo.Tipo);

                                        Celda(
                                            tabla,
                                            grupo.Cantidad.ToString());

                                        Celda(
                                            tabla,
                                            grupo.Costo.ToString(
                                                "C2",
                                                CultureInfo.GetCultureInfo("es-AR")));
                                    }
                                });
                            }

                            // DETALLE DEL HISTORIAL
                            contenido.Item()
                                .PaddingTop(8)
                                .Text("DETALLE DE SERVICIOS REGISTRADOS")
                                .Bold()
                                .FontSize(11);

                            if (cantidadServicios == 0)
                            {
                                contenido.Item()
                                    .Padding(8)
                                    .Text(
                                        "Este vehículo no tiene servicios registrados.");
                            }
                            else
                            {
                                contenido.Item().Table(tabla =>
                                {
                                    tabla.ColumnsDefinition(columnas =>
                                    {
                                        columnas.ConstantColumn(58);
                                        columnas.RelativeColumn(1.2f);
                                        columnas.ConstantColumn(60);
                                        columnas.RelativeColumn(2f);
                                        columnas.ConstantColumn(65);
                                    });

                                    tabla.Header(cabecera =>
                                    {
                                        Encabezado(cabecera, "Fecha");
                                        Encabezado(cabecera, "Tipo");
                                        Encabezado(cabecera, "Km");
                                        Encabezado(cabecera, "Descripción");
                                        Encabezado(cabecera, "Costo");
                                    });

                                    foreach (var servicio in listaServicios
                                        .OrderByDescending(s => s.Fecha))
                                    {
                                        Celda(
                                            tabla,
                                            servicio.Fecha.ToString("dd/MM/yyyy"));

                                        Celda(
                                            tabla,
                                            servicio.TipoServicio?.Nombre
                                                ?? "Sin especificar");

                                        Celda(
                                            tabla,
                                            servicio.Kilometraje.ToString("N0"));

                                        Celda(
                                            tabla,
                                            string.IsNullOrWhiteSpace(
                                                servicio.Descripcion)
                                                ? "—"
                                                : servicio.Descripcion);

                                        Celda(
                                            tabla,
                                            servicio.Costo.ToString(
                                                "C2",
                                                CultureInfo.GetCultureInfo("es-AR")));
                                    }
                                });
                            }
                        });

                    // PIE DE PÁGINA
                    pagina.Footer()
                        .AlignCenter()
                        .Text(texto =>
                        {
                            texto.Span(
                                "CarCheck - Informe de mantenimiento - Página ");

                            texto.CurrentPageNumber();

                            texto.Span(" de ");

                            texto.TotalPages();
                        });
                });
            }).GeneratePdf(ruta);
        }

        private static void CeldaDato(
            TableDescriptor tabla,
            string etiqueta,
            string valor)
        {
            tabla.Cell()
                .Border(1)
                .BorderColor(Colors.Grey.Lighten2)
                .Padding(6)
                .Text(etiqueta)
                .Bold();

            tabla.Cell()
                .Border(1)
                .BorderColor(Colors.Grey.Lighten2)
                .Padding(6)
                .Text(
                    string.IsNullOrWhiteSpace(valor)
                        ? "—"
                        : valor);
        }

        private static void Encabezado(
            TableCellDescriptor celda,
            string texto)
        {
            celda.Cell()
                .Background(Colors.Blue.Medium)
                .Padding(5)
                .Text(texto)
                .FontColor(Colors.White)
                .Bold();
        }

        private static void Celda(
            TableDescriptor tabla,
            string texto)
        {
            tabla.Cell()
                .BorderBottom(1)
                .BorderColor(Colors.Grey.Lighten2)
                .Padding(5)
                .Text(texto ?? "—");
        }
    }
}

