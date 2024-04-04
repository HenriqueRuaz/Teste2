using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//No ai needed
//No copypast

namespace Teste2{
    internal class Program{
        static void Main(string[] args){

            string exit = "x";      //proceed the loop
            Console.Write("Enter your name: ");
            
            string name = Console.ReadLine();
            
            Console.WriteLine($"User32_Windows: {name}");
            Console.WriteLine($"Hello {name} What do you want to do?");
            Console.WriteLine("");

            while (exit != "z"){        //while exit is different
                
                while(exit == "x"){ 

                    Console.WriteLine("- Calculator [1]");
                    Console.WriteLine("- Mad Lib    [2]");
                    Console.WriteLine("- Just Talk  [3]");
                    Console.Write(">>> ");
                    int choose = Convert.ToInt32(Console.ReadLine());
                        
                    if(choose == 1){
                        
                        double k1, k2;
                        string op;
                            
                        Console.WriteLine("Choose an oporator: [+] [-] [*] [/]");
                        Console.Write(">>> ");
                        op = Console.ReadLine();


                        Console.Write("Choose a number: ");
                        k1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Choose another number: ");
                        k2 = Convert.ToDouble(Console.ReadLine());
                            
                        if(op == "+"){
                            double sum = k1 + k2;
                            Console.WriteLine($"{k1} + {k2} = {sum}");
                        }else if(op == "-"){
                            double sub = k1 - k2;
                            Console.WriteLine($"{k1} - {k2} = {sub}");       
                        }else if(op == "*"){
                            double mult = k1 * k2;
                            Console.WriteLine($"{k1} * {k2} = {mult}");
                        }else if(op == "/"){
                            double div = k1 / k2;
                            Console.WriteLine($"{k1} / {k2} = {div}");
                        }else{
                            Console.WriteLine("Something's wrong!");
                        }
                    }
                    
                     
                    if(choose == 2){
                        Console.WriteLine("Enter a color");
                        string color = Console.ReadLine();
                        Console.WriteLine("Enter a plural noun");
                        string pluralnoun = Console.ReadLine();
                        Console.WriteLine("Enter a celebrity name: ");
                        string celebrity = Console.ReadLine();

                        Console.WriteLine("");
                        Console.WriteLine("The sky is " + color);
                        Console.WriteLine($"And {pluralnoun} are fake");
                        Console.WriteLine("You hate " + celebrity);

                    }


                    if(choose == 3){
                        string talk;
                        string opcion;

                        Console.WriteLine("What do you want to talk about?");
                        Console.WriteLine("Life [1]");
                        Console.WriteLine("Games [2]");
                        Console.WriteLine("Future [3]");
                        Console.Write(">>> ");
                        talk = Console.ReadLine();
                                                                    //No one will run this so...
                        if(talk == "1"){
                            
                            Console.WriteLine("Feelings [a]");
                            Console.WriteLine("Quotes [b]");
                            Console.WriteLine("Important [c]");
                            Console.Write(">>> ");
                            opcion = Console.ReadLine();

                            if(opcion == "a"){
                                Console.WriteLine("How can someone be happy if there's nothing to fight for...");

                            }else if(opcion == "b"){
                                Console.WriteLine("The greatest act of responsibility is accepting that we are the ones who are wrong.");

                            }else if(opcion == "c"){ 
                                Console.WriteLine("Don't give up");

                            }else{
                                Console.WriteLine("Something's wrong!");

                            }
                        }else if(talk == "2"){
                            
                            Console.WriteLine("My favorite [a]");
                            Console.WriteLine("League of legends [b]");
                            Console.WriteLine("Addiction [c]");
                            Console.Write(">>> ");
                            opcion = Console.ReadLine();

                            if(opcion == "a"){
                                Console.WriteLine("Ori and the Blind Florest ");

                            }else if(opcion == "b"){
                                Console.WriteLine("nickname: lonlxx, main Kindred.");

                            }else if(opcion == "c"){ 
                                Console.WriteLine("Hollow Knight, Minecraft, Terraria, The Binding of Isaac ");

                            }else{
                                Console.WriteLine("Something's wrong!");

                            }
                        }else if (talk == "3"){
                            
                            Console.WriteLine("What I'm going to do [a]");
                            Console.WriteLine("My goals [b]");
                            Console.WriteLine("Kind of person I will be [c]");
                            Console.Write(">>> ");
                            opcion = Console.ReadLine();

                            if(opcion == "a"){
                                Console.WriteLine("Being a programmer ");

                            }else if(opcion == "b"){
                                Console.WriteLine("Creating a game named: Dawn Light ");

                            }else if(opcion == "c"){ 
                                Console.WriteLine("Probably, a person of limited wisdom ");

                            }else{
                                Console.WriteLine("Something's wrong!");

                            }
                        }else{
                            Console.WriteLine("Something's wrong!");
                        }

                    }
                    
                    Console.WriteLine("");
                    Console.WriteLine("Press [x] to continue, press [z] to exit!");
		            exit = Console.ReadLine();
                }
            }
        }
    }
}