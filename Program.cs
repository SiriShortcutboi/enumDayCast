using System;

public class Program
{

    public static void Main()
    {
        int weekdaying = 4;
        switch ((weekDay)weekdaying)
        {
        
            case weekDay.Monday://you might leave the first empty to
                Console.WriteLine("That day is Monday");//show the playerstate as none
                break;
            case weekDay.Tuesday:
                Console.WriteLine("That day is Tuesday, " + 
                "the day before swing dancing night"); 
                break;
            case weekDay.Wednesday:
                Console.WriteLine("That day is Wednesday, swing dancing night");
                break;
            case weekDay.Thursday:
                Console.WriteLine("That day is Thursday"); 
                break;
            case weekDay.Friday:
                Console.WriteLine("That day is Friday");
                break;
            case weekDay.Saturday:
                Console.WriteLine("That day is Saturday, " + 
                "the day before swing dancing night"); 
                break;
                


            case weekDay.Sunday:
            Console.WriteLine(" That day is Sunday, the Lord's day");
                break;

        }
//it is very important to not have Magic Numbers
//in your code

    


    }

    enum weekDay
    {
        Monday = 1,
        Tuesday, 
        Wednesday, 
        Thursday, 
        Friday,
        Saturday, 
        Sunday, 
    }
}



/* 
//some boilerplate

switch (playerState)
{
    case playerState.None:
    case playerState.Idle:
        Console.WriteLine("Player is doing nothing");
        break;
    case PlayerState.Running:
    Console.WriteLine("player is running"); 
    break;
        


}
//it is very important to not have Magic Numbers
//in your code

Enum PlayerState
{
    None = 1,
    Idle, 
    Running, 
    Battling, 

} */