using System;
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


    }
}
