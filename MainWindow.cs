namespace Practice
{
    public partial class MainWindow : Form
    {
        public static Bitmap bmp;
        public static Graphics g;
        public static int functionId;
        public static double start;
        public static double end;
        public static bool itemIsRadian;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(GraphBox.Width, GraphBox.Height);
            GraphBox.Image = bmp;
            g = Graphics.FromImage(GraphBox.Image);
            FuncSelectBox.Text = FuncSelectBox.Items[0].ToString();
        }

        private void DoGraphButton_Click(object sender, EventArgs e)
        {
            if (RadianItem.Checked)
            {
                start = (double)startRange.Value;
                end = (double)endRange.Value;
            }
            else
            {
                start = (double)startRange.Value * Math.PI / 180;
                end = (double)endRange.Value * Math.PI / 180;
            }

            functionId = FuncSelectBox.SelectedIndex;

            if (RadianItem.Checked)
                itemIsRadian = true;
            else
                itemIsRadian = false;

            if (start < end)
            {
                double width = end - start;
                double onePixel = width / 800;
                double x, y, ypix;
                Brush brush = new SolidBrush(Color.Black);
                Brush gridbrush = new SolidBrush(Color.LightGray);
                g.Clear(Color.White);
                Font font = new Font("Arial", 10);
                g.FillRectangle(new SolidBrush(Color.Red), 0, 200, 804, 2);

                bool xaxis = true;
                for (double i = 0; i <= 800; i++)
                {
                    x = start + i * onePixel;
                    if (functionId == 0)
                        y = -Math.Sin(x);
                    else if (functionId == 1)
                        y = -Math.Cos(x);
                    else if (functionId == 2)
                        y = -Math.Tan(x);
                    else if (functionId == 3)
                        if (Math.Tan(x) != 0)
                            y = -1 / Math.Tan(x);
                        else y = 1000;
                    else
                        y = 0;
                    ypix = y / onePixel + 199;
                    if (ypix <= 400 && ypix >= 0)
                        g.FillRectangle(brush, (float)i, (float)ypix, 2, 2);

                    if (Math.Abs(x - (int)x) < onePixel && (int)x == 0)
                    {
                        if (xaxis)
                        {
                            g.FillRectangle(new SolidBrush(Color.Red), (float)i, 0, 2, 410);
                            for (int j = (int)i + 1 + (int)width * 800; j >= 0; j -= 80)
                            {
                                if (RadianItem.Checked)
                                    x = start + j * onePixel;
                                else
                                    x = (start + j * onePixel) * 180 / Math.PI;
                                g.FillRectangle(gridbrush, (float)j, 0, 1, 410);
                                g.DrawString(Math.Round(x, 1).ToString(), font, brush, (float)j - 10, 410);
                            }
                            xaxis = false;
                        }
                    }
                    else if ((start > 0 || end < 0) && xaxis)
                    {
                        for (int j = 0; j <= 800; j += 80)
                        {
                            if (RadianItem.Checked)
                                x = start + j * onePixel;
                            else
                                x = (start + j * onePixel) * 180 / Math.PI;
                            g.FillRectangle(gridbrush, (float)j, 0, 1, 410);
                            g.DrawString(Math.Round(x, 1).ToString(), font, brush, (float)j - 10, 410);
                        }
                        xaxis = false;
                    }
                    if (i % 80 == 40 && i != 200)
                    {
                        g.FillRectangle(gridbrush, 0, (float)i, 804, 1);
                    }
                }
                for (int j = 360; j >= 0; j -= 80)
                {
                    y = -(j - 200) / 80 * (width / 10);
                    g.DrawString(Math.Round(y, 2).ToString(), font, brush, 805, (float)j - 10);
                }
            }
            else
                MessageBox.Show("Неверно задан интервал!");
            GraphBox.Invalidate();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Сохранить график как ...";
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter = "PNG File(*.png)|*.png|Bitmap File(*.bmp)|*.bmp|GIF File(*.gif)|*.gif|JPEG File(*.jpg)|*jpg";
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = savedialog.FileName;
                string strFilExtn = fileName.Remove(0, fileName.Length - 3);
                switch (strFilExtn)
                {
                    case "bmp":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "jpg":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "png":
                        bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }
            }
        }
        private void GradusItem_CheckedChanged(object sender, EventArgs e)
        {
            if (GradusItem.Checked)
            {
                startRange.Maximum = 1000;
                startRange.Minimum = -1000;
                endRange.Maximum = 1000;
                endRange.Minimum = -1000;
            }
            if (!GradusItem.Checked)
            {
                startRange.Maximum = 100;
                startRange.Minimum = -100;
                endRange.Maximum = 100;
                endRange.Minimum = -100;
            }
        }
        private void InfoButton_Click(object sender, EventArgs e)
        {
            Info info = new Info(FuncSelectBox.SelectedIndex);
            info.Show();
        }
    }
}
