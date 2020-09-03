using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr3_2
{
  public partial class Form1 : Form
  {
    Timer t;
    public Form1()
    {
      InitializeComponent();
    }
        private void timer1_Tick(object sender, EventArgs e)
    {
    }
        private void progressBar1_Click(object sender, EventArgs e)
    {
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      t = new System.Windows.Forms.Timer();
      t.Interval = 1000;
      t.Tick += new EventHandler(t_Tick);
      t.Start();
    }
    void t_Tick(object sender, EventArgs e)
    {
      progressBar1.Value += 1;
      if (progressBar1.Value >= 100) 
        t.Stop();
    }
  }
}
