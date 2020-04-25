using CompactGUI.My.Resources;
using System;
using System.Diagnostics;
using System.Windows.Forms;

#nullable enable

namespace CompactGUI
{
    public partial class ShutdownDialog
    {
        public ShutdownDialog() => InitializeComponent();

        private void OK_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            shutdownTimer.Stop();
            FadeTransition.FadeForm(this, Convert.ToDouble(0.96M), 0, 300, true);
            // Me.Close()
        }

        private void Dialog1_Load(object sender, EventArgs e)
        {
            shutdownTimer.Start();
            string switchExpr = SDProcIntent.Text;
            switch (switchExpr)
            {
                case "Shutdown":
                    {
                        SDProgText.Text = Resources.StrTimedShutdown;
                        break;
                    }

                case "Restart":
                    {
                        SDProgText.Text = Resources.StrTimedRestart;
                        break;
                    }

                case "Sleep":
                    {
                        SDProgText.Text = Resources.StrTimedSleep;
                        break;
                    }
            }
        }

        private int secCount = 9;

        private void ShutdownTimer_Tick(object sender, EventArgs e)
        {
            string switchExpr = SDProcIntent.Text;
            switch (switchExpr)
            {
                case "Shutdown":
                    {
                        SDProgText.Text = "Shutting down in " + secCount + " seconds";
                        break;
                    }

                case "Restart":
                    {
                        SDProgText.Text = "Restarting in " + secCount + " seconds";
                        break;
                    }

                case "Sleep":
                    {
                        SDProgText.Text = "Sleeping in " + secCount + " seconds";
                        break;
                    }
            }

            SDProgText.Visible = true;
            if (secCount == 0)
            {
                secCount = 10;
                shutdownTimer.Stop();
                string switchExpr1 = SDProcIntent.Text;
                switch (switchExpr1)
                {
                    case "Shutdown":
                        {
                            Process.Start("shutdown", "/s /t 0");
                            Close();
                            break;
                        }

                    case "Restart":
                        {
                            Process.Start("shutdown", "/r /t 0");
                            Close();
                            break;
                        }

                    case "Sleep":
                        {
                            Application.SetSuspendState(PowerState.Suspend, false, false);
                            Close();
                            break;
                        }
                }

                DialogResult = DialogResult.OK;
            }

            secCount -= 1;
        }
    }
}