using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoKenPO
{
    internal class Game
    {
        //enum armazena valores constatntes
        public enum Resultado
        {
            Ganhar,Perder,Empatar
        }

        public static Image[] images =
        {
            Image.FromFile("imagens/Pedra.png"),
            Image.FromFile("imagens/Tesoura.png"),
            Image.FromFile("imagens/Papel.png")
        };

        public Image imgPc { get; private set; }
        public Image imgjogador { get; private set; }

        public Resultado Jogar(int jogador)
        {
            int pc = JogadaPC();

            imgPc = images[pc];

            imgjogador = images[jogador];

            if (jogador == pc)
            {
                return Resultado.Empatar;
            }else if((jogador == 0 && pc == 1) || (jogador == 1 && pc == 2))
            {
                return Resultado.Ganhar;
            }
            else
            {
                return Resultado.Perder;
            }

        }

        private int JogadaPC()
        {
            int mil = DateTime.Now.Millisecond;

            if(mil < 333)
            {
                return 0;
            }else if(mil < 666 && mil >= 333)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

    }
}
