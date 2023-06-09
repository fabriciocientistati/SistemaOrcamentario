﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace SistemaOrcamentario.Models
{
    public class PessoaModel
    {
        public PessoaModel() =>
            Orcamentos = new List<OrcamentoModel>();

        public PessoaModel(int iD, string nome, string cpf, string cnpj, string numberCellPhone, string numberFixPhone, string email, string cep, string rua, string numero, string bairro, string cidade, string estado, DateTime dataInclusao) : this()
        {
            ID = iD;
            Nome = nome;
            Cpf = cpf;
            Cnpj = cnpj;
            NumberCellPhone = numberCellPhone;
            NumberFixPhone = numberFixPhone;
            Email = email;
            Cep = cep;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            DataInclusao = dataInclusao;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Cnpj { get; set; }
        public string NumberCellPhone { get; set; }
        public string? NumberFixPhone { get; set; }
        public string? Email { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string? Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public DateTime DataInclusao { get; set; } = DateTime.Now;
        public virtual ICollection<OrcamentoModel> Orcamentos { get; set; }
    }
}
