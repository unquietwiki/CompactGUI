using CompactGUI.My.Resources;
using System.Drawing;

namespace CompactGUI
{
    internal static class CommmonActions
    {
        public static void PrepareforCompact()
        {
            {
                Compact withBlock = My.MyProject.Forms.Compact;
                withBlock.btnAnalyze.Enabled = true;
                withBlock.btnReturn.Visible = false;
                withBlock.checkShutdownOnCompletion.Checked = false;
                withBlock.CompResultsPanel.Visible = false;
                withBlock.btnSubmitToWiki.Visible = false;
                withBlock.AnalysisPanel.Visible = false;
                withBlock.sb_ResultsPanel.Visible = false;
                withBlock.TabControl1.SelectedTab = withBlock.InputPage;
                withBlock.lblCompressed.Text = Resources.StrEstComp;
            }
        }

        public static void ActionBegun(Compact.ActionMode Mode)
        {
            {
                Compact withBlock = My.MyProject.Forms.Compact;

                // Defaults
                withBlock.IsActive = true;
                withBlock.IsQueryMode = false;
                withBlock.btnAnalyze.Enabled = false;
                withBlock.lblProgressPercent.Visible = true;

                // Adjustments
                switch (Mode)
                {
                    case Compact.ActionMode.Compact:
                        {
                            withBlock.lblActivityProgress.Text = Resources.StrWaitComp;
                            withBlock.AnalysisPanel.Visible = true;
                            break;
                        }

                    case Compact.ActionMode.UnCompact:
                        {
                            withBlock.lblActivityProgress.Text = Resources.StrDeComp;
                            withBlock.CompResultsPanel.Visible = false;
                            withBlock.btnSubmitToWiki.Visible = false;
                            break;
                        }

                    case Compact.ActionMode.Analyze:
                        {
                            withBlock.IsActive = false;
                            withBlock.IsQueryMode = true;
                            withBlock.lblActivityProgress.Text = Resources.StrAnalyze;
                            withBlock.ActivityProgressBar.Width = 0;
                            withBlock.AnalysisPanel.Visible = true;
                            withBlock.AllFiles.Clear();
                            withBlock.TreeData.Clear();
                            break;
                        }
                }

                withBlock.TabControl1.SelectedTab = withBlock.ProgressPage;
                withBlock.tlpResultsConsole.Location = new Point(7, 24);
                withBlock.tlpResultsConsole.Height = withBlock.tlpResultsConsole.Height + 30;
            }
        }

        public static void ActionCompleted(Compact.ActionMode Mode, bool AnalysisShowsFolderIsCompressed = true)
        {
            {
                Compact withBlock = My.MyProject.Forms.Compact;

                // Adjustments
                switch (Mode)
                {
                    case Compact.ActionMode.Compact:
                        {
                            withBlock.IsActive = false;
                            Compact.isCompressed = true;
                            break;
                        }

                    case Compact.ActionMode.UnCompact:
                        {
                            withBlock.sb_ResultsPanel.Visible = false;
                            withBlock.lblActivityProgress.Text = Resources.StrFinishDeComp;
                            Compact.isCompressed = false;
                            break;
                        }

                    case Compact.ActionMode.Analyze:
                        {
                            withBlock.btnAnalyze.Enabled = false;
                            if (AnalysisShowsFolderIsCompressed)
                            {
                                withBlock.lblActivityProgress.Text = Resources.StrHasComp;
                                withBlock.lblCompressed.Text = Resources.StrIsComp;
                                withBlock.CompResultsPanel.Visible = true;
                                withBlock.btnSubmitToWiki.Visible = true;
                                withBlock.sb_ResultsPanel.Visible = true;
                                Compact.isCompressed = true;
                            }
                            else
                            {
                                withBlock.lblActivityProgress.Text = Resources.StrHasNoComp;
                                Compact.isCompressed = false;
                            }

                            withBlock.IsQueryMode = false;
                            break;
                        }
                }

                withBlock.btnReturn.Visible = true;
                withBlock.tlpResultsConsole.Location = new Point(7, 54);
                withBlock.tlpResultsConsole.Height = withBlock.tlpResultsConsole.Height - 30;
                withBlock.IsActive = false;
                withBlock.GetWorkingList().Clear();
            }
        }
    }
}