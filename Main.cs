using System;
using System.Collections.Generic;
using System.Linq;

namespace ExceptionHandlingTask_DanDavison
{
    class MainMenu
    {
        public Class log;

        public MainMenu(){
            this.log = new Class();
        }

        public void Room()
        {
            List<string> rooms = new List<string>() 
            {"TD224", "AGSE111"};
            System.Console.WriteLine("________________________________");
            System.Console.WriteLine("Welcome to Classroom sign in!");
            System.Console.WriteLine("Current rooms available:");
            System.Console.WriteLine();

            foreach (string roomNo in rooms ){
                System.Console.WriteLine("+ " + roomNo);
            }
            System.Console.WriteLine("________________________________");
            System.Console.WriteLine("Input Room Number: ");
            string roomInput = System.Console.ReadLine();

            if (rooms.Contains(roomInput.ToUpper())){

                log.roomNo = roomInput.ToUpper();
                UserFN();
            }

            else{
                System.Console.WriteLine("********************************");
                System.Console.WriteLine("** Invalid input **");
                System.Console.WriteLine("Press any key to try again.");
                System.Console.WriteLine("********************************");
                System.Console.ReadKey();
                System.Console.WriteLine();
                Room();
            }
        }
        public void UserFN(){
            System.Console.WriteLine("________________________________");           
            System.Console.WriteLine("Input First Name: ");
            string nameInputFN = System.Console.ReadLine();
            System.Console.WriteLine("________________________________");
            bool intCheck = nameInputFN.Any(char.IsDigit);

            if( intCheck == true || nameInputFN == ""){
                System.Console.WriteLine("********************************");                
                System.Console.WriteLine("** Invalid input **");
                System.Console.WriteLine("Press any key to try again.");
                System.Console.WriteLine("********************************");
                System.Console.ReadKey();
                System.Console.WriteLine();
                UserFN();
            }
            
            else{
                log.firstName = nameInputFN;
                UserLN();
            }
        }
        public void UserLN(){  
            System.Console.WriteLine("Input Last Name: ");
            string nameInputLN = System.Console.ReadLine();
            System.Console.WriteLine("________________________________");  
            bool intCheck = nameInputLN.Any(char.IsDigit);

            if( intCheck == true || nameInputLN == ""){
                System.Console.WriteLine("********************************");
                System.Console.WriteLine("** Invalid input **");
                System.Console.WriteLine("Press any key to try again.");
                System.Console.WriteLine("********************************");
                System.Console.ReadKey();
                System.Console.WriteLine();
                UserLN();
            }
            
            else{
                log.lastName = nameInputLN;
                Entry();
            }
        }        
        public void Entry(){

            DateTime currentTime = DateTime.Now;
            System.Console.Write("Current Time: ");
            System.Console.Write(currentTime.ToString("dd/mm/yy hh:mm tt"));
            System.Console.WriteLine();
            System.Console.WriteLine("________________________________");  
            System.Console.WriteLine("Input Entry Date and Time: ");
            System.Console.WriteLine("Format must be - dd/mm/yy hh:mm tt");
            string entry = System.Console.ReadLine();
            System.Console.WriteLine("________________________________");  

            try{
                DateTime parsedEntryInput = DateTime.Parse(entry);
                log.entry = parsedEntryInput;
                Exit();
            }

            catch{
                System.Console.WriteLine("********************************");
                System.Console.WriteLine("** Invalid input **");
                System.Console.WriteLine("Press any key to try again.");
                System.Console.WriteLine("********************************");
                System.Console.ReadKey();
                System.Console.WriteLine();
                Entry();
            }
        }

        public void Exit(){
            System.Console.WriteLine();  
            System.Console.WriteLine("Input Exit Date and Time: ");
            System.Console.WriteLine("Format must be - dd/mm/yy hh:mm tt");
            string exit = System.Console.ReadLine();
            System.Console.WriteLine("________________________________");  

            try{
                DateTime parsedExitInput = DateTime.Parse(exit);
                log.exit = parsedExitInput;
                Duration();
            }

            catch{
                System.Console.WriteLine("********************************");
                System.Console.WriteLine("** Invalid input **");
                System.Console.WriteLine("Press any key to try again.");
                System.Console.WriteLine("********************************");               
                System.Console.ReadKey();
                System.Console.WriteLine();
                Exit();
            }
        }
        public void Duration(){

            TimeSpan duration = log.exit - log.entry;
            double time = Math.Round(duration.TotalMinutes, 0);
            log.duration = time;
            if(time <0){
                System.Console.WriteLine("********************************");
                System.Console.WriteLine("Error Occurred: Duration of stay cannot be negative");
                System.Console.WriteLine("Press any key to try again.");
                System.Console.WriteLine("********************************"); 
                System.Console.ReadKey();
                System.Console.WriteLine();
                Exit();
            }
            else{
               Report(); 
            }
        }
        public void Report(){
        {
            System.Console.WriteLine(); 
            System.Console.WriteLine("Room: " + log.roomNo);
            System.Console.WriteLine("Name: " + log.firstName + " " + log.lastName);
            System.Console.WriteLine("Entry: " + log.entry);
            System.Console.WriteLine("Exit: " + log.exit);
            System.Console.WriteLine("Duration: " + log.duration + " minute(s)" );
            System.Console.WriteLine("________________________________"); 
        }
    }
}
}