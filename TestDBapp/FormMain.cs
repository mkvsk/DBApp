using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestDBapp
{
	public partial class FormMain : Form
	{	

		SqlConnection sqlConnection;
		string connectionString = @"Data Source=DESKTOP-1Q2BQKB;Initial Catalog=mts_db;Integrated Security=True";

		public Boolean isRotatedFullName = false;
		public Boolean isFirstClickFullName = true;

		public Boolean isAscendingFullNameColumn = true;
		public Boolean isAscendingPhoneNumberColumn = true;
		public Boolean isAscendingRegistrationDateColumn = true;
		public Boolean isAscendingActivityColumn = true;
		public Boolean isAscendingTariffPlanColumn = true;

		private int idToChange;

		public FormMain()
		{
			InitializeComponent();

			panelDetailedInfo.Visible = false;
			buttonSaveDetailedInfo.Enabled = false;			
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.abonents". При необходимости она может быть перемещена или удалена.
            this.abonentsTableAdapter.Fill(this.dataSet.abonents);

            sqlConnection = new SqlConnection(connectionString);

			await sqlConnection.OpenAsync();

			totalAbonentsCount();
			activeAbonentsCount();

          
		}

		private void totalAbonentsCount()
		{
			int amount_abonents = dataGridView.DisplayedRowCount(true);
			textBoxTotalAbonentsCount.Text = amount_abonents.ToString();
        }

		private void activeAbonentsCount()
        {
			int counter = 0;
			DataGridViewCheckBoxColumn activityCol = new DataGridViewCheckBoxColumn();
			activityCol.FalseValue = false;

			foreach(DataGridViewRow row in dataGridView.Rows)
            {
				object value = row.Cells[3].Value;
				
				if (value != null && (Boolean)value)
                {
					counter++;
                }
            }
			textBoxActiveAbonentsCount.Text = counter.ToString();
		}

		private void sortAscending(DataGridViewTextBoxColumn dataColumn, PictureBox pictureBox)
		{	
			dataGridView.Sort(dataColumn, ListSortDirection.Ascending);
			pictureBox.Image = TestDBapp.Properties.Resources.ascending;
		}

		private void sortDescending(DataGridViewTextBoxColumn dataColumn, PictureBox pictureBox)
		{
			dataGridView.Sort(dataColumn, ListSortDirection.Descending);
			pictureBox.Image = TestDBapp.Properties.Resources.descending;
		}

		private void buttonFullNameDataSort_Click(object sender, EventArgs e)
		{
			if (isAscendingFullNameColumn)
			{
				sortDescending(fullnameDataGridViewTextBoxColumn, pictureBoxArrowFullName);
				isAscendingFullNameColumn = false;
			}
			else
			{
				sortAscending(fullnameDataGridViewTextBoxColumn, pictureBoxArrowFullName);
				isAscendingFullNameColumn = true;
			}
		}

		private void buttonNumberMainDataSort_Click(object sender, EventArgs e)
		{
			
			if (isAscendingPhoneNumberColumn)
			{
				sortDescending(phonenumbermainDataGridViewTextBoxColumn, pictureBoxArrowFullName);
				isAscendingPhoneNumberColumn = false;
			}
			else
			{
				sortAscending(phonenumbermainDataGridViewTextBoxColumn, pictureBoxArrowFullName);
				isAscendingPhoneNumberColumn = true;
			}
		}

		private void buttonRegistrationDateDataSort_Click(object sender, EventArgs e)
		{
			if (isAscendingRegistrationDateColumn)
			{

				sortDescending(registrationdateDataGridViewTextBoxColumn, pictureBoxArrowRegistrationDate);
				isAscendingRegistrationDateColumn = false;
			}
			else
			{
				sortAscending(registrationdateDataGridViewTextBoxColumn, pictureBoxArrowRegistrationDate);
				isAscendingRegistrationDateColumn = true;
			}
		}

		private void buttonActivityDataSort_Click(object sender, EventArgs e)
		{
			if (isAscendingActivityColumn)
			{
				sortDescending(activityDataGridViewTextBoxColumn, pictureBoxArrowActivity);
				isAscendingActivityColumn = false;
			}
			else
			{
				sortAscending(activityDataGridViewTextBoxColumn, pictureBoxArrowActivity);
				isAscendingActivityColumn = true;
			}
		}

		private void buttonTariffPlanDataSort_Click(object sender, EventArgs e)
		{
			if (isAscendingTariffPlanColumn)
			{
				sortDescending(tariffplanDataGridViewTextBoxColumn, pictureBoxArrowTariffPlan);
				isAscendingTariffPlanColumn = false;
			}
			else
			{
				sortAscending(tariffplanDataGridViewTextBoxColumn, pictureBoxArrowTariffPlan);
				isAscendingTariffPlanColumn = true;
			}
		}

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {	
			

			string strValue = "";
			strValue = e.RowIndex.ToString();

			

			if (e.RowIndex == -1)
			{
				clearDetailedInfoTextBoxes();
			}
			else
			{
				DataGridViewRow dr = dataGridView.Rows[e.RowIndex];
				DataGridViewCellCollection dataColumnList = dr.Cells;

				panelDetailedInfo.Visible = true;
				//pictureBoxDarkness.Visible = true;

				string full_name_detailed = dataColumnList[0].Value.ToString();
				string phone_number_detailed = dataColumnList[1].Value.ToString();
				string passport_number_detailed = dataColumnList[5].Value.ToString();
				string tariff_plan_detailed = dataColumnList[4].Value.ToString();
				DateTime registration_date_detailed = DateTime.Parse(dataColumnList[2].Value.ToString());
				bool activity_detailed = Boolean.Parse(dataColumnList[3].Value.ToString());

				idToChange = Int32.Parse(dataColumnList[6].Value.ToString());

				string[] fio = full_name_detailed.Split();
				textBoxDetailedSecondName.Text = fio[0];
				textBoxDetailedFirstName.Text = fio[1];
				textBoxDetailedMiddleName.Text = fio[2];

				textBoxDetailedPhoneNumber.Text = phone_number_detailed;
				textBoxDetailedPassportNumber.Text = passport_number_detailed;
				dateTimeDetailedRegistrationDate.Value = registration_date_detailed;
				textBoxDetailedTariffPlan.Text = tariff_plan_detailed;
				checkBoxDetailedInfoStatus.Checked = activity_detailed;
			}

		}

        private void buttonDetailedInfoCancel_Click(object sender, EventArgs e)
        {
			buttonSaveDetailedInfo.Enabled = false;
			buttonEditDetailedInfo.Enabled = true;
			panelDetailedInfo.Visible = false;
			panelMessageBox.Visible = false;

			disableDetailedInfoTextBoxes();

			//pictureBoxDarkness.Visible = false;
		}

        private void buttonEditDetailedInfo_Click(object sender, EventArgs e)
        {
			buttonSaveDetailedInfo.Enabled = true;
			buttonEditDetailedInfo.Enabled = false;

			enableDetailedInfoTextBoxes();
		}

        private void buttonSaveDetailedInfo_Click(object sender, EventArgs e)
        {
			string full_name_detailed = String.Join(
				" ", 
				textBoxDetailedSecondName.Text, 
				textBoxDetailedFirstName.Text, 
				textBoxDetailedMiddleName.Text
				);

			string phone_number_detailed = textBoxDetailedPhoneNumber.Text;
			string passport_number_detailed = textBoxDetailedPassportNumber.Text;
			string tariff_plan_detailed = textBoxDetailedTariffPlan.Text;
			DateTime registration_date_detailed = dateTimeDetailedRegistrationDate.Value;
			bool activity_detailed = checkBoxDetailedInfoStatus.Checked;
			//idToChange


			//РЕАЛИЗОВАТЬ ОБНОВЛЕНИЕ В БАЗЕ ДАННЫХ ЧЕРЕЗ UPDATE ПО id

			disableDetailedInfoTextBoxes();

			buttonSaveDetailedInfo.Enabled = false;
			buttonEditDetailedInfo.Enabled = true;

			/*abonentsBindingSource.EndEdit();
			abonentsTableAdapter.Update(dataSet.abonents);*/
		}

		private void buttonAddNewAbonent_Click(object sender, EventArgs e)
        {
			panelDetailedInfo.Visible = true;

			buttonSaveDetailedInfo.Enabled = true;
			buttonEditDetailedInfo.Enabled = false;

			enableDetailedInfoTextBoxes();
			clearDetailedInfoTextBoxes();
						
			//abonentsBindingSource.AddNew();
		}

		private void enableDetailedInfoTextBoxes()
		{
			textBoxDetailedSecondName.Enabled = true;
			textBoxDetailedFirstName.Enabled = true;
			textBoxDetailedMiddleName.Enabled = true;
			textBoxDetailedPhoneNumber.Enabled = true;
			textBoxDetailedPassportNumber.Enabled = true;
			dateTimeDetailedRegistrationDate.Enabled = true;
			textBoxDetailedTariffPlan.Enabled = true;
			checkBoxDetailedInfoStatus.Enabled = true;
		}

		private void disableDetailedInfoTextBoxes()
		{
			textBoxDetailedSecondName.Enabled = false;
			textBoxDetailedFirstName.Enabled = false;
			textBoxDetailedMiddleName.Enabled = false;
			textBoxDetailedPhoneNumber.Enabled = false;
			textBoxDetailedPassportNumber.Enabled = false;
			dateTimeDetailedRegistrationDate.Enabled = false;
			textBoxDetailedTariffPlan.Enabled = false;
			checkBoxDetailedInfoStatus.Enabled = false;
		}

		private void clearDetailedInfoTextBoxes()
        {
			textBoxDetailedSecondName.Text = "";
			textBoxDetailedFirstName.Text = "";
			textBoxDetailedMiddleName.Text = "";
			textBoxDetailedPhoneNumber.Text = "";
			textBoxDetailedPassportNumber.Text = "";
			dateTimeDetailedRegistrationDate = null;
			textBoxDetailedTariffPlan.Text = "";
			checkBoxDetailedInfoStatus.Checked = false;
		}

        private void buttonDeleteDetailedInfo_Click(object sender, EventArgs e)
        {
			buttonSaveDetailedInfo.Enabled = false;
			buttonEditDetailedInfo.Enabled = false;

			disableDetailedInfoTextBoxes();

			panelMessageBox.Visible = true;		
		}

        private void buttonNoMessBox_Click(object sender, EventArgs e)
        {
			buttonSaveDetailedInfo.Enabled = true;
			buttonEditDetailedInfo.Enabled = false;

			panelMessageBox.Visible = false;
		}

		private void buttonYesMessBox_Click(object sender, EventArgs e)
        {
			buttonSaveDetailedInfo.Enabled = false;
			buttonEditDetailedInfo.Enabled = false;

			panelMessageBox.Visible = false;	
		}

        private void textBoxFullNameSearch_KeyDown(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.Enter)
			{
				e.Handled = true;
				dataGridView.CurrentCell = null;

				for (int i = 0; i < dataGridView.RowCount; i++)
				{
					dataGridView.Rows[i].Selected = false;

					for (int j = 0; j < dataGridView.ColumnCount; j++)
					{
						if (dataGridView.Rows[i].Cells[j].Value != null)
						{
							if (dataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBoxFullNameSearch.Text))
							{
								break;
							}
							else
							{
								dataGridView.Rows[i].Visible = false;
							}
						}
					}
				}
			}
		}		

        private void textBoxNumberMainSearch_KeyDown(object sender, KeyEventArgs e)
        {
			if (e.KeyCode == Keys.Enter)
			{
				e.Handled = true;
				dataGridView.CurrentCell = null;

				for (int i = 0; i < dataGridView.RowCount; i++)
				{
					dataGridView.Rows[i].Selected = false;

					for (int j = 0; j < dataGridView.ColumnCount; j++)
					{
						if (dataGridView.Rows[i].Cells[j].Value != null)
						{
							if (dataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBoxNumberMainSearch.Text))
							{								
								break;
							}
							else
							{
								dataGridView.Rows[i].Visible = false;
							}
						}
					}
				}
			}
		}

        private void buttonHelper_MouseEnter(object sender, EventArgs e)
        {
			panelHelper.Visible = true;
        }

        private void buttonHelper_MouseLeave(object sender, EventArgs e)
        {
			panelHelper.Visible = false;
        }
    }


    public class Abonent
	{	
		string second_name;
		string first_name;
		string middle_name;
		string phone_number;
		string passport_number;
		string tariff_plan;
		int registration_date;
		bool activity;
		int id;

		public Abonent (
			string second_name, 
			string first_name, 
			string middle_name, 
			string phone_number, 
			string passport_number, 
			string tariff_plan, 
			bool activity, 
			int registration_date,
			int id
			)

		{
			this.second_name = second_name;
			this.first_name = first_name;
			this.middle_name = middle_name;
			this.phone_number = phone_number;
			this.passport_number = passport_number;
			this.registration_date = registration_date;
			this.tariff_plan = tariff_plan;
			this.activity = activity;
			this.id = id;
		}

		public string getSecond_name()
        {
			return second_name;
        }

		public string getFirst_name()
		{
			return first_name;
		}

		public string getMiddle_name()
		{
			return middle_name;
		}

		public string getFull_name()
		{
			string full_name = "";
			return full_name;
		}

		public string getPhone_number()
		{
			return phone_number;
		}

		public string getPassport_number()
        {
			return passport_number;
        }

		public string getTariff_plan()
		{
			return tariff_plan;
		}

		public int getRegistration_date()
		{
			return registration_date;
		}

		public bool getActivity()
		{
			return activity;
		}

		public int getId()
        {
			return id;
        }

	}
}



/*
		private void ButtonEditData_Click(object sender, EventArgs e)
		{
			int index, n;

			string SqlText = "UPDATE [abonents] SET ";


			string full_name2;
			string phone_number_main2;
			string tariff_plan2;
			DateTime registration_date2;
			bool activity2;

			index = dataGridView.CurrentRow.Index;
			full_name2 = dataGridView[0, index].Value.ToString();
			phone_number_main2 = dataGridView[1, index].Value.ToString();
			tariff_plan2 = dataGridView[2, index].Value.ToString();
			registration_date2 = DateTime.Parse(dataGridView[3, index].Value.ToString());
			activity2 = Boolean.Parse(dataGridView[4, index].Value.ToString());

			full_nameTextBox.Text = full_name2;
			phone_number_mainTextBox.Text = phone_number_main2;
			tariff_planTextBox.Text = tariff_plan2;
			registration_dateDateTimePicker.Value = registration_date2;
			activityCheckBox.Checked = activity2;

			if (ShowDialog() == DialogResult.OK)
			{
				full_name2 = full_nameTextBox.Text;
				phone_number_main2 = phone_number_mainTextBox.Text;
				tariff_plan2 = tariff_planTextBox.Text;
				registration_date2 = registration_dateDateTimePicker.Value;
				activity2 = activityCheckBox.Checked;

				SqlText += "full_name = \'" + full_name2 + "\', phone_number_main = \'" + phone_number_main2 + "\', tariff_plan = \'" + tariff_plan2 + "\', registration_date = \'" + registration_date2 + "\', activity = \'" + activity2 + "\'";


				MyExecuteNonQuery(SqlText);
				FillSource();
			}
		}

		private void FillSource()
		{
			string SqlText = "SELECT * FROM [abonents]";
			SqlDataAdapter da = new SqlDataAdapter(SqlText, connectionString);
			DataSet ds = new DataSet();
			da.Fill(ds, "[abonents]");
			dataGridView.DataSource = ds.Tables["[abonents]"].DefaultView;
		}

		public void MyExecuteNonQuery(string SqlText)
		{
			SqlConnection cn; // экземпляр класса типа SqlConnection
			SqlCommand cmd;

			// выделение памяти с инициализацией строки соединения с базой данных
			cn = new SqlConnection(connectionString);
			cn.Open(); // открыть источник данных
			cmd = cn.CreateCommand(); // задать SQL-команду
			cmd.CommandText = SqlText; // задать командную строку
			cmd.ExecuteNonQuery(); // выполнить SQL-команду
			cn.Close(); // закрыть источник данных
		}
*/


/*
		private void ButtonDeleteRow_Click(object sender, EventArgs e)
		{
			if (this.dataGridView.SelectedRows.Count > 0 &&
				this.dataGridView.SelectedRows[0].Index !=
				this.dataGridView.Rows.Count - 1)
			{
				this.dataGridView.Rows.RemoveAt(
				this.dataGridView.SelectedRows[0].Index);
			}
		}*/


