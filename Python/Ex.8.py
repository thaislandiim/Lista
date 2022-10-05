matriz = [[None, None], [None, None], [None, None]]

for l in range(0, 3):
  for c in range(0, 2):
    matriz[l][c] = int(input("Insira um número: "))

for l in range(0,3):
  for c in range(0,2):
    if matriz[l][c] % 3 == 0:
      print(f"[{matriz[l][c]}]")