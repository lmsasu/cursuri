def my_sum(lista):
    the_sum = 0
    for item in lista:
        the_sum += item
    return the_sum

if __name__ == '__main__':
    print('Exemplu de utilizare')
    lista = list(range(100))
    print(my_sum(lista))