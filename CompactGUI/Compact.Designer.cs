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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Compact));
            _FolderBrowserDialog1 = new FolderBrowserDialog();
            _OpenFileDialog1 = new OpenFileDialog();
            _topbar_title = new Label();
            _panel_topBar = new Panel();
            _panel_topBar.MouseDown += new MouseEventHandler(Panel_topBar_MouseDown);
            _showinfopopup = new Label();
            _showinfopopup.Click += new EventHandler(ShowInfoPopup_Click);
            _updateBanner = new Panel();
            _updateBanner.Paint += new PaintEventHandler(UpdateBanner_Paint);
            _dlUpdateLink = new LinkLabel();
            _dlUpdateLink.LinkClicked += new LinkLabelLinkClickedEventHandler(DlUpdateLink_LinkClicked);
            _btnAnalyze = new Button();
            _btnAnalyze.Click += new EventHandler(BtnAnalyze_Click);
            _topbar_dirchooserContainer = new Panel();
            _topbar_dirchooserContainer.DragDrop += new DragEventHandler(DirChooser_DragDrop);
            _topbar_dirchooserContainer.DragEnter += new DragEventHandler(DirChooser_DragEnter);
            _dirChooser = new LinkLabel();
            _dirChooser.LinkClicked += new LinkLabelLinkClickedEventHandler(SelectFolderToCompress);
            _dirChooser.Click += new EventHandler(SelectFolderToCompress);
            _dirChooser.LinkClicked += new LinkLabelLinkClickedEventHandler(SelectFolderToCompress);
            _dirChooser.Click += new EventHandler(SelectFolderToCompress);
            _dirChooser.MouseEnter += new EventHandler(DirChooser_MouseEnter);
            _dirChooser.MouseLeave += new EventHandler(DirChooser_MouseLeave);
            _dirChooser.DragDrop += new DragEventHandler(DirChooser_DragDrop);
            _dirChooser.DragEnter += new DragEventHandler(DirChooser_DragEnter);
            _btn_Mainmin = new Button();
            _btn_Mainmin.Click += new EventHandler(Btn_Mainmin_Click);
            _btn_Mainmax = new Button();
            _btn_Mainmax.Click += new EventHandler(Btn_Mainmax_Click);
            _btn_Mainexit = new Button();
            _btn_Mainexit.Click += new EventHandler(Btn_Mainexit_Click);
            _topbar_icon = new PictureBox();
            _progressTimer = new Timer(components);
            _seecompest = new Label();
            _seecompest.MouseHover += new EventHandler(Seecompest_MouseHover);
            _seecompest.MouseLeave += new EventHandler(HideWikiRes);
            _ToolTipFilesCompressed = new ToolTip(components);
            _help_resultsFilesCompressed = new Label();
            _sb_lblGameIssues = new Label();
            _sb_lblGameIssues.Click += new EventHandler(Sb_lblGameIssues_Click);
            _compressX4 = new RadioButton();
            _compressX4.Click += new EventHandler(CompressX8_CheckedChanged);
            _compressLZX = new RadioButton();
            _compressLZX.Click += new EventHandler(CompressX8_CheckedChanged);
            _compressX8 = new RadioButton();
            _compressX8.Click += new EventHandler(CompressX8_CheckedChanged);
            _compressX16 = new RadioButton();
            _compressX16.Click += new EventHandler(CompressX8_CheckedChanged);
            _checkForceCompression = new CheckBox();
            _checkHiddenFiles = new CheckBox();
            _checkRecursiveScan = new CheckBox();
            _panel_MainWindow = new Panel();
            _sb_Panel = new Panel();
            _TableLayoutPanel2 = new TableLayoutPanel();
            _sb_ResultsPanel = new Panel();
            _sb_ResultsPanel.Paint += new PaintEventHandler(Sb_ResultsPanel_Paint);
            _Label4 = new Label();
            _Label3 = new Label();
            _sb_compressedSizeVisual = new Panel();
            _Panel6 = new Panel();
            _sb_AnalysisPanel = new Panel();
            _sb_AnalysisPanel.Paint += new PaintEventHandler(Sb_AnalysisPanel_Paint);
            _sb_progresslabel = new Label();
            _sb_progressbar = new Panel();
            _sb_progresspercent = new Label();
            _wkPostSizeUnit = new Label();
            _wkPostSizeVal = new Label();
            _wkPreSizeUnit = new Label();
            _TableLayoutPanel3 = new TableLayoutPanel();
            _Label19 = new Label();
            _sb_labelCompressed = new Label();
            _sb_labelCompressed.MouseHover += new EventHandler(Seecompest_MouseHover);
            _sb_labelCompressed.MouseLeave += new EventHandler(HideWikiRes);
            _sb_FolderName = new Label();
            _vis_dropshadowmain2 = new Panel();
            _wkPreSizeVal = new Label();
            _btnCompress = new Button();
            _btnCompress.Click += new EventHandler(BtnCompress_Click);
            _btnCompress.Paint += new PaintEventHandler(ButtonCompress_Paint);
            _btnCompress.EnabledChanged += new EventHandler(ButtonCompress_EnabledChanged);
            _btnUncompress = new Button();
            _btnUncompress.Click += new EventHandler(BtnUncompress_Click);
            _vis_dropshadowMain = new Panel();
            _TabControl1 = new TabControl();
            _InputPage = new TabPage();
            _Panel1 = new Panel();
            _Panel1.Paint += new PaintEventHandler(Panel1_Paint);
            _Label1 = new Label();
            _SelectedFiles = new ListBox();
            _SelectedFiles.DrawItem += new DrawItemEventHandler(ListBox1_DrawItem);
            _SelectedFiles.MeasureItem += new MeasureItemEventHandler(ListBox1_MeasureItem);
            _FlowPanel_CompressionOptions = new FlowLayoutPanel();
            _Panel4 = new Panel();
            _Label2 = new Label();
            _Panel3 = new Panel();
            _comboChooseShutdown = new ComboBox();
            _comboChooseShutdown.SelectedIndexChanged += new EventHandler(ComboBox1_SelectedIndexChanged);
            _comboChooseShutdown.MouseLeave += new EventHandler(ComboBox1_SelectedIndexChanged);
            _comboChooseShutdown.SelectedIndexChanged += new EventHandler(ComboBox1_SelectedIndexChanged);
            _comboChooseShutdown.MouseLeave += new EventHandler(ComboBox1_SelectedIndexChanged);
            _checkShutdownOnCompletion = new CheckBox();
            _Label8 = new Label();
            _ProgressPage = new TabPage();
            _TableLayoutPanel4 = new TableLayoutPanel();
            _CompResultsPanel = new Panel();
            _CompResultsPanel.Paint += new PaintEventHandler(CompResultsPanel_Paint);
            _results_arc = new GraphicsPanel();
            _results_arc.Paint += new PaintEventHandler(Results_arc_Paint);
            _labelFilesCompressed = new Label();
            _dirChosenLabel = new Label();
            _TableLayoutPanel1 = new TableLayoutPanel();
            _compressedSizeVisual = new Panel();
            _compressedSizeLabel = new Label();
            _Panel5 = new Panel();
            _origSizeLabel = new Label();
            _Label9 = new Label();
            _Label11 = new Label();
            _panel_console = new Panel();
            _saveconlog = new Button();
            _saveconlog.Click += new EventHandler(Saveconlog_Click);
            _conOut = new ListBox();
            _returnArrow = new Label();
            _returnArrow.Click += new EventHandler(ReturnArrow_Click);
            _submitToWiki = new Label();
            _submitToWiki.Click += new EventHandler(SubmitToWiki_Click);
            _spaceSavedLabel = new Label();
            _TrayIcon = new NotifyIcon(components);
            _TrayIcon.BalloonTipClicked += new EventHandler(TrayIcon_BalloonTipClicked);
            _TrayIcon.DoubleClick += new EventHandler(TrayIcon_BalloonTipClicked);
            _TrayIcon.BalloonTipClicked += new EventHandler(TrayIcon_BalloonTipClicked);
            _TrayIcon.DoubleClick += new EventHandler(TrayIcon_BalloonTipClicked);
            _TrayMenu = new ContextMenuStrip(components);
            _Tray_ShowMain = new ToolStripMenuItem();
            _Tray_ShowMain.Click += new EventHandler(TrayIcon_BalloonTipClicked);
            _panel_topBar.SuspendLayout();
            _updateBanner.SuspendLayout();
            _topbar_dirchooserContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_topbar_icon).BeginInit();
            _panel_MainWindow.SuspendLayout();
            _sb_Panel.SuspendLayout();
            _TableLayoutPanel2.SuspendLayout();
            _sb_ResultsPanel.SuspendLayout();
            _sb_AnalysisPanel.SuspendLayout();
            _TableLayoutPanel3.SuspendLayout();
            _TabControl1.SuspendLayout();
            _InputPage.SuspendLayout();
            _Panel1.SuspendLayout();
            _FlowPanel_CompressionOptions.SuspendLayout();
            _Panel4.SuspendLayout();
            _Panel3.SuspendLayout();
            _ProgressPage.SuspendLayout();
            _TableLayoutPanel4.SuspendLayout();
            _CompResultsPanel.SuspendLayout();
            _compressedSizeVisual.SuspendLayout();
            _Panel5.SuspendLayout();
            _panel_console.SuspendLayout();
            _TrayMenu.SuspendLayout();
            SuspendLayout();
            // 
            // OpenFileDialog1
            // 
            _OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // topbar_title
            // 
            _topbar_title.AutoSize = true;
            _topbar_title.Font = new Font("Segoe UI Semilight", 15.75F);
            _topbar_title.ForeColor = Color.White;
            _topbar_title.Location = new Point(39, 20);
            _topbar_title.Name = "topbar_title";
            _topbar_title.Size = new Size(136, 30);
            _topbar_title.TabIndex = 13;
            _topbar_title.Text = "CompactGUI²";
            // 
            // panel_topBar
            // 
            _panel_topBar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _panel_topBar.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(47)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(83)));
            _panel_topBar.Controls.Add(_showinfopopup);
            _panel_topBar.Controls.Add(_updateBanner);
            _panel_topBar.Controls.Add(_btnAnalyze);
            _panel_topBar.Controls.Add(_topbar_dirchooserContainer);
            _panel_topBar.Controls.Add(_btn_Mainmin);
            _panel_topBar.Controls.Add(_btn_Mainmax);
            _panel_topBar.Controls.Add(_btn_Mainexit);
            _panel_topBar.Controls.Add(_topbar_icon);
            _panel_topBar.Controls.Add(_topbar_title);
            _panel_topBar.Location = new Point(0, 0);
            _panel_topBar.Name = "panel_topBar";
            _panel_topBar.Size = new Size(1000, 135);
            _panel_topBar.TabIndex = 14;
            // 
            // showinfopopup
            // 
            _showinfopopup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _showinfopopup.AutoSize = true;
            _showinfopopup.Font = new Font("Segoe MDL2 Assets", 11.0F);
            _showinfopopup.ForeColor = Color.White;
            _showinfopopup.Location = new Point(798, 15);
            _showinfopopup.Name = "showinfopopup";
            _showinfopopup.Size = new Size(22, 15);
            _showinfopopup.TabIndex = 14;
            _showinfopopup.Text = "";
            // 
            // updateBanner
            // 
            _updateBanner.Anchor = AnchorStyles.Top;
            _updateBanner.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(39)), Conversions.ToInteger(Conversions.ToByte(174)), Conversions.ToInteger(Conversions.ToByte(96)));
            _updateBanner.Controls.Add(_dlUpdateLink);
            _updateBanner.Location = new Point(310, 0);
            _updateBanner.Name = "updateBanner";
            _updateBanner.Size = new Size(380, 19);
            _updateBanner.TabIndex = 24;
            _updateBanner.Visible = false;
            // 
            // dlUpdateLink
            // 
            _dlUpdateLink.BackColor = Color.Transparent;
            _dlUpdateLink.Font = new Font("Segoe UI", 8.0F);
            _dlUpdateLink.LinkBehavior = LinkBehavior.HoverUnderline;
            _dlUpdateLink.LinkColor = Color.AliceBlue;
            _dlUpdateLink.Location = new Point(0, 0);
            _dlUpdateLink.Margin = new Padding(0);
            _dlUpdateLink.Name = "dlUpdateLink";
            _dlUpdateLink.Size = new Size(380, 18);
            _dlUpdateLink.TabIndex = 1;
            _dlUpdateLink.TabStop = true;
            _dlUpdateLink.Text = "Update Available: Click to download V2.X";
            _dlUpdateLink.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAnalyze
            // 
            _btnAnalyze.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnAnalyze.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(47)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(83)));
            _btnAnalyze.FlatAppearance.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(102)), Conversions.ToInteger(Conversions.ToByte(121)), Conversions.ToInteger(Conversions.ToByte(138)));
            _btnAnalyze.FlatAppearance.MouseDownBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(72)), Conversions.ToInteger(Conversions.ToByte(112)), Conversions.ToInteger(Conversions.ToByte(138)));
            _btnAnalyze.FlatAppearance.MouseOverBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(102)), Conversions.ToInteger(Conversions.ToByte(121)), Conversions.ToInteger(Conversions.ToByte(138)));
            _btnAnalyze.FlatStyle = FlatStyle.Flat;
            _btnAnalyze.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnAnalyze.ForeColor = Color.White;
            _btnAnalyze.Location = new Point(742, 71);
            _btnAnalyze.Margin = new Padding(30, 3, 3, 3);
            _btnAnalyze.Name = "btnAnalyze";
            _btnAnalyze.Size = new Size(165, 39);
            _btnAnalyze.TabIndex = 23;
            _btnAnalyze.Text = "Analyse Folder";
            _btnAnalyze.UseVisualStyleBackColor = false;
            _btnAnalyze.Visible = false;
            // 
            // topbar_dirchooserContainer
            // 
            _topbar_dirchooserContainer.AllowDrop = true;
            _topbar_dirchooserContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _topbar_dirchooserContainer.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(102)), Conversions.ToInteger(Conversions.ToByte(121)), Conversions.ToInteger(Conversions.ToByte(138)));
            _topbar_dirchooserContainer.Controls.Add(_dirChooser);
            _topbar_dirchooserContainer.Location = new Point(44, 69);
            _topbar_dirchooserContainer.MinimumSize = new Size(270, 0);
            _topbar_dirchooserContainer.Name = "topbar_dirchooserContainer";
            _topbar_dirchooserContainer.Size = new Size(912, 43);
            _topbar_dirchooserContainer.TabIndex = 15;
            // 
            // dirChooser
            // 
            _dirChooser.ActiveLinkColor = Color.White;
            _dirChooser.AllowDrop = true;
            _dirChooser.AutoEllipsis = true;
            _dirChooser.Dock = DockStyle.Fill;
            _dirChooser.Font = new Font("Segoe UI", 11.25F);
            _dirChooser.ForeColor = Color.White;
            _dirChooser.LinkBehavior = LinkBehavior.NeverUnderline;
            _dirChooser.LinkColor = Color.White;
            _dirChooser.Location = new Point(0, 0);
            _dirChooser.Name = "dirChooser";
            _dirChooser.Padding = new Padding(19, 0, 0, 0);
            _dirChooser.Size = new Size(912, 43);
            _dirChooser.TabIndex = 15;
            _dirChooser.TabStop = true;
            _dirChooser.Text = "❯   Select Target Folder";
            _dirChooser.TextAlign = ContentAlignment.MiddleLeft;
            _dirChooser.VisitedLinkColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(52)), Conversions.ToInteger(Conversions.ToByte(152)), Conversions.ToInteger(Conversions.ToByte(219)));
            // 
            // btn_Mainmin
            // 
            _btn_Mainmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btn_Mainmin.BackColor = Color.Transparent;
            _btn_Mainmin.FlatAppearance.BorderSize = 0;
            _btn_Mainmin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            _btn_Mainmin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            _btn_Mainmin.FlatStyle = FlatStyle.Flat;
            _btn_Mainmin.Font = new Font("Segoe UI Symbol", 11.25F);
            _btn_Mainmin.ForeColor = Color.White;
            _btn_Mainmin.Location = new Point(841, 0);
            _btn_Mainmin.Margin = new Padding(0);
            _btn_Mainmin.Name = "btn_Mainmin";
            _btn_Mainmin.Size = new Size(45, 42);
            _btn_Mainmin.TabIndex = 17;
            _btn_Mainmin.TabStop = false;
            _btn_Mainmin.Text = "—";
            _btn_Mainmin.UseVisualStyleBackColor = false;
            // 
            // btn_Mainmax
            // 
            _btn_Mainmax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btn_Mainmax.BackColor = Color.Transparent;
            _btn_Mainmax.FlatAppearance.BorderSize = 0;
            _btn_Mainmax.FlatAppearance.MouseDownBackColor = Color.Transparent;
            _btn_Mainmax.FlatAppearance.MouseOverBackColor = Color.Transparent;
            _btn_Mainmax.FlatStyle = FlatStyle.Flat;
            _btn_Mainmax.Font = new Font("Segoe UI Symbol", 11.25F);
            _btn_Mainmax.ForeColor = Color.White;
            _btn_Mainmax.Location = new Point(899, 0);
            _btn_Mainmax.Margin = new Padding(0);
            _btn_Mainmax.Name = "btn_Mainmax";
            _btn_Mainmax.Size = new Size(44, 42);
            _btn_Mainmax.TabIndex = 16;
            _btn_Mainmax.TabStop = false;
            _btn_Mainmax.Text = "☐";
            _btn_Mainmax.UseVisualStyleBackColor = false;
            // 
            // btn_Mainexit
            // 
            _btn_Mainexit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btn_Mainexit.BackColor = Color.Transparent;
            _btn_Mainexit.FlatAppearance.BorderSize = 0;
            _btn_Mainexit.FlatAppearance.MouseDownBackColor = Color.Maroon;
            _btn_Mainexit.FlatAppearance.MouseOverBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(192)), Conversions.ToInteger(Conversions.ToByte(0)), Conversions.ToInteger(Conversions.ToByte(0)));
            _btn_Mainexit.FlatStyle = FlatStyle.Flat;
            _btn_Mainexit.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btn_Mainexit.ForeColor = Color.White;
            _btn_Mainexit.Location = new Point(943, 0);
            _btn_Mainexit.Margin = new Padding(0);
            _btn_Mainexit.Name = "btn_Mainexit";
            _btn_Mainexit.Size = new Size(57, 42);
            _btn_Mainexit.TabIndex = 15;
            _btn_Mainexit.TabStop = false;
            _btn_Mainexit.Text = "✕";
            _btn_Mainexit.UseVisualStyleBackColor = false;
            // 
            // topbar_icon
            // 
            _topbar_icon.Image = My.Resources.Resources.iconbright;
            _topbar_icon.Location = new Point(11, 25);
            _topbar_icon.Name = "topbar_icon";
            _topbar_icon.Size = new Size(25, 25);
            _topbar_icon.SizeMode = PictureBoxSizeMode.Zoom;
            _topbar_icon.TabIndex = 15;
            _topbar_icon.TabStop = false;
            // 
            // progressTimer
            // 
            _progressTimer.Interval = 20;
            // 
            // seecompest
            // 
            _seecompest.AutoSize = true;
            _seecompest.Font = new Font("Segoe UI Symbol", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _seecompest.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(52)), Conversions.ToInteger(Conversions.ToByte(152)), Conversions.ToInteger(Conversions.ToByte(219)));
            _seecompest.Location = new Point(316, 96);
            _seecompest.Name = "seecompest";
            _seecompest.Size = new Size(16, 13);
            _seecompest.TabIndex = 21;
            _seecompest.Text = "❯ ";
            _seecompest.Visible = false;
            // 
            // ToolTipFilesCompressed
            // 
            _ToolTipFilesCompressed.AutoPopDelay = 12000;
            _ToolTipFilesCompressed.BackColor = Color.White;
            _ToolTipFilesCompressed.ForeColor = SystemColors.WindowFrame;
            _ToolTipFilesCompressed.InitialDelay = 200;
            _ToolTipFilesCompressed.IsBalloon = true;
            _ToolTipFilesCompressed.ReshowDelay = 100;
            _ToolTipFilesCompressed.ShowAlways = true;
            _ToolTipFilesCompressed.ToolTipIcon = ToolTipIcon.Info;
            _ToolTipFilesCompressed.ToolTipTitle = "Information";
            // 
            // help_resultsFilesCompressed
            // 
            _help_resultsFilesCompressed.AutoSize = true;
            _help_resultsFilesCompressed.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _help_resultsFilesCompressed.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(52)), Conversions.ToInteger(Conversions.ToByte(152)), Conversions.ToInteger(Conversions.ToByte(219)));
            _help_resultsFilesCompressed.Location = new Point(480, 168);
            _help_resultsFilesCompressed.Margin = new Padding(0, 1, 0, 0);
            _help_resultsFilesCompressed.Name = "help_resultsFilesCompressed";
            _help_resultsFilesCompressed.Size = new Size(22, 17);
            _help_resultsFilesCompressed.TabIndex = 31;
            _help_resultsFilesCompressed.Text = "(?)";
            _ToolTipFilesCompressed.SetToolTip(_help_resultsFilesCompressed, resources.GetString("help_resultsFilesCompressed.ToolTip"));
            // 
            // sb_lblGameIssues
            // 
            _sb_lblGameIssues.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            _sb_lblGameIssues.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(220)), Conversions.ToInteger(Conversions.ToByte(30)), Conversions.ToInteger(Conversions.ToByte(0)));
            _sb_lblGameIssues.Location = new Point(189, 153);
            _sb_lblGameIssues.Name = "sb_lblGameIssues";
            _sb_lblGameIssues.Size = new Size(132, 20);
            _sb_lblGameIssues.TabIndex = 23;
            _sb_lblGameIssues.Text = "! Game Has Issues";
            _sb_lblGameIssues.TextAlign = ContentAlignment.MiddleCenter;
            _ToolTipFilesCompressed.SetToolTip(_sb_lblGameIssues, "This game has issues and compression is not recommended. Click to go to the Wiki " + "for details. ");
            _sb_lblGameIssues.Visible = false;
            // 
            // compressX4
            // 
            _compressX4.AutoSize = true;
            _compressX4.Font = new Font("Segoe UI", 8.25F);
            _compressX4.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(48)), Conversions.ToInteger(Conversions.ToByte(67)), Conversions.ToInteger(Conversions.ToByte(84)));
            _compressX4.Location = new Point(37, 38);
            _compressX4.Name = "compressX4";
            _compressX4.Size = new Size(77, 17);
            _compressX4.TabIndex = 9;
            _compressX4.Text = "XPRESS 4K";
            _ToolTipFilesCompressed.SetToolTip(_compressX4, "Fastest, Low Compression");
            _compressX4.UseVisualStyleBackColor = true;
            // 
            // compressLZX
            // 
            _compressLZX.AutoSize = true;
            _compressLZX.Font = new Font("Segoe UI", 8.25F);
            _compressLZX.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(48)), Conversions.ToInteger(Conversions.ToByte(67)), Conversions.ToInteger(Conversions.ToByte(84)));
            _compressLZX.Location = new Point(37, 128);
            _compressLZX.Name = "compressLZX";
            _compressLZX.Size = new Size(45, 17);
            _compressLZX.TabIndex = 12;
            _compressLZX.Text = "LZX ";
            _ToolTipFilesCompressed.SetToolTip(_compressLZX, "Slowest, Very High Compression (Not Recommended for Games/Programs)");
            _compressLZX.UseVisualStyleBackColor = true;
            // 
            // compressX8
            // 
            _compressX8.AutoSize = true;
            _compressX8.Checked = true;
            _compressX8.Font = new Font("Segoe UI", 8.25F);
            _compressX8.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(48)), Conversions.ToInteger(Conversions.ToByte(67)), Conversions.ToInteger(Conversions.ToByte(84)));
            _compressX8.Location = new Point(37, 68);
            _compressX8.Name = "compressX8";
            _compressX8.Size = new Size(77, 17);
            _compressX8.TabIndex = 10;
            _compressX8.TabStop = true;
            _compressX8.Text = "XPRESS 8K";
            _ToolTipFilesCompressed.SetToolTip(_compressX8, "Fast, Medium Compression (Recommended)");
            _compressX8.UseVisualStyleBackColor = true;
            // 
            // compressX16
            // 
            _compressX16.AutoSize = true;
            _compressX16.Font = new Font("Segoe UI", 8.25F);
            _compressX16.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(48)), Conversions.ToInteger(Conversions.ToByte(67)), Conversions.ToInteger(Conversions.ToByte(84)));
            _compressX16.Location = new Point(37, 98);
            _compressX16.Name = "compressX16";
            _compressX16.Size = new Size(83, 17);
            _compressX16.TabIndex = 11;
            _compressX16.Text = "XPRESS 16K";
            _ToolTipFilesCompressed.SetToolTip(_compressX16, "Slow, High Compression");
            _compressX16.UseVisualStyleBackColor = true;
            // 
            // checkForceCompression
            // 
            _checkForceCompression.AutoSize = true;
            _checkForceCompression.Font = new Font("Segoe UI", 8.25F);
            _checkForceCompression.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(48)), Conversions.ToInteger(Conversions.ToByte(67)), Conversions.ToInteger(Conversions.ToByte(84)));
            _checkForceCompression.Location = new Point(37, 68);
            _checkForceCompression.Name = "checkForceCompression";
            _checkForceCompression.Size = new Size(133, 17);
            _checkForceCompression.TabIndex = 7;
            _checkForceCompression.Text = "Force Action on Files";
            _ToolTipFilesCompressed.SetToolTip(_checkForceCompression, resources.GetString("checkForceCompression.ToolTip"));
            _checkForceCompression.UseVisualStyleBackColor = true;
            // 
            // checkHiddenFiles
            // 
            _checkHiddenFiles.AutoSize = true;
            _checkHiddenFiles.Font = new Font("Segoe UI", 8.25F);
            _checkHiddenFiles.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(48)), Conversions.ToInteger(Conversions.ToByte(67)), Conversions.ToInteger(Conversions.ToByte(84)));
            _checkHiddenFiles.Location = new Point(37, 98);
            _checkHiddenFiles.Name = "checkHiddenFiles";
            _checkHiddenFiles.Size = new Size(192, 17);
            _checkHiddenFiles.TabIndex = 6;
            _checkHiddenFiles.Text = "Process Hidden and System Files";
            _ToolTipFilesCompressed.SetToolTip(_checkHiddenFiles, resources.GetString("checkHiddenFiles.ToolTip"));
            _checkHiddenFiles.UseVisualStyleBackColor = true;
            // 
            // checkRecursiveScan
            // 
            _checkRecursiveScan.AutoSize = true;
            _checkRecursiveScan.Checked = true;
            _checkRecursiveScan.CheckState = CheckState.Checked;
            _checkRecursiveScan.Enabled = false;
            _checkRecursiveScan.Font = new Font("Segoe UI", 8.25F);
            _checkRecursiveScan.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(48)), Conversions.ToInteger(Conversions.ToByte(67)), Conversions.ToInteger(Conversions.ToByte(84)));
            _checkRecursiveScan.Location = new Point(37, 38);
            _checkRecursiveScan.Name = "checkRecursiveScan";
            _checkRecursiveScan.Size = new Size(135, 17);
            _checkRecursiveScan.TabIndex = 5;
            _checkRecursiveScan.Text = "Compress Subfolders";
            _ToolTipFilesCompressed.SetToolTip(_checkRecursiveScan, "This option is now checked by default and cannot be changed. ");
            _checkRecursiveScan.UseVisualStyleBackColor = true;
            // 
            // panel_MainWindow
            // 
            _panel_MainWindow.BorderStyle = BorderStyle.FixedSingle;
            _panel_MainWindow.Controls.Add(_panel_topBar);
            _panel_MainWindow.Controls.Add(_sb_Panel);
            _panel_MainWindow.Controls.Add(_vis_dropshadowMain);
            _panel_MainWindow.Controls.Add(_TabControl1);
            _panel_MainWindow.Dock = DockStyle.Fill;
            _panel_MainWindow.Location = new Point(0, 0);
            _panel_MainWindow.Name = "panel_MainWindow";
            _panel_MainWindow.Size = new Size(1002, 652);
            _panel_MainWindow.TabIndex = 31;
            // 
            // sb_Panel
            // 
            _sb_Panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            _sb_Panel.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(43)), Conversions.ToInteger(Conversions.ToByte(60)), Conversions.ToInteger(Conversions.ToByte(75)));
            _sb_Panel.Controls.Add(_TableLayoutPanel2);
            _sb_Panel.Controls.Add(_sb_lblGameIssues);
            _sb_Panel.Controls.Add(_seecompest);
            _sb_Panel.Controls.Add(_wkPostSizeUnit);
            _sb_Panel.Controls.Add(_wkPostSizeVal);
            _sb_Panel.Controls.Add(_wkPreSizeUnit);
            _sb_Panel.Controls.Add(_TableLayoutPanel3);
            _sb_Panel.Controls.Add(_sb_FolderName);
            _sb_Panel.Controls.Add(_vis_dropshadowmain2);
            _sb_Panel.Controls.Add(_wkPreSizeVal);
            _sb_Panel.Controls.Add(_btnCompress);
            _sb_Panel.Controls.Add(_btnUncompress);
            _sb_Panel.Location = new Point(647, 135);
            _sb_Panel.Margin = new Padding(0);
            _sb_Panel.Name = "sb_Panel";
            _sb_Panel.Padding = new Padding(20, 0, 20, 0);
            _sb_Panel.Size = new Size(353, 515);
            _sb_Panel.TabIndex = 15;
            _sb_Panel.Visible = false;
            // 
            // TableLayoutPanel2
            // 
            _TableLayoutPanel2.ColumnCount = 1;
            _TableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            _TableLayoutPanel2.Controls.Add(_sb_ResultsPanel, 0, 0);
            _TableLayoutPanel2.Controls.Add(_sb_AnalysisPanel, 0, 1);
            _TableLayoutPanel2.Location = new Point(7, 173);
            _TableLayoutPanel2.Margin = new Padding(0);
            _TableLayoutPanel2.Name = "TableLayoutPanel2";
            _TableLayoutPanel2.RowCount = 2;
            _TableLayoutPanel2.RowStyles.Add(new RowStyle());
            _TableLayoutPanel2.RowStyles.Add(new RowStyle());
            _TableLayoutPanel2.Size = new Size(342, 251);
            _TableLayoutPanel2.TabIndex = 23;
            // 
            // sb_ResultsPanel
            // 
            _sb_ResultsPanel.Controls.Add(_Label4);
            _sb_ResultsPanel.Controls.Add(_Label3);
            _sb_ResultsPanel.Controls.Add(_sb_compressedSizeVisual);
            _sb_ResultsPanel.Controls.Add(_Panel6);
            _sb_ResultsPanel.Location = new Point(3, 3);
            _sb_ResultsPanel.Name = "sb_ResultsPanel";
            _sb_ResultsPanel.Padding = new Padding(40, 0, 40, 0);
            _sb_ResultsPanel.Size = new Size(332, 141);
            _sb_ResultsPanel.TabIndex = 25;
            _sb_ResultsPanel.Visible = false;
            // 
            // Label4
            // 
            _Label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _Label4.AutoSize = true;
            _Label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label4.ForeColor = Color.Silver;
            _Label4.Location = new Point(201, 126);
            _Label4.Name = "Label4";
            _Label4.Size = new Size(93, 13);
            _Label4.TabIndex = 26;
            _Label4.Text = "Compressed Size";
            _Label4.Visible = false;
            // 
            // Label3
            // 
            _Label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _Label3.AutoSize = true;
            _Label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label3.ForeColor = Color.Silver;
            _Label3.Location = new Point(50, 126);
            _Label3.Name = "Label3";
            _Label3.Size = new Size(72, 13);
            _Label3.TabIndex = 26;
            _Label3.Text = "Original Size";
            _Label3.Visible = false;
            // 
            // sb_compressedSizeVisual
            // 
            _sb_compressedSizeVisual.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(39)), Conversions.ToInteger(Conversions.ToByte(174)), Conversions.ToInteger(Conversions.ToByte(96)));
            _sb_compressedSizeVisual.Location = new Point(225, 5);
            _sb_compressedSizeVisual.Name = "sb_compressedSizeVisual";
            _sb_compressedSizeVisual.Size = new Size(40, 113);
            _sb_compressedSizeVisual.TabIndex = 0;
            // 
            // Panel6
            // 
            _Panel6.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(211)), Conversions.ToInteger(Conversions.ToByte(84)), Conversions.ToInteger(Conversions.ToByte(0)));
            _Panel6.Location = new Point(67, 5);
            _Panel6.Name = "Panel6";
            _Panel6.Size = new Size(40, 113);
            _Panel6.TabIndex = 0;
            // 
            // sb_AnalysisPanel
            // 
            _sb_AnalysisPanel.Controls.Add(_sb_progresslabel);
            _sb_AnalysisPanel.Controls.Add(_sb_progressbar);
            _sb_AnalysisPanel.Controls.Add(_sb_progresspercent);
            _sb_AnalysisPanel.Location = new Point(3, 150);
            _sb_AnalysisPanel.Name = "sb_AnalysisPanel";
            _sb_AnalysisPanel.Size = new Size(332, 96);
            _sb_AnalysisPanel.TabIndex = 24;
            _sb_AnalysisPanel.Visible = false;
            // 
            // sb_progresslabel
            // 
            _sb_progresslabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _sb_progresslabel.ForeColor = Color.White;
            _sb_progresslabel.Location = new Point(19, 32);
            _sb_progresslabel.Name = "sb_progresslabel";
            _sb_progresslabel.Size = new Size(301, 20);
            _sb_progresslabel.TabIndex = 11;
            _sb_progresslabel.Text = "Analysing...";
            _sb_progresslabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sb_progressbar
            // 
            _sb_progressbar.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(39)), Conversions.ToInteger(Conversions.ToByte(174)), Conversions.ToInteger(Conversions.ToByte(96)));
            _sb_progressbar.Location = new Point(19, 55);
            _sb_progressbar.Name = "sb_progressbar";
            _sb_progressbar.Size = new Size(301, 14);
            _sb_progressbar.TabIndex = 10;
            // 
            // sb_progresspercent
            // 
            _sb_progresspercent.BackColor = Color.Transparent;
            _sb_progresspercent.Font = new Font("Segoe UI", 8.25F);
            _sb_progresspercent.ForeColor = Color.White;
            _sb_progresspercent.Location = new Point(107, 72);
            _sb_progresspercent.Name = "sb_progresspercent";
            _sb_progresspercent.RightToLeft = RightToLeft.No;
            _sb_progresspercent.Size = new Size(122, 14);
            _sb_progresspercent.TabIndex = 22;
            _sb_progresspercent.Text = "0%";
            _sb_progresspercent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wkPostSizeUnit
            // 
            _wkPostSizeUnit.AutoSize = true;
            _wkPostSizeUnit.BackColor = Color.Transparent;
            _wkPostSizeUnit.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _wkPostSizeUnit.ForeColor = Color.White;
            _wkPostSizeUnit.Location = new Point(273, 128);
            _wkPostSizeUnit.Name = "wkPostSizeUnit";
            _wkPostSizeUnit.Size = new Size(16, 12);
            _wkPostSizeUnit.TabIndex = 9;
            _wkPostSizeUnit.Text = "GB";
            _wkPostSizeUnit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wkPostSizeVal
            // 
            _wkPostSizeVal.BackColor = Color.Transparent;
            _wkPostSizeVal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _wkPostSizeVal.ForeColor = Color.White;
            _wkPostSizeVal.Location = new Point(184, 112);
            _wkPostSizeVal.Name = "wkPostSizeVal";
            _wkPostSizeVal.Size = new Size(143, 50);
            _wkPostSizeVal.TabIndex = 6;
            _wkPostSizeVal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wkPreSizeUnit
            // 
            _wkPreSizeUnit.AutoSize = true;
            _wkPreSizeUnit.BackColor = Color.Transparent;
            _wkPreSizeUnit.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _wkPreSizeUnit.ForeColor = Color.White;
            _wkPreSizeUnit.Location = new Point(115, 128);
            _wkPreSizeUnit.Name = "wkPreSizeUnit";
            _wkPreSizeUnit.Size = new Size(16, 12);
            _wkPreSizeUnit.TabIndex = 8;
            _wkPreSizeUnit.Text = "GB";
            _wkPreSizeUnit.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TableLayoutPanel3
            // 
            _TableLayoutPanel3.ColumnCount = 3;
            _TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 149.0F));
            _TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8.0F));
            _TableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150.0F));
            _TableLayoutPanel3.Controls.Add(_Label19, 0, 0);
            _TableLayoutPanel3.Controls.Add(_sb_labelCompressed, 2, 0);
            _TableLayoutPanel3.Location = new Point(23, 92);
            _TableLayoutPanel3.Name = "TableLayoutPanel3";
            _TableLayoutPanel3.RowCount = 1;
            _TableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0F));
            _TableLayoutPanel3.Size = new Size(307, 20);
            _TableLayoutPanel3.TabIndex = 7;
            // 
            // Label19
            // 
            _Label19.BackColor = Color.Transparent;
            _Label19.Dock = DockStyle.Fill;
            _Label19.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label19.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(149)), Conversions.ToInteger(Conversions.ToByte(152)), Conversions.ToInteger(Conversions.ToByte(154)));
            _Label19.Location = new Point(0, 0);
            _Label19.Margin = new Padding(0);
            _Label19.Name = "Label19";
            _Label19.Size = new Size(149, 20);
            _Label19.TabIndex = 8;
            _Label19.Text = "Uncompressed";
            _Label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sb_labelCompressed
            // 
            _sb_labelCompressed.BackColor = Color.Transparent;
            _sb_labelCompressed.Dock = DockStyle.Fill;
            _sb_labelCompressed.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _sb_labelCompressed.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(149)), Conversions.ToInteger(Conversions.ToByte(152)), Conversions.ToInteger(Conversions.ToByte(154)));
            _sb_labelCompressed.Location = new Point(157, 0);
            _sb_labelCompressed.Margin = new Padding(0);
            _sb_labelCompressed.Name = "sb_labelCompressed";
            _sb_labelCompressed.Size = new Size(150, 20);
            _sb_labelCompressed.TabIndex = 8;
            _sb_labelCompressed.Text = "Estimated Compressed";
            _sb_labelCompressed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sb_FolderName
            // 
            _sb_FolderName.BackColor = Color.Transparent;
            _sb_FolderName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _sb_FolderName.ForeColor = Color.White;
            _sb_FolderName.Location = new Point(0, 17);
            _sb_FolderName.Name = "sb_FolderName";
            _sb_FolderName.Padding = new Padding(10, 0, 10, 0);
            _sb_FolderName.Size = new Size(354, 60);
            _sb_FolderName.TabIndex = 6;
            _sb_FolderName.Text = "Portal 2";
            _sb_FolderName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // vis_dropshadowmain2
            // 
            _vis_dropshadowmain2.BackColor = Color.Transparent;
            _vis_dropshadowmain2.BackgroundImage = My.Resources.Resources.dsmask;
            _vis_dropshadowmain2.BackgroundImageLayout = ImageLayout.Stretch;
            _vis_dropshadowmain2.Location = new Point(0, 0);
            _vis_dropshadowmain2.Name = "vis_dropshadowmain2";
            _vis_dropshadowmain2.Size = new Size(353, 6);
            _vis_dropshadowmain2.TabIndex = 2;
            // 
            // wkPreSizeVal
            // 
            _wkPreSizeVal.BackColor = Color.Transparent;
            _wkPreSizeVal.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _wkPreSizeVal.ForeColor = Color.White;
            _wkPreSizeVal.Location = new Point(23, 112);
            _wkPreSizeVal.Name = "wkPreSizeVal";
            _wkPreSizeVal.Size = new Size(149, 50);
            _wkPreSizeVal.TabIndex = 6;
            _wkPreSizeVal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCompress
            // 
            _btnCompress.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _btnCompress.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(47)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(83)));
            _btnCompress.Enabled = false;
            _btnCompress.FlatAppearance.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(102)), Conversions.ToInteger(Conversions.ToByte(121)), Conversions.ToInteger(Conversions.ToByte(138)));
            _btnCompress.FlatAppearance.MouseDownBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(72)), Conversions.ToInteger(Conversions.ToByte(112)), Conversions.ToInteger(Conversions.ToByte(138)));
            _btnCompress.FlatAppearance.MouseOverBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(102)), Conversions.ToInteger(Conversions.ToByte(121)), Conversions.ToInteger(Conversions.ToByte(138)));
            _btnCompress.FlatStyle = FlatStyle.Flat;
            _btnCompress.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _btnCompress.ForeColor = Color.Silver;
            _btnCompress.Location = new Point(71, 446);
            _btnCompress.Margin = new Padding(8, 3, 3, 3);
            _btnCompress.Name = "btnCompress";
            _btnCompress.Size = new Size(208, 39);
            _btnCompress.TabIndex = 3;
            _btnCompress.Text = "Compress Folder";
            _btnCompress.UseVisualStyleBackColor = false;
            // 
            // btnUncompress
            // 
            _btnUncompress.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _btnUncompress.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(47)), Conversions.ToInteger(Conversions.ToByte(66)), Conversions.ToInteger(Conversions.ToByte(83)));
            _btnUncompress.FlatAppearance.BorderColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(102)), Conversions.ToInteger(Conversions.ToByte(121)), Conversions.ToInteger(Conversions.ToByte(138)));
            _btnUncompress.FlatAppearance.MouseDownBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(72)), Conversions.ToInteger(Conversions.ToByte(112)), Conversions.ToInteger(Conversions.ToByte(138)));
            _btnUncompress.FlatAppearance.MouseOverBackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(102)), Conversions.ToInteger(Conversions.ToByte(121)), Conversions.ToInteger(Conversions.ToByte(138)));
            _btnUncompress.FlatStyle = FlatStyle.Flat;
            _btnUncompress.Font = new Font("Segoe UI", 8.25F);
            _btnUncompress.ForeColor = Color.White;
            _btnUncompress.Location = new Point(71, 446);
            _btnUncompress.Name = "btnUncompress";
            _btnUncompress.Size = new Size(208, 39);
            _btnUncompress.TabIndex = 29;
            _btnUncompress.Text = "Uncompress Folder";
            _btnUncompress.UseVisualStyleBackColor = false;
            _btnUncompress.Visible = false;
            // 
            // vis_dropshadowMain
            // 
            _vis_dropshadowMain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _vis_dropshadowMain.BackColor = Color.Transparent;
            _vis_dropshadowMain.BackgroundImage = My.Resources.Resources.dsmask;
            _vis_dropshadowMain.BackgroundImageLayout = ImageLayout.Stretch;
            _vis_dropshadowMain.Location = new Point(0, 135);
            _vis_dropshadowMain.Name = "vis_dropshadowMain";
            _vis_dropshadowMain.Size = new Size(998, 6);
            _vis_dropshadowMain.TabIndex = 16;
            // 
            // TabControl1
            // 
            _TabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _TabControl1.Controls.Add(_InputPage);
            _TabControl1.Controls.Add(_ProgressPage);
            _TabControl1.Location = new Point(0, 116);
            _TabControl1.MinimumSize = new Size(503, 200);
            _TabControl1.Name = "TabControl1";
            _TabControl1.SelectedIndex = 0;
            _TabControl1.Size = new Size(1003, 535);
            _TabControl1.TabIndex = 30;
            // 
            // InputPage
            // 
            _InputPage.BackColor = Color.White;
            _InputPage.Controls.Add(_Panel1);
            _InputPage.Controls.Add(_FlowPanel_CompressionOptions);
            _InputPage.Location = new Point(4, 22);
            _InputPage.Name = "InputPage";
            _InputPage.Padding = new Padding(3);
            _InputPage.Size = new Size(995, 509);
            _InputPage.TabIndex = 0;
            _InputPage.Text = "InputPage";
            // 
            // Panel1
            // 
            _Panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _Panel1.Controls.Add(_Label1);
            _Panel1.Controls.Add(_SelectedFiles);
            _Panel1.Location = new Point(44, 214);
            _Panel1.Name = "Panel1";
            _Panel1.Size = new Size(574, 287);
            _Panel1.TabIndex = 24;
            // 
            // Label1
            // 
            _Label1.AutoSize = true;
            _Label1.Font = new Font("Segoe UI", 11.25F);
            _Label1.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(48)), Conversions.ToInteger(Conversions.ToByte(67)), Conversions.ToInteger(Conversions.ToByte(84)));
            _Label1.Location = new Point(15, 35);
            _Label1.Name = "Label1";
            _Label1.Size = new Size(99, 20);
            _Label1.TabIndex = 18;
            _Label1.Text = "Selected Files";
            // 
            // SelectedFiles
            // 
            _SelectedFiles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _SelectedFiles.BackColor = Color.White;
            _SelectedFiles.BorderStyle = BorderStyle.None;
            _SelectedFiles.DrawMode = DrawMode.OwnerDrawVariable;
            _SelectedFiles.Font = new Font("Segoe UI", 10.0F);
            _SelectedFiles.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(48)), Conversions.ToInteger(Conversions.ToByte(67)), Conversions.ToInteger(Conversions.ToByte(84)));
            _SelectedFiles.FormattingEnabled = true;
            _SelectedFiles.ItemHeight = 25;
            _SelectedFiles.Location = new Point(19, 59);
            _SelectedFiles.Name = "SelectedFiles";
            _SelectedFiles.Size = new Size(555, 200);
            _SelectedFiles.TabIndex = 23;
            _SelectedFiles.TabStop = false;
            // 
            // FlowPanel_CompressionOptions
            // 
            _FlowPanel_CompressionOptions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _FlowPanel_CompressionOptions.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _FlowPanel_CompressionOptions.Controls.Add(_Panel4);
            _FlowPanel_CompressionOptions.Controls.Add(_Panel3);
            _FlowPanel_CompressionOptions.Location = new Point(44, 21);
            _FlowPanel_CompressionOptions.Name = "FlowPanel_CompressionOptions";
            _FlowPanel_CompressionOptions.Size = new Size(574, 174);
            _FlowPanel_CompressionOptions.TabIndex = 22;
            // 
            // Panel4
            // 
            _Panel4.Controls.Add(_Label2);
            _Panel4.Controls.Add(_compressX4);
            _Panel4.Controls.Add(_compressLZX);
            _Panel4.Controls.Add(_compressX8);
            _Panel4.Controls.Add(_compressX16);
            _Panel4.Location = new Point(3, 3);
            _Panel4.Name = "Panel4";
            _Panel4.Size = new Size(266, 160);
            _Panel4.TabIndex = 24;
            // 
            // Label2
            // 
            _Label2.AutoSize = true;
            _Label2.Font = new Font("Segoe UI", 11.25F);
            _Label2.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(48)), Conversions.ToInteger(Conversions.ToByte(67)), Conversions.ToInteger(Conversions.ToByte(84)));
            _Label2.Location = new Point(12, 7);
            _Label2.Name = "Label2";
            _Label2.Size = new Size(210, 20);
            _Label2.TabIndex = 18;
            _Label2.Text = "Select Compression Algorithm";
            // 
            // Panel3
            // 
            _Panel3.Controls.Add(_comboChooseShutdown);
            _Panel3.Controls.Add(_checkShutdownOnCompletion);
            _Panel3.Controls.Add(_Label8);
            _Panel3.Controls.Add(_checkForceCompression);
            _Panel3.Controls.Add(_checkHiddenFiles);
            _Panel3.Controls.Add(_checkRecursiveScan);
            _FlowPanel_CompressionOptions.SetFlowBreak(_Panel3, true);
            _Panel3.Location = new Point(275, 3);
            _Panel3.Name = "Panel3";
            _Panel3.Size = new Size(290, 160);
            _Panel3.TabIndex = 23;
            // 
            // comboChooseShutdown
            // 
            _comboChooseShutdown.BackColor = Color.White;
            _comboChooseShutdown.DropDownStyle = ComboBoxStyle.DropDownList;
            _comboChooseShutdown.FlatStyle = FlatStyle.Flat;
            _comboChooseShutdown.Font = new Font("Segoe UI", 8.25F);
            _comboChooseShutdown.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(48)), Conversions.ToInteger(Conversions.ToByte(67)), Conversions.ToInteger(Conversions.ToByte(84)));
            _comboChooseShutdown.FormattingEnabled = true;
            _comboChooseShutdown.Items.AddRange(new object[] { "Shutdown", "Restart", "Sleep" });
            _comboChooseShutdown.Location = new Point(52, 125);
            _comboChooseShutdown.Margin = new Padding(0);
            _comboChooseShutdown.Name = "comboChooseShutdown";
            _comboChooseShutdown.Size = new Size(78, 21);
            _comboChooseShutdown.TabIndex = 34;
            // 
            // checkShutdownOnCompletion
            // 
            _checkShutdownOnCompletion.AutoSize = true;
            _checkShutdownOnCompletion.Font = new Font("Segoe UI", 8.25F);
            _checkShutdownOnCompletion.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(48)), Conversions.ToInteger(Conversions.ToByte(67)), Conversions.ToInteger(Conversions.ToByte(84)));
            _checkShutdownOnCompletion.Location = new Point(37, 128);
            _checkShutdownOnCompletion.Name = "checkShutdownOnCompletion";
            _checkShutdownOnCompletion.Size = new Size(168, 17);
            _checkShutdownOnCompletion.TabIndex = 33;
            _checkShutdownOnCompletion.Text = "                          PC on Finish";
            _checkShutdownOnCompletion.UseVisualStyleBackColor = true;
            // 
            // Label8
            // 
            _Label8.AutoSize = true;
            _Label8.Font = new Font("Segoe UI", 11.25F);
            _Label8.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(48)), Conversions.ToInteger(Conversions.ToByte(67)), Conversions.ToInteger(Conversions.ToByte(84)));
            _Label8.Location = new Point(12, 7);
            _Label8.Name = "Label8";
            _Label8.Size = new Size(199, 20);
            _Label8.TabIndex = 18;
            _Label8.Text = "Select Additional Arguments";
            // 
            // ProgressPage
            // 
            _ProgressPage.BackColor = Color.White;
            _ProgressPage.Controls.Add(_TableLayoutPanel4);
            _ProgressPage.Controls.Add(_returnArrow);
            _ProgressPage.Controls.Add(_submitToWiki);
            _ProgressPage.Location = new Point(4, 22);
            _ProgressPage.Name = "ProgressPage";
            _ProgressPage.Padding = new Padding(3);
            _ProgressPage.Size = new Size(995, 509);
            _ProgressPage.TabIndex = 1;
            _ProgressPage.Text = "ProgressPage";
            // 
            // TableLayoutPanel4
            // 
            _TableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _TableLayoutPanel4.AutoSize = true;
            _TableLayoutPanel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _TableLayoutPanel4.ColumnCount = 1;
            _TableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0F));
            _TableLayoutPanel4.Controls.Add(_CompResultsPanel, 0, 0);
            _TableLayoutPanel4.Controls.Add(_panel_console, 0, 1);
            _TableLayoutPanel4.Location = new Point(7, 54);
            _TableLayoutPanel4.Name = "TableLayoutPanel4";
            _TableLayoutPanel4.RowCount = 2;
            _TableLayoutPanel4.RowStyles.Add(new RowStyle());
            _TableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0F));
            _TableLayoutPanel4.Size = new Size(630, 447);
            _TableLayoutPanel4.TabIndex = 34;
            // 
            // CompResultsPanel
            // 
            _CompResultsPanel.Controls.Add(_results_arc);
            _CompResultsPanel.Controls.Add(_help_resultsFilesCompressed);
            _CompResultsPanel.Controls.Add(_labelFilesCompressed);
            _CompResultsPanel.Controls.Add(_dirChosenLabel);
            _CompResultsPanel.Controls.Add(_TableLayoutPanel1);
            _CompResultsPanel.Controls.Add(_compressedSizeVisual);
            _CompResultsPanel.Controls.Add(_Panel5);
            _CompResultsPanel.Controls.Add(_Label9);
            _CompResultsPanel.Controls.Add(_Label11);
            _CompResultsPanel.Dock = DockStyle.Fill;
            _CompResultsPanel.Location = new Point(3, 3);
            _CompResultsPanel.Name = "CompResultsPanel";
            _CompResultsPanel.Size = new Size(624, 219);
            _CompResultsPanel.TabIndex = 31;
            _CompResultsPanel.Visible = false;
            // 
            // results_arc
            // 
            _results_arc.Location = new Point(13, 63);
            _results_arc.Name = "results_arc";
            _results_arc.Size = new Size(265, 122);
            _results_arc.TabIndex = 35;
            // 
            // labelFilesCompressed
            // 
            _labelFilesCompressed.AutoSize = true;
            _labelFilesCompressed.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _labelFilesCompressed.ForeColor = Color.DimGray;
            _labelFilesCompressed.Location = new Point(284, 167);
            _labelFilesCompressed.Margin = new Padding(0);
            _labelFilesCompressed.MaximumSize = new Size(0, 20);
            _labelFilesCompressed.MinimumSize = new Size(150, 20);
            _labelFilesCompressed.Name = "labelFilesCompressed";
            _labelFilesCompressed.Size = new Size(150, 20);
            _labelFilesCompressed.TabIndex = 30;
            _labelFilesCompressed.Text = "n/n Files Compressed";
            // 
            // dirChosenLabel
            // 
            _dirChosenLabel.AutoSize = true;
            _dirChosenLabel.Font = new Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _dirChosenLabel.ForeColor = Color.DarkGray;
            _dirChosenLabel.Location = new Point(290, 196);
            _dirChosenLabel.Name = "dirChosenLabel";
            _dirChosenLabel.Size = new Size(87, 15);
            _dirChosenLabel.TabIndex = 32;
            _dirChosenLabel.Text = "dirchosenLabel";
            _dirChosenLabel.Visible = false;
            // 
            // TableLayoutPanel1
            // 
            _TableLayoutPanel1.AutoSize = true;
            _TableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _TableLayoutPanel1.ColumnCount = 2;
            _TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            _TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            _TableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            _TableLayoutPanel1.Location = new Point(228, 50);
            _TableLayoutPanel1.Margin = new Padding(0);
            _TableLayoutPanel1.Name = "TableLayoutPanel1";
            _TableLayoutPanel1.RowCount = 1;
            _TableLayoutPanel1.RowStyles.Add(new RowStyle());
            _TableLayoutPanel1.Size = new Size(0, 0);
            _TableLayoutPanel1.TabIndex = 31;
            // 
            // compressedSizeVisual
            // 
            _compressedSizeVisual.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(95)), Conversions.ToInteger(Conversions.ToByte(190)), Conversions.ToInteger(Conversions.ToByte(123)));
            _compressedSizeVisual.Controls.Add(_compressedSizeLabel);
            _compressedSizeVisual.Location = new Point(288, 125);
            _compressedSizeVisual.Name = "compressedSizeVisual";
            _compressedSizeVisual.Size = new Size(320, 25);
            _compressedSizeVisual.TabIndex = 29;
            // 
            // compressedSizeLabel
            // 
            _compressedSizeLabel.AutoSize = true;
            _compressedSizeLabel.Font = new Font("Segoe UI", 10.5F);
            _compressedSizeLabel.ForeColor = SystemColors.ButtonHighlight;
            _compressedSizeLabel.Location = new Point(1, 3);
            _compressedSizeLabel.Name = "compressedSizeLabel";
            _compressedSizeLabel.Size = new Size(58, 19);
            _compressedSizeLabel.TabIndex = 27;
            _compressedSizeLabel.Text = "220 MB";
            // 
            // Panel5
            // 
            _Panel5.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(226)), Conversions.ToInteger(Conversions.ToByte(127)), Conversions.ToInteger(Conversions.ToByte(60)));
            _Panel5.Controls.Add(_origSizeLabel);
            _Panel5.Location = new Point(288, 62);
            _Panel5.Name = "Panel5";
            _Panel5.Size = new Size(320, 25);
            _Panel5.TabIndex = 28;
            // 
            // origSizeLabel
            // 
            _origSizeLabel.AutoSize = true;
            _origSizeLabel.Font = new Font("Segoe UI", 10.5F);
            _origSizeLabel.ForeColor = Color.White;
            _origSizeLabel.Location = new Point(1, 3);
            _origSizeLabel.Name = "origSizeLabel";
            _origSizeLabel.Size = new Size(58, 19);
            _origSizeLabel.TabIndex = 27;
            _origSizeLabel.Text = "300 MB";
            // 
            // Label9
            // 
            _Label9.AutoSize = true;
            _Label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _Label9.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(42)), Conversions.ToInteger(Conversions.ToByte(58)), Conversions.ToInteger(Conversions.ToByte(73)));
            _Label9.Location = new Point(284, 34);
            _Label9.Name = "Label9";
            _Label9.Size = new Size(93, 20);
            _Label9.TabIndex = 25;
            _Label9.Text = "Original Size";
            // 
            // Label11
            // 
            _Label11.AutoSize = true;
            _Label11.Font = new Font("Segoe UI", 11.25F);
            _Label11.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(42)), Conversions.ToInteger(Conversions.ToByte(58)), Conversions.ToInteger(Conversions.ToByte(73)));
            _Label11.Location = new Point(284, 97);
            _Label11.Name = "Label11";
            _Label11.Size = new Size(125, 20);
            _Label11.TabIndex = 26;
            _Label11.Text = "Compressed Size:";
            // 
            // panel_console
            // 
            _panel_console.Controls.Add(_saveconlog);
            _panel_console.Controls.Add(_conOut);
            _panel_console.Dock = DockStyle.Fill;
            _panel_console.Location = new Point(3, 228);
            _panel_console.Name = "panel_console";
            _panel_console.Size = new Size(624, 216);
            _panel_console.TabIndex = 33;
            // 
            // saveconlog
            // 
            _saveconlog.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _saveconlog.BackColor = Color.WhiteSmoke;
            _saveconlog.FlatStyle = FlatStyle.Flat;
            _saveconlog.Location = new Point(533, 188);
            _saveconlog.Name = "saveconlog";
            _saveconlog.Size = new Size(75, 23);
            _saveconlog.TabIndex = 33;
            _saveconlog.Text = "Save Log";
            _saveconlog.UseVisualStyleBackColor = false;
            // 
            // conOut
            // 
            _conOut.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            _conOut.BackColor = Color.White;
            _conOut.BorderStyle = BorderStyle.None;
            _conOut.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _conOut.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(48)), Conversions.ToInteger(Conversions.ToByte(67)), Conversions.ToInteger(Conversions.ToByte(84)));
            _conOut.FormattingEnabled = true;
            _conOut.HorizontalScrollbar = true;
            _conOut.ItemHeight = 15;
            _conOut.Location = new Point(13, 4);
            _conOut.Name = "conOut";
            _conOut.Size = new Size(595, 165);
            _conOut.TabIndex = 30;
            // 
            // returnArrow
            // 
            _returnArrow.AutoSize = true;
            _returnArrow.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _returnArrow.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(48)), Conversions.ToInteger(Conversions.ToByte(67)), Conversions.ToInteger(Conversions.ToByte(84)));
            _returnArrow.Location = new Point(11, 24);
            _returnArrow.Name = "returnArrow";
            _returnArrow.Size = new Size(205, 20);
            _returnArrow.TabIndex = 22;
            _returnArrow.Text = "❮   Return To Selection Screen";
            _returnArrow.Visible = false;
            // 
            // submitToWiki
            // 
            _submitToWiki.AutoSize = true;
            _submitToWiki.BackColor = Color.WhiteSmoke;
            _submitToWiki.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, Conversions.ToByte(0));
            _submitToWiki.ForeColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(52)), Conversions.ToInteger(Conversions.ToByte(152)), Conversions.ToInteger(Conversions.ToByte(219)));
            _submitToWiki.Location = new Point(439, 19);
            _submitToWiki.Name = "submitToWiki";
            _submitToWiki.Padding = new Padding(3, 5, 3, 5);
            _submitToWiki.Size = new Size(179, 30);
            _submitToWiki.TabIndex = 33;
            _submitToWiki.Text = "❯  Submit Results to Wiki";
            _submitToWiki.Visible = false;
            // 
            // spaceSavedLabel
            // 
            _spaceSavedLabel.AutoSize = true;
            _spaceSavedLabel.Font = new Font("Segoe UI", 16.0F);
            _spaceSavedLabel.ForeColor = Color.DimGray;
            _spaceSavedLabel.Location = new Point(1042, 298);
            _spaceSavedLabel.Name = "spaceSavedLabel";
            _spaceSavedLabel.Size = new Size(147, 30);
            _spaceSavedLabel.TabIndex = 27;
            _spaceSavedLabel.Text = "700MB Saved";
            // 
            // TrayIcon
            // 
            _TrayIcon.ContextMenuStrip = _TrayMenu;
            _TrayIcon.Icon = (Icon)resources.GetObject("TrayIcon.Icon");
            _TrayIcon.Text = "CompactGUI";
            _TrayIcon.Visible = true;
            // 
            // TrayMenu
            // 
            _TrayMenu.Items.AddRange(new ToolStripItem[] { _Tray_ShowMain });
            _TrayMenu.Name = "TrayMenu";
            _TrayMenu.RenderMode = ToolStripRenderMode.Professional;
            _TrayMenu.ShowImageMargin = false;
            _TrayMenu.Size = new Size(79, 26);
            // 
            // Tray_ShowMain
            // 
            _Tray_ShowMain.BackColor = Color.White;
            _Tray_ShowMain.Name = "Tray_ShowMain";
            _Tray_ShowMain.Size = new Size(78, 22);
            _Tray_ShowMain.Text = "Show";
            // 
            // Compact
            // 
            AutoScaleDimensions = new SizeF(6.0F, 13.0F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1002, 652);
            Controls.Add(_panel_MainWindow);
            Controls.Add(_spaceSavedLabel);
            DoubleBuffered = true;
            ForeColor = Color.DimGray;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 652);
            Name = "Compact";
            Text = "CompactGUI";
            _panel_topBar.ResumeLayout(false);
            _panel_topBar.PerformLayout();
            _updateBanner.ResumeLayout(false);
            _topbar_dirchooserContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_topbar_icon).EndInit();
            _panel_MainWindow.ResumeLayout(false);
            _sb_Panel.ResumeLayout(false);
            _sb_Panel.PerformLayout();
            _TableLayoutPanel2.ResumeLayout(false);
            _sb_ResultsPanel.ResumeLayout(false);
            _sb_ResultsPanel.PerformLayout();
            _sb_AnalysisPanel.ResumeLayout(false);
            _TableLayoutPanel3.ResumeLayout(false);
            _TabControl1.ResumeLayout(false);
            _InputPage.ResumeLayout(false);
            _Panel1.ResumeLayout(false);
            _Panel1.PerformLayout();
            _FlowPanel_CompressionOptions.ResumeLayout(false);
            _Panel4.ResumeLayout(false);
            _Panel4.PerformLayout();
            _Panel3.ResumeLayout(false);
            _Panel3.PerformLayout();
            _ProgressPage.ResumeLayout(false);
            _ProgressPage.PerformLayout();
            _TableLayoutPanel4.ResumeLayout(false);
            _CompResultsPanel.ResumeLayout(false);
            _CompResultsPanel.PerformLayout();
            _compressedSizeVisual.ResumeLayout(false);
            _compressedSizeVisual.PerformLayout();
            _Panel5.ResumeLayout(false);
            _Panel5.PerformLayout();
            _panel_console.ResumeLayout(false);
            _TrayMenu.ResumeLayout(false);
            Load += new EventHandler(Compact_Load);
            FormClosing += new FormClosingEventHandler(MyForm_Closing);
            ResumeLayout(false);
            PerformLayout();
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

        private Panel _panel_topBar;

        internal Panel panel_topBar
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _panel_topBar;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_panel_topBar != null)
                {
                    _panel_topBar.MouseDown -= Panel_topBar_MouseDown;
                }

                _panel_topBar = value;
                if (_panel_topBar != null)
                {
                    _panel_topBar.MouseDown += Panel_topBar_MouseDown;
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

        private Panel _panel_MainWindow;

        internal Panel panel_MainWindow
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _panel_MainWindow;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_panel_MainWindow != null)
                {
                }

                _panel_MainWindow = value;
                if (_panel_MainWindow != null)
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

        private Button _btn_Mainmin;

        internal Button btn_Mainmin
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btn_Mainmin;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btn_Mainmin != null)
                {
                    _btn_Mainmin.Click -= Btn_Mainmin_Click;
                }

                _btn_Mainmin = value;
                if (_btn_Mainmin != null)
                {
                    _btn_Mainmin.Click += Btn_Mainmin_Click;
                }
            }
        }

        private Button _btn_Mainmax;

        internal Button btn_Mainmax
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btn_Mainmax;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btn_Mainmax != null)
                {
                    _btn_Mainmax.Click -= Btn_Mainmax_Click;
                }

                _btn_Mainmax = value;
                if (_btn_Mainmax != null)
                {
                    _btn_Mainmax.Click += Btn_Mainmax_Click;
                }
            }
        }

        private Button _btn_Mainexit;

        internal Button btn_Mainexit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _btn_Mainexit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_btn_Mainexit != null)
                {
                    _btn_Mainexit.Click -= Btn_Mainexit_Click;
                }

                _btn_Mainexit = value;
                if (_btn_Mainexit != null)
                {
                    _btn_Mainexit.Click += Btn_Mainexit_Click;
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
                    _compressX4.Click -= CompressX8_CheckedChanged;
                }

                _compressX4 = value;
                if (_compressX4 != null)
                {
                    _compressX4.Click += CompressX8_CheckedChanged;
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
                    _compressLZX.Click -= CompressX8_CheckedChanged;
                }

                _compressLZX = value;
                if (_compressLZX != null)
                {
                    _compressLZX.Click += CompressX8_CheckedChanged;
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
                    _compressX8.Click -= CompressX8_CheckedChanged;
                }

                _compressX8 = value;
                if (_compressX8 != null)
                {
                    _compressX8.Click += CompressX8_CheckedChanged;
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
                    _compressX16.Click -= CompressX8_CheckedChanged;
                }

                _compressX16 = value;
                if (_compressX16 != null)
                {
                    _compressX16.Click += CompressX8_CheckedChanged;
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

        private Panel _panel_console;

        internal Panel panel_console
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _panel_console;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_panel_console != null)
                {
                }

                _panel_console = value;
                if (_panel_console != null)
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
                    _sb_lblGameIssues.Click -= Sb_lblGameIssues_Click;
                }

                _sb_lblGameIssues = value;
                if (_sb_lblGameIssues != null)
                {
                    _sb_lblGameIssues.Click += Sb_lblGameIssues_Click;
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
                    _results_arc.Paint -= Results_arc_Paint;
                }

                _results_arc = value;
                if (_results_arc != null)
                {
                    _results_arc.Paint += Results_arc_Paint;
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