using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace PasswordStrengthApplication
{
    public partial class Register : System.Web.UI.Page
    {

        //     protected void Page_Load(object sender, EventArgs e) {}

        protected void btnRegister_Click(object sender, EventArgs e)
            {
                string password = txtPassword.Text;

                // Perform server-side validation
                if (!IsStrongPassword(password))
                {
                    lblErrorMessage.Text = "Password must meet complexity requirements.";
                    lblErrorMessage.Visible = true;
                    return;
                }

                // Registration logic here
            }

            private bool IsStrongPassword(string password)
            {
                // Password complexity requirements
                int minLength = 8;
                int minDigitCount = 1;
                int minUpperCaseCount = 1;
                int minLowerCaseCount = 1;

                // Check password length
                if (password.Length < minLength)
                    return false;

                // Check for at least one digit
                if (password.Count(char.IsDigit) < minDigitCount)
                    return false;

                // Check for at least one uppercase letter
                if (password.Count(char.IsUpper) < minUpperCaseCount)
                    return false;

                // Check for at least one lowercase letter
                if (password.Count(char.IsLower) < minLowerCaseCount)
                    return false;

                // Additional complexity checks can be added here
                // For example, checking for special characters

                return true;
            }
    }
 }