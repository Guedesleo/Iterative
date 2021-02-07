//Elabore um algoritmo  para Imprimir a tabuada de qualquer número informado. 

const readline = require("readline");
const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

rl.question("Digite um numero : ", function (number) {
    var tabuada = []
    for (var i = 0; i <= 10; i++) {
        if(Math.floor(number)!= number){
            console.log("Digite um numero inteiro!");
            rl.close();
        }else{
            if (number >= 0) {
                valor = i * number
                tabuada[i] = `${number} x ${i}  = ${valor} `;
            } else {
                console.log("Por favor digite um numero  maior que 0 !");
                rl.close();
            }
        }
    }
    for (var i = 0; i <= 10; i++) {
        console.log(tabuada[i])
    }

    rl.close();
});

rl.on("close", function () {
    process.exit(0);
});