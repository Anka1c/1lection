int a = 11;
int b = 8;
int c = 10;
int d = 9;
int e = 16;

int max = a; //max наша коробочка и мы кладем в нее значение первой гири (a)

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("Максимальный вес гири равен ");
Console.Write(max);