﻿using System.ComponentModel.Composition;
using Altman.Plugin;

namespace Plugin_DbManager
{
    [PartCreationPolicy(CreationPolicy.NonShared)]
    [Export(typeof(IPlugin))]
    public class Plugin : IControlPlugin
    {
        private object _userControl;
        private PluginInfo _pluginInfo;
        private IPluginSetting _pluginSetting;
		[Import(typeof(IHost))]
        private IHost _host;

        public Plugin()
        {
            _pluginInfo = new PluginInfo();
            _pluginSetting = new PluginSetting();
        }

        public IPluginInfo PluginInfo
        {
            get { return _pluginInfo; }
        }

        public IPluginSetting PluginSetting
        {
            get { return _pluginSetting; }
        }

        public object LoadGui(PluginParameter data)
        {
            return _userControl = new DbManagerPanel(_host, data);
        }

        public void Dispose()
        {
	        _userControl = null;
        }
    }
}
