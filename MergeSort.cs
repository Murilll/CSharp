/*using System;


void mergesort(int[] arr)
{
    int e = arr.Length;
    int[] arraux = new int[e];
    mergesortrec(arr, arraux, 0, e);
}


// void mergesort(int[] arr, //DUAS FUNCOES COM O MESMO NOME.
// int s,
// int e)
// {

// }

void mergesortrec(
    int[] arr, 
    int[] arraux, 
    int s, int e)
{
    if (e - s < 2)
        return;
    int p = (s + e) / 2;
    mergesortrec(arr, arraux, s, p);
    mergesortrec(arr, arraux, p, e);
    merge(arr, arraux, s, p, e);
}

void merge(int[] arr,
int[] arraux, // Faltou um parametro aqui, o int[] arraux
int s, 
int p, 
int e) 
{
    int i = s, j = p, k = s;
    while (i < p && j < e)
    {
        if (arr[i] < arr[j])
        {
            arraux[k] = arr[i];
            i++;
            k++;
        }
        else
        {
            arraux[k] = arr[j];
            j++;
            k++;
        }
    }

    while (i < p)
    {
        arraux[k] = arr[i]; // aqui tava arr[j] e o certo é o arr[i]
        i++;
        k++;
    }

    while (j < e)
    {
        arraux[k] = arr[j];
        j++;
        k++;
    }

    for (int t = s; t < e; t++)
    {
        arr[t] = arraux[t];
    }
}



int[] arr = new int[]
{8, 4, 2, 3, 9, 12, 11, 1 };

mergesort(arr);
// Teu foreach tava errado, como eu apaguei tudo ele pra testar eu nao vi oq tava
foreach (int numero in arr){
    Console.Write(numero);
}