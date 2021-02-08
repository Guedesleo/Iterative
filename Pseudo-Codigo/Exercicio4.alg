Algoritmo "Exercicio4"
//Escreva o Pseudocódigo para ler um valor N qualquer fornecido
//pelo usuário e verificar os itens abaixo.
//O Programa deve ser executado enquanto o usuário desejar.

//-Calcular o Fatorial para o numero lido
//- Verificar se o numero é Primo
//- Verificar se é Par ou Impar.
//- Calcular o número ao cubo

procedimento fatorial(numero,fat:inteiro)
inicio
      fat<-1
      para i de 1 ate numero faca
           fat <- fat * i
      fimpara
      escreval("O Valor do fatorial que você digitou e:",fat)
fimprocedimento

procedimento verificarPrimo(numero,cont:inteiro)
inicio
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
fimprocedimento

procedimento ParOuImpar(numero:inteiro)
inicio
         se numero mod 2 = 0 entao
         escreval("o numero",numero," e par.")
      senao
           escreval("o numero", numero," e impar.")
      fimse
fimprocedimento

procedimento cubo(valor:real)
inicio
        se valor > 0 entao
         valor <- valor ^ 3
         escreval("O valor do numero elevado ao cubo",valor,".")
      fimse
fimprocedimento








//Programção Principal
Var
numero,i:inteiro
fat : inteiro
opcao:inteiro
cont :inteiro
valor:real
resp:caracter

Inicio
resp<-"S"
Enquanto (resp = "S") faca
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
        fatorial(i,numero,fat)
     caso 2
        verificarPrimo(i,numero,cont)
     caso 3
        ParOuImpar(numero)
     caso 4
        valor<-numero
        cubo(valor)
     outrocaso
        escreval("Opcao Invalida!")
  fimescolha
  escreva("Deseja continuar?- Resposta [S]im ou [N]ao:")
  leia(resp)
fimenquanto
Fimalgoritmo