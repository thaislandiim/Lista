let numero = [
    [0,0,0], 
    [0,0,0], 
    [0,0,0]
  ]
  let c;
  let l;
  
  for(l = 0; l < 3; l++){
    for(c = 0; c < 3; c++){
      if(l == 0 && c == 0){
        numero[l][c] = Number(prompt("Insira um número: "))
      } else {
        if(c == 0){
          numero[l][c] = numero[l - 1][2] + 1
        } else {
          numero[l][c] = numero[l][c - 1] + 1
        }
      }
    }
  }
  console.log(numero.map(l => `[ ${l.join(', ')} ]`).join("\n"))