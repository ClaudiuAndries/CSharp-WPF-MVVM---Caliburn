using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFUI.ViewModels
{
        public class ThirdViewModel : Screen
        {

                public ThirdViewModel(string finalText)
                {
                        _FinalText = finalText;
                        NotifyOfPropertyChange(() => _FinalText);
                }
                public string _FinalText;

                public string FinalText
                {
                        get
                        {
                                return _FinalText;
                        }
                        
                }
                public void Pressed()
                {
                        TryClose();
                }
        }
}
