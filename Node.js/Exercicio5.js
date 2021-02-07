//Realize um algoritmo que ordene em ordem crescente um vetor “ZX” de 100 posições. 

const readline = require("readline");
const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

    let numeros =[];
    let atual=0;
    rl.question("Digite o tamanho do array que deseja: ", async  function(numero) {
        for(var i = 0; i < numero; i++){
            await new Promise((resolve) => { 
                rl.question(`Digite o valor de indice ${i}: `, (valor) => {
                    resolve(numeros.push(valor)); 
                });   
            });
        }
        console.log(numeros)
        for (i = 0; i < numero; i++)
            {
              for(j=i+1; j < numero; j++)
              {  
                if (numeros[i] > numeros[j])
                {
                    atual = numeros[i];
                    numeros[i] = numeros[j];
                    numeros[j] = atual;
                }
              }
            }
         for (i = 0; i < numero; i++)
             {
                 console.log(numeros[i]);
             }
    });