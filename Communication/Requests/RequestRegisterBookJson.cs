﻿using GestaoLivraria.Entities;

namespace GestaoLivraria.Communication.Requests
{
    public class RequestRegisterBookJson
    {
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty ;
        public Genre Genre { get; set; }
        public decimal Price { get; set; }
        public int QuantityStock { get; set; }


    }
}
