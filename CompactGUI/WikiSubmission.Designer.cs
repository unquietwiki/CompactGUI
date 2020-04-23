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
            _lbl_Title = new Label();
            _txtbox_Name = new TextBox();
            _lbl_GameorProgram = new Label();
            _lbl_SteamID = new Label();
            _lbl_optional = new Label();
            _ToolTip1 = new ToolTip(components);
            _txtbox_SteamID = new NumericUpDown();
            _Label2 = new Label();
            _btn_NextPage = new Button();
            _btn_NextPage.Click += new EventHandler(Btn_NextPage_Click);
            _btn_Cancel = new Button();
            _btn_Cancel.Click += new EventHandler(Btn_Cancel_Click);
            _TabControl1 = new TabControl();
            _Page1 = new TabPage();
            _Radio_Program = new RadioButton();
            _Radio_Game = new RadioButton();
            _Label6 = new Label();
            _Page2 = new TabPage();
            _panel_SteamID = new Panel();
            _Page3 = new TabPage();
            _ListView1 = new ListView();
            _ColumnHeader1 = new ColumnHeader();
            _ColumnHeader2 = new ColumnHeader();
            _Panel2 = new Panel();
            _Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_txtbox_SteamID).BeginInit();
            _TabControl1.SuspendLayout();
            _Page1.SuspendLayout();
            _Page2.SuspendLayout();
            _panel_SteamID.SuspendLayout();
            _Page3.SuspendLayout();
            _Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            _Panel1.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(47)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(83)));
            _Panel1.Controls.Add(_lbl_Title);
            _Panel1.Dock = DockStyle.Top;
            _Panel1.Location = new Point(0, 0);
            _Panel1.Name = "Panel1";
            _Panel1.Size = new Size(590, 60);
            _Panel1.TabIndex = 0;
            // 
            // lbl_Title
            // 
            _lbl_Title.AutoSize = true;
            _lbl_Title.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _lbl_Title.ForeColor = Color.White;
            _lbl_Title.Location = new Point(12, 18);
            _lbl_Title.Name = "lbl_Title";
            _lbl_Title.Size = new Size(140, 30);
            _lbl_Title.TabIndex = 0;
            _lbl_Title.Text = "Submit Result";
            // 
            // txtbox_Name
            // 
            _txtbox_Name.Font = new Font("Segoe UI", 10.0F);
            _txtbox_Name.Location = new Point(198, 47);
            _txtbox_Name.MaxLength = 100;
            _txtbox_Name.Name = "txtbox_Name";
            _txtbox_Name.Size = new Size(233, 25);
            _txtbox_Name.TabIndex = 1;
            _ToolTip1.SetToolTip(_txtbox_Name, resources.GetString("txtbox_Name.ToolTip"));
            // 
            // lbl_GameorProgram
            // 
            _lbl_GameorProgram.AutoSize = true;
            _lbl_GameorProgram.Font = new Font("Segoe UI", 11.0F);
            _lbl_GameorProgram.Location = new Point(37, 48);
            _lbl_GameorProgram.Name = "lbl_GameorProgram";
            _lbl_GameorProgram.Size = new Size(95, 20);
            _lbl_GameorProgram.TabIndex = 2;
            _lbl_GameorProgram.Text = "Game Name:";
            _ToolTip1.SetToolTip(_lbl_GameorProgram, resources.GetString("lbl_GameorProgram.ToolTip"));
            // 
            // lbl_SteamID
            // 
            _lbl_SteamID.AutoSize = true;
            _lbl_SteamID.Font = new Font("Segoe UI", 11.0F);
            _lbl_SteamID.Location = new Point(41, 20);
            _lbl_SteamID.Name = "lbl_SteamID";
            _lbl_SteamID.Size = new Size(73, 20);
            _lbl_SteamID.TabIndex = 2;
            _lbl_SteamID.Text = "Steam ID:";
            _ToolTip1.SetToolTip(_lbl_SteamID, resources.GetString("lbl_SteamID.ToolTip"));
            // 
            // lbl_optional
            // 
            _lbl_optional.AutoSize = true;
            _lbl_optional.Font = new Font("Segoe UI", 8.0F);
            _lbl_optional.ForeColor = Color.Maroon;
            _lbl_optional.Location = new Point(419, 25);
            _lbl_optional.Name = "lbl_optional";
            _lbl_optional.Size = new Size(59, 13);
            _lbl_optional.TabIndex = 2;
            _lbl_optional.Text = "(Optional)";
            _ToolTip1.SetToolTip(_lbl_optional, resources.GetString("lbl_optional.ToolTip"));
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
            // txtbox_SteamID
            // 
            _txtbox_SteamID.BackColor = Color.White;
            _txtbox_SteamID.BorderStyle = BorderStyle.FixedSingle;
            _txtbox_SteamID.Font = new Font("Segoe UI", 10.0F);
            _txtbox_SteamID.Location = new Point(180, 20);
            _txtbox_SteamID.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            _txtbox_SteamID.Name = "txtbox_SteamID";
            _txtbox_SteamID.Size = new Size(233, 25);
            _txtbox_SteamID.TabIndex = 4;
            _ToolTip1.SetToolTip(_txtbox_SteamID, resources.GetString("txtbox_SteamID.ToolTip"));
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
            // btn_NextPage
            // 
            _btn_NextPage.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(47)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(83)));
            _btn_NextPage.FlatStyle = FlatStyle.Flat;
            _btn_NextPage.Font = new Font("Segoe UI", 10.0F);
            _btn_NextPage.ForeColor = Color.White;
            _btn_NextPage.Location = new Point(503, 5);
            _btn_NextPage.Name = "btn_NextPage";
            _btn_NextPage.Size = new Size(75, 32);
            _btn_NextPage.TabIndex = 3;
            _btn_NextPage.Text = "Next";
            _btn_NextPage.UseVisualStyleBackColor = false;
            // 
            // btn_Cancel
            // 
            _btn_Cancel.BackColor = Color.Maroon;
            _btn_Cancel.DialogResult = DialogResult.Cancel;
            _btn_Cancel.FlatStyle = FlatStyle.Flat;
            _btn_Cancel.Font = new Font("Segoe UI", 10.0F);
            _btn_Cancel.ForeColor = Color.White;
            _btn_Cancel.Location = new Point(420, 5);
            _btn_Cancel.Name = "btn_Cancel";
            _btn_Cancel.Size = new Size(75, 32);
            _btn_Cancel.TabIndex = 3;
            _btn_Cancel.Text = "Cancel";
            _btn_Cancel.UseVisualStyleBackColor = false;
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
            _Page2.Controls.Add(_panel_SteamID);
            _Page2.Controls.Add(_txtbox_Name);
            _Page2.Controls.Add(_lbl_GameorProgram);
            _Page2.Location = new Point(4, 22);
            _Page2.Name = "Page2";
            _Page2.Padding = new Padding(3);
            _Page2.Size = new Size(594, 188);
            _Page2.TabIndex = 0;
            _Page2.Text = "Page2";
            _Page2.UseVisualStyleBackColor = true;
            // 
            // panel_SteamID
            // 
            _panel_SteamID.Controls.Add(_txtbox_SteamID);
            _panel_SteamID.Controls.Add(_lbl_SteamID);
            _panel_SteamID.Controls.Add(_lbl_optional);
            _panel_SteamID.Location = new Point(18, 74);
            _panel_SteamID.Name = "panel_SteamID";
            _panel_SteamID.Size = new Size(490, 60);
            _panel_SteamID.TabIndex = 3;
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
            _Panel2.Controls.Add(_btn_NextPage);
            _Panel2.Controls.Add(_btn_Cancel);
            _Panel2.Dock = DockStyle.Bottom;
            _Panel2.Location = new Point(0, 244);
            _Panel2.Name = "Panel2";
            _Panel2.Size = new Size(590, 49);
            _Panel2.TabIndex = 5;
            // 
            // WikiSubmission
            // 
            AcceptButton = _btn_NextPage;
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(47)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(83)));
            CancelButton = _btn_Cancel;
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
            ((System.ComponentModel.ISupportInitialize)_txtbox_SteamID).EndInit();
            _TabControl1.ResumeLayout(false);
            _Page1.ResumeLayout(false);
            _Page1.PerformLayout();
            _Page2.ResumeLayout(false);
            _Page2.PerformLayout();
            _panel_SteamID.ResumeLayout(false);
            _panel_SteamID.PerformLayout();
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

        private Label _lbl_Title;

        internal Label lbl_Title
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lbl_Title;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lbl_Title != null)
                {
                }

                _lbl_Title = value;
                if (_lbl_Title != null)
                {
                }
            }
        }

        private TextBox _txtbox_Name;

        internal TextBox txtbox_Name
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtbox_Name;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtbox_Name != null)
                {
                }

                _txtbox_Name = value;
                if (_txtbox_Name != null)
                {
                }
            }
        }

        private Label _lbl_GameorProgram;

        internal Label lbl_GameorProgram
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lbl_GameorProgram;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lbl_GameorProgram != null)
                {
                }

                _lbl_GameorProgram = value;
                if (_lbl_GameorProgram != null)
                {
                }
            }
        }

        private Label _lbl_SteamID;

        internal Label lbl_SteamID
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lbl_SteamID;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lbl_SteamID != null)
                {
                }

                _lbl_SteamID = value;
                if (_lbl_SteamID != null)
                {
                }
            }
        }

        private Label _lbl_optional;

        internal Label lbl_optional
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lbl_optional;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lbl_optional != null)
                {
                }

                _lbl_optional = value;
                if (_lbl_optional != null)
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

        private Button _btn_NextPage;

        internal Button btn_NextPage
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btn_NextPage;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btn_NextPage != null)
                {
                    _btn_NextPage.Click -= Btn_NextPage_Click;
                }

                _btn_NextPage = value;
                if (_btn_NextPage != null)
                {
                    _btn_NextPage.Click += Btn_NextPage_Click;
                }
            }
        }

        private Button _btn_Cancel;

        internal Button btn_Cancel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btn_Cancel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btn_Cancel != null)
                {
                    _btn_Cancel.Click -= Btn_Cancel_Click;
                }

                _btn_Cancel = value;
                if (_btn_Cancel != null)
                {
                    _btn_Cancel.Click += Btn_Cancel_Click;
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

        private Panel _panel_SteamID;

        internal Panel panel_SteamID
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _panel_SteamID;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_panel_SteamID != null)
                {
                }

                _panel_SteamID = value;
                if (_panel_SteamID != null)
                {
                }
            }
        }

        private NumericUpDown _txtbox_SteamID;

        internal NumericUpDown txtbox_SteamID
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtbox_SteamID;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtbox_SteamID != null)
                {
                }

                _txtbox_SteamID = value;
                if (_txtbox_SteamID != null)
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