using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using dev.pages;


namespace dev.pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Jogo : CarouselPage
    {
        public void atualizaVendinha()
        {
            vendinha.Items[0] = "Carvão " + val[0];
            vendinha.Items[1] = "Pilula do suicidio " + val[1];
            vendinha.Items[2] = "Faca " + val[2];
            vendinha.Items[3] = "Pistola " + val[3];
            vendinha.Items[4] = "Granada " + val[4];
            vendinha.Items[5] = "Maçã dourada " + val[5];
            vendinha.Items[6] = "CG Titan 100cc " + val[6];
        }
        public static double din = 0;
        public static double[] val = { 1, 20, 50, 100, 200, 1000, 2000 };
        List<string> cartaspuxadas = new List<string>();
        public Jogo()
        {
            InitializeComponent();

            vendinha.Items.Add("Carvão " + val[0]);
            vendinha.Items.Add("Pilula do suicidio " + val[1]);
            vendinha.Items.Add("Faca " + val[2]);
            vendinha.Items.Add("Pistola " + val[3]);
            vendinha.Items.Add("Granada " + val[4]);
            vendinha.Items.Add("Maçã dourada " + val[5]);
            vendinha.Items.Add("CG Titan 100cc " + val[6]);
        }
        string[] efeitos = {"Imitação",
                            "Conjunto de roupas extra",
                            "O chão é lava",
                            "Alejado",
                            "Movintando com D4",
                            "Movintando com D8",
                            "Lingua do P!",
                            "Camera Lenta",
                            "Estatua!",
                            "Tá ansioso filhão?",
                            "Três pares de meia",
                            "Coringa",
                            "O oposto do que você quer dizer",
                            "O gato comeu sua lingua?",
                            "Luz... Camera... Ah não!!",
                            "Sussurrando",
                            "Galinha! PoPoPo!",
                            "Fale sua frase e repita. Fale sua frase e repita.",
                            "Tá frio né?",
                            "Sotaque não... dialeto!",
                            "No ritmo do Hino!",
                            "Uga Buga! Você falar igual homem das cavernas!",
                            "Falando linguas!",
                            "Decorando o roteiro!" };
        private void puxar(object sender, EventArgs args)
        {
            void infla(int inf)
            {
                for (int cont = 0; cont < val.Length; cont++)
                {
                    val[cont] *= inf;
                }
                atualizaVendinha();
            }
            void dinfla(int dinf)
            {
                for (int cont = 0; cont < val.Length; cont++)
                {
                    val[cont] /= dinf;
                }
                atualizaVendinha();
            }

            Random rd = new Random();
            string[] cartas = {
                "Todos os jogadores voltam do começo",
                "Você e sua familia pegam lepra e morrem",
                "Você e sua familia pegam a peste negra e morrem",
                "Você e sua familia pegam covid e morrem",
                "Você e sua familia pegam variola do macaco e morrem",
                "Você e sua familia pegam aids e morrem",
                "Você e sua familia pegam lepra e morrem",
                "Você e sua familia pegam a peste negra e morrem",
                "Você e sua familia pegam covid e morrem",
                "Você e sua familia pegam variola do macaco e morrem",
                "Você e sua familia pegam aids e morrem",
                "Cura! Guarde para depois",
                "Cura! Guarde para depois",
                "Cura! Guarde para depois",
                "Cura! Guarde para depois",
                "Cura! Guarde para depois",
                "Você só pode se comunicar imitando alguem da escolha do grupo. Falhe e volte 2 casas.",
                "Você só pode se comunicar imitando alguem da escolha do grupo. Falhe e volte 2 casas.",
                "Você só pode se comunicar imitando alguem da escolha do grupo. Falhe e volte 2 casas.",
                "Você só pode se comunicar imitando alguem da escolha do grupo. Falhe e volte 2 casas.",
                "Tudo na loja custa 2x mais!",
                "Tudo na loja custa 10x mais!",
                "Tudo na loja custa 2x menos!",
                "Tudo na loja custa 10x menos!",
                "Tudo na loja custa 2x mais!",
                "Tudo na loja custa 10x mais!",
                "Tudo na loja custa 2x menos!",
                "Tudo na loja custa 10x menos!",
                "Tudo na loja custa 2x mais!",
                "Tudo na loja custa 10x mais!",
                "Tudo na loja custa 2x menos!",
                "Tudo na loja custa 10x menos!",
                "Tenha o direito de abrir a loja sem estar nela!",
                "Tenha o direito de abrir a loja sem estar nela!",
                "Tenha o direito de abrir a loja sem estar nela!",
                "Tenha o direito de abrir a loja sem estar nela!",
                "Nada aconteceu...",
                "Nada aconteceu...",
                "Nada aconteceu...",
                "Nada aconteceu...",
                "Nada aconteceu...",
                "Nada aconteceu...",
                "Nada aconteceu...",
                "Nada aconteceu...",
                "Jogue Jó-Ken-Pô com um jogador da sua escolha. O perdedor volta 5 casas.",
                "Todos os jogadores dividem o dinheiro que tem entre si.",
                "Todos os jogadores dão seu dinheiro pra você.",
                "Avance 5 quadrantes!",
                "Volte 5 quadrantes",
                "Avance 5 quadrantes!",
                "Volte 5 quadrantes",
                "Avance 5 quadrantes!",
                "Volte 5 quadrantes",
                "Tome um gole da coisa mais picante no recinto ou volte 10 casas!",
                "Pegue um cubo de gelo e mastigue ou volte 10 casas!",
                "Beba 5 copos de água ou volte 10 casas.",
                "Coloque mais um conjunto de roupas em si até o final do jogo. Tire e volte do começo.",
                "Encostar no chão resulta na sua morte.",
                "Você só pode se movimentar um quadrante por vez!",
                "Use um D4 para se movimentar!",
                "Use um D8 para se movimentar!",
                "Fale somente na lingua do P! Erre e volte 10 casas!",
                "Tudo que você fizer deve ser feito muuuuito lentameeeente",
                "Você não pode parar de se movimentar por 4 rounds ou volte 20 casas.",
                "Você não pode se mexer por 4 rounds ou volte 20 casas.",
                "Coloque três pares de meia.",
                "Fique 1 minuto sem piscar ou volte 20 casas",
                "Fique sem respirar por 1 minuto e 30 segundos ou volte 20 casas.",
                "Faça 20 flexões ou volte 20 casas",
                "Faça 50 agachamentos ou volte 20 casas",
                "Faça 50 abdominais ou volte 20 casas",
                "Você foi roubado. Zere seu dinheiro.",
                "Tudo que você falar deve terminar com uma risada louca. Erre e volte 5 casas.",
                "Fale o oposto do que você quer dizer. Erre e volte 5 casas.",
                "Liste todos os filmes de uma saga que o jogador da esquerda escolher. Erre e volte 10 casas",
                "O jogador a sua esquerda fará uma pergunta referente a numeros. Quem chegar mais perto não volta 10 casas",
                "Escolha alguem para compartilhar todos os efeitos que você tem.",
                "Escolha alguem para passar todos os seus efeitos.",
                "Troque seus efeitos com os de alguém",
                "Escolha alguem para trocar de posição com essa pessoa.",
                "Apague pelo menos 20 contatos do seu celular ou volte do começo.",
                "Não pode falar até morrer.",
                "Instale Flappy Bird e atinga 20 pontos de primeira, morra e volte o numero de pontos que faltava para você alcançar",
                "Faça uma partida de tente não rir com alguem da sua escolha. Vocês tem 2 minutos pra fazer um ou o outro rir. Quem perder volta tudo, empate os dois voltam",
                "Deixei seu celular gravando até você morrer.",
                "Coma ou beba 5 algo doce (copos ou unidades) ou volte 15 casas.",
                "Você só pode falar sussurrando, fale alto e volte 5 casas",
                "Coma algo cru (frutas e legumes não contam) ou volte do começo",
                "Você só pode se comunicar como uma galinha. Volte 5 casas a cada erro.",
                "Fala sua frase e repita ela. Volte 5 casas a cada erro.",
                "Conte uma piada pro grupo, se ninguem rir volte do começo",
                "Se cubra com um cobertor até o fim do jogo. Tire e volte 10 casas",
                "Coma 5 de algo salgado (colheres de sal conta) ou volte 15 casas",
                "Peça para o jogador da direitar falar um ingrediente e o da esquerda outro. Misture e coma. Não faça isso e volte tudo.",
                "Você só pode se comunicar com um sotaque que o jogador da esquerda escolher. Volte 5 casas a cada erro",
                "Nada acontece! Volte uma casa",
                "Limpe um efeito negativo seu",
                "Volte tudo :D",
                "Tudo que você falar deve ser ritmo do hino nacional",
                "Role o dado. Se cair mais que a metade, volte esse numero. Se cair menos, avance esse numero",
                "Só se comunique como um homem das cavernas. Volte 5 casas a cada erro.",
                "O jogador da esquerda irá tocar 1 segundo de uma musica, advinhe ou volte 10 casas",
                "Vá até a janela e grite. Ou volte 10 casas",
                "O jogador da esquerda irá fazer numeros atrás de sua mão, advinhe ou volte 10 casas.",
                "Faça 100 polichinelos ou volte tudo",
                "Desenhe algo que o jogador da esquerda pedir em 20 segundos. Os outros julgarão se você deve voltar 10 casas ou avançar 1",
                "Você só pode se comunicar na lingua que o jogador da esquerda decidir. Use o google tradutor, mas leia a tradução",
                "Fale somente com trechos do filme que o jogador da esquerda decidir.",
                "Você ganha uma asa delta! Avance 3 casas.",
                "Convide outro jogador para um duelo de polegar. Quem perder volta 5 casas.",
                "Você encontrou um atalho secreto! Avance 5 casas.",
                "Você tropeça e cai. Volte 2 casas.",
                "Fique na ponta dos pés por 1 minuto. Volte 10 casas se cair.",
                "Troque de lugar com o jogador à sua direita!",
                "O jogador à sua esquerda escolhe uma palavra. Você precisa falar apenas usando palavras que rimam com ela. Erre e volte 5 casas.",
                "Você se deparou com um portal mágico! Avance 5 casas.",
                "Cante uma música famosa. Se os outros jogadores não adivinharem qual é em 5 segundos, volte 5 casas.",
                "Se torne o juiz de uma competição de dança entre os jogadores. Aquele com a melhor dança não volta do começo",
                "Crie um desafio físico para outro jogador. Se ele fizer e não terminar ofegante, vocês dois voltam 15 casas. Se ele fizer e terminar ofegante avancem 3 casas",
                "Faça uma imitação de um animal escolhido pelo jogador à sua direita. Se o jogador da esquerda não reconhecer, volte 10 casas.",
                "De repente, todos os jogadores mudam de corpo! Troquem de lugar com o jogador a suas esquerda e continuem jogando.",
                "Você recebe uma carta de sorte! Avance o número de casas correspondente ao resultado de um dado.",
                "Um raio mágico o transforma em uma estátua por um turno. Pule a sua próxima rodada.",


                "Todos os jogadores voltam do começo",
                "Você e sua familia pegam lepra e morrem",
                "Você e sua familia pegam a peste negra e morrem",
                "Você e sua familia pegam covid e morrem",
                "Você e sua familia pegam variola do macaco e morrem",
                "Você e sua familia pegam aids e morrem",
                "Você e sua familia pegam lepra e morrem",
                "Você e sua familia pegam a peste negra e morrem",
                "Você e sua familia pegam covid e morrem",
                "Você e sua familia pegam variola do macaco e morrem",
                "Você e sua familia pegam aids e morrem",
                "Cura! Guarde para depois",
                "Cura! Guarde para depois",
                "Cura! Guarde para depois",
                "Cura! Guarde para depois",
                "Cura! Guarde para depois",
                "Você só pode se comunicar imitando alguem da escolha do grupo. Falhe e volte 2 casas.",
                "Você só pode se comunicar imitando alguem da escolha do grupo. Falhe e volte 2 casas.",
                "Você só pode se comunicar imitando alguem da escolha do grupo. Falhe e volte 2 casas.",
                "Você só pode se comunicar imitando alguem da escolha do grupo. Falhe e volte 2 casas.",
                "Tudo na loja custa 2x mais!",
                "Tudo na loja custa 10x mais!",
                "Tudo na loja custa 2x menos!",
                "Tudo na loja custa 10x menos!",
                "Tudo na loja custa 2x mais!",
                "Tudo na loja custa 10x mais!",
                "Tudo na loja custa 2x menos!",
                "Tudo na loja custa 10x menos!",
                "Tudo na loja custa 2x mais!",
                "Tudo na loja custa 10x mais!",
                "Tudo na loja custa 2x menos!",
                "Tudo na loja custa 10x menos!",
                "Tenha o direito de abrir a loja sem estar nela!",
                "Tenha o direito de abrir a loja sem estar nela!",
                "Tenha o direito de abrir a loja sem estar nela!",
                "Tenha o direito de abrir a loja sem estar nela!",
                "Jogue Jó-Ken-Pô com um jogador da sua escolha. O perdedor volta 5 casas.",
                "Todos os jogadores dividem o dinheiro que tem entre si.",
                "Todos os jogadores dão seu dinheiro pra você.",
                "Avance 5 quadrantes!",
                "Volte 5 quadrantes",
                "Tome um gole da coisa mais picante no recinto ou volte 10 casas!",
                "Pegue um cubo de gelo e mastigue ou volte 10 casas!",
                "Beba 5 copos de água ou volte 10 casas.",
                "Coloque mais um conjunto de roupas em si até o final do jogo. Tire e volte do começo.",
                "Encostar no chão resulta na sua morte.",
                "Você só pode se movimentar um quadrante por vez!",
                "Use um D4 para se movimentar!",
                "Use um D8 para se movimentar!",
                "Fale somente na lingua do P! Erre e volte 10 casas!",
                "Tudo que você fizer deve ser feito muuuuito lentameeeente",
                "Você não pode parar de se movimentar por 4 rounds ou volte 20 casas.",
                "Você não pode se mexer por 4 rounds ou volte 20 casas.",
                "Coloque três pares de meia.",
                "Fique 1 minuto sem piscar ou volte 20 casas",
                "Fique sem respirar por 1 minuto e 30 segundos ou volte 20 casas.",
                "Faça 20 flexões ou volte 20 casas",
                "Faça 50 agachamentos ou volte 20 casas",
                "Faça 50 abdominais ou volte 20 casas",
                "Você foi roubado. Zere seu dinheiro.",
                "Tudo que você falar deve terminar com uma risada louca. Erre e volte 5 casas.",
                "Fale o oposto do que você quer dizer. Erre e volte 5 casas.",
                "Liste todos os filmes de uma saga que o jogador da esquerda escolher. Erre e volte 10 casas",
                "O jogador a sua esquerda fará uma pergunta referente a numeros. Quem chegar mais perto não volta 10 casas",
                "Escolha alguem para compartilhar todos os efeitos que você tem.",
                "Escolha alguem para passar todos os seus efeitos.",
                "Troque seus efeitos com os de alguém",
                "Escolha alguem para trocar de posição com essa pessoa.",
                "Apague pelo menos 20 contatos do seu celular ou volte do começo.",
                "Não pode falar até morrer.",
                "Instale Flappy Bird e atinga 20 pontos de primeira, morra e volte o numero de pontos que faltava para você alcançar",
                "Faça uma partida de tente não rir com alguem da sua escolha. Vocês tem 2 minutos pra fazer um ou o outro rir. Quem perder volta tudo, empate os dois voltam",
                "Deixei seu celular gravando até você morrer.",
                "Coma ou beba 5 algo doce (copos ou unidades) ou volte 15 casas.",
                "Você só pode falar sussurrando, fale alto e volte 5 casas",
                "Coma algo cru (frutas e legumes não contam) ou volte do começo",
                "Você só pode se comunicar como uma galinha. Volte 5 casas a cada erro.",
                "Fala sua frase e repita ela. Volte 5 casas a cada erro.",
                "Conte uma piada pro grupo, se ninguem rir volte do começo",
                "Se cubra com um cobertor até o fim do jogo. Tire e volte 10 casas",
                "Coma 5 de algo salgado (colheres de sal conta) ou volte 15 casas",
                "Peça para o jogador da direitar falar um ingrediente e o da esquerda outro. Misture e coma. Não faça isso e volte tudo.",
                "Você só pode se comunicar com um sotaque que o jogador da esquerda escolher. Volte 5 casas a cada erro",
                "Nada acontece! Volte uma casa",
                "Limpe um efeito negativo seu",
                "Volte tudo :D",
                "Tudo que você falar deve ser ritmo do hino nacional",
                "Role o dado. Se cair mais que a metade, volte esse numero. Se cair menos, avance esse numero",
                "Só se comunique como um homem das cavernas. Volte 5 casas a cada erro.",
                "O jogador da esquerda irá tocar 1 segundo de uma musica, advinhe ou volte 10 casas",
                "Vá até a janela e grite. Ou volte 10 casas",
                "O jogador da esquerda irá fazer numeros atrás de sua mão, advinhe ou volte 10 casas.",
                "Faça 100 polichinelos ou volte tudo",
                "Desenhe algo que o jogador da esquerda pedir em 20 segundos. Os outros julgarão se você deve voltar 10 casas ou avançar 1",
                "Você só pode se comunicar na lingua que o jogador da esquerda decidir. Use o google tradutor, mas leia a tradução",
                "Fale somente com trechos do filme que o jogador da esquerda decidir.",
                "Você ganha uma asa delta! Avance 3 casas.",
                "Convide outro jogador para um duelo de polegar. Quem perder volta 5 casas.",
                "Você encontrou um atalho secreto! Avance 5 casas.",
                "Você tropeça e cai. Volte 2 casas.",
                "Fique na ponta dos pés por 1 minuto. Volte 10 casas se cair.",
                "Troque de lugar com o jogador à sua direita!",
                "O jogador à sua esquerda escolhe uma palavra. Você precisa falar apenas usando palavras que rimam com ela. Erre e volte 5 casas.",
                "Você se deparou com um portal mágico! Avance 5 casas.",
                "Cante uma música famosa. Se os outros jogadores não adivinharem qual é em 5 segundos, volte 5 casas.",
                "Se torne o juiz de uma competição de dança entre os jogadores. Aquele com a melhor dança não volta do começo",
                "Crie um desafio físico para outro jogador. Se ele fizer e não terminar ofegante, vocês dois voltam 15 casas. Se ele fizer e terminar ofegante avancem 3 casas",
                "Faça uma imitação de um animal escolhido pelo jogador à sua direita. Se o jogador da esquerda não reconhecer, volte 10 casas.",
                "De repente, todos os jogadores mudam de corpo! Troquem de lugar com o jogador a suas esquerda e continuem jogando.",
                "Você recebe uma carta de sorte! Avance o número de casas correspondente ao resultado de um dado.",
                "Um raio mágico o transforma em uma estátua por um turno. Pule a sua próxima rodada."

           };
            int qtd = 0;
            foreach (string carta in cartas)
            {
                qtd++;
            }

            int i = rd.Next(0, qtd);
            DisplayAlert("Carta #" + i.ToString(), cartas[i], "OK");

            puxou(cartas[i]);

            if (i == 20 || i == 24 || i == 28 || i == 128 || i == 132 || i == 136)
            {
                infla(2);
            }
            if (i == 21 || i == 25 || i == 29 || i == 129 || i == 133 || i == 137)
            {
                infla(10);
            }
            if (i == 22 || i == 26 || i == 30 || i == 130 || i == 134 || i == 138)
            {
                dinfla(2);
            }
            if (i == 23 || i == 27 || i == 31 || i == 131 || i == 135 || i == 139)
            {
                dinfla(10);
            }


        }

        private void crtpxd(object sender, EventArgs args)
        {
            Navigation.PushAsync(new cartaspux(puxou()));
        }
        private void events(object sender, EventArgs args)
        {
            Navigation.PushAsync(new events(efeitos));
        }

        public string[] puxou(string crtpxda)
        {
            cartaspuxadas.Add(crtpxda);
            string[] enzoo = cartaspuxadas.ToArray();
            return enzoo;
        }
        public string[] puxou()
        {
            string[] enzoo = cartaspuxadas.ToArray();
            return enzoo;
        }
        public void adin(double dinheiro)
        {
            money.Text = "Seu dinheiro: " + dinheiro.ToString() + "$";
            moneyv.Text = "Seu dinheiro: " + dinheiro.ToString() + "$";
        }
        private void addd(Object sender, EventArgs args)
        {

            din += 10;
            adin(din);
        }
        private void add(Object sender, EventArgs args)
        {
            if (Convert.ToInt32(pmoney.Text) < 100000)
            {
                din += Convert.ToInt32(pmoney.Text);
                adin(din);
            }
            else
            {
                DisplayAlert("Vai com calma!", "Você está tentando adicionar muito dinheiro... vá com calma", "OK");
            }
        }
        private void roubs(Object sender, EventArgs args)
        {
            din = 0;
            adin(din);
        }
        private void comprar(Object sender, EventArgs args)
        {

            int op = vendinha.SelectedIndex;
            void check(double preco, double dinheiro)
            {
                if (preco > dinheiro)
                {
                    DisplayAlert("Pobre!", "Não foi possivel comprar: Dinheiro insuficiente", "OK");
                }
                else
                {
                    DisplayAlert("Tá podendo!", "Item comprado com sucesso!", "OK");
                    inventario.Items.Add(vendinha.SelectedItem.ToString());
                    adin(din -= preco);
                }

            }
            switch (op)
            {
                case 0:
                    check(val[op], din);
                    break;
                case 1:
                    check(val[op], din);
                    break;
                case 2:
                    check(val[op], din);
                    break;
                case 3:
                    check(val[op], din);
                    break;
                case 4:
                    check(val[op], din);
                    break;
                case 5:
                    check(val[op], din);
                    break;
                case 6:
                    check(val[op], din);
                    break;
                case 7:
                    check(val[op], din);
                    break;

            }

        }
        private void usar(Object sender, EventArgs args)
        {
            if (inventario.SelectedItem == null)
            {
                DisplayAlert("Burro!", "Você não tem nenhum item selecionado!", "OK");



            }
            else
            {
                DisplayAlert("Sucesso!", "Item utilizado: " + inventario.SelectedItem.ToString(), "OK");
                inventario.Items.Remove(inventario.SelectedItem.ToString());
            }

        }
        private void info(Object sender, EventArgs args)
        {
            int op = vendinha.SelectedIndex;
            switch (op)
            {
                case 0:
                    DisplayAlert("Carvão", "Role um D4. Se cair 4 você está curado de um de seus efeitos, qualquer outro numero resulta em infecção alimentar (Volte 5 casas)", "OK");
                    break;
                case 1:
                    DisplayAlert("Pilula do suicidio", "Morra. Limpe seus efeitos mas volte  do começo.", "OK");

                    break;
                case 2:
                    DisplayAlert("Faca", "Ataque o jogador que estiver no seu quadrante e faça ele voltar 5 casas.", "OK");

                    break;
                case 3:
                    DisplayAlert("Pistola", "Ataque o jogador que estiver no seu quadrante e faça ele voltar 15 casas.", "OK");

                    break;
                case 4:
                    DisplayAlert("Granada", "Mate o jogador no seu quadrante e mande esse cabra pro começo do jogo.", "OK");

                    break;
                case 5:
                    DisplayAlert("Maçã Dourada", "Limpe seus efeitos e fique 3 turnos sem puxar cartas brancas.", "OK");

                    break;
                case 6:
                    DisplayAlert("CG Titan 100cc", "É uma moto cara... compre ela e use um D8 para andar.", "OK");

                    break;
                case 7:
                    break;

            }
        }
    }
}
