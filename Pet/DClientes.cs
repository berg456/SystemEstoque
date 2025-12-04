using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet
{
    internal class DClientes
    {
        private int _Id;
        private string _Codigo;
        private string _Nome;
        private string _Celular;
        private string _Email;
        private string _Cpf;
        private string _Endereco;
        private byte[] _Imagem;
        
        private string _TextoBuscar;

        public DClientes() { }
        public DClientes(int id, string codigo, string nome, string celular, string email, string cpf, string endereco, byte[] imagem, string textoBuscar)
        {
            _Id = id;
            _Codigo = codigo;
            _Nome = nome;
            _Celular = celular;
            _Email = email;
            _Cpf = cpf;
            _Endereco = endereco;
            _Imagem = imagem;
            _TextoBuscar = textoBuscar;
        }

        public int Id { get => _Id; set => _Id = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Nome { get => _Nome; set => _Nome = value; }
        public string Celular { get => _Celular; set => _Celular = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Cpf { get => _Cpf; set => _Cpf = value; }
        public string Endereco { get => _Endereco; set => _Endereco = value; }
        public byte[] Imagem { get => _Imagem; set => _Imagem = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }
    }
}
