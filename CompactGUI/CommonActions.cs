using CompactGUI.My.Resources;
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
                withBlock.sb_labelCompressed.Text = Resources.StrEstComp;
            }
        }

        public static void ActionBegun(Compact.ActionMode Mode)
        {
            {
                Compact withBlock = My.MyProject.Forms.Compact;
                switch (Mode)
                {
                    case Compact.ActionMode.Compact:
                        {
                            withBlock.IsActive = true;
                            withBlock.IsQueryMode = false;
                            withBlock.btnCompress.Visible = false;
                            withBlock.btnAnalyze.Enabled = false;
                            withBlock.sb_progresslabel.Text = Resources.StrWaitComp;
                            withBlock.sb_progresspercent.Visible = true;
                            withBlock.sb_AnalysisPanel.Visible = true;
                            break;
                        }

                    case Compact.ActionMode.UnCompact:
                        {
                            withBlock.IsActive = true;
                            withBlock.IsQueryMode = false;
                            withBlock.btnUncompress.Visible = false;
                            withBlock.btnAnalyze.Enabled = false;
                            withBlock.sb_progresslabel.Text = Resources.StrDeComp;
                            withBlock.sb_progresspercent.Visible = true;
                            withBlock.CompResultsPanel.Visible = false;
                            withBlock.submitToWiki.Visible = false;
                            break;
                        }

                    case Compact.ActionMode.Analyze:
                        {
                            withBlock.IsQueryMode = true;
                            withBlock.btnCompress.Visible = false;
                            withBlock.btnAnalyze.Enabled = false;
                            withBlock.sb_progresslabel.Text = Resources.StrAnalyze;
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

        public static void ActionCompleted(Compact.ActionMode Mode, bool AnalysisShowsFolderIsCompressed = true)
        {
            {
                Compact withBlock = My.MyProject.Forms.Compact;
                switch (Mode)
                {
                    case Compact.ActionMode.Compact:
                        {
                            withBlock.btnAnalyze.Enabled = true;
                            withBlock.btnUncompress.Visible = true;
                            withBlock.IsActive = false;
                            break;
                        }

                    case Compact.ActionMode.UnCompact:
                        {
                            withBlock.btnAnalyze.Enabled = true;
                            withBlock.btnUncompress.Visible = false;
                            withBlock.sb_ResultsPanel.Visible = false;
                            withBlock.sb_progresslabel.Text = Resources.StrFinishDeComp;
                            break;
                        }

                    case Compact.ActionMode.Analyze:
                        {
                            if (AnalysisShowsFolderIsCompressed)
                            {
                                withBlock.sb_progresslabel.Text = Resources.StrHasComp;
                                withBlock.sb_labelCompressed.Text = Resources.StrIsComp;
                                withBlock.btnUncompress.Visible = true;
                                withBlock.CompResultsPanel.Visible = true;
                                withBlock.submitToWiki.Visible = true;
                                withBlock.sb_ResultsPanel.Visible = true;
                            }
                            else
                            {
                                withBlock.sb_progresslabel.Text = Resources.StrHasNoComp;
                                withBlock.btnUncompress.Visible = false;
                            }

                            withBlock.IsQueryMode = false;
                            break;
                        }
                }

                withBlock.returnArrow.Visible = true;
                withBlock.TableLayoutPanel4.Location = new Point(7, 54);
                withBlock.TableLayoutPanel4.Height = withBlock.TableLayoutPanel4.Height - 30;
                withBlock.IsActive = false;
                withBlock.GetWorkingList().Clear();
            }
        }
    }
}