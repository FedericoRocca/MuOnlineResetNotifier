using System;
using System.Diagnostics;
using System.Media;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace MulandiaResetNotifier
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        private Timer timerCheck;
        Process[] proc;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                InitTimer(); //Iniciamos el timer
            }
            catch (Exception ex)
            {
                launchErrorPopUp(ex.Message);
            }
        }

        private void launchResetPopUp()
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Personaje reseteado!";
            popup.ContentText = "Tu personaje llegó al nivel 400 y está listo para resetear";
            popup.Popup();
            if( chkBoxSonidoNotificacion.Checked )
            {
                SoundPlayer notification = new SoundPlayer(Properties.Resources.Notification);
                notification.Play();
            }
        }

        private void launchErrorPopUp(string message)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Se produjo un error";
            popup.ContentText = message;
            popup.Popup();
            if (chkBoxSonidoNotificacion.Checked)
            {
                SoundPlayer notification = new SoundPlayer(Properties.Resources.Error_Notification);
                notification.Play();
            }
        }

        public void setTimerInterval()
        {
            int minutos = 60000;
            int segundos = 1000;
            timerCheck.Interval = Convert.ToInt32(nudTimer.Value) * minutos; //Convertimos a minutos y seteamos el intervalo
        }

        public void InitTimer()
        {
            timerCheck = new Timer();
            timerCheck.Tick += new EventHandler(resetTimerTick); // Cuando se vence el timeout lanzamos el evento
            setTimerInterval();
            timerCheck.Start();
        }

        private void resetTimerTick(object sender, EventArgs e) // Evento de vencimiento del timer
        {
            // TODO: Obtener el PID del proceso lanzado desde el launcher para isolar el main de Mulandia
            string processName = "main";
            proc = Process.GetProcessesByName(processName);
            if (proc.Length < 1)
            {
                launchErrorPopUp("No se encuentra un main abierto.");
            }
            else if (proc.Length > 1)
            {
                launchErrorPopUp("Se encuentra mas de un main abierto");
            }

            if (proc.Length == 1)
            {
                proc = Process.GetProcessesByName("main"); // Obtenemos nuevamente el proceso, ya que el title de la ventana va cambiando
                string windowTitle = proc[0].MainWindowTitle;
                if (windowTitle.Contains("Level: [400]"))
                {
                    launchResetPopUp();
                }
            }
        }

        // Eventos de cierre y resize del form
        private void mainForm_Resize(object sender, System.EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
        }

        private void notifyIcon1_DoubleClick(object sender,
                                     System.EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void formClose(object sender, FormClosedEventArgs e)
        {
            Hide();
        }

        private void timerChanged(object sender, EventArgs e)
        {
            setTimerInterval();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
        }

        private void formClose(object sender, FormClosingEventArgs e)
        {
            Hide();
        }
    }
}
