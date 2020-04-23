using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CompactGUI
{
    [DesignerGenerated()]
    public partial class WikiSubmission : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(WikiSubmission));
            _Panel1 = new Panel();
            _Panel1.Paint += new PaintEventHandler(WikiSubmission_Paint);
            _Panel1.MouseDown += new MouseEventHandler(Panel_topBar_MouseDown);
            _LblTitle = new Label();
            _TxtBoxName = new TextBox();
            _LblGameorProgram = new Label();
            _LblSteamID = new Label();
            _Lbloptional = new Label();
            _ToolTip1 = new ToolTip(components);
            _TxtBoxSteamID = new NumericUpDown();
            _Label2 = new Label();
            _BtnNextPage = new Button();
            _BtnNextPage.Click += new EventHandler(Btn_NextPage_Click);
            _BtnCancel = new Button();
            _BtnCancel.Click += new EventHandler(Btn_Cancel_Click);
            _TabControl1 = new TabControl();
            _Page1 = new TabPage();
            _Radio_Program = new RadioButton();
            _Radio_Game = new RadioButton();
            _Label6 = new Label();
            _Page2 = new TabPage();
            _PanelSteamID = new Panel();
            _Page3 = new TabPage();
            _ListView1 = new ListView();
            _ColumnHeader1 = new ColumnHeader();
            _ColumnHeader2 = new ColumnHeader();
            _Panel2 = new Panel();
            _Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_TxtBoxSteamID).BeginInit();
            _TabControl1.SuspendLayout();
            _Page1.SuspendLayout();
            _Page2.SuspendLayout();
            _PanelSteamID.SuspendLayout();
            _Page3.SuspendLayout();
            _Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(47)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(83)));
            _Panel1.Controls.Add(_LblTitle);
            _Panel1.Dock = DockStyle.Top;
            _Panel1.Location = new Point(0, 0);
            _Panel1.Name = "Panel1";
            _Panel1.Size = new Size(590, 60);
            _Panel1.TabIndex = 0;
            // 
            // LblTitle
            // 
            _LblTitle.AutoSize = true;
            _LblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _LblTitle.ForeColor = Color.White;
            _LblTitle.Location = new Point(12, 18);
            _LblTitle.Name = "LblTitle";
            _LblTitle.Size = new Size(140, 30);
            _LblTitle.TabIndex = 0;
            _LblTitle.Text = "Submit Result";
            // 
            // TxtBoxName
            // 
            _TxtBoxName.Font = new Font("Segoe UI", 10.0F);
            _TxtBoxName.Location = new Point(198, 47);
            _TxtBoxName.MaxLength = 100;
            _TxtBoxName.Name = "TxtBoxName";
            _TxtBoxName.Size = new Size(233, 25);
            _TxtBoxName.TabIndex = 1;
            _ToolTip1.SetToolTip(_TxtBoxName, resources.GetString("TxtBoxName.ToolTip"));
            // 
            // LblGameorProgram
            // 
            _LblGameorProgram.AutoSize = true;
            _LblGameorProgram.Font = new Font("Segoe UI", 11.0F);
            _LblGameorProgram.Location = new Point(37, 48);
            _LblGameorProgram.Name = "LblGameorProgram";
            _LblGameorProgram.Size = new Size(95, 20);
            _LblGameorProgram.TabIndex = 2;
            _LblGameorProgram.Text = "Game Name:";
            _ToolTip1.SetToolTip(_LblGameorProgram, resources.GetString("LblGameorProgram.ToolTip"));
            // 
            // LblSteamID
            // 
            _LblSteamID.AutoSize = true;
            _LblSteamID.Font = new Font("Segoe UI", 11.0F);
            _LblSteamID.Location = new Point(41, 20);
            _LblSteamID.Name = "LblSteamID";
            _LblSteamID.Size = new Size(73, 20);
            _LblSteamID.TabIndex = 2;
            _LblSteamID.Text = "Steam ID:";
            _ToolTip1.SetToolTip(_LblSteamID, resources.GetString("LblSteamID.ToolTip"));
            // 
            // Lbloptional
            // 
            _Lbloptional.AutoSize = true;
            _Lbloptional.Font = new Font("Segoe UI", 8.0F);
            _Lbloptional.ForeColor = Color.Maroon;
            _Lbloptional.Location = new Point(419, 25);
            _Lbloptional.Name = "Lbloptional";
            _Lbloptional.Size = new Size(59, 13);
            _Lbloptional.TabIndex = 2;
            _Lbloptional.Text = "(Optional)";
            _ToolTip1.SetToolTip(_Lbloptional, resources.GetString("Lbloptional.ToolTip"));
            // 
            // ToolTip1
            // 
            _ToolTip1.AutomaticDelay = 100;
            _ToolTip1.AutoPopDelay = 10000;
            _ToolTip1.BackColor = Color.White;
            _ToolTip1.ForeColor = Color.Black;
            _ToolTip1.InitialDelay = 100;
            _ToolTip1.IsBalloon = true;
            _ToolTip1.ReshowDelay = 20;
            _ToolTip1.ToolTipIcon = ToolTipIcon.Info;
            _ToolTip1.ToolTipTitle = "Help";
            // 
            // TxtBoxSteamID
            // 
            _TxtBoxSteamID.BackColor = Color.White;
            _TxtBoxSteamID.BorderStyle = BorderStyle.FixedSingle;
            _TxtBoxSteamID.Font = new Font("Segoe UI", 10.0F);
            _TxtBoxSteamID.Location = new Point(180, 20);
            _TxtBoxSteamID.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            _TxtBoxSteamID.Name = "TxtBoxSteamID";
            _TxtBoxSteamID.Size = new Size(233, 25);
            _TxtBoxSteamID.TabIndex = 4;
            _ToolTip1.SetToolTip(_TxtBoxSteamID, resources.GetString("TxtBoxSteamID.ToolTip"));
            // 
            // Label2
            // 
            _Label2.AutoSize = true;
            _Label2.Font = new Font("Segoe UI", 11.0F);
            _Label2.Location = new Point(31, 19);
            _Label2.Name = "Label2";
            _Label2.Size = new Size(235, 20);
            _Label2.TabIndex = 3;
            _Label2.Text = "The following data has been sent. ";
            _ToolTip1.SetToolTip(_Label2, resources.GetString("Label2.ToolTip"));
            // 
            // BtnNextPage
            // 
            _BtnNextPage.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(47)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(83)));
            _BtnNextPage.FlatStyle = FlatStyle.Flat;
            _BtnNextPage.Font = new Font("Segoe UI", 10.0F);
            _BtnNextPage.ForeColor = Color.White;
            _BtnNextPage.Location = new Point(503, 5);
            _BtnNextPage.Name = "BtnNextPage";
            _BtnNextPage.Size = new Size(75, 32);
            _BtnNextPage.TabIndex = 3;
            _BtnNextPage.Text = "Next";
            _BtnNextPage.UseVisualStyleBackColor = false;
            // 
            // BtnCancel
            // 
            _BtnCancel.BackColor = Color.Maroon;
            _BtnCancel.DialogResult = DialogResult.Cancel;
            _BtnCancel.FlatStyle = FlatStyle.Flat;
            _BtnCancel.Font = new Font("Segoe UI", 10.0F);
            _BtnCancel.ForeColor = Color.White;
            _BtnCancel.Location = new Point(420, 5);
            _BtnCancel.Name = "BtnCancel";
            _BtnCancel.Size = new Size(75, 32);
            _BtnCancel.TabIndex = 3;
            _BtnCancel.Text = "Cancel";
            _BtnCancel.UseVisualStyleBackColor = false;
            // 
            // TabControl1
            // 
            _TabControl1.Controls.Add(_Page1);
            _TabControl1.Controls.Add(_Page2);
            _TabControl1.Controls.Add(_Page3);
            _TabControl1.Location = new Point(-5, 37);
            _TabControl1.Name = "TabControl1";
            _TabControl1.SelectedIndex = 0;
            _TabControl1.Size = new Size(602, 214);
            _TabControl1.TabIndex = 4;
            // 
            // Page1
            // 
            _Page1.Controls.Add(_Radio_Program);
            _Page1.Controls.Add(_Radio_Game);
            _Page1.Controls.Add(_Label6);
            _Page1.Location = new Point(4, 22);
            _Page1.Name = "Page1";
            _Page1.Padding = new Padding(3);
            _Page1.Size = new Size(594, 188);
            _Page1.TabIndex = 2;
            _Page1.Text = "Page1";
            _Page1.UseVisualStyleBackColor = true;
            // 
            // Radio_Program
            // 
            _Radio_Program.AutoSize = true;
            _Radio_Program.Font = new Font("Segoe UI", 9.0F);
            _Radio_Program.Location = new Point(65, 117);
            _Radio_Program.Name = "Radio_Program";
            _Radio_Program.Size = new Size(71, 19);
            _Radio_Program.TabIndex = 4;
            _Radio_Program.TabStop = true;
            _Radio_Program.Text = "Program";
            _Radio_Program.UseVisualStyleBackColor = true;
            // 
            // Radio_Game
            // 
            _Radio_Game.AutoSize = true;
            _Radio_Game.Font = new Font("Segoe UI", 9.0F);
            _Radio_Game.Location = new Point(65, 85);
            _Radio_Game.Name = "Radio_Game";
            _Radio_Game.Size = new Size(56, 19);
            _Radio_Game.TabIndex = 4;
            _Radio_Game.TabStop = true;
            _Radio_Game.Text = "Game";
            _Radio_Game.UseVisualStyleBackColor = true;
            // 
            // Label6
            // 
            _Label6.AutoSize = true;
            _Label6.Font = new Font("Segoe UI", 11.0F);
            _Label6.Location = new Point(37, 48);
            _Label6.Name = "Label6";
            _Label6.Size = new Size(288, 20);
            _Label6.TabIndex = 3;
            _Label6.Text = "Are you submitting a game or a program?";
            // 
            // Page2
            // 
            _Page2.Controls.Add(_PanelSteamID);
            _Page2.Controls.Add(_TxtBoxName);
            _Page2.Controls.Add(_LblGameorProgram);
            _Page2.Location = new Point(4, 22);
            _Page2.Name = "Page2";
            _Page2.Padding = new Padding(3);
            _Page2.Size = new Size(594, 188);
            _Page2.TabIndex = 0;
            _Page2.Text = "Page2";
            _Page2.UseVisualStyleBackColor = true;
            // 
            // PanelSteamID
            // 
            _PanelSteamID.Controls.Add(_TxtBoxSteamID);
            _PanelSteamID.Controls.Add(_LblSteamID);
            _PanelSteamID.Controls.Add(_Lbloptional);
            _PanelSteamID.Location = new Point(18, 74);
            _PanelSteamID.Name = "PanelSteamID";
            _PanelSteamID.Size = new Size(490, 60);
            _PanelSteamID.TabIndex = 3;
            // 
            // Page3
            // 
            _Page3.Controls.Add(_ListView1);
            _Page3.Controls.Add(_Label2);
            _Page3.Location = new Point(4, 22);
            _Page3.Name = "Page3";
            _Page3.Padding = new Padding(3);
            _Page3.Size = new Size(594, 188);
            _Page3.TabIndex = 1;
            _Page3.Text = "Page3";
            _Page3.UseVisualStyleBackColor = true;
            // 
            // ListView1
            // 
            _ListView1.BorderStyle = BorderStyle.FixedSingle;
            _ListView1.Columns.AddRange(new ColumnHeader[] { _ColumnHeader1, _ColumnHeader2 });
            _ListView1.Font = new Font("Segoe UI", 7.0F);
            _ListView1.GridLines = true;
            _ListView1.HeaderStyle = ColumnHeaderStyle.None;
            _ListView1.Location = new Point(35, 46);
            _ListView1.Name = "ListView1";
            _ListView1.Size = new Size(533, 136);
            _ListView1.TabIndex = 4;
            _ListView1.UseCompatibleStateImageBehavior = false;
            _ListView1.View = View.Details;
            // 
            // ColumnHeader1
            // 
            _ColumnHeader1.Text = "Data";
            _ColumnHeader1.Width = 120;
            // 
            // ColumnHeader2
            // 
            _ColumnHeader2.Text = "Value";
            _ColumnHeader2.Width = 700;
            // 
            // Panel2
            // 
            _Panel2.BackColor = Color.White;
            _Panel2.Controls.Add(_BtnNextPage);
            _Panel2.Controls.Add(_BtnCancel);
            _Panel2.Dock = DockStyle.Bottom;
            _Panel2.Location = new Point(0, 244);
            _Panel2.Name = "Panel2";
            _Panel2.Size = new Size(590, 49);
            _Panel2.TabIndex = 5;
            // 
            // WikiSubmission
            // 
            AcceptButton = _BtnNextPage;
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(47)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(83)));
            CancelButton = _BtnCancel;
            ClientSize = new Size(590, 293);
            Controls.Add(_Panel1);
            Controls.Add(_Panel2);
            Controls.Add(_TabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WikiSubmission";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WikiSubmission";
            _Panel1.ResumeLayout(false);
            _Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_TxtBoxSteamID).EndInit();
            _TabControl1.ResumeLayout(false);
            _Page1.ResumeLayout(false);
            _Page1.PerformLayout();
            _Page2.ResumeLayout(false);
            _Page2.PerformLayout();
            _PanelSteamID.ResumeLayout(false);
            _PanelSteamID.PerformLayout();
            _Page3.ResumeLayout(false);
            _Page3.PerformLayout();
            _Panel2.ResumeLayout(false);
            ResumeLayout(false);
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
                    _Panel1.Paint -= WikiSubmission_Paint;
                    _Panel1.MouseDown -= Panel_topBar_MouseDown;
                }

                _Panel1 = value;
                if (_Panel1 != null)
                {
                    _Panel1.Paint += WikiSubmission_Paint;
                    _Panel1.MouseDown += Panel_topBar_MouseDown;
                }
            }
        }

        private Label _LblTitle;

        internal Label LblTitle
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LblTitle;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LblTitle != null)
                {
                }

                _LblTitle = value;
                if (_LblTitle != null)
                {
                }
            }
        }

        private TextBox _TxtBoxName;

        internal TextBox TxtBoxName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TxtBoxName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TxtBoxName != null)
                {
                }

                _TxtBoxName = value;
                if (_TxtBoxName != null)
                {
                }
            }
        }

        private Label _LblGameorProgram;

        internal Label LblGameorProgram
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LblGameorProgram;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LblGameorProgram != null)
                {
                }

                _LblGameorProgram = value;
                if (_LblGameorProgram != null)
                {
                }
            }
        }

        private Label _LblSteamID;

        internal Label LblSteamID
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LblSteamID;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LblSteamID != null)
                {
                }

                _LblSteamID = value;
                if (_LblSteamID != null)
                {
                }
            }
        }

        private Label _Lbloptional;

        internal Label Lbloptional
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Lbloptional;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Lbloptional != null)
                {
                }

                _Lbloptional = value;
                if (_Lbloptional != null)
                {
                }
            }
        }

        private ToolTip _ToolTip1;

        internal ToolTip ToolTip1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolTip1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ToolTip1 != null)
                {
                }

                _ToolTip1 = value;
                if (_ToolTip1 != null)
                {
                }
            }
        }

        private Button _BtnNextPage;

        internal Button BtnNextPage
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtnNextPage;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnNextPage != null)
                {
                    _BtnNextPage.Click -= Btn_NextPage_Click;
                }

                _BtnNextPage = value;
                if (_BtnNextPage != null)
                {
                    _BtnNextPage.Click += Btn_NextPage_Click;
                }
            }
        }

        private Button _BtnCancel;

        internal Button BtnCancel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtnCancel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnCancel != null)
                {
                    _BtnCancel.Click -= Btn_Cancel_Click;
                }

                _BtnCancel = value;
                if (_BtnCancel != null)
                {
                    _BtnCancel.Click += Btn_Cancel_Click;
                }
            }
        }

        private TabControl _TabControl1;

        internal TabControl TabControl1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabControl1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabControl1 != null)
                {
                }

                _TabControl1 = value;
                if (_TabControl1 != null)
                {
                }
            }
        }

        private TabPage _Page2;

        internal TabPage Page2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Page2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Page2 != null)
                {
                }

                _Page2 = value;
                if (_Page2 != null)
                {
                }
            }
        }

        private TabPage _Page3;

        internal TabPage Page3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Page3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Page3 != null)
                {
                }

                _Page3 = value;
                if (_Page3 != null)
                {
                }
            }
        }

        private TabPage _Page1;

        internal TabPage Page1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Page1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Page1 != null)
                {
                }

                _Page1 = value;
                if (_Page1 != null)
                {
                }
            }
        }

        private RadioButton _Radio_Program;

        internal RadioButton Radio_Program
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Radio_Program;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Radio_Program != null)
                {
                }

                _Radio_Program = value;
                if (_Radio_Program != null)
                {
                }
            }
        }

        private RadioButton _Radio_Game;

        internal RadioButton Radio_Game
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Radio_Game;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Radio_Game != null)
                {
                }

                _Radio_Game = value;
                if (_Radio_Game != null)
                {
                }
            }
        }

        private Label _Label6;

        internal Label Label6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label6 != null)
                {
                }

                _Label6 = value;
                if (_Label6 != null)
                {
                }
            }
        }

        private Panel _Panel2;

        internal Panel Panel2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel2 != null)
                {
                }

                _Panel2 = value;
                if (_Panel2 != null)
                {
                }
            }
        }

        private Panel _PanelSteamID;

        internal Panel PanelSteamID
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PanelSteamID;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PanelSteamID != null)
                {
                }

                _PanelSteamID = value;
                if (_PanelSteamID != null)
                {
                }
            }
        }

        private NumericUpDown _TxtBoxSteamID;

        internal NumericUpDown TxtBoxSteamID
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TxtBoxSteamID;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TxtBoxSteamID != null)
                {
                }

                _TxtBoxSteamID = value;
                if (_TxtBoxSteamID != null)
                {
                }
            }
        }

        private Label _Label2;

        internal Label Label2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label2 != null)
                {
                }

                _Label2 = value;
                if (_Label2 != null)
                {
                }
            }
        }

        private ListView _ListView1;

        internal ListView ListView1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ListView1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ListView1 != null)
                {
                }

                _ListView1 = value;
                if (_ListView1 != null)
                {
                }
            }
        }

        private ColumnHeader _ColumnHeader1;

        internal ColumnHeader ColumnHeader1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader1 != null)
                {
                }

                _ColumnHeader1 = value;
                if (_ColumnHeader1 != null)
                {
                }
            }
        }

        private ColumnHeader _ColumnHeader2;

        internal ColumnHeader ColumnHeader2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ColumnHeader2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ColumnHeader2 != null)
                {
                }

                _ColumnHeader2 = value;
                if (_ColumnHeader2 != null)
                {
                }
            }
        }
    }
}