using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Contato
    {
        public Contato()
        {
            Con_cod = 0;
            Con_nome = "";
            Con_email = "";
            Con_fone = "";
            Con_endereco = "";
            Con_bairro = "";
            Con_cidade = "";
            Con_estado = "";
            Con_cep = "";
        }
        public Contato(int codigo, string nome, string email, string fone, string endereco, string bairro, string cidade, string estado, string cep)
        {
            Con_cod = codigo;
            Con_nome = nome;
            Con_email = email;
            Con_fone = fone;
            Con_endereco = endereco;
            Con_bairro = bairro;
            Con_cidade = cidade;
            Con_estado = estado;
            Con_cep = cep;

        }

        private int con_cod;
        private String con_nome;
        private String con_email;
        private String con_fone;
        private String con_endereco;
        private String con_bairro;
        private String con_cidade;
        private String con_estado;
        private String con_cep;

        public int Con_cod { get => con_cod; set => con_cod = value; }
        public string Con_nome { get => con_nome; set => con_nome = value; }
        public string Con_email { get => con_email; set => con_email = value; }
        public string Con_fone { get => con_fone; set => con_fone = value; }
        public string Con_endereco { get => con_endereco; set => con_endereco = value; }
        public string Con_bairro { get => con_bairro; set => con_bairro = value; }
        public string Con_cidade { get => con_cidade; set => con_cidade = value; }
        public string Con_estado { get => con_estado; set => con_estado = value; }
        public string Con_cep { get => con_cep; set => con_cep = value; }
    }
}
