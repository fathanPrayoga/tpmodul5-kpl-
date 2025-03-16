using tpModul5_103022330070;

class Program
{
    static void Main()
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("yoga"); 

        DataGeneric<string> dataNIM = new DataGeneric<string>("103022330070"); 
        dataNIM.PrintData();
    }
}