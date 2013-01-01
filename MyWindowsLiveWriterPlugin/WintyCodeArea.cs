using System.Windows.Forms;
using WindowsLive.Writer.Api;
using System.Xml;

/*
2009-10-02

Winty

wintys@gmail.com

http://www.blogjava.net/wintys
  */

namespace MyWindowsLiveWriterPlugin {
    /*Plugin 主类*/
    [WriterPlugin("{7DFB5431-D7DA-4e61-9E4B-056D30DFDB63}",
        "WintyCodeArea",
        PublisherUrl = "http://www.blogjava.net/wintys",
        ImagePath = "image.jpg",
        HasEditableOptions = true,
        Description = "Insert <div class=\"mycode\">your code</div>\nhttp://www.blogjava.net/wintys\nwintys@gmail.com")]
    [InsertableContentSource("WintyCodeArea")]
    public class WintyCodeArea : ContentSource {
        WintyCodeAreaSettings m_settings;

        public override void Initialize(IProperties pluginOptions) {
            base.Initialize(pluginOptions);
            m_settings = new WintyCodeAreaSettings(pluginOptions);
        }

        public override DialogResult CreateContent(IWin32Window dialogOwner, ref string content) {
            if (content.Trim() == "") return DialogResult.Cancel;

            string originalContent = content;

            content = m_settings.FrontCode;

            if (m_settings.EscapeCode)
                content += System.Web.HttpUtility.HtmlEncode(originalContent);
            if (m_settings.RemoveBr)
                content += originalContent
                    .Replace("<P>", "").Replace("</P>", "")
                    .Replace("\r\n", "").Replace("\n", "")
                    .Replace("<BR>", "\n")
                    .Replace("&nbsp;", " ");
            else
                content += originalContent;


            content += m_settings.BackCode;

            return DialogResult.OK;
        }

        public override void EditOptions(IWin32Window dialogOwner) {
            SettingForm settingForm = new SettingForm(m_settings);
            settingForm.ShowDialog(dialogOwner);
        }

    }
}
