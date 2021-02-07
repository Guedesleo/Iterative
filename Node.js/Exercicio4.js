//'Escreva o Pseudocódigo para ler um valor N qualquer fornecido pelo usuário e verificar os itens abaixo.  
//O Programa deve ser executado enquanto o usuário desejar. 

//- Calcular o Fatorial para o numero lido
//- Verificar se o numero é Primo
//- Verificar se é Par ou Impar.
//- Calcular o número ao cubo


const readline = require("readline");
const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

let fatorial=1;
let cont = 1;
rl.question("Digite um numero: ", function(numero) {
    console.log ("--------------------------------------------------------------------------------------------------");
    console.log("| A seguir escolha qual figura deseja, digitando o número correspondente a figura correspondente.|");
    console.log("|         1 ==> Calcular o Fatorial para o numero lido                                           |");
    console.log("|         2 ==> Verificar se o numero é Primo                                                    |");
    console.log("|         3 ==> Verificar se é Par ou Impar                                                      |");
    console.log("|         4 ==>  Calcular o número ao cubo                                                       |");
    console.log("--------------------------------------------------------------------------------------------------");
    rl.question("Qual dessa opções voce deseja executar? ", function(opcao) {
        switch (opcao){
            case '1':
                   for (var i = 1; i < numero; i++)
                   {
                       fatorial += fatorial * i;
                   }
                   console.log(`O Valor do fatorial que você digitou e:${fatorial}`);
                   break;
             case '2':
                    for (var i = 1; i < numero; i++)
                    {
                        if (numero % i == 0)
                           cont++;
                    }
                    if(cont == 2)
                        console.log(`O numero  ${numero} e primo!`);
                    else
                        console.log(`O numero  ${numero} nao e primo!`);
                   break;
            case '3':
                    if(numero % 2 == 0)
                    {
                        console.log(`O numero que voce digitou e par${numero}`);
                    }else{
                        console.log(`O numero que voce digitou e impar ${numero}.`);
                    }
                    break;
            case '4':
                        if(numero > 0)
                        {
                            numero = Math.pow(numero,3);
                            console.log(`O valor do numero elevado ao cubo ${numero}.`)
                        }
                        break;
            default:
                    console.log(`Opcao Invalida!`);
        }
    });
});