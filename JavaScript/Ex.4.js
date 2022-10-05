let v1 = [4]
let v2 = [4]

for(let n = 0; n < 4; n++){
  v1[n] = Number(prompt("Insira um número: "))
  v2[n] = Number(prompt("Insira um número: "))

  let v3 = []
  v3 = v1[n] + v2[n]
  console.log(v3)
} 