from typing import List, Union

def my_sum(lista: List[Union[int, float]]) -> Union[int, float]:
    sum = 0
    for item in lista:
        sum += item
    return sum
	
if __name__ == '__main__':
	print('Exemplu de utilizare')
	lista = list(range(100))
	print(my_sum(lista))