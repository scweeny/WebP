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
        delegate void SetTextListviewCallback(int i);
        string command="";

        string lvitems;
        string cbp;
        string cbm;
        bool cblossless;
        string numqf;
        string numcomp;
        string savepath;
        bool cbexact;

        int now_index =0;
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

        void onSetlistviewText(int i)
        {
            if (this.InvokeRequired)
            {
                SetTextListviewCallback a = new SetTextListviewCallback(onSetlistviewText);
                this.Invoke(a, new object[] { i });
            }
            else
            {
                lvitems = listView1.Items[now_index].Text;
                T_Work_file.Text = lvitems;
            }
        }
      
       

        int cwebp_thread()
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
            return 0;
        }
        private void Complete(object sender, EventArgs e)
        {
            OnSetlistviewColor(now_index, Color.Aquamarine);
            
            now_index++;

            if(now_index < listView1.Items.Count)
            {
                onSetlistviewText(now_index);//lvitems = listView1.Items[now_index].Text;
                                             //T_Work_file.Text = lvitems;
                T_Start = new Thread(start_thread);
                T_Start.Start();
            }
            else
                MessageBox.Show("clear");
        }
        void start_thread()
        {
            if (is_stop)
            {
                is_stop = false;
                return ;
            }
           


            command = "-preset " + cbp;

            command = command + " -metadata " + cbm;


            if (cblossless)
            {
                command = command + " -lossless";
                if (cbexact)
                    command = command + " -exact";
            }
            else
            {
                command = command + " -q " + numqf;
                command = command + " -m " + numcomp;
            }
            command = command + " \"" + lvitems + "\"";



            String[] spstring = lvitems.Split('\\');


            command = command + " -o " + "\"" + savepath + @"\" + spstring[spstring.Length - 1] + ".webp" + "\"";


            OnSetProgressEvent(now_index + 1);//progressBar1.Value = i + 1;

            ThreadWorker worker = new ThreadWorker();
            worker.Process = cwebp_thread;
            worker.OnCompleted += new EventHandler(Complete);

            T_cwemp = new Thread(worker.Run);
            T_cwemp.Start();
            //T_cwemp.Join();
           // OnSetlistviewColor(now_index, Color.Aquamarine);// listView1.Items[i].BackColor = Color.Aquamarine;

           
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
            now_index = 0;

            lvitems = listView1.Items[0].Text;
            cbp = CB_Preset.Text;
            cbm = CB_Metadata.Text;
            cblossless = CB_Lossless.Checked;
            numqf = Num_QF.Value.ToString();
            numcomp = Num_COMP.Value.ToString();
            T_Work_file.Text = lvitems;
            savepath = T_Save_Path.Text;
            cbexact = CB_Exact.Checked;

            T_Start = new Thread(start_thread);
            T_Start.Start();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            is_stop = true;
        }

        private void CB_Lossless_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Lossless.Checked)
            {
                Num_QF.Enabled = false;
                Num_COMP.Enabled = false;
                CB_Exact.Enabled = true;
            }
            else
            {
                Num_QF.Enabled = true;
                Num_COMP.Enabled = true;
                CB_Exact.Enabled = false;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                T_Save_Path.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
    class ThreadWorker
    {
        public Func<int> Process { get; set; } // 실제 스레드가 작업할 메소드 명
        public event EventHandler OnCompleted; // 작업할 내용르

        public void Run()
        {
            Process();

            if (OnCompleted != null)
                OnCompleted(this, EventArgs.Empty);
        }
    }
}
