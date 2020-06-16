using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFUI.Views;
using WPFUI.Models;

namespace WPFUI.ViewModels
{
        public class FirstViewModel : Screen 
        {
                public string _Person_Name = "";

                public string FirstName
                {
                        get
                        {
                                return _Person_Name;
                        }
                        set
                        {
                                _Person_Name = value;
                        }
                }
                public string Name
                {
                        get
                        {
                                return _Person_Name;
                        }

                }
                public void SecondWindow()
                {
                        if(_Person_Name == "")
                        {
                                MessageBox.Show("Trebuie sa iti introduci numele pentru a incepe!");
                                return;
                        }
                        IWindowManager obj = new  WindowManager();
                        obj.ShowWindow(new SecondViewModel(_Person_Name), null);
                        TryClose();
                }
        }
}
