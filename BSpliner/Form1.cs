using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // Process for GNUPlot
using System.IO;

namespace BSpliner
{
    public partial class Form1 : Form
    {
        private Curve CurveControl = new Curve(); // Curve class that does all the calculations
        private List<Vertex> ControlPoints; // Control points
        private List<Vertex> CurvePoints; // B-Spline points
        private int Steps = 1000; // Used for calculation of curve points
        private int Degree = 3; // ^^ Ditto ^^

        // Boundaries used in GNUPlot
        private Vertex Min = new Vertex(-100, -100, -100);
        private Vertex Max = new Vertex(100, 100, 100);

        // Used for Preset Selection
        int PreviousIndex = 0;

        public Form1()
        {
            InitializeComponent();
            cb_presets.SelectedIndex = 2; // Random
            CurveControl.ProgressChanged += CurveControl_ProgressChanged;

            // Sets default steps/degree values
            tb_steps.Text = Steps.ToString();
            tb_degree.Text = Degree.ToString();

            // Not implemented yet
            ddb_file.Enabled = false;
            gb_boundaries.Enabled = false;
        }
        
        /// <summary>
        /// Reads points from string and converts to vertex list
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private List<Vertex> GetPointsFromString(string data)
        {
            List<Vertex> points = new List<Vertex>();

            // Splits string by line and removes empty lines
            string[] lines = data.Split(new[] { '\r', 'n' });

            int index = 1;
            foreach (string line in lines)
            {
                // Attempts to read each coordinate of point
                //  Goes to next line if unable
                string[] point = line.Split(' ');
                if (point.Length < 3) continue;

                float x, y, z;

                try
                {
                    x = Convert.ToSingle(point[0]);
                }
                catch
                {
                    MessageBox.Show(String.Format("Cannot convert \"{0}\" on line {1} to floating point", point[0], index));
                    continue;
                }

                try
                {
                    y = Convert.ToSingle(point[1]);
                }
                catch
                {
                    MessageBox.Show(String.Format("Cannot convert \"{0}\" on line {1} to floating point", point[1], index));
                    continue;
                }

                try
                {
                    z = Convert.ToSingle(point[2]);
                }
                catch
                {
                    MessageBox.Show(String.Format("Cannot convert \"{0}\" on line {1} to floating point", point[2], index));
                    continue;
                }

                // Adds new point to list of points
                points.Add(new Vertex(x, y, z));
                index++;
            }

            return points;
        }

        // Updates progress bar
        private void CurveControl_ProgressChanged(float p)
        {
            if (p >= 1.0f)
            {
                pb_calculation.Visible = false;
                return;
            }
            
            pb_calculation.Visible = true;
            pb_calculation.Value = (int)(100.0f * p);
        }
        
        bool WritePointsToFile(List<Vertex> verts, string path)
        {
            // Creates path directory if it doesn't exist
            if (Directory.Exists(Path.GetDirectoryName(path)))
                Directory.CreateDirectory(Path.GetDirectoryName(path));

            // Writes to file
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.ASCII))
            {
                sw.Write(GetStringFromPoints(verts));
            }
            
            return true;
        }
        
        string GetStringFromPoints(List<Vertex> points)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Vertex v in points)
                sb.AppendLine(v.ToString());

            return sb.ToString();
        }

        /// <summary>
        /// Writes command file for GNUPlot
        /// </summary>
        /// <param name="control"></param>
        /// <param name="curve"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        bool WriteCommandFile(string control, string curve, string path)
        {
            // Creates path directory if it doesn't exist
            if (Directory.Exists(Path.GetDirectoryName(path)))
                Directory.CreateDirectory(Path.GetDirectoryName(path));

            // Creates/opens file and writes command file for GNUPlot
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.ASCII))
            {
                // Axis ranges
                sw.WriteLine("set xrange [{0}:{1}]", Min.X, Max.X);
                sw.WriteLine("set yrange [{0}:{1}]", Min.Y, Max.Y);
                sw.WriteLine("set zrange [{0}:{1}]", Min.Z, Max.Z);

                // Axis labels
                sw.WriteLine("set xlabel \"X Axis\"");
                sw.WriteLine("set ylabel \"Y Axis\"");
                sw.WriteLine("set zlabel \"Z Axis\"");
                sw.WriteLine();

                // Plot command for B-Spline
                sw.WriteLine(GetPlotCommand(control, curve));
                
                sw.Write("pause -1");
            }

            return true;
        }

        // Gets splot command needed to draw points in GNUPlot
        private string GetPlotCommand(string control, string curve)
        {
            StringBuilder sb = new StringBuilder();
            List<string> commands = new List<string>();

            if (rb_control_both.Checked || rb_control_points.Checked)
                commands.Add(string.Format("\'{0}\' title \"Control Points\" lc rgb \"green\"", control));

            if (rb_control_both.Checked || rb_control_lines.Checked)
                commands.Add(string.Format("\'{0}\' title \"Control Lines\" lc rgb \"purple\" with lines", control));

            if (rb_curve_both.Checked || rb_curve_points.Checked)
                commands.Add(string.Format("\'{0}\' title \"Curve Points\" lc rgb \"red\"", curve));

            if (rb_curve_both.Checked || rb_curve_lines.Checked)
                commands.Add(string.Format("\'{0}\' title \"Curve\" lc rgb \"blue\" with lines", curve));

            for (int i = 0; i < commands.Count; i++)
            {
                if (i == 0)
                    sb.Append(string.Format("splot {0}", commands[i]));
                else
                    sb.Append(string.Format(", {0}", commands[i]));
            }
            
            return sb.ToString();
        }
        
        private void btn_presets_load_Click(object sender, EventArgs e)
        {
            if (!(cb_presets.SelectedItem is string)) return; // Returns if selected item isn't a string

            btn_presets_load.Text = "Re-Load";

            // Loads preset control points
            switch((string)cb_presets.SelectedItem)
            {
                case "Tornado":
                    ControlPoints = PresetPoints.Tornado(Min, Max);
                    break;
                case "Box":
                    ControlPoints = PresetPoints.Box();
                    break;
                case "Triangle":
                    ControlPoints = PresetPoints.Triangle();
                    break;
                case "Random":
                    ControlPoints = PresetPoints.Random(100, 100);
                    break;
                case "Clover":
                    ControlPoints = PresetPoints.Clover();
                    break;
            }

            // Updates control points textbox
            tb_controlpoints.Text = GetStringFromPoints(ControlPoints);
        }

        private void btn_calculatebspline_Click(object sender, EventArgs e)
        {
            // Reads points from text
            ControlPoints = GetPointsFromString(tb_controlpoints.Text);

            // Updates Degree and Step values
            try
            {
                Degree = Convert.ToInt32(tb_degree.Text);
            }
            catch
            {
                Degree = 0;
                tb_degree.Text = "0";
            }
            try
            {
                Steps = Convert.ToInt32(tb_steps.Text);
            }
            catch
            {
                Degree = 0;
                tb_steps.Text = "0";
            }

            // Updates B-Spline points
            CurvePoints = CurveControl.GenerateBSpline(ControlPoints, Degree, Steps);
            
            // Updates B-Spline textbox
            tb_bsplinepoints.Text = GetStringFromPoints(CurvePoints);
        }

        private void tb_bsplinepoints_TextChanged(object sender, EventArgs e)
        {
            if (tb_bsplinepoints.Text == null || tb_bsplinepoints.Text == "")
            {
                btn_plotpoints.Enabled = false;
                return;
            }
            
            btn_plotpoints.Enabled = true;
        }

        private void tb_controlpoints_TextChanged(object sender, EventArgs e)
        {
            if (tb_controlpoints == null || tb_controlpoints.Text == "")
            {
                btn_calculatebspline.Enabled = false;
                return;
            }

            btn_calculatebspline.Enabled = true;
        }

        // Runs GNU Plot
        private void btn_plotpoints_Click(object sender, EventArgs e)
        {
            // Updates points
            ControlPoints = GetPointsFromString(tb_controlpoints.Text);
            CurvePoints = GetPointsFromString(tb_bsplinepoints.Text);

            // Writes out needed files
            WriteCommandFile("ControlPoints.txt", "CurvePoints.txt", "Command.txt");
            WritePointsToFile(ControlPoints, "ControlPoints.txt");
            WritePointsToFile(CurvePoints, "CurvePoints.txt");

            // Runs GNU Plot
            Process p = Process.Start("gnuplot.exe", "Command.txt");
            p.WaitForExit();
        }
        
        private void cb_presets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PreviousIndex != cb_presets.SelectedIndex)
                btn_presets_load.Text = "Load";

            PreviousIndex = cb_presets.SelectedIndex;
        }

        private void KeyPressNumberFilter(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void EnableSelectAll(object sender, KeyEventArgs e)
        {
            if (!(sender is TextBox)) return;

            if (e.Control && e.KeyCode == Keys.A)
            {
                if (sender != null)
                    ((TextBox)sender).SelectAll();
            }
        }

        // Not used
        private void CheckedChanged(object sender, EventArgs e)
        {
            if (rb_control_none.Checked && rb_curve_none.Checked)
                btn_plotpoints.Enabled = false;
            else
                btn_plotpoints.Enabled = true;
        }
    }
}
