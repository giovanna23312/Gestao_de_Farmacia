using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaVital
{
    internal class ClassUser
    {
        public static void Inserir(string login, string senha)
        {
            string sql = @"insert into tab_user values(@login, @senha)";
            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);

            cmd.Parameters.AddWithValue("login", login);
            cmd.Parameters.AddWithValue("senha", senha);

            cmd.ExecuteNonQuery();
        }

        public static void Atualizar(string login, string senha, int codigo)
        {
            string sql = @"update tab_user set login =@login, senha =@senha where id =@id";
            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);

            cmd.Parameters.AddWithValue("login", login);
            cmd.Parameters.AddWithValue("senha", senha);
            cmd.Parameters.AddWithValue("id", codigo);

            cmd.ExecuteNonQuery();
        }
    }
}
