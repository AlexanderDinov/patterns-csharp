using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Pattern.Controls
{
    public class LinuxComboBox : IUIControl
    {
        public string getName()
        {
            return "LinuxComboBox";
        }
    }
}
