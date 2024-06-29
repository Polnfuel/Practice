using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Info : Form
    {
        string text;
        int funcId;
        public Info(int index)
        {
            InitializeComponent();
            funcId = index;
            RefInfo refinfo = new RefInfo();
            if (index == 0)
                text = refinfo.SineText;
            else if (index == 1)
                text = refinfo.CosineText;
            else if (index == 2)
                text = refinfo.TangentText;
            else if (index == 3)
                text = refinfo.CotangentText;
        }
        private void Info_Load(object sender, EventArgs e)
        {
            if (funcId == 0)
                Text = "Синус";
            else if (funcId == 1)
                Text = "Косинус";
            else if (funcId == 2)
                Text = "Тангенс";
            else if (funcId == 3)
                Text = "Котангенс";
            TextLabel.Text = text;
        }
    }
}
