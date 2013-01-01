using System;
using System.Windows.Forms;

namespace MyWindowsLiveWriterPlugin
{
    partial class SettingForm : Form
    {
        WintyCodeAreaSettings m_settings;

        public SettingForm(WintyCodeAreaSettings settings)
        {
            InitializeComponent();
            //Winty's initialization
            m_settings = settings;
            txtFrontCode.Text = m_settings.FrontCode;
            chkEscapeCode.Checked = m_settings.EscapeCode;
            textBackCode.Text = m_settings.BackCode;
        }

        /*保存设置*/
        private void btnOK_Click(object sender, EventArgs e)
        {
            m_settings.FrontCode = txtFrontCode.Text;
            m_settings.EscapeCode = chkEscapeCode.Checked;
            m_settings.BackCode = textBackCode.Text;

            Close();
        }

        /*恢复默认设置*/
        private void btnRestoreDefault_Click(object sender, EventArgs e)
        {
            m_settings.FrontCode = WintyCodeAreaSettings.DEFAULT_FRONT_CODE;
            m_settings.EscapeCode = WintyCodeAreaSettings.DEFAULT_ESCAPE_CODE;
            m_settings.BackCode = WintyCodeAreaSettings.DEFAULT_BACK_CODE;

            txtFrontCode.Text = m_settings.FrontCode;
            chkEscapeCode.Checked = m_settings.EscapeCode;
            textBackCode.Text = m_settings.BackCode;
        }
    }
}
