using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InputGoalScreen : Form
    {

        public bool ConfirmGoal = false;
        public string GoalName;
        public string GoalNumber; 


        public InputGoalScreen()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void Goal_Name_TextChanged(object sender, EventArgs e)
        {
            GoalName = Goal_Name.Text;

        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Main_screen_return(); 
        }

        private void Confirm_Button_Click(object sender, EventArgs e)
        {
            ConfirmGoal = true; 
            Main_screen_return();
        }


        private void Main_screen_return() 
        {
            //MainScreen F1 = new MainScreen(ConfirmGoal); 
            //this.Hide(); F1.ShowDialog(); this.Close();  
        }

        private void Goal_Amount_TextChanged(object sender, EventArgs e)
        {
            GoalNumber = Goal_Amount.Text;
            string goalnumber = GoalNumber.ToString();
        }
    }
}
