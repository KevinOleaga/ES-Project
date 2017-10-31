using System;

namespace ES.UI
{
    public partial class Login1 : System.Web.UI.Page
    {
        private static string _UserName, _Password;

        protected void Page_Load(object sender, EventArgs e)
        {
            divPassword.Visible = false;
            btnPassword.Visible = false;
            btnRestore.Visible = false;
            btnReturn.Visible = false;
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            txtUser.Text = string.Empty;

            divUser.Visible = true;
            btnUser.Visible = true;

            link.Visible = true;
        }

        protected void btnRestore_Click(object sender, EventArgs e)
        {
            Response.Redirect("ForgotPassword.aspx");
        }
        
        protected void btnPassword_Click(object sender, EventArgs e)
        {
            _Password = txtPassword.Text.ToUpper();

            if (_Password == "1234")
            {
                Response.Redirect("Index.aspx");
            }
        }

        protected void btnUser_Click(object sender, EventArgs e)
        {
            _UserName = txtUser.Text.ToUpper();

            if (_UserName == "ADMIN")
            {
                divUser.Visible = false;
                btnUser.Visible = false;

                divPassword.Visible = true;
                btnPassword.Visible = true;

                btnReturn.Visible = false;
                btnRestore.Visible = false;
            }            
        }
    }
}