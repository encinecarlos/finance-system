using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// a API ta aonde nessa história toda?
namespace Gama_SistemaFinanceiro
{
    public partial class F_login : Form
    {

        Form1 form1;
        DataTable dt = new DataTable();
        public F_login(Form1 f ) 
        {
            InitializeComponent();
            form1 = f;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void F_login_Load(object sender, EventArgs e)
        {

        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;

            if(username=="" || password == "")
            {
                MessageBox.Show("username or password is invalid");
                tb_username.Focus();
                return;// nao continua a execução da rotina
            }

            string sql = "SELECT * FROM tb_usuarios WHERE T_USERNAME='"+username+"' AND T_PASSWORDUSER= '" +password+"'"; // detalhes string
            dt = DataBase.consult(sql); // retorno do dt da consulta
            if(dt.Rows.Count == 1)
            {
                form1.lb_access.Text = dt.Rows[0].Field<string>("T_LEVELUSER");//retornando dado
                form1.lb_userName.Text = dt.Rows[0].Field<string>("T_USERNAME");//acessando resultado
                form1.pb_ledVerde.Image = Properties.Resources.led_green;
                Global.level =int.Parse( dt.Rows[0].Field<Int64>("T_LEVELUSER").ToString());
                Global.logado = true;
                this.Close();
            }
            else
            {

                MessageBox.Show("user not found");
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
