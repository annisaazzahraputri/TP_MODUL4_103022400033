using System;
using System.Collections.Generic;

class KodePos
{
    private Dictionary<string, string> kodePosTable = new Dictionary<string, string>()
    {
        {"Batununggal", "40266"},
        {"Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijaura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"}
    };

    public string getKodePos(string kelurahan)
    {
        return kodePosTable[kelurahan];
    }
}

class DoorMachine
{
    enum State { Terkunci, Terbuka }

    private State currentState = State.Terkunci;

    public void BukaPintu()
    {
        if (currentState == State.Terkunci)
        {
            currentState = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
        else
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
    }
}

class Program
{
    static void Main()
    {
        KodePos kp = new KodePos();
        Console.WriteLine("Kode Pos Batununggal: " + kp.getKodePos("Batununggal"));

        DoorMachine door = new DoorMachine();
        door.BukaPintu();
        door.BukaPintu();
    }
}