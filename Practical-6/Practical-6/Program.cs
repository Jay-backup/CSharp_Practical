public delegate void Notify();
public class ProcessBusinessLogic
{
    public event Notify? ProcessComplete;

    public void StratProcess()
    {
        Console.WriteLine("Process Started!!");
        // some code here...
        OnProcessCompleted();
    }

    protected virtual void OnProcessCompleted()
    {
        //if ProcessCompleted is not null then call delegate
        Console.WriteLine("Process is running...");

        ProcessComplete?.Invoke();
    }
}

class Program
{
    static void Main(string[] args)
    {
        ProcessBusinessLogic pbl = new ProcessBusinessLogic();
        pbl.ProcessComplete += bl_ProcessCompleted;
        pbl.StratProcess();

        void bl_ProcessCompleted()
        {
            Console.WriteLine("Method Invoked!!");
        }
        
    }
}