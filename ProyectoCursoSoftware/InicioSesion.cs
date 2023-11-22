using System.Data;
using System;
using System.Diagnostics;
using System.Drawing;

namespace ProyectoCursoSoftware
{
    public partial class InicioSesion : Form
    {
        Conexion con;
        int cont = 3;
        Stopwatch oSW = new Stopwatch();
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (txtUsuario.Text.Equals("") || txtContrasena.Text.Equals(""))
            {
                MessageBox.Show("No pueden haber campos vacios", "Alerta");
                Cursor.Current = Cursors.Default;
                return;
            }
            con = new Conexion(txtUsuario.Text, txtContrasena.Text);
            if (this.con.connect.State == ConnectionState.Open)
            {
                if (con.rol == "sysadmin")
                {
                    MenuAdministrador menu = new MenuAdministrador(con);
                    menu.Show();
                    this.Visible = false;
                }

                if (con.rol == "dbcreator")
                {
                    MenuVendedor menuVendedor = new MenuVendedor();
                    menuVendedor.Show();
                    this.Visible = false;
                }
            }
            else
            {
                Cursor.Current = Cursors.Default;
                --cont;
                lblIntentos.Text = "La contraseña o usuario es incorrecta. Vuelve a intentarlo. " + cont + " Intentos restantes";
                if (cont == 0)
                {
                    cont = 3;
                    btnAceptar.Enabled = false;
                    //btnCancelar.Enabled = false;
                    txtContrasena.Enabled = false;
                    txtUsuario.Enabled = false;
                    checkBox1.Enabled = false;
                    timer1.Enabled = true;
                    oSW.Start();
                    //Thread.Sleep(60000);//60,000=60seg
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)oSW.ElapsedMilliseconds);
            lblIntentos.Text = (30 - ts.Seconds).ToString();
            if (ts.Seconds == 30)
            {
                oSW.Restart();
                timer1.Enabled = false;
                lblIntentos.Text = "";
                btnAceptar.Enabled = true;
                //btnCancelar.Enabled = true;
                txtUsuario.Enabled = true;
                txtContrasena.Enabled = true;
                checkBox1.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtContrasena.PasswordChar = '\0';
            }
            else
            {
                txtContrasena.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}