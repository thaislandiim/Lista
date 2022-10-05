numeros = [
  [[0, 0, 0], [0, 0, 0], [0, 0, 0]],
  [[0, 0, 0], [0, 0, 0], [0, 0, 0]]
]

for l in range(0, 3):
  for c in range(0, 2):
    for lc in range(0, 3):
      numeros[l][c][lc] = int(input("Insira um número: "))