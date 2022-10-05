const vetor = [4]

vetor[0] = Number(prompt("Insira um número: "))

for(let n = 0; n < 3; n++){
  vetor[n + 1] = vetor[n] + 1
}
console.log(vetor)