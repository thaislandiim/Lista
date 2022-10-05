v1 = [0,0,0,0]
v2 = [0,0,0,0]
v3 = [0,0,0,0]

for v in range(0,4):
  v1[v] = int(input("Insira um número: "))
  v2[v] = int(input("Insira um número: "))

  v3[v] = v1[v] + v2[v]
  print(v3[v])