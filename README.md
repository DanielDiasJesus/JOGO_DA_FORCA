
# Jogo da Forca (C#)

Um projeto de um Jogo da Forca feito em C#.

No decorrer deste projeto - _que fiz pois estava com tempo livre antes de ir à faculdade_ - vamos entender, bem por cima, (até porque não é minha intenção ensinar a o desenvolver) o funcionamento essencial de um projeto de mesmo nível ao de um **jogo da forca**.

## ⌚ Antes de iniciar o projeto
First things first, antes de ja ir colocando a mão na massa e codar, precisamos entender as regras e o funcionamento do jogo.

_"Ah, mas é um jogo da forca... As regras são bem intuitivas"_

Sim, realmente é. Mas de qualquer forma é preciso deixar isso bem definido pois quando for de fato programar, possa colocar sua lógica em prática e assim conseguir refletir o máximo das regras do jogo **e até implementar as suas próprias** - _como eu fiz_ - e ter um joguinho ainda mais com a sua cara 😁

É preciso também, definir o que é importante para o funcionamento do jogo. No caso deste projeto, o jogo foi feito com uma interface oriunda do Windows Forms que, a grosso modo, é uma estrutura de interface de usuário (UI) que cria aplicativos de Desktop avançados para Windows através de um designer virtual com mecanismo de edição **_Drag and Drop_** (ou **Arrastar e Soltar**, em português). Se nunca ouviu falar disso, então recomendo pesquisar e estudar um pouco antes de prosseguir, pois este projeto utiliza fortemente de recursos presentes somente nesta estrutura de criação de design.

#### 📖  Regras da Forca
O jogo da forca é composto por regras simples, de acordo com a **Wikipédia**
>O jogo da forca é um jogo em que o jogador tem que acertar qual é a palavra proposta, tendo como dica o número de letras e o tema ligado à palavra. A cada letra errada, é desenhado uma parte do corpo do enforcado. O jogo termina ou com o acerto da palavra ou com o término do preenchimento das partes corpóreas do enforcado.

Para começar o jogo se desenha uma base e um risco correspondente ao lugar de cada letra.
Por exemplo, para a palavra "MELANCIA", se escreve:
M E L A N C I A ------> _ _ _ _ _ _ _ _
>O jogador que tenta adivinhar a palavra deve ir dizendo as letras que podem existir na palavra. Cada letra que ele acerta é escrita no espaço correspondente.

M E L A N C I A ------> _ E _ A _ _ I A
>Caso a letra não exista nessa palavra, desenha-se uma parte do corpo (iniciando pela cabeça, tronco, braços…)

Como no exemplo dessa imagem abaixo
![regra_forca](https://user-images.githubusercontent.com/43553717/159046745-950b5b94-7c13-4cfa-90ea-f06a7c7db333.gif)
**Nesse projeto, o jogador terá apenas 7 chances de tentar acertar a palavra** (_para deixar o jogo um pouco mais emocionante_ 😏).
>O jogo é ganho se a palavra é adivinhada. Caso o jogador não descubra qual palavra é ele que perde.

E eu tomei a liberdade de adicionar mais algumas funcionalidades no jogo, como: 
- a continuidade do jogo (com uma palavra diferente mas do mesmo tema) caso o jogador acerte a palavra atual;
- pontuação acrescidos conforme o jogador acerta as palavras;
- possibilidade de continuar jogar novamente do início caso o jogador perca o jogo;
- possibilidade de troca de palavra para outra do mesmo tema somente uma vez por rodada e na troca o número de tentativas é subtraído por 2;
- pedir até 3 dicas, desde que a quantidade de letras reveladas seja inferior a 3 e que a palavra tenha mais de 4 letras em sua composição.

Você pode tomar a mesma liberdade e definir mais regras - _mas pelo amor de Alan Turing, **nunca mude a essência do jogo**_ - e assim deixá-lo mais divertido.

## 🔧 Colocando a mão na massa
Imagino que deve estar pensando:
>_"Finalmente começamos os tópicos de programação"_

Acalme-se, meu caro leitor. Existem algumas etapas a serem seguidas antes de programar. Essas etapas _- por mais chatas que pareçam -_ fazem parte do desenvolvimento de um sistema (mesmo que indiretamente). Uma hora ou outra vamos nos deparar e ter que lidar com elas no decorrer do projeto.

Como no exemplo da regra acima;
> Caso a letra não exista nessa palavra, desenha-se uma parte do corpo (iniciando pela cabeça, tronco, braços…)

temos que já ter em mente que precisamos das figuras representanda pelo numero de erros do jogador. Se preferir, pode baixar os sprites da internet. Neste projeto, foi desenhado cada sprite em um programa de desenhos muito poderoso _- vulgo paint -_ **para seguir com o tema do design** _- que foi voltada a um contexto e ambientação mais rústica (aguarde os próximos capitulos) -_ primeiro é desenhado a forca, depois a cabeça, o corpo, os braços e as pernas assim por diante como no exemplo abaixo.
|Sprite 1 | Sprite 2| Sprite 3 | Sprite 4| Sprite 5 | Sprite 6| Sprite 7 | Sprite 8 |
|-------- | --------| -------- | --------| -------- | --------| -------- | -------- |
| ![FORCA_0](https://user-images.githubusercontent.com/43553717/159053384-f1a87e4e-46a1-4d8b-a93c-4ae092326553.png) | ![FORCA_1](https://user-images.githubusercontent.com/43553717/159053723-af3b2590-e152-455d-92d3-ff074cdd1986.png) | ![FORCA_2](https://user-images.githubusercontent.com/43553717/159053934-2d270ed9-25a3-4964-9b83-96d0c80c35bf.png) | ![FORCA_3](https://user-images.githubusercontent.com/43553717/159053979-55146a90-d931-4321-8b22-5e42fef1cec0.png) | ![FORCA_4](https://user-images.githubusercontent.com/43553717/159054199-5e333f97-3c74-4c6a-af62-c151a89cef2c.png) | ![FORCA_5](https://user-images.githubusercontent.com/43553717/159054225-64e3babb-3503-4c3e-a6a5-17a1f597946f.png) | ![FORCA_6](https://user-images.githubusercontent.com/43553717/159054263-8bd1311f-5507-4bab-9dfe-0f851212f197.png) | ![FORCA_7](https://user-images.githubusercontent.com/43553717/159054364-36492481-c6ff-4691-9a40-324f0eac3c93.png)

_-Lembrando que, para facilitar a programação, cada sprite deve ser salva em arquivos diferentes._

Logo após ter as sprites, é hora de criar uma interface legal para o jogo. Como dito anteriormente, a primícia do design deste projeto foi algo mais rustico, como um jogo desenhado a lapis em um caderno. Nada muito complexo ou imaginado. Como é mostrado nos exemplos abaixo.
![INTERFACE_JOGO_FORCA_4](https://user-images.githubusercontent.com/43553717/159720175-3bf34692-fda1-40c1-bf49-6014d67ba87b.jpg)   ![INTERFACE_JOGO_FORCA_3](https://user-images.githubusercontent.com/43553717/159079515-7f2011cc-5965-4bcb-a50c-c8b801eb2717.jpg) 
![INTERFACE_JOGO_FORCA_5](https://user-images.githubusercontent.com/43553717/159725740-0b1e1b17-b285-4c17-87a1-7eb2f51eae02.jpg)


_- novamente volto a reforçar que a intenção deste artigo não é ensinar a desenvolver o projeto, e sim passar o seu funcionamento a limpo e tornar visual o que para quem for visualizar este repositório sem a necessidade de fuçar pelo repositório._

## 💻 Coding Time
Finalmente! Chegamos no tópico tão esperado deste projeto. a **PROGRAMAÇÃO** do jogo. A parte onde daremos vida ao nosso projeto.
A programação deste projeto _- como de qualquer outro que envolva programação -_ foi dividida em 3 partes (como é possível ver na interface desse programa na imagem acima):
- Definição de necessidades do código;
- Entrada de dados;
- Processamento e manipulação dos dados de entrada;
- Retorno da saída dos dados processados.

##### 📝 Definição de necessidades do código
Esta etapa diz respeito a todas as propriedades e funcionalidades que serão essenciais para o funcionamento do código, tais como o numero de tentativas do jogador, sua quantidade de acertos, o máximo de tentativas permitidas pelo programa, quantidade de pontos e as localizações das sprites de cada erro do jogador e entre outras. Confira na imagem abaixo como esse projeto define essas necessidades:
![CODING_DEFINICAO_NECESSIDADE_1](https://user-images.githubusercontent.com/43553717/159718257-01047ebf-e805-44ca-a720-4d0dbf4a3dc4.jpg)

A propriedade mais importante para definir qual sera a ``palavraAtual``, no contexto das regras deste projeto, seria **o tema da palavra esolhida**. No caso deste projeto, **o tema da palavra gerada é definido de acordo com a escolha do usuário na primeira vez que iniciar o jogo** através da interface "ESCOLHA UM TEMA" definida na primeira imagem de exemplo de criação da interface citado anteriormente. Em sumo, o jogador escolhe um tema e este tema será atribuido à variavel ``temaAtual``.

Todas as vezes que o programa inicializar, deve criar um novo jogo com estas mesmas propriedades inicializadas de acordo com as regras. Esta parte da programação deste projeto está definido pela função ``novoJogo()`` conforme a imagem abaixo;
![CODING_DEFINICAO_NECESSIDADE_2](https://user-images.githubusercontent.com/43553717/160299173-00ed0cb1-4156-492e-8e59-bf98cd216dd0.jpg)

Resumidamente, esta função é responsável por inicializar um novo jogo (indiferente de ser a primeira vez do jogador) e **atribui às propriedades de inicialização definidas na interface e tratadas pelo programa (como é visto nas três primeiras linhas da função) os seus devidos valores**, isso porque essa função é dinâmica e não é chamada somente na inicialização e sim em varios outros momentos no decorrer do programa. Logo após uma nova palavra é gerada através do método ``gerarPalavra()`` e **é atribuida a palavra atual através de uma busca e escolha aleatória em uma das listas de palavras (separadas pelos temas disponíveis) salvos em arquivos de textos diferentes** conforme mostrado na imagem abaixo.
![CODING_DEFINICAO_NECESSIDADE_4](https://user-images.githubusercontent.com/43553717/159729317-7ba6e375-00a6-4374-bda5-6918d2cf7838.jpg)
Repare que, ao atribuir o nome do arquivo ao identificador de recurso (URI), é chamado a função de tratamento ``handleTemaURI(string temaAtual)``, isso pois **o tema da escolha do jogador pode ter acentos** (como em PROFISSÃO) e, por boa prática _- e por não ser um completo lunático -_, **os arquivos salvos tem a formatação de texto universal**, isto é, **não possuí acentos em sua composição ou espaços em branco ou caracteres especiais (com exceção de "-" ou "_")** e esse essa função trata exatamente isso.
Outra coisa importante de se mencionar é que de acordo com a lógica da função, se o jogador acertar a palavra e continuar o jogo, **as chances da nova palavra ser repetida diminuiem em 100%** até que ele tenha completado todas as palavras da lista.

Continuando com o método ``novoJogo()``, em seguida, a sprite da forca, quantidade de tentativas e acertos é configurada aos seus valores iniciais respectivamente. Abaixo temos o método ``statusButton(boolean)`` que é um método que percorre o contexto atual procurando por botões e os ativando ou desativando de acordo com o parâmetro (``true`` ativa os botões e ``false`` os desativa) _- isso porque toda vez que o jogador escolhe uma letra o botão é desativado sendo necessário reativar todos eles novamente_.
Logo abaixo temos a parte interessante, é onde trocamos a correspondência das letras da palavra por underlines (de acordo com as regras universais do jogo citadas anteriormente) através do método ``esconderCorrespondencia()``. Para isso, um laço de repetição é criado que será iterado até o final da palavra atual e em cada iteração, é gerado uma nova ``Label`` com o valor do texto representado por um underline (*"_"*) e sua estilização também definida gerando esse resultado final:
![CODING_DEFINICAO_NECESSIDADE_3](https://user-images.githubusercontent.com/43553717/159340871-ad8a682d-e6be-4f62-96a2-a470dd19d7a6.jpg)

Repare que este método lida com a responsividade das palavras, isso é, caso a palavra for maior que um determinado numero de letra, cada letra tende a diminuir o tamanho da ``Label`` ou da fonte de texto _- que é o caso deste projeto -_ e assim consegue "encaixar" a palavra dentro do painel no qual a letra está localizada. Legal, não é? 🙂

##### 📥 Entrada de dados
A parte de entrada de dados será **encarregada a capturar todos os dados "crus" podendo ou não serem tratadas inicialmente antes de serem enviadas para a parte responsável pela manipulação** _- quando se tem a separação distinta destas etapas, eu pessoalmente prefiro verificar e tratar os dados antes de se enviar para a parte de processamento pois dessa forma fica bem nítido a função de cada parte._

As entradas de dados deste projeto, como já deve ser claro a este ponto, é representada pelo conjunto dos botões na interface, onde o usuário poderá interagir na intenção de ter um problema solucionado _- claro que essa interação varia de acordo com o contexto do programa -_
![INTERFACE_ENTRADA_DE_DADOS](https://user-images.githubusercontent.com/43553717/159292007-d6546578-78af-48e4-94f8-5fc8685a6a45.jpg)
Cada botão é objeto com propriedades, métodos e eventos a serem tratados ou utilizados conforme a necessidade do programa e o decorrer da programação. 
Neste caso, nós estamos interessados em capturar o **evento de clique do botão** (que é representado pela forma do jogador escolher uma possível letra presente na palavra). 
Também precisamos achar a identidade de cada botão, pois para o programa eles não passam de um conjunto de objetos que são instâncias de uma mesma classe, então **como vamos saber se o usuario clicou no botão equivalente a letra A ou a letra B?** Bom, há varias formas de identificarmos um botão com essa intenção, mas para ficar mais fácil, nesse caso usaremos somente o **texto presente em cada botão** como uma convenção e assim definir a identidade do botão.
E essa explicação toda é traduzida em código de acordo com a imagem abaixo
![CODING_ENTRADA_DE_DADOS_1](https://user-images.githubusercontent.com/43553717/160291884-67dc418e-962f-4802-a3c2-0a619887cc5f.jpg)

A primeira linha do código é utilizada somente para atribuir o foco atual para outro contexto fora do botão _- com a simples finalidade de ficar mais bonitinho -_ e, seguindo abaixo, **temos a instância do botão oriunda de object sender vindo do parâmetro da função chamada no evento de clique do objeto** e veja, neste caso não foi necessário nenhuma verificação ou tratamento antes de passar para a etapa de processamento de dados, isso porque esse método será chamado SOMENTE quando algum dos 26 botões (representados pelas letras do alfabeto) for clicado, por ser um método **bem específico** e **dentro de um contexto bem definido e controlado**, não tem a necessidade de fazer verificações, validações ou tratamentos dos dados.

Logo abaixo da instância temos duas linhas utilizadas para estilização e lógica respectivamente. Primeiramente a borda do botão será afinada **indicando visualmente que o botão clicado atualmente foi de fato clicado** e também o **diferenciando dos que não foram clicados pois tem a borda mais grossa** e logo em seguida o botão é desativado pois, de acordo com a lógica do jogo **não se pode escolher mais de uma vez a mesma letra** _- primeiro porque se uma letra pertence a solução, todas as suas compatibilidades devem ser trocadas e reveladas e segundo pois ora, se a letra não pertençe a solução, é ilógico tentar novamente com a mesma letra e insistir no erro  -_ e logo em seguida, o texto presente no botão (representando a identidade do mesmo, equivalente a letra escolhida pelo usuário) é recuperado pela propriedade `` Text `` presente em `` Button `` e enviado para o método de processamento de dados `` manipularEscolha() ``.

##### 🔨 Processamento e saída de dados
E é aqui que está presente o coração do projeto. Olhe a imagem abaixo da função `` manipularEscolha() `` chamada na etapa anterior;
![CODING_PROCESSAMENTO_DE_DADOS_1](https://user-images.githubusercontent.com/43553717/160298731-4bb203e5-5db6-4a2e-8be1-97305fd58465.jpg)

Primeiramente, temos um laço de repetição que, talvez, seja a parte mais importante do processamento de dados. Aqui é onde ocorre a verificação para identificar se a **letra escolhida** pelo jogador está presente na **palavra gerada** _- guardada dentro da variável ``palavraAtual``_. Mas também não há nenhum mistério em seu funcionamento, o laço de repetição percorre toda a palavra e a cada iteração verifica se a letra da vez corresponde a letra esolhida pelo jogador. Caso seja verdadeiro, a variável local ``acertou`` recebe ``true`` _- para, no decorrer do programa. identificar se o laço chegou ao final sem que ele acerte uma letra o que é verificado logo abaixo-_ e, na primeira linha dentro do laço de repetição, há uma atribuição de um caracter ``letraAtual`` provinda da função ``verificarCodificacao()``. 
Eis o problema: nós, brasileiros, utilizamos um sistema de codificação um pouco diferente do padrão universal (americano) em nosso sitema de comunicação escrita, isto é, nossas palavras são um pouco diferentes das do restante do mundo _-- assim como algumas outras linguas como chinês ou árabe, mas não estamos interessados nelas --_ e por isso devemos nos atentar à estas palavras e trocar à sua correspondente letra. Por exemplo a palavra **MACARRÃO** ela posui um **A** com uma acento til( **~**) gerando a letra **Ã**. E isto é um prolema, pois na nossa interface não colocamos opções de acentuação para o usuário escolher. Então como resolver este problema? É aí que o método ``verificarCodificacao()`` entra. Ele é um método que troca a letra com acentuação pela sua respectiva letra base sem acento... Os caracteres **[Ã, Á, À, Â, ...]** por exemplo, são trocados pelo **A**, assim como os caracteres **[É, È, Ê, ...]** são trocados pelo **E**. Assim como é mostrado na descrição da função abaixo.
![CODING_PROCESSAMENTO_DE_DADOS_3](https://user-images.githubusercontent.com/43553717/160292968-c69c6fb8-9fa8-42e1-84ec-2d43a3752c09.jpg)
Pronto, até aqui temos tudo em ordem no controle da acentuação 🙂

Agora, voltando com o método ``manipularEscolha()`` a letra retornada do processamento da função ``verificarCodificacao()`` é passada para a verificação na linha imediatamente abaixo comparando com a letra escolhida pelo jogador vinda do parametro ``control`` e, caso a verificação for verdadeira, **é atribuido verdadeiro à variavel local ``acertou``, os acertos são acrescidos e a função ``mostrarLetra()`` é chamada**. 
Essa função é bem simples, **ela percorre o contexto onde estão as ``Labels`` geradas anteriormente em ``novoJogo()`` e acresce um index toda vez que ele for menor que a posição passada no parâmetro do método (primeiro parâmetro)**, _- podendo assim identificar qual a pocisão da palavra atual corresponde a letra que o jogador acertou -_ e, quando o index corresponder ao parâmetro da posição **a ``Label`` correspondente dentro deste contexto receberá o texto equivalente ao caracter da posição atual que o jogador acertou presente na variável ``palavraAtual`` (segundo parâmetro)**.
E, voltando na primeira verificação do laço de repetição, ele não pode parar assim que achar a primeira letra pois se existir mais de uma correspondência de letra para a palavra atual, **TODAS ELAS DEVEM SER TROCADAS** _- como é descrito nas regras do jogo. Viu como é bom definir tudo antes de colocar a mão na massa? Fica a dica_ 😉 -  como no exemplo da palavra **"MACARRÃO"**.

No momento atual, ela está correspondendo somente à **"_ _ _ _ _ _ _ _"**.

Vamos supor que o jogador escolha a letra **"A"**.
Este laço de repetição deve iterar cada posição da palavra atual **até o final da palavra**, podendo assim identificar se a letra escolhida pelo jogador está presente _- independente da codificação da palavra, pois tratamos isso anteriormente -_ na palavra atual. **E está!** Três vezes ainda. Ou seja, **as definições de acerto devem ser feitas 3 vezes**, isso é, **acertou 3 letras presentes na palavra e deve-se mostrar estas 3 letras em suas respectivas posições.** 

Deixando o jogo com a solução parcial: **"_ A _ A _ _ Ã _"**.

Prosseguindo com a função logo abaixo do método ``mostrarLetra()`` temos uma verificação para desativar o botão da dica caso a quantidade de acertos for maior ou igual a 3 (como solicitado na regra 5) _- abordaremos a questão da dica mais tarde -_ e logo abaixo, temos a segunda verificação que trata caso o jogador **não tenha acertado nenhuma letra e a posição de iteração do laço de repetição estiver no final da palavra** em outras palavras, o jogador infelizmente errou ao escolher a letra pois ela não está presente em nossa solução parcial 😪.
É chamado então o método ``errou()`` que **acresce uma tentativa** pois, conforme solicitado na regras do jogo, o jogador só explicitamente perdeu uma tentativa quando a letra escolhida não está presente na resolução da palavra e também **muda a sprite da forca**, desenhando mais um pedaço do corpo do boneco a ser cruelmente enforcado.

E, finalizando o método ``manipularEscolha()``, temos duas verificações finais.
A primeira verificado, através da função ``ganhou()``, é chamada para identificar se a **quantidade de acertos da palavra atual é igual ao tamanho real da palavra atual** _- desta forma, nós conseguimos saber se ele acertou todas as letras presente na palavra -_ e caso seja verdadeiro, a quantidade de pontos é acrescida (conforme solicitados na regra 2) e um novo jogo é chamado através da função ``novoJogo()`` da qual já trabalhamos nos tópicos anteriores. Esta função é chamada sempre que o jogo voltar ao estado inicial sendo elas **na primeira vez que o programa for inicializado**, **quando acertar uma palavra** (conforme solicidado na regra 1) ou **quando o jogador perder o jogo porém deseja jogar novamente** (conforme solicitados na regra 3).

E ultima verificação é chamada para identificar caso o jogador **perdeu o jogo** através da função ``perdeu()`` que verifica **se o numero de tentativas do jogador for igual ao máximo de tentativas permitidas pelo jogo** e caso seja verdadeiro, a função ``fimDeJogo()`` é chamado. A função ``fimDeJogo()`` abre uma **janela personalizada** _- semelhante a de esolha de tema, porém menor e mais controlada quanto à posição -_ é mostrada ao jogador questionando se ele deseja jogar novamente juntamente com a quantidade de pontos que ele adquiriu ao decorrer dos jogos. Confome é visto na imagem abaixo.
![INTERFACE_JOGO_FORCA_5](https://user-images.githubusercontent.com/43553717/159725740-0b1e1b17-b285-4c17-87a1-7eb2f51eae02.jpg)

E por último, mas não menos importante, temos os dois botões mais chamativos dessa linda interface, a **DICA** e **TROCAR**.

Primeiramente, vamos abordar a **dica**. Conforme solicitado nas regras, a dica deve eliminar ao jogador as correspondências de uma letra presente na solução parcial da palavra atual. Ela tem também limitações _- conforme visto anteriormente -_ e de acordo com as regras, a dica não pode ser requerida pelo jogador caso:
> [...] a quantidade de letras reveladas seja inferior a 3 e que a palavra tenha mais de 4 letras em sua composição.

O primeiro caso, já está tratado na função ``manipularEscolha()`` e o segundo caso também está tratado na função ``statusButton()``. Então o a função ficou conforme a imagem abaixo.
![CODING_PROCESSAMENTO_DE_DADOS_4](https://user-images.githubusercontent.com/43553717/160299527-1b482160-d9e5-4cad-8ca9-d0723c99f7dd.jpg)

Como pode ver, é gerado um indice aleatório dentro dos limites de ``palavraAtual`` e, enquanto a informação de que não há correspondências disponíveis no contexto onde as ``Label``s estão inseridas, requerida através da função ``letraDisponível()`` o indice gerado anteriormente recebe um novo indice aleatório. 

*- ``letraDisponível()`` retorna ``true`` caso a posição referente ao indice gerado está disponível, isso é, corresponde à um caracter "_" e caso contrário, retorna ``false``*.

E, quando houver uma posição disponível, ela será verificada através do método ``verificarCodificacao()`` _- do qual falamos anteriormente -_ e atribuida a variavel local ``letraAtual`` e essa será imediatamente passada para a função ``manipularEscolha()`` _- do qual também falamos anteriormente -_ **trocando todas as correspondências dessa letra na palavra atual** e mostrando o resultado parcial para o jogador.
Logo após, o botão referênte à letra gerada pela dica é desativado _- pois não há mais nenhuma correspondência desta letra na resolução_.

E agora só nos resta a **troca de palarva**. A troca de palavra, conforme solicitado nas regras, deve permitir ao jogador a:
> possibilidade de troca de palavra para outra do mesmo tema somente uma vez por rodada e na troca o número de tentativas é subtraído por 2;

E é exatamente isso que a função ``manipularTrocaPalavra()`` descreve na imagem abaixo.
![CODING_PROCESSAMENTO_DE_DADOS_5](https://user-images.githubusercontent.com/43553717/160300135-b7a97358-3141-45b3-b430-02873a494329.jpg)

Em resumo, a uma nova palavra é gerada e atribuida a variavel ``palavraAtual``, a função ``esconderCorrespondencia()`` é chamada para atualizar, no contexto das ``Label``s, a nova palavra gerada, os botões são novamente ativados _- inclusive a dica pois, sejamos justos, se o jogador pediu alguma dica, foi referente a palavra anterior... Por este motivo, as dicas que ele solicitou anteriormente são inúteis nessa nova palavra -_, os acertos são zerados, a função de erro é iterado duas vezes _- assim subtraindo o número de tentativas por dois-_ e o botão é desativado _- pois o jogador só pode utilizar esse recurso uma vez por rodada._

E isso é tudo por hoje p-p-pessoal! Chegamos ao fim deste readme. Espero que este pequeno resumo tenha ajudado a visualizar este projeto e lembre-se 
>**_"Ser ruim em alguma coisa é o primeiro passo para se tornar bom em alguma coisa"_**

##### ATÉ A PRÓXIMA. FUI 😁
