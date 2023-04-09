using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace application
{
    class Program
    {
        public static void Main(string[] args)
        {
            
           string[] names = new string[5];
             string[] passwords = new string[5];
            string path = "C:\\OOP week 1\\week1 pd\\user.txt";
            string ctach;
            readData(path, names, passwords);
            ctach = menuBar();
            while (true)
            {
                if (ctach == "1")
                {
                    int back = 0;
                    Console.Clear();
                    SignUp(names, passwords, path);
                    while (back != 4)
                    {
                        Console.WriteLine("Enter 4 to go back!!!!");
                        back = int.Parse(Console.ReadLine());
                        if (back != 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid Input!!!!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    if (back == 4)
                    {
                        Console.Clear();
                        ctach = menuBar();

                    }
                }
                if (ctach == "2")
                {

                    Console.Clear();
                    int back = 0;
                    bool check;
                    check = SignIn(names, passwords, path);
                    if (check == true)
                    {
                        Console.WriteLine("Success!!!!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid username or password!!!!");
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    while (back != 4)
                    {
                        Console.WriteLine("Enter 4 to go back!!!!");
                        back = int.Parse(Console.ReadLine());
                        if (back != 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid Input!!!!");
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                    }
                    if (back == 4)
                    {
                        Console.Clear();
                        ctach = menuBar();

                    }
                }
                if (ctach == "3")
                {
                    break;
                }
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("Thanks for using our application!!!!");
            Console.ReadKey();
        }
        static string menuBar()
        {
            Console.Clear();
            string option;
            Console.WriteLine("1:Sign Up!!!!!");
            Console.WriteLine("2:Sign In!!!!!");
            Console.WriteLine("3:Exit");
            Console.WriteLine("Enter your option!!!!");
            option= Console.ReadLine();
            return option;
        }
           static void SignUp(string[] names, string[] passwords , string path)
            {
            Console.Clear();
            bool flage=true;
            string name;
            string password;
            Console.WriteLine("Enter your new name!!!!");
            name = Console.ReadLine();
            Console.WriteLine("Enter your new password!!!!");
            password = Console.ReadLine();
            for(int i =0; i<5; i++)
            {
                if (name == names[i])
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("User Alreday Exists!!!!");
                    Console.ForegroundColor = ConsoleColor.Black;
                    flage = false;
                }
            }
            if(flage==true)
            {
                
                    Console.WriteLine("Success!!!!");
                StreamWriter file = new StreamWriter(path, false);                  
                    file.WriteLine(name + "," + password);
                    file.Flush();
                    file.Close();
               
            }
            }
        static bool SignIn(string[] names, string[] passwords, string path)
        {
            Console.Clear();
            bool found=false;
            string n;
            string p;
            Console.WriteLine("Enter your log in username!!!!");
            n = Console.ReadLine();
            Console.WriteLine("Enter your log in password!!!!");
            p = Console.ReadLine();
                for(int x=0; x <5; x++)
            {
                if(names[x]==n && passwords[x]==p)
                {
                    found = true;
                    break;
                }
                
            }
            return found;
        }
        static string ParseData(string record , int field)
        {
           
            int comma = 1;
            string item = "";
            for(int  x=0; x<record.Length; x++)
            {
                if(record[x]==',')
                {
                    comma++;
                }
                else if(comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        static void readData(string path,string[]names,string[]passwords)
        {
            int x = 0;
            if(File.Exists(path))
            {
                StreamReader filevariable = new StreamReader(path);
                string record;
                while((record=filevariable.ReadLine())!=null)
                {
                    names[x] = ParseData(record, 1);
                    passwords[x] = ParseData(record, 2);
                    x++;
                    if (x >= 5)
                    {
                        break;
                    }
                }
                filevariable.Close();
            }
        }
        static void removeUser(string[] names, string[] passwords, string path)
        {
            bool flage = false;
            string user;
            Console.WriteLine("Which user you want to remove?");
            user = Console.ReadLine();
            for(int x =0; x<5; x++)
            {
                if(user==names[x])
                {
                    names[x] = " ";
                    passwords[x] = " ";
                    Console.WriteLine("Removes Successfully!!!!");
                    flage = true;
                    for (int i=x;  i < 5 ; i++)
                    {
                        names[i] = names[i + 1];
                        passwords[i] = passwords[i + 1];
                        StoreToFile(names, passwords, path);
                    }
                }
            }
            if(flage==false)
            {
                Console.WriteLine("User NOT FOUND!!!!");
            }
        }
       static void StoreToFile(string[] names, string[] passwords,string path)
        {
            StreamWriter file1 = new StreamWriter(path, false);
            for (int x = 0; x < 5; x++)
            {
                file1.WriteLine(names[x] + "," + passwords[x]);
            }
            file1.Flush();
            file1.Close();
        }
    }
}
