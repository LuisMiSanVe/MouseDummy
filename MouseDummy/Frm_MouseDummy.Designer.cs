namespace MouseDummy
{
    partial class Frm_MouseDummy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MouseDummy));
            grpbx_points = new GroupBox();
            lbl_movepoint = new Label();
            btn_up = new Button();
            btn_down = new Button();
            btn_ClearSequences = new Button();
            nmrupdwn_actionDelay = new NumericUpDown();
            btn_playLoop = new Button();
            btn_playSequence = new Button();
            cmbbx_savedSequences = new ComboBox();
            lstbx_points = new ListBox();
            grpbx_pointSelector = new GroupBox();
            btn_copy = new Button();
            btn_delete = new Button();
            btn_trackMousePos = new Button();
            btn_add = new Button();
            lbl_y = new Label();
            lbl_x = new Label();
            txtbx_x = new TextBox();
            txtbx_y = new TextBox();
            grpbx_action = new GroupBox();
            rdbtn_HoldRelease = new RadioButton();
            rdbtn_tripleClick = new RadioButton();
            rdbtn_doubleClick = new RadioButton();
            rdbtn_singleClick = new RadioButton();
            lbl_gradualSpeed = new Label();
            nmrupdwn_gradualSmooth = new NumericUpDown();
            btn_clickMiddle = new Button();
            btn_moveInstant = new Button();
            btn_scrollDown = new Button();
            btn_scrollUp = new Button();
            btn_clickRight = new Button();
            btn_clickLeft = new Button();
            btn_moveGradual = new Button();
            lbl_scroll = new Label();
            lbl_click = new Label();
            lbl_move = new Label();
            tmr_checkCoords = new System.Windows.Forms.Timer(components);
            tltp_help = new ToolTip(components);
            cntxmnustrp_sequences = new ContextMenuStrip(components);
            loadToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            chk_natural = new CheckBox();
            grpbx_points.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrupdwn_actionDelay).BeginInit();
            grpbx_pointSelector.SuspendLayout();
            grpbx_action.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrupdwn_gradualSmooth).BeginInit();
            cntxmnustrp_sequences.SuspendLayout();
            SuspendLayout();
            // 
            // grpbx_points
            // 
            grpbx_points.Controls.Add(lbl_movepoint);
            grpbx_points.Controls.Add(btn_up);
            grpbx_points.Controls.Add(btn_down);
            grpbx_points.Controls.Add(btn_ClearSequences);
            grpbx_points.Controls.Add(nmrupdwn_actionDelay);
            grpbx_points.Controls.Add(btn_playLoop);
            grpbx_points.Controls.Add(btn_playSequence);
            grpbx_points.Controls.Add(cmbbx_savedSequences);
            grpbx_points.Controls.Add(lstbx_points);
            grpbx_points.Location = new Point(12, 12);
            grpbx_points.Name = "grpbx_points";
            grpbx_points.Size = new Size(277, 289);
            grpbx_points.TabIndex = 0;
            grpbx_points.TabStop = false;
            grpbx_points.Text = "Points";
            // 
            // lbl_movepoint
            // 
            lbl_movepoint.AutoSize = true;
            lbl_movepoint.Location = new Point(45, 267);
            lbl_movepoint.Margin = new Padding(2, 0, 2, 0);
            lbl_movepoint.Name = "lbl_movepoint";
            lbl_movepoint.Size = new Size(71, 15);
            lbl_movepoint.TabIndex = 8;
            lbl_movepoint.Text = "Move Point:";
            // 
            // btn_up
            // 
            btn_up.Location = new Point(123, 265);
            btn_up.Margin = new Padding(2, 2, 2, 2);
            btn_up.Name = "btn_up";
            btn_up.Size = new Size(48, 20);
            btn_up.TabIndex = 7;
            btn_up.Text = "^";
            btn_up.UseVisualStyleBackColor = true;
            btn_up.Click += btn_up_Click;
            // 
            // btn_down
            // 
            btn_down.Location = new Point(175, 265);
            btn_down.Margin = new Padding(2, 2, 2, 2);
            btn_down.Name = "btn_down";
            btn_down.Size = new Size(48, 20);
            btn_down.TabIndex = 6;
            btn_down.Text = "v";
            btn_down.UseVisualStyleBackColor = true;
            btn_down.Click += btn_down_Click;
            // 
            // btn_ClearSequences
            // 
            btn_ClearSequences.BackgroundImage = (Image)resources.GetObject("btn_ClearSequences.BackgroundImage");
            btn_ClearSequences.BackgroundImageLayout = ImageLayout.Stretch;
            btn_ClearSequences.Location = new Point(236, 20);
            btn_ClearSequences.Name = "btn_ClearSequences";
            btn_ClearSequences.Size = new Size(21, 18);
            btn_ClearSequences.TabIndex = 5;
            tltp_help.SetToolTip(btn_ClearSequences, "Clear Sequences");
            btn_ClearSequences.UseVisualStyleBackColor = true;
            btn_ClearSequences.Click += btn_ClearSequences_Click;
            // 
            // nmrupdwn_actionDelay
            // 
            nmrupdwn_actionDelay.Location = new Point(148, 20);
            nmrupdwn_actionDelay.Margin = new Padding(2, 2, 2, 2);
            nmrupdwn_actionDelay.Name = "nmrupdwn_actionDelay";
            nmrupdwn_actionDelay.Size = new Size(30, 23);
            nmrupdwn_actionDelay.TabIndex = 4;
            tltp_help.SetToolTip(nmrupdwn_actionDelay, "Seconds of delay between actions");
            nmrupdwn_actionDelay.ValueChanged += nmrupdwn_actionDelay_ValueChanged;
            // 
            // btn_playLoop
            // 
            btn_playLoop.BackgroundImage = (Image)resources.GetObject("btn_playLoop.BackgroundImage");
            btn_playLoop.BackgroundImageLayout = ImageLayout.Stretch;
            btn_playLoop.Location = new Point(209, 20);
            btn_playLoop.Name = "btn_playLoop";
            btn_playLoop.Size = new Size(21, 18);
            btn_playLoop.TabIndex = 3;
            tltp_help.SetToolTip(btn_playLoop, "Play Looped Secuence");
            btn_playLoop.UseVisualStyleBackColor = true;
            btn_playLoop.Click += btn_playLoop_Click;
            // 
            // btn_playSequence
            // 
            btn_playSequence.BackgroundImage = (Image)resources.GetObject("btn_playSequence.BackgroundImage");
            btn_playSequence.BackgroundImageLayout = ImageLayout.Stretch;
            btn_playSequence.Location = new Point(183, 20);
            btn_playSequence.Name = "btn_playSequence";
            btn_playSequence.Size = new Size(21, 18);
            btn_playSequence.TabIndex = 2;
            tltp_help.SetToolTip(btn_playSequence, "Play Sequence");
            btn_playSequence.UseVisualStyleBackColor = true;
            btn_playSequence.Click += btn_playSequence_Click;
            // 
            // cmbbx_savedSequences
            // 
            cmbbx_savedSequences.FormattingEnabled = true;
            cmbbx_savedSequences.Items.AddRange(new object[] { "+ Save the sequence...", "+ New sequence...", "-------------------------------" });
            cmbbx_savedSequences.Location = new Point(16, 19);
            cmbbx_savedSequences.Name = "cmbbx_savedSequences";
            cmbbx_savedSequences.Size = new Size(128, 23);
            cmbbx_savedSequences.TabIndex = 1;
            cmbbx_savedSequences.SelectedIndexChanged += cmbbx_savedSequences_SelectedIndexChanged;
            cmbbx_savedSequences.TextChanged += cmbbx_savedSequences_TextChanged;
            // 
            // lstbx_points
            // 
            lstbx_points.FormattingEnabled = true;
            lstbx_points.ItemHeight = 15;
            lstbx_points.Location = new Point(16, 48);
            lstbx_points.Name = "lstbx_points";
            lstbx_points.Size = new Size(242, 214);
            lstbx_points.TabIndex = 0;
            // 
            // grpbx_pointSelector
            // 
            grpbx_pointSelector.Controls.Add(btn_copy);
            grpbx_pointSelector.Controls.Add(btn_delete);
            grpbx_pointSelector.Controls.Add(btn_trackMousePos);
            grpbx_pointSelector.Controls.Add(btn_add);
            grpbx_pointSelector.Controls.Add(lbl_y);
            grpbx_pointSelector.Controls.Add(lbl_x);
            grpbx_pointSelector.Controls.Add(txtbx_x);
            grpbx_pointSelector.Controls.Add(txtbx_y);
            grpbx_pointSelector.Location = new Point(295, 12);
            grpbx_pointSelector.Name = "grpbx_pointSelector";
            grpbx_pointSelector.Size = new Size(291, 100);
            grpbx_pointSelector.TabIndex = 1;
            grpbx_pointSelector.TabStop = false;
            grpbx_pointSelector.Text = "Point Select";
            // 
            // btn_copy
            // 
            btn_copy.Location = new Point(150, 58);
            btn_copy.Name = "btn_copy";
            btn_copy.Size = new Size(64, 23);
            btn_copy.TabIndex = 7;
            btn_copy.Text = "Copy";
            btn_copy.UseVisualStyleBackColor = true;
            btn_copy.Click += btn_copy_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(219, 58);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(64, 23);
            btn_delete.TabIndex = 6;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_trackMousePos
            // 
            btn_trackMousePos.Location = new Point(11, 58);
            btn_trackMousePos.Name = "btn_trackMousePos";
            btn_trackMousePos.Size = new Size(64, 23);
            btn_trackMousePos.TabIndex = 5;
            btn_trackMousePos.Text = "Track (T)";
            btn_trackMousePos.UseVisualStyleBackColor = true;
            btn_trackMousePos.Click += btn_trackMousePos_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(80, 58);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(64, 23);
            btn_add.TabIndex = 4;
            btn_add.Text = "Add (N)";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // lbl_y
            // 
            lbl_y.AutoSize = true;
            lbl_y.Location = new Point(150, 23);
            lbl_y.Name = "lbl_y";
            lbl_y.Size = new Size(17, 15);
            lbl_y.TabIndex = 3;
            lbl_y.Text = "Y:";
            // 
            // lbl_x
            // 
            lbl_x.AutoSize = true;
            lbl_x.Location = new Point(14, 23);
            lbl_x.Name = "lbl_x";
            lbl_x.Size = new Size(17, 15);
            lbl_x.TabIndex = 2;
            lbl_x.Text = "X:";
            // 
            // txtbx_x
            // 
            txtbx_x.Location = new Point(37, 20);
            txtbx_x.Name = "txtbx_x";
            txtbx_x.Size = new Size(107, 23);
            txtbx_x.TabIndex = 1;
            txtbx_x.TextChanged += txtbx_xy_TextChanged;
            // 
            // txtbx_y
            // 
            txtbx_y.Location = new Point(173, 20);
            txtbx_y.Name = "txtbx_y";
            txtbx_y.Size = new Size(107, 23);
            txtbx_y.TabIndex = 0;
            txtbx_y.TextChanged += txtbx_xy_TextChanged;
            // 
            // grpbx_action
            // 
            grpbx_action.Controls.Add(chk_natural);
            grpbx_action.Controls.Add(rdbtn_HoldRelease);
            grpbx_action.Controls.Add(rdbtn_tripleClick);
            grpbx_action.Controls.Add(rdbtn_doubleClick);
            grpbx_action.Controls.Add(rdbtn_singleClick);
            grpbx_action.Controls.Add(lbl_gradualSpeed);
            grpbx_action.Controls.Add(nmrupdwn_gradualSmooth);
            grpbx_action.Controls.Add(btn_clickMiddle);
            grpbx_action.Controls.Add(btn_moveInstant);
            grpbx_action.Controls.Add(btn_scrollDown);
            grpbx_action.Controls.Add(btn_scrollUp);
            grpbx_action.Controls.Add(btn_clickRight);
            grpbx_action.Controls.Add(btn_clickLeft);
            grpbx_action.Controls.Add(btn_moveGradual);
            grpbx_action.Controls.Add(lbl_scroll);
            grpbx_action.Controls.Add(lbl_click);
            grpbx_action.Controls.Add(lbl_move);
            grpbx_action.Location = new Point(295, 118);
            grpbx_action.Name = "grpbx_action";
            grpbx_action.Size = new Size(291, 183);
            grpbx_action.TabIndex = 2;
            grpbx_action.TabStop = false;
            grpbx_action.Text = "Actions";
            // 
            // rdbtn_HoldRelease
            // 
            rdbtn_HoldRelease.AutoSize = true;
            rdbtn_HoldRelease.Location = new Point(227, 112);
            rdbtn_HoldRelease.Margin = new Padding(2, 2, 2, 2);
            rdbtn_HoldRelease.Name = "rdbtn_HoldRelease";
            rdbtn_HoldRelease.Size = new Size(51, 19);
            rdbtn_HoldRelease.TabIndex = 15;
            rdbtn_HoldRelease.Text = "Hold";
            rdbtn_HoldRelease.UseVisualStyleBackColor = true;
            rdbtn_HoldRelease.CheckedChanged += rdbtn_Click_CheckedChanged;
            // 
            // rdbtn_tripleClick
            // 
            rdbtn_tripleClick.AutoSize = true;
            rdbtn_tripleClick.Location = new Point(168, 112);
            rdbtn_tripleClick.Margin = new Padding(2, 2, 2, 2);
            rdbtn_tripleClick.Name = "rdbtn_tripleClick";
            rdbtn_tripleClick.Size = new Size(54, 19);
            rdbtn_tripleClick.TabIndex = 14;
            rdbtn_tripleClick.Text = "Triple";
            rdbtn_tripleClick.UseVisualStyleBackColor = true;
            rdbtn_tripleClick.CheckedChanged += rdbtn_Click_CheckedChanged;
            // 
            // rdbtn_doubleClick
            // 
            rdbtn_doubleClick.AutoSize = true;
            rdbtn_doubleClick.Location = new Point(97, 112);
            rdbtn_doubleClick.Margin = new Padding(2, 2, 2, 2);
            rdbtn_doubleClick.Name = "rdbtn_doubleClick";
            rdbtn_doubleClick.Size = new Size(63, 19);
            rdbtn_doubleClick.TabIndex = 13;
            rdbtn_doubleClick.Text = "Double";
            rdbtn_doubleClick.UseVisualStyleBackColor = true;
            rdbtn_doubleClick.CheckedChanged += rdbtn_Click_CheckedChanged;
            // 
            // rdbtn_singleClick
            // 
            rdbtn_singleClick.AutoSize = true;
            rdbtn_singleClick.Checked = true;
            rdbtn_singleClick.Location = new Point(34, 112);
            rdbtn_singleClick.Margin = new Padding(2, 2, 2, 2);
            rdbtn_singleClick.Name = "rdbtn_singleClick";
            rdbtn_singleClick.Size = new Size(57, 19);
            rdbtn_singleClick.TabIndex = 12;
            rdbtn_singleClick.TabStop = true;
            rdbtn_singleClick.Text = "Single";
            rdbtn_singleClick.UseVisualStyleBackColor = true;
            rdbtn_singleClick.CheckedChanged += rdbtn_Click_CheckedChanged;
            // 
            // lbl_gradualSpeed
            // 
            lbl_gradualSpeed.AutoSize = true;
            lbl_gradualSpeed.Location = new Point(158, 53);
            lbl_gradualSpeed.Name = "lbl_gradualSpeed";
            lbl_gradualSpeed.Size = new Size(75, 15);
            lbl_gradualSpeed.TabIndex = 11;
            lbl_gradualSpeed.Text = "Smoothness:";
            // 
            // nmrupdwn_gradualSmooth
            // 
            nmrupdwn_gradualSmooth.Location = new Point(238, 52);
            nmrupdwn_gradualSmooth.Margin = new Padding(2, 2, 2, 2);
            nmrupdwn_gradualSmooth.Name = "nmrupdwn_gradualSmooth";
            nmrupdwn_gradualSmooth.Size = new Size(41, 23);
            nmrupdwn_gradualSmooth.TabIndex = 10;
            // 
            // btn_clickMiddle
            // 
            btn_clickMiddle.Location = new Point(158, 84);
            btn_clickMiddle.Name = "btn_clickMiddle";
            btn_clickMiddle.Size = new Size(56, 23);
            btn_clickMiddle.TabIndex = 9;
            btn_clickMiddle.Tag = "Click";
            btn_clickMiddle.Text = "Middle";
            btn_clickMiddle.UseVisualStyleBackColor = true;
            btn_clickMiddle.Click += btn_action_Click;
            // 
            // btn_moveInstant
            // 
            btn_moveInstant.Location = new Point(92, 24);
            btn_moveInstant.Name = "btn_moveInstant";
            btn_moveInstant.Size = new Size(75, 23);
            btn_moveInstant.TabIndex = 8;
            btn_moveInstant.Tag = "Move";
            btn_moveInstant.Text = "Instant";
            btn_moveInstant.UseVisualStyleBackColor = true;
            btn_moveInstant.Click += btn_action_Click;
            // 
            // btn_scrollDown
            // 
            btn_scrollDown.Location = new Point(205, 141);
            btn_scrollDown.Name = "btn_scrollDown";
            btn_scrollDown.Size = new Size(75, 23);
            btn_scrollDown.TabIndex = 7;
            btn_scrollDown.Tag = "Scroll";
            btn_scrollDown.Text = "Down";
            btn_scrollDown.UseVisualStyleBackColor = true;
            btn_scrollDown.Click += btn_action_Click;
            // 
            // btn_scrollUp
            // 
            btn_scrollUp.Location = new Point(92, 141);
            btn_scrollUp.Name = "btn_scrollUp";
            btn_scrollUp.Size = new Size(75, 23);
            btn_scrollUp.TabIndex = 6;
            btn_scrollUp.Tag = "Scroll";
            btn_scrollUp.Text = "Up";
            btn_scrollUp.UseVisualStyleBackColor = true;
            btn_scrollUp.Click += btn_action_Click;
            // 
            // btn_clickRight
            // 
            btn_clickRight.Location = new Point(224, 84);
            btn_clickRight.Name = "btn_clickRight";
            btn_clickRight.Size = new Size(56, 23);
            btn_clickRight.TabIndex = 5;
            btn_clickRight.Tag = "Click";
            btn_clickRight.Text = "Right";
            btn_clickRight.UseVisualStyleBackColor = true;
            btn_clickRight.Click += btn_action_Click;
            // 
            // btn_clickLeft
            // 
            btn_clickLeft.Location = new Point(92, 84);
            btn_clickLeft.Name = "btn_clickLeft";
            btn_clickLeft.Size = new Size(56, 23);
            btn_clickLeft.TabIndex = 4;
            btn_clickLeft.Tag = "Click";
            btn_clickLeft.Text = "Left";
            btn_clickLeft.UseVisualStyleBackColor = true;
            btn_clickLeft.Click += btn_action_Click;
            // 
            // btn_moveGradual
            // 
            btn_moveGradual.Location = new Point(205, 24);
            btn_moveGradual.Name = "btn_moveGradual";
            btn_moveGradual.Size = new Size(75, 23);
            btn_moveGradual.TabIndex = 3;
            btn_moveGradual.Tag = "Move";
            btn_moveGradual.Text = "Gradual";
            btn_moveGradual.UseVisualStyleBackColor = true;
            btn_moveGradual.Click += btn_action_Click;
            // 
            // lbl_scroll
            // 
            lbl_scroll.AutoSize = true;
            lbl_scroll.Location = new Point(15, 145);
            lbl_scroll.Name = "lbl_scroll";
            lbl_scroll.Size = new Size(39, 15);
            lbl_scroll.TabIndex = 2;
            lbl_scroll.Text = "Scroll:";
            // 
            // lbl_click
            // 
            lbl_click.AutoSize = true;
            lbl_click.Location = new Point(14, 88);
            lbl_click.Name = "lbl_click";
            lbl_click.Size = new Size(36, 15);
            lbl_click.TabIndex = 1;
            lbl_click.Text = "Click:";
            // 
            // lbl_move
            // 
            lbl_move.AutoSize = true;
            lbl_move.Location = new Point(14, 28);
            lbl_move.Name = "lbl_move";
            lbl_move.Size = new Size(40, 15);
            lbl_move.TabIndex = 0;
            lbl_move.Text = "Move:";
            // 
            // tmr_checkCoords
            // 
            tmr_checkCoords.Tick += tmr_checkCoords_Tick;
            // 
            // cntxmnustrp_sequences
            // 
            cntxmnustrp_sequences.ImageScalingSize = new Size(24, 24);
            cntxmnustrp_sequences.Items.AddRange(new ToolStripItem[] { loadToolStripMenuItem, deleteToolStripMenuItem });
            cntxmnustrp_sequences.Name = "cntxmnustrp_sequences";
            cntxmnustrp_sequences.Size = new Size(108, 48);
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(107, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // chk_natural
            // 
            chk_natural.AutoSize = true;
            chk_natural.CheckAlign = ContentAlignment.MiddleRight;
            chk_natural.Location = new Point(54, 53);
            chk_natural.Name = "chk_natural";
            chk_natural.Size = new Size(98, 19);
            chk_natural.TabIndex = 16;
            chk_natural.Text = "Natural move";
            chk_natural.UseVisualStyleBackColor = true;
            // 
            // Frm_MouseDummy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 310);
            Controls.Add(grpbx_action);
            Controls.Add(grpbx_pointSelector);
            Controls.Add(grpbx_points);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Frm_MouseDummy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mouse Dummy";
            TopMost = true;
            Load += Frm_MouseDummy_Load;
            KeyDown += Frm_MouseDummy_KeyDown;
            grpbx_points.ResumeLayout(false);
            grpbx_points.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrupdwn_actionDelay).EndInit();
            grpbx_pointSelector.ResumeLayout(false);
            grpbx_pointSelector.PerformLayout();
            grpbx_action.ResumeLayout(false);
            grpbx_action.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrupdwn_gradualSmooth).EndInit();
            cntxmnustrp_sequences.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpbx_points;
        private GroupBox grpbx_pointSelector;
        private GroupBox grpbx_action;
        private ListBox lstbx_points;
        private Label lbl_x;
        private TextBox txtbx_x;
        private TextBox txtbx_y;
        private Button btn_trackMousePos;
        private Button btn_add;
        private Label lbl_y;
        private ComboBox cmbbx_savedSequences;
        private Label lbl_click;
        private Button btn_scrollDown;
        private Button btn_scrollUp;
        private Button btn_clickRight;
        private Button btn_clickLeft;
        private Button btn_moveGradual;
        private Label lbl_scroll;
        private Button btn_moveInstant;
        private Label lbl_move;
        private Button btn_playSequence;
        private System.Windows.Forms.Timer tmr_checkCoords;
        private Button btn_playLoop;
        private ToolTip tltp_help;
        private Button btn_copy;
        private Button btn_delete;
        private Button btn_clickMiddle;
        private NumericUpDown nmrupdwn_gradualSmooth;
        private RadioButton rdbtn_doubleClick;
        private RadioButton rdbtn_singleClick;
        private Label lbl_gradualSpeed;
        private RadioButton rdbtn_tripleClick;
        private NumericUpDown nmrupdwn_actionDelay;
        private Button btn_ClearSequences;
        private Label lbl_movepoint;
        private Button btn_up;
        private Button btn_down;
        private RadioButton rdbtn_HoldRelease;
        private ContextMenuStrip cntxmnustrp_sequences;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private CheckBox chk_natural;
    }
}
