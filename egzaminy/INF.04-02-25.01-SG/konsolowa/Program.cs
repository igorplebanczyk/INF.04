WashingMachine washingMachine = new();
Vacuum vacuum = new();

washingMachine.displayMessage("Podaj numer prania (1 - 12):");
int programNumber = int.Parse(Console.ReadLine());
if (washingMachine.setProgram(programNumber) != 0) washingMachine.displayMessage("Program został ustawiony");
else washingMachine.displayMessage("Podano niepoprawny numer programu");

vacuum.on();
vacuum.on();
vacuum.on();
vacuum.displayMessage("Odkurzacz wyładował się");
vacuum.off();

class Appliance
{
    /************************************************
    nazwa: displayMessage
    opis: klasa wyświetla w konsoli podany komunikat
    parametry: message - komunikat do wyświetlenia
    zwracany typ i opis: brak
    autor: 12345678901
    ************************************************/
    public void displayMessage(string message)
    {
        Console.WriteLine(message);
    }
}   

class WashingMachine : Appliance
{
    private int programNumber = 0;

    public int setProgram(int programNumber)
    {
        if (programNumber >= 1 && programNumber <= 12) this.programNumber = programNumber;
        else this.programNumber = 0;

        return this.programNumber;
    }
}

class Vacuum : Appliance
{
    private bool status = false;

    public void on()
    {
        if (status != false) return;

        status = true;
        displayMessage("Odkurzacz włączono");
    }

    public void off()
    {
        if (status != true) return;

        status = false;
        displayMessage("Odkurzacz wyłączono");
    }
}