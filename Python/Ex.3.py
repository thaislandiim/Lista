numero = [0,0,0,0,0,0,0,0,0,0]

for n in range(0, 10):
  numero[n] = int(input("Insira um valor: "))

for n in range(0, 10):
  if numero[n] % 2 == 0:
    print(f"[{numero[n]}]")