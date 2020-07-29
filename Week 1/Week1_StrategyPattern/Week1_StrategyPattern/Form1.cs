using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1_StrategyPattern
{
    public partial class Form1 : Form
    {
        private int next = 0;
        private int current;
        private List<int> readRequests;
        private List<ISchedule> algorithms;

        private OperatingSystem os;

        public Form1()
        {
            InitializeComponent();
            os = new OperatingSystem();
            readRequests = new List<int>();
            algorithms = new List<ISchedule>();
            this.LoadNumbers();
            this.AddAlgorithms();
        }

        private void AddAlgorithms()
        {
            this.algorithms.Add(new FFCS());
            this.algorithms.Add(new SSTF());
            this.algorithms.Add(new ScanDisk());
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            current = this.readRequests[0];
            timer1.Start();
            next = 0;

            this.btnRun.Enabled = false;
            this.btnStop.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ProcessElement(int id)
        {
            if (id == 100)
            {
                id = readRequests.Max();
            }
            else if (id == 0)
            {
                id = readRequests.Min();
            }

            trackBar1.Value = readRequests.First(x => x == id);
            tbNumber.Text = readRequests.First(x => x == id).ToString();
            label2.Text = tbNumber.Text;

            current = readRequests.First(x => x == id);

            lbNumbers.Items.Remove(readRequests.First(x => x == id));
            readRequests.Remove(readRequests.First(x => x == id));

            Random random = new Random();
            int element = random.Next(100);
            readRequests.Add(element);
            lbNumbers.Items.Add(readRequests[readRequests.Count - 1]);
        }

        private void LoadNumbers()
        {
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                int element = random.Next(0, 100);
                readRequests.Add(element);
                lbNumbers.Items.Add(element);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (ISchedule s in algorithms)
            {
                if (rbFFCS.Checked)
                {
                    if (s.GetName() == "First Come First Serve")
                    {
                        os.ChangeAlgorithm(s);
                    }
                }
                else if (rbSSTF.Checked)
                {
                    if (s.GetName() == "Shortest Seek Time First")
                    {
                        os.ChangeAlgorithm(s);
                    }
                }
                else
                {
                    if (s.GetName() == "Scan Disk")
                    {
                        os.ChangeAlgorithm(s);
                    }
                }

            }
            next = os.ReadNext(readRequests, current);
            ProcessElement(next);
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.btnRun.Enabled = true;
            this.btnStop.Enabled = false;
        }

        private void rbFFCS_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
