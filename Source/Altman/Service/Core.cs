﻿using Altman.Forms;
using Altman.Plugin;

namespace Altman.Service
{
    public class Core : IHostCore
    {
        private FormMain _mainForm;
        public Core(FormMain mainForm)
        {
            _mainForm = mainForm;
        }
    }
}
