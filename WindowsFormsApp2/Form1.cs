using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeForm();
        }













        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //טרים זאת מתודה שמעיפה רווחים מיויתרים
            if (firstNameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please fill first name", "Notice");
                //נשאר למלא בדיקות של שאר השדות
            }
            else
            {
                //כשהמשתמש לוחץ על הוספה, אנחנו יוצרים אובייקט מסוג אמפלועי ומגדרים לו את הפרופרטעיז לפי מה שהוזן
                Employee newEmployee = new Employee();
                newEmployee.FirstName = firstNameTextBox.Text.Trim();
                newEmployee.LastName = lastNameTextBox.Text.Trim();


                //מוסיפים את האפלועי החדשד בתור אייטם בליסטבוקס. 
                //הליסט בוקס הוא די דבע והוא יודע לייצג את האפלועי 
                //רק כסטרינג. לכן מאחורי הקלעים הוא קורא למתודה 2סטרינג
                employeeListListBox.Items.Add(newEmployee);
                InitializeForm();
            }
        }
        

        //מתודה שנשתמש בה בשביל למחוק את כל השדות למעלה
        private void InitializeForm()
        {
            //מאפס את הטסקטבוקסים נשאר לאפשב את שאר השדות
            firstNameTextBox.Text = lastNameTextBox.Text = "";
            gradeComboBox.SelectedIndex = 1;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            InitializeForm();
        }
    }
}
