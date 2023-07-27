using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ReportesHDISeguros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            string CadenaConexion = "Database= hdiseguros; Data source = localhost; User id=root; Password=root; SSL Mode=none; ";
            MySqlConnection conexionDB;
            DataTable dataTable = new DataTable();
            MySqlDataReader resultado;

            try
            {
                conexionDB = new MySqlConnection(CadenaConexion);
                MySqlCommand comando = new MySqlCommand("Select * from poliza where Contratante = '"+txtNombre.Text+"';", conexionDB);
                comando.CommandType = CommandType.Text;
                conexionDB.Open();
                resultado = comando.ExecuteReader();
                dataTable.Load(resultado);
                conexionDB.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvPoliza.DataSource = dataTable;
        }

        private void btnBuscarPoliza_Click(object sender, EventArgs e)
        {
            string CadenaConexion = "Database= hdiseguros; Data source = localhost; User id=root; Password=root; SSL Mode=none; ";
            MySqlConnection conexionDB;
            DataTable dataTable = new DataTable();
            MySqlDataReader resultado;

            try
            {
                conexionDB = new MySqlConnection(CadenaConexion);
                MySqlCommand comando = new MySqlCommand("Select * from poliza where NumeroPoliza = '" + txtPoliza.Text + "';", conexionDB);
                comando.CommandType = CommandType.Text;
                conexionDB.Open();
                resultado = comando.ExecuteReader();
                dataTable.Load(resultado);
                conexionDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvPoliza.DataSource = dataTable;
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string CadenaConexion = "Database= hdiseguros; Data source = localhost; User id=root; Password=root; SSL Mode=none; ";
            MySqlConnection conexionDB;
            DataTable dataTable = new DataTable();
            MySqlDataReader resultado;
            string sqlEjecutar = "insert into reporte (NumeroPoliza,FechaHoraOcurrencia,LugarOcurrencia," +
                "NombreQuienReportar,TelefonoContacto,CorreoELectronico,DescripcionSiniestro,Placas,Color,Observaciones,NombreAjustador)" +
                "values (@NumeroPoliza,@FechaHoraOcurrencia,@LugarOcurrencia,@NombreQuienReportar,@TelefonoContacto,@CorreoELectronico," +
                "@DescripcionSiniestro,@Placas,@Color,@Observaciones,@NombreAjustador);";

            try
            {
                conexionDB = new MySqlConnection(CadenaConexion);

                MySqlCommand comandoSQL = new MySqlCommand();
                comandoSQL.Connection = conexionDB;
                comandoSQL.CommandText = sqlEjecutar;
                comandoSQL.Parameters.Add("@NumeroPoliza", MySqlDbType.String).Value = txtPoliza.Text;
                comandoSQL.Parameters.Add("@FechaHoraOcurrencia", MySqlDbType.Datetime).Value = dtpFechaOcurrencia.Value;
                comandoSQL.Parameters.Add("@LugarOcurrencia", MySqlDbType.String).Value = txtLugar.Text;
                comandoSQL.Parameters.Add("@NombreQuienReportar", MySqlDbType.String).Value = txtNombreQuienReporta.Text;
                comandoSQL.Parameters.Add("@TelefonoContacto", MySqlDbType.String).Value = txtTelefono.Text;
                comandoSQL.Parameters.Add("@CorreoELectronico", MySqlDbType.String).Value = txtCorreo.Text;
                comandoSQL.Parameters.Add("@DescripcionSiniestro", MySqlDbType.String).Value = txtDescripcion.Text;
                comandoSQL.Parameters.Add("@Placas", MySqlDbType.String).Value = txtPlacas.Text;
                comandoSQL.Parameters.Add("@Color", MySqlDbType.String).Value = txtColor.Text;
                comandoSQL.Parameters.Add("@Observaciones", MySqlDbType.String).Value = txtObservaciones.Text;
                comandoSQL.Parameters.Add("@NombreAjustador", MySqlDbType.String).Value = txtNombreAjustador.Text;
                conexionDB.Open();
                comandoSQL.ExecuteReader();
                //dataTable.Load(resultado);
                conexionDB.Close();
                MySqlCommand comando = new MySqlCommand("Select * from reporte " , conexionDB);
                comando.CommandType = CommandType.Text;
                conexionDB.Open();
                resultado = comando.ExecuteReader();
                dataTable.Load(resultado);
                conexionDB.Close();


                MessageBox.Show("Reporte Guardado Correctamente!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvReportes.DataSource = dataTable;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarConfirmo_Click(object sender, EventArgs e)
        {
            string CadenaConexion = "Database= hdiseguros; Data source = localhost; User id=root; Password=root; SSL Mode=none; ";
            MySqlConnection conexionDB;
            DataTable dataTable = new DataTable();
            MySqlDataReader resultado;
            string sqlEjecutar = "insert into confirmacion (FechaRegistro,NumeroSiniestro,NombreAjustador,Confirmo)" +
                "values (@FechaRegistro,@NumeroSiniestro,@NombreAjustador,@Confirmo);";

            try
            {
                conexionDB = new MySqlConnection(CadenaConexion);

                MySqlCommand comandoSQL = new MySqlCommand();
                comandoSQL.Connection = conexionDB;
                comandoSQL.CommandText = sqlEjecutar;
                comandoSQL.Parameters.Add("@FechaRegistro", MySqlDbType.Date).Value = dtpFechaRegistroC.Value;
                comandoSQL.Parameters.Add("@NumeroSiniestro", MySqlDbType.String).Value = txtNumeroSIniestroC.Text;
                comandoSQL.Parameters.Add("@NombreAjustador", MySqlDbType.String).Value = txtNombreAjustadorC.Text;

                if (cbConfirmo.Checked)
                {
                    comandoSQL.Parameters.Add("@Confirmo", MySqlDbType.Enum).Value = 1;
                }
                else
                {
                    comandoSQL.Parameters.Add("@Confirmo", MySqlDbType.Enum).Value = 2;
                }
                
                
                conexionDB.Open();
                comandoSQL.ExecuteReader();
                //dataTable.Load(resultado);
                conexionDB.Close();
                MySqlCommand comando = new MySqlCommand("Select * from confirmacion ", conexionDB);
                comando.CommandType = CommandType.Text;
                conexionDB.Open();
                resultado = comando.ExecuteReader();
                dataTable.Load(resultado);
                conexionDB.Close();


                MessageBox.Show("Confirmación Guardado Correctamente!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvConfirmacion.DataSource = dataTable;
        }
    }
}
