// Leia nome, salário e categoria de um funcionário, se a categoria for = “m” de mensalista,
// conceder 10% de aumento, se for = “h” de horista, conceder 20% de aumento, se não for “m”
// nem “h”, exibir a mensagem categoria inválida.

const readline = require("readline");
const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

rl.question("Qual o seu nome ? ", function(name) {
    rl.question("Qual o valor do seu salario ? ", function(money) {
      rl.question("Qual e a sua categoria, m para mensalista e h para horista? ", function(category) {
              if(category == "m"){
                    category="mensalista";
                    var aumento = ((10/100)*money);
              }else{
                if(category=="h"){
                  category="horista"
                  var aumento  = ((20/100)*money);
                }else{
                  console.log(`categoria inválida`);
                  rl.close();
                }
              }
              console.log(`Olá ${name}, o seu salario hoje e de ${money}, por ser ${category} ouve um aumento no seu salario de ${aumento}.`)
        rl.close();
      });
    });
});

rl.on("close", function() {
    process.exit(0);
});