// Напишите программу ,которая принимает на               A: (3,6,8); B:(2,1,-7), -> 15.84
// вход координаты двух точек и находит растояние между   A: (7.-5.0); B:(1,-1,9), -> 11.53
// нима в 3D пространстве.

void Distance (int x, int y, int z, int x1, int y1, int z1)
{
    int namberZ = ((x1-x)*(x1-x) +(y1-y)*(y1-y) +(z1-z)*(z1-z));
    double sqr = Math.Sqrt(namberZ);
    double sqrZ = Math.Round(sqr, 2);
    Console.WriteLine(sqrZ);

}

Distance (3,6,8,2,1,-7);
// Distance (7,-5,0,1,-1,9);