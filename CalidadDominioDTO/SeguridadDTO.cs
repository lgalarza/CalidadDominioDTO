namespace CalidadDominioDTO
{
    public class SeguridadDTO
    {
        public class LoginDTO
        {
            public string codigo { get; set; }
            public string clave { get; set; }
        }

        public class LoginRespuestaDTO
        {
            public string codigoUsuario { get; set; }
            public string numeroIdentificacion { get; set; }
            public string nombreUsuario { get; set; }
            public string apellidoUsuario { get; set; }
            public byte[] claveUsuario { get; set; }
            public string correoElectronico { get; set; }
            public string numeroTelefono { get; set; }
            public string codigoEmpresa { get; set; }
            public string razonSocial { get; set; }
            public bool estadoUsuario { get; set; }
            public string codigoPerfil { get; set; }
            public string nombrePerfil { get; set; }

        }

        public class PermisosXPagina
        {
            public short codigoPerfil { get; set; }
            public short codigoPagina { get; set; }
            public string codigoUsuario { get; set; }
        }

        public class MenuDTO
        {
            public short codigoEmpresa { get; set; }
            public string razonSocial { get; set; }
            public short codigoPerfil { get; set; }
            public string nombrePerfil { get; set; }
            public short codigoFuncion { get; set; }
            public string nombreFuncion { get; set; }
            public short codigoTransaccion { get; set; }
            public string nombreTransaccion { get; set; }
            public string urlPagina { get; set; }
            public string actividad { get; set; }

        }

        public class FuncionDTO
        {
            public short codigoFuncion { get; set; }
            public string nombreFuncion { get; set; }
        }
    }
}
