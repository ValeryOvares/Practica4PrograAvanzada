﻿namespace Practica4Api.Entities
{
    public class PrincipalEnt
    {
        public long Id_Compra { get; set; }

        public decimal Precio { get; set; }

        public decimal Saldo { get; set; }

        public string Descripcion { get; set; } = string.Empty;

        public string Estado { get; set; } = string.Empty;
    }
}
