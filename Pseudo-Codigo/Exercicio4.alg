Algoritmo "semnome"
//Escreva o Pseudocódigo para ler um valor N qualquer fornecido
//pelo usuário e verificar os itens abaixo.
//O Programa deve ser executado enquanto o usuário desejar.

//-Calcular o Fatorial para o numero lido
//- Verificar se o numero é Primo
//- Verificar se é Par ou Impar.
//- Calcular o número ao cubo

Var
numero,i:inteiro
fatorial : inteiro
opcao:inteiro
cont :inteiro
cubo:real

Inicio
fatorial<-1
Escreva("Digite um numero:")
leia(numero)
Escreval("--------------------------------------------------------------------------------------------------")
Escreval("| A seguir escolha qual figura deseja, digitando o número correspondente a figura correspondente.|")
Escreval("|         1 ==> Calcular o Fatorial para o numero lido                                           |")
Escreval("|         2 ==> Verificar se o numero é Primo                                                    |")
Escreval("|         3 ==> Verificar se é Par ou Impar                                                      |")
Escreval("|         4 ==>  Calcular o número ao cubo                                                       |")
Escreval("--------------------------------------------------------------------------------------------------")
Escreva("Qual dessa opções voce deseja executar?")
leia(opcao)

escolha opcao
 caso 1
      para i de 1 ate numero faca
           fatorial <- fatorial * i
      fimpara
      escreval("O Valor do fatorial que você digitou e:",fatorial)
 caso 2
      para i de 1 ate numero faca
       se numero mod  i = 0 entao
          cont <- cont+1
       fimse
      fimpara
      se cont = 2 entao
         escreval("o numero", numero," e primo!")
      senao
      escreval("o numero", numero," nao e primo!")
      fimse
 caso 3
      se numero mod 2 = 0 entao
         escreval("o numero",numero," e par.")
      senao
           escreval("o numero", numero," e impar.")
      fimse
 caso 4
      se numero > 0 entao
         cubo <- numero ^ 3
         escreval("O valor do numero elevado ao cubo",cubo,".")
      fimse
 outrocaso
      escreval("Opcao Invalida!")
 fimescolha


Fimalgoritmo