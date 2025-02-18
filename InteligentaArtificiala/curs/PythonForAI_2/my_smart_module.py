from typing import List, Union

def my_sum(lista: List[Union[int, float]]) -> Union[int, float]:
    s = 0
    for item in lista:
        s += item
    return s
	
if __name__ == '__main__':
	print('A small example on calling my_sum')
	lista = list(range(100))
	print(my_sum(lista))