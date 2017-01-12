namespace BSpliner
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_plotpoints = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ddb_file = new System.Windows.Forms.ToolStripDropDownButton();
            this.gb_bplinespoints = new System.Windows.Forms.GroupBox();
            this.rb_curve_none = new System.Windows.Forms.RadioButton();
            this.tb_bsplinepoints = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_curve_points = new System.Windows.Forms.RadioButton();
            this.rb_curve_lines = new System.Windows.Forms.RadioButton();
            this.rb_curve_both = new System.Windows.Forms.RadioButton();
            this.gb_controlpoints = new System.Windows.Forms.GroupBox();
            this.rb_control_none = new System.Windows.Forms.RadioButton();
            this.lbl_control_draw = new System.Windows.Forms.Label();
            this.rb_control_lines = new System.Windows.Forms.RadioButton();
            this.rb_control_points = new System.Windows.Forms.RadioButton();
            this.rb_control_both = new System.Windows.Forms.RadioButton();
            this.tb_controlpoints = new System.Windows.Forms.TextBox();
            this.btn_calculatebspline = new System.Windows.Forms.Button();
            this.lbl_bound_x = new System.Windows.Forms.Label();
            this.tb_bound_x = new System.Windows.Forms.TextBox();
            this.gb_boundaries = new System.Windows.Forms.GroupBox();
            this.lbl_bound_z = new System.Windows.Forms.Label();
            this.tb_bound_z = new System.Windows.Forms.TextBox();
            this.lbl_bound_y = new System.Windows.Forms.Label();
            this.tb_bound_y = new System.Windows.Forms.TextBox();
            this.cb_presets = new System.Windows.Forms.ComboBox();
            this.btn_presets_load = new System.Windows.Forms.Button();
            this.gb_presets = new System.Windows.Forms.GroupBox();
            this.pb_calculation = new System.Windows.Forms.ProgressBar();
            this.gb_calculationoptions = new System.Windows.Forms.GroupBox();
            this.lbl_steps = new System.Windows.Forms.Label();
            this.tb_steps = new System.Windows.Forms.TextBox();
            this.lbl_degree = new System.Windows.Forms.Label();
            this.tb_degree = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.gb_bplinespoints.SuspendLayout();
            this.gb_controlpoints.SuspendLayout();
            this.gb_boundaries.SuspendLayout();
            this.gb_presets.SuspendLayout();
            this.gb_calculationoptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_plotpoints
            // 
            this.btn_plotpoints.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_plotpoints.Enabled = false;
            this.btn_plotpoints.Location = new System.Drawing.Point(450, 373);
            this.btn_plotpoints.Name = "btn_plotpoints";
            this.btn_plotpoints.Size = new System.Drawing.Size(106, 67);
            this.btn_plotpoints.TabIndex = 0;
            this.btn_plotpoints.Text = "PLOT\r\nPOINTS\r\n(GNU)";
            this.btn_plotpoints.UseVisualStyleBackColor = true;
            this.btn_plotpoints.Click += new System.EventHandler(this.btn_plotpoints_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddb_file});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1006, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ddb_file
            // 
            this.ddb_file.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddb_file.Image = ((System.Drawing.Image)(resources.GetObject("ddb_file.Image")));
            this.ddb_file.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ddb_file.Name = "ddb_file";
            this.ddb_file.Size = new System.Drawing.Size(46, 24);
            this.ddb_file.Text = "File";
            // 
            // gb_bplinespoints
            // 
            this.gb_bplinespoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_bplinespoints.Controls.Add(this.rb_curve_none);
            this.gb_bplinespoints.Controls.Add(this.tb_bsplinepoints);
            this.gb_bplinespoints.Controls.Add(this.label1);
            this.gb_bplinespoints.Controls.Add(this.rb_curve_points);
            this.gb_bplinespoints.Controls.Add(this.rb_curve_lines);
            this.gb_bplinespoints.Controls.Add(this.rb_curve_both);
            this.gb_bplinespoints.Location = new System.Drawing.Point(562, 89);
            this.gb_bplinespoints.Name = "gb_bplinespoints";
            this.gb_bplinespoints.Size = new System.Drawing.Size(432, 592);
            this.gb_bplinespoints.TabIndex = 0;
            this.gb_bplinespoints.TabStop = false;
            this.gb_bplinespoints.Text = "B-Spline Points";
            // 
            // rb_curve_none
            // 
            this.rb_curve_none.AutoSize = true;
            this.rb_curve_none.Location = new System.Drawing.Point(310, 560);
            this.rb_curve_none.Name = "rb_curve_none";
            this.rb_curve_none.Size = new System.Drawing.Size(63, 21);
            this.rb_curve_none.TabIndex = 10;
            this.rb_curve_none.Text = "None";
            this.rb_curve_none.UseVisualStyleBackColor = true;
            // 
            // tb_bsplinepoints
            // 
            this.tb_bsplinepoints.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_bsplinepoints.Location = new System.Drawing.Point(3, 18);
            this.tb_bsplinepoints.Multiline = true;
            this.tb_bsplinepoints.Name = "tb_bsplinepoints";
            this.tb_bsplinepoints.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_bsplinepoints.Size = new System.Drawing.Size(426, 536);
            this.tb_bsplinepoints.TabIndex = 1;
            this.tb_bsplinepoints.TextChanged += new System.EventHandler(this.tb_bsplinepoints_TextChanged);
            this.tb_bsplinepoints.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnableSelectAll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Draw:";
            // 
            // rb_curve_points
            // 
            this.rb_curve_points.AutoSize = true;
            this.rb_curve_points.Location = new System.Drawing.Point(167, 560);
            this.rb_curve_points.Name = "rb_curve_points";
            this.rb_curve_points.Size = new System.Drawing.Size(68, 21);
            this.rb_curve_points.TabIndex = 7;
            this.rb_curve_points.Text = "Points";
            this.rb_curve_points.UseVisualStyleBackColor = true;
            // 
            // rb_curve_lines
            // 
            this.rb_curve_lines.AutoSize = true;
            this.rb_curve_lines.Checked = true;
            this.rb_curve_lines.Location = new System.Drawing.Point(241, 560);
            this.rb_curve_lines.Name = "rb_curve_lines";
            this.rb_curve_lines.Size = new System.Drawing.Size(63, 21);
            this.rb_curve_lines.TabIndex = 8;
            this.rb_curve_lines.TabStop = true;
            this.rb_curve_lines.Text = "Lines";
            this.rb_curve_lines.UseVisualStyleBackColor = true;
            // 
            // rb_curve_both
            // 
            this.rb_curve_both.AutoSize = true;
            this.rb_curve_both.Location = new System.Drawing.Point(103, 560);
            this.rb_curve_both.Name = "rb_curve_both";
            this.rb_curve_both.Size = new System.Drawing.Size(58, 21);
            this.rb_curve_both.TabIndex = 6;
            this.rb_curve_both.Text = "Both";
            this.rb_curve_both.UseVisualStyleBackColor = true;
            // 
            // gb_controlpoints
            // 
            this.gb_controlpoints.Controls.Add(this.rb_control_none);
            this.gb_controlpoints.Controls.Add(this.lbl_control_draw);
            this.gb_controlpoints.Controls.Add(this.rb_control_lines);
            this.gb_controlpoints.Controls.Add(this.rb_control_points);
            this.gb_controlpoints.Controls.Add(this.rb_control_both);
            this.gb_controlpoints.Controls.Add(this.tb_controlpoints);
            this.gb_controlpoints.Location = new System.Drawing.Point(12, 89);
            this.gb_controlpoints.Name = "gb_controlpoints";
            this.gb_controlpoints.Size = new System.Drawing.Size(432, 592);
            this.gb_controlpoints.TabIndex = 0;
            this.gb_controlpoints.TabStop = false;
            this.gb_controlpoints.Text = "Control Points";
            // 
            // rb_control_none
            // 
            this.rb_control_none.AutoSize = true;
            this.rb_control_none.Checked = true;
            this.rb_control_none.Location = new System.Drawing.Point(309, 560);
            this.rb_control_none.Name = "rb_control_none";
            this.rb_control_none.Size = new System.Drawing.Size(63, 21);
            this.rb_control_none.TabIndex = 5;
            this.rb_control_none.TabStop = true;
            this.rb_control_none.Text = "None";
            this.rb_control_none.UseVisualStyleBackColor = true;
            // 
            // lbl_control_draw
            // 
            this.lbl_control_draw.AutoSize = true;
            this.lbl_control_draw.Location = new System.Drawing.Point(52, 562);
            this.lbl_control_draw.Name = "lbl_control_draw";
            this.lbl_control_draw.Size = new System.Drawing.Size(44, 17);
            this.lbl_control_draw.TabIndex = 4;
            this.lbl_control_draw.Text = "Draw:";
            // 
            // rb_control_lines
            // 
            this.rb_control_lines.AutoSize = true;
            this.rb_control_lines.Location = new System.Drawing.Point(240, 560);
            this.rb_control_lines.Name = "rb_control_lines";
            this.rb_control_lines.Size = new System.Drawing.Size(63, 21);
            this.rb_control_lines.TabIndex = 3;
            this.rb_control_lines.Text = "Lines";
            this.rb_control_lines.UseVisualStyleBackColor = true;
            // 
            // rb_control_points
            // 
            this.rb_control_points.AutoSize = true;
            this.rb_control_points.Location = new System.Drawing.Point(166, 560);
            this.rb_control_points.Name = "rb_control_points";
            this.rb_control_points.Size = new System.Drawing.Size(68, 21);
            this.rb_control_points.TabIndex = 2;
            this.rb_control_points.Text = "Points";
            this.rb_control_points.UseVisualStyleBackColor = true;
            // 
            // rb_control_both
            // 
            this.rb_control_both.AutoSize = true;
            this.rb_control_both.Location = new System.Drawing.Point(102, 560);
            this.rb_control_both.Name = "rb_control_both";
            this.rb_control_both.Size = new System.Drawing.Size(58, 21);
            this.rb_control_both.TabIndex = 1;
            this.rb_control_both.Text = "Both";
            this.rb_control_both.UseVisualStyleBackColor = true;
            // 
            // tb_controlpoints
            // 
            this.tb_controlpoints.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_controlpoints.Location = new System.Drawing.Point(3, 18);
            this.tb_controlpoints.Multiline = true;
            this.tb_controlpoints.Name = "tb_controlpoints";
            this.tb_controlpoints.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_controlpoints.Size = new System.Drawing.Size(426, 536);
            this.tb_controlpoints.TabIndex = 0;
            this.tb_controlpoints.TextChanged += new System.EventHandler(this.tb_controlpoints_TextChanged);
            this.tb_controlpoints.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnableSelectAll);
            // 
            // btn_calculatebspline
            // 
            this.btn_calculatebspline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_calculatebspline.Enabled = false;
            this.btn_calculatebspline.Location = new System.Drawing.Point(450, 289);
            this.btn_calculatebspline.Name = "btn_calculatebspline";
            this.btn_calculatebspline.Size = new System.Drawing.Size(106, 67);
            this.btn_calculatebspline.TabIndex = 0;
            this.btn_calculatebspline.Text = "CALCULATE\r\nPOINTS\r\n(>>)";
            this.btn_calculatebspline.UseVisualStyleBackColor = true;
            this.btn_calculatebspline.Click += new System.EventHandler(this.btn_calculatebspline_Click);
            // 
            // lbl_bound_x
            // 
            this.lbl_bound_x.AutoSize = true;
            this.lbl_bound_x.Location = new System.Drawing.Point(6, 24);
            this.lbl_bound_x.Name = "lbl_bound_x";
            this.lbl_bound_x.Size = new System.Drawing.Size(21, 17);
            this.lbl_bound_x.TabIndex = 2;
            this.lbl_bound_x.Text = "X:";
            // 
            // tb_bound_x
            // 
            this.tb_bound_x.Location = new System.Drawing.Point(30, 21);
            this.tb_bound_x.MaxLength = 12;
            this.tb_bound_x.Name = "tb_bound_x";
            this.tb_bound_x.Size = new System.Drawing.Size(73, 22);
            this.tb_bound_x.TabIndex = 3;
            this.tb_bound_x.Text = "-100, 100";
            // 
            // gb_boundaries
            // 
            this.gb_boundaries.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gb_boundaries.Controls.Add(this.lbl_bound_z);
            this.gb_boundaries.Controls.Add(this.tb_bound_z);
            this.gb_boundaries.Controls.Add(this.lbl_bound_y);
            this.gb_boundaries.Controls.Add(this.tb_bound_y);
            this.gb_boundaries.Controls.Add(this.lbl_bound_x);
            this.gb_boundaries.Controls.Add(this.tb_bound_x);
            this.gb_boundaries.Location = new System.Drawing.Point(450, 446);
            this.gb_boundaries.Name = "gb_boundaries";
            this.gb_boundaries.Size = new System.Drawing.Size(109, 110);
            this.gb_boundaries.TabIndex = 4;
            this.gb_boundaries.TabStop = false;
            this.gb_boundaries.Text = "Boundaries";
            // 
            // lbl_bound_z
            // 
            this.lbl_bound_z.AutoSize = true;
            this.lbl_bound_z.Location = new System.Drawing.Point(6, 80);
            this.lbl_bound_z.Name = "lbl_bound_z";
            this.lbl_bound_z.Size = new System.Drawing.Size(21, 17);
            this.lbl_bound_z.TabIndex = 6;
            this.lbl_bound_z.Text = "Z:";
            // 
            // tb_bound_z
            // 
            this.tb_bound_z.Location = new System.Drawing.Point(30, 80);
            this.tb_bound_z.MaxLength = 12;
            this.tb_bound_z.Name = "tb_bound_z";
            this.tb_bound_z.Size = new System.Drawing.Size(73, 22);
            this.tb_bound_z.TabIndex = 7;
            this.tb_bound_z.Text = "-100, 100";
            // 
            // lbl_bound_y
            // 
            this.lbl_bound_y.AutoSize = true;
            this.lbl_bound_y.Location = new System.Drawing.Point(6, 52);
            this.lbl_bound_y.Name = "lbl_bound_y";
            this.lbl_bound_y.Size = new System.Drawing.Size(21, 17);
            this.lbl_bound_y.TabIndex = 6;
            this.lbl_bound_y.Text = "Y:";
            // 
            // tb_bound_y
            // 
            this.tb_bound_y.Location = new System.Drawing.Point(30, 49);
            this.tb_bound_y.MaxLength = 12;
            this.tb_bound_y.Name = "tb_bound_y";
            this.tb_bound_y.Size = new System.Drawing.Size(73, 22);
            this.tb_bound_y.TabIndex = 7;
            this.tb_bound_y.Text = "-100, 100";
            // 
            // cb_presets
            // 
            this.cb_presets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_presets.FormattingEnabled = true;
            this.cb_presets.Items.AddRange(new object[] {
            "Box",
            "Clover",
            "Random",
            "Tornado",
            "Triangle"});
            this.cb_presets.Location = new System.Drawing.Point(6, 21);
            this.cb_presets.Name = "cb_presets";
            this.cb_presets.Size = new System.Drawing.Size(326, 24);
            this.cb_presets.TabIndex = 5;
            this.cb_presets.SelectedIndexChanged += new System.EventHandler(this.cb_presets_SelectedIndexChanged);
            // 
            // btn_presets_load
            // 
            this.btn_presets_load.Location = new System.Drawing.Point(338, 20);
            this.btn_presets_load.Name = "btn_presets_load";
            this.btn_presets_load.Size = new System.Drawing.Size(85, 26);
            this.btn_presets_load.TabIndex = 7;
            this.btn_presets_load.Text = "Load";
            this.btn_presets_load.UseVisualStyleBackColor = true;
            this.btn_presets_load.Click += new System.EventHandler(this.btn_presets_load_Click);
            // 
            // gb_presets
            // 
            this.gb_presets.Controls.Add(this.btn_presets_load);
            this.gb_presets.Controls.Add(this.cb_presets);
            this.gb_presets.Location = new System.Drawing.Point(12, 31);
            this.gb_presets.Name = "gb_presets";
            this.gb_presets.Size = new System.Drawing.Size(432, 52);
            this.gb_presets.TabIndex = 8;
            this.gb_presets.TabStop = false;
            this.gb_presets.Text = "Presets";
            // 
            // pb_calculation
            // 
            this.pb_calculation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_calculation.Location = new System.Drawing.Point(450, 260);
            this.pb_calculation.Name = "pb_calculation";
            this.pb_calculation.Size = new System.Drawing.Size(106, 23);
            this.pb_calculation.TabIndex = 9;
            this.pb_calculation.Visible = false;
            // 
            // gb_calculationoptions
            // 
            this.gb_calculationoptions.Controls.Add(this.lbl_steps);
            this.gb_calculationoptions.Controls.Add(this.tb_steps);
            this.gb_calculationoptions.Controls.Add(this.lbl_degree);
            this.gb_calculationoptions.Controls.Add(this.tb_degree);
            this.gb_calculationoptions.Location = new System.Drawing.Point(562, 31);
            this.gb_calculationoptions.Name = "gb_calculationoptions";
            this.gb_calculationoptions.Size = new System.Drawing.Size(432, 52);
            this.gb_calculationoptions.TabIndex = 10;
            this.gb_calculationoptions.TabStop = false;
            this.gb_calculationoptions.Text = "Calculation Options";
            // 
            // lbl_steps
            // 
            this.lbl_steps.AutoSize = true;
            this.lbl_steps.Location = new System.Drawing.Point(299, 24);
            this.lbl_steps.Name = "lbl_steps";
            this.lbl_steps.Size = new System.Drawing.Size(48, 17);
            this.lbl_steps.TabIndex = 6;
            this.lbl_steps.Text = "Steps:";
            // 
            // tb_steps
            // 
            this.tb_steps.Location = new System.Drawing.Point(353, 21);
            this.tb_steps.MaxLength = 12;
            this.tb_steps.Name = "tb_steps";
            this.tb_steps.Size = new System.Drawing.Size(73, 22);
            this.tb_steps.TabIndex = 7;
            this.tb_steps.Text = "300";
            this.tb_steps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNumberFilter);
            // 
            // lbl_degree
            // 
            this.lbl_degree.AutoSize = true;
            this.lbl_degree.Location = new System.Drawing.Point(6, 25);
            this.lbl_degree.Name = "lbl_degree";
            this.lbl_degree.Size = new System.Drawing.Size(59, 17);
            this.lbl_degree.TabIndex = 4;
            this.lbl_degree.Text = "Degree:";
            // 
            // tb_degree
            // 
            this.tb_degree.Location = new System.Drawing.Point(71, 22);
            this.tb_degree.MaxLength = 12;
            this.tb_degree.Name = "tb_degree";
            this.tb_degree.Size = new System.Drawing.Size(73, 22);
            this.tb_degree.TabIndex = 5;
            this.tb_degree.Text = "3";
            this.tb_degree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressNumberFilter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 693);
            this.Controls.Add(this.gb_calculationoptions);
            this.Controls.Add(this.pb_calculation);
            this.Controls.Add(this.gb_presets);
            this.Controls.Add(this.gb_boundaries);
            this.Controls.Add(this.gb_bplinespoints);
            this.Controls.Add(this.btn_plotpoints);
            this.Controls.Add(this.gb_controlpoints);
            this.Controls.Add(this.btn_calculatebspline);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "B-Spliner GUI v1.0";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gb_bplinespoints.ResumeLayout(false);
            this.gb_bplinespoints.PerformLayout();
            this.gb_controlpoints.ResumeLayout(false);
            this.gb_controlpoints.PerformLayout();
            this.gb_boundaries.ResumeLayout(false);
            this.gb_boundaries.PerformLayout();
            this.gb_presets.ResumeLayout(false);
            this.gb_calculationoptions.ResumeLayout(false);
            this.gb_calculationoptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_plotpoints;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton ddb_file;
        private System.Windows.Forms.GroupBox gb_bplinespoints;
        private System.Windows.Forms.GroupBox gb_controlpoints;
        private System.Windows.Forms.Button btn_calculatebspline;
        private System.Windows.Forms.Label lbl_bound_x;
        private System.Windows.Forms.TextBox tb_bound_x;
        private System.Windows.Forms.GroupBox gb_boundaries;
        private System.Windows.Forms.Label lbl_bound_y;
        private System.Windows.Forms.TextBox tb_bound_y;
        private System.Windows.Forms.Label lbl_bound_z;
        private System.Windows.Forms.TextBox tb_bound_z;
        private System.Windows.Forms.ComboBox cb_presets;
        private System.Windows.Forms.Button btn_presets_load;
        private System.Windows.Forms.TextBox tb_controlpoints;
        private System.Windows.Forms.TextBox tb_bsplinepoints;
        private System.Windows.Forms.GroupBox gb_presets;
        private System.Windows.Forms.ProgressBar pb_calculation;
        private System.Windows.Forms.GroupBox gb_calculationoptions;
        private System.Windows.Forms.Label lbl_degree;
        private System.Windows.Forms.TextBox tb_degree;
        private System.Windows.Forms.Label lbl_steps;
        private System.Windows.Forms.TextBox tb_steps;
        private System.Windows.Forms.RadioButton rb_control_lines;
        private System.Windows.Forms.RadioButton rb_control_points;
        private System.Windows.Forms.RadioButton rb_control_both;
        private System.Windows.Forms.Label lbl_control_draw;
        private System.Windows.Forms.RadioButton rb_control_none;
        private System.Windows.Forms.RadioButton rb_curve_none;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_curve_points;
        private System.Windows.Forms.RadioButton rb_curve_lines;
        private System.Windows.Forms.RadioButton rb_curve_both;
    }
}

