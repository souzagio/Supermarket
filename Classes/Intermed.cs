using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Supermarket.Classes
{
    internal class Intermed
    {
        //Abrir conexão com o servidor
        MySqlConnection Conexao = new MySqlConnection("server=localhost; uid=root; pwr=; port=3306; database=neoacessbd;");
        MySqlDataReader Dr;

        //Variáveis de controle
        public Int16 ID = 0;

        //Classes de erros ao tentar acessar o servidor
        public class Erro
        {
            public int Id { get; set; }
            public string Descricao { get; set; }
        }
        public class RetornaErroMySql
        {
            List<Erro> lstErros = new List<Erro>()
        {
            new Erro(){Id=1062, Descricao="Login ou e-mail já em uso,\nescolha um diferente"}
        };
            public string RetornaErro(int errorNumber)
            {
                string msgErro = string.Empty;
                Erro errInfo = new Erro();
                errInfo = lstErros.Find(p => p.Id == errorNumber);
                if (errInfo != null)
                    msgErro = errInfo.Descricao;
                return msgErro;
            }
        }

        public string Logar(string varNome, string varSenha) //Done
        {
            string msg = string.Empty;
            
            Conexao.Open();
            MySqlCommand cmd = new MySqlCommand("STPLogin", Conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = Conexao;

            cmd.Parameters.Clear();
            cmd.Parameters.Add("@pLogin", MySqlDbType.VarChar).Value = varNome;
            cmd.Parameters.Add("@pPass", MySqlDbType.VarChar).Value = varSenha;

            MySqlParameter IdUser;
            IdUser = cmd.Parameters.Add("@oID", MySqlDbType.Int16);
            IdUser.Direction = ParameterDirection.Output;
            Dr = cmd.ExecuteReader();
            try
            {


                if (Dr.HasRows)
                {
                    Dr.Read();
                    ID = Convert.ToInt16(Dr["ID"].ToString());
                }
                Dr.Close();
                Conexao.Close();
            }
            catch (MySqlException SqlErrr)
            {
                RetornaErroMySql retErro = new RetornaErroMySql();
                string msgErro = retErro.RetornaErro(SqlErrr.Number);
                if (string.IsNullOrEmpty(msgErro)) msgErro = SqlErrr.Message;
                msg = msgErro;
            }
            catch (Exception Ex)
            {
                msg = Ex.Message.ToString();
            }
            finally { if (Conexao.State == ConnectionState.Open) Conexao.Close(); }
            return msg;
        }
    }
}
