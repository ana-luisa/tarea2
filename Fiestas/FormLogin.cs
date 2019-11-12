using BL_Fiestas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiestas
{
    public partial class FormLogin : Form
    {

        SeguridadBL _seguridad; 

        public FormLogin()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario;
            string Contraseña;

            Usuario = textBox1.Text;
            Contraseña = textBox2.Text;

           var resultado = _seguridad.Autorizar(Usuario, Contraseña);

            if (resultado == true) 
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (textBox2.PasswordChar == '*')
                {
                    textBox2.PasswordChar = '\0';
                }
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
            
        }

    }
} 
