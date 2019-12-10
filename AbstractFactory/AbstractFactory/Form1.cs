using AbstractFactory.Pattern.Controls;
using AbstractFactory.Pattern.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
    public partial class Form1 : Form
    {
        enum UIControls { cLinux, cWindows };

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            IUIControlsFactory factory = null;

            switch ((UIControls)this.cbOSControls.SelectedIndex)
            {
                case UIControls.cLinux:
                    factory = new LinuxUIFactory();
                    break;

                case UIControls.cWindows:
                    factory = new WindowsUIFactory();
                    break;

                default:
                    MessageBox.Show("Не сте избрали OS за UI контролите!");
                    return;
            }

            IUIControl button = factory.getButton();
            IUIControl textbox = factory.getTextBox();
            IUIControl combobox = factory.getComboBox();
            IUIControl label = factory.getLabel();

            this.tbUIControls.Clear();
            this.tbUIControls.AppendText("Button type: " + button.getName() + Environment.NewLine);
            this.tbUIControls.AppendText("ComboBox type: " + combobox.getName() + Environment.NewLine);
            this.tbUIControls.AppendText("TextBox type: " + textbox.getName() + Environment.NewLine);
            this.tbUIControls.AppendText("Label type: " + label.getName() + Environment.NewLine);
        }
    }
}
