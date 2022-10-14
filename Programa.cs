using System;

char c = 'a'; // 16 bits, char é usado só para um caracter
string str = "Olá mundo";

bool b1 = true;
bool b2 = false;

float f = 2.5f;
float fi = float.PositiveInfinity;
double d = 2.5; // aceita valores maiores
double d1 = double.Epsilon;
double d2 = double.NaN;
decimal m = 5.0m; // Usado para contar dinheiro

byte b = 200; // bit
short s = 1000; // 16 bits
int i = 3; // 32 bits
long l = 3; // 64 bits

U = sem sinal
sbyte sb = 100; // bit
ushort us = 1000; // 16 bits
uint ui = 3; // 32 bits
ulong ul = 3; // 64 bits

object obj = s;
string str2 = (string)obj;

int result = (int)(ui + l);

dynamic dy = 8;
dy = "Olá, mundo!";
R. Canelinha, Indaiatuba - SP
var x = 7;

int a = int.MaxValue;
int num = unchecked(a + 1); // Garantir que não vai dar erro

int[] arr = new int[10]; // Vetor
object[] objs = new object[100];
var arr2 = new double[3];

arr[0] = 4;
arr[^1] = 3;

int n = 4 ^ 2; // Ou exclusivo, bit a bit
int n1 = 6 & 2; // And, bit a bit
int n2 = 6 >> 4; // Desloca os bits, bit a bit 
int n3 = 6 % 4; // Resto

int? x = null; // Valores nulos
Console.WriteLine(y ?? 7);
Console.WriteLine(y.ToString());

string s3 = null;
string s4 = s3?.Replace('a','b') ?? "Erro";
Console.WriteLine(s4);

See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int i = 3;
if (i < 10)
{
    Console.WriteLine(i);
}
// else if (i < 15)
// {
//     Console.WriteLine("Muito Forte");
// }
// else {
//     Console.WriteLine("...");
// }

// int x = 3;
// switch (i)
// {
//     case 3:
//         Console.WriteLine(3);
//         goto case 5;
//     case 4:
//     Console.WriteLine(4);
//         break;
//     case 5:
//         Console.WriteLine("Bom dia");
//         break;
//     default:
//         Console.WriteLine("Não sei");
//         break;
// }

// int z = 3;
// while (z < 10){
//     Console.WriteLine("oi");
//     z++;
// }

// int y = 3;
// do
// {
//     Console.WriteLine("Hello");
//     y++
// } while y < 10: 


// for (int a = 0; a < 10; a++){
//     Console.WriteLine("Oi!");
// }

// int[] arr = new int[100];
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = 1;
// }

// foreach (int n in arr)
// {
//     Console.WriteLine(n);
// }