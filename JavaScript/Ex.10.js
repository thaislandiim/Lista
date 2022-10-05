let numeros = [
  [[0, 0, 0], [0, 0, 0], [0, 0, 0]],
  [[0, 0, 0], [0, 0, 0], [0, 0, 0]]
]

for(let l = 0; l < 3; l++){
  for(let c = 0; c < 2; c++){
    for(let lc = 0; lc < 3; lc++){
      numeros[l][c][lc] = prompt("Insira um número: ")
    }
  }
}
  