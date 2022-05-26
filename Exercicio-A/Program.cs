// See https://aka.ms/new-console-template for more information

int[] a1 = new int[6] { 10, 15, 18, 30, 42, 45};
int a2 = 48;

int[] b1 = new int[4] { 2, 8, 16, 25 };
int b2 = 10;

int[] c1 = new int[5] { 4, 7, 13, 20, 22 };
int c2 = 25;

int[] d1 = new int[6] { 6, 9, 11, 19, 21, 33 };
int d2 = 44;

int[] e1 = new int[2] { 4, 10 };
int e2 = 15;

int[] f1 = new int[4] { 7, 17, 28, 35 };
int f2 = 28;


int soma = 0;

verificar(a1,a2);
verificar(b1, b2);
verificar(c1, c2);
verificar(d1, d2);
verificar(e1, e2);
verificar(f1, f2);


void verificar(int[] lista, int total)
{
    bool existe = false;

    for (int i = 0; i < lista.Length; i++)
    {
        for (int j = 0; j < lista.Length; j++)
        {
            soma = lista[i] + lista[j];
            if (soma == total)
            {
                existe = true;

            }

        }

    }
    if (existe == true)
    {
        Console.WriteLine("Verdadeiro");
    }
    else
    {
        Console.WriteLine("Falso");
    }


}

