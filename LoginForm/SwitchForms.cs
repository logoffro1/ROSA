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
        private Form currentForm;
        private Form formToOpen;

        //this was made so it can be used in every form, without reusing the same code

        /*
        * Check for every role if it has access to the specific form, if not, show warning
        * Acces:
        * Waiter - Table Overview and EditForm
        * Bartender - BarKitchenForm
        * Chef - BarKitchenForm
        * Manager - Everythinng
        */
        public SwitchForms(Employee employee, Form currentForm, Form formToOpen) //this was made so it can be used in every form, without reusing the same code
        {

            this.currentForm = currentForm;
            this.formToOpen = formToOpen;

            if (formToOpen is loginForm || formToOpen is homeForm) //everyone has acces to those forms
                ShowHideForms(formToOpen);
            else
                switch (employee.role)
                {
                    case Roles.Waiter:
                        if (!(formToOpen is tableViewForm || formToOpen is EditForm || formToOpen is paymentForm))
                            MessageBox.Show($"Acces Denied!{Environment.NewLine}Your role does not have permission!", "Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                            ShowHideForms(formToOpen);
                        break;
                    case Roles.Bartender:
                        if (!(formToOpen is BarKitchenForm))
                            MessageBox.Show($"Acces Denied!{Environment.NewLine}Your role does not have permission!", "Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                            ShowHideForms(formToOpen);
                        break;
                    case Roles.Chef:
                        if (!(formToOpen is BarKitchenForm))
                            MessageBox.Show($"Acces Denied!{Environment.NewLine}Your role does not have permission!", "Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                            ShowHideForms(formToOpen);
                        break;
                    default:
                        ShowHideForms(formToOpen);
                        break;
                }
            //ShowHideForms();
        }
        private void ShowHideForms(Form a)
        {
            if (a != currentForm)
            {
                a.Show();
                currentForm.Hide();
            }
        }
    }
}
