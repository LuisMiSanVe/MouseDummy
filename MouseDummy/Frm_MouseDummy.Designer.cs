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
            grpbx_pointSelector = new GroupBox();
            grpbx_action = new GroupBox();
            lstbx_points = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lbl_x = new Label();
            lbl_y = new Label();
            btn_add = new Button();
            btn_trackMouseCoor = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            grpbx_points.SuspendLayout();
            grpbx_pointSelector.SuspendLayout();
            grpbx_action.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // grpbx_points
            // 
            grpbx_points.Controls.Add(lstbx_points);
            grpbx_points.Location = new Point(12, 12);
            grpbx_points.Name = "grpbx_points";
            grpbx_points.Size = new Size(277, 426);
            grpbx_points.TabIndex = 0;
            grpbx_points.TabStop = false;
            grpbx_points.Text = "Points";
            // 
            // grpbx_pointSelector
            // 
            grpbx_pointSelector.Controls.Add(btn_trackMouseCoor);
            grpbx_pointSelector.Controls.Add(btn_add);
            grpbx_pointSelector.Controls.Add(lbl_y);
            grpbx_pointSelector.Controls.Add(lbl_x);
            grpbx_pointSelector.Controls.Add(textBox2);
            grpbx_pointSelector.Controls.Add(textBox1);
            grpbx_pointSelector.Location = new Point(295, 12);
            grpbx_pointSelector.Name = "grpbx_pointSelector";
            grpbx_pointSelector.Size = new Size(291, 100);
            grpbx_pointSelector.TabIndex = 1;
            grpbx_pointSelector.TabStop = false;
            grpbx_pointSelector.Text = "Point Select";
            // 
            // grpbx_action
            // 
            grpbx_action.Controls.Add(tabControl1);
            grpbx_action.Location = new Point(295, 118);
            grpbx_action.Name = "grpbx_action";
            grpbx_action.Size = new Size(291, 320);
            grpbx_action.TabIndex = 2;
            grpbx_action.TabStop = false;
            grpbx_action.Text = "Actions";
            // 
            // lstbx_points
            // 
            lstbx_points.FormattingEnabled = true;
            lstbx_points.ItemHeight = 15;
            lstbx_points.Location = new Point(6, 18);
            lstbx_points.Name = "lstbx_points";
            lstbx_points.Size = new Size(265, 394);
            lstbx_points.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 20);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(107, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(37, 20);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(107, 23);
            textBox2.TabIndex = 1;
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
            // lbl_y
            // 
            lbl_y.AutoSize = true;
            lbl_y.Location = new Point(150, 23);
            lbl_y.Name = "lbl_y";
            lbl_y.Size = new Size(17, 15);
            lbl_y.TabIndex = 3;
            lbl_y.Text = "Y:";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(150, 58);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(130, 23);
            btn_add.TabIndex = 4;
            btn_add.Text = "Add (N)";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_trackMouseCoor
            // 
            btn_trackMouseCoor.Location = new Point(14, 58);
            btn_trackMouseCoor.Name = "btn_trackMouseCoor";
            btn_trackMouseCoor.Size = new Size(130, 23);
            btn_trackMouseCoor.TabIndex = 5;
            btn_trackMouseCoor.Text = "Track Mouse Position";
            btn_trackMouseCoor.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(14, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(266, 288);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(258, 260);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 72);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Frm_MouseDummy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 450);
            Controls.Add(grpbx_action);
            Controls.Add(grpbx_pointSelector);
            Controls.Add(grpbx_points);
            Name = "Frm_MouseDummy";
            Text = "Mouse Dummy";
            grpbx_points.ResumeLayout(false);
            grpbx_pointSelector.ResumeLayout(false);
            grpbx_pointSelector.PerformLayout();
            grpbx_action.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpbx_points;
        private GroupBox grpbx_pointSelector;
        private GroupBox grpbx_action;
        private ListBox lstbx_points;
        private Label lbl_x;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btn_trackMouseCoor;
        private Button btn_add;
        private Label lbl_y;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}
