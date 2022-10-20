using System;

Console.WriteLine("Hello, WOrld!");

void mergesort(int[] arr)
{
    int e = arr.Length;
    int[] arraux = new int[e];
    mergesortrec(arr, arraux, 0, e);
}

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
int[] arraux,
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
        arraux[k] = arr[i];
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
foreach (int numero in arr){
    Console.Write(numero);
}

public class File : IDisposable
{
    public void Dispose()
    {
    if (obj == null)
    throw new InvalidOperationException();

    if (obj is BigNatural bn)
    {
        if (this.b > bn.b)
            return  1;
        else if (this.b < bn.b)
            return -1;
        else
        {
            return (int)(this.a - bn.a);
        }
    }
    else if (obj is int i)
    {
    if (this.b > 0)
        return 1;
    if (i < 0)
        return 0;
    return (int)(args - (ulong)i);
    }
    else if (obj is int u)
    {

    }
    }
} 

public class File : IComparable
{
    public int Compareto(object? obj)
    {
        throw new NotImplementedException
    }
}


