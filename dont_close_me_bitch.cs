using System;
using System.Collections.Generic;
using System.Text;
using System.Resources;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Runtime.InteropServices;
using System.Threading;
using System.Xml.Serialization;
using System.Windows;


namespace The_Virus
{
    class Dont_close_me_bitch
    {


        public static void Check()
        {
            Boolean i = true;
            while (i == true) //Starting a loop
            {
                Process[] pname = Process.GetProcessesByName("DONG"); //Checking if a process called DONG exists
                if (pname.Length == 0) //If it don't exists
                {
                    ThreadStart bite = new ThreadStart(Restart_main_process); //Creating a thread for restarting it
                    Thread dans_mes_frites = new Thread(bite);
                    dans_mes_frites.Start(); //Starting it
                    MessageBox.Show("You tried to close me, huh.", "Fuck you, you dumbass", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.DefaultDesktopOnly); //Fuck You.
                    //Disgust = +2; //You are REALLY Disgusting
                    //Settings1.Default.Disgust = Disgust; //In fact you'll maybe close me so duh, I know you, ya know

                }
                else //If it Exists
                {
                    //Then you're broke, lol
                }


            }
        }
        public static void Restart_main_process()
        {
            MainWindow win2 = new MainWindow(); //Creating the window
            win2.Show(); //Show it
        }
    }
}
