using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Webp
{
    public partial class Form3 : Form
    {
        Process process = new Process();
        Form1 f1;
        private Thread T_cwemp, T_Start;
        delegate void SetProgressCallback(int d);
        delegate void SetMaxProgressCallback(int d);
        delegate void SetColorListviewCallback(int i, Color d);
        string command="";
        bool is_stop = false;
        public Form3(Form1 form)
        {
            InitializeComponent();
            f1 = form;
        }
        
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1.Visible = true;
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

        }
        void OnSetProgressEvent(int d)
        {
            if (this.InvokeRequired)
            {
                SetProgressCallback a = new SetProgressCallback(OnSetProgressEvent);
                this.Invoke(a, new object[] { d });
            }
            else
            {
                this.progressBar1.Value = d;
            }
        }
        void OnSetMaxProgressEvent(int d)
        {
            if (this.InvokeRequired)
            {
                SetMaxProgressCallback a = new SetMaxProgressCallback(OnSetMaxProgressEvent);
                this.Invoke(a, new object[] { d });
            }
            else
            {
                this.progressBar1.Maximum = d;
            }
        }

        void OnSetlistviewColor(int i, Color d)
        {
            if (this.InvokeRequired)
            {
                SetColorListviewCallback a = new SetColorListviewCallback(OnSetlistviewColor);
                this.Invoke(a, new object[] { i,d });
            }
            else
            {
                listView1.Items[i].BackColor = d;
            }
            
        }
       

        void cwebp_thread()
        {
           
            ProcessStartInfo cmd = new ProcessStartInfo();

            cmd.WindowStyle = ProcessWindowStyle.Hidden;             // cmd창이 숨겨지도록 하기
            cmd.CreateNoWindow = true;                               // cmd창을 띄우지 안도록 하기

            cmd.UseShellExecute = false;
            cmd.RedirectStandardOutput = true;        // cmd창에서 데이터를 가져오기
            cmd.RedirectStandardInput = true;          // cmd창으로 데이터 보내기
            cmd.RedirectStandardError = true;          // cmd창에서 오류 내용 가져오기



            

            cmd.FileName = @"binary\cwebp.exe";
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
            OnSetProgressEvent(0);//progressBar1.Value = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                OnSetlistviewColor(i, Color.White);//listView1.Items[i].BackColor = Color.White;
            }

            OnSetMaxProgressEvent(listView1.Items.Count);//progressBar1.Maximum = listView1.Items.Count;
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


                command = "-preset " + CB_Preset.Text;

                command = command + " -metadata " + CB_Metadata.Text;

                command = command + " -q " + Num_QF.Value.ToString();
                command = command + " -m " + Num_COMP.Value.ToString();
                command = command + " \"" + T_Work_file.Text + "\"";



                String[] spstring = T_Work_file.Text.Split('\\');


                command = command + " -o " + "\"" + T_Save_Path.Text + @"\" + spstring[spstring.Length - 1] + ".webp" + "\"";


                OnSetProgressEvent(i + 1);//progressBar1.Value = i + 1;
                T_cwemp = new Thread(cwebp_thread);
                T_cwemp.Start();
                T_cwemp.Join();
                OnSetlistviewColor(i, Color.Aquamarine);// listView1.Items[i].BackColor = Color.Aquamarine;
            }
            MessageBox.Show("clear");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            is_stop = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                T_Save_Path.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
