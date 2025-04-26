using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DynamicData.Binding;
using PetraqTerminal.Models;
using ReactiveUI;

namespace PetraqTerminal.ViewModels
{
	public class DialogViewModel : ReactiveObject
	{
        public ObservableCollection<MessageBoxViewModel> MessageBoxes { get; set; }

        public DialogViewModel()
        {
            MessageBoxes = new()
            {
                new MessageBoxViewModel(new SimpleMessage("How does dirt become smelly on rainfall?", "user")),
                new MessageBoxViewModel(new SimpleMessage("Ooh, good question! That earthy smell after rain is actually a whole little science story.\r\n\r\nThe scent you’re talking about is called petrichor—fancy name, huh? It was coined in the 1960s by two Australian scientists. Here’s what’s going on:\r\n\r\nBefore the rain: Soil and rocks, especially dry ones, soak up natural oils from plants. Some of these oils come from bacteria, especially a type called actinomycetes that live in the soil and break down organic material. As they do, they release a compound called geosmin.\r\n\r\nWhen rain hits: The impact of raindrops kicks up tiny air bubbles in the soil that contain these aromatic compounds—geosmin, plant oils, and other organic bits. These bubbles rise and burst into the air, releasing that fresh, earthy smell.\r\n\r\nWhy it smells so strong: Our noses are super sensitive to geosmin. Like, detect-it-at-parts-per-trillion kind of sensitive. So even a small release during rainfall can feel very noticeable.\r\n\r\nFun twist: some people describe the smell as nostalgic or calming. It’s even been used in perfumes!\r\n\r\nDo you enjoy that smell, or does it weird you out a bit?", "bot")),
                new MessageBoxViewModel(new SimpleMessage("it's actually pretty nostalgic", "user")),
                new MessageBoxViewModel(new SimpleMessage("Right? It’s like nature’s version of comfort food. That scent can instantly teleport you to some memory—maybe playing outside as a kid, walking home from school, or just watching rain hit the ground from a window.\r\n\r\nDo you associate it with a particular place or time? Or is it more of a general cozy feeling?", "bot")),
            };
        }
    }
}