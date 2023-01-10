using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoWindows.ViewModels.Base;

namespace TwoWindows.ViewModels
{
    internal class MainWindowViewModel : TitledViewModel
    {
        public MainWindowViewModel()
        {
            Title = "Главное окно";
        }
    }
}
