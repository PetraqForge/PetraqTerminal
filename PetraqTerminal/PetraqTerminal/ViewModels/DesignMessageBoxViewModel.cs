using System;
using System.Collections.Generic;
using PetraqTerminal.Models;
using ReactiveUI;

namespace PetraqTerminal.ViewModels
{
    public class DesignMessageBoxViewModel : MessageBoxViewModel
    {
        public DesignMessageBoxViewModel()
            : base(new SimpleMessage("Lirillirlrllrlrlrlrlrlrlrllrrirlrirlrirkì Larilà, elefante nel deserto che cammina qua e là. Con la sua conchiglia e un orologio che fa tic tac, le spine del cactus mi fanno un attacco flashback. Arriva zio Ramon su una mongolfiera blu, gridando: \"Ma che fai lì? T i piace pure il WiFi, tu?\" Io rispondo senza fiato: \"cerco solo di capire perché un cactus con sandali si possa anche vestire!\"",
                "bot"
            )) {}
    }
}