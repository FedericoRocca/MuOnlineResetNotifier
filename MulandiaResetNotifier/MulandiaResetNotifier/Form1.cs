using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace MulandiaResetNotifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Timer timerCheck;
        Process[] proc;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                proc = Process.GetProcessesByName("main");
                if( proc.Length < 1 )
                {
                    launchErrorPopUp("No se encuentra un main abierto.");
                } else if (proc.Length > 1)
                {
                    launchErrorPopUp("Se encuentra mas de un main abierto");
                } else if ( proc.Length == 1 )
                {
                    InitTimer();
                }              
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
        }

        private void launchErrorPopUp(string message)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Se produjo un error";
            popup.ContentText = message;
            popup.Popup();
        }

        public void InitTimer()
        {
            timerCheck = new Timer();
            timerCheck.Tick += new EventHandler(resetTimerTick);
            timerCheck.Interval = 10000; // in miliseconds
            timerCheck.Start();
        }

        private void resetTimerTick(object sender, EventArgs e)
        {
            if (proc.Length == 1)
            {
                string asd = proc[0].MainWindowTitle;
                if (asd.Contains("Level: [400]"))
                {
                    launchResetPopUp();
                }
            }
        }
    }
}
