using AbstractFactory.Pattern.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Pattern.Factory
{
    public interface IUIControlsFactory
    {
        IUIControl getButton();
        IUIControl getTextBox();
        IUIControl getComboBox();
    }
}
