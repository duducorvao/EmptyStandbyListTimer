using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmptyStandbyListTimer
{
    public partial class MainWindow : Form
    {

        private float TimeInterval { get; set; }
        private bool ShouldExecuteImmediately { get; set; }

        private static System.Timers.Timer SystemTimer { get; set; }

        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void StartTimer()
        {
            
        }

        private void StopTimer()
        {

        }



        #region Forms Events
        private void StartTimerBtn_Click(object sender, EventArgs e)
        {
            this.StartTimer();
        }

        private void StopTimerBtn_Click(object sender, EventArgs e)
        {
            this.StopTimer();
        }
        #endregion
    }
}
