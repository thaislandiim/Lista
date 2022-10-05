numero =  [[None, None, None], [None, None, None], [None, None, None]]

for l in range(0, 3):
  for c in range(0, 3):
    if l == 0 and c == 0:
      numero[l][c] = int(input("Insira um número: "))
    else:
      if c == 0:
        numero[l][c] = numero[l -1][c - 1] + 1
      else:
        numero[l][c] = numero[l][c - 1] + 1

print(numero)