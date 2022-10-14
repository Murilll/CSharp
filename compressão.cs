using System;

int[] arr = new int[]
{192, 255};

void compressAndDecompress(byte[] bytes){  // Contar o tempo da compressão
    var start = Datetime.Now;
    var compressed = compress(bytes);
    bytes = decompress(compressed);
    var end = DateTime.Now;
    MessageBox.Show((end - start).TotalMilliseconds.ToString() + " ms");
}

for (int i = 0; i < arr.Length; i += 2){
    int x = arr[i];
    int x1 = arr[i+1];
    x = x >> 4;
    x1 = x1 >> 4;
    x = x << 4;
    int compress = x + x1; 

    Console.WriteLine($"Compressão: {compress}");
}

