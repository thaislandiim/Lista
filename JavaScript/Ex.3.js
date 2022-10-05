let vetor = [10]

for(let n = 0; n < 10; n++){
  vetor[n] = prompt("Insira um número: ")
}
for (let n = 0; n < 10; n++) {
  if (vetor[n] % 4 == 0){
    console.log("[" + vetor[n] + "]")
  }
}