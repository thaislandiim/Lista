matriz = [[None, None, None, None], [None, None, None, None]]

for l in range(0,2):
  for c in range(0,4):
    if l == 0 and c == 0:
      matriz[l][c] = int(input("Insira um número: "))
    else:
      if c == 0:
        matriz[l][c] = matriz[l - 1][c] + 1
      else:
        matriz[l][c] = matriz[l][c - 1] + 1

print(matriz)