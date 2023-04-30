using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.ChainOfResponsibility.ChainOfResponsibility2;

public class Application
{
    public string Adi { get; set; }
    public decimal MezuniyetDerecesi { get; set; }
    public int DilSeviyesi { get; set; }
    public int TecrubeYili { get; set; }
    public bool KabulEdildiMi { get; set; }
}

public abstract class ApplicationHandler
{
    protected ApplicationHandler nextHandler;

    public void SetNextHandler(ApplicationHandler handler)
    {
        nextHandler = handler;
    }

    public abstract void CheckUserForJob(Application application);
}

public class MezuniyetDerecesiHandler : ApplicationHandler
{
    public override void CheckUserForJob(Application application)
    {
        if(application.MezuniyetDerecesi >= 3.5m)
        {
            application.KabulEdildiMi = true;
        }else if(nextHandler != null)
        {
            nextHandler.CheckUserForJob(application);
        }
    }
}

public class DilSeviyesiHandler : ApplicationHandler
{
    public override void CheckUserForJob(Application application)
    {
        if (application.DilSeviyesi >= 3)
        {
            application.KabulEdildiMi = true;
        }
        else if (nextHandler != null)
        {
            nextHandler.CheckUserForJob(application);
        }
    }
}

public class TecrubeYiliHandler : ApplicationHandler
{
    public override void CheckUserForJob(Application application)
    {
        if (application.TecrubeYili >= 1)
        {
            application.KabulEdildiMi = true;
        }
        else if (nextHandler != null)
        {
            nextHandler.CheckUserForJob(application);
        }
    }
}
