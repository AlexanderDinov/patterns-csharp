using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Pattern.Controls;

namespace AbstractFactory.Pattern.Factory
{
    public class WindowsUIFactory : IUIControlsFactory
    {
        public IUIControl getButton() => new WindowsButton();

        public IUIControl getComboBox() => new WindowsComboBox();

        public IUIControl getLabel() => new WindowsLabel();

        public IUIControl getTextBox() => new WindowsTextBox();        
    }
}
