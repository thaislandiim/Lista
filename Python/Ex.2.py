numero = [0,0,0,0]

for n in range(0, 4):
  if n == 0:
    numero[n] = int(input("Insira um valor: "))
  else:
    if n > 0:
      numero[n] = numero[n - 1] * 7

print(numero)