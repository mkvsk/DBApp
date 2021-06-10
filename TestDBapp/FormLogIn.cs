using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDBapp;
using System.Data.Sql;
using MySql.Data.MySqlClient;

namespace DataBaseApp
{
	public partial class FormLogIn : Form
	{
		const string USERNAME_P = "root";
		const string PASSWORD_P = "1339";

		const string EMPTY_STRING = "";
		const string ERROR_TRY_AGAIN = "try again";
		const string ERROR_INCORRECT_PASSWORD = "incorrect password try again";
		const string INFO_ENTER_USERNAME = "enter username";
		const string INFO_ENTER_PASSWORD = "enter password";

		int stepNumber = 1;
		string username = "";
		string password = "";

		private static readonly Color darkRed = Color.FromArgb(224, 96, 85);
		private static readonly Color lightViolet = Color.FromArgb(111, 92, 195);
		private static readonly Color bgGrey = Color.FromArgb(237, 237, 237);
		private static readonly Color lightGrey = Color.FromArgb(233, 236, 239);

		private static readonly Color colorButtonActivateBG = Color.FromArgb(33, 150, 243);
		private static readonly Color colorButtonDiactivateBG = Color.FromArgb(108, 117, 125);

		public FormLogIn()
		{
			InitializeComponent();
		}

		private void buttonNextStep_diactivate()
		{
			buttonNextStep.Enabled = false;
			buttonNextStep.BackColor = colorButtonDiactivateBG;
		}

		private void buttonNextStep_activate()
		{
			buttonNextStep.Enabled = true;
			buttonNextStep.BackColor = colorButtonActivateBG;
		}

		private void buttonNextStep_Click(object sender, EventArgs e)
		{	
			
			if (stepNumber == 1)
			{
				username = textBoxDataToEnter.Text;

				if ((!(username.Equals(USERNAME_P)) || (username.Equals(INFO_ENTER_USERNAME))))
				{
					textBoxDataToEnter.Text = ERROR_TRY_AGAIN;
					textBoxDataToEnter.ForeColor = darkRed;
					buttonNextStep_diactivate();
				}
				else if (username.Equals(USERNAME_P))
				{
					textBoxDataToEnter.Text = EMPTY_STRING;
					stepNumber = 2;
					textBoxDataToEnter.Text = INFO_ENTER_PASSWORD;
					textBoxDataToEnter.ForeColor = lightGrey;
					pictureBoxPassword.Visible = true;
					buttonNextStep_diactivate();
				}
			}
			else if (stepNumber == 2)
			{				
				showLoader();
			}
		}

		private async void showLoader()
		{
			labelLog.Visible = false;
			panelDataToEnter.Visible = false;
			buttonNextStep.Visible = false;
			Loader.Visible = true;

			await Task.Delay(1000);

			labelLog.Visible = true;
			panelDataToEnter.Visible = true;
			buttonNextStep.Visible = true;
			Loader.Visible = false;

			if (password.Equals(PASSWORD_P))
			{
				stepNumber = 3;
				openDB();
			}
			else
			{
				textBoxDataToEnter.Text = ERROR_INCORRECT_PASSWORD;
				textBoxDataToEnter.ForeColor = darkRed;
				textBoxDataToEnter.UseSystemPasswordChar = false;
				buttonNextStep_diactivate();

				stepNumber = 2;
			}
		}

		private void openDB()
		{
			this.Hide();
			FormMain newForm = new FormMain();
			newForm.Show();
		}

		private void textBoxDataToEnter_Click(object sender, EventArgs e)
		{

			if (textBoxDataToEnter.Text.Equals(INFO_ENTER_USERNAME)
				|| textBoxDataToEnter.Text.Equals(ERROR_TRY_AGAIN)
				|| textBoxDataToEnter.Text.Equals(INFO_ENTER_PASSWORD)
				|| textBoxDataToEnter.Text.Equals(ERROR_INCORRECT_PASSWORD))
			{
				if (stepNumber == 1)
				{
					textBoxDataToEnter.Text = EMPTY_STRING;
					textBoxDataToEnter.ForeColor = colorButtonActivateBG;
				}
				else if (stepNumber == 2)
				{
					textBoxDataToEnter.Text = EMPTY_STRING;
					textBoxDataToEnter.ForeColor = colorButtonActivateBG;
					textBoxDataToEnter.UseSystemPasswordChar = true;
				}
			}

		}

		private void textBoxDataToEnter_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back))
			{
				e.Handled = true;
			}
		}

		private void textBoxDataToEnter_TextChanged(object sender, EventArgs e)
		{
			username = textBoxDataToEnter.Text;
			password = textBoxDataToEnter.Text;

			if (username.Length > 2 || password.Length > 2)
			{
				buttonNextStep_activate();
			}
			else if (username.Length <= 2 || password.Length <= 2)
			{
				buttonNextStep_diactivate();
			}
		}

		private void textBoxDataToEnter_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				buttonNextStep.Focus();
				buttonNextStep_Click(sender, e);               
			}
		}

		private void FormLogIn_FormClosed(object sender, FormClosedEventArgs e)
		{
			//this.Hide();
			Application.Exit();
		}

		private void FormLogIn_Load(object sender, EventArgs e)
		{
			buttonNextStep_diactivate();
		}

		public class User
		{
			string username;
			string password;
			string access_key;

			public User(
				string username,
				string password,
				string accessKey
				)
			{
				this.username = username;
				this.password = password;
				this.access_key = accessKey;
			}

			public string getUsername()
			{
				return username;
			}

			public string getPassword()
            {
				return password;
            }

			public string getAccessKey()
            {
				return access_key;
            }

		}
	}
}