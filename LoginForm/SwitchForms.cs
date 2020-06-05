using System;
using System.Windows.Forms;
using RosaModel;
namespace LoginForm
{
    /// <summary>
    ///   SwitchForms class
    ///   Made by Cosmin Ilie
    ///   Student number: 645976
    /// </summary>
    class SwitchForms
    {
        public SwitchForms(Employee employee, Form currentForm,Form formToOpen)
        {
            switch (employee.role)
            {
                case Roles.Waiter:
                    if (!(formToOpen is tableViewForm))
                        MessageBox.Show($"Acces Denied!{Environment.NewLine}Your role does not have permission!","Denied",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    else
                    {
                        formToOpen.Show();
                        currentForm.Hide();
                    }
                    break;
                case Roles.Bartender:
                    if(!(formToOpen is BarKitchenForm))
                        MessageBox.Show($"Acces Denied!{Environment.NewLine}Your role does not have permission!", "Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        formToOpen.Show();
                        currentForm.Hide();
                     }            
                   break;
                case Roles.Chef:
                    if (!(formToOpen is BarKitchenForm))
                        MessageBox.Show($"Acces Denied!{Environment.NewLine}Your role does not have permission!", "Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    {
                        formToOpen.Show();
                        currentForm.Hide();
                    }
                    break;
                default:
                    formToOpen.Show();
                    currentForm.Hide();
                    break;
            }
        }
    }
}
