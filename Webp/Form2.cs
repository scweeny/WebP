using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Webp
{
    public partial class Form2 : Form
    {
        Form1 f1;
        private Thread T_dwemp;
        bool is_stop = false;
        Process process = new Process();
        public Form2(Form1 form)
        {
            InitializeComponent();
            f1 = form;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.Visible = true;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                T_Save_Path.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    listView1.Items.Add(openFileDialog1.FileNames[i]);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        void dwebp_thread()
        {
            string command;
            ProcessStartInfo cmd = new ProcessStartInfo();

            cmd.WindowStyle = ProcessWindowStyle.Hidden;             // cmd창이 숨겨지도록 하기
            cmd.CreateNoWindow = true;                               // cmd창을 띄우지 안도록 하기

            cmd.UseShellExecute = false;
            cmd.RedirectStandardOutput = true;        // cmd창에서 데이터를 가져오기
            cmd.RedirectStandardInput = true;          // cmd창으로 데이터 보내기
            cmd.RedirectStandardError = true;          // cmd창에서 오류 내용 가져오기


            command = "\"" + T_Work_file.Text + "\"";


            if (Chkbox_MT.Checked)
                command = command + " -mt";
            else
                command = command + "";

            String[] spstring = T_Work_file.Text.Split('\\');


            command = command + " -o " + "\"" + T_Save_Path.Text + @"\" + spstring[spstring.Length - 1] + ".png" + "\"";

            cmd.FileName = @"binary\dwebp.exe";
            cmd.Arguments = command;

            process.StartInfo = cmd;

            process.EnableRaisingEvents = true;

            process.Start();
            /*SRffmpeg = process.StandardError;
            while (process.HasExited == false)
            {
                tmp = SRffmpeg.ReadLine();

                String[] spstring = tmp.Split(' ');
                if (spstring[0] == "frame=")
                {
                    try
                    {
                        if (spstring[1] == "")
                            t1 = double.Parse(spstring[2]);
                        else
                            t1 = double.Parse(spstring[1]);
                        t2 = double.Parse(label2.Text);
                        t3 = t1 / t2 * 100.0;
                       
                    }
                    catch {; }
                }
                
            }*/
            process.WaitForExit();


            process.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            progressBar1.Value = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].BackColor = Color.White;
            }

            progressBar1.Maximum = listView1.Items.Count;
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("No Selected Image");
                return;
            }

            if (T_Save_Path.Text == "")
            {
                MessageBox.Show("No Selected save path");
                return;
            }

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (is_stop)
                {
                    is_stop = false;
                    break;
                }
                T_Work_file.Text = listView1.Items[i].Text;
                progressBar1.Value = i + 1;
                T_dwemp = new Thread(dwebp_thread);
                T_dwemp.Start();
                T_dwemp.Join();
                listView1.Items[i].BackColor = Color.Aquamarine;
            }
            MessageBox.Show("clear");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int i;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    listView1.Items.Add(openFileDialog1.FileNames[i]);
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                T_Save_Path.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            is_stop = true;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}
