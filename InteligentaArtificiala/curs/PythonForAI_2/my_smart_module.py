def my_sum(lista: list[int|float]) -> int|float:
    s = 0
    for item in lista:
        s += item
    return s
	
if __name__ == '__main__':
	print('A small example on calling my_sum')
	lista = list(range(100))
	print(my_sum(lista))