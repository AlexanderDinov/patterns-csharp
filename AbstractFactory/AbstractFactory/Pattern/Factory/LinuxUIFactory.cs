using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Pattern.Controls;

namespace AbstractFactory.Pattern.Factory
{
    public class LinuxUIFactory : IUIControlsFactory
    {
        public IUIControl getButton() => new LinuxButton();

        public IUIControl getComboBox() => new LinuxComboBox();

        public IUIControl getLabel() => new LinuxLabel();        

        public IUIControl getTextBox() => new LinuxTextBox();
        
    }
}
