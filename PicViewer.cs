using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rakendust
{
    public partial class PicViewer : Form
    {
        private PictureBox pb;
        private Button but;
        public PicViewer()
        {
            InitializeComponent();
            Size = new Size(800, 600);
            StartPosition = FormStartPosition.CenterParent;

            pb = new PictureBox();
            pb.Location = new Point(20, 20);
            pb.Size = new Size(540, 380);
            pb.SizeMode = PictureBoxSizeMode.Zoom;

            but = new Button();
            but.Text = "Vali pilt";
            but.Location = new Point(20, 415);
            but.Size = new Size(180, 30);
            but.Click += choosepic_Load;

            this.Controls.Add(pb);
            this.Controls.Add(but);
        }

        private void PicViewer_Load(object sender, EventArgs e)
        {
            // Здесь код загрузки формы (можно оставить пустым)
        }
        private void choosepic_Load(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Pildid|*.jpg;*.jpeg;*.png;*.gif";
                ofd.Title = "Vali pilt";

                // Автоматически получаем путь к папке "Загрузки" текущего пользователя
                string downloadsPath = System.IO.Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    "Downloads"
                );

                // Устанавливаем начальную папку для поиска
                ofd.InitialDirectory = downloadsPath;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Загружаем выбранный файл
                    pb.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
        private void showpic_Load(object sender, EventArgs e)
        {

        }
        private void closebut_Load(object sender, EventArgs e)
        {

        }
        private void setback_Load(object sender, EventArgs e)
        {

        }
        private void clearbut_Load(object sender, EventArgs e)
        {

        }
    }
}
