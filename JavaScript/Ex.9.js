let matriz = [[0,0,0], [0,0,0]]

for(let l = 0; l < 2; l++){
  for(let c = 0; c < 3; c++){
    if(l == 0 && c == 0){
      matriz[l][c] = Number(prompt("Insira um número: "))
    } else {
      if(c == 0){
        matriz[l][c] = matriz[l - 1][2] * 7
      } else {
        matriz[l][c] = matriz[l][c - 1] * 7
      }
    }
  }
}
console.log(matriz)