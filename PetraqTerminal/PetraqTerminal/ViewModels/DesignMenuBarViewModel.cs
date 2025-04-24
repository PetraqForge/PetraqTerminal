using System;
using System.Collections.Generic;
using ReactiveUI;

namespace PetraqTerminal.ViewModels
{
	public class DesignMenuBarViewModel : MenuBarViewModel
	{
        public DesignMenuBarViewModel() : base()
        {
            PanelEndPosition = "Bottom";
            PanelOrientation = "Vertical";
            PanelPosition = "Left";
        }
    }
}