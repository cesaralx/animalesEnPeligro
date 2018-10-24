using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AnimalesEnPeligro
{
    
    public partial class Login : Form
    {
        private splash spl = new splash();
        public Login()
        {
            InitializeComponent();
            try
            {
                Thread hilo = new Thread(new ThreadStart(iniciarSplash));
                hilo.Start();
                Thread.Sleep(5000);
                hilo.Abort();
                this.TopMost = true;
                this.BringToFront();
            }
            catch (Exception ex) {
                Console.Write("Error al iniciar componentes " + ex);
            }
        }

        public void iniciarSplash()
        {
                Application.Run(spl); 
        }

     
    }
}
