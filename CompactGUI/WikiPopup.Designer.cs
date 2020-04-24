using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CompactGUI
{
    [DesignerGenerated()]
    public partial class WikiPopup : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(WikiPopup));
            _GamesTable = new TableLayoutPanel();
            _Label1 = new Label();
            _Panel1 = new Panel();
            _Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            _ImportantToolTip = new ToolTip(components);
            _Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // GamesTable
            // 
            _GamesTable.AutoSize = true;
            _GamesTable.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _GamesTable.BackColor = Color.Transparent;
            _GamesTable.ColumnCount = 5;
            _GamesTable.ColumnStyles.Add(new ColumnStyle());
            _GamesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80.0F));
            _GamesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80.0F));
            _GamesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70.0F));
            _GamesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110.0F));
            _GamesTable.ForeColor = Color.White;
            _GamesTable.Location = new Point(16, 69);
            _GamesTable.Name = "GamesTable";
            _GamesTable.RowCount = 1;
            _GamesTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 35.0F));
            _GamesTable.Size = new Size(340, 35);
            _GamesTable.TabIndex = 7;
            _GamesTable.Visible = false;
            // 
            // Label1
            // 
            _Label1.AutoSize = true;
            _Label1.BackColor = Color.Transparent;
            _Label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label1.ForeColor = Color.White;
            _Label1.Location = new Point(11, 27);
            _Label1.Name = "Label1";
            _Label1.Size = new Size(131, 25);
            _Label1.TabIndex = 8;
            _Label1.Text = "Online Results";
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.Transparent;
            _Panel1.BorderStyle = BorderStyle.FixedSingle;
            _Panel1.Controls.Add(_Label1);
            _Panel1.Controls.Add(_GamesTable);
            _Panel1.Dock = DockStyle.Fill;
            _Panel1.ForeColor = Color.Black;
            _Panel1.Location = new Point(0, 0);
            _Panel1.Name = "Panel1";
            _Panel1.Size = new Size(430, 375);
            _Panel1.TabIndex = 9;
            // 
            // ImportantToolTip
            // 
            _ImportantToolTip.AutomaticDelay = 100;
            _ImportantToolTip.AutoPopDelay = 3000;
            _ImportantToolTip.BackColor = Color.White;
            _ImportantToolTip.InitialDelay = 100;
            _ImportantToolTip.ReshowDelay = 20;
            _ImportantToolTip.ShowAlways = true;
            _ImportantToolTip.ToolTipIcon = ToolTipIcon.Info;
            // 
            // WikiPopup
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(Convert.ToInt32(Conversions.ToByte(43)), Convert.ToInt32(Conversions.ToByte(60)), Convert.ToInt32(Conversions.ToByte(75)));
            ClientSize = new Size(430, 375);
            Controls.Add(_Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WikiPopup";
            Opacity = 0D;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Form2";
            _Panel1.ResumeLayout(false);
            _Panel1.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel _GamesTable;

        internal TableLayoutPanel GamesTable
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GamesTable;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GamesTable != null)
                {
                }

                _GamesTable = value;
                if (_GamesTable != null)
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
                    _Panel1.Paint -= Panel1_Paint;
                }

                _Panel1 = value;
                if (_Panel1 != null)
                {
                    _Panel1.Paint += Panel1_Paint;
                }
            }
        }

        private ToolTip _ImportantToolTip;

        internal ToolTip ImportantToolTip
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ImportantToolTip;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ImportantToolTip != null)
                {
                }

                _ImportantToolTip = value;
                if (_ImportantToolTip != null)
                {
                }
            }
        }
    }
}