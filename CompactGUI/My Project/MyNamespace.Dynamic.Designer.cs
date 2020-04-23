using System;
using System.ComponentModel;
using System.Diagnostics;

namespace CompactGUI.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            public Compact m_Compact;

            public Compact Compact
            {
                [DebuggerHidden]
                get
                {
                    m_Compact = MyForms.Create__Instance__(m_Compact);
                    return m_Compact;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_Compact)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Compact);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Info m_Info;

            public Info Info
            {
                [DebuggerHidden]
                get
                {
                    m_Info = MyForms.Create__Instance__(m_Info);
                    return m_Info;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_Info)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Info);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public ShutdownDialog m_ShutdownDialog;

            public ShutdownDialog ShutdownDialog
            {
                [DebuggerHidden]
                get
                {
                    m_ShutdownDialog = MyForms.Create__Instance__(m_ShutdownDialog);
                    return m_ShutdownDialog;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_ShutdownDialog)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_ShutdownDialog);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public WikiPopup m_WikiPopup;

            public WikiPopup WikiPopup
            {
                [DebuggerHidden]
                get
                {
                    m_WikiPopup = MyForms.Create__Instance__(m_WikiPopup);
                    return m_WikiPopup;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_WikiPopup)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_WikiPopup);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public WikiSubmission m_WikiSubmission;

            public WikiSubmission WikiSubmission
            {
                [DebuggerHidden]
                get
                {
                    m_WikiSubmission = MyForms.Create__Instance__(m_WikiSubmission);
                    return m_WikiSubmission;
                }

                [DebuggerHidden]
                set
                {
                    if (value == m_WikiSubmission)
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_WikiSubmission);
                }
            }
        }
    }
}