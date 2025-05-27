using System.Runtime.InteropServices;
using static System.Windows.Forms.AxHost;

namespace MouseDummy
{
    public partial class Frm_MouseDummy : Form
    {
        public Frm_MouseDummy()
        {
            InitializeComponent();
        }

        // Windows Internal Mouse Methods
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        // Event Flags
        private const uint MOUSEEVENTF_LEFTDOWN = 0x02;
        private const uint MOUSEEVENTF_LEFTUP = 0x04;
        private const uint MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const uint MOUSEEVENTF_RIGHTUP = 0x10;
        private const uint MOUSEEVENTF_MIDDLEDOWN = 0x20;
        private const uint MOUSEEVENTF_MIDDLEUP = 0x40;
        private const uint MOUSEEVENTF_WHEEL = 0x0800;

        // MouseDummy Methods
        private int clickType = 1;
        private int actionDelay = 0;
        private bool keepLoop = true;

        private void Frm_MouseDummy_Load(object sender, EventArgs e)
        {
            // Load the saved sequences in the ComboBox
            if (Directory.Exists("SavedSequences"))
            {
                List<string> savedSequences = new List<string>();
                foreach (string file in Directory.GetFiles("SavedSequences"))
                {   // Remove extension
                    savedSequences.Add(file.Split('.')[0].Split('\\')[1]);
                }
                cmbbx_savedSequences.Items.AddRange(savedSequences.ToArray());
            }
        }

        private void btn_trackMousePos_Click(object sender, EventArgs e)
        {
            // Set the current coords
            txtbx_x.Text = Cursor.Position.X.ToString();
            txtbx_y.Text = Cursor.Position.Y.ToString();
            // Enable the tracking Timer
            tmr_checkCoords.Enabled = true;
            // Disable the window
            grpbx_points.Enabled = false;
            grpbx_action.Enabled = false;
            grpbx_pointSelector.Enabled = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!txtbx_x.Text.Equals("") && !txtbx_y.Text.Equals(""))
            {
                // Save the point
                lstbx_points.Items.Add("Point " + (lstbx_points.Items.Count + 1) + " | " + txtbx_x.Text + "x" + txtbx_y.Text + ": No Action Assigned");
                // Disable the mouse tracking
                tmr_checkCoords.Enabled = false;
                // Enable the window
                grpbx_points.Enabled = true;
                grpbx_action.Enabled = true;
                grpbx_pointSelector.Enabled = true;
                // Clear the X and Y fields
                txtbx_x.Text = "";
                txtbx_y.Text = "";
                // Disable Gradual Speed by default
                nmrupdwn_gradualSmooth.Enabled = false;
            }
            else
                MessageBox.Show("Select the Point's X and Y first!", "Error adding point", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_action_Click(object sender, EventArgs e)
        {
            Button snd = (Button)sender;
            if (lstbx_points.SelectedItem != null)
            {
                // Asign Action
                lstbx_points.Items[lstbx_points.SelectedIndex] = lstbx_points.Items[lstbx_points.SelectedIndex].ToString().Split(":")[0] + ": ";
                // If it's a click action, add the type
                if (snd.Tag.ToString().Contains("Click"))
                    lstbx_points.Items[lstbx_points.SelectedIndex] += clickType + "-";
                lstbx_points.Items[lstbx_points.SelectedIndex] += snd.Tag + " " + snd.Text;
                // Enable Gradual speed if you selected Gradual Move
                if (snd.Text.Contains("Gradual"))
                    nmrupdwn_gradualSmooth.Enabled = true;
                else
                    nmrupdwn_gradualSmooth.Enabled = false;
            }
            else
                MessageBox.Show("Select the Point you want to asign the action first!", "Error assigning action to the point", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void tmr_checkCoords_Tick(object sender, EventArgs e)
        {
            txtbx_x.Text = Cursor.Position.X.ToString();
            txtbx_y.Text = Cursor.Position.Y.ToString();
        }

        private void Frm_MouseDummy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N)
                btn_add_Click(null, null);
            else if (e.KeyCode == Keys.C)
            {
                // Cancel sequence
                keepLoop = false;
            }
        }

        private void btn_playLoop_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The sequence will run in loop infinitely, until you cancel it.\n" +
                                "The delay between actions in looped sequences is set to a minimum of 1 second with an extra delay time after a whole sequence is run, so you can safely cancel the process.\n" +
                                "Do you want to continue?","Loop Sequences Information", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                tltp_help.Show("Stop sequence (C)", btn_playSequence);
                // Play in loop
                new Thread(() =>
                {
                    do
                    {
                        // Reset the variable
                        keepLoop = true;

                        Invoke(() => { runSequence(); });

                        // Extra Delay between loops
                        // In looped, at least 1s is necessary
                        if (actionDelay < 1000)
                            nmrupdwn_actionDelay.Invoke(() => { nmrupdwn_actionDelay.Value++; });
                        Thread.Sleep(actionDelay);
                    }
                    while (keepLoop);
                    MessageBox.Show("Infinite loop was cancelled.", "Looped Sequence was stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_playSequence.Invoke(() => { tltp_help.Hide(btn_playSequence); });
                }).Start();
            }
        }

        private void btn_playSequence_Click(object sender, EventArgs e)
        {
            runSequence();
        }

        private void runSequence() {
            // Disable the window
            grpbx_action.Enabled = false;
            grpbx_pointSelector.Enabled = false;
            btn_playSequence.BackgroundImage = imglst_play.Images[1];
            // Run the sequence
            for (int i = 0; i < lstbx_points.Items.Count; i++)
            {
                // Extract info from action
                string action = lstbx_points.Items[i].ToString().Split(":")[1].Trim().Split(" ")[0];
                if (action.Contains("Click"))
                    action = action.Split("-")[1];
                string type = lstbx_points.Items[i].ToString().Split(":")[1].Trim().Split(" ")[1];
                int x = int.Parse(lstbx_points.Items[i].ToString().Split("|")[1].Split(":")[0].Split("x")[0].Trim());
                int y = int.Parse(lstbx_points.Items[i].ToString().Split("|")[1].Split(":")[0].Split("x")[1].Trim());

                switch (action)
                {
                    case "Move":
                        switch (type)
                        {
                            case "Instant":
                                SetCursorPos(x, y);
                                break;
                            case "Gradual":
                                int currentX = Cursor.Position.X;
                                int currentY = Cursor.Position.Y;
                                if (nmrupdwn_gradualSmooth.Value == 0)
                                    // If gradual is selected, smooth is set at 10 by default (if it havent been changed manually)
                                    nmrupdwn_gradualSmooth.Value = 10;
                                int smoothness = (int)nmrupdwn_gradualSmooth.Value;

                                for (int f = 1; f <= smoothness; f++)
                                {
                                    float t = (float)f / smoothness;
                                    int intermediateX = (int)(currentX + (x - currentX) * t);
                                    int intermediateY = (int)(currentY + (y - currentY) * t);

                                    SetCursorPos(intermediateX, intermediateY);
                                    Thread.Sleep(50);
                                }
                                break;
                            default:
                                MessageBox.Show("An error occurred at running the point " + (i + 1) + "'s Action (" + type + ")", "Error running the secuence", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                        break;
                    case "Click":
                        switch (type)
                        {
                            case "Left":
                                SetCursorPos(x, y);
                                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                                break;
                            case "Middle":
                                SetCursorPos(x, y);
                                mouse_event(MOUSEEVENTF_MIDDLEDOWN, 0, 0, 0, 0);
                                mouse_event(MOUSEEVENTF_MIDDLEUP, 0, 0, 0, 0);
                                break;
                            case "Right":
                                SetCursorPos(x, y);
                                mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
                                mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
                                break;
                            default:
                                MessageBox.Show("An error occurred at running the point " + (i + 1) + "'s Action (" + type + ")", "Error running the secuence", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                        break;
                    case "Scroll":
                        switch (type)
                        {
                            case "Up":
                                SetCursorPos(x, y);
                                mouse_event(MOUSEEVENTF_WHEEL, 0, 0, 120, 0);
                                break;
                            case "Down":
                                SetCursorPos(x, y);
                                mouse_event(MOUSEEVENTF_WHEEL, 0, 0, unchecked((uint)-120), 0);
                                break;
                            default:
                                MessageBox.Show("An error occurred at running the point " + (i + 1) + "'s Action (" + type + ")", "Error running the secuence", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                        break;
                    default:
                        MessageBox.Show("You must assign an action to the point " + (i + 1), "Error running the secuence", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
                // Delay between actions
                Thread.Sleep(actionDelay);
            }
            // Enable the window
            grpbx_action.Enabled = true;
            grpbx_pointSelector.Enabled = true;
            btn_playSequence.BackgroundImage = imglst_play.Images[0];
            this.Activate();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lstbx_points.SelectedItem != null)
            {
                lstbx_points.Items.Remove(lstbx_points.SelectedItem);
                // Re-assign point number count
                for (int i = 0; i < lstbx_points.Items.Count; i++) 
                {
                    lstbx_points.Items[i] = lstbx_points.Items[i].ToString().Replace(lstbx_points.Items[i].ToString().Split("|")[0], "Point " + (i+1) + " ");
                }
            }
            else
                MessageBox.Show("Select the Point you want to delete first!", "Error deleting the point", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            if (lstbx_points.SelectedItem != null)
                lstbx_points.Items.Add("Point " + (lstbx_points.Items.Count + 1) + " | " + lstbx_points.SelectedItem.ToString().Split("|")[1].Split(":")[0].Trim() + ": No Action Assigned");
            else
                MessageBox.Show("Select the Point you want to copy first!", "Error coping the point", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void rdbtn_Click_CheckedChanged(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Text)
            {
                case "Single":
                    clickType = 1;
                    break;
                case "Double":
                    clickType = 2;
                    break;
                case "Triple":
                    clickType = 3;
                    break;
                default:
                    MessageBox.Show("An error occurred at choosing the Click Type (" + ((RadioButton)sender).Text + ")", "Error setting the click type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void cmbbx_savedSequences_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbx_savedSequences.Items[cmbbx_savedSequences.SelectedIndex].ToString().Contains("+ Save"))
            {
                if (lstbx_points.Items.Count > 0)
                {
                    // Create the sequence's name by summarizing the content of the actions
                    // Sequence number based of how many elements the combobox has (not including the options)
                    string sequenceName = cmbbx_savedSequences.Items.Count - 2 + "-";
                    string currentSequence = "";
                    for (int i = 0; i < lstbx_points.Items.Count; i++)
                    {
                        string separator = "\n";
                        if (i == lstbx_points.Items.Count - 1)
                            separator = "";
                        currentSequence += lstbx_points.Items[i] + separator;
                        switch (lstbx_points.Items[i])
                        {
                            case string a when a.Contains("Move"):
                                sequenceName += "Mv";
                                break;
                            case string b when b.Contains("Right"):
                                sequenceName += "Rgt";
                                break;
                            case string c when c.Contains("Middle"):
                                sequenceName += "Mdl";
                                break;
                            case string d when d.Contains("Left"):
                                sequenceName += "Lft";
                                break;
                            case string f when f.Contains("Up"):
                                sequenceName += "Up";
                                break;
                            case string h when h.Contains("Down"):
                                sequenceName += "Dwn";
                                break;
                            default:
                                sequenceName += "NoAct";
                                break;
                        }
                    }

                    // Save in a file
                    if (!Directory.Exists("SavedSequences"))
                        Directory.CreateDirectory("SavedSequences");
                    File.WriteAllText("SavedSequences\\" + sequenceName + ".sqc", currentSequence);

                    // Adds the sequence to the ComboBox
                    cmbbx_savedSequences.Items.Add(sequenceName);
                }
            }
            else if (cmbbx_savedSequences.Items[cmbbx_savedSequences.SelectedIndex].ToString().Contains("+ New"))
            {
                // Clear the current points
                lstbx_points.Items.Clear();
            }
            else if (cmbbx_savedSequences.Items[cmbbx_savedSequences.SelectedIndex].ToString().Contains("------"))
            {
                // Does nothing as only serves as separator between options and actual saved sequences
            }
            else
            {
                // Clear the current points
                lstbx_points.Items.Clear();

                // Load from the file
                string[] savedSequence = File.ReadAllText("SavedSequences\\" + cmbbx_savedSequences.SelectedItem + ".sqc").Split("\n");

                lstbx_points.Items.AddRange(savedSequence);
            }
            cmbbx_savedSequences.SelectedText = "";
        }

        private void nmrupdwn_actionDelay_ValueChanged(object sender, EventArgs e)
        {
            // Convert to milliseconds
            actionDelay = (int)nmrupdwn_actionDelay.Value * 1000;
        }

        private void btn_ClearSequences_Click(object sender, EventArgs e)
        {
            if (cmbbx_savedSequences.Items.Count > 3) // If we skip the options...
            {
                if (MessageBox.Show("Are you sure you want to clear all the saved sequences?\n" +
                                    "This will delete every sequence file saved in your system.\n" +
                                    "The program will restart afterwards.", "Deletion Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                    foreach (string file in Directory.GetFiles("SavedSequences"))
                    {
                        File.Delete(file);
                    }
                    Directory.Delete("SavedSequences");

                    lstbx_points.Items.Clear();

                    Application.Restart();
                }
            }
            else
                MessageBox.Show("There is no saved sequences to delete, try saving some first!", "Error clearing saved sequences", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
