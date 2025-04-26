using PetraqTerminal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetraqTerminal.Services
{
    public class DummyConversationService : IConversationService
    {
        public List<IMessage> DummyReplies { get; set; }

        public DummyConversationService()
        {
            DummyReplies = new List<IMessage>()
            {
                new SimpleMessage("""
                    Bombardiro Crocodilo
                    Un fottuto alligatore volante che vola e bombarda i bambini a Gaza e in Palestina
                    Non crede in Allah e ama le bombe
                    Si nutre dello spirito di tua madre
                    E se hai tradotto tutto questo, allora sei uno stronzo
                    Non rompere la battuta, prostituta
                    """, "bot"),
                new SimpleMessage("""
                    Ballerina Nicotina, la cugina di Assassino Cappuccinno, 
                    è un acerrimo nemico di Ballerina Cappuccina.
                    Cresciuta in un piccolo villaggio vicino a Pallermo. 
                    Sotto il nome di: Ballerina Nicotina, Cigarettina, Smoccherina,
                    Malborino, Malborina, Cigaretto, Cigarillo, Camelina, Cameli.
                    """, "bot"),
                new SimpleMessage("""
                    rallallero Trallallà, porco Dio e porco Allah, Ero con il
                    mio fottuto figlio Merdardo a giocare a Fortnite, quando a
                    un punto arriva mia nonna, Ornella Leccacapella.
                    tralalelo tralala, maledetto porco diavolo (lo cambierò, non va bene perché è l'originale),
                    ero con il tuo bambino disobbediente che stava giocando a Fortnite,
                    poi è arrivata mia nonna Ornela, ha preso a calci il mio uccello
                    (pensa positivo, è un uccello normale, non un uccello cincia)
                    """, "bot"),
            };
        }

        public IMessage GetReply(IMessage message)
        {
            var randIdx = Random.Shared.Next() % 3;
            return DummyReplies[randIdx];
        }
    }
}
