﻿using WindowsLive.Writer.Api;

namespace MyWindowsLiveWriterPlugin
{
    class WintyCodeAreaSettings
    {
        IProperties m_properties;

        private const string FRONT_CODE = "FRONT_CODE";//前缀代码
        private const string BACK_CODE = "BACK_CODE";//后缀代码
        private const string ESCAPE_CODE = "ESCAPE_CODE";//是否转义代码
        private const string REMOVE_BR = "REMOVE_BR"; // 是否把代码中因为复制到live writer产生的<br />去掉

        public const string DEFAULT_FRONT_CODE = "<pre><code>";
        public const string DEFAULT_BACK_CODE = "</code></pre>";
        public const bool   DEFAULT_ESCAPE_CODE = false;
        public const bool DEFAULT_REMOVE_BR = true;

        public WintyCodeAreaSettings(IProperties properties)
        {
            m_properties = properties;
        }

        public string FrontCode
        {
            get
            {
                return m_properties.GetString(FRONT_CODE, DEFAULT_FRONT_CODE);
            }
            set
            {
                m_properties.SetString(FRONT_CODE, value);
            }
        }

        public string BackCode
        {
            get
            {
                return m_properties.GetString(BACK_CODE, DEFAULT_BACK_CODE);
            }
            set
            {
                m_properties.SetString(BACK_CODE, value);
            }
        }

        public bool EscapeCode
        {
            get
            {
                return m_properties.GetBoolean(ESCAPE_CODE, DEFAULT_ESCAPE_CODE);
            }
            set
            {
                m_properties.SetBoolean(ESCAPE_CODE, value);
            }
        }

        public bool RemoveBr {
            get {
                return m_properties.GetBoolean(REMOVE_BR, DEFAULT_REMOVE_BR);
            }
            set {
                m_properties.SetBoolean(REMOVE_BR, value);
            }
        }

    }
}
