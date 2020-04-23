using System.Drawing;

namespace CompactGUI
{
    internal static class CommmonActions
    {

        // FIXME: can't compress new files for some reason

        public static void PrepareforCompact()
        {
            {
                Compact withBlock = My.MyProject.Forms.Compact;
                withBlock.btnCompress.Visible = true;
                withBlock.btnCompress.Enabled = true;
                withBlock.btnAnalyze.Enabled = true;
                withBlock.btnUncompress.Visible = false;
                withBlock.returnArrow.Visible = false;
                withBlock.checkShutdownOnCompletion.Checked = false;
                withBlock.CompResultsPanel.Visible = false;
                withBlock.submitToWiki.Visible = false;
                withBlock.sb_AnalysisPanel.Visible = false;
                withBlock.sb_ResultsPanel.Visible = false;
                withBlock.TabControl1.SelectedTab = withBlock.InputPage;
                withBlock.sb_labelCompressed.Text = "Estimated Compressed";
            }
        }

        public static void ActionBegun(string Mode)
        {
            {
                Compact withBlock = My.MyProject.Forms.Compact;
                switch (Mode)
                {
                    case "C":
                        {
                            withBlock.IsActive1 = true;
                            withBlock.IsQueryMode1 = false;
                            withBlock.btnCompress.Visible = false;
                            withBlock.btnAnalyze.Enabled = false;
                            withBlock.sb_progresslabel.Text = "Compressing, Please Wait";
                            withBlock.sb_progresspercent.Visible = true;
                            withBlock.sb_AnalysisPanel.Visible = true;
                            break;
                        }

                    case "U":
                        {
                            withBlock.IsActive1 = true;
                            withBlock.IsQueryMode1 = false;
                            withBlock.btnUncompress.Visible = false;
                            withBlock.btnAnalyze.Enabled = false;
                            withBlock.sb_progresslabel.Text = "Uncompressing...";
                            withBlock.sb_progresspercent.Visible = true;
                            withBlock.CompResultsPanel.Visible = false;
                            withBlock.submitToWiki.Visible = false;
                            break;
                        }

                    case "A":
                        {
                            withBlock.IsQueryMode1 = true;
                            withBlock.btnCompress.Visible = false;
                            withBlock.btnAnalyze.Enabled = false;
                            withBlock.sb_progresslabel.Text = "Analyzing...";
                            withBlock.sb_progressbar.Width = 0;
                            withBlock.sb_Panel.Visible = true;
                            withBlock.sb_AnalysisPanel.Visible = true;
                            withBlock.AllFiles.Clear();
                            withBlock.TreeData.Clear();
                            break;
                        }
                }

                withBlock.TabControl1.SelectedTab = withBlock.ProgressPage;
                withBlock.TableLayoutPanel4.Location = new Point(7, 24);
                withBlock.TableLayoutPanel4.Height = withBlock.TableLayoutPanel4.Height + 30;
            }
        }

        public static void ActionCompleted(string Mode, bool AnalysisShowsFolderIsCompressed = true)
        {
            {
                Compact withBlock = My.MyProject.Forms.Compact;
                switch (Mode)
                {
                    case "C":
                        {
                            withBlock.returnArrow.Visible = true;
                            withBlock.btnAnalyze.Enabled = true;
                            withBlock.btnUncompress.Visible = true;
                            withBlock.IsActive1 = false;
                            break;
                        }

                    case "U":
                        {
                            withBlock.returnArrow.Visible = true;
                            withBlock.btnAnalyze.Enabled = true;
                            withBlock.btnUncompress.Visible = false;
                            withBlock.sb_ResultsPanel.Visible = false;
                            withBlock.sb_progresslabel.Text = "Finished Uncompressing";
                            break;
                        }

                    case "A":
                        {
                            if (AnalysisShowsFolderIsCompressed)
                            {
                                withBlock.sb_progresslabel.Text = "This Folder Contains Compressed Files";
                                withBlock.sb_labelCompressed.Text = "Compressed";
                                withBlock.btnUncompress.Visible = true;
                                withBlock.CompResultsPanel.Visible = true;
                                withBlock.submitToWiki.Visible = true;
                                withBlock.sb_ResultsPanel.Visible = true;
                            }
                            else
                            {
                                withBlock.sb_progresslabel.Text = "This Folder is Not Compressed";
                                withBlock.btnUncompress.Visible = false;
                            }

                            withBlock.returnArrow.Visible = true;
                            withBlock.IsQueryMode1 = false;
                            break;
                        }
                }

                withBlock.TableLayoutPanel4.Location = new Point(7, 54);
                withBlock.TableLayoutPanel4.Height = withBlock.TableLayoutPanel4.Height - 30;
                withBlock.IsActive1 = false;
                withBlock.GetWorkingList().Clear();
            }
        }
    }
}