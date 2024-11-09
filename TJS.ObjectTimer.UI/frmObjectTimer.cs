using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using TJS.ObjectTimer.BL;

namespace TJS.ObjectTimer.UI
{
    //remade the ui based on the code because I couldn't the actual project to import correctly
    public partial class frmObjectTimer : Form
    {
        // Create a Timer class object for the main timer
        StopWatch stopWatch = new StopWatch();

        public frmObjectTimer()
        {
            InitializeComponent();
        }

        private void btnStartClock_Click(object sender, EventArgs e)
        {
            try
            {
                // Start the clock
                stopWatch.StartClock();

                // Start the timer
                tmrClock.Enabled = true;

                // Set display colors
                lblElapsedTime.ForeColor = Color.Green;

                // Clear List box
                lbxSplitTimes.Items.Clear();

            }
            catch (Exception ex)
            {
                // Show error message in the status strip
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }
        private void tmrClock_Tick(object sender, EventArgs e)
        {
            //Show call duration and new split time
            lblElapsedTime.Text = stopWatch.ElapsedTime;
        }

        private void btnStopTimer_Click(object sender, EventArgs e)
        {
            // Check if the clock is running before stopping
            try
            {
                // Stop the clock
                stopWatch.StopClock();

                // Stop the timer
                tmrClock.Enabled = false;

                // Set display colors
                lblElapsedTime.ForeColor = Color.Red;

            }
            catch (Exception ex)
            {
                // Show error message in the status strip
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            //tries to get a new split time from the stopwatch
            try 
            {
                lbxSplitTimes.Items.Add(stopWatch.newSplit());
            }
            catch (Exception ex)
            {
                // Show error message in the status strip
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }
    }
}


