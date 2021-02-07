Algoritmo "Elabore um algoritmo  para Imprimir a tabuada de qualquer número informado. "
Var
valor,resultado :inteiro
i: inteiro

Inicio
// Seção de Comandos, procedimento, funções, operadores, etc...
escreva("Digite um numero:")
leia(valor)
se valor < 0 entao
   escreval("Digite um numero maior que 0.")
senao
     para i de 1 ate 10 faca
          se valor >= 0 entao
             resultado<- (i*valor)
             escreval (valor," x",i," =", resultado)
          fimse
     fimpara
fimse


Fimalgoritmo