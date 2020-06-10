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
        //this was made so it can be used in every form, without reusing the same code
        public SwitchForms(Employee employee, Form currentForm,Form formToOpen) //this was made so it can be used in every form, without reusing the same code
        {
            /*
             * Check for every role if it has access to the specific form, if not, show warning
             * 
             * Acces:
             * Waiter - Table Overview and EditForm
             * Bartender - BarKitchenForm
             * Chef - BarKitchenForm
             * Manager - Everythinng
             */
            switch (employee.role)
            {
                case Roles.Waiter:
                    if (!(formToOpen is tableViewForm || formToOpen is EditForm))
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
