using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralDesignPatterns.Facade.Facade1;

public class AltSistem1
{
    public string Operasyon1()
    {
        return "AltSistem1: Operasyon1\n";
    }
    public string Operasyon2()
    {
        return "AltSistem1: Operasyon2\n";
    }
}

public class AltSistem2
{
    public string Operasyon1()
    {
        return "AltSistem2: Operasyon1\n";
    }
    public string Operasyon2()
    {
        return "AltSistem2: Operasyon2\n";
    }
}

public class Facade
{
    protected AltSistem1 _altSistem1;
    protected AltSistem2 _altSistem2;
    public Facade(AltSistem1 altSistem1, AltSistem2 altSistem2)
    {
        _altSistem1 = altSistem1;
        _altSistem2 = altSistem2;
    }

    public string OperasyonA()
    {
        return "Facade: OperasyonA\n" + _altSistem1.Operasyon1() + _altSistem2.Operasyon1();
    }

    public string OperasyonB()
    {
        return "Facade: OperasyonB\n" + _altSistem1.Operasyon2() + _altSistem2.Operasyon2();
    }

}
