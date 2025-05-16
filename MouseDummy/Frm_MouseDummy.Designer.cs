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
            grpbx_points = new GroupBox();
            btn_playSecuence = new Button();
            cmbbx_savedSecuences = new ComboBox();
            lstbx_points = new ListBox();
            grpbx_pointSelector = new GroupBox();
            btn_trackMousePos = new Button();
            btn_add = new Button();
            lbl_y = new Label();
            lbl_x = new Label();
            txtbx_x = new TextBox();
            txtbx_y = new TextBox();
            grpbx_action = new GroupBox();
            btn_moveInstant = new Button();
            btn_scrollDown = new Button();
            btn_scrollUp = new Button();
            btn_clickRight = new Button();
            btn_clickLeft = new Button();
            btn_moveGradual = new Button();
            lbl_scroll = new Label();
            lbl_click = new Label();
            lbl_move = new Label();
            grpbx_points.SuspendLayout();
            grpbx_pointSelector.SuspendLayout();
            grpbx_action.SuspendLayout();
            SuspendLayout();
            // 
            // grpbx_points
            // 
            grpbx_points.Controls.Add(btn_playSecuence);
            grpbx_points.Controls.Add(cmbbx_savedSecuences);
            grpbx_points.Controls.Add(lstbx_points);
            grpbx_points.Location = new Point(12, 12);
            grpbx_points.Name = "grpbx_points";
            grpbx_points.Size = new Size(277, 289);
            grpbx_points.TabIndex = 0;
            grpbx_points.TabStop = false;
            grpbx_points.Text = "Points";
            // 
            // btn_playSecuence
            // 
            btn_playSecuence.Location = new Point(233, 19);
            btn_playSecuence.Name = "btn_playSecuence";
            btn_playSecuence.Size = new Size(25, 25);
            btn_playSecuence.TabIndex = 2;
            btn_playSecuence.UseVisualStyleBackColor = true;
            // 
            // cmbbx_savedSecuences
            // 
            cmbbx_savedSecuences.FormattingEnabled = true;
            cmbbx_savedSecuences.Items.AddRange(new object[] { "+ Save the current secuence..." });
            cmbbx_savedSecuences.Location = new Point(16, 19);
            cmbbx_savedSecuences.Name = "cmbbx_savedSecuences";
            cmbbx_savedSecuences.Size = new Size(211, 23);
            cmbbx_savedSecuences.TabIndex = 1;
            cmbbx_savedSecuences.SelectedIndexChanged += cmbbx_savedSecuences_SelectedIndexChanged;
            // 
            // lstbx_points
            // 
            lstbx_points.FormattingEnabled = true;
            lstbx_points.ItemHeight = 15;
            lstbx_points.Location = new Point(16, 48);
            lstbx_points.Name = "lstbx_points";
            lstbx_points.Size = new Size(242, 229);
            lstbx_points.TabIndex = 0;
            // 
            // grpbx_pointSelector
            // 
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
            // btn_trackMousePos
            // 
            btn_trackMousePos.Location = new Point(14, 58);
            btn_trackMousePos.Name = "btn_trackMousePos";
            btn_trackMousePos.Size = new Size(130, 23);
            btn_trackMousePos.TabIndex = 5;
            btn_trackMousePos.Text = "Track Mouse Position";
            btn_trackMousePos.UseVisualStyleBackColor = true;
            btn_trackMousePos.Click += btn_trackMousePos_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(150, 58);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(130, 23);
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
            // 
            // txtbx_y
            // 
            txtbx_y.Location = new Point(173, 20);
            txtbx_y.Name = "txtbx_y";
            txtbx_y.Size = new Size(107, 23);
            txtbx_y.TabIndex = 0;
            // 
            // grpbx_action
            // 
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
            // btn_moveInstant
            // 
            btn_moveInstant.Location = new Point(205, 24);
            btn_moveInstant.Name = "btn_moveInstant";
            btn_moveInstant.Size = new Size(75, 23);
            btn_moveInstant.TabIndex = 8;
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
            btn_scrollUp.Text = "Up";
            btn_scrollUp.UseVisualStyleBackColor = true;
            btn_scrollUp.Click += btn_action_Click;
            // 
            // btn_clickRight
            // 
            btn_clickRight.Location = new Point(205, 84);
            btn_clickRight.Name = "btn_clickRight";
            btn_clickRight.Size = new Size(75, 23);
            btn_clickRight.TabIndex = 5;
            btn_clickRight.Text = "Right";
            btn_clickRight.UseVisualStyleBackColor = true;
            btn_clickRight.Click += btn_action_Click;
            // 
            // btn_clickLeft
            // 
            btn_clickLeft.Location = new Point(92, 84);
            btn_clickLeft.Name = "btn_clickLeft";
            btn_clickLeft.Size = new Size(75, 23);
            btn_clickLeft.TabIndex = 4;
            btn_clickLeft.Text = "Left";
            btn_clickLeft.UseVisualStyleBackColor = true;
            btn_clickLeft.Click += btn_action_Click;
            // 
            // btn_moveGradual
            // 
            btn_moveGradual.Location = new Point(92, 24);
            btn_moveGradual.Name = "btn_moveGradual";
            btn_moveGradual.Size = new Size(75, 23);
            btn_moveGradual.TabIndex = 3;
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
            // Frm_MouseDummy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 310);
            Controls.Add(grpbx_action);
            Controls.Add(grpbx_pointSelector);
            Controls.Add(grpbx_points);
            Name = "Frm_MouseDummy";
            Text = "Mouse Dummy";
            Load += Frm_MouseDummy_Load;
            grpbx_points.ResumeLayout(false);
            grpbx_pointSelector.ResumeLayout(false);
            grpbx_pointSelector.PerformLayout();
            grpbx_action.ResumeLayout(false);
            grpbx_action.PerformLayout();
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
        private ComboBox cmbbx_savedSecuences;
        private Label lbl_click;
        private Button btn_scrollDown;
        private Button btn_scrollUp;
        private Button btn_clickRight;
        private Button btn_clickLeft;
        private Button btn_moveGradual;
        private Label lbl_scroll;
        private Button btn_moveInstant;
        private Label lbl_move;
        private Button btn_playSecuence;
    }
}
