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
            this._TopBarTitle = new System.Windows.Forms.Label();
            this._TopBarPanel = new System.Windows.Forms.Panel();
            this._btnConfigure = new System.Windows.Forms.Label();
            this._updateBanner = new System.Windows.Forms.Panel();
            this._UpdateLink = new System.Windows.Forms.LinkLabel();
            this._btnAnalyze = new System.Windows.Forms.Button();
            this._topbar_dirchooserContainer = new System.Windows.Forms.Panel();
            this._dirChooser = new System.Windows.Forms.LinkLabel();
            this._BtnMainMin = new System.Windows.Forms.Button();
            this._BtnMainMax = new System.Windows.Forms.Button();
            this._BtnMainExit = new System.Windows.Forms.Button();
            this._TopBarIcon = new System.Windows.Forms.PictureBox();
            this._progressTimer = new System.Windows.Forms.Timer(this.components);
            this._seecompest = new System.Windows.Forms.Label();
            this._ToolTipFilesCompressed = new System.Windows.Forms.ToolTip(this.components);
            this._helpResultsFilesCompressed = new System.Windows.Forms.Label();
            this._lblGameIssues = new System.Windows.Forms.Label();
            this._compressX4 = new System.Windows.Forms.RadioButton();
            this._compressLZX = new System.Windows.Forms.RadioButton();
            this._compressX8 = new System.Windows.Forms.RadioButton();
            this._compressX16 = new System.Windows.Forms.RadioButton();
            this._checkForceCompression = new System.Windows.Forms.CheckBox();
            this._checkHiddenFiles = new System.Windows.Forms.CheckBox();
            this._checkRecursiveScan = new System.Windows.Forms.CheckBox();
            this._PanelMainWindow = new System.Windows.Forms.Panel();
            this._ActivityPanel = new System.Windows.Forms.Panel();
            this._TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._sb_ResultsPanel = new System.Windows.Forms.Panel();
            this._Label4 = new System.Windows.Forms.Label();
            this._Label3 = new System.Windows.Forms.Label();
            this._CompSizeBar = new System.Windows.Forms.Panel();
            this._OrigSizeBar = new System.Windows.Forms.Panel();
            this._AnalysisPanel = new System.Windows.Forms.Panel();
            this._lblActivityProgress = new System.Windows.Forms.Label();
            this._ActivityProgressBar = new System.Windows.Forms.Panel();
            this._lblProgressPercent = new System.Windows.Forms.Label();
            this._wkPostSizeUnit = new System.Windows.Forms.Label();
            this._wkPostSizeVal = new System.Windows.Forms.Label();
            this._wkPreSizeUnit = new System.Windows.Forms.Label();
            this._TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this._lblUncompressed = new System.Windows.Forms.Label();
            this._lblCompressed = new System.Windows.Forms.Label();
            this._lblFolderName = new System.Windows.Forms.Label();
            this._vis_dropshadowmain2 = new System.Windows.Forms.Panel();
            this._wkPreSizeVal = new System.Windows.Forms.Label();
            this._btnCompDecomp = new System.Windows.Forms.Button();
            this._vis_dropshadowMain = new System.Windows.Forms.Panel();
            this._TabControl1 = new System.Windows.Forms.TabControl();
            this._InputPage = new System.Windows.Forms.TabPage();
            this._FilesPanel = new System.Windows.Forms.Panel();
            this._Label1 = new System.Windows.Forms.Label();
            this._SelectedFiles = new System.Windows.Forms.ListBox();
            this._FlowPanel_CompressionOptions = new System.Windows.Forms.FlowLayoutPanel();
            this._CompressionPanel = new System.Windows.Forms.Panel();
            this._Label2 = new System.Windows.Forms.Label();
            this._ArgumentPanel = new System.Windows.Forms.Panel();
            this._comboChooseShutdown = new System.Windows.Forms.ComboBox();
            this._checkShutdownOnCompletion = new System.Windows.Forms.CheckBox();
            this._Label8 = new System.Windows.Forms.Label();
            this._ProgressPage = new System.Windows.Forms.TabPage();
            this._tlpResultsConsole = new System.Windows.Forms.TableLayoutPanel();
            this._CompResultsPanel = new System.Windows.Forms.Panel();
            this._ResultsArc = new CompactGUI.GraphicsPanel();
            this._lblFilesCompressed = new System.Windows.Forms.Label();
            this._dirChosenLabel = new System.Windows.Forms.Label();
            this._TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._ResultsCompressedBar = new System.Windows.Forms.Panel();
            this._compressedSizeLabel = new System.Windows.Forms.Label();
            this._ResultsOriginalBar = new System.Windows.Forms.Panel();
            this._origSizeLabel = new System.Windows.Forms.Label();
            this._Label9 = new System.Windows.Forms.Label();
            this._Label11 = new System.Windows.Forms.Label();
            this._ConsolePanel = new System.Windows.Forms.Panel();
            this._btnSaveConsoleLog = new System.Windows.Forms.Button();
            this._ConsoleOutput = new System.Windows.Forms.ListBox();
            this._btnReturn = new System.Windows.Forms.Label();
            this._btnSubmitToWiki = new System.Windows.Forms.Label();
            this._spaceSavedLabel = new System.Windows.Forms.Label();
            this._TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this._TrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._Tray_ShowMain = new System.Windows.Forms.ToolStripMenuItem();
            this._TopBarPanel.SuspendLayout();
            this._updateBanner.SuspendLayout();
            this._topbar_dirchooserContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._TopBarIcon)).BeginInit();
            this._PanelMainWindow.SuspendLayout();
            this._ActivityPanel.SuspendLayout();
            this._TableLayoutPanel2.SuspendLayout();
            this._sb_ResultsPanel.SuspendLayout();
            this._AnalysisPanel.SuspendLayout();
            this._TableLayoutPanel3.SuspendLayout();
            this._TabControl1.SuspendLayout();
            this._InputPage.SuspendLayout();
            this._FilesPanel.SuspendLayout();
            this._FlowPanel_CompressionOptions.SuspendLayout();
            this._CompressionPanel.SuspendLayout();
            this._ArgumentPanel.SuspendLayout();
            this._ProgressPage.SuspendLayout();
            this._tlpResultsConsole.SuspendLayout();
            this._CompResultsPanel.SuspendLayout();
            this._ResultsCompressedBar.SuspendLayout();
            this._ResultsOriginalBar.SuspendLayout();
            this._ConsolePanel.SuspendLayout();
            this._TrayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // _OpenFileDialog1
            // 
            this._OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // _TopBarTitle
            // 
            this._TopBarTitle.AutoSize = true;
            this._TopBarTitle.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F);
            this._TopBarTitle.ForeColor = System.Drawing.Color.White;
            this._TopBarTitle.Location = new System.Drawing.Point(39, 20);
            this._TopBarTitle.Name = "_TopBarTitle";
            this._TopBarTitle.Size = new System.Drawing.Size(136, 30);
            this._TopBarTitle.TabIndex = 13;
            this._TopBarTitle.Text = "CompactGUI²";
            // 
            // _TopBarPanel
            // 
            this._TopBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._TopBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(66)))), ((int)(((byte)(83)))));
            this._TopBarPanel.Controls.Add(this._btnConfigure);
            this._TopBarPanel.Controls.Add(this._updateBanner);
            this._TopBarPanel.Controls.Add(this._btnAnalyze);
            this._TopBarPanel.Controls.Add(this._topbar_dirchooserContainer);
            this._TopBarPanel.Controls.Add(this._BtnMainMin);
            this._TopBarPanel.Controls.Add(this._BtnMainMax);
            this._TopBarPanel.Controls.Add(this._BtnMainExit);
            this._TopBarPanel.Controls.Add(this._TopBarIcon);
            this._TopBarPanel.Controls.Add(this._TopBarTitle);
            this._TopBarPanel.Location = new System.Drawing.Point(0, 0);
            this._TopBarPanel.Name = "_TopBarPanel";
            this._TopBarPanel.Size = new System.Drawing.Size(1000, 135);
            this._TopBarPanel.TabIndex = 14;
            this._TopBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_topBar_MouseDown);
            // 
            // _btnConfigure
            // 
            this._btnConfigure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnConfigure.AutoSize = true;
            this._btnConfigure.Font = new System.Drawing.Font("Segoe MDL2 Assets", 11F);
            this._btnConfigure.ForeColor = System.Drawing.Color.White;
            this._btnConfigure.Location = new System.Drawing.Point(798, 15);
            this._btnConfigure.Name = "_btnConfigure";
            this._btnConfigure.Size = new System.Drawing.Size(22, 15);
            this._btnConfigure.TabIndex = 14;
            this._btnConfigure.Text = "";
            this._btnConfigure.Click += new System.EventHandler(this.ShowInfoPopup_Click);
            // 
            // _updateBanner
            // 
            this._updateBanner.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._updateBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this._updateBanner.Controls.Add(this._UpdateLink);
            this._updateBanner.Location = new System.Drawing.Point(310, 0);
            this._updateBanner.Name = "_updateBanner";
            this._updateBanner.Size = new System.Drawing.Size(380, 19);
            this._updateBanner.TabIndex = 24;
            this._updateBanner.Visible = false;
            this._updateBanner.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateBanner_Paint);
            // 
            // _UpdateLink
            // 
            this._UpdateLink.BackColor = System.Drawing.Color.Transparent;
            this._UpdateLink.Font = new System.Drawing.Font("Segoe UI", 8F);
            this._UpdateLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this._UpdateLink.LinkColor = System.Drawing.Color.AliceBlue;
            this._UpdateLink.Location = new System.Drawing.Point(0, 0);
            this._UpdateLink.Margin = new System.Windows.Forms.Padding(0);
            this._UpdateLink.Name = "_UpdateLink";
            this._UpdateLink.Size = new System.Drawing.Size(380, 18);
            this._UpdateLink.TabIndex = 1;
            this._UpdateLink.TabStop = true;
            this._UpdateLink.Text = "Update Available: Click to Download!";
            this._UpdateLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._UpdateLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DlUpdateLink_LinkClicked);
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
            // _BtnMainMin
            // 
            this._BtnMainMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._BtnMainMin.BackColor = System.Drawing.Color.Transparent;
            this._BtnMainMin.FlatAppearance.BorderSize = 0;
            this._BtnMainMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._BtnMainMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._BtnMainMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._BtnMainMin.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this._BtnMainMin.ForeColor = System.Drawing.Color.White;
            this._BtnMainMin.Location = new System.Drawing.Point(841, 0);
            this._BtnMainMin.Margin = new System.Windows.Forms.Padding(0);
            this._BtnMainMin.Name = "_BtnMainMin";
            this._BtnMainMin.Size = new System.Drawing.Size(45, 42);
            this._BtnMainMin.TabIndex = 17;
            this._BtnMainMin.TabStop = false;
            this._BtnMainMin.Text = "—";
            this._BtnMainMin.UseVisualStyleBackColor = false;
            this._BtnMainMin.Click += new System.EventHandler(this.Btn_Mainmin_Click);
            // 
            // _BtnMainMax
            // 
            this._BtnMainMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._BtnMainMax.BackColor = System.Drawing.Color.Transparent;
            this._BtnMainMax.FlatAppearance.BorderSize = 0;
            this._BtnMainMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._BtnMainMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._BtnMainMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._BtnMainMax.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F);
            this._BtnMainMax.ForeColor = System.Drawing.Color.White;
            this._BtnMainMax.Location = new System.Drawing.Point(899, 0);
            this._BtnMainMax.Margin = new System.Windows.Forms.Padding(0);
            this._BtnMainMax.Name = "_BtnMainMax";
            this._BtnMainMax.Size = new System.Drawing.Size(44, 42);
            this._BtnMainMax.TabIndex = 16;
            this._BtnMainMax.TabStop = false;
            this._BtnMainMax.Text = "☐";
            this._BtnMainMax.UseVisualStyleBackColor = false;
            this._BtnMainMax.Click += new System.EventHandler(this.Btn_Mainmax_Click);
            // 
            // _BtnMainExit
            // 
            this._BtnMainExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._BtnMainExit.BackColor = System.Drawing.Color.Transparent;
            this._BtnMainExit.FlatAppearance.BorderSize = 0;
            this._BtnMainExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this._BtnMainExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this._BtnMainExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._BtnMainExit.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._BtnMainExit.ForeColor = System.Drawing.Color.White;
            this._BtnMainExit.Location = new System.Drawing.Point(943, 0);
            this._BtnMainExit.Margin = new System.Windows.Forms.Padding(0);
            this._BtnMainExit.Name = "_BtnMainExit";
            this._BtnMainExit.Size = new System.Drawing.Size(57, 42);
            this._BtnMainExit.TabIndex = 15;
            this._BtnMainExit.TabStop = false;
            this._BtnMainExit.Text = "✕";
            this._BtnMainExit.UseVisualStyleBackColor = false;
            this._BtnMainExit.Click += new System.EventHandler(this.Btn_Mainexit_Click);
            // 
            // _TopBarIcon
            // 
            this._TopBarIcon.Image = global::CompactGUI.My.Resources.Resources.iconbright;
            this._TopBarIcon.Location = new System.Drawing.Point(11, 25);
            this._TopBarIcon.Name = "_TopBarIcon";
            this._TopBarIcon.Size = new System.Drawing.Size(25, 25);
            this._TopBarIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._TopBarIcon.TabIndex = 15;
            this._TopBarIcon.TabStop = false;
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
            // _helpResultsFilesCompressed
            // 
            this._helpResultsFilesCompressed.AutoSize = true;
            this._helpResultsFilesCompressed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._helpResultsFilesCompressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this._helpResultsFilesCompressed.Location = new System.Drawing.Point(480, 168);
            this._helpResultsFilesCompressed.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this._helpResultsFilesCompressed.Name = "_helpResultsFilesCompressed";
            this._helpResultsFilesCompressed.Size = new System.Drawing.Size(22, 17);
            this._helpResultsFilesCompressed.TabIndex = 31;
            this._helpResultsFilesCompressed.Text = "(?)";
            this._ToolTipFilesCompressed.SetToolTip(this._helpResultsFilesCompressed, resources.GetString("_helpResultsFilesCompressed.ToolTip"));
            // 
            // _lblGameIssues
            // 
            this._lblGameIssues.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblGameIssues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this._lblGameIssues.Location = new System.Drawing.Point(189, 153);
            this._lblGameIssues.Name = "_lblGameIssues";
            this._lblGameIssues.Size = new System.Drawing.Size(132, 20);
            this._lblGameIssues.TabIndex = 23;
            this._lblGameIssues.Text = "! Known Issues";
            this._lblGameIssues.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._ToolTipFilesCompressed.SetToolTip(this._lblGameIssues, "This game has issues and compression is not recommended. Click to go to the Wiki " +
        "for details. ");
            this._lblGameIssues.Visible = false;
            this._lblGameIssues.Click += new System.EventHandler(this.Sb_lblKnownIssues_Click);
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
            this._PanelMainWindow.Controls.Add(this._TopBarPanel);
            this._PanelMainWindow.Controls.Add(this._ActivityPanel);
            this._PanelMainWindow.Controls.Add(this._vis_dropshadowMain);
            this._PanelMainWindow.Controls.Add(this._TabControl1);
            this._PanelMainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this._PanelMainWindow.Location = new System.Drawing.Point(0, 0);
            this._PanelMainWindow.Name = "_PanelMainWindow";
            this._PanelMainWindow.Size = new System.Drawing.Size(1002, 652);
            this._PanelMainWindow.TabIndex = 31;
            // 
            // _ActivityPanel
            // 
            this._ActivityPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            this._ActivityPanel.Controls.Add(this._TableLayoutPanel2);
            this._ActivityPanel.Controls.Add(this._lblGameIssues);
            this._ActivityPanel.Controls.Add(this._seecompest);
            this._ActivityPanel.Controls.Add(this._wkPostSizeUnit);
            this._ActivityPanel.Controls.Add(this._wkPostSizeVal);
            this._ActivityPanel.Controls.Add(this._wkPreSizeUnit);
            this._ActivityPanel.Controls.Add(this._TableLayoutPanel3);
            this._ActivityPanel.Controls.Add(this._lblFolderName);
            this._ActivityPanel.Controls.Add(this._vis_dropshadowmain2);
            this._ActivityPanel.Controls.Add(this._wkPreSizeVal);
            this._ActivityPanel.Controls.Add(this._btnCompDecomp);
            this._ActivityPanel.Location = new System.Drawing.Point(647, 135);
            this._ActivityPanel.Margin = new System.Windows.Forms.Padding(0);
            this._ActivityPanel.Name = "_ActivityPanel";
            this._ActivityPanel.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this._ActivityPanel.Size = new System.Drawing.Size(353, 515);
            this._ActivityPanel.TabIndex = 15;
            // 
            // _TableLayoutPanel2
            // 
            this._TableLayoutPanel2.ColumnCount = 1;
            this._TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._TableLayoutPanel2.Controls.Add(this._sb_ResultsPanel, 0, 0);
            this._TableLayoutPanel2.Controls.Add(this._AnalysisPanel, 0, 1);
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
            this._sb_ResultsPanel.Controls.Add(this._CompSizeBar);
            this._sb_ResultsPanel.Controls.Add(this._OrigSizeBar);
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
            // _CompSizeBar
            // 
            this._CompSizeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this._CompSizeBar.Location = new System.Drawing.Point(225, 5);
            this._CompSizeBar.Name = "_CompSizeBar";
            this._CompSizeBar.Size = new System.Drawing.Size(40, 113);
            this._CompSizeBar.TabIndex = 0;
            // 
            // _OrigSizeBar
            // 
            this._OrigSizeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this._OrigSizeBar.Location = new System.Drawing.Point(67, 5);
            this._OrigSizeBar.Name = "_OrigSizeBar";
            this._OrigSizeBar.Size = new System.Drawing.Size(40, 113);
            this._OrigSizeBar.TabIndex = 0;
            // 
            // _AnalysisPanel
            // 
            this._AnalysisPanel.Controls.Add(this._lblActivityProgress);
            this._AnalysisPanel.Controls.Add(this._ActivityProgressBar);
            this._AnalysisPanel.Controls.Add(this._lblProgressPercent);
            this._AnalysisPanel.Location = new System.Drawing.Point(3, 150);
            this._AnalysisPanel.Name = "_AnalysisPanel";
            this._AnalysisPanel.Size = new System.Drawing.Size(332, 96);
            this._AnalysisPanel.TabIndex = 24;
            this._AnalysisPanel.Visible = false;
            this._AnalysisPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Sb_AnalysisPanel_Paint);
            // 
            // _lblActivityProgress
            // 
            this._lblActivityProgress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblActivityProgress.ForeColor = System.Drawing.Color.White;
            this._lblActivityProgress.Location = new System.Drawing.Point(19, 32);
            this._lblActivityProgress.Name = "_lblActivityProgress";
            this._lblActivityProgress.Size = new System.Drawing.Size(301, 20);
            this._lblActivityProgress.TabIndex = 11;
            this._lblActivityProgress.Text = "Analysing...";
            this._lblActivityProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _ActivityProgressBar
            // 
            this._ActivityProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this._ActivityProgressBar.Location = new System.Drawing.Point(19, 55);
            this._ActivityProgressBar.Name = "_ActivityProgressBar";
            this._ActivityProgressBar.Size = new System.Drawing.Size(301, 14);
            this._ActivityProgressBar.TabIndex = 10;
            // 
            // _lblProgressPercent
            // 
            this._lblProgressPercent.BackColor = System.Drawing.Color.Transparent;
            this._lblProgressPercent.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this._lblProgressPercent.ForeColor = System.Drawing.Color.White;
            this._lblProgressPercent.Location = new System.Drawing.Point(107, 72);
            this._lblProgressPercent.Name = "_lblProgressPercent";
            this._lblProgressPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lblProgressPercent.Size = new System.Drawing.Size(122, 14);
            this._lblProgressPercent.TabIndex = 22;
            this._lblProgressPercent.Text = "0%";
            this._lblProgressPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this._TableLayoutPanel3.Controls.Add(this._lblUncompressed, 0, 0);
            this._TableLayoutPanel3.Controls.Add(this._lblCompressed, 2, 0);
            this._TableLayoutPanel3.Location = new System.Drawing.Point(23, 92);
            this._TableLayoutPanel3.Name = "_TableLayoutPanel3";
            this._TableLayoutPanel3.RowCount = 1;
            this._TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._TableLayoutPanel3.Size = new System.Drawing.Size(307, 20);
            this._TableLayoutPanel3.TabIndex = 7;
            // 
            // _lblUncompressed
            // 
            this._lblUncompressed.BackColor = System.Drawing.Color.Transparent;
            this._lblUncompressed.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lblUncompressed.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblUncompressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(152)))), ((int)(((byte)(154)))));
            this._lblUncompressed.Location = new System.Drawing.Point(0, 0);
            this._lblUncompressed.Margin = new System.Windows.Forms.Padding(0);
            this._lblUncompressed.Name = "_lblUncompressed";
            this._lblUncompressed.Size = new System.Drawing.Size(149, 20);
            this._lblUncompressed.TabIndex = 8;
            this._lblUncompressed.Text = "Uncompressed";
            this._lblUncompressed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lblCompressed
            // 
            this._lblCompressed.BackColor = System.Drawing.Color.Transparent;
            this._lblCompressed.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lblCompressed.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCompressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(152)))), ((int)(((byte)(154)))));
            this._lblCompressed.Location = new System.Drawing.Point(157, 0);
            this._lblCompressed.Margin = new System.Windows.Forms.Padding(0);
            this._lblCompressed.Name = "_lblCompressed";
            this._lblCompressed.Size = new System.Drawing.Size(150, 20);
            this._lblCompressed.TabIndex = 8;
            this._lblCompressed.Text = "Estimated Compressed";
            this._lblCompressed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._lblCompressed.MouseLeave += new System.EventHandler(this.HideWikiRes);
            this._lblCompressed.MouseHover += new System.EventHandler(this.Seecompest_MouseHover);
            // 
            // _lblFolderName
            // 
            this._lblFolderName.BackColor = System.Drawing.Color.Transparent;
            this._lblFolderName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblFolderName.ForeColor = System.Drawing.Color.White;
            this._lblFolderName.Location = new System.Drawing.Point(0, 17);
            this._lblFolderName.Name = "_lblFolderName";
            this._lblFolderName.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this._lblFolderName.Size = new System.Drawing.Size(354, 60);
            this._lblFolderName.TabIndex = 6;
            this._lblFolderName.Text = "Folder Name";
            this._lblFolderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // _btnCompDecomp
            // 
            this._btnCompDecomp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCompDecomp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(66)))), ((int)(((byte)(83)))));
            this._btnCompDecomp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(121)))), ((int)(((byte)(138)))));
            this._btnCompDecomp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(112)))), ((int)(((byte)(138)))));
            this._btnCompDecomp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(121)))), ((int)(((byte)(138)))));
            this._btnCompDecomp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnCompDecomp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCompDecomp.ForeColor = System.Drawing.Color.Silver;
            this._btnCompDecomp.Location = new System.Drawing.Point(71, 446);
            this._btnCompDecomp.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this._btnCompDecomp.Name = "_btnCompDecomp";
            this._btnCompDecomp.Size = new System.Drawing.Size(208, 39);
            this._btnCompDecomp.TabIndex = 3;
            this._btnCompDecomp.Text = "(De)Compress";
            this._btnCompDecomp.UseVisualStyleBackColor = false;
            this._btnCompDecomp.EnabledChanged += new System.EventHandler(this.ButtonCompress_EnabledChanged);
            this._btnCompDecomp.Click += new System.EventHandler(this.BtnCompDecomp_Click);
            this._btnCompDecomp.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonCompress_Paint);
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
            this._InputPage.Controls.Add(this._FilesPanel);
            this._InputPage.Controls.Add(this._FlowPanel_CompressionOptions);
            this._InputPage.Location = new System.Drawing.Point(4, 22);
            this._InputPage.Name = "_InputPage";
            this._InputPage.Padding = new System.Windows.Forms.Padding(3);
            this._InputPage.Size = new System.Drawing.Size(995, 509);
            this._InputPage.TabIndex = 0;
            this._InputPage.Text = "InputPage";
            // 
            // _FilesPanel
            // 
            this._FilesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._FilesPanel.Controls.Add(this._Label1);
            this._FilesPanel.Controls.Add(this._SelectedFiles);
            this._FilesPanel.Location = new System.Drawing.Point(44, 214);
            this._FilesPanel.Name = "_FilesPanel";
            this._FilesPanel.Size = new System.Drawing.Size(574, 287);
            this._FilesPanel.TabIndex = 24;
            this._FilesPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
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
            this._FlowPanel_CompressionOptions.Controls.Add(this._CompressionPanel);
            this._FlowPanel_CompressionOptions.Controls.Add(this._ArgumentPanel);
            this._FlowPanel_CompressionOptions.Location = new System.Drawing.Point(44, 21);
            this._FlowPanel_CompressionOptions.Name = "_FlowPanel_CompressionOptions";
            this._FlowPanel_CompressionOptions.Size = new System.Drawing.Size(574, 174);
            this._FlowPanel_CompressionOptions.TabIndex = 22;
            // 
            // _CompressionPanel
            // 
            this._CompressionPanel.Controls.Add(this._Label2);
            this._CompressionPanel.Controls.Add(this._compressX4);
            this._CompressionPanel.Controls.Add(this._compressLZX);
            this._CompressionPanel.Controls.Add(this._compressX8);
            this._CompressionPanel.Controls.Add(this._compressX16);
            this._CompressionPanel.Location = new System.Drawing.Point(3, 3);
            this._CompressionPanel.Name = "_CompressionPanel";
            this._CompressionPanel.Size = new System.Drawing.Size(266, 160);
            this._CompressionPanel.TabIndex = 24;
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
            // _ArgumentPanel
            // 
            this._ArgumentPanel.Controls.Add(this._comboChooseShutdown);
            this._ArgumentPanel.Controls.Add(this._checkShutdownOnCompletion);
            this._ArgumentPanel.Controls.Add(this._Label8);
            this._ArgumentPanel.Controls.Add(this._checkForceCompression);
            this._ArgumentPanel.Controls.Add(this._checkHiddenFiles);
            this._ArgumentPanel.Controls.Add(this._checkRecursiveScan);
            this._FlowPanel_CompressionOptions.SetFlowBreak(this._ArgumentPanel, true);
            this._ArgumentPanel.Location = new System.Drawing.Point(275, 3);
            this._ArgumentPanel.Name = "_ArgumentPanel";
            this._ArgumentPanel.Size = new System.Drawing.Size(290, 160);
            this._ArgumentPanel.TabIndex = 23;
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
            this._ProgressPage.Controls.Add(this._tlpResultsConsole);
            this._ProgressPage.Controls.Add(this._btnReturn);
            this._ProgressPage.Controls.Add(this._btnSubmitToWiki);
            this._ProgressPage.Location = new System.Drawing.Point(4, 22);
            this._ProgressPage.Name = "_ProgressPage";
            this._ProgressPage.Padding = new System.Windows.Forms.Padding(3);
            this._ProgressPage.Size = new System.Drawing.Size(995, 509);
            this._ProgressPage.TabIndex = 1;
            this._ProgressPage.Text = "ProgressPage";
            // 
            // _tlpResultsConsole
            // 
            this._tlpResultsConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tlpResultsConsole.AutoSize = true;
            this._tlpResultsConsole.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this._tlpResultsConsole.ColumnCount = 1;
            this._tlpResultsConsole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlpResultsConsole.Controls.Add(this._CompResultsPanel, 0, 0);
            this._tlpResultsConsole.Controls.Add(this._ConsolePanel, 0, 1);
            this._tlpResultsConsole.Location = new System.Drawing.Point(7, 54);
            this._tlpResultsConsole.Name = "_tlpResultsConsole";
            this._tlpResultsConsole.RowCount = 2;
            this._tlpResultsConsole.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tlpResultsConsole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlpResultsConsole.Size = new System.Drawing.Size(630, 447);
            this._tlpResultsConsole.TabIndex = 34;
            // 
            // _CompResultsPanel
            // 
            this._CompResultsPanel.Controls.Add(this._ResultsArc);
            this._CompResultsPanel.Controls.Add(this._helpResultsFilesCompressed);
            this._CompResultsPanel.Controls.Add(this._lblFilesCompressed);
            this._CompResultsPanel.Controls.Add(this._dirChosenLabel);
            this._CompResultsPanel.Controls.Add(this._TableLayoutPanel1);
            this._CompResultsPanel.Controls.Add(this._ResultsCompressedBar);
            this._CompResultsPanel.Controls.Add(this._ResultsOriginalBar);
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
            // _ResultsArc
            // 
            this._ResultsArc.Location = new System.Drawing.Point(13, 63);
            this._ResultsArc.Name = "_ResultsArc";
            this._ResultsArc.Size = new System.Drawing.Size(265, 122);
            this._ResultsArc.TabIndex = 35;
            this._ResultsArc.Paint += new System.Windows.Forms.PaintEventHandler(this.ResultsArcPaint);
            // 
            // _lblFilesCompressed
            // 
            this._lblFilesCompressed.AutoSize = true;
            this._lblFilesCompressed.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblFilesCompressed.ForeColor = System.Drawing.Color.DimGray;
            this._lblFilesCompressed.Location = new System.Drawing.Point(284, 167);
            this._lblFilesCompressed.Margin = new System.Windows.Forms.Padding(0);
            this._lblFilesCompressed.MaximumSize = new System.Drawing.Size(0, 20);
            this._lblFilesCompressed.MinimumSize = new System.Drawing.Size(150, 20);
            this._lblFilesCompressed.Name = "_lblFilesCompressed";
            this._lblFilesCompressed.Size = new System.Drawing.Size(150, 20);
            this._lblFilesCompressed.TabIndex = 30;
            this._lblFilesCompressed.Text = "n/n Files Compressed";
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
            // _ResultsCompressedBar
            // 
            this._ResultsCompressedBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(190)))), ((int)(((byte)(123)))));
            this._ResultsCompressedBar.Controls.Add(this._compressedSizeLabel);
            this._ResultsCompressedBar.Location = new System.Drawing.Point(288, 125);
            this._ResultsCompressedBar.Name = "_ResultsCompressedBar";
            this._ResultsCompressedBar.Size = new System.Drawing.Size(320, 25);
            this._ResultsCompressedBar.TabIndex = 29;
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
            // _ResultsOriginalBar
            // 
            this._ResultsOriginalBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(127)))), ((int)(((byte)(60)))));
            this._ResultsOriginalBar.Controls.Add(this._origSizeLabel);
            this._ResultsOriginalBar.Location = new System.Drawing.Point(288, 62);
            this._ResultsOriginalBar.Name = "_ResultsOriginalBar";
            this._ResultsOriginalBar.Size = new System.Drawing.Size(320, 25);
            this._ResultsOriginalBar.TabIndex = 28;
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
            // _ConsolePanel
            // 
            this._ConsolePanel.Controls.Add(this._btnSaveConsoleLog);
            this._ConsolePanel.Controls.Add(this._ConsoleOutput);
            this._ConsolePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ConsolePanel.Location = new System.Drawing.Point(3, 228);
            this._ConsolePanel.Name = "_ConsolePanel";
            this._ConsolePanel.Size = new System.Drawing.Size(624, 216);
            this._ConsolePanel.TabIndex = 33;
            // 
            // _btnSaveConsoleLog
            // 
            this._btnSaveConsoleLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSaveConsoleLog.BackColor = System.Drawing.Color.WhiteSmoke;
            this._btnSaveConsoleLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnSaveConsoleLog.Location = new System.Drawing.Point(533, 188);
            this._btnSaveConsoleLog.Name = "_btnSaveConsoleLog";
            this._btnSaveConsoleLog.Size = new System.Drawing.Size(75, 23);
            this._btnSaveConsoleLog.TabIndex = 33;
            this._btnSaveConsoleLog.Text = "Save Log";
            this._btnSaveConsoleLog.UseVisualStyleBackColor = false;
            this._btnSaveConsoleLog.Click += new System.EventHandler(this.Saveconlog_Click);
            // 
            // _ConsoleOutput
            // 
            this._ConsoleOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._ConsoleOutput.BackColor = System.Drawing.Color.White;
            this._ConsoleOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._ConsoleOutput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._ConsoleOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this._ConsoleOutput.FormattingEnabled = true;
            this._ConsoleOutput.HorizontalScrollbar = true;
            this._ConsoleOutput.ItemHeight = 15;
            this._ConsoleOutput.Location = new System.Drawing.Point(13, 4);
            this._ConsoleOutput.Name = "_ConsoleOutput";
            this._ConsoleOutput.Size = new System.Drawing.Size(595, 165);
            this._ConsoleOutput.TabIndex = 30;
            // 
            // _btnReturn
            // 
            this._btnReturn.AutoSize = true;
            this._btnReturn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(67)))), ((int)(((byte)(84)))));
            this._btnReturn.Location = new System.Drawing.Point(11, 24);
            this._btnReturn.Name = "_btnReturn";
            this._btnReturn.Size = new System.Drawing.Size(205, 20);
            this._btnReturn.TabIndex = 22;
            this._btnReturn.Text = "❮   Return To Selection Screen";
            this._btnReturn.Visible = false;
            this._btnReturn.Click += new System.EventHandler(this.ReturnArrow_Click);
            // 
            // _btnSubmitToWiki
            // 
            this._btnSubmitToWiki.AutoSize = true;
            this._btnSubmitToWiki.BackColor = System.Drawing.Color.WhiteSmoke;
            this._btnSubmitToWiki.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnSubmitToWiki.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this._btnSubmitToWiki.Location = new System.Drawing.Point(439, 19);
            this._btnSubmitToWiki.Name = "_btnSubmitToWiki";
            this._btnSubmitToWiki.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this._btnSubmitToWiki.Size = new System.Drawing.Size(179, 30);
            this._btnSubmitToWiki.TabIndex = 33;
            this._btnSubmitToWiki.Text = "❯  Submit Results to Wiki";
            this._btnSubmitToWiki.Visible = false;
            this._btnSubmitToWiki.Click += new System.EventHandler(this.SubmitToWiki_Click);
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
            this._TopBarPanel.ResumeLayout(false);
            this._TopBarPanel.PerformLayout();
            this._updateBanner.ResumeLayout(false);
            this._topbar_dirchooserContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._TopBarIcon)).EndInit();
            this._PanelMainWindow.ResumeLayout(false);
            this._ActivityPanel.ResumeLayout(false);
            this._ActivityPanel.PerformLayout();
            this._TableLayoutPanel2.ResumeLayout(false);
            this._sb_ResultsPanel.ResumeLayout(false);
            this._sb_ResultsPanel.PerformLayout();
            this._AnalysisPanel.ResumeLayout(false);
            this._TableLayoutPanel3.ResumeLayout(false);
            this._TabControl1.ResumeLayout(false);
            this._InputPage.ResumeLayout(false);
            this._FilesPanel.ResumeLayout(false);
            this._FilesPanel.PerformLayout();
            this._FlowPanel_CompressionOptions.ResumeLayout(false);
            this._CompressionPanel.ResumeLayout(false);
            this._CompressionPanel.PerformLayout();
            this._ArgumentPanel.ResumeLayout(false);
            this._ArgumentPanel.PerformLayout();
            this._ProgressPage.ResumeLayout(false);
            this._ProgressPage.PerformLayout();
            this._tlpResultsConsole.ResumeLayout(false);
            this._CompResultsPanel.ResumeLayout(false);
            this._CompResultsPanel.PerformLayout();
            this._ResultsCompressedBar.ResumeLayout(false);
            this._ResultsCompressedBar.PerformLayout();
            this._ResultsOriginalBar.ResumeLayout(false);
            this._ResultsOriginalBar.PerformLayout();
            this._ConsolePanel.ResumeLayout(false);
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

        private Label _TopBarTitle;

        internal Label topbar_title
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TopBarTitle;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TopBarTitle != null)
                {
                }

                _TopBarTitle = value;
                if (_TopBarTitle != null)
                {
                }
            }
        }

        private Panel _TopBarPanel;

        internal Panel TopBarPanel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TopBarPanel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TopBarPanel != null)
                {
                    _TopBarPanel.MouseDown -= Panel_topBar_MouseDown;
                }

                _TopBarPanel = value;
                if (_TopBarPanel != null)
                {
                    _TopBarPanel.MouseDown += Panel_topBar_MouseDown;
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

        private Label _btnConfigure;

        internal Label btnConfigure
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnConfigure;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnConfigure != null)
                {
                    _btnConfigure.Click -= ShowInfoPopup_Click;
                }

                _btnConfigure = value;
                if (_btnConfigure != null)
                {
                    _btnConfigure.Click += ShowInfoPopup_Click;
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

        private PictureBox _TopBarIcon;

        internal PictureBox TopBarIcon
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TopBarIcon;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TopBarIcon != null)
                {
                }

                _TopBarIcon = value;
                if (_TopBarIcon != null)
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

        private Button _BtnMainMin;

        internal Button BtnMainmin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtnMainMin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnMainMin != null)
                {
                    _BtnMainMin.Click -= Btn_Mainmin_Click;
                }

                _BtnMainMin = value;
                if (_BtnMainMin != null)
                {
                    _BtnMainMin.Click += Btn_Mainmin_Click;
                }
            }
        }

        private Button _BtnMainMax;

        internal Button BtnMainmax
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtnMainMax;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnMainMax != null)
                {
                    _BtnMainMax.Click -= Btn_Mainmax_Click;
                }

                _BtnMainMax = value;
                if (_BtnMainMax != null)
                {
                    _BtnMainMax.Click += Btn_Mainmax_Click;
                }
            }
        }

        private Button _BtnMainExit;

        internal Button BtnMainexit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BtnMainExit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BtnMainExit != null)
                {
                    _BtnMainExit.Click -= Btn_Mainexit_Click;
                }

                _BtnMainExit = value;
                if (_BtnMainExit != null)
                {
                    _BtnMainExit.Click += Btn_Mainexit_Click;
                }
            }
        }

        private Panel _ActivityPanel;

        internal Panel ActivityPanel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ActivityPanel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ActivityPanel = value;
            }
        }

        private Label _lblActivityProgress;

        internal Label lblActivityProgress
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblActivityProgress;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblActivityProgress = value;
            }
        }

        private Panel _ActivityProgressBar;

        internal Panel ActivityProgressBar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ActivityProgressBar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ActivityProgressBar = value;
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
                _wkPostSizeUnit = value;
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
                _wkPostSizeVal = value;
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
                _wkPreSizeUnit = value;
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
                _TableLayoutPanel3 = value;
            }
        }

        private Label _lblUncompressed;

        internal Label lblUncompressed
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblUncompressed;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblUncompressed = value;
            }
        }

        private Label _lblCompressed;

        internal Label lblCompressed
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblCompressed;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblCompressed != null)
                {
                    _lblCompressed.MouseHover -= Seecompest_MouseHover;
                    _lblCompressed.MouseLeave -= HideWikiRes;
                }

                _lblCompressed = value;
                if (_lblCompressed != null)
                {
                    _lblCompressed.MouseHover += Seecompest_MouseHover;
                    _lblCompressed.MouseLeave += HideWikiRes;
                }
            }
        }

        private Label _lblFolderName;

        internal Label lblFolderName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblFolderName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblFolderName = value;
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
                _vis_dropshadowmain2 = value;
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

        private Panel _CompressionPanel;

        internal Panel CompressionPanel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CompressionPanel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CompressionPanel != null)
                {
                }

                _CompressionPanel = value;
                if (_CompressionPanel != null)
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

        private Panel _ArgumentPanel;

        internal Panel ArgumentPanel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ArgumentPanel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ArgumentPanel = value;
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
                _checkShutdownOnCompletion = value;
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
                _Label8 = value;
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
                _checkForceCompression = value;
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
                _checkHiddenFiles = value;
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
                _checkRecursiveScan = value;
            }
        }

        private Button _btnCompDecomp;

        internal Button btnCompDecomp
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnCompDecomp;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnCompDecomp != null)
                {
                    _btnCompDecomp.Click -= BtnCompDecomp_Click;
                    _btnCompDecomp.Paint -= ButtonCompress_Paint;
                    _btnCompDecomp.EnabledChanged -= ButtonCompress_EnabledChanged;
                }

                _btnCompDecomp = value;
                if (_btnCompDecomp != null)
                {
                    _btnCompDecomp.Click += BtnCompDecomp_Click;
                    _btnCompDecomp.Paint += ButtonCompress_Paint;
                    _btnCompDecomp.EnabledChanged += ButtonCompress_EnabledChanged;
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
                _ProgressPage = value;
            }
        }

        private Label _btnReturn;

        internal Label btnReturn
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnReturn;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnReturn != null)
                {
                    _btnReturn.Click -= ReturnArrow_Click;
                }

                _btnReturn = value;
                if (_btnReturn != null)
                {
                    _btnReturn.Click += ReturnArrow_Click;
                }
            }
        }

        private Panel _ConsolePanel;

        internal Panel ConsolePanel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ConsolePanel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ConsolePanel = value;
            }
        }

        private Button _btnSaveConsoleLog;

        internal Button btnSaveConsoleLog
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSaveConsoleLog;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSaveConsoleLog != null)
                {
                    _btnSaveConsoleLog.Click -= Saveconlog_Click;
                }

                _btnSaveConsoleLog = value;
                if (_btnSaveConsoleLog != null)
                {
                    _btnSaveConsoleLog.Click += Saveconlog_Click;
                }
            }
        }

        private ListBox _ConsoleOutput;

        internal ListBox ConsoleOutput
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ConsoleOutput;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ConsoleOutput = value;
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

        private Label _btnSubmitToWiki;

        internal Label btnSubmitToWiki
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btnSubmitToWiki;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btnSubmitToWiki != null)
                {
                    _btnSubmitToWiki.Click -= SubmitToWiki_Click;
                }

                _btnSubmitToWiki = value;
                if (_btnSubmitToWiki != null)
                {
                    _btnSubmitToWiki.Click += SubmitToWiki_Click;
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
                _dirChosenLabel = value;
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
                _TableLayoutPanel1 = value;
            }
        }

        private Label _helpResultsFilesCompressed;

        internal Label helpResultsFilesCompressed
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _helpResultsFilesCompressed;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _helpResultsFilesCompressed = value;
            }
        }

        private Label _lblFilesCompressed;

        internal Label lblFilesCompressed
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblFilesCompressed;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblFilesCompressed = value;
            }
        }

        private Panel _ResultsCompressedBar;

        internal Panel ResultsCompressedBar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ResultsCompressedBar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ResultsCompressedBar = value;
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
                _compressedSizeLabel = value;
            }
        }

        private Panel _ResultsOriginalBar;

        internal Panel ResultsOriginalBar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ResultsOriginalBar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _ResultsOriginalBar = value;
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
                _origSizeLabel = value;
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

        private Label _lblProgressPercent;

        internal Label lblProgressPercent
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblProgressPercent;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _lblProgressPercent = value;
            }
        }

        private Label _lblGameIssues;

        internal Label lblGameIssues
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lblGameIssues;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lblGameIssues != null)
                {
                    _lblGameIssues.Click -= Sb_lblKnownIssues_Click;
                }

                _lblGameIssues = value;
                if (_lblGameIssues != null)
                {
                    _lblGameIssues.Click += Sb_lblKnownIssues_Click;
                }
            }
        }

        private Panel _AnalysisPanel;

        internal Panel AnalysisPanel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AnalysisPanel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AnalysisPanel != null)
                {
                    _AnalysisPanel.Paint -= Sb_AnalysisPanel_Paint;
                }

                _AnalysisPanel = value;
                if (_AnalysisPanel != null)
                {
                    _AnalysisPanel.Paint += Sb_AnalysisPanel_Paint;
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

        private Panel _OrigSizeBar;

        internal Panel OrigSizeBar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _OrigSizeBar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _OrigSizeBar = value;
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

        private Panel _CompSizeBar;

        internal Panel CompSizeBar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CompSizeBar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _CompSizeBar = value;
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
                _TableLayoutPanel2 = value;
            }
        }

        private TableLayoutPanel _tlpResultsConsole;

        internal TableLayoutPanel tlpResultsConsole
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _tlpResultsConsole;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _tlpResultsConsole = value;
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

        private LinkLabel _UpdateLink;

        internal LinkLabel UpdateLink
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _UpdateLink;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_UpdateLink != null)
                {
                    _UpdateLink.LinkClicked -= DlUpdateLink_LinkClicked;
                }

                _UpdateLink = value;
                if (_UpdateLink != null)
                {
                    _UpdateLink.LinkClicked += DlUpdateLink_LinkClicked;
                }
            }
        }

        private GraphicsPanel _ResultsArc;

        internal GraphicsPanel ResultsArc
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ResultsArc;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ResultsArc != null)
                {
                    _ResultsArc.Paint -= ResultsArcPaint;
                }

                _ResultsArc = value;
                if (_ResultsArc != null)
                {
                    _ResultsArc.Paint += ResultsArcPaint;
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
                _TrayMenu = value;
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

        private Panel _FilesPanel;

        internal Panel FilesPanel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _FilesPanel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_FilesPanel != null)
                {
                    _FilesPanel.Paint -= Panel1_Paint;
                }

                _FilesPanel = value;
                if (_FilesPanel != null)
                {
                    _FilesPanel.Paint += Panel1_Paint;
                }
            }
        }
    }
}
