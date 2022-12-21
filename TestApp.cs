
public class TestApp
{

    public string Name { get; set; }
    public  void GetName()
    {
         Console.WriteLine("What is your Name ?");
       Name =  Console.ReadLine();
     
    }

    public  void SayGreeting()
    {
      //getting the current time to display the right greeting format
      //  DateTime.Now.ToString("h:mm:ss tt")
       var currentDateTime = DateTime.UtcNow; 
       var currentTimeAlone = new TimeSpan(currentDateTime.Hour, currentDateTime.Minute,    currentDateTime.Second); 
       Console.WriteLine(currentTimeAlone);
       
          DateTime currentTime = DateTime.Now;


            if (currentTime.Hour <= 12 && currentTime.Hour >= 1)
            {
                Console.WriteLine($"Good Morning {Name}");
            }
            else if (currentTime.Hour >= 12 && currentTime.Hour <= 16)
            {
                Console.WriteLine($"Good Afternoon {Name}");
            }
            else if (currentTime.Hour >= 16 && currentTime.Hour <= 20 )
            {
                Console.WriteLine($"Good Evening {Name}");
            }
            else if (currentTime.Hour >= 20 && currentTime.Hour <= 1 )
            {
                Console.WriteLine($"Good Night {Name}");
            }
            else 
            {
                Console.WriteLine($"Good Night {Name}");
            }

            Console.ReadKey();
    }

}