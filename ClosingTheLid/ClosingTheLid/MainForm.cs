using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Microsoft.Win32;

namespace ClosingTheLid
{
    public partial class MainForm : Form
    {
        //TODO: function that gets current setting
        SettingsControl sc = new SettingsControl();
        Random r = new Random();
        int count_windowMove = 0;

        public void CommandPromptExecute(string cmdText)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = cmdText;
            process.StartInfo = startInfo;
            process.Start();
        }

        public void ExecuteCommands()
        {
            try
            {
                for (int i = 0; i < whatToDo().Length; i++)
                {
                    CommandPromptExecute( whatToDo()[i] );
                }
            }
            catch (Exception objException){}
        }

        public int radioButtonCheck()
        {
            if (button_doNothing.Checked)
                return 0;
            else if (button_sleep.Checked)
                return 1;
            else if (button_hibernate.Checked)
                return 2;
            else if (button_shutdown.Checked)
                return 3;
            else
                return -1;
        }

        public string[] whatToDo()
        {
            string[] commands = new string[2];

            string cmdIndex = radioButtonCheck().ToString();

            if (checkbox_onBattery.Checked)
                commands[0] = "/C powercfg -setdcvalueindex SCHEME_CURRENT 4f971e89-eebd-4455-a8de-9e59040e7347 5ca83367-6e45-459f-a27b-476b1d01c936 "
                    + cmdIndex;
            else if (!checkbox_onBattery.Checked)
                commands[0] = "/C \n";

            if (checkbox_pluggedIn.Checked)
                commands[1] = "/C powercfg -setacvalueindex SCHEME_CURRENT 4f971e89-eebd-4455-a8de-9e59040e7347 5ca83367-6e45-459f-a27b-476b1d01c936 "
                    + cmdIndex;
            else if (!checkbox_pluggedIn.Checked)
                commands[1] = "/C \n";

            return commands;
        }

        public void windowMove()
        {
            if (count_windowMove > 2)
                return;

            Screen screen = Screen.FromControl(this);   //  get screen
            int max_X = screen.WorkingArea.Right;       //  RIGHT bound
            int max_Y = screen.WorkingArea.Bottom;      //  LEFT bound

            int increment_X = r.Next(50, max_X);        //  random increment generator
            int increment_Y = r.Next(50, max_Y);

            int direction_X = r.Next(2);    //  0 for + increment
            int direction_Y = r.Next(2);    //  1 for - increment

            int new_X = this.Location.X;    //  init

            if (direction_X == 1)           //  applying increment
                new_X += increment_X;       //  (calculating new coordinate value)
            else if (direction_X == 0)
                new_X -= increment_X;

            int new_Y = this.Location.Y;    //  init

            if (direction_Y == 1)           //  applying increment
                new_Y += increment_Y;       //  (calculating new coordinate value)
            else if (direction_Y == 0)
                new_Y -= increment_Y;

            //  CHECK IF:
            if (new_X < 0)                              //  LEFT border corssed
                new_X = -new_X;
            else if (new_X + this.Width > max_X)        //  RIGHT border crossed  
                new_X -= new_X + this.Width - max_X;

            if (new_Y < 0)                              //  TOP border corssed
                new_Y = -new_Y;
            else if (new_Y + this.Height > max_Y)       //  BOTTOM border corssed
                new_Y -= new_Y + this.Height - max_Y;

            this.SetDesktopLocation(new_X, new_Y);      //  moving the window
            count_windowMove++;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            ExecuteCommands();
            button_apply.Text = String.Format("its: {0}", sc.SetCurrentSettings());
            button_close.Text = String.Format("its: {0}", sc.GetDCSetting());
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button_close_MouseHover(object sender, EventArgs e)
        {
            windowMove();
        }

        private void button_doNothing_MouseHover(object sender, EventArgs e)
        {
            button_doNothing.ForeColor = SystemColors.ControlDark;
        }

        private void button_doNothing_MouseLeave(object sender, EventArgs e)
        {
            button_doNothing.ForeColor = SystemColors.Control;
        }

        private void button_sleep_MouseHover(object sender, EventArgs e)
        {
            button_sleep.ForeColor = SystemColors.ControlDark;
        }

        private void button_sleep_MouseLeave(object sender, EventArgs e)
        {
            button_sleep.ForeColor = SystemColors.Control;
        }

        private void button_hibernate_MouseHover(object sender, EventArgs e)
        {
            button_hibernate.ForeColor = SystemColors.ControlDark;
        }

        private void button_hibernate_MouseLeave(object sender, EventArgs e)
        {
            button_hibernate.ForeColor = SystemColors.Control;
        }

        private void button_shutdown_MouseHover(object sender, EventArgs e)
        {
            button_shutdown.ForeColor = SystemColors.ControlDark;
        }

        private void button_shutdown_MouseLeave(object sender, EventArgs e)
        {
            button_shutdown.ForeColor = SystemColors.Control;
        }

        private void checkbox_onBattery_MouseHover(object sender, EventArgs e)
        {
            checkbox_onBattery.ForeColor = SystemColors.ControlDark;
        }

        private void checkbox_onBattery_MouseLeave(object sender, EventArgs e)
        {
            checkbox_onBattery.ForeColor = SystemColors.Control;
        }

        private void checkbox_pluggedIn_MouseHover(object sender, EventArgs e)
        {
            checkbox_pluggedIn.ForeColor = SystemColors.ControlDark;
        }

        private void checkbox_pluggedIn_MouseLeave(object sender, EventArgs e)
        {
            checkbox_pluggedIn.ForeColor = SystemColors.Control;
        }
    }
}
