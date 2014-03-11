using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Agent.MVC.Viewer
{
    /// <summary>
    /// Inherits from existing ComboBox
    /// </summary>
    public class ColorComboBox : ComboBox
    {
        public ColorComboBox()
        {
            FillColors();

            // Change DrawMode for custom drawing
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FillColors()
        {
            this.Items.Clear();
            string[] colors = new string[] { "#000000", "#993300", "#333300", "#003300", "#003366", "#000080", "#333399", "#333333", "#800000", "#FF6600", "#808000", "#008000", "#008080", "#0000FF", "#666699", "#808080", "#FF0000", "#FF9900", "#99CC00", "#339966", "#33CCCC", "#3366FF", "#800080", "#969696", "#FF00FF", "#FFCC00", "#FFFF00", "#00FF00", "#00FFFF", "#00CCFF", "#993366", "#C0C0C0", "#FF99CC", "#FFCC99", "#FFFF99", "#CCFFCC", "#CCFFFF", "#99CCFF", "#CC99FF", "#FFFFFF", "#9999FF", "#993366", "#FFFFCC", "#CCFFFF", "#660066", "#FF8080", "#0066CC", "#CCCCFF", "#000080", "#FF00FF", "#FFFF00", "#00FFFF", "#800080", "#800000", "#008080", "#0000FF" };
            Dictionary<int, Color> dicAllowColors = new Dictionary<int, Color>();
            for (int i = 0; i < colors.Length; i++)
            {
                Color color = System.Drawing.ColorTranslator.FromHtml(colors.ElementAt(i));
                if (!dicAllowColors.ContainsKey(color.ToArgb()))
                    dicAllowColors.Add(color.ToArgb(), color);
                //else
                //    MessageBox.Show(color.Name);
            }
                // Fill Colors using Reflection
            foreach (Color color in typeof(Color).GetProperties(BindingFlags.Static | BindingFlags.Public).Where(c => c.PropertyType == typeof(Color)).Select(c => (Color)c.GetValue(c, null)))
            {
                if (dicAllowColors.ContainsKey(color.ToArgb()))
                    this.Items.Add(color);
            }
            
        }

        /// <summary>
        /// Override Draw Method
        /// </summary>
        /// <param name="e"></param>
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                Color color = (Color)this.Items[e.Index];

                int nextX = 0;

                e.Graphics.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);
                DrawColor(e, color, ref nextX);
                DrawText(e, color, nextX);
            }
            else
                base.OnDrawItem(e);
        }

        /// <summary>
        /// Draw the Color rectangle filled with item color
        /// </summary>
        /// <param name="e"></param>
        /// <param name="color"></param>
        /// <param name="nextX"></param>
        private void DrawColor(DrawItemEventArgs e, Color color, ref int nextX)
        {
            int width = e.Bounds.Height * 2 - 8;
            Rectangle rectangle = new Rectangle(e.Bounds.X + 3, e.Bounds.Y + 3, width, e.Bounds.Height - 6);
            e.Graphics.FillRectangle(new SolidBrush(color), rectangle);

            nextX = width + 8;
        }

        /// <summary>
        /// Draw the color name next to the color rectangle
        /// </summary>
        /// <param name="e"></param>
        /// <param name="color"></param>
        /// <param name="nextX"></param>
        private void DrawText(DrawItemEventArgs e, Color color, int nextX)
        {
            e.Graphics.DrawString(color.Name, e.Font, new SolidBrush(e.ForeColor), new PointF(nextX, e.Bounds.Y + (e.Bounds.Height - e.Font.Height) / 2));
        }

        /// <summary>
        /// Gets/sets the selected color of ComboBox
        /// (Default color is Black)
        /// </summary>
        public Color Color
        {
            get
            {
                if (this.SelectedItem != null)
                    return (Color)this.SelectedItem;

                return Color.White;
            }
            set
            {
                int ix = this.Items.IndexOf(value);
                if (ix >= 0)
                    this.SelectedIndex = ix;
            }
        }
    }
}
