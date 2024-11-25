using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Agenda_Angelical.GlobalVariable
{
    static public class UserSession
    {
        static private string _usuario = null;

        static public string Usuario
        {

            get
            {
                return _usuario;
            }

            set
            {
                _usuario = value.ToUpper();
            }

        }

        static private MySqlConnection _conexao = null;

        static public MySqlConnection Conexao
        {

            get
            {
                return _conexao;
            }

            set
            {
                _conexao = value;
            }

        }
    }
}
}
