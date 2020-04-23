using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CompactGUI
{
    [DesignerGenerated()]
    public partial class Info : Form
    {
        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

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

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this._Label1 = new System.Windows.Forms.Label();
            this._Label2 = new System.Windows.Forms.Label();
            this._RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this._semVersion = new System.Windows.Forms.Label();
            this._LblCheckUpdates = new System.Windows.Forms.LinkLabel();
            this._TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._checkMinimisetoTray = new System.Windows.Forms.CheckBox();
            this._checkEnableRCMenu = new System.Windows.Forms.CheckBox();
            this._Label3 = new System.Windows.Forms.Label();
            this._Label4 = new System.Windows.Forms.Label();
            this._Panelheader = new System.Windows.Forms.Panel();
            this._BtnMainexit = new System.Windows.Forms.Button();
            this._Label5 = new System.Windows.Forms.Label();
            this._link_Github = new System.Windows.Forms.LinkLabel();
            this._InfoTabControl = new System.Windows.Forms.TabControl();
            this._Tab_Features = new System.Windows.Forms.TabPage();
            this._Label9 = new System.Windows.Forms.Label();
            this._Label8 = new System.Windows.Forms.Label();
            this._btnDefaultNonCompressable = new System.Windows.Forms.Button();
            this._btnSaveNonCompressable = new System.Windows.Forms.Button();
            this._TxtBoxNonCompressable = new System.Windows.Forms.TextBox();
            this._Label7 = new System.Windows.Forms.Label();
            this._checkShowNotifications = new System.Windows.Forms.CheckBox();
            this._checkEnableNonCompressable = new System.Windows.Forms.CheckBox();
            this._Tab_Licenses = new System.Windows.Forms.TabPage();
            this._Tab_Help = new System.Windows.Forms.TabPage();
            this._Label6 = new System.Windows.Forms.Label();
            this._Btnoptions = new System.Windows.Forms.Button();
            this._Panel1 = new System.Windows.Forms.Panel();
            this._Btnhelp = new System.Windows.Forms.Button();
            this._Btnlicenses = new System.Windows.Forms.Button();
            this._Panel2 = new System.Windows.Forms.Panel();
            this._TableLayoutPanel1.SuspendLayout();
            this._Panelheader.SuspendLayout();
            this._InfoTabControl.SuspendLayout();
            this._Tab_Features.SuspendLayout();
            this._Tab_Licenses.SuspendLayout();
            this._Tab_Help.SuspendLayout();
            this._Panel1.SuspendLayout();
            this._Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _Label1
            // 
            this._Label1.AutoSize = true;
            this._Label1.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this._Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this._Label1.Location = new System.Drawing.Point(46, 57);
            this._Label1.Name = "_Label1";
            this._Label1.Size = new System.Drawing.Size(133, 19);
            this._Label1.TabIndex = 0;
            this._Label1.Text = "EXTERNAL LICENSES";
            // 
            // _Label2
            // 
            this._Label2.AutoSize = true;
            this._Label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label2.ForeColor = System.Drawing.Color.Black;
            this._Label2.Location = new System.Drawing.Point(69, 97);
            this._Label2.Name = "_Label2";
            this._Label2.Size = new System.Drawing.Size(87, 17);
            this._Label2.TabIndex = 1;
            this._Label2.Text = "Ookii Dialogs";
            // 
            // _RichTextBox1
            // 
            this._RichTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._RichTextBox1.BackColor = System.Drawing.Color.White;
            this._RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._RichTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._RichTextBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this._RichTextBox1.Location = new System.Drawing.Point(72, 125);
            this._RichTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this._RichTextBox1.Name = "_RichTextBox1";
            this._RichTextBox1.ReadOnly = true;
            this._RichTextBox1.Size = new System.Drawing.Size(586, 206);
            this._RichTextBox1.TabIndex = 2;
            this._RichTextBox1.TabStop = false;
            this._RichTextBox1.Text = resources.GetString("_RichTextBox1.Text");
            // 
            // _semVersion
            // 
            this._semVersion.AutoSize = true;
            this._semVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(66)))), ((int)(((byte)(83)))));
            this._semVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._semVersion.ForeColor = System.Drawing.Color.Gainsboro;
            this._semVersion.Location = new System.Drawing.Point(3, 0);
            this._semVersion.Name = "_semVersion";
            this._semVersion.Size = new System.Drawing.Size(75, 21);
            this._semVersion.TabIndex = 3;
            this._semVersion.Text = "VERSION";
            // 
            // _LblCheckUpdates
            // 
            this._LblCheckUpdates.AutoSize = true;
            this._LblCheckUpdates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(66)))), ((int)(((byte)(83)))));
            this._LblCheckUpdates.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._LblCheckUpdates.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this._LblCheckUpdates.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this._LblCheckUpdates.Location = new System.Drawing.Point(84, 5);
            this._LblCheckUpdates.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this._LblCheckUpdates.Name = "_LblCheckUpdates";
            this._LblCheckUpdates.Size = new System.Drawing.Size(104, 13);
            this._LblCheckUpdates.TabIndex = 4;
            this._LblCheckUpdates.TabStop = true;
            this._LblCheckUpdates.Text = "Check For Updates";
            this._LblCheckUpdates.Visible = false;
            this._LblCheckUpdates.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLinks);
            // 
            // _TableLayoutPanel1
            // 
            this._TableLayoutPanel1.AutoSize = true;
            this._TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._TableLayoutPanel1.ColumnCount = 2;
            this._TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._TableLayoutPanel1.Controls.Add(this._semVersion, 0, 0);
            this._TableLayoutPanel1.Controls.Add(this._LblCheckUpdates, 1, 0);
            this._TableLayoutPanel1.Location = new System.Drawing.Point(147, 32);
            this._TableLayoutPanel1.Name = "_TableLayoutPanel1";
            this._TableLayoutPanel1.RowCount = 1;
            this._TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this._TableLayoutPanel1.Size = new System.Drawing.Size(191, 21);
            this._TableLayoutPanel1.TabIndex = 5;
            // 
            // _checkMinimisetoTray
            // 
            this._checkMinimisetoTray.AutoSize = true;
            this._checkMinimisetoTray.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._checkMinimisetoTray.ForeColor = System.Drawing.Color.DimGray;
            this._checkMinimisetoTray.Location = new System.Drawing.Point(51, 305);
            this._checkMinimisetoTray.Name = "_checkMinimisetoTray";
            this._checkMinimisetoTray.Size = new System.Drawing.Size(158, 19);
            this._checkMinimisetoTray.TabIndex = 2;
            this._checkMinimisetoTray.Text = "Hide to Tray on Minimise";
            this._checkMinimisetoTray.UseVisualStyleBackColor = true;
            this._checkMinimisetoTray.CheckedChanged += new System.EventHandler(this.CheckMinimisetoTray_CheckedChanged);
            // 
            // _checkEnableRCMenu
            // 
            this._checkEnableRCMenu.AutoSize = true;
            this._checkEnableRCMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._checkEnableRCMenu.ForeColor = System.Drawing.Color.DimGray;
            this._checkEnableRCMenu.Location = new System.Drawing.Point(51, 363);
            this._checkEnableRCMenu.Name = "_checkEnableRCMenu";
            this._checkEnableRCMenu.Size = new System.Drawing.Size(202, 19);
            this._checkEnableRCMenu.TabIndex = 2;
            this._checkEnableRCMenu.Text = "Add to Explorer Right-click Menu";
            this._checkEnableRCMenu.UseVisualStyleBackColor = true;
            this._checkEnableRCMenu.Click += new System.EventHandler(this.CheckEnableRCMenu_CheckedChanged);
            // 
            // _Label3
            // 
            this._Label3.AutoSize = true;
            this._Label3.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this._Label3.ForeColor = System.Drawing.Color.Black;
            this._Label3.Location = new System.Drawing.Point(46, 245);
            this._Label3.Name = "_Label3";
            this._Label3.Size = new System.Drawing.Size(66, 19);
            this._Label3.TabIndex = 1;
            this._Label3.Text = "SETTINGS";
            // 
            // _Label4
            // 
            this._Label4.AutoSize = true;
            this._Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(66)))), ((int)(((byte)(83)))));
            this._Label4.Font = new System.Drawing.Font("Segoe UI", 16F);
            this._Label4.ForeColor = System.Drawing.Color.White;
            this._Label4.Location = new System.Drawing.Point(11, 25);
            this._Label4.Name = "_Label4";
            this._Label4.Size = new System.Drawing.Size(136, 30);
            this._Label4.TabIndex = 8;
            this._Label4.Text = "CompactGUI";
            // 
            // _Panelheader
            // 
            this._Panelheader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._Panelheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(66)))), ((int)(((byte)(83)))));
            this._Panelheader.Controls.Add(this._BtnMainexit);
            this._Panelheader.Controls.Add(this._Label4);
            this._Panelheader.Controls.Add(this._TableLayoutPanel1);
            this._Panelheader.Location = new System.Drawing.Point(0, 0);
            this._Panelheader.Name = "_Panelheader";
            this._Panelheader.Size = new System.Drawing.Size(840, 76);
            this._Panelheader.TabIndex = 9;
            this._Panelheader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_header_MouseDown);
            // 
            // _BtnMainexit
            // 
            this._BtnMainexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._BtnMainexit.BackColor = System.Drawing.Color.Transparent;
            this._BtnMainexit.FlatAppearance.BorderSize = 0;
            this._BtnMainexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this._BtnMainexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._BtnMainexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._BtnMainexit.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._BtnMainexit.ForeColor = System.Drawing.Color.White;
            this._BtnMainexit.Location = new System.Drawing.Point(794, 0);
            this._BtnMainexit.Margin = new System.Windows.Forms.Padding(0);
            this._BtnMainexit.Name = "_BtnMainexit";
            this._BtnMainexit.Size = new System.Drawing.Size(45, 30);
            this._BtnMainexit.TabIndex = 16;
            this._BtnMainexit.TabStop = false;
            this._BtnMainexit.Text = "✕";
            this._BtnMainexit.UseVisualStyleBackColor = false;
            this._BtnMainexit.Click += new System.EventHandler(this.Btn_Mainexit_Click);
            // 
            // _Label5
            // 
            this._Label5.AutoSize = true;
            this._Label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this._Label5.ForeColor = System.Drawing.Color.Black;
            this._Label5.Location = new System.Drawing.Point(69, 97);
            this._Label5.Name = "_Label5";
            this._Label5.Size = new System.Drawing.Size(243, 19);
            this._Label5.TabIndex = 6;
            this._Label5.Text = "Help and information can be found on";
            // 
            // _link_Github
            // 
            this._link_Github.AutoSize = true;
            this._link_Github.Font = new System.Drawing.Font("Segoe UI", 10F);
            this._link_Github.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this._link_Github.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this._link_Github.Location = new System.Drawing.Point(69, 121);
            this._link_Github.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this._link_Github.Name = "_link_Github";
            this._link_Github.Size = new System.Drawing.Size(66, 19);
            this._link_Github.TabIndex = 5;
            this._link_Github.TabStop = true;
            this._link_Github.Text = "❯  Github";
            this._link_Github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLinks);
            // 
            // _InfoTabControl
            // 
            this._InfoTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._InfoTabControl.Controls.Add(this._Tab_Features);
            this._InfoTabControl.Controls.Add(this._Tab_Licenses);
            this._InfoTabControl.Controls.Add(this._Tab_Help);
            this._InfoTabControl.Location = new System.Drawing.Point(129, 47);
            this._InfoTabControl.Name = "_InfoTabControl";
            this._InfoTabControl.SelectedIndex = 0;
            this._InfoTabControl.Size = new System.Drawing.Size(714, 512);
            this._InfoTabControl.TabIndex = 10;
            // 
            // _Tab_Features
            // 
            this._Tab_Features.BackColor = System.Drawing.Color.White;
            this._Tab_Features.Controls.Add(this._Label9);
            this._Tab_Features.Controls.Add(this._Label8);
            this._Tab_Features.Controls.Add(this._btnDefaultNonCompressable);
            this._Tab_Features.Controls.Add(this._btnSaveNonCompressable);
            this._Tab_Features.Controls.Add(this._TxtBoxNonCompressable);
            this._Tab_Features.Controls.Add(this._Label7);
            this._Tab_Features.Controls.Add(this._Label3);
            this._Tab_Features.Controls.Add(this._checkShowNotifications);
            this._Tab_Features.Controls.Add(this._checkMinimisetoTray);
            this._Tab_Features.Controls.Add(this._checkEnableNonCompressable);
            this._Tab_Features.Controls.Add(this._checkEnableRCMenu);
            this._Tab_Features.Location = new System.Drawing.Point(4, 22);
            this._Tab_Features.Name = "_Tab_Features";
            this._Tab_Features.Padding = new System.Windows.Forms.Padding(3);
            this._Tab_Features.Size = new System.Drawing.Size(706, 486);
            this._Tab_Features.TabIndex = 0;
            this._Tab_Features.Text = "Features";
            this._Tab_Features.Paint += new System.Windows.Forms.PaintEventHandler(this.Tab_Features_Paint);
            // 
            // _Label9
            // 
            this._Label9.AutoSize = true;
            this._Label9.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this._Label9.ForeColor = System.Drawing.Color.Black;
            this._Label9.Location = new System.Drawing.Point(46, 57);
            this._Label9.Name = "_Label9";
            this._Label9.Size = new System.Drawing.Size(216, 19);
            this._Label9.TabIndex = 6;
            this._Label9.Text = "POORLY COMPRESSED FILETYPES";
            // 
            // _Label8
            // 
            this._Label8.AutoSize = true;
            this._Label8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._Label8.ForeColor = System.Drawing.Color.DimGray;
            this._Label8.Location = new System.Drawing.Point(46, 429);
            this._Label8.Name = "_Label8";
            this._Label8.Size = new System.Drawing.Size(236, 15);
            this._Label8.TabIndex = 5;
            this._Label8.Text = "* Requires a restart of CompactGUI to apply";
            // 
            // _btnDefaultNonCompressable
            // 
            this._btnDefaultNonCompressable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(121)))), ((int)(((byte)(138)))));
            this._btnDefaultNonCompressable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(66)))), ((int)(((byte)(83)))));
            this._btnDefaultNonCompressable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnDefaultNonCompressable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._btnDefaultNonCompressable.ForeColor = System.Drawing.Color.White;
            this._btnDefaultNonCompressable.Location = new System.Drawing.Point(541, 86);
            this._btnDefaultNonCompressable.Name = "_btnDefaultNonCompressable";
            this._btnDefaultNonCompressable.Size = new System.Drawing.Size(75, 30);
            this._btnDefaultNonCompressable.TabIndex = 4;
            this._btnDefaultNonCompressable.Text = "Default";
            this._btnDefaultNonCompressable.UseVisualStyleBackColor = false;
            this._btnDefaultNonCompressable.Click += new System.EventHandler(this.BtnDefaultNonCompressable_Click);
            // 
            // _btnSaveNonCompressable
            // 
            this._btnSaveNonCompressable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(121)))), ((int)(((byte)(138)))));
            this._btnSaveNonCompressable.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(66)))), ((int)(((byte)(83)))));
            this._btnSaveNonCompressable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSaveNonCompressable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._btnSaveNonCompressable.ForeColor = System.Drawing.Color.White;
            this._btnSaveNonCompressable.Location = new System.Drawing.Point(541, 164);
            this._btnSaveNonCompressable.Name = "_btnSaveNonCompressable";
            this._btnSaveNonCompressable.Size = new System.Drawing.Size(75, 30);
            this._btnSaveNonCompressable.TabIndex = 4;
            this._btnSaveNonCompressable.Text = "Save";
            this._btnSaveNonCompressable.UseVisualStyleBackColor = false;
            this._btnSaveNonCompressable.Click += new System.EventHandler(this.BtnSaveNonCompressable_Click);
            // 
            // _TxtBoxNonCompressable
            // 
            this._TxtBoxNonCompressable.AcceptsTab = true;
            this._TxtBoxNonCompressable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TxtBoxNonCompressable.ForeColor = System.Drawing.Color.DimGray;
            this._TxtBoxNonCompressable.Location = new System.Drawing.Point(49, 86);
            this._TxtBoxNonCompressable.Multiline = true;
            this._TxtBoxNonCompressable.Name = "_TxtBoxNonCompressable";
            this._TxtBoxNonCompressable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._TxtBoxNonCompressable.Size = new System.Drawing.Size(455, 108);
            this._TxtBoxNonCompressable.TabIndex = 3;
            // 
            // _Label7
            // 
            this._Label7.Location = new System.Drawing.Point(0, 0);
            this._Label7.Name = "_Label7";
            this._Label7.Size = new System.Drawing.Size(100, 23);
            this._Label7.TabIndex = 7;
            // 
            // _checkShowNotifications
            // 
            this._checkShowNotifications.AutoSize = true;
            this._checkShowNotifications.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._checkShowNotifications.ForeColor = System.Drawing.Color.DimGray;
            this._checkShowNotifications.Location = new System.Drawing.Point(51, 334);
            this._checkShowNotifications.Name = "_checkShowNotifications";
            this._checkShowNotifications.Size = new System.Drawing.Size(215, 19);
            this._checkShowNotifications.TabIndex = 2;
            this._checkShowNotifications.Text = "Show Notification when Completed";
            this._checkShowNotifications.UseVisualStyleBackColor = true;
            this._checkShowNotifications.CheckedChanged += new System.EventHandler(this.CheckShowNotifications_CheckedChanged);
            // 
            // _checkEnableNonCompressable
            // 
            this._checkEnableNonCompressable.AutoSize = true;
            this._checkEnableNonCompressable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._checkEnableNonCompressable.ForeColor = System.Drawing.Color.DimGray;
            this._checkEnableNonCompressable.Location = new System.Drawing.Point(51, 276);
            this._checkEnableNonCompressable.Name = "_checkEnableNonCompressable";
            this._checkEnableNonCompressable.Size = new System.Drawing.Size(231, 19);
            this._checkEnableNonCompressable.TabIndex = 2;
            this._checkEnableNonCompressable.Text = "Skip Files that are Poorly Compressed *";
            this._checkEnableNonCompressable.UseVisualStyleBackColor = true;
            this._checkEnableNonCompressable.CheckedChanged += new System.EventHandler(this.CheckEnableNonCompressable_CheckedChanged);
            // 
            // _Tab_Licenses
            // 
            this._Tab_Licenses.BackColor = System.Drawing.Color.White;
            this._Tab_Licenses.Controls.Add(this._RichTextBox1);
            this._Tab_Licenses.Controls.Add(this._Label1);
            this._Tab_Licenses.Controls.Add(this._Label2);
            this._Tab_Licenses.Location = new System.Drawing.Point(4, 22);
            this._Tab_Licenses.Name = "_Tab_Licenses";
            this._Tab_Licenses.Padding = new System.Windows.Forms.Padding(3);
            this._Tab_Licenses.Size = new System.Drawing.Size(706, 486);
            this._Tab_Licenses.TabIndex = 1;
            this._Tab_Licenses.Text = "Licenses";
            // 
            // _Tab_Help
            // 
            this._Tab_Help.Controls.Add(this._Label6);
            this._Tab_Help.Controls.Add(this._link_Github);
            this._Tab_Help.Controls.Add(this._Label5);
            this._Tab_Help.Location = new System.Drawing.Point(4, 22);
            this._Tab_Help.Name = "_Tab_Help";
            this._Tab_Help.Padding = new System.Windows.Forms.Padding(3);
            this._Tab_Help.Size = new System.Drawing.Size(706, 486);
            this._Tab_Help.TabIndex = 2;
            this._Tab_Help.Text = "Help";
            this._Tab_Help.UseVisualStyleBackColor = true;
            // 
            // _Label6
            // 
            this._Label6.AutoSize = true;
            this._Label6.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this._Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this._Label6.Location = new System.Drawing.Point(46, 57);
            this._Label6.Name = "_Label6";
            this._Label6.Size = new System.Drawing.Size(37, 19);
            this._Label6.TabIndex = 1;
            this._Label6.Text = "Help";
            // 
            // _Btnoptions
            // 
            this._Btnoptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._Btnoptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(121)))), ((int)(((byte)(138)))));
            this._Btnoptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._Btnoptions.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._Btnoptions.FlatAppearance.BorderSize = 0;
            this._Btnoptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(121)))), ((int)(((byte)(138)))));
            this._Btnoptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(121)))), ((int)(((byte)(138)))));
            this._Btnoptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Btnoptions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this._Btnoptions.ForeColor = System.Drawing.Color.White;
            this._Btnoptions.Location = new System.Drawing.Point(0, 0);
            this._Btnoptions.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this._Btnoptions.Name = "_Btnoptions";
            this._Btnoptions.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this._Btnoptions.Size = new System.Drawing.Size(145, 39);
            this._Btnoptions.TabIndex = 24;
            this._Btnoptions.Text = "Options";
            this._Btnoptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._Btnoptions.UseVisualStyleBackColor = false;
            this._Btnoptions.Click += new System.EventHandler(this.Btn_options_Click);
            this._Btnoptions.Paint += new System.Windows.Forms.PaintEventHandler(Btn_Paint);
            // 
            // _Panel1
            // 
            this._Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this._Panel1.Controls.Add(this._Btnhelp);
            this._Panel1.Controls.Add(this._Btnlicenses);
            this._Panel1.Controls.Add(this._Btnoptions);
            this._Panel1.Location = new System.Drawing.Point(0, 75);
            this._Panel1.Name = "_Panel1";
            this._Panel1.Size = new System.Drawing.Size(143, 521);
            this._Panel1.TabIndex = 11;
            // 
            // _Btnhelp
            // 
            this._Btnhelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._Btnhelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this._Btnhelp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._Btnhelp.FlatAppearance.BorderSize = 0;
            this._Btnhelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(121)))), ((int)(((byte)(138)))));
            this._Btnhelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(121)))), ((int)(((byte)(138)))));
            this._Btnhelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Btnhelp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this._Btnhelp.ForeColor = System.Drawing.Color.White;
            this._Btnhelp.Location = new System.Drawing.Point(0, 80);
            this._Btnhelp.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this._Btnhelp.Name = "_Btnhelp";
            this._Btnhelp.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this._Btnhelp.Size = new System.Drawing.Size(145, 39);
            this._Btnhelp.TabIndex = 24;
            this._Btnhelp.Text = "Help";
            this._Btnhelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._Btnhelp.UseVisualStyleBackColor = false;
            this._Btnhelp.Click += new System.EventHandler(this.Btn_options_Click);
            this._Btnhelp.Paint += new System.Windows.Forms.PaintEventHandler(Btn_Paint);
            // 
            // _Btnlicenses
            // 
            this._Btnlicenses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._Btnlicenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this._Btnlicenses.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this._Btnlicenses.FlatAppearance.BorderSize = 0;
            this._Btnlicenses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(121)))), ((int)(((byte)(138)))));
            this._Btnlicenses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(121)))), ((int)(((byte)(138)))));
            this._Btnlicenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._Btnlicenses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this._Btnlicenses.ForeColor = System.Drawing.Color.White;
            this._Btnlicenses.Location = new System.Drawing.Point(0, 40);
            this._Btnlicenses.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this._Btnlicenses.Name = "_Btnlicenses";
            this._Btnlicenses.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this._Btnlicenses.Size = new System.Drawing.Size(145, 39);
            this._Btnlicenses.TabIndex = 24;
            this._Btnlicenses.Text = "External Licenses";
            this._Btnlicenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._Btnlicenses.UseVisualStyleBackColor = false;
            this._Btnlicenses.Click += new System.EventHandler(this.Btn_options_Click);
            this._Btnlicenses.Paint += new System.Windows.Forms.PaintEventHandler(Btn_Paint);
            // 
            // _Panel2
            // 
            this._Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._Panel2.Controls.Add(this._Panelheader);
            this._Panel2.Controls.Add(this._Panel1);
            this._Panel2.Controls.Add(this._InfoTabControl);
            this._Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this._Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Panel2.Location = new System.Drawing.Point(0, 0);
            this._Panel2.Name = "_Panel2";
            this._Panel2.Size = new System.Drawing.Size(841, 539);
            this._Panel2.TabIndex = 12;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(841, 539);
            this.Controls.Add(this._Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            this._TableLayoutPanel1.ResumeLayout(false);
            this._TableLayoutPanel1.PerformLayout();
            this._Panelheader.ResumeLayout(false);
            this._Panelheader.PerformLayout();
            this._InfoTabControl.ResumeLayout(false);
            this._Tab_Features.ResumeLayout(false);
            this._Tab_Features.PerformLayout();
            this._Tab_Licenses.ResumeLayout(false);
            this._Tab_Licenses.PerformLayout();
            this._Tab_Help.ResumeLayout(false);
            this._Tab_Help.PerformLayout();
            this._Panel1.ResumeLayout(false);
            this._Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

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

        private RichTextBox _RichTextBox1;

        internal RichTextBox RichTextBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RichTextBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RichTextBox1 != null)
                {
                }

                _RichTextBox1 = value;
                if (_RichTextBox1 != null)
                {
                }
            }
        }

        private Label _semVersion;

        internal Label semVersion
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _semVersion;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_semVersion != null)
                {
                }

                _semVersion = value;
                if (_semVersion != null)
                {
                }
            }
        }

        private LinkLabel _LblCheckUpdates;

        internal LinkLabel LblCheckUpdates
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LblCheckUpdates;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LblCheckUpdates != null)
                {
                    _LblCheckUpdates.LinkClicked -= GithubLinks;
                }

                _LblCheckUpdates = value;
                if (_LblCheckUpdates != null)
                {
                    _LblCheckUpdates.LinkClicked += GithubLinks;
                }
            }
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

        private CheckBox _checkEnableRCMenu;

        internal CheckBox checkEnableRCMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _checkEnableRCMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_checkEnableRCMenu != null)
                {
                    _checkEnableRCMenu.Click -= CheckEnableRCMenu_CheckedChanged;
                }

                _checkEnableRCMenu = value;
                if (_checkEnableRCMenu != null)
                {
                    _checkEnableRCMenu.Click += CheckEnableRCMenu_CheckedChanged;
                }
            }
        }

        private Label _Label3;

        internal Label Label3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label3 != null)
                {
                }

                _Label3 = value;
                if (_Label3 != null)
                {
                }
            }
        }

        private Label _Label4;

        internal Label Label4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label4 != null)
                {
                }

                _Label4 = value;
                if (_Label4 != null)
                {
                }
            }
        }

        private Panel _Panelheader;

        internal Panel Panelheader
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panelheader;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panelheader != null)
                {
                    _Panelheader.MouseDown -= Panel_header_MouseDown;
                }

                _Panelheader = value;
                if (_Panelheader != null)
                {
                    _Panelheader.MouseDown += Panel_header_MouseDown;
                }
            }
        }

        private Label _Label5;

        internal Label Label5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label5 != null)
                {
                }

                _Label5 = value;
                if (_Label5 != null)
                {
                }
            }
        }

        private LinkLabel _link_Github;

        internal LinkLabel link_Github
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _link_Github;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_link_Github != null)
                {
                    _link_Github.LinkClicked -= GithubLinks;
                }

                _link_Github = value;
                if (_link_Github != null)
                {
                    _link_Github.LinkClicked += GithubLinks;
                }
            }
        }

        private CheckBox _checkMinimisetoTray;

        internal CheckBox checkMinimisetoTray
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _checkMinimisetoTray;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_checkMinimisetoTray != null)
                {
                    _checkMinimisetoTray.CheckedChanged -= CheckMinimisetoTray_CheckedChanged;
                }

                _checkMinimisetoTray = value;
                if (_checkMinimisetoTray != null)
                {
                    _checkMinimisetoTray.CheckedChanged += CheckMinimisetoTray_CheckedChanged;
                }
            }
        }

        private TabControl _InfoTabControl;

        internal TabControl InfoTabControl
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _InfoTabControl;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_InfoTabControl != null)
                {
                }

                _InfoTabControl = value;
                if (_InfoTabControl != null)
                {
                }
            }
        }

        private TabPage _Tab_Features;

        internal TabPage Tab_Features
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Tab_Features;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Tab_Features != null)
                {
                    _Tab_Features.Paint -= Tab_Features_Paint;
                }

                _Tab_Features = value;
                if (_Tab_Features != null)
                {
                    _Tab_Features.Paint += Tab_Features_Paint;
                }
            }
        }

        private TabPage _Tab_Licenses;

        internal TabPage Tab_Licenses
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Tab_Licenses;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Tab_Licenses != null)
                {
                }

                _Tab_Licenses = value;
                if (_Tab_Licenses != null)
                {
                }
            }
        }

        private TabPage _Tab_Help;

        internal TabPage Tab_Help
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Tab_Help;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Tab_Help != null)
                {
                }

                _Tab_Help = value;
                if (_Tab_Help != null)
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

        private Button _Btnoptions;

        internal Button Btnoptions
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Btnoptions;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Btnoptions != null)
                {
                    _Btnoptions.Click -= Btn_options_Click;
                    _Btnoptions.Paint -= Btn_Paint;
                }

                _Btnoptions = value;
                if (_Btnoptions != null)
                {
                    _Btnoptions.Click += Btn_options_Click;
                    _Btnoptions.Paint += Btn_Paint;
                }
            }
        }

        private Button _Btnhelp;

        internal Button Btnhelp
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Btnhelp;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Btnhelp != null)
                {
                    _Btnhelp.Click -= Btn_options_Click;
                    _Btnhelp.Paint -= Btn_Paint;
                }

                _Btnhelp = value;
                if (_Btnhelp != null)
                {
                    _Btnhelp.Click += Btn_options_Click;
                    _Btnhelp.Paint += Btn_Paint;
                }
            }
        }

        private Button _Btnlicenses;

        internal Button Btnlicenses
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Btnlicenses;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Btnlicenses != null)
                {
                    _Btnlicenses.Click -= Btn_options_Click;
                    _Btnlicenses.Paint -= Btn_Paint;
                }

                _Btnlicenses = value;
                if (_Btnlicenses != null)
                {
                    _Btnlicenses.Click += Btn_options_Click;
                    _Btnlicenses.Paint += Btn_Paint;
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

        private Button _BtnMainexit;

        internal Button BtnMainexit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtnMainexit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnMainexit != null)
                {
                    _BtnMainexit.Click -= Btn_Mainexit_Click;
                }

                _BtnMainexit = value;
                if (_BtnMainexit != null)
                {
                    _BtnMainexit.Click += Btn_Mainexit_Click;
                }
            }
        }

        private CheckBox _checkShowNotifications;

        internal CheckBox checkShowNotifications
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _checkShowNotifications;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_checkShowNotifications != null)
                {
                    _checkShowNotifications.CheckedChanged -= CheckShowNotifications_CheckedChanged;
                }

                _checkShowNotifications = value;
                if (_checkShowNotifications != null)
                {
                    _checkShowNotifications.CheckedChanged += CheckShowNotifications_CheckedChanged;
                }
            }
        }

        private Label _Label7;

        internal Label Label7
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label7;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label7 != null)
                {
                }

                _Label7 = value;
                if (_Label7 != null)
                {
                }
            }
        }

        private TextBox _TxtBoxNonCompressable;

        internal TextBox TxtBoxNonCompressable
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TxtBoxNonCompressable;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TxtBoxNonCompressable != null)
                {
                }

                _TxtBoxNonCompressable = value;
                if (_TxtBoxNonCompressable != null)
                {
                }
            }
        }

        private CheckBox _checkEnableNonCompressable;

        internal CheckBox checkEnableNonCompressable
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _checkEnableNonCompressable;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_checkEnableNonCompressable != null)
                {
                    _checkEnableNonCompressable.CheckedChanged -= CheckEnableNonCompressable_CheckedChanged;
                }

                _checkEnableNonCompressable = value;
                if (_checkEnableNonCompressable != null)
                {
                    _checkEnableNonCompressable.CheckedChanged += CheckEnableNonCompressable_CheckedChanged;
                }
            }
        }

        private Button _btnDefaultNonCompressable;

        internal Button btnDefaultNonCompressable
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnDefaultNonCompressable;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnDefaultNonCompressable != null)
                {
                    _btnDefaultNonCompressable.Click -= BtnDefaultNonCompressable_Click;
                }

                _btnDefaultNonCompressable = value;
                if (_btnDefaultNonCompressable != null)
                {
                    _btnDefaultNonCompressable.Click += BtnDefaultNonCompressable_Click;
                }
            }
        }

        private Button _btnSaveNonCompressable;

        internal Button btnSaveNonCompressable
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSaveNonCompressable;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSaveNonCompressable != null)
                {
                    _btnSaveNonCompressable.Click -= BtnSaveNonCompressable_Click;
                }

                _btnSaveNonCompressable = value;
                if (_btnSaveNonCompressable != null)
                {
                    _btnSaveNonCompressable.Click += BtnSaveNonCompressable_Click;
                }
            }
        }

        private Label _Label8;

        internal Label Label8
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label8;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label8 != null)
                {
                }

                _Label8 = value;
                if (_Label8 != null)
                {
                }
            }
        }

        private Label _Label9;

        internal Label Label9
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label9;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label9 != null)
                {
                }

                _Label9 = value;
                if (_Label9 != null)
                {
                }
            }
        }

        public IContainer Components { get => components; set => components = value; }
    }
}