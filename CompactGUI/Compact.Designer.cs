using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace CompactGUI
{
    [DesignerGenerated()]
    public partial class Compact : Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compact));
            this._FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this._OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this._topbar_title = new System.Windows.Forms.Label();
            this._PaneltopBar = new System.Windows.Forms.Panel();
            this._showinfopopup = new System.Windows.Forms.Label();
            this._updateBanner = new System.Windows.Forms.Panel();
            this._dlUpdateLink = new System.Windows.Forms.LinkLabel();
            this._btnAnalyze = new System.Windows.Forms.Button();
            this._topbar_dirchooserContainer = new System.Windows.Forms.Panel();
            this._dirChooser = new System.Windows.Forms.LinkLabel();
            this._BtnMainmin = new System.Windows.Forms.Button();
            this._BtnMainmax = new System.Windows.Forms.Button();
            this._BtnMainexit = new System.Windows.Forms.Button();
            this._topbar_icon = new System.Windows.Forms.PictureBox();
            this._progressTimer = new System.Windows.Forms.Timer(this.components);
            this._seecompest = new System.Windows.Forms.Label();
            this._ToolTipFilesCompressed = new System.Windows.Forms.ToolTip(this.components);
            this._help_resultsFilesCompressed = new System.Windows.Forms.Label();
            this._sb_lblGameIssues = new System.Windows.Forms.Label();
            this._compressX4 = new System.Windows.Forms.RadioButton();
            this._compressLZX = new System.Windows.Forms.RadioButton();
            this._compressX8 = new System.Windows.Forms.RadioButton();
            this._compressX16 = new System.Windows.Forms.RadioButton();
            this._checkForceCompression = new System.Windows.Forms.CheckBox();
            this._checkHiddenFiles = new System.Windows.Forms.CheckBox();
            this._checkRecursiveScan = new System.Windows.Forms.CheckBox();
            this._PanelMainWindow = new System.Windows.Forms.Panel();
            this._sb_Panel = new System.Windows.Forms.Panel();
            this._TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._sb_ResultsPanel = new System.Windows.Forms.Panel();
            this._Label4 = new System.Windows.Forms.Label();
            this._Label3 = new System.Windows.Forms.Label();
            this._sb_compressedSizeVisual = new System.Windows.Forms.Panel();
            this._Panel6 = new System.Windows.Forms.Panel();
            this._sb_AnalysisPanel = new System.Windows.Forms.Panel();
            this._sb_progresslabel = new System.Windows.Forms.Label();
            this._sb_progressbar = new System.Windows.Forms.Panel();
            this._sb_progresspercent = new System.Windows.Forms.Label();
            this._wkPostSizeUnit = new System.Windows.Forms.Label();
            this._wkPostSizeVal = new System.Windows.Forms.Label();
            this._wkPreSizeUnit = new System.Windows.Forms.Label();
            this._TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._Label19 = new System.Windows.Forms.Label();
            this._sb_labelCompressed = new System.Windows.Forms.Label();
            this._sb_FolderName = new System.Windows.Forms.Label();
            this._vis_dropshadowmain2 = new System.Windows.Forms.Panel();
            this._wkPreSizeVal = new System.Windows.Forms.Label();
            this._btnCompress = new System.Windows.Forms.Button();
            this._btnUncompress = new System.Windows.Forms.Button();
            this._vis_dropshadowMain = new System.Windows.Forms.Panel();
            this._TabControl1 = new System.Windows.Forms.TabControl();
            this._InputPage = new System.Windows.Forms.TabPage();
            this._Panel1 = new System.Windows.Forms.Panel();
            this._Label1 = new System.Windows.Forms.Label();
            this._SelectedFiles = new System.Windows.Forms.ListBox();
            this._FlowPanel_CompressionOptions = new System.Windows.Forms.FlowLayoutPanel();
            this._Panel4 = new System.Windows.Forms.Panel();
            this._Label2 = new System.Windows.Forms.Label();
            this._Panel3 = new System.Windows.Forms.Panel();
            this._comboChooseShutdown = new System.Windows.Forms.ComboBox();
            this._checkShutdownOnCompletion = new System.Windows.Forms.CheckBox();
            this._Label8 = new System.Windows.Forms.Label();
            this._ProgressPage = new System.Windows.Forms.TabPage();
            this._TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this._CompResultsPanel = new System.Windows.Forms.Panel();
            this._results_arc = new CompactGUI.GraphicsPanel();
            this._labelFilesCompressed = new System.Windows.Forms.Label();
            this._dirChosenLabel = new System.Windows.Forms.Label();
            this._TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._compressedSizeVisual = new System.Windows.Forms.Panel();
            this._compressedSizeLabel = new System.Windows.Forms.Label();
            this._Panel5 = new System.Windows.Forms.Panel();
            this._origSizeLabel = new System.Windows.Forms.Label();
            this._Label9 = new System.Windows.Forms.Label();
            this._Label11 = new System.Windows.Forms.Label();
            this._Panelconsole = new System.Windows.Forms.Panel();
            this._saveconlog = new System.Windows.Forms.Button();
            this._conOut = new System.Windows.Forms.ListBox();
            this._returnArrow = new System.Windows.Forms.Label();
            this._submitToWiki = new System.Windows.Forms.Label();
            this._spaceSavedLabel = new System.Windows.Forms.Label();
            this._TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this._TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._Tray_ShowMain = new System.Windows.Forms.ToolStripMenuItem();
            this._PaneltopBar.SuspendLayout();
            this._updateBanner.SuspendLayout();
            this._topbar_dirchooserContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._topbar_icon)).BeginInit();
            this._PanelMainWindow.SuspendLayout();
            this._sb_Panel.SuspendLayout();
            this._TableLayoutPanel2.SuspendLayout();
            this._sb_ResultsPanel.SuspendLayout();
            this._sb_AnalysisPanel.SuspendLayout();
            this._TableLayoutPanel3.SuspendLayout();
            this._TabControl1.SuspendLayout();
            this._InputPage.SuspendLayout();
            this._Panel1.SuspendLayout();
            this._FlowPanel_CompressionOptions.SuspendLayout();
            this._Panel4.SuspendLayout();
            this._Panel3.SuspendLayout();
            this._ProgressPage.SuspendLayout();
            this._TableLayoutPanel4.SuspendLayout();
            this._CompResultsPanel.SuspendLayout();
            this._compressedSizeVisual.SuspendLayout();
            this._Panel5.SuspendLayout();
            this._Panelconsole.SuspendLayout();
            this._TrayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _OpenFileDialog1
            // 
            this._OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // _topbar_title
            // 
            this._topbar_title.AutoSize = true;
            this._topbar_title.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F);
            this._topbar_title.ForeColor = System.Drawing.Color.White;
            this._topbar_title.Location = new System.Drawing.Point(39, 20);
            this._topbar_title.Name = "_topbar_title";
            this._topbar_title.Size = new System.Drawing.Size(136, 30);
            this._topbar_title.TabIndex = 13;
            this._topbar_title.Text = "CompactGUI²";
            // 
            // _PaneltopBar
            // 
            this._PaneltopBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._PaneltopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(66)))), ((int)(((byte)(83)))));
            this._PaneltopBar.Controls.Add(this._showinfopopup);
            this._PaneltopBar.Controls.Add(this._updateBanner);
            this._PaneltopBar.Controls.Add(this._btnAnalyze);
            this._PaneltopBar.Controls.Add(this._topbar_dirchooserContainer);
            this._PaneltopBar.Controls.Add(this._BtnMainmin);
            this._PaneltopBar.Controls.Add(this._BtnMainmax);
            this._PaneltopBar.Controls.Add(this._BtnMainexit);
            this._PaneltopBar.Controls.Add(this._topbar_icon);
            this._PaneltopBar.Controls.Add(this._topbar_title);
            this._PaneltopBar.Location = new System.Drawing.Point(0, 0);
            this._PaneltopBar.Name = "_PaneltopBar";
            this._PaneltopBar.Size = new System.Drawing.Size(1000, 135);
            this._PaneltopBar.TabIndex = 14;
            this._PaneltopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_topBar_MouseDown);
            // 
            // _showinfopopup
            // 
            this._showinfopopup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._showinfopopup.AutoSize = true;
            this._showinfopopup.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11F);
            this._showinfopopup.ForeColor = System.Drawing.Color.White;
            this._showinfopopup.Location = new System.Drawing.Point(798, 15);
            this._showinfopopup.Name = "_showinfopopup";
            this._showinfopopup.Size = new System.Drawing.Size(22, 15);
            this._showinfopopup.TabIndex = 14;
            this._showinfopopup.Text = "";
            this._showinfopopup.Click += new System.EventHandler(this.ShowInfoPopup_Click);
            // 
            // _updateBanner
            // 
            this._updateBanner.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._updateBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this._updateBanner.Controls.Add(this._dlUpdateLink);
            this._updateBanner.Location = new System.Drawing.Point(310, 0);
            this._updateBanner.Name = "_updateBanner";
            this._updateBanner.Size = new System.Drawing.Size(380, 19);
            this._updateBanner.TabIndex = 24;
            this._updateBanner.Visible = false;
            this._updateBanner.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateBanner_Paint);
            // 
            // _dlUpdateLink
            // 
            this._dlUpdateLink.BackColor = System.Drawing.Color.Transparent;
            this._dlUpdateLink.Font = new System.Drawing.Font("Segoe UI", 8F);
            this._dlUpdateLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this._dlUpdateLink.LinkColor = System.Drawing.Color.AliceBlue;
            this._dlUpdateLink.Location = new System.Drawing.Point(0, 0);
            this._dlUpdateLink.Margin = new System.Windows.Forms.Padding(0);
            this._dlUpdateLink.Name = "_dlUpdateLink";
            this._dlUpdateLink.Size = new System.Drawing.Size(380, 18);
            this._dlUpdateLink.TabIndex = 1;
            this._dlUpdateLink.TabStop = true;
            this._dlUpdateLink.Text = "Update Available: Click to Download!";
            this._dlUpdateLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._dlUpdateLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DlUpdateLink_LinkClicked);
            // 
            // _btnAnalyze
            // 
            this._btnAnalyze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnAnalyze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(66)))), ((int)(((byte)(83)))));
            this._btnAnalyze.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(121)))), ((int)(((byte)(138)))));
            this._btnAnalyze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(112)))), ((int)(((byte)(138)))));
            this._btnAnalyze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(121)))), ((int)(((byte)(138)))));
            this._btnAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnAnalyze.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAnalyze.ForeColor = System.Drawing.Color.White;
            this._btnAnalyze.Location = new System.Drawing.Point(742, 71);
            this._btnAnalyze.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this._btnAnalyze.Name = "_btnAnalyze";
            this._btnAnalyze.Size = new System.Drawing.Size(165, 39);
            this._btnAnalyze.TabIndex = 23;
            this._btnAnalyze.Text = "Analyse Folder";
            this._btnAnalyze.UseVisualStyleBackColor = false;
            this._btnAnalyze.Visible = false;
            this._btnAnalyze.Click += new System.EventHandler(this.BtnAnalyze_Click);
            // 
            // _topbar_dirchooserContainer
            // 
            this._topbar_dirchooserContainer.AllowDrop = true;
            this._topbar_dirchooserContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._topbar_dirchooserContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(121)))), ((int)(((byte)(138)))));
            this._topbar_dirchooserContainer.Controls.Add(this._dirChooser);
            this._topbar_dirchooserContainer.Location = new System.Drawing.Point(44, 69);
            this._topbar_dirchooserContainer.MinimumSize = new System.Drawing.Size(270, 0);
            this._topbar_dirchooserContainer.Name = "_topbar_dirchooserContainer";
            this._topbar_dirchooserContainer.Size = new System.Drawing.Size(912, 43);
            this._topbar_dirchooserContainer.TabIndex = 15;
            this._topbar_dirchooserContainer.DragDrop += new System.Windows.Forms.DragEventHandler(this.DirChooser_DragDrop);
            this._topbar_dirchooserContainer.DragEnter += new System.Windows.Forms.DragEventHandler(this.DirChooser_DragEnter);
            // 
            // _dirChooser
            // 
            this._dirChooser.ActiveLinkColor = System.Drawing.Color.White;
            this._dirChooser.AllowDrop = true;
            this._dirChooser.AutoEllipsis = true;
            this._dirChooser.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dirChooser.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._dirChooser.ForeColor = System.Drawing.Color.White;
            this._dirChooser.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this._dirChooser.LinkColor = System.Drawing.Color.White;
            this._dirChooser.Location = new System.Drawing.Point(0, 0);
            this._dirChooser.Name = "_dirChooser";
            this._dirChooser.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this._dirChooser.Size = new System.Drawing.Size(912, 43);
            this._dirChooser.TabIndex = 15;
            this._dirChooser.TabStop = true;
            this._dirChooser.Text = "❯   Select Target Folder";
            this._dirChooser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._dirChooser.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this._dirChooser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SelectFolderToCompress);
            this._dirChooser.Click += new System.EventHandler(this.SelectFolderToCompress);
            this._dirChooser.DragDrop += new System.Windows.Forms.DragEventHandler(this.DirChooser_DragDrop);
            this._dirChooser.DragEnter += new System.Windows.Forms.DragEventHandler(this.DirChooser_DragEnter);
            this._dirChooser.MouseEnter += new System.EventHandler(this.DirChooser_MouseEnter);
            this._dirChooser.MouseLeave += new System.EventHandler(this.DirChooser_MouseLeave);
            // 
            // _BtnMainmin
            // 
            this._BtnMainmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._BtnMainmin.BackColor = System.Drawing.Color.Transparent;
            this._BtnMainmin.FlatAppearance.BorderSize = 0;
            this._BtnMainmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._BtnMainmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._BtnMainmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._BtnMainmin.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this._BtnMainmin.ForeColor = System.Drawing.Color.White;
            this._BtnMainmin.Location = new System.Drawing.Point(841, 0);
            this._BtnMainmin.Margin = new System.Windows.Forms.Padding(0);
            this._BtnMainmin.Name = "_BtnMainmin";
            this._BtnMainmin.Size = new System.Drawing.Size(45, 42);
            this._BtnMainmin.TabIndex = 17;
            this._BtnMainmin.TabStop = false;
            this._BtnMainmin.Text = "—";
            this._BtnMainmin.UseVisualStyleBackColor = false;
            this._BtnMainmin.Click += new System.EventHandler(this.Btn_Mainmin_Click);
            // 
            // _BtnMainmax
            // 
            this._BtnMainmax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._BtnMainmax.BackColor = System.Drawing.Color.Transparent;
            this._BtnMainmax.FlatAppearance.BorderSize = 0;
            this._BtnMainmax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._BtnMainmax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._BtnMainmax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._BtnMainmax.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this._BtnMainmax.ForeColor = System.Drawing.Color.White;
            this._BtnMainmax.Location = new System.Drawing.Point(899, 0);
            this._BtnMainmax.Margin = new System.Windows.Forms.Padding(0);
            this._BtnMainmax.Name = "_BtnMainmax";
            this._BtnMainmax.Size = new System.Drawing.Size(44, 42);
            this._BtnMainmax.TabIndex = 16;
            this._BtnMainmax.TabStop = false;
            this._BtnMainmax.Text = "☐";
            this._BtnMainmax.UseVisualStyleBackColor = false;
            this._BtnMainmax.Click += new System.EventHandler(this.Btn_Mainmax_Click);
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
            this._BtnMainexit.Location = new System.Drawing.Point(943, 0);
            this._BtnMainexit.Margin = new System.Windows.Forms.Padding(0);
            this._BtnMainexit.Name = "_BtnMainexit";
            this._BtnMainexit.Size = new System.Drawing.Size(57, 42);
            this._BtnMainexit.TabIndex = 15;
            this._BtnMainexit.TabStop = false;
            this._BtnMainexit.Text = "✕";
            this._BtnMainexit.UseVisualStyleBackColor = false;
            this._BtnMainexit.Click += new System.EventHandler(this.Btn_Mainexit_Click);
            // 
            // _topbar_icon
            // 
            this._topbar_icon.Image = global::CompactGUI.My.Resources.Resources.iconbright;
            this._topbar_icon.Location = new System.Drawing.Point(11, 25);
            this._topbar_icon.Name = "_topbar_icon";
            this._topbar_icon.Size = new System.Drawing.Size(25, 25);
            this._topbar_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._topbar_icon.TabIndex = 15;
            this._topbar_icon.TabStop = false;
            // 
            // _progressTimer
            // 
            this._progressTimer.Interval = 20;
            // 
            // _seecompest
            // 
            this._seecompest.AutoSize = true;
            this._seecompest.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._seecompest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this._seecompest.Location = new System.Drawing.Point(316, 96);
            this._seecompest.Name = "_seecompest";
            this._seecompest.Size = new System.Drawing.Size(16, 13);
            this._seecompest.TabIndex = 21;
            this._seecompest.Text = "❯ ";
            this._seecompest.Visible = false;
            this._seecompest.MouseLeave += new System.EventHandler(this.HideWikiRes);
            this._seecompest.MouseHover += new System.EventHandler(this.Seecompest_MouseHover);
            // 
            // _ToolTipFilesCompressed
            // 
            this._ToolTipFilesCompressed.AutoPopDelay = 12000;
            this._ToolTipFilesCompressed.BackColor = System.Drawing.Color.White;
            this._ToolTipFilesCompressed.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this._ToolTipFilesCompressed.InitialDelay = 200;
            this._ToolTipFilesCompressed.IsBalloon = true;
            this._ToolTipFilesCompressed.ReshowDelay = 100;
            this._ToolTipFilesCompressed.ShowAlways = true;
            this._ToolTipFilesCompressed.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this._ToolTipFilesCompressed.ToolTipTitle = "Information";
            // 
            // _help_resultsFilesCompressed
            // 
            this._help_resultsFilesCompressed.AutoSize = true;
            this._help_resultsFilesCompressed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._help_resultsFilesCompressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this._help_resultsFilesCompressed.Location = new System.Drawing.Point(480, 168);
            this._help_resultsFilesCompressed.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this._help_resultsFilesCompressed.Name = "_help_resultsFilesCompressed";
            this._help_resultsFilesCompressed.Size = new System.Drawing.Size(22, 17);
            this._help_resultsFilesCompressed.TabIndex = 31;
            this._help_resultsFilesCompressed.Text = "(?)";
            this._ToolTipFilesCompressed.SetToolTip(this._help_resultsFilesCompressed, resources.GetString("_help_resultsFilesCompressed.ToolTip"));
            // 
            // _sb_lblGameIssues
            // 
            this._sb_lblGameIssues.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sb_lblGameIssues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this._sb_lblGameIssues.Location = new System.Drawing.Point(189, 153);
            this._sb_lblGameIssues.Name = "_sb_lblGameIssues";
            this._sb_lblGameIssues.Size = new System.Drawing.Size(132, 20);
            this._sb_lblGameIssues.TabIndex = 23;
            this._sb_lblGameIssues.Text = "! Known Issues";
            this._sb_lblGameIssues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._ToolTipFilesCompressed.SetToolTip(this._sb_lblGameIssues, "This game has issues and compression is not recommended. Click to go to the Wiki " +
        "for details. ");
            this._sb_lblGameIssues.Visible = false;
            this._sb_lblGameIssues.Click += new System.EventHandler(this.Sb_lblKnownIssues_Click);
            // 
            // _compressX4
            // 
            this._compressX4.AutoSize = true;
            this._compressX4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this._compressX4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this._compressX4.Location = new System.Drawing.Point(37, 38);
            this._compressX4.Name = "_compressX4";
            this._compressX4.Size = new System.Drawing.Size(77, 17);
            this._compressX4.TabIndex = 9;
            this._compressX4.Text = "XPRESS 4K";
            this._ToolTipFilesCompressed.SetToolTip(this._compressX4, "Fastest, Low Compression");
            this._compressX4.UseVisualStyleBackColor = true;
            this._compressX4.Click += new System.EventHandler(this.Compress_CheckedChanged);
            // 
            // _compressLZX
            // 
            this._compressLZX.AutoSize = true;
            this._compressLZX.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this._compressLZX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this._compressLZX.Location = new System.Drawing.Point(37, 128);
            this._compressLZX.Name = "_compressLZX";
            this._compressLZX.Size = new System.Drawing.Size(45, 17);
            this._compressLZX.TabIndex = 12;
            this._compressLZX.Text = "LZX ";
            this._ToolTipFilesCompressed.SetToolTip(this._compressLZX, "Slowest, Very High Compression (Not Recommended for Games/Programs)");
            this._compressLZX.UseVisualStyleBackColor = true;
            this._compressLZX.Click += new System.EventHandler(this.Compress_CheckedChanged);
            // 
            // _compressX8
            // 
            this._compressX8.AutoSize = true;
            this._compressX8.Checked = true;
            this._compressX8.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this._compressX8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this._compressX8.Location = new System.Drawing.Point(37, 68);
            this._compressX8.Name = "_compressX8";
            this._compressX8.Size = new System.Drawing.Size(77, 17);
            this._compressX8.TabIndex = 10;
            this._compressX8.TabStop = true;
            this._compressX8.Text = "XPRESS 8K";
            this._ToolTipFilesCompressed.SetToolTip(this._compressX8, "Fast, Medium Compression (Recommended)");
            this._compressX8.UseVisualStyleBackColor = true;
            this._compressX8.Click += new System.EventHandler(this.Compress_CheckedChanged);
            // 
            // _compressX16
            // 
            this._compressX16.AutoSize = true;
            this._compressX16.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this._compressX16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this._compressX16.Location = new System.Drawing.Point(37, 98);
            this._compressX16.Name = "_compressX16";
            this._compressX16.Size = new System.Drawing.Size(83, 17);
            this._compressX16.TabIndex = 11;
            this._compressX16.Text = "XPRESS 16K";
            this._ToolTipFilesCompressed.SetToolTip(this._compressX16, "Slow, High Compression");
            this._compressX16.UseVisualStyleBackColor = true;
            this._compressX16.Click += new System.EventHandler(this.Compress_CheckedChanged);
            // 
            // _checkForceCompression
            // 
            this._checkForceCompression.AutoSize = true;
            this._checkForceCompression.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this._checkForceCompression.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this._checkForceCompression.Location = new System.Drawing.Point(37, 68);
            this._checkForceCompression.Name = "_checkForceCompression";
            this._checkForceCompression.Size = new System.Drawing.Size(133, 17);
            this._checkForceCompression.TabIndex = 7;
            this._checkForceCompression.Text = "Force Action on Files";
            this._ToolTipFilesCompressed.SetToolTip(this._checkForceCompression, resources.GetString("_checkForceCompression.ToolTip"));
            this._checkForceCompression.UseVisualStyleBackColor = true;
            // 
            // _checkHiddenFiles
            // 
            this._checkHiddenFiles.AutoSize = true;
            this._checkHiddenFiles.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this._checkHiddenFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this._checkHiddenFiles.Location = new System.Drawing.Point(37, 98);
            this._checkHiddenFiles.Name = "_checkHiddenFiles";
            this._checkHiddenFiles.Size = new System.Drawing.Size(192, 17);
            this._checkHiddenFiles.TabIndex = 6;
            this._checkHiddenFiles.Text = "Process Hidden and System Files";
            this._ToolTipFilesCompressed.SetToolTip(this._checkHiddenFiles, resources.GetString("_checkHiddenFiles.ToolTip"));
            this._checkHiddenFiles.UseVisualStyleBackColor = true;
            // 
            // _checkRecursiveScan
            // 
            this._checkRecursiveScan.AutoSize = true;
            this._checkRecursiveScan.Checked = true;
            this._checkRecursiveScan.CheckState = System.Windows.Forms.CheckState.Checked;
            this._checkRecursiveScan.Enabled = false;
            this._checkRecursiveScan.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this._checkRecursiveScan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this._checkRecursiveScan.Location = new System.Drawing.Point(37, 38);
            this._checkRecursiveScan.Name = "_checkRecursiveScan";
            this._checkRecursiveScan.Size = new System.Drawing.Size(135, 17);
            this._checkRecursiveScan.TabIndex = 5;
            this._checkRecursiveScan.Text = "Compress Subfolders";
            this._ToolTipFilesCompressed.SetToolTip(this._checkRecursiveScan, "This option is now checked by default and cannot be changed. ");
            this._checkRecursiveScan.UseVisualStyleBackColor = true;
            // 
            // _PanelMainWindow
            // 
            this._PanelMainWindow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._PanelMainWindow.Controls.Add(this._PaneltopBar);
            this._PanelMainWindow.Controls.Add(this._sb_Panel);
            this._PanelMainWindow.Controls.Add(this._vis_dropshadowMain);
            this._PanelMainWindow.Controls.Add(this._TabControl1);
            this._PanelMainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this._PanelMainWindow.Location = new System.Drawing.Point(0, 0);
            this._PanelMainWindow.Name = "_PanelMainWindow";
            this._PanelMainWindow.Size = new System.Drawing.Size(1002, 652);
            this._PanelMainWindow.TabIndex = 31;
            // 
            // _sb_Panel
            // 
            this._sb_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._sb_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this._sb_Panel.Controls.Add(this._TableLayoutPanel2);
            this._sb_Panel.Controls.Add(this._sb_lblGameIssues);
            this._sb_Panel.Controls.Add(this._seecompest);
            this._sb_Panel.Controls.Add(this._wkPostSizeUnit);
            this._sb_Panel.Controls.Add(this._wkPostSizeVal);
            this._sb_Panel.Controls.Add(this._wkPreSizeUnit);
            this._sb_Panel.Controls.Add(this._TableLayoutPanel3);
            this._sb_Panel.Controls.Add(this._sb_FolderName);
            this._sb_Panel.Controls.Add(this._vis_dropshadowmain2);
            this._sb_Panel.Controls.Add(this._wkPreSizeVal);
            this._sb_Panel.Controls.Add(this._btnCompress);
            this._sb_Panel.Controls.Add(this._btnUncompress);
            this._sb_Panel.Location = new System.Drawing.Point(647, 135);
            this._sb_Panel.Margin = new System.Windows.Forms.Padding(0);
            this._sb_Panel.Name = "_sb_Panel";
            this._sb_Panel.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this._sb_Panel.Size = new System.Drawing.Size(353, 515);
            this._sb_Panel.TabIndex = 15;
            this._sb_Panel.Visible = false;
            // 
            // _TableLayoutPanel2
            // 
            this._TableLayoutPanel2.ColumnCount = 1;
            this._TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._TableLayoutPanel2.Controls.Add(this._sb_ResultsPanel, 0, 0);
            this._TableLayoutPanel2.Controls.Add(this._sb_AnalysisPanel, 0, 1);
            this._TableLayoutPanel2.Location = new System.Drawing.Point(7, 173);
            this._TableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this._TableLayoutPanel2.Name = "_TableLayoutPanel2";
            this._TableLayoutPanel2.RowCount = 2;
            this._TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._TableLayoutPanel2.Size = new System.Drawing.Size(342, 251);
            this._TableLayoutPanel2.TabIndex = 23;
            // 
            // _sb_ResultsPanel
            // 
            this._sb_ResultsPanel.Controls.Add(this._Label4);
            this._sb_ResultsPanel.Controls.Add(this._Label3);
            this._sb_ResultsPanel.Controls.Add(this._sb_compressedSizeVisual);
            this._sb_ResultsPanel.Controls.Add(this._Panel6);
            this._sb_ResultsPanel.Location = new System.Drawing.Point(3, 3);
            this._sb_ResultsPanel.Name = "_sb_ResultsPanel";
            this._sb_ResultsPanel.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this._sb_ResultsPanel.Size = new System.Drawing.Size(332, 141);
            this._sb_ResultsPanel.TabIndex = 25;
            this._sb_ResultsPanel.Visible = false;
            this._sb_ResultsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Sb_ResultsPanel_Paint);
            // 
            // _Label4
            // 
            this._Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._Label4.AutoSize = true;
            this._Label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label4.ForeColor = System.Drawing.Color.Silver;
            this._Label4.Location = new System.Drawing.Point(201, 126);
            this._Label4.Name = "_Label4";
            this._Label4.Size = new System.Drawing.Size(93, 13);
            this._Label4.TabIndex = 26;
            this._Label4.Text = "Compressed Size";
            this._Label4.Visible = false;
            // 
            // _Label3
            // 
            this._Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._Label3.AutoSize = true;
            this._Label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label3.ForeColor = System.Drawing.Color.Silver;
            this._Label3.Location = new System.Drawing.Point(50, 126);
            this._Label3.Name = "_Label3";
            this._Label3.Size = new System.Drawing.Size(72, 13);
            this._Label3.TabIndex = 26;
            this._Label3.Text = "Original Size";
            this._Label3.Visible = false;
            // 
            // _sb_compressedSizeVisual
            // 
            this._sb_compressedSizeVisual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this._sb_compressedSizeVisual.Location = new System.Drawing.Point(225, 5);
            this._sb_compressedSizeVisual.Name = "_sb_compressedSizeVisual";
            this._sb_compressedSizeVisual.Size = new System.Drawing.Size(40, 113);
            this._sb_compressedSizeVisual.TabIndex = 0;
            // 
            // _Panel6
            // 
            this._Panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this._Panel6.Location = new System.Drawing.Point(67, 5);
            this._Panel6.Name = "_Panel6";
            this._Panel6.Size = new System.Drawing.Size(40, 113);
            this._Panel6.TabIndex = 0;
            // 
            // _sb_AnalysisPanel
            // 
            this._sb_AnalysisPanel.Controls.Add(this._sb_progresslabel);
            this._sb_AnalysisPanel.Controls.Add(this._sb_progressbar);
            this._sb_AnalysisPanel.Controls.Add(this._sb_progresspercent);
            this._sb_AnalysisPanel.Location = new System.Drawing.Point(3, 150);
            this._sb_AnalysisPanel.Name = "_sb_AnalysisPanel";
            this._sb_AnalysisPanel.Size = new System.Drawing.Size(332, 96);
            this._sb_AnalysisPanel.TabIndex = 24;
            this._sb_AnalysisPanel.Visible = false;
            this._sb_AnalysisPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Sb_AnalysisPanel_Paint);
            // 
            // _sb_progresslabel
            // 
            this._sb_progresslabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sb_progresslabel.ForeColor = System.Drawing.Color.White;
            this._sb_progresslabel.Location = new System.Drawing.Point(19, 32);
            this._sb_progresslabel.Name = "_sb_progresslabel";
            this._sb_progresslabel.Size = new System.Drawing.Size(301, 20);
            this._sb_progresslabel.TabIndex = 11;
            this._sb_progresslabel.Text = "Analysing...";
            this._sb_progresslabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _sb_progressbar
            // 
            this._sb_progressbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this._sb_progressbar.Location = new System.Drawing.Point(19, 55);
            this._sb_progressbar.Name = "_sb_progressbar";
            this._sb_progressbar.Size = new System.Drawing.Size(301, 14);
            this._sb_progressbar.TabIndex = 10;
            // 
            // _sb_progresspercent
            // 
            this._sb_progresspercent.BackColor = System.Drawing.Color.Transparent;
            this._sb_progresspercent.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this._sb_progresspercent.ForeColor = System.Drawing.Color.White;
            this._sb_progresspercent.Location = new System.Drawing.Point(107, 72);
            this._sb_progresspercent.Name = "_sb_progresspercent";
            this._sb_progresspercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._sb_progresspercent.Size = new System.Drawing.Size(122, 14);
            this._sb_progresspercent.TabIndex = 22;
            this._sb_progresspercent.Text = "0%";
            this._sb_progresspercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _wkPostSizeUnit
            // 
            this._wkPostSizeUnit.AutoSize = true;
            this._wkPostSizeUnit.BackColor = System.Drawing.Color.Transparent;
            this._wkPostSizeUnit.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._wkPostSizeUnit.ForeColor = System.Drawing.Color.White;
            this._wkPostSizeUnit.Location = new System.Drawing.Point(273, 128);
            this._wkPostSizeUnit.Name = "_wkPostSizeUnit";
            this._wkPostSizeUnit.Size = new System.Drawing.Size(16, 12);
            this._wkPostSizeUnit.TabIndex = 9;
            this._wkPostSizeUnit.Text = "GB";
            this._wkPostSizeUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _wkPostSizeVal
            // 
            this._wkPostSizeVal.BackColor = System.Drawing.Color.Transparent;
            this._wkPostSizeVal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._wkPostSizeVal.ForeColor = System.Drawing.Color.White;
            this._wkPostSizeVal.Location = new System.Drawing.Point(184, 112);
            this._wkPostSizeVal.Name = "_wkPostSizeVal";
            this._wkPostSizeVal.Size = new System.Drawing.Size(143, 50);
            this._wkPostSizeVal.TabIndex = 6;
            this._wkPostSizeVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _wkPreSizeUnit
            // 
            this._wkPreSizeUnit.AutoSize = true;
            this._wkPreSizeUnit.BackColor = System.Drawing.Color.Transparent;
            this._wkPreSizeUnit.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._wkPreSizeUnit.ForeColor = System.Drawing.Color.White;
            this._wkPreSizeUnit.Location = new System.Drawing.Point(115, 128);
            this._wkPreSizeUnit.Name = "_wkPreSizeUnit";
            this._wkPreSizeUnit.Size = new System.Drawing.Size(16, 12);
            this._wkPreSizeUnit.TabIndex = 8;
            this._wkPreSizeUnit.Text = "GB";
            this._wkPreSizeUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _TableLayoutPanel3
            // 
            this._TableLayoutPanel3.ColumnCount = 3;
            this._TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this._TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this._TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this._TableLayoutPanel3.Controls.Add(this._Label19, 0, 0);
            this._TableLayoutPanel3.Controls.Add(this._sb_labelCompressed, 2, 0);
            this._TableLayoutPanel3.Location = new System.Drawing.Point(23, 92);
            this._TableLayoutPanel3.Name = "_TableLayoutPanel3";
            this._TableLayoutPanel3.RowCount = 1;
            this._TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._TableLayoutPanel3.Size = new System.Drawing.Size(307, 20);
            this._TableLayoutPanel3.TabIndex = 7;
            // 
            // _Label19
            // 
            this._Label19.BackColor = System.Drawing.Color.Transparent;
            this._Label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Label19.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(152)))), ((int)(((byte)(154)))));
            this._Label19.Location = new System.Drawing.Point(0, 0);
            this._Label19.Margin = new System.Windows.Forms.Padding(0);
            this._Label19.Name = "_Label19";
            this._Label19.Size = new System.Drawing.Size(149, 20);
            this._Label19.TabIndex = 8;
            this._Label19.Text = "Uncompressed";
            this._Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _sb_labelCompressed
            // 
            this._sb_labelCompressed.BackColor = System.Drawing.Color.Transparent;
            this._sb_labelCompressed.Dock = System.Windows.Forms.DockStyle.Fill;
            this._sb_labelCompressed.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sb_labelCompressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(152)))), ((int)(((byte)(154)))));
            this._sb_labelCompressed.Location = new System.Drawing.Point(157, 0);
            this._sb_labelCompressed.Margin = new System.Windows.Forms.Padding(0);
            this._sb_labelCompressed.Name = "_sb_labelCompressed";
            this._sb_labelCompressed.Size = new System.Drawing.Size(150, 20);
            this._sb_labelCompressed.TabIndex = 8;
            this._sb_labelCompressed.Text = "Estimated Compressed";
            this._sb_labelCompressed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._sb_labelCompressed.MouseLeave += new System.EventHandler(this.HideWikiRes);
            this._sb_labelCompressed.MouseHover += new System.EventHandler(this.Seecompest_MouseHover);
            // 
            // _sb_FolderName
            // 
            this._sb_FolderName.BackColor = System.Drawing.Color.Transparent;
            this._sb_FolderName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sb_FolderName.ForeColor = System.Drawing.Color.White;
            this._sb_FolderName.Location = new System.Drawing.Point(0, 17);
            this._sb_FolderName.Name = "_sb_FolderName";
            this._sb_FolderName.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this._sb_FolderName.Size = new System.Drawing.Size(354, 60);
            this._sb_FolderName.TabIndex = 6;
            this._sb_FolderName.Text = "Folder Name";
            this._sb_FolderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _vis_dropshadowmain2
            // 
            this._vis_dropshadowmain2.BackColor = System.Drawing.Color.Transparent;
            this._vis_dropshadowmain2.BackgroundImage = global::CompactGUI.My.Resources.Resources.dsmask;
            this._vis_dropshadowmain2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._vis_dropshadowmain2.Location = new System.Drawing.Point(0, 0);
            this._vis_dropshadowmain2.Name = "_vis_dropshadowmain2";
            this._vis_dropshadowmain2.Size = new System.Drawing.Size(353, 6);
            this._vis_dropshadowmain2.TabIndex = 2;
            // 
            // _wkPreSizeVal
            // 
            this._wkPreSizeVal.BackColor = System.Drawing.Color.Transparent;
            this._wkPreSizeVal.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._wkPreSizeVal.ForeColor = System.Drawing.Color.White;
            this._wkPreSizeVal.Location = new System.Drawing.Point(23, 112);
            this._wkPreSizeVal.Name = "_wkPreSizeVal";
            this._wkPreSizeVal.Size = new System.Drawing.Size(149, 50);
            this._wkPreSizeVal.TabIndex = 6;
            this._wkPreSizeVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _btnCompress
            // 
            this._btnCompress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCompress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(66)))), ((int)(((byte)(83)))));
            this._btnCompress.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(121)))), ((int)(((byte)(138)))));
            this._btnCompress.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(112)))), ((int)(((byte)(138)))));
            this._btnCompress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(121)))), ((int)(((byte)(138)))));
            this._btnCompress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnCompress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCompress.ForeColor = System.Drawing.Color.Silver;
            this._btnCompress.Location = new System.Drawing.Point(71, 446);
            this._btnCompress.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this._btnCompress.Name = "_btnCompress";
            this._btnCompress.Size = new System.Drawing.Size(208, 39);
            this._btnCompress.TabIndex = 3;
            this._btnCompress.Text = "Compress Folder";
            this._btnCompress.UseVisualStyleBackColor = false;
            this._btnCompress.EnabledChanged += new System.EventHandler(this.ButtonCompress_EnabledChanged);
            this._btnCompress.Click += new System.EventHandler(this.BtnCompress_Click);
            this._btnCompress.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonCompress_Paint);
            // 
            // _btnUncompress
            // 
            this._btnUncompress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnUncompress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(66)))), ((int)(((byte)(83)))));
            this._btnUncompress.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(121)))), ((int)(((byte)(138)))));
            this._btnUncompress.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(112)))), ((int)(((byte)(138)))));
            this._btnUncompress.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(121)))), ((int)(((byte)(138)))));
            this._btnUncompress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnUncompress.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this._btnUncompress.ForeColor = System.Drawing.Color.White;
            this._btnUncompress.Location = new System.Drawing.Point(71, 446);
            this._btnUncompress.Name = "_btnUncompress";
            this._btnUncompress.Size = new System.Drawing.Size(208, 39);
            this._btnUncompress.TabIndex = 29;
            this._btnUncompress.Text = "Uncompress Folder";
            this._btnUncompress.UseVisualStyleBackColor = false;
            this._btnUncompress.Visible = false;
            this._btnUncompress.Click += new System.EventHandler(this.BtnUncompress_Click);
            // 
            // _vis_dropshadowMain
            // 
            this._vis_dropshadowMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._vis_dropshadowMain.BackColor = System.Drawing.Color.Transparent;
            this._vis_dropshadowMain.BackgroundImage = global::CompactGUI.My.Resources.Resources.dsmask;
            this._vis_dropshadowMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._vis_dropshadowMain.Location = new System.Drawing.Point(0, 135);
            this._vis_dropshadowMain.Name = "_vis_dropshadowMain";
            this._vis_dropshadowMain.Size = new System.Drawing.Size(998, 6);
            this._vis_dropshadowMain.TabIndex = 16;
            // 
            // _TabControl1
            // 
            this._TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._TabControl1.Controls.Add(this._InputPage);
            this._TabControl1.Controls.Add(this._ProgressPage);
            this._TabControl1.Location = new System.Drawing.Point(0, 116);
            this._TabControl1.MinimumSize = new System.Drawing.Size(503, 200);
            this._TabControl1.Name = "_TabControl1";
            this._TabControl1.SelectedIndex = 0;
            this._TabControl1.Size = new System.Drawing.Size(1003, 535);
            this._TabControl1.TabIndex = 30;
            // 
            // _InputPage
            // 
            this._InputPage.BackColor = System.Drawing.Color.White;
            this._InputPage.Controls.Add(this._Panel1);
            this._InputPage.Controls.Add(this._FlowPanel_CompressionOptions);
            this._InputPage.Location = new System.Drawing.Point(4, 22);
            this._InputPage.Name = "_InputPage";
            this._InputPage.Padding = new System.Windows.Forms.Padding(3);
            this._InputPage.Size = new System.Drawing.Size(995, 509);
            this._InputPage.TabIndex = 0;
            this._InputPage.Text = "InputPage";
            // 
            // _Panel1
            // 
            this._Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._Panel1.Controls.Add(this._Label1);
            this._Panel1.Controls.Add(this._SelectedFiles);
            this._Panel1.Location = new System.Drawing.Point(44, 214);
            this._Panel1.Name = "_Panel1";
            this._Panel1.Size = new System.Drawing.Size(574, 287);
            this._Panel1.TabIndex = 24;
            this._Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // _Label1
            // 
            this._Label1.AutoSize = true;
            this._Label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this._Label1.Location = new System.Drawing.Point(15, 35);
            this._Label1.Name = "_Label1";
            this._Label1.Size = new System.Drawing.Size(99, 20);
            this._Label1.TabIndex = 18;
            this._Label1.Text = "Selected Files";
            // 
            // _SelectedFiles
            // 
            this._SelectedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._SelectedFiles.BackColor = System.Drawing.Color.White;
            this._SelectedFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._SelectedFiles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this._SelectedFiles.Font = new System.Drawing.Font("Segoe UI", 10F);
            this._SelectedFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this._SelectedFiles.FormattingEnabled = true;
            this._SelectedFiles.ItemHeight = 25;
            this._SelectedFiles.Location = new System.Drawing.Point(19, 59);
            this._SelectedFiles.Name = "_SelectedFiles";
            this._SelectedFiles.Size = new System.Drawing.Size(555, 200);
            this._SelectedFiles.TabIndex = 23;
            this._SelectedFiles.TabStop = false;
            this._SelectedFiles.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBox1_DrawItem);
            this._SelectedFiles.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.ListBox1_MeasureItem);
            // 
            // _FlowPanel_CompressionOptions
            // 
            this._FlowPanel_CompressionOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._FlowPanel_CompressionOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._FlowPanel_CompressionOptions.Controls.Add(this._Panel4);
            this._FlowPanel_CompressionOptions.Controls.Add(this._Panel3);
            this._FlowPanel_CompressionOptions.Location = new System.Drawing.Point(44, 21);
            this._FlowPanel_CompressionOptions.Name = "_FlowPanel_CompressionOptions";
            this._FlowPanel_CompressionOptions.Size = new System.Drawing.Size(574, 174);
            this._FlowPanel_CompressionOptions.TabIndex = 22;
            // 
            // _Panel4
            // 
            this._Panel4.Controls.Add(this._Label2);
            this._Panel4.Controls.Add(this._compressX4);
            this._Panel4.Controls.Add(this._compressLZX);
            this._Panel4.Controls.Add(this._compressX8);
            this._Panel4.Controls.Add(this._compressX16);
            this._Panel4.Location = new System.Drawing.Point(3, 3);
            this._Panel4.Name = "_Panel4";
            this._Panel4.Size = new System.Drawing.Size(266, 160);
            this._Panel4.TabIndex = 24;
            // 
            // _Label2
            // 
            this._Label2.AutoSize = true;
            this._Label2.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this._Label2.Location = new System.Drawing.Point(12, 7);
            this._Label2.Name = "_Label2";
            this._Label2.Size = new System.Drawing.Size(210, 20);
            this._Label2.TabIndex = 18;
            this._Label2.Text = "Select Compression Algorithm";
            // 
            // _Panel3
            // 
            this._Panel3.Controls.Add(this._comboChooseShutdown);
            this._Panel3.Controls.Add(this._checkShutdownOnCompletion);
            this._Panel3.Controls.Add(this._Label8);
            this._Panel3.Controls.Add(this._checkForceCompression);
            this._Panel3.Controls.Add(this._checkHiddenFiles);
            this._Panel3.Controls.Add(this._checkRecursiveScan);
            this._FlowPanel_CompressionOptions.SetFlowBreak(this._Panel3, true);
            this._Panel3.Location = new System.Drawing.Point(275, 3);
            this._Panel3.Name = "_Panel3";
            this._Panel3.Size = new System.Drawing.Size(290, 160);
            this._Panel3.TabIndex = 23;
            // 
            // _comboChooseShutdown
            // 
            this._comboChooseShutdown.BackColor = System.Drawing.Color.White;
            this._comboChooseShutdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboChooseShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._comboChooseShutdown.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this._comboChooseShutdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this._comboChooseShutdown.FormattingEnabled = true;
            this._comboChooseShutdown.Items.AddRange(new object[] {
            "Shutdown",
            "Restart",
            "Sleep"});
            this._comboChooseShutdown.Location = new System.Drawing.Point(52, 125);
            this._comboChooseShutdown.Margin = new System.Windows.Forms.Padding(0);
            this._comboChooseShutdown.Name = "_comboChooseShutdown";
            this._comboChooseShutdown.Size = new System.Drawing.Size(78, 21);
            this._comboChooseShutdown.TabIndex = 34;
            this._comboChooseShutdown.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            this._comboChooseShutdown.MouseLeave += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // _checkShutdownOnCompletion
            // 
            this._checkShutdownOnCompletion.AutoSize = true;
            this._checkShutdownOnCompletion.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this._checkShutdownOnCompletion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this._checkShutdownOnCompletion.Location = new System.Drawing.Point(37, 128);
            this._checkShutdownOnCompletion.Name = "_checkShutdownOnCompletion";
            this._checkShutdownOnCompletion.Size = new System.Drawing.Size(168, 17);
            this._checkShutdownOnCompletion.TabIndex = 33;
            this._checkShutdownOnCompletion.Text = "                          PC on Finish";
            this._checkShutdownOnCompletion.UseVisualStyleBackColor = true;
            // 
            // _Label8
            // 
            this._Label8.AutoSize = true;
            this._Label8.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this._Label8.Location = new System.Drawing.Point(12, 7);
            this._Label8.Name = "_Label8";
            this._Label8.Size = new System.Drawing.Size(199, 20);
            this._Label8.TabIndex = 18;
            this._Label8.Text = "Select Additional Arguments";
            // 
            // _ProgressPage
            // 
            this._ProgressPage.BackColor = System.Drawing.Color.White;
            this._ProgressPage.Controls.Add(this._TableLayoutPanel4);
            this._ProgressPage.Controls.Add(this._returnArrow);
            this._ProgressPage.Controls.Add(this._submitToWiki);
            this._ProgressPage.Location = new System.Drawing.Point(4, 22);
            this._ProgressPage.Name = "_ProgressPage";
            this._ProgressPage.Padding = new System.Windows.Forms.Padding(3);
            this._ProgressPage.Size = new System.Drawing.Size(995, 509);
            this._ProgressPage.TabIndex = 1;
            this._ProgressPage.Text = "ProgressPage";
            // 
            // _TableLayoutPanel4
            // 
            this._TableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._TableLayoutPanel4.AutoSize = true;
            this._TableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._TableLayoutPanel4.ColumnCount = 1;
            this._TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._TableLayoutPanel4.Controls.Add(this._CompResultsPanel, 0, 0);
            this._TableLayoutPanel4.Controls.Add(this._Panelconsole, 0, 1);
            this._TableLayoutPanel4.Location = new System.Drawing.Point(7, 54);
            this._TableLayoutPanel4.Name = "_TableLayoutPanel4";
            this._TableLayoutPanel4.RowCount = 2;
            this._TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._TableLayoutPanel4.Size = new System.Drawing.Size(630, 447);
            this._TableLayoutPanel4.TabIndex = 34;
            // 
            // _CompResultsPanel
            // 
            this._CompResultsPanel.Controls.Add(this._results_arc);
            this._CompResultsPanel.Controls.Add(this._help_resultsFilesCompressed);
            this._CompResultsPanel.Controls.Add(this._labelFilesCompressed);
            this._CompResultsPanel.Controls.Add(this._dirChosenLabel);
            this._CompResultsPanel.Controls.Add(this._TableLayoutPanel1);
            this._CompResultsPanel.Controls.Add(this._compressedSizeVisual);
            this._CompResultsPanel.Controls.Add(this._Panel5);
            this._CompResultsPanel.Controls.Add(this._Label9);
            this._CompResultsPanel.Controls.Add(this._Label11);
            this._CompResultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._CompResultsPanel.Location = new System.Drawing.Point(3, 3);
            this._CompResultsPanel.Name = "_CompResultsPanel";
            this._CompResultsPanel.Size = new System.Drawing.Size(624, 219);
            this._CompResultsPanel.TabIndex = 31;
            this._CompResultsPanel.Visible = false;
            this._CompResultsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CompResultsPanel_Paint);
            // 
            // _results_arc
            // 
            this._results_arc.Location = new System.Drawing.Point(13, 63);
            this._results_arc.Name = "_results_arc";
            this._results_arc.Size = new System.Drawing.Size(265, 122);
            this._results_arc.TabIndex = 35;
            this._results_arc.Paint += new System.Windows.Forms.PaintEventHandler(this.ResultsArcPaint);
            // 
            // _labelFilesCompressed
            // 
            this._labelFilesCompressed.AutoSize = true;
            this._labelFilesCompressed.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelFilesCompressed.ForeColor = System.Drawing.Color.DimGray;
            this._labelFilesCompressed.Location = new System.Drawing.Point(284, 167);
            this._labelFilesCompressed.Margin = new System.Windows.Forms.Padding(0);
            this._labelFilesCompressed.MaximumSize = new System.Drawing.Size(0, 20);
            this._labelFilesCompressed.MinimumSize = new System.Drawing.Size(150, 20);
            this._labelFilesCompressed.Name = "_labelFilesCompressed";
            this._labelFilesCompressed.Size = new System.Drawing.Size(150, 20);
            this._labelFilesCompressed.TabIndex = 30;
            this._labelFilesCompressed.Text = "n/n Files Compressed";
            // 
            // _dirChosenLabel
            // 
            this._dirChosenLabel.AutoSize = true;
            this._dirChosenLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dirChosenLabel.ForeColor = System.Drawing.Color.DarkGray;
            this._dirChosenLabel.Location = new System.Drawing.Point(290, 196);
            this._dirChosenLabel.Name = "_dirChosenLabel";
            this._dirChosenLabel.Size = new System.Drawing.Size(87, 15);
            this._dirChosenLabel.TabIndex = 32;
            this._dirChosenLabel.Text = "dirchosenLabel";
            this._dirChosenLabel.Visible = false;
            // 
            // _TableLayoutPanel1
            // 
            this._TableLayoutPanel1.AutoSize = true;
            this._TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._TableLayoutPanel1.ColumnCount = 2;
            this._TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._TableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this._TableLayoutPanel1.Location = new System.Drawing.Point(228, 50);
            this._TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this._TableLayoutPanel1.Name = "_TableLayoutPanel1";
            this._TableLayoutPanel1.RowCount = 1;
            this._TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._TableLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this._TableLayoutPanel1.TabIndex = 31;
            // 
            // _compressedSizeVisual
            // 
            this._compressedSizeVisual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(190)))), ((int)(((byte)(123)))));
            this._compressedSizeVisual.Controls.Add(this._compressedSizeLabel);
            this._compressedSizeVisual.Location = new System.Drawing.Point(288, 125);
            this._compressedSizeVisual.Name = "_compressedSizeVisual";
            this._compressedSizeVisual.Size = new System.Drawing.Size(320, 25);
            this._compressedSizeVisual.TabIndex = 29;
            // 
            // _compressedSizeLabel
            // 
            this._compressedSizeLabel.AutoSize = true;
            this._compressedSizeLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this._compressedSizeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this._compressedSizeLabel.Location = new System.Drawing.Point(1, 3);
            this._compressedSizeLabel.Name = "_compressedSizeLabel";
            this._compressedSizeLabel.Size = new System.Drawing.Size(58, 19);
            this._compressedSizeLabel.TabIndex = 27;
            this._compressedSizeLabel.Text = "220 MB";
            // 
            // _Panel5
            // 
            this._Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(127)))), ((int)(((byte)(60)))));
            this._Panel5.Controls.Add(this._origSizeLabel);
            this._Panel5.Location = new System.Drawing.Point(288, 62);
            this._Panel5.Name = "_Panel5";
            this._Panel5.Size = new System.Drawing.Size(320, 25);
            this._Panel5.TabIndex = 28;
            // 
            // _origSizeLabel
            // 
            this._origSizeLabel.AutoSize = true;
            this._origSizeLabel.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this._origSizeLabel.ForeColor = System.Drawing.Color.White;
            this._origSizeLabel.Location = new System.Drawing.Point(1, 3);
            this._origSizeLabel.Name = "_origSizeLabel";
            this._origSizeLabel.Size = new System.Drawing.Size(58, 19);
            this._origSizeLabel.TabIndex = 27;
            this._origSizeLabel.Text = "300 MB";
            // 
            // _Label9
            // 
            this._Label9.AutoSize = true;
            this._Label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(73)))));
            this._Label9.Location = new System.Drawing.Point(284, 34);
            this._Label9.Name = "_Label9";
            this._Label9.Size = new System.Drawing.Size(93, 20);
            this._Label9.TabIndex = 25;
            this._Label9.Text = "Original Size";
            // 
            // _Label11
            // 
            this._Label11.AutoSize = true;
            this._Label11.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this._Label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(58)))), ((int)(((byte)(73)))));
            this._Label11.Location = new System.Drawing.Point(284, 97);
            this._Label11.Name = "_Label11";
            this._Label11.Size = new System.Drawing.Size(125, 20);
            this._Label11.TabIndex = 26;
            this._Label11.Text = "Compressed Size:";
            // 
            // _Panelconsole
            // 
            this._Panelconsole.Controls.Add(this._saveconlog);
            this._Panelconsole.Controls.Add(this._conOut);
            this._Panelconsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Panelconsole.Location = new System.Drawing.Point(3, 228);
            this._Panelconsole.Name = "_Panelconsole";
            this._Panelconsole.Size = new System.Drawing.Size(624, 216);
            this._Panelconsole.TabIndex = 33;
            // 
            // _saveconlog
            // 
            this._saveconlog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._saveconlog.BackColor = System.Drawing.Color.WhiteSmoke;
            this._saveconlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._saveconlog.Location = new System.Drawing.Point(533, 188);
            this._saveconlog.Name = "_saveconlog";
            this._saveconlog.Size = new System.Drawing.Size(75, 23);
            this._saveconlog.TabIndex = 33;
            this._saveconlog.Text = "Save Log";
            this._saveconlog.UseVisualStyleBackColor = false;
            this._saveconlog.Click += new System.EventHandler(this.Saveconlog_Click);
            // 
            // _conOut
            // 
            this._conOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._conOut.BackColor = System.Drawing.Color.White;
            this._conOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._conOut.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._conOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this._conOut.FormattingEnabled = true;
            this._conOut.HorizontalScrollbar = true;
            this._conOut.ItemHeight = 15;
            this._conOut.Location = new System.Drawing.Point(13, 4);
            this._conOut.Name = "_conOut";
            this._conOut.Size = new System.Drawing.Size(595, 165);
            this._conOut.TabIndex = 30;
            // 
            // _returnArrow
            // 
            this._returnArrow.AutoSize = true;
            this._returnArrow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._returnArrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this._returnArrow.Location = new System.Drawing.Point(11, 24);
            this._returnArrow.Name = "_returnArrow";
            this._returnArrow.Size = new System.Drawing.Size(205, 20);
            this._returnArrow.TabIndex = 22;
            this._returnArrow.Text = "❮   Return To Selection Screen";
            this._returnArrow.Visible = false;
            this._returnArrow.Click += new System.EventHandler(this.ReturnArrow_Click);
            // 
            // _submitToWiki
            // 
            this._submitToWiki.AutoSize = true;
            this._submitToWiki.BackColor = System.Drawing.Color.WhiteSmoke;
            this._submitToWiki.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._submitToWiki.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this._submitToWiki.Location = new System.Drawing.Point(439, 19);
            this._submitToWiki.Name = "_submitToWiki";
            this._submitToWiki.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this._submitToWiki.Size = new System.Drawing.Size(179, 30);
            this._submitToWiki.TabIndex = 33;
            this._submitToWiki.Text = "❯  Submit Results to Wiki";
            this._submitToWiki.Visible = false;
            this._submitToWiki.Click += new System.EventHandler(this.SubmitToWiki_Click);
            // 
            // _spaceSavedLabel
            // 
            this._spaceSavedLabel.AutoSize = true;
            this._spaceSavedLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this._spaceSavedLabel.ForeColor = System.Drawing.Color.DimGray;
            this._spaceSavedLabel.Location = new System.Drawing.Point(1042, 298);
            this._spaceSavedLabel.Name = "_spaceSavedLabel";
            this._spaceSavedLabel.Size = new System.Drawing.Size(147, 30);
            this._spaceSavedLabel.TabIndex = 27;
            this._spaceSavedLabel.Text = "700MB Saved";
            // 
            // _TrayIcon
            // 
            this._TrayIcon.ContextMenuStrip = this._TrayMenu;
            this._TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("_TrayIcon.Icon")));
            this._TrayIcon.Text = "CompactGUI";
            this._TrayIcon.Visible = true;
            this._TrayIcon.BalloonTipClicked += new System.EventHandler(this.TrayIcon_BalloonTipClicked);
            this._TrayIcon.DoubleClick += new System.EventHandler(this.TrayIcon_BalloonTipClicked);
            // 
            // _TrayMenu
            // 
            this._TrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._Tray_ShowMain});
            this._TrayMenu.Name = "TrayMenu";
            this._TrayMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this._TrayMenu.ShowImageMargin = false;
            this._TrayMenu.Size = new System.Drawing.Size(79, 26);
            // 
            // _Tray_ShowMain
            // 
            this._Tray_ShowMain.BackColor = System.Drawing.Color.White;
            this._Tray_ShowMain.Name = "_Tray_ShowMain";
            this._Tray_ShowMain.Size = new System.Drawing.Size(78, 22);
            this._Tray_ShowMain.Text = "Show";
            this._Tray_ShowMain.Click += new System.EventHandler(this.TrayIcon_BalloonTipClicked);
            // 
            // Compact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 652);
            this.Controls.Add(this._PanelMainWindow);
            this.Controls.Add(this._spaceSavedLabel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 652);
            this.Name = "Compact";
            this.Text = "CompactGUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyForm_Closing);
            this.Load += new System.EventHandler(this.Compact_Load);
            this._PaneltopBar.ResumeLayout(false);
            this._PaneltopBar.PerformLayout();
            this._updateBanner.ResumeLayout(false);
            this._topbar_dirchooserContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._topbar_icon)).EndInit();
            this._PanelMainWindow.ResumeLayout(false);
            this._sb_Panel.ResumeLayout(false);
            this._sb_Panel.PerformLayout();
            this._TableLayoutPanel2.ResumeLayout(false);
            this._sb_ResultsPanel.ResumeLayout(false);
            this._sb_ResultsPanel.PerformLayout();
            this._sb_AnalysisPanel.ResumeLayout(false);
            this._TableLayoutPanel3.ResumeLayout(false);
            this._TabControl1.ResumeLayout(false);
            this._InputPage.ResumeLayout(false);
            this._Panel1.ResumeLayout(false);
            this._Panel1.PerformLayout();
            this._FlowPanel_CompressionOptions.ResumeLayout(false);
            this._Panel4.ResumeLayout(false);
            this._Panel4.PerformLayout();
            this._Panel3.ResumeLayout(false);
            this._Panel3.PerformLayout();
            this._ProgressPage.ResumeLayout(false);
            this._ProgressPage.PerformLayout();
            this._TableLayoutPanel4.ResumeLayout(false);
            this._CompResultsPanel.ResumeLayout(false);
            this._CompResultsPanel.PerformLayout();
            this._compressedSizeVisual.ResumeLayout(false);
            this._compressedSizeVisual.PerformLayout();
            this._Panel5.ResumeLayout(false);
            this._Panel5.PerformLayout();
            this._Panelconsole.ResumeLayout(false);
            this._TrayMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private FolderBrowserDialog _FolderBrowserDialog1;

        internal FolderBrowserDialog FolderBrowserDialog1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _FolderBrowserDialog1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_FolderBrowserDialog1 != null)
                {
                }

                _FolderBrowserDialog1 = value;
                if (_FolderBrowserDialog1 != null)
                {
                }
            }
        }

        private OpenFileDialog _OpenFileDialog1;

        internal OpenFileDialog OpenFileDialog1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _OpenFileDialog1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_OpenFileDialog1 != null)
                {
                }

                _OpenFileDialog1 = value;
                if (_OpenFileDialog1 != null)
                {
                }
            }
        }

        private Label _topbar_title;

        internal Label topbar_title
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _topbar_title;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_topbar_title != null)
                {
                }

                _topbar_title = value;
                if (_topbar_title != null)
                {
                }
            }
        }

        private Panel _PaneltopBar;

        internal Panel PaneltopBar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PaneltopBar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PaneltopBar != null)
                {
                    _PaneltopBar.MouseDown -= Panel_topBar_MouseDown;
                }

                _PaneltopBar = value;
                if (_PaneltopBar != null)
                {
                    _PaneltopBar.MouseDown += Panel_topBar_MouseDown;
                }
            }
        }

        private LinkLabel _dirChooser;

        internal LinkLabel dirChooser
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dirChooser;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dirChooser != null)
                {
                    _dirChooser.LinkClicked -= SelectFolderToCompress;
                    _dirChooser.Click -= SelectFolderToCompress;
                    _dirChooser.MouseEnter -= DirChooser_MouseEnter;
                    _dirChooser.MouseLeave -= DirChooser_MouseLeave;
                    _dirChooser.DragDrop -= DirChooser_DragDrop;
                    _dirChooser.DragEnter -= DirChooser_DragEnter;
                }

                _dirChooser = value;
                if (_dirChooser != null)
                {
                    _dirChooser.LinkClicked += SelectFolderToCompress;
                    _dirChooser.Click += SelectFolderToCompress;
                    _dirChooser.MouseEnter += DirChooser_MouseEnter;
                    _dirChooser.MouseLeave += DirChooser_MouseLeave;
                    _dirChooser.DragDrop += DirChooser_DragDrop;
                    _dirChooser.DragEnter += DirChooser_DragEnter;
                }
            }
        }

        private Timer _progressTimer;

        internal Timer progressTimer
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _progressTimer;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_progressTimer != null)
                {
                }

                _progressTimer = value;
                if (_progressTimer != null)
                {
                }
            }
        }

        private Label _showinfopopup;

        internal Label showinfopopup
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _showinfopopup;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_showinfopopup != null)
                {
                    _showinfopopup.Click -= ShowInfoPopup_Click;
                }

                _showinfopopup = value;
                if (_showinfopopup != null)
                {
                    _showinfopopup.Click += ShowInfoPopup_Click;
                }
            }
        }

        private Button _btnAnalyze;

        internal Button btnAnalyze
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnAnalyze;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnAnalyze != null)
                {
                    _btnAnalyze.Click -= BtnAnalyze_Click;
                }

                _btnAnalyze = value;
                if (_btnAnalyze != null)
                {
                    _btnAnalyze.Click += BtnAnalyze_Click;
                }
            }
        }

        private ToolTip _ToolTipFilesCompressed;

        internal ToolTip ToolTipFilesCompressed
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ToolTipFilesCompressed;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ToolTipFilesCompressed != null)
                {
                }

                _ToolTipFilesCompressed = value;
                if (_ToolTipFilesCompressed != null)
                {
                }
            }
        }

        private Label _seecompest;

        internal Label seecompest
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _seecompest;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_seecompest != null)
                {
                    _seecompest.MouseHover -= Seecompest_MouseHover;
                    _seecompest.MouseLeave -= HideWikiRes;
                }

                _seecompest = value;
                if (_seecompest != null)
                {
                    _seecompest.MouseHover += Seecompest_MouseHover;
                    _seecompest.MouseLeave += HideWikiRes;
                }
            }
        }

        private PictureBox _topbar_icon;

        internal PictureBox topbar_icon
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _topbar_icon;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_topbar_icon != null)
                {
                }

                _topbar_icon = value;
                if (_topbar_icon != null)
                {
                }
            }
        }

        private Panel _PanelMainWindow;

        internal Panel PanelMainWindow
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PanelMainWindow;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PanelMainWindow != null)
                {
                }

                _PanelMainWindow = value;
                if (_PanelMainWindow != null)
                {
                }
            }
        }

        private Panel _topbar_dirchooserContainer;

        internal Panel topbar_dirchooserContainer
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _topbar_dirchooserContainer;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_topbar_dirchooserContainer != null)
                {
                    _topbar_dirchooserContainer.DragDrop -= DirChooser_DragDrop;
                    _topbar_dirchooserContainer.DragEnter -= DirChooser_DragEnter;
                }

                _topbar_dirchooserContainer = value;
                if (_topbar_dirchooserContainer != null)
                {
                    _topbar_dirchooserContainer.DragDrop += DirChooser_DragDrop;
                    _topbar_dirchooserContainer.DragEnter += DirChooser_DragEnter;
                }
            }
        }

        private Button _BtnMainmin;

        internal Button BtnMainmin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtnMainmin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnMainmin != null)
                {
                    _BtnMainmin.Click -= Btn_Mainmin_Click;
                }

                _BtnMainmin = value;
                if (_BtnMainmin != null)
                {
                    _BtnMainmin.Click += Btn_Mainmin_Click;
                }
            }
        }

        private Button _BtnMainmax;

        internal Button BtnMainmax
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtnMainmax;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnMainmax != null)
                {
                    _BtnMainmax.Click -= Btn_Mainmax_Click;
                }

                _BtnMainmax = value;
                if (_BtnMainmax != null)
                {
                    _BtnMainmax.Click += Btn_Mainmax_Click;
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

        private Panel _sb_Panel;

        internal Panel sb_Panel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _sb_Panel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_sb_Panel != null)
                {
                }

                _sb_Panel = value;
                if (_sb_Panel != null)
                {
                }
            }
        }

        private Label _sb_progresslabel;

        internal Label sb_progresslabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _sb_progresslabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_sb_progresslabel != null)
                {
                }

                _sb_progresslabel = value;
                if (_sb_progresslabel != null)
                {
                }
            }
        }

        private Panel _sb_progressbar;

        internal Panel sb_progressbar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _sb_progressbar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_sb_progressbar != null)
                {
                }

                _sb_progressbar = value;
                if (_sb_progressbar != null)
                {
                }
            }
        }

        private Label _wkPostSizeUnit;

        internal Label wkPostSizeUnit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _wkPostSizeUnit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_wkPostSizeUnit != null)
                {
                }

                _wkPostSizeUnit = value;
                if (_wkPostSizeUnit != null)
                {
                }
            }
        }

        private Label _wkPostSizeVal;

        internal Label wkPostSizeVal
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _wkPostSizeVal;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_wkPostSizeVal != null)
                {
                }

                _wkPostSizeVal = value;
                if (_wkPostSizeVal != null)
                {
                }
            }
        }

        private Label _wkPreSizeUnit;

        internal Label wkPreSizeUnit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _wkPreSizeUnit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_wkPreSizeUnit != null)
                {
                }

                _wkPreSizeUnit = value;
                if (_wkPreSizeUnit != null)
                {
                }
            }
        }

        private TableLayoutPanel _TableLayoutPanel3;

        internal TableLayoutPanel TableLayoutPanel3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TableLayoutPanel3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TableLayoutPanel3 != null)
                {
                }

                _TableLayoutPanel3 = value;
                if (_TableLayoutPanel3 != null)
                {
                }
            }
        }

        private Label _Label19;

        internal Label Label19
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label19;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label19 != null)
                {
                }

                _Label19 = value;
                if (_Label19 != null)
                {
                }
            }
        }

        private Label _sb_labelCompressed;

        internal Label sb_labelCompressed
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _sb_labelCompressed;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_sb_labelCompressed != null)
                {
                    _sb_labelCompressed.MouseHover -= Seecompest_MouseHover;
                    _sb_labelCompressed.MouseLeave -= HideWikiRes;
                }

                _sb_labelCompressed = value;
                if (_sb_labelCompressed != null)
                {
                    _sb_labelCompressed.MouseHover += Seecompest_MouseHover;
                    _sb_labelCompressed.MouseLeave += HideWikiRes;
                }
            }
        }

        private Label _sb_FolderName;

        internal Label sb_FolderName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _sb_FolderName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_sb_FolderName != null)
                {
                }

                _sb_FolderName = value;
                if (_sb_FolderName != null)
                {
                }
            }
        }

        private Panel _vis_dropshadowmain2;

        internal Panel vis_dropshadowmain2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _vis_dropshadowmain2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_vis_dropshadowmain2 != null)
                {
                }

                _vis_dropshadowmain2 = value;
                if (_vis_dropshadowmain2 != null)
                {
                }
            }
        }

        private Panel _vis_dropshadowMain;

        internal Panel vis_dropshadowMain
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _vis_dropshadowMain;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_vis_dropshadowMain != null)
                {
                }

                _vis_dropshadowMain = value;
                if (_vis_dropshadowMain != null)
                {
                }
            }
        }

        private Label _wkPreSizeVal;

        internal Label wkPreSizeVal
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _wkPreSizeVal;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_wkPreSizeVal != null)
                {
                }

                _wkPreSizeVal = value;
                if (_wkPreSizeVal != null)
                {
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

        private TabPage _InputPage;

        internal TabPage InputPage
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _InputPage;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_InputPage != null)
                {
                }

                _InputPage = value;
                if (_InputPage != null)
                {
                }
            }
        }

        private FlowLayoutPanel _FlowPanel_CompressionOptions;

        internal FlowLayoutPanel FlowPanel_CompressionOptions
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _FlowPanel_CompressionOptions;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_FlowPanel_CompressionOptions != null)
                {
                }

                _FlowPanel_CompressionOptions = value;
                if (_FlowPanel_CompressionOptions != null)
                {
                }
            }
        }

        private Panel _Panel4;

        internal Panel Panel4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel4 != null)
                {
                }

                _Panel4 = value;
                if (_Panel4 != null)
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

        private RadioButton _compressX4;

        internal RadioButton compressX4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _compressX4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_compressX4 != null)
                {
                    _compressX4.Click -= Compress_CheckedChanged;
                }

                _compressX4 = value;
                if (_compressX4 != null)
                {
                    _compressX4.Click += Compress_CheckedChanged;
                }
            }
        }

        private RadioButton _compressLZX;

        internal RadioButton compressLZX
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _compressLZX;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_compressLZX != null)
                {
                    _compressLZX.Click -= Compress_CheckedChanged;
                }

                _compressLZX = value;
                if (_compressLZX != null)
                {
                    _compressLZX.Click += Compress_CheckedChanged;
                }
            }
        }

        private RadioButton _compressX8;

        internal RadioButton compressX8
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _compressX8;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_compressX8 != null)
                {
                    _compressX8.Click -= Compress_CheckedChanged;
                }

                _compressX8 = value;
                if (_compressX8 != null)
                {
                    _compressX8.Click += Compress_CheckedChanged;
                }
            }
        }

        private RadioButton _compressX16;

        internal RadioButton compressX16
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _compressX16;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_compressX16 != null)
                {
                    _compressX16.Click -= Compress_CheckedChanged;
                }

                _compressX16 = value;
                if (_compressX16 != null)
                {
                    _compressX16.Click += Compress_CheckedChanged;
                }
            }
        }

        private Panel _Panel3;

        internal Panel Panel3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel3 != null)
                {
                }

                _Panel3 = value;
                if (_Panel3 != null)
                {
                }
            }
        }

        private ComboBox _comboChooseShutdown;

        internal ComboBox comboChooseShutdown
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _comboChooseShutdown;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_comboChooseShutdown != null)
                {
                    _comboChooseShutdown.SelectedIndexChanged -= ComboBox1_SelectedIndexChanged;
                    _comboChooseShutdown.MouseLeave -= ComboBox1_SelectedIndexChanged;
                }

                _comboChooseShutdown = value;
                if (_comboChooseShutdown != null)
                {
                    _comboChooseShutdown.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
                    _comboChooseShutdown.MouseLeave += ComboBox1_SelectedIndexChanged;
                }
            }
        }

        private CheckBox _checkShutdownOnCompletion;

        internal CheckBox checkShutdownOnCompletion
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _checkShutdownOnCompletion;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_checkShutdownOnCompletion != null)
                {
                }

                _checkShutdownOnCompletion = value;
                if (_checkShutdownOnCompletion != null)
                {
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

        private CheckBox _checkForceCompression;

        internal CheckBox checkForceCompression
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _checkForceCompression;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_checkForceCompression != null)
                {
                }

                _checkForceCompression = value;
                if (_checkForceCompression != null)
                {
                }
            }
        }

        private CheckBox _checkHiddenFiles;

        internal CheckBox checkHiddenFiles
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _checkHiddenFiles;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_checkHiddenFiles != null)
                {
                }

                _checkHiddenFiles = value;
                if (_checkHiddenFiles != null)
                {
                }
            }
        }

        private CheckBox _checkRecursiveScan;

        internal CheckBox checkRecursiveScan
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _checkRecursiveScan;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_checkRecursiveScan != null)
                {
                }

                _checkRecursiveScan = value;
                if (_checkRecursiveScan != null)
                {
                }
            }
        }

        private Button _btnCompress;

        internal Button btnCompress
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCompress;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCompress != null)
                {
                    _btnCompress.Click -= BtnCompress_Click;
                    _btnCompress.Paint -= ButtonCompress_Paint;
                    _btnCompress.EnabledChanged -= ButtonCompress_EnabledChanged;
                }

                _btnCompress = value;
                if (_btnCompress != null)
                {
                    _btnCompress.Click += BtnCompress_Click;
                    _btnCompress.Paint += ButtonCompress_Paint;
                    _btnCompress.EnabledChanged += ButtonCompress_EnabledChanged;
                }
            }
        }

        private TabPage _ProgressPage;

        internal TabPage ProgressPage
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ProgressPage;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ProgressPage != null)
                {
                }

                _ProgressPage = value;
                if (_ProgressPage != null)
                {
                }
            }
        }

        private Label _returnArrow;

        internal Label returnArrow
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _returnArrow;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_returnArrow != null)
                {
                    _returnArrow.Click -= ReturnArrow_Click;
                }

                _returnArrow = value;
                if (_returnArrow != null)
                {
                    _returnArrow.Click += ReturnArrow_Click;
                }
            }
        }

        private Panel _Panelconsole;

        internal Panel Panelconsole
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panelconsole;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panelconsole != null)
                {
                }

                _Panelconsole = value;
                if (_Panelconsole != null)
                {
                }
            }
        }

        private Button _saveconlog;

        internal Button saveconlog
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _saveconlog;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_saveconlog != null)
                {
                    _saveconlog.Click -= Saveconlog_Click;
                }

                _saveconlog = value;
                if (_saveconlog != null)
                {
                    _saveconlog.Click += Saveconlog_Click;
                }
            }
        }

        private ListBox _conOut;

        internal ListBox conOut
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _conOut;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_conOut != null)
                {
                }

                _conOut = value;
                if (_conOut != null)
                {
                }
            }
        }

        private Panel _CompResultsPanel;

        internal Panel CompResultsPanel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CompResultsPanel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CompResultsPanel != null)
                {
                    _CompResultsPanel.Paint -= CompResultsPanel_Paint;
                }

                _CompResultsPanel = value;
                if (_CompResultsPanel != null)
                {
                    _CompResultsPanel.Paint += CompResultsPanel_Paint;
                }
            }
        }

        private Label _submitToWiki;

        internal Label submitToWiki
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _submitToWiki;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_submitToWiki != null)
                {
                    _submitToWiki.Click -= SubmitToWiki_Click;
                }

                _submitToWiki = value;
                if (_submitToWiki != null)
                {
                    _submitToWiki.Click += SubmitToWiki_Click;
                }
            }
        }

        private Label _dirChosenLabel;

        internal Label dirChosenLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dirChosenLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dirChosenLabel != null)
                {
                }

                _dirChosenLabel = value;
                if (_dirChosenLabel != null)
                {
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

        private Label _help_resultsFilesCompressed;

        internal Label help_resultsFilesCompressed
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _help_resultsFilesCompressed;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_help_resultsFilesCompressed != null)
                {
                }

                _help_resultsFilesCompressed = value;
                if (_help_resultsFilesCompressed != null)
                {
                }
            }
        }

        private Label _labelFilesCompressed;

        internal Label labelFilesCompressed
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _labelFilesCompressed;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_labelFilesCompressed != null)
                {
                }

                _labelFilesCompressed = value;
                if (_labelFilesCompressed != null)
                {
                }
            }
        }

        private Panel _compressedSizeVisual;

        internal Panel compressedSizeVisual
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _compressedSizeVisual;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_compressedSizeVisual != null)
                {
                }

                _compressedSizeVisual = value;
                if (_compressedSizeVisual != null)
                {
                }
            }
        }

        private Label _compressedSizeLabel;

        internal Label compressedSizeLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _compressedSizeLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_compressedSizeLabel != null)
                {
                }

                _compressedSizeLabel = value;
                if (_compressedSizeLabel != null)
                {
                }
            }
        }

        private Panel _Panel5;

        internal Panel Panel5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel5 != null)
                {
                }

                _Panel5 = value;
                if (_Panel5 != null)
                {
                }
            }
        }

        private Label _origSizeLabel;

        internal Label origSizeLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _origSizeLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_origSizeLabel != null)
                {
                }

                _origSizeLabel = value;
                if (_origSizeLabel != null)
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

        private Label _Label11;

        internal Label Label11
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Label11;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Label11 != null)
                {
                }

                _Label11 = value;
                if (_Label11 != null)
                {
                }
            }
        }

        private Label _spaceSavedLabel;

        internal Label spaceSavedLabel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _spaceSavedLabel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_spaceSavedLabel != null)
                {
                }

                _spaceSavedLabel = value;
                if (_spaceSavedLabel != null)
                {
                }
            }
        }

        private Button _btnUncompress;

        internal Button btnUncompress
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnUncompress;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnUncompress != null)
                {
                    _btnUncompress.Click -= BtnUncompress_Click;
                }

                _btnUncompress = value;
                if (_btnUncompress != null)
                {
                    _btnUncompress.Click += BtnUncompress_Click;
                }
            }
        }

        private Label _sb_progresspercent;

        internal Label sb_progresspercent
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _sb_progresspercent;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_sb_progresspercent != null)
                {
                }

                _sb_progresspercent = value;
                if (_sb_progresspercent != null)
                {
                }
            }
        }

        private Label _sb_lblGameIssues;

        internal Label sb_lblGameIssues
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _sb_lblGameIssues;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_sb_lblGameIssues != null)
                {
                    _sb_lblGameIssues.Click -= Sb_lblKnownIssues_Click;
                }

                _sb_lblGameIssues = value;
                if (_sb_lblGameIssues != null)
                {
                    _sb_lblGameIssues.Click += Sb_lblKnownIssues_Click;
                }
            }
        }

        private Panel _sb_AnalysisPanel;

        internal Panel sb_AnalysisPanel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _sb_AnalysisPanel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_sb_AnalysisPanel != null)
                {
                    _sb_AnalysisPanel.Paint -= Sb_AnalysisPanel_Paint;
                }

                _sb_AnalysisPanel = value;
                if (_sb_AnalysisPanel != null)
                {
                    _sb_AnalysisPanel.Paint += Sb_AnalysisPanel_Paint;
                }
            }
        }

        private Panel _sb_ResultsPanel;

        internal Panel sb_ResultsPanel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _sb_ResultsPanel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_sb_ResultsPanel != null)
                {
                    _sb_ResultsPanel.Paint -= Sb_ResultsPanel_Paint;
                }

                _sb_ResultsPanel = value;
                if (_sb_ResultsPanel != null)
                {
                    _sb_ResultsPanel.Paint += Sb_ResultsPanel_Paint;
                }
            }
        }

        private Panel _Panel6;

        internal Panel Panel6
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Panel6;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Panel6 != null)
                {
                }

                _Panel6 = value;
                if (_Panel6 != null)
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

        private Panel _sb_compressedSizeVisual;

        internal Panel sb_compressedSizeVisual
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _sb_compressedSizeVisual;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_sb_compressedSizeVisual != null)
                {
                }

                _sb_compressedSizeVisual = value;
                if (_sb_compressedSizeVisual != null)
                {
                }
            }
        }

        private TableLayoutPanel _TableLayoutPanel2;

        internal TableLayoutPanel TableLayoutPanel2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TableLayoutPanel2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TableLayoutPanel2 != null)
                {
                }

                _TableLayoutPanel2 = value;
                if (_TableLayoutPanel2 != null)
                {
                }
            }
        }

        private TableLayoutPanel _TableLayoutPanel4;

        internal TableLayoutPanel TableLayoutPanel4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TableLayoutPanel4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TableLayoutPanel4 != null)
                {
                }

                _TableLayoutPanel4 = value;
                if (_TableLayoutPanel4 != null)
                {
                }
            }
        }

        private Panel _updateBanner;

        internal Panel updateBanner
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _updateBanner;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_updateBanner != null)
                {
                    _updateBanner.Paint -= UpdateBanner_Paint;
                }

                _updateBanner = value;
                if (_updateBanner != null)
                {
                    _updateBanner.Paint += UpdateBanner_Paint;
                }
            }
        }

        private LinkLabel _dlUpdateLink;

        internal LinkLabel dlUpdateLink
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _dlUpdateLink;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_dlUpdateLink != null)
                {
                    _dlUpdateLink.LinkClicked -= DlUpdateLink_LinkClicked;
                }

                _dlUpdateLink = value;
                if (_dlUpdateLink != null)
                {
                    _dlUpdateLink.LinkClicked += DlUpdateLink_LinkClicked;
                }
            }
        }

        private GraphicsPanel _results_arc;

        internal GraphicsPanel results_arc
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _results_arc;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_results_arc != null)
                {
                    _results_arc.Paint -= ResultsArcPaint;
                }

                _results_arc = value;
                if (_results_arc != null)
                {
                    _results_arc.Paint += ResultsArcPaint;
                }
            }
        }

        private NotifyIcon _TrayIcon;

        internal NotifyIcon TrayIcon
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TrayIcon;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TrayIcon != null)
                {
                    _TrayIcon.BalloonTipClicked -= TrayIcon_BalloonTipClicked;
                    _TrayIcon.DoubleClick -= TrayIcon_BalloonTipClicked;
                }

                _TrayIcon = value;
                if (_TrayIcon != null)
                {
                    _TrayIcon.BalloonTipClicked += TrayIcon_BalloonTipClicked;
                    _TrayIcon.DoubleClick += TrayIcon_BalloonTipClicked;
                }
            }
        }

        private ContextMenuStrip _TrayMenu;

        internal ContextMenuStrip TrayMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TrayMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TrayMenu != null)
                {
                }

                _TrayMenu = value;
                if (_TrayMenu != null)
                {
                }
            }
        }

        private ToolStripMenuItem _Tray_ShowMain;

        internal ToolStripMenuItem Tray_ShowMain
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Tray_ShowMain;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Tray_ShowMain != null)
                {
                    _Tray_ShowMain.Click -= TrayIcon_BalloonTipClicked;
                }

                _Tray_ShowMain = value;
                if (_Tray_ShowMain != null)
                {
                    _Tray_ShowMain.Click += TrayIcon_BalloonTipClicked;
                }
            }
        }

        private ListBox _SelectedFiles;

        internal ListBox SelectedFiles
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SelectedFiles;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SelectedFiles != null)
                {
                    _SelectedFiles.DrawItem -= ListBox1_DrawItem;
                    _SelectedFiles.MeasureItem -= ListBox1_MeasureItem;
                }

                _SelectedFiles = value;
                if (_SelectedFiles != null)
                {
                    _SelectedFiles.DrawItem += ListBox1_DrawItem;
                    _SelectedFiles.MeasureItem += ListBox1_MeasureItem;
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
    }
}