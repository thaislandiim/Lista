let matriz = [[0,0], [0,0], [0,0]]

for(let l = 0; l < 3; l++){
  for(let c = 0; c < 2; c++){
    matriz[l][c] = prompt("Insira um número: ")
  }
}

for(let l = 0; l < 3; l++){
  for(let c = 0; c < 2; c++){
    if(matriz[l][c] % 3 == 0){
      console.log("[" + matriz[l][c] + "]")
    }
  }
}