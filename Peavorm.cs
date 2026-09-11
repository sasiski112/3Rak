using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rakendust
{
    public class Peavorm : Form
    {
        private Label txt;
        private Button s;
        private Button m;
        private Button l;
        
        public Peavorm()
        {
            Text = "Peavorm";
            Size = new Size(800, 600);
            StartPosition = FormStartPosition.CenterScreen;
            BackgroundImage = Image.FromFile(@"C:\Users\opilane\Desktop\wallpaper.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
            txt = new Label();
            txt.Text = "Vali rakendus";
            txt.Location = new Point(345, 100);
            txt.AutoSize = true;
            txt.Size = new Size(100, 100);

            s = new Button();
            s.Location = new Point(100, 400);
            s.Size = new Size(150, 80);
            s.Text = "Pildivaatur";
            Color origCol = s.BackColor;
            s.MouseEnter += (sender, Enabled) => { s.BackColor = Color.Gray; };
            s.MouseEnter += (sender, Enabled) => { s.BackColor = origCol; };

            s.MouseClick += (sender, e) =>
            {
                PicViewer viewer = new PicViewer();
                viewer.ShowDialog();
            };

            Controls.Add(txt);
            Controls.Add(s);
        }
    }
}
