﻿using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> _mensagensValidacao { get; set; }

        private List<string> MensagemValidacao 
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); } 
        }

        protected void LimparMensagens()
        {
            MensagemValidacao.Clear();
        }

        protected void AdicionarMensagem(string msg)
        {
            MensagemValidacao.Add(msg);
        }

        public abstract void Validate();

        protected bool Valido
        {
            get { return !MensagemValidacao.Any(); }
        }
    }
}
