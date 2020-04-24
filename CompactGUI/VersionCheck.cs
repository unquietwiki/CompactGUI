using System;
using System.Globalization;
using System.Net;
using System.Xml.Linq;

namespace CompactGUI
{
    internal class VersionCheck
    {
        public static void VC(string version)
        {
            try
            {
                XDocument versionDoc = XDocument.Load("https://raw.githubusercontent.com/ImminentFate/CompactGUI/master/Version.xml");
                if (versionDoc.ToString() != default)
                {
                    //TODO: make sure this works
                    if (Convert.ToBoolean(XMLParse(versionDoc, version),Compact.culture))
                    {
                        My.MyProject.Forms.Compact.updateBanner.Visible = true;
                        My.MyProject.Forms.Compact.dlUpdateLink.Text = "Update Available: Click to download " + Xml_VersionStr;
                        My.MyProject.Forms.Info.LblCheckUpdates.Text = "Update to " + Xml_VersionStr;
                        My.MyProject.Forms.Info.LblCheckUpdates.Visible = true;
                    }
                }
            }
            catch (WebException)
            {
            }
        }

        public static object[] Xml_Fixes { get; set; }
        public static object[] Xml_Changes { get; set; }
        public static bool Xml_IsPrerelease { get; set; }
        public static string Xml_ChocoVStr { get; set; }
        public static string Xml_VersionStr { get; set; }
        public static int Xml_MinorVer { get; set; }
        public static float Xml_MajorVer { get; set; }

        public static object XMLParse(XDocument versionDoc, string version)
        {
            XElement info = versionDoc.Root;
            Xml_MajorVer = float.Parse(info.Element("VersionMajor").Value, CultureInfo.InvariantCulture);
            Xml_MinorVer = Convert.ToInt32(info.Element("VersionMinor").Value, Compact.culture);
            Xml_VersionStr = info.Element("VersionStr").Value;
            Xml_ChocoVStr = info.Element("ChocolateyVStr").Value;
            Xml_IsPrerelease = Convert.ToBoolean(info.Element("IsPrerelease").Value, Compact.culture);
            Xml_Changes = info.Element("Changes").Value.Split('|');
            Xml_Fixes = info.Element("Fixes").Value.Split('|');
            float exe_MajorVer = float.Parse(version.Substring(0, version.LastIndexOf(".", StringComparison.CurrentCultureIgnoreCase)), CultureInfo.InvariantCulture);
            int exe_MinorVer = Convert.ToInt32(version.Substring(version.LastIndexOf(".", StringComparison.CurrentCultureIgnoreCase) + 1), Compact.culture);
            if (Xml_MajorVer > exe_MajorVer)
            {
                return true;
            }
            else if (Xml_MajorVer == exe_MajorVer)
            {
                if (Xml_MinorVer > exe_MinorVer)
                {
                    return true;
                }
            }

            return default;
        }
    }
}