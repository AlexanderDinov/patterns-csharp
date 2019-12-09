using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Pattern.Controls
{
    public class LinuxTextBox : IUIControl
    {
        public string getName()
        {
            return "LinuxTextBox";
        }
    }
}
