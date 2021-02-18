﻿using System;

namespace BooksWebApi.Models.Entities
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public int ClienteId { get; set; }
        public int LibroId { get; set; }
        public DateTime Fecha { get; set; }
    }
}
