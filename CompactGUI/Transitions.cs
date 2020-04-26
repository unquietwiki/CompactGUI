using System;
using System.Drawing;
using System.Windows.Forms;

namespace CompactGUI
{
    internal class FadeTransition
    {
        public static double FadeTickCumulation1 { get; set; }
        public static double Bounds1 { get; set; }
        public static bool FadeCloseOnFinish1 { get; set; }

        public static Timer FadeTimer1 { get; } = new Timer();
        public static double Modifier1 { get; set; }
        public static double FadeTickCount1 { get; set; }
        public static double FadeStopOp1 { get; set; }
        public static double FadeStartOp1 { get; set; }
        public static Form FadeObj1 { get; set; }

        /// <summary>
        /// Fades the target form into or out of view
        /// </summary>
        /// <param name="targetForm">Choose the target form</param>
        /// <param name="startopacity">Set start opacity as a decimal between 0 and 1</param>
        /// <param name="endopacity">Set end opacity as a decimal between 0 and 1</param>
        /// <param name="duration">Set duration of transition in milliseconds</param>
        /// <param name="closeonFinish"></param>
        public static void FadeForm(Form targetForm, double startopacity, double endopacity, double duration, bool closeonFinish = false)
        {
            if (duration <= 30)
            {
                Modifier1 = 10;
            }

            if (duration > 30 & duration < 1000)
            {
                Modifier1 = 25;
            }

            if (duration >= 1000)
            {
                Modifier1 = 50;
            }

            FadeTimer1.Interval = Convert.ToInt32(Modifier1);
            FadeObj1 = targetForm;
            FadeObj1.Opacity = startopacity;
            FadeStartOp1 = startopacity;
            FadeStopOp1 = endopacity;
            FadeCloseOnFinish1 = closeonFinish;
            FadeTickCount1 = (endopacity - startopacity) / (duration / Modifier1);
            if (endopacity - startopacity < 0)
            {
                Bounds1 = -FadeTickCount1;
                FadeTickCumulation1 = -FadeTickCount1;
            }
            else
            {
                Bounds1 = FadeTickCount1;
                FadeTickCumulation1 = FadeTickCount1;
            }

            FadeObj1.Show();
            FadeTimer1.Tick += FadeTimer_Tick;
            FadeTimer1.Start();
        }

        public static void FadeTimer_Tick(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(FadeObj1.Opacity < FadeStopOp1 + Bounds1 & FadeObj1.Opacity > FadeStopOp1 - Bounds1))
            {
                FadeTimer1.Stop();
                FadeObj1.Opacity = FadeStopOp1;
                FadeTimer1.Tick -= FadeTimer_Tick;
                //TODO: make sure this works
                if ((FadeObj1.Opacity) == 0 && (FadeCloseOnFinish1 == true))
                {
                    FadeObj1.Close();
                }

                if ((FadeObj1.Opacity) == 0 && (FadeCloseOnFinish1 == false))
                {
                    FadeObj1.Hide();
                }
            }
            else
            {
                FadeObj1.Opacity += FadeTickCount1;
                FadeTickCumulation1 += FadeTickCount1;
            }
        }
    }

    internal class UnfurlTransition
    {
        private const decimal Modifier = 16 + (2 / 3);

        public static int UnfurlStartWidth1 { get; set; }
        public static int UnfurlEndWidth1 { get; set; }
        public static int UnfurlDuration1 { get; set; }
        public static Control UnfurlObj1 { get; set; }

        public static Timer UnfurlTimer1 { get; } = new Timer() { Interval = Convert.ToInt32(Modifier) };
        public static decimal UnfurlTickcount1 { get; set; }
        public static decimal Bounds1 { get; set; }

        public static void UnfurlControl(Control target, int startwidth, int endwidth, int duration)
        {
            if (endwidth - startwidth != 0)
            {
                UnfurlObj1 = target;
                UnfurlStartWidth1 = startwidth;
                UnfurlEndWidth1 = endwidth;
                UnfurlDuration1 = duration;
                UnfurlTickcount1 = (endwidth - startwidth) / (duration / Modifier);
                if (endwidth - startwidth < 0)
                {
                    Bounds1 = Convert.ToDecimal(-UnfurlTickcount1);
                }
                else
                {
                    Bounds1 = Convert.ToDecimal(UnfurlTickcount1);
                }

                UnfurlObj1.Width = startwidth;
                UnfurlObj1.Show();
                UnfurlTimer1.Tick += UnfurlTimer_Tick;
                UnfurlTimer1.Start();
            }
        }

        public static void UnfurlTimer_Tick(object sender, EventArgs e)
        {
            if (UnfurlObj1.Width < UnfurlEndWidth1 + Bounds1 & UnfurlObj1.Width > UnfurlEndWidth1 - Bounds1)
            {
                UnfurlTimer1.Stop();
                UnfurlObj1.Width = UnfurlEndWidth1;
                if (UnfurlObj1 == My.MyProject.Forms.Compact.topbar_dirchooserContainer)
                {
                    My.MyProject.Forms.Compact.btnAnalyze.Visible = true;
                    My.MyProject.Forms.Compact.TopBarPanel.Anchor -= (int)AnchorStyles.Bottom;
                    My.MyProject.Forms.Compact.TopBarPanel.Height = 135;
                    UnfurlObj1.Location = new Point(44, 69);
                }

                UnfurlTimer1.Tick -= UnfurlTimer_Tick;
            }
            else
            {
                UnfurlObj1.Width += (int)UnfurlTickcount1;
            }
        }
    }

    public static class PaintPercentageTransition
    {
        private static Panel TargetControl;
        private static readonly Timer PaintTimer = new Timer() { Interval = 5 };
        private static double callpercentstep = 0;
        private static double x = 1;
        private static float T;

        public static double Callpercentstep { get => callpercentstep; set => callpercentstep = value; }

        public static Timer PaintTimer1 => PaintTimer;

        public static void PaintTarget(Panel target, float targetpercentage, int speed)
        {
            TargetControl = target;
            T = targetpercentage;
            Callpercentstep = 0;
            x = 1;
            PaintTimer1.Tick += Tick;
            PaintTimer1.Interval = speed;
            PaintTimer1.Start();
        }

        public static void Tick(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Callpercentstep >= T))
            {
                PaintTimer1.Stop();
                Callpercentstep = T;
                TargetControl.Invalidate();
                TargetControl.Update();
                PaintTimer1.Tick -= Tick;
            }
            else
            {
                Callpercentstep += 1.6 * x;
                x -= T / (1.25 * Math.Pow(T, 2));
                TargetControl.Invalidate();
                TargetControl.Update();
            }
        }
    }
}