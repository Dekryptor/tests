using System;
using System.Timers;
using System.Threading.Tasks;
					
public class Program
{
	public static void Main()
	{
        var timer = new Timer(2000);
		timer.Elapsed += async (sender, eventArgs) =>
		{
			await Task.Run(() => OnEventExecution(sender, eventArgs));
		};
		
		timer.Start();
		Console.ReadKey();
	}
	
	public static void OnEventExecution(object sender, ElapsedEventArgs eventArgs)
    {
        Console.WriteLine($"Elapsed event at {eventArgs.SignalTime:G}");
    }
}
