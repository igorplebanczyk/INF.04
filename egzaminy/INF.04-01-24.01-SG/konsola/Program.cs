char getSex(int[] pesel)
{
    if (pesel[9] % 2 == 0) return 'K';
    else return 'M';
}

/**********************************************
nazwa funkcji: isValid
opis funkcji: sprawdza czy numer PESEL jest poprawny na podstawie sumy kontrolnej
parametry: pesel - numer pesel w postaci tablicy liczb całkowitych
zwracany typ i opis: bool - true albo false w zależności od zgodności sumy kontrolnej
autor: 12345678901
***********************************************/
bool isValid(int[] pesel)
{
    int s = pesel[0] + pesel[1] * 3 + pesel[2] * 7 + pesel[3] * 9 + pesel[4] + pesel[5] * 3 + pesel[6] * 7 + pesel[7] * 9 + pesel[8] + pesel[9] * 3;
    int m = s % 10;
    int r;

    if (m == 0) r = 0;
    else r = 10 - m;

    return pesel[10] == r;
}

Console.WriteLine("Podaj numer PESEL: ");
int[] pesel = [5, 5, 0, 3, 0, 1, 0, 1, 1, 9, 3];
for (int i = 0; i < pesel.Length; i++)
{
    pesel[i] = int.Parse(Console.Read().ToString()) - '0';
}
Console.WriteLine("");

if (getSex(pesel) == 'K') Console.WriteLine("Kobieta");
else Console.WriteLine("Mężczyzna");

Console.WriteLine(isValid(pesel));