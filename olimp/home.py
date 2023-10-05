x, y, l, c1, c2, c3, c4, c5, c6 = (int(input()) for i in range(9))
summa = 0
p = 2*(x+y) #периметр нового дома
new = c4 + c5 #постройка из нового
old = c2 + c3 #постройка из старого разрушенного
snos = c2 + c6 #снос и вывоз
if (old <= new + snos) and (c1 <= old):
    if (l >= max(x,y)) and (l<p):
        summa = c1 * max(x, y) + (p - l) * new + (l - max(x, y)) * old
    if l<max(x,y):
        summa = l * c1 + new * (p - l)
    if l>=p:
        summa = max(x, y) * c1 + (p - max(x, y)) * old + (l - p) * snos
if (old <= new + snos) and (c1 > old):
    if l<p:
        summa = l * old + (p - l) * new
    if l>=p:
        summa = p * old + (l - p) * snos
if (old > new + snos) and (c1<= new + snos):
    if (l >= max(x,y)) and (l<p):
        summa = max(x, y) * c1 + (l - max(x, y)) * (new + snos) + (p - l) * new
    if l<max(x,y):
        summa = l * c1 + (p - l) * new
    if l>p:
        summa = max(x, y) * c1 + (p - max(x, y)) * (new + snos) + (l - p) * snos
if (old > new + snos) and (c1 > new + snos):
    if l<p:
        summa = l * snos + p * new
    if l>p:
        summa = p * (new + snos) + (l - p) * snos
print(summa)