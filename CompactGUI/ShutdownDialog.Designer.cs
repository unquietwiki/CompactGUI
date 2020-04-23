using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CompactGUI
{
    [DesignerGenerated()]
    public partial class ShutdownDialog : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ShutdownDialog));
            _TableLayoutPanel1 = new TableLayoutPanel();
            _OK_Button = new Button();
            _OK_Button.Click += new EventHandler(OK_Button_Click);
            _shutdownTimer = new Timer(components);
            _shutdownTimer.Tick += new EventHandler(ShutdownTimer_Tick);
            _SDProcIntent = new Label();
            _SDProgText = new Label();
            _Panel1 = new Panel();
            _Label1 = new Label();
            _TableLayoutPanel1.SuspendLayout();
            _Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            _TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _TableLayoutPanel1.ColumnCount = 1;
            _TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0F));
            _TableLayoutPanel1.Controls.Add(_OK_Button, 0, 0);
            _TableLayoutPanel1.Location = new Point(3, 62);
            _TableLayoutPanel1.Name = "TableLayoutPanel1";
            _TableLayoutPanel1.RowCount = 1;
            _TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0F));
            _TableLayoutPanel1.Size = new Size(304, 41);
            _TableLayoutPanel1.TabIndex = 0;
            // 
            // OK_Button
            // 
            _OK_Button.Anchor = AnchorStyles.None;
            _OK_Button.BackColor = Color.Gainsboro;
            _OK_Button.FlatAppearance.BorderColor = Color.DarkGray;
            _OK_Button.FlatStyle = FlatStyle.Flat;
            _OK_Button.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _OK_Button.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _OK_Button.Location = new Point(118, 7);
            _OK_Button.Name = "OK_Button";
            _OK_Button.Size = new Size(67, 26);
            _OK_Button.TabIndex = 2;
            _OK_Button.Text = "Abort";
            _OK_Button.UseVisualStyleBackColor = false;
            // 
            // shutdownTimer
            // 
            _shutdownTimer.Interval = 1000;
            // 
            // SDProcIntent
            // 
            _SDProcIntent.AutoSize = true;
            _SDProcIntent.Location = new Point(302, 9);
            _SDProcIntent.Name = "SDProcIntent";
            _SDProcIntent.Size = new Size(39, 13);
            _SDProcIntent.TabIndex = 1;
            _SDProcIntent.Text = "Label1";
            _SDProcIntent.Visible = false;
            // 
            // SDProgText
            // 
            _SDProgText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _SDProgText.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)), Conversions.ToInteger(Conversions.ToByte(64)));
            _SDProgText.Location = new Point(3, 34);
            _SDProgText.Name = "SDProgText";
            _SDProgText.Size = new Size(304, 25);
            _SDProgText.TabIndex = 1;
            _SDProgText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Panel1
            // 
            _Panel1.BorderStyle = BorderStyle.FixedSingle;
            _Panel1.Controls.Add(_Label1);
            _Panel1.Controls.Add(_SDProgText);
            _Panel1.Controls.Add(_TableLayoutPanel1);
            _Panel1.Dock = DockStyle.Fill;
            _Panel1.Location = new Point(0, 0);
            _Panel1.Name = "Panel1";
            _Panel1.Size = new Size(312, 108);
            _Panel1.TabIndex = 3;
            // 
            // Label1
            // 
            _Label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label1.ForeColor = Color.DarkGray;
            _Label1.Location = new Point(3, 9);
            _Label1.Name = "Label1";
            _Label1.Size = new Size(104, 25);
            _Label1.TabIndex = 2;
            _Label1.Text = "CompactGUI";
            // 
            // ShutdownDialog
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(312, 108);
            Controls.Add(_Panel1);
            Controls.Add(_SDProcIntent);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ShutdownDialog";
            Opacity = 0.98D;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dialog1";
            TopMost = true;
            _TableLayoutPanel1.ResumeLayout(false);
            _Panel1.ResumeLayout(false);
            Load += new EventHandler(Dialog1_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        private TableLayoutPanel _TableLayoutPanel1;

        internal TableLayoutPanel TableLayoutPanel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TableLayoutPanel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TableLayoutPanel1 != null)
                {
                }

                _TableLayoutPanel1 = value;
                if (_TableLayoutPanel1 != null)
                {
                }
            }
        }

        private Button _OK_Button;

        internal Button OK_Button
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _OK_Button;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_OK_Button != null)
                {
                    _OK_Button.Click -= OK_Button_Click;
                }

                _OK_Button = value;
                if (_OK_Button != null)
                {
                    _OK_Button.Click += OK_Button_Click;
                }
            }
        }

        private Timer _shutdownTimer;

        internal Timer shutdownTimer
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _shutdownTimer;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_shutdownTimer != null)
                {
                    _shutdownTimer.Tick -= ShutdownTimer_Tick;
                }

                _shutdownTimer = value;
                if (_shutdownTimer != null)
                {
                    _shutdownTimer.Tick += ShutdownTimer_Tick;
                }
            }
        }

        private Label _SDProcIntent;

        internal Label SDProcIntent
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SDProcIntent;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SDProcIntent != null)
                {
                }

                _SDProcIntent = value;
                if (_SDProcIntent != null)
                {
                }
            }
        }

        private Label _SDProgText;

        internal Label SDProgText
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SDProgText;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SDProgText != null)
                {
                }

                _SDProgText = value;
                if (_SDProgText != null)
                {
                }
            }
        }

        private Panel _Panel1;

        internal Panel Panel1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel1 != null)
                {
                }

                _Panel1 = value;
                if (_Panel1 != null)
                {
                }
            }
        }

        private Label _Label1;

        internal Label Label1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label1 != null)
                {
                }

                _Label1 = value;
                if (_Label1 != null)
                {
                }
            }
        }
    }
}