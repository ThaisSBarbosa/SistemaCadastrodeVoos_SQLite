using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace Thais
{
    class Conexão
    {
        
        //if(File.Exists("dados.txt"))
        
        public SQLiteConnection conn = new SQLiteConnection("Data Source = acme.sqlite");

        public void conectar()
        {
            conn.Open();

            string sqlcriartabela = "CREATE TABLE IF NOT EXISTS `TB_VOO` (`ID_VOO`INTEGER," +
                "`DATA_VOO`TEXT,`CUSTO`NUMERIC,`DISTANCIA`	INTEGER,`CAPTURA`TEXT," +
                "`NIVEL_DOR`INTEGER,PRIMARY KEY(ID_VOO))";

            SQLiteCommand criartabela = new SQLiteCommand(sqlcriartabela, conn);
            criartabela.ExecuteNonQuery();

        }

        public void desconectar()
        {
            conn.Close();
        }
    }
}
