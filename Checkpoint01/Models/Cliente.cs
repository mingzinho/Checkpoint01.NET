﻿namespace Checkpoint01.Models
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
