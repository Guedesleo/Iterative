// Faça um algoritmo que conte de 1 a 100 e a cada múltiplo de 10 emita uma mensagem:
// “Múltiplo de 10”.
multiplo10(100);
function multiplo10(limite){
    for(var i=1;i<=limite;i++){
        if(i%10 == 0){
            console.log("Esse e multiplo de 10:",i);
        }
    }
}

    