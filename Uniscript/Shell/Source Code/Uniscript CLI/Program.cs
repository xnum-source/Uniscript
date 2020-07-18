using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Xml;

namespace Uniscript_CLI
{
    
    class Program
    {
        private void NewLine()
        {
            Console.WriteLine(@"");
            Console.Write("uni-3.9.18.8 ~ (" + Environment.MachineName + ")\n$ " + @""
                );

        }
       
       
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(@"Uniscript 3.9.18.8 Command Line Interface
Created by Xyzdesk

To get more information about this specific type, go to xyzdesk.online/docs/3-9-18-8/about
");
            Console.WriteLine(@"");
            Console.Write("uni-3.9.18.8 ~ (" + Environment.MachineName + ")\n$ " + @""
                );

            string command = Console.ReadLine();

            if (command == "cdir()")
            {
                Console.WriteLine("Current Directory: " + Environment.CurrentDirectory);
                Console.WriteLine(@"");
                Console.Write("uni-3.9.18.8 ~ (" + Environment.MachineName + ")\n$ " + @""
                    );

                Console.ReadLine();
                Console.WriteLine(@"");
                Console.Write("uni-3.9.18.8 ~ (" + Environment.MachineName + ")\n$ " + @""
                    );
            }
            if(command == "help()")
            {
                Console.WriteLine(@"
Here is a list of commands: 
Basic
help() - Gets a list of commands

Audio and Video

AudioManager - Manage Audio and Play Audio
    AudioManager.Play(id) - Play an audio from List.Audio

Settings

");
                Console.ReadLine();
                Console.WriteLine(@"");
                Console.Write("uni-3.9.18.8 ~ (" + Environment.MachineName + ")\n$ " + @""
                    );
            }
            if(command == "help")
            {
                Console.WriteLine("For help say help(), help(command), help(calculate) or help(u).");
                Console.WriteLine(@"");
                Console.Write("uni-3.9.18.8 ~ (" + Environment.MachineName + ")\n$ " + @""
                    );

                Console.ReadLine();
                Console.WriteLine(@"");
                Console.Write("uni-3.9.18.8 ~ (" + Environment.MachineName + ")\n$ " + @""
                    );
            }
            
            if (command == "AudioManager.Play(1)") 
            {
                Console.Beep();
                Console.WriteLine(@"");
                Console.Write("uni-3.9.18.8 ~ (" + Environment.MachineName + ")\n$ " + @""
                    );

                Console.ReadLine();
                Console.WriteLine(@"");
                Console.Write("uni-3.9.18.8 ~ (" + Environment.MachineName + ")\n$ " + @""
                    );
            }
            if (command == "AudioManager")
            {
                Console.WriteLine(@"AudioManager Help
AudioManager.Play(number) - Plays a random noise based off of a integer in parenthesis");
                Console.WriteLine(@"");
                Console.Write("uni-3.9.18.8 ~ (" + Environment.MachineName + ")\n$ " + @""
                    );
                
                
                    Console.ReadLine();
                    Console.WriteLine(@"");
                    Console.Write("uni-3.9.18.8 ~ (" + Environment.MachineName + ")\n$ " + @""
                        );
                    
                
            }
            else
            {
               
                Console.ReadLine();
                Console.WriteLine(@"");
                Console.Write("uni-3.9.18.8 ~ (" + Environment.MachineName + ")\n$ " + @""
                    );

            };
        }
        
    }
}
