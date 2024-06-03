﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalidadDominioDTO
{
    public class MantenimientoDTO
    {
        public class SeccionesDTO
        {
            public short? codigoSeccion { get; set; }
            public string? nombreSeccion { get; set; }
            public bool? estadoSeccion { get; set; }
            public string? descripcionEstadoSeccion { get; set; }
            public string? usuarioTransaccion { get; set; }
            public string? equipoTransaccion { get; set; }
        }

        public class PreguntasDTO
        {
            public short? codigoPregunta { get; set; }
            public short codigoSeccion { get; set; }
            public string? descripcionPregunta { get; set; }
            public DateTime? vigenciaDesde { get; set; }
            public DateTime? vigenciaHasta { get; set; }
            public bool? estadoPregunta { get; set; }
            public string? descripcionEstadoPregunta { get; set; }
            public string? usuarioTransaccion { get; set; }
            public string? equipoTransaccion { get; set; }
            public bool? repuestaPregunta { get; set; }
            public int? respuestaMarcada { get; set; }

        }

        public class NovedadesDTO
        {
            public short? codigoNovedad { get; set; }
            public string? descripcionNovedad { get; set; }
            public bool? estadoNovedad { get; set; }
            public string? descripcionEstadoNovedad { get; set; }
            public string? usuarioTransaccion { get; set; }
            public string? equipoTransaccion { get; set; }
        }

        public class TipoCacaoDTO
        {
            public short? codigoTipoCacao { get; set; }
            public string? nombreTipoCacao { get; set; }
            public bool? estadoTipoCacao { get; set; }
            public string? descripcionEstadoTipoCacao { get; set; }
        }

        public class GruposDTO
        {
            public short? codigoGrupo { get; set; }
            public string? nombreGrupo { get; set; }
            public string? codigoZona { get; set; }
            public bool? estadoGrupo { get; set; }
            public string? descripcionEstadoGrupo { get; set; }
        }

        public class CertificacionesDTO
        {
            public short? codigoCertificacion { get; set; }
            public string? codigoCertificacionAlfanumerico { get; set; }
            public string? nombreCertificacion { get; set; }
            public DateTime? fechaInicial { get; set; }
            public DateTime? fechaFinal { get; set; }
            public decimal? toleranciaCuota { get; set; }
            public bool? estadoCertificacion { get; set; }
            public string? descripcionEstadoCertificacion { get; set; }
        }

        public class ProgramasDTO
        {
            public short? codigoPrograma { get; set; }
            public string? codigoProgramaAlfanumerico { get; set; }
            public string? nombrePrograma { get; set; }
            public short? codigoCertificacion { get; set; }
            public bool? estadoPrograma { get; set; }
            public string? descripcionEstadoPrograma { get; set; }
        }

        public class GrupoVendorFacturaDTO
        {
            public short? codigoGrupoVendor { get; set; }
            public string? codigoVendorPrincipal { get; set; }
            public string? nombreVendorPrincipal { get; set; }
            public string? codigoVendorFactura { get; set; }
            public string? nombreVendorFactura { get; set; }
            public short? codigoPrograma { get; set; }
            public decimal? cupoCompra { get; set; }
            public decimal? excedente { get; set; }
            public bool? estadoGrupoVendor { get; set; }
            public string? descripcionEstadoGrupoVendor { get; set; }
        }

        public class PronosticoCosechaDTO
        {
            public string? codigoZona { get; set; }
            public decimal? enero { get; set; }
            public decimal? febrero { get; set; }
            public decimal? marzo { get; set; }
            public decimal? abril { get; set; }
            public decimal? mayo { get; set; }
            public decimal? junio { get; set; }
            public decimal? julio { get; set; }
            public decimal? agosto { get; set; }
            public decimal? septiembre { get; set; }
            public decimal? octubre { get; set; }
            public decimal? noviembre { get; set; }
            public decimal? diciembre { get; set; }
            public decimal? total { get; set; }
            public bool? estadoPronosticoCosecha { get; set; }
            public string? descripcionEstadoPronosticoCosecha { get; set; }
        }
    }
}
