using System;
using System.Collections.Generic;
using ReactiveUI;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;


namespace PetraqTerminal.ViewModels
{
	public class MenuBarViewModel : ReactiveObject
	{
        private string _panelOrientation;
        public string PanelOrientation
        {
            get => _panelOrientation;
            set => this.RaiseAndSetIfChanged(ref _panelOrientation, value);
        }

        private string _panelPosition;
        public string PanelPosition
        {
            get => _panelPosition;
            set => this.RaiseAndSetIfChanged(ref _panelPosition, value);
        }

        private string _panelEndPosition;
        public string PanelEndPosition
        {
            get => _panelEndPosition;
            set => this.RaiseAndSetIfChanged(ref _panelEndPosition, value);
        }

        public MenuBarViewModel()
        {
            _panelOrientation = "Vertical";
            _panelPosition = "Left";
            _panelEndPosition = "Bottom";
            SetPanelOrientation();
        }

        private void SetPanelOrientation()
        {
            if (Application.Current!.ApplicationLifetime is ISingleViewApplicationLifetime)
            {
                PanelOrientation = "Horizontal";
                PanelPosition = "Top";
                PanelEndPosition = "Right";
            } else
            {
                PanelOrientation = "Vertical";
                PanelPosition = "Left";
                PanelEndPosition = "Bottom";
            }
        }
	}
}