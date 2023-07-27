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
            //Boton para buscar la poliza por el nombre del contratante
            //Creamos la cadena para la conexion a la base datos, se especifica el nombre de la base de datos, usuari, contraseña, etc
            string CadenaConexion = "Database= hdiseguros; Data source = localhost; User id=root; Password=root; SSL Mode=none; ";
            //Variable de la conexión
            MySqlConnection conexionDB;
            //Creamos una variable DataTable para poder guardar los datos obtenidos de la base de datos.
            DataTable dataTable = new DataTable();
            //Variable resultado de la ejecucion del comando.
            MySqlDataReader resultado;

            try
            {
                //Le asignamos la cadena a la conexión
                conexionDB = new MySqlConnection(CadenaConexion);
                //Definimos el codigo de la consulta y se la asignamos al comando
                MySqlCommand comando = new MySqlCommand("Select * from poliza where Contratante = '"+txtNombre.Text+"';", conexionDB);
                comando.CommandType = CommandType.Text;
                //se abre la conexión
                conexionDB.Open();
                //EL resultado de la ejecucion del comando lo guardamos en la variable resultado
                resultado = comando.ExecuteReader();
                //Se lo asignamos a la tabla
                dataTable.Load(resultado);
                //Se cierra conexión
                conexionDB.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Se asigna la tabla al DataGridiView, es donde se muestran los datos.
            dgvPoliza.DataSource = dataTable;
        }

        private void btnBuscarPoliza_Click(object sender, EventArgs e)
        {
            //Boton para buscar la poliza por el id de la poliza.
            //Creamos la cadena para la conexion a la base datos, se especifica el nombre de la base de datos, usuari, contraseña, etc
            string CadenaConexion = "Database= hdiseguros; Data source = localhost; User id=root; Password=root; SSL Mode=none; ";
            //Variable de la conexión
            MySqlConnection conexionDB;
            //Creamos una variable DataTable para poder guardar los datos obtenidos de la base de datos.
            DataTable dataTable = new DataTable();
            //Variable resultado de la ejecucion del comando.
            MySqlDataReader resultado;

            try
            {
                //Le asignamos la cadena a la conexión
                conexionDB = new MySqlConnection(CadenaConexion);
                //Definimos el codigo de la consulta y se la asignamos al comando
                MySqlCommand comando = new MySqlCommand("Select * from poliza where NumeroPoliza = '" + txtPoliza.Text + "';", conexionDB);
                comando.CommandType = CommandType.Text;
                //se abre la conexión
                conexionDB.Open();
                //EL resultado de la ejecucion del comando lo guardamos en la variable resultado
                resultado = comando.ExecuteReader();
                //Se lo asignamos a la tabla
                dataTable.Load(resultado);
                //Se cierra conexión
                conexionDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Se asigna la tabla al DataGridiView, es donde se muestran los datos.
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
            //Boton para guardar los datos del reporte
            //Creamos la cadena para la conexion a la base datos, se especifica el nombre de la base de datos, usuari, contraseña, etc
            string CadenaConexion = "Database= hdiseguros; Data source = localhost; User id=root; Password=root; SSL Mode=none; ";
            //Variable de la conexión
            MySqlConnection conexionDB;
            //Creamos una variable DataTable para poder guardar los datos obtenidos de la base de datos.
            DataTable dataTable = new DataTable();
            //Variable resultado de la ejecucion del comando.
            MySqlDataReader resultado;

            //Cadena con el comando de la ejecucion, de define la tabla y los parametros a insertar
            string sqlEjecutar = "insert into reporte (NumeroPoliza,FechaHoraOcurrencia,LugarOcurrencia," +
                "NombreQuienReportar,TelefonoContacto,CorreoELectronico,DescripcionSiniestro,Placas,Color,Observaciones,NombreAjustador)" +
                "values (@NumeroPoliza,@FechaHoraOcurrencia,@LugarOcurrencia,@NombreQuienReportar,@TelefonoContacto,@CorreoELectronico," +
                "@DescripcionSiniestro,@Placas,@Color,@Observaciones,@NombreAjustador);";

            try
            {
                //Se asigna el comando a la conexión
                conexionDB = new MySqlConnection(CadenaConexion);
                MySqlCommand comandoSQL = new MySqlCommand();
                comandoSQL.Connection = conexionDB;
                comandoSQL.CommandText = sqlEjecutar;
                //Se le asignan los valores a cada uno de los parametros.
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
                //Se ejecuta el comando
                comandoSQL.ExecuteReader();
                //dataTable.Load(resultado);
                conexionDB.Close();
                //Se ejecuta de nuevo una consulta para obtener la tabla con los valores nuevos registrados.
                MySqlCommand comando = new MySqlCommand("Select * from reporte " , conexionDB);
                comando.CommandType = CommandType.Text;
                conexionDB.Open();
                resultado = comando.ExecuteReader();
                //Se le asigna a la tabla
                dataTable.Load(resultado);
                conexionDB.Close();


                MessageBox.Show("Reporte Guardado Correctamente!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //La tabla se asigna al data grid view para que se muestre en el FORM
            dgvReportes.DataSource = dataTable;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarConfirmo_Click(object sender, EventArgs e)
        {
            //Boton para guardar los las confirmaciones de los clientes
            //Creamos la cadena para la conexion a la base datos, se especifica el nombre de la base de datos, usuari, contraseña, etc
            string CadenaConexion = "Database= hdiseguros; Data source = localhost; User id=root; Password=root; SSL Mode=none; ";
            //Variable de la conexión
            MySqlConnection conexionDB;
            //Creamos una variable DataTable para poder guardar los datos obtenidos de la base de datos.
            DataTable dataTable = new DataTable();
            //Variable resultado de la ejecucion del comando.
            MySqlDataReader resultado;

            //Cadena con el comando de la ejecucion, de define la tabla y los parametros a insertar
            string sqlEjecutar = "insert into confirmacion (FechaRegistro,NumeroSiniestro,NombreAjustador,Confirmo)" +
                "values (@FechaRegistro,@NumeroSiniestro,@NombreAjustador,@Confirmo);";

            try
            {
                //Se asigna el comando a la conexión
                conexionDB = new MySqlConnection(CadenaConexion);

                MySqlCommand comandoSQL = new MySqlCommand();
                comandoSQL.Connection = conexionDB;
                comandoSQL.CommandText = sqlEjecutar;
                //Se le asignan los valores a cada uno de los parametros.
                comandoSQL.Parameters.Add("@FechaRegistro", MySqlDbType.Date).Value = dtpFechaRegistroC.Value;
                comandoSQL.Parameters.Add("@NumeroSiniestro", MySqlDbType.String).Value = txtNumeroSIniestroC.Text;
                comandoSQL.Parameters.Add("@NombreAjustador", MySqlDbType.String).Value = txtNombreAjustadorC.Text;

                //SI el checkbox esta chekeado se manda como parametro 1 que es "Si"
                if (cbConfirmo.Checked)
                {
                    comandoSQL.Parameters.Add("@Confirmo", MySqlDbType.Enum).Value = 1;
                }
                else
                {
                    //SI el checkbox no esta chekeado se manda como parametro 2 que es "No"
                    comandoSQL.Parameters.Add("@Confirmo", MySqlDbType.Enum).Value = 2;
                }
                
                //Se abre la conexión y se ejecuta el comando
                conexionDB.Open();
                comandoSQL.ExecuteReader();
                // Cierra conexión
                conexionDB.Close();
                //Se ejecuta de nuevo una consulta para obtener la tabla con los valores nuevos registrados.
                MySqlCommand comando = new MySqlCommand("Select * from confirmacion ", conexionDB);
                comando.CommandType = CommandType.Text;
                conexionDB.Open();
                resultado = comando.ExecuteReader();
                //Los datos obtenidos se le asignan a la tabla
                dataTable.Load(resultado);
                //Cierra conexión
                conexionDB.Close();

                //Mensaje de confirmación de exito
                MessageBox.Show("Confirmación Guardado Correctamente!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //La tabla se asigna al datagridview para que se muestre en el FORM
            dgvConfirmacion.DataSource = dataTable;
        }
    }
}
