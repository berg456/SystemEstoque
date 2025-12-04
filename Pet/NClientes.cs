using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet
{
    internal class NClientes
    {
        //Método Inserir
        public static string Inserir(string codigo, string nome, string celular, string email, string cpf, string endereco, byte[] imagem)
        {
            DClientes Obj = new DClientes();
            Obj.Codigo = codigo;
            Obj.Nome = nome;
            Obj.Celular = celular;
            Obj.Email = email;
            Obj.Cpf = cpf;
            Obj.Endereco = endereco;
            Obj.Imagem = imagem;
            

            return Obj.Inserir(Obj);
        }


        //Método Editar
        public static string Editar(int id, string codigo, string nome, string descricao, byte[] imagem, int idcategoria, int idapresentacao)
        {
            DClientes Obj = new DClientes();
            Obj.Id = id;
            Obj.Codigo = codigo;
            Obj.Nome = nome;
            Obj.Celular = descricao;
            Obj.Imagem = imagem;

            return Obj.Editar(Obj);
        }



        //Método Deletar
        public static string Excluir(int id)
        {
            DClientes Obj = new DClientes();
            Obj.Id = id;

            return Obj.Excluir(Obj);
        }


        //Método Mostrar
        public static DataTable Mostrar()
        {
            return new DClientes().Mostrar();


        }


        //Método Buscar Nome
        public static DataTable BuscarNome(string textobuscar)
        {
            DClientes Obj = new DClientes();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNome(Obj);
        }
    }
}
}
