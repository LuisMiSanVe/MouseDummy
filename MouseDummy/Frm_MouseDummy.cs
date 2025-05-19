using System.Runtime.InteropServices;

namespace MouseDummy
{
    public partial class Frm_MouseDummy : Form
    {
        public Frm_MouseDummy()
        {
            InitializeComponent();
        }

        // Windows Internal Mouse Events
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

        // MouseDummy Events
        private int clickType = 1;
        private void Frm_MouseDummy_Load(object sender, EventArgs e)
        {

        }

        private void btn_trackMousePos_Click(object sender, EventArgs e)
        {
            tmr_checkCoords.Enabled = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Save the point
            lstbx_points.Items.Add("Point " + (lstbx_points.Items.Count + 1) + " | " + txtbx_x.Text + "x" + txtbx_y.Text + ": No Action Assigned");
            // Disable the mouse tracking
            tmr_checkCoords.Enabled = false;
            // Clear the X and Y fields
            txtbx_x.Text = "";
            txtbx_y.Text = "";
        }

        private void cmbbx_savedSecuences_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_action_Click(object sender, EventArgs e)
        {
            if (lstbx_points.SelectedItem != null)
            {
                lstbx_points.Items[lstbx_points.SelectedIndex] = lstbx_points.Items[lstbx_points.SelectedIndex].ToString().Split(":")[0] + ": ";
                if (((Button)sender).Tag.ToString().Contains("Click"))
                    lstbx_points.Items[lstbx_points.SelectedIndex] += clickType + "-";
                lstbx_points.Items[lstbx_points.SelectedIndex] += ((Button)sender).Tag + " " + ((Button)sender).Text;
            }
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
                // Cancel
            }
        }

        private void btn_playLoop_Click(object sender, EventArgs e)
        {

        }

        private void btn_playSecuence_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstbx_points.Items.Count; i++)
            {
                string action = lstbx_points.Items[i].ToString().Split(":")[1].Trim().Split(" ")[0];
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
                                // Gradual
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
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lstbx_points.SelectedItem != null)
                lstbx_points.Items.Remove(lstbx_points.SelectedItem);
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            if (lstbx_points.SelectedItem != null)
                lstbx_points.Items.Add("Point " + (lstbx_points.Items.Count + 1) + " | " + lstbx_points.SelectedItem.ToString().Split("|")[1].Split(":")[0].Trim() + ": No Action Assigned");
        }

        private void rdbtn_Click_CheckedChanged(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Text) {
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
    }
}
