using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Repositorios
{
    public class Cliente
    {
        public Cliente()
        {
            var userRepositorio = new UserRepositorio();
            var produto = new Produto();
            var user = new User();

            userRepositorio.Adicionar(user);
        }
    }
}
