using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Pattern.Controls
{
    public class LinuxButton : IUIControl
    {
        public string getName()
        {
            return "LinuxButton";
        }
    }
}
