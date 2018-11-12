
## Пряк избор
![Alt Text](https://upload.wikimedia.org/wikipedia/commons/9/94/Selection-Sort-Animation.gif)
```
void straightSelection(struct CElem m[], unsigned n)
{ unsigned i, j;
  for (i = 0; i < n-1; i++)
    for (j = i+1; j <= n; j++)
      if (m[i].key > m[j].key)
        swap(m+i, m+j);
}
```
### Доказателство:
Понеже всеки път се взима минималният елемент от останалите ( необходени ) елементи, накраят остава само един, който няма с кой да се сравни ( освен със себе си ), затова итерациите са n-1.

<br /><br /><br />

## Мехурче
![Alt Text](https://upload.wikimedia.org/wikipedia/commons/c/c8/Bubble-sort-example-300px.gif)
```
void bubbleSort(int arr[], int n)
{
   int i, j;
   for (i = 0; i < n-1; i++)
       for (j = 0; j < n-i-1; j++)
           if (arr[j] > arr[j+1])
              swap(&arr[j], &arr[j+1]);
}
```
### Доказателство:
Итерациите са n-1, защото когато се стигне до последния елемент се изисква сравнение със следващия, а такъв не е наличен понеже е достигнат краят на масива.

<br /><br /><br />

## Вмъкване
![Alt Text](https://upload.wikimedia.org/wikipedia/commons/0/0f/Insertion-sort-example-300px.gif)
```
void straightInsertion(struct CElem m[], unsigned n)
{ struct CElem x;
  unsigned i;
  int j;
  for (i = 1; i < n; i++) {
    x = m[i];
    j = i-1;
    while (j >= 0 && x.key < m[j].key)
      m[j+1] = m[j--];
      m[j+1] = x;
  }
}
```
### Доказателство:
Тъй, като се започва от първия елемент ( а не от нулевия ) са достаъчни n-1 итерации.

<br /><br /><br />

## Пирамида
![Alt Text](https://upload.wikimedia.org/wikipedia/commons/4/4d/Heapsort-example.gif)
```
void heapSort(struct CElem m[], unsigned n) /* Пирамидално сортиране */
{ unsigned k;

/* 1. Построяване на пирамидата */
  for (k = n/2 + 1; k > 1; k--) {
    sift(m,k-1,n);
  }

/* 2. Построяване на сортирана последователност */
  for (k = n; k > 1; k--) {
    swap(m+1,m+k);
    sift(m,1,k-1);
  }
}

```
### Доказателство:
Бр. на итерациите = n - 1, защото цикълът ще се завърти к пъти освен когато е равен на 1 (k>1).
