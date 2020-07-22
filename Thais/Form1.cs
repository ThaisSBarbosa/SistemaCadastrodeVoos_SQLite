using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Globalization;

namespace Thais
{
    public partial class acme_form : Form
    {
        public acme_form()
        {
            InitializeComponent();
        }

        //Preenche todos os registros do banco no list view
        void PreencheListView()
        {
            Conexão con = new Conexão();

            try
            {
                con.conectar();

                string sql = "SELECT * FROM TB_VOO";

                SQLiteDataAdapter dados = new SQLiteDataAdapter(sql, con.conn);
                DataTable dadosvoos = new DataTable();

                dados.Fill(dadosvoos);

                listviewdados.Items.Clear();

                for (int i = 0; i < dadosvoos.Rows.Count; i++)
                {
                    listviewdados.Items.Add(Convert.ToDateTime(dadosvoos.Rows[i]["DATA_VOO"].ToString()).ToShortDateString());
                    listviewdados.Items[i].SubItems.Add(dadosvoos.Rows[i]["CAPTURA"].ToString());
                    listviewdados.Items[i].SubItems.Add(dadosvoos.Rows[i]["NIVEL_DOR"].ToString());
                }

                if (listviewdados.Items.Count!=0)
                listviewdados.Items[listviewdados.Items.Count-1].Selected=true;

                con.desconectar();

            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PreencheListView();
        }

        private void rbcapturasim_CheckedChanged(object sender, EventArgs e)
        {
        }


        /*preenche tela com os detalhes do voo ao selecionar um item 
        no list view e ao clicar em cancelar após editar algum detalhe*/

        void PreencherTelaDetalhes()
        {
            btncancelar.Enabled = btnsalvar.Enabled = false;

            Conexão con = new Conexão();

            try
            { 
                con.conectar();

                int a = 0;
                for (int i = 0; i < listviewdados.Items.Count; i++)
                {
                    if (listviewdados.Items[i].Selected == true)
                    {
                        a = i + 1;
                        break;
                    }
                }

                string sql = "SELECT * FROM TB_VOO WHERE ID_VOO = " + a.ToString();

                SQLiteDataAdapter dados = new SQLiteDataAdapter(sql, con.conn);
                DataTable dadosvoos = new DataTable();

                dados.Fill(dadosvoos);

                txtdata.Text = Convert.ToDateTime(dadosvoos.Rows[0]["DATA_VOO"].ToString()).ToShortDateString();
                txtcusto.Text = dadosvoos.Rows[0]["CUSTO"].ToString();
                txtdistancia.Text = dadosvoos.Rows[0]["DISTANCIA"].ToString();
                if (dadosvoos.Rows[0]["CAPTURA"].ToString() == "S")
                {
                    rbcapturasim.Checked = true;
                }
                else if (dadosvoos.Rows[0]["CAPTURA"].ToString() == "N")
                {
                    rbcapturanao.Checked = true;
                }
                txtniveldor.Text = dadosvoos.Rows[0]["NIVEL_DOR"].ToString();

                con.desconectar();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message.ToString());
            }
        }

        private void listviewdados_Click(object sender, EventArgs e)
        {
            PreencherTelaDetalhes();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (listviewdados.Items.Count != 0)
                PreencherTelaDetalhes();
            else
                LimpaTela();
        }

        void LimpaTela()
        {

            txtdata.Clear();
            txtcusto.Clear();
            txtdistancia.Clear();
            txtniveldor.Clear();
            rbcapturanao.Checked = false;
            rbcapturasim.Checked = false;
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if(listviewdados.SelectedItems.Count>0)
            {
                btncancelar.Enabled = btnsalvar.Enabled = false;

                Conexão con = new Conexão();

                try
                { 
                    con.conectar();

                    int a = 0;
                    for (int i = 0; i < listviewdados.Items.Count; i++)
                    {
                        if (listviewdados.Items[i].Selected == true)
                        {
                            a = i + 1;
                            break;
                        }
                    }

                    //exclui o registro e atualiza os ids

                    string sqlexclui = "DELETE FROM TB_VOO WHERE ID_VOO = " + a.ToString();
                    SQLiteCommand dadosexclui = new SQLiteCommand(sqlexclui, con.conn);
                    dadosexclui.ExecuteNonQuery();

                    string sqlatualizaids = "update TB_VOO set ID_VOO = (select count(*) from " +
                        "TB_VOO t2 where t2.rowid <= TB_VOO.rowid)";
                    SQLiteCommand atualizaids = new SQLiteCommand(sqlatualizaids, con.conn);
                    atualizaids.ExecuteNonQuery();

                    PreencheListView();
               
                    LimpaTela();

                    con.desconectar();
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Primeiro você deve selecionar um registro.","Atenção");
            }
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            btncancelar.Enabled = btnsalvar.Enabled = false;

            Conexão con = new Conexão();

            try
            { 
                con.conectar();

                //atualiza o registro no banco ou faz um novo

                if ((MessageBox.Show("Você quer salvar como novo registro?\n\nClique em não para atualizar " +
                "o registro selecionado e em sim para salvar como novo.",
                "Mensagem ao usuário", MessageBoxButtons.YesNo) == DialogResult.Yes))
                {
                    string sql = "SELECT * FROM TB_VOO";

                    SQLiteDataAdapter dados = new SQLiteDataAdapter(sql, con.conn);
                    DataTable dadosvoos = new DataTable();

                    dados.Fill(dadosvoos);
                    int d = dadosvoos.Rows.Count+1;

                    string captura="";

                    if (rbcapturasim.Checked==true)
                    {
                        captura = "S";
                    }
                    else if(rbcapturanao.Checked == true)
                    {
                        captura = "N";
                    }

                    string sqlinclui = "INSERT INTO TB_VOO (ID_VOO, DATA_VOO, CUSTO, DISTANCIA, CAPTURA, NIVEL_DOR) VALUES ('" +
                        d.ToString()+"',@DATA_VOO,@CUSTO,@DISTANCIA,'" +captura + "',@NIVEL_DOR)";
                    SQLiteCommand dadosinclui = new SQLiteCommand(sqlinclui, con.conn);

                    try
                    {
                        dadosinclui.Parameters.Add("@DATA_VOO", DbType.DateTime);
                        dadosinclui.Parameters["@DATA_VOO"].Value = Convert.ToDateTime(txtdata.Text);
                        dadosinclui.Parameters.Add("@CUSTO", DbType.Double);
                        dadosinclui.Parameters["@CUSTO"].Value = Convert.ToDouble(txtcusto.Text);
                        dadosinclui.Parameters.Add("@DISTANCIA", DbType.Int32);
                        dadosinclui.Parameters["@DISTANCIA"].Value = Convert.ToInt32(txtdistancia.Text);
                        dadosinclui.Parameters.Add("@NIVEL_DOR", DbType.Int32);
                        dadosinclui.Parameters["@NIVEL_DOR"].Value = Convert.ToInt32(txtniveldor.Text);
                        dadosinclui.ExecuteNonQuery();

                        PreencheListView();

                        PreencherTelaDetalhes();
                    }
                    catch
                    {
                        MessageBox.Show("Os dados preenchidos são inválidos.");
                        LimpaTela();
                    }




                }
                else if (listviewdados.Items.Count!=0)
                {
                    int a = 0;
                    for (int i = 0; i < listviewdados.Items.Count; i++)
                    {
                        if (listviewdados.Items[i].Selected == true)
                        {
                            a = i + 1;
                            break;
                        }
                    }

                    try
                    {
                        string sqldata = "UPDATE TB_VOO SET DATA_VOO =@DATA_VOO WHERE ID_VOO = " + a.ToString();
                        SQLiteCommand dadosdata = new SQLiteCommand(sqldata, con.conn);
                        dadosdata.Parameters.Add("@DATA_VOO", DbType.DateTime);
                        dadosdata.Parameters["@DATA_VOO"].Value = Convert.ToDateTime(txtdata.Text);
                        dadosdata.ExecuteNonQuery();

                        string sqlcusto = "UPDATE TB_VOO SET CUSTO =@CUSTO WHERE ID_VOO = " + a.ToString();
                        SQLiteCommand dadoscusto = new SQLiteCommand(sqlcusto, con.conn);
                        dadoscusto.Parameters.Add("@CUSTO", DbType.Double);
                        dadoscusto.Parameters["@CUSTO"].Value = Convert.ToDouble(txtcusto.Text);
                        dadoscusto.ExecuteNonQuery();

                        string sqldistancia = "UPDATE TB_VOO SET DISTANCIA =@DISTANCIA WHERE ID_VOO = " + a.ToString();
                        SQLiteCommand dadosdistancia = new SQLiteCommand(sqldistancia, con.conn);
                        dadosdistancia.Parameters.Add("@DISTANCIA", DbType.Int32);
                        dadosdistancia.Parameters["@DISTANCIA"].Value = Convert.ToInt32(txtdistancia.Text);
                        dadosdistancia.ExecuteNonQuery();

                        if (rbcapturasim.Checked == true)
                        {
                            string sqlcapturasim = "UPDATE TB_VOO SET CAPTURA ='S' WHERE ID_VOO = " + a.ToString();
                            SQLiteCommand dadoscapturasim = new SQLiteCommand(sqlcapturasim, con.conn);
                            dadoscapturasim.ExecuteNonQuery();
                        }
                        else if (rbcapturanao.Checked == true)
                        {
                            string sqlcapturanao = "UPDATE TB_VOO SET CAPTURA ='N' WHERE ID_VOO = " + a.ToString();
                            SQLiteCommand dadoscapturanao = new SQLiteCommand(sqlcapturanao, con.conn);
                            dadoscapturanao.ExecuteNonQuery();
                        }

                        string sqlniveldor = "UPDATE TB_VOO SET NIVEL_DOR =@NIVEL_DOR WHERE ID_VOO = " + a.ToString();
                        SQLiteCommand dadosniveldor = new SQLiteCommand(sqlniveldor, con.conn);
                        dadosniveldor.Parameters.Add("@NIVEL_DOR", DbType.Int32);
                        dadosniveldor.Parameters["@NIVEL_DOR"].Value = Convert.ToInt32(txtniveldor.Text);
                        dadosniveldor.ExecuteNonQuery();

                        PreencherTelaDetalhes();
                        PreencheListView();
                    }
                    catch
                    {
                        MessageBox.Show("Os dados preenchidos são inválidos.");
                        LimpaTela();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Não há registro para atualizar.\nVocê pode inserir um novo.", "Atenção");
                    HabilitaSalvarCancelar();
                }

                con.desconectar();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message.ToString());
                
                LimpaTela();
            }

            

        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        //Habilita Salvar e Cancelar caso o usuário digite algo nas textboxes

        void HabilitaSalvarCancelar()
        {
            btncancelar.Enabled = btnsalvar.Enabled = true;
        }

        private void txtdata_KeyPress(object sender, KeyPressEventArgs e)
        {
            HabilitaSalvarCancelar();
        }

        private void txtcusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            HabilitaSalvarCancelar();
        }

        private void txtdistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            HabilitaSalvarCancelar();
        }

        private void rbcapturasim_Click(object sender, EventArgs e)
        {
            HabilitaSalvarCancelar();
        }

        private void rbcapturanao_Click(object sender, EventArgs e)
        {
            HabilitaSalvarCancelar();
        }

        private void txtniveldor_KeyPress(object sender, KeyPressEventArgs e)
        {
            HabilitaSalvarCancelar();
        }



        private void txtdata_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtcusto_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtdistancia_TextChanged(object sender, EventArgs e)
        {
        }

        private void rbcapturanao_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void txtniveldor_TextChanged(object sender, EventArgs e)
        {
        }

    }
}
