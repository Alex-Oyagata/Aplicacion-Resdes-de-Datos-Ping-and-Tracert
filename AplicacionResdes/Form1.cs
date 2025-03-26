using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AplicacionResdes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComsndoPing_Click(object sender, EventArgs e)
        {
            // Verificamos si el usuario ha seleccionado IPv4 o IPv6
            string tipoIP = TipodeDireccionIP(); // Método que determina el tipo de dirección IP

            if (tipoIP == null)
            {
                MessageBox.Show("Por favor, selecciona IPv4 o IPv6.");
                return; // Si no se seleccionó, salimos del método
            }

            // Obtenemos la dirección IP o el dominio ingresado por el usuario
            string direccionIP = txtDireccion.Text;
            if (string.IsNullOrEmpty(direccionIP))
            {
                MessageBox.Show("Ingresa una dirección IP o un dominio válido.");
                return; // Salimos si la dirección es inválida
            }

            // Validamos si la dirección IP es correcta según el tipo seleccionado
            if (!ValidarDireccionIP(tipoIP, direccionIP))
            {
                return; // Si no es válida, terminamos la ejecución
            }

            // Comenzamos a construir el comando de ping base
            string comandoPing = "ping";

            // Usamos listas para separar las opciones
            List<string> opcionesCriticas = new List<string>();
            List<string> opcionesConValor = new List<string>();

            // Usamos una lista para asociar los checkboxes con sus valores
            var opciones = new List<(CheckBox CheckBox, string Valor, string Name)>
            {
                  (chkT, " -t", "chkT"), // Opción para hacer ping de manera continua
                  (chkN, $" -n {txtNumN.Text}", "chkN"), // Opción para definir el número de pings
                  (chKL, $" -l {txtNumL.Text}", "chKL"), // Opción para definir el tamaño del paquete
                  (chkA, " -a", "chkA"), // Opción para convertir la dirección IP en su dominio
                  (chkF, " -f", "chkF"), // Establecer marca no fragmentar en paquetes solo IPV 4
                  (chkI, $" -i {txtNumI.Text}", "chkI"), // es Valor de saltos maximos
                  (chkR, $" -r {txtNumR.Text}", "chkR"), //Registra la ruta a través de un número especificado de saltos
                  (chkS, $" -s {txtNumS.Text}", "chkS") // TIEMPO
            };

            // Variable para recordar cuál opción fue seleccionada
            string ultimaOpcionCritica = null;

            // Construimos las listas según las opciones seleccionadas
            foreach (var opcion in opciones)
            {
                if (opcion.CheckBox.Checked)
                {
                    // Validamos si es un checkbox crítico (-n o -l o -i)
                    if (opcion.Name == "chkN" || opcion.Name == "chKL" || opcion.Name == "chkI" || opcion.Name == "chkR" || opcion.Name == "chkS")
                    {
                        if (ultimaOpcionCritica != null)
                        {
                            // Desmarcamos la opción anterior si es crítica
                            if (ultimaOpcionCritica != opcion.Name)
                            {
                                if (ultimaOpcionCritica == "chkN") chkN.Checked = false;
                                if (ultimaOpcionCritica == "chKL") chKL.Checked = false;
                                if (ultimaOpcionCritica == "chkI") chkI.Checked = false;
                                if (ultimaOpcionCritica == "chkR") chkR.Checked = false;
                                if (ultimaOpcionCritica == "chkS") chkS.Checked = false;
                            }
                        }

                        // Actualizamos la última opción crítica seleccionada
                        ultimaOpcionCritica = opcion.Name;

                        // Validamos el número
                        int valor;
                        if (!int.TryParse(opcion.Valor.Split(' ')[2], out valor) || valor <= 0)
                        {
                            MessageBox.Show($"Por favor, ingresa un número válido en {opcion.Valor.Split(' ')[1]}.");
                            return; // Salimos si el número no es válido
                        }

                        // Añadimos la opción con valor a la lista correspondiente
                        opcionesConValor.Add(opcion.Valor);
                    }
                    else
                    {
                        // Añadimos la opción crítica a la lista de opciones críticas
                        opcionesCriticas.Add(opcion.Valor);
                    }
                }
            }

            // Construimos el comando final en orden: primero opciones críticas, luego opciones con valor
            comandoPing += string.Join("", opcionesCriticas) + " " + string.Join("", opcionesConValor) + $" {direccionIP}";

            // Mostramos el comando completo que se va a ejecutar en un mensaje ordenado
            MessageBox.Show("Comando a ejecutar: " + comandoPing);
            EjecutarComando(comandoPing); // Método que ejecuta el comando de ping
        }

        private void btnComandoTracert_Click(object sender, EventArgs e)
        {
            // Verificamos si el usuario ha seleccionado IPv4 o IPv6
            string tipoIP = TipodeDireccionIP(); // Método que determina el tipo de dirección IP
            if (tipoIP == null)
            {
                MessageBox.Show("Por favor, selecciona IPv4 o IPv6.");
                return; // Si no se seleccionó, salimos del método
            }

            // Obtenemos la dirección IP o el dominio ingresado por el usuario
            string direccionIP = txtDireccion2.Text;
            if (string.IsNullOrEmpty(direccionIP))
            {
                MessageBox.Show("Ingresa una dirección IP o un dominio válido.");
                return; // Salimos si la dirección es inválida
            }

            // Validamos si la dirección IP es correcta según el tipo seleccionado
            if (!ValidarDireccionIP(tipoIP, direccionIP))
            {
                return; // Si no es válida, terminamos la ejecución
            }

            // Comenzamos a construir el comando de tracert base
            string comandoTracert = "tracert";

            // Usamos una lista para asociar los checkboxes con sus valores
            var opciones = new List<(CheckBox CheckBox, string Valor)>
             {
                   (chkD, " -d"), // Opción para no resolver nombres
                   (chkH, $" -h {txtNumH.Text}"), // Opción para definir el número máximo de saltos
                   (chkW, $" -w {txtNumW.Text}"), //Tiempo de espera en milisegundos
                   (chkRT, " -R") //seguir la ruta de retorno
             };

            // Variable para almacenar las opciones seleccionadas
            List<string> opcionesSeleccionadas = new List<string>();

            // Construimos el comando de tracert según las opciones seleccionadas
            foreach (var opcion in opciones)
            {
                if (opcion.CheckBox.Checked) // Si el checkbox está seleccionado
                {
                    // Validamos si la opción tiene un valor adicional (como -h)
                    if (opcion.CheckBox == chkH || opcion.CheckBox == chkW)
                    {
                        int saltosMaximos;
                        // Comprobamos que el valor ingresado sea un número válido y positivo
                        if (!int.TryParse(txtNumH.Text, out saltosMaximos) || saltosMaximos <= 0)
                        {
                            MessageBox.Show("Por favor, ingresa un número válido");
                            return; // Salimos si el número no es válido
                        }
                    }
                    // Agregamos la opción seleccionada al comando
                    opcionesSeleccionadas.Add(opcion.Valor);
                }
            }

            // Construimos el comando final en orden: agregando las opciones seleccionadas
            comandoTracert += string.Join("", opcionesSeleccionadas) + $" {direccionIP}";

            // Mostramos el comando completo que se va a ejecutar
            MessageBox.Show("Comando a ejecutar: " + comandoTracert);
            EjecutarComando(comandoTracert); // Método que ejecuta el comando de tracert
        }


        private void EjecutarComando(string comando)
        {
            try
            {
                // Crear el proceso para ejecutar el comando
                Process proceso = new Process();

                //los datos con los que quiere iniciar el proceso StsrtInfor

                //StartInfo que se utiliza para iniciar procesos del sistema operativo.

                proceso.StartInfo.FileName = "cmd.exe";//Especifica el programa que se va a ejecutar 

                proceso.StartInfo.Arguments = $"/C {comando}";//define los argumentos que se pasan al programa
                proceso.StartInfo.RedirectStandardOutput = true;  //Permite redirigir la salida estándar del proceso a la aplicación
                proceso.StartInfo.RedirectStandardError = true; // Redirigir la salida de error
                proceso.StartInfo.UseShellExecute = false;// Indica que el proceso no debe utilizar la shell de Windows para ejecutar el comando
                proceso.StartInfo.CreateNoWindow = true; // Configura el proceso para que no se muestre una ventana de consola.

                // Iniciar el proceso
                proceso.Start();

                // Leer la salida estándar y la salida de error
                string resultado = proceso.StandardOutput.ReadToEnd();
                string errores = proceso.StandardError.ReadToEnd(); // Leer errores
                proceso.WaitForExit(); // Esperar a que el proceso termine

                if (!string.IsNullOrEmpty(errores))
                {
                    // Si hay errores, mostrar el mensaje
                    MessageBox.Show("Error al ejecutar el comando: " + errores);
                }
                else
                {
                    // Mostrar la salida en el área de texto
                    txtAreaDeTexto.Text += resultado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar el comando: " + ex.Message);
            }
        }



        private string TipodeDireccionIP()
        {
            if (chKIPV4.Checked && !chKIPV6.Checked)
            {
                return "IPv4";
            }
            else if (chKIPV6.Checked && !chKIPV4.Checked)
            {
                return "IPv6";
            }
            else
            {
                return null; // Si ninguno o ambos están seleccionados, devolvemos nulo
            }
        }


        private bool EsDireccionIPv4(string direccion)
        {
            try
            {

                var ipHostInfo = Dns.GetHostEntry(direccion);

                // Verificar si hay alguna dirección IPv4 en la lista
                foreach (var ip in ipHostInfo.AddressList)
                {
                    // Si encontramos una dirección IPv4, retornamos verdadero
                    if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    {
                        return true; // Es una dirección IPv4
                    }
                }

                // Si no hay direcciones IPv4, retornar falso
                return false;
            }
            catch
            {
                // Si no se puede resolver, intentamos verificar si la cadena es una dirección IP válida
                // y si es de tipo IPv4
                return IPAddress.TryParse(direccion, out IPAddress ip) &&
                       ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork;
            }
        }
        private bool EsDireccionIPv6(string direccion)
        {
            // Intentar analizar la cadena de dirección para determinar si es una dirección IP
            bool esValida = IPAddress.TryParse(direccion, out IPAddress ip);

            // Verificar si la dirección es IPv6
            if (esValida)
            {
                // Retornar verdadero si es una dirección IPv6
                return ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6;
            }

            // Retornar falso si no es válida o no es una dirección IPv6
            return false;
        }

        private bool ValidarDireccionIP(string tipoIP, string direccionIP)
        {
            if (string.IsNullOrEmpty(direccionIP))
            {
                MessageBox.Show("Ingresa una dirección IP o un dominio válido.");
                return false;
            }

            if (tipoIP == "IPv4" && !EsDireccionIPv4(direccionIP))
            {
                MessageBox.Show("No es una dirección IPv4 válida.");
                return false;
            }

            if (tipoIP == "IPv6" && !EsDireccionIPv6(direccionIP))
            {
                MessageBox.Show("No es una dirección IPv6 válida.");
                return false;
            }

            return true; // Dirección válida
        }



        //Chekbox 

        private void chKping_CheckedChanged(object sender, EventArgs e)
        {

            if (chKping.Checked)
            {
                // Mostrar los controles si Ping está seleccionado
                txtDireccion.Visible = true;
                chkT.Visible = true;
                chkN.Visible = true;
                chKL.Visible = true;
                chkA.Visible = true;
                chkF.Visible = true;
                chkI.Visible = true;
                chkR.Visible = true;
                chkS.Visible = true;


                btnComsndoPing.Visible = true;
                btnComandoTracert.Visible = false;
                chkTracert.Checked = false; // Desmarcar Tracert
                lbIngresar.Visible = true;
            }
            else
            {
                // Ocultar controles
                txtDireccion.Visible = false;
                chkT.Visible = false;
                chkN.Visible = false;
                chKL.Visible = false;
                chkA.Visible = false;
                chkF.Visible = false;
                chkI.Visible = false;
                chkR.Visible = false;
                chkS.Visible = false;

                btnComsndoPing.Visible = false;
                lbIngresar.Visible = false;

                txtNumN.Visible = false;
                txtNumL.Visible = false;
                txtNumI.Visible = false;
            }

        }

        private void chkN_CheckedChanged(object sender, EventArgs e)
        {
            if (chkN.Checked)
            {
                // Mostrar el TextBox para ingresar el número de paquetes
                txtNumN.Visible = true;
            }
            else
            {
                // Ocultar el TextBox si se desmarca
                txtNumN.Visible = false;
            }
        }

        private void chKL_CheckedChanged(object sender, EventArgs e)
        {
            if (chKL.Checked)
            {
                // Mostrar el TextBox para ingresar el tamaño del paquete
                txtNumL.Visible = true;
            }
            else
            {
                // Ocultar el TextBox si se desmarca
                txtNumL.Visible = false;
            }
        }

        private void chkTracert_CheckedChanged(object sender, EventArgs e)
        {

            if (chkTracert.Checked)
            {
                // Mostrar los controles si Ping está seleccionado
                txtDireccion2.Visible = true;
                chkD.Visible = true;
                chkH.Visible = true;
                chkW.Visible = true;
                chkRT.Visible = true;

                btnComandoTracert.Visible = true;
                btnComsndoPing.Visible = false;
                lbIngersar2.Visible = true;
                chKping.Checked = false; // Desmarcar Tracert
            }
            else
            {
                // Ocultar controles
                txtDireccion2.Visible = false;
                chkD.Visible = false;
                chkH.Visible = false;
                chkW .Visible = false;
                chkRT .Visible = false;

                btnComandoTracert.Visible = false;
                lbIngersar2.Visible = false;

                txtNumH.Visible = false;
            }

        }

        private void chkH_CheckedChanged(object sender, EventArgs e)
        {
            if (chkH.Checked)
            {
                // Mostrar el TextBox para ingresar el tamaño del paquete
                txtNumH.Visible = true;
            }
            else
            {
                // Ocultar el TextBox si se desmarca
                txtNumH.Visible = false;
            }

        }

        private void chKIPV4_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chKIPV4.Checked)
                {
                    chKIPV6.Checked = false; // Desmarcar IPv6 si se selecciona IPv4
                }
            }
        }

        private void chKIPV6_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chKIPV6.Checked)
                {
                    chKIPV4.Checked = false; // Desmarcar IPv4 si se selecciona IPv6
                }
            }
        }

        private void chkI_CheckedChanged(object sender, EventArgs e)
        {
            if (chkI.Checked)
            {
                // Mostrar el TextBox para ingresar el número de paquetes
                txtNumI.Visible = true;
            }
            else
            {
                // Ocultar el TextBox si se desmarca
                txtNumI.Visible = false;
            }
        }

        private void chkR_CheckedChanged(object sender, EventArgs e)
        {
            if (chkR.Checked)
            {
                // Mostrar el TextBox para ingresar el número de paquetes
                txtNumR.Visible = true;
            }
            else
            {
                // Ocultar el TextBox si se desmarca
                txtNumR.Visible = false;
            }
        }

        private void chkS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkS.Checked)
            {
                // Mostrar el TextBox para ingresar el número de paquetes
                txtNumS.Visible = true;
            }
            else
            {
                // Ocultar el TextBox si se desmarca
                txtNumS.Visible = false;
            }

        }

        private void chkW_CheckedChanged(object sender, EventArgs e)
        {
            if (chkW.Checked)
            {
                // Mostrar el TextBox para ingresar el número de paquetes
                txtNumW.Visible = true;
            }
            else
            {
                // Ocultar el TextBox si se desmarca
                txtNumW.Visible = false;
            }

        }
    }
}
