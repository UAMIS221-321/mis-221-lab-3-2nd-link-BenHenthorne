//main start
class Program{
    
    static void Main(){
        string enjoymentLevel = "";
        while(enjoymentLevel != "exit"){
            Menu();
            enjoymentLevel = GetEnjoymentLevel().ToLower();
            if(enjoymentLevel == "exit"){
                Exit();
                break;
            }
            string stadium = GetStadiumRecommendation(enjoymentLevel);
            if(stadium != ""){
                string game = GetGameRecommendation(stadium);
                DisplayStadiumDetails(stadium, game);
            }
        }
    }
    //main end

    static void Menu(){
        Console.Clear();
        System.Console.WriteLine("Welcome to College Football Intro\n"); //Menu intro
    }

    static string GetEnjoymentLevel(){
        System.Console.WriteLine("Please select your preferred enjoyment level:\nBoring\nAverage\nFun\nEpic\n\nEnter 'Exit' to close\n");
        return (Console.ReadLine());
    }

    static string GetStadiumRecommendation(string enjoymentLevel){
        switch(enjoymentLevel){
            case "boring":
                return "Neyland Stadium"; //boring stadium
            case "average":
                return "Jordan-Hare Stadium"; //average stadium
            case "fun":
                return "Tiger Stadium"; //fun stadium
            case "epic":
                return "Saban Field at Bryant-Denny Stadium"; //epix staduim
            default:
                System.Console.WriteLine("Invalid enjoyment level."); //entering the wrong input will output invalid enjoymnent levels
                Pause();
                return "";
        }
    }

    static string GetGameRecommendation(string stadium){
        switch(stadium){
            case "Neyland Stadium":
                return "Tennessee vs Kent State";
            case "Jordan-Hare Stadium":
                return "Auburn vs Kentucky";
            case "Tiger Stadium":                        //all of the recommended games
                return "LSU vs Alabama";
            case "Saban Field at Bryant-Denny Stadium":
                return "Alabama vs Auburn";
            default:
                return "No game scheduled";
            
        } 
    }

    static void DisplayStadiumDetails(string stadium, string game){
        if(stadium != "" && game != ""){
            Console.Clear();
            System.Console.WriteLine($"Best Stadium to visit: {stadium}\nBest Game to see: {game}"); //recommedation 
        }
        Pause();
    }

    static void Pause(){
        System.Console.WriteLine("\nPress any key to return to Menu\n"); //return to menu
        Console.ReadKey();
    }

    static void Exit(){
        Console.WriteLine("\nClosing program. Thank you for using College Football Intro\n"); //closing propmt
    }
}