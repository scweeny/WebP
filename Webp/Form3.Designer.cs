namespace Webp
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.T_Work_file = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.T_Save_Path = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label7 = new System.Windows.Forms.Label();
            this.CB_Lossless = new System.Windows.Forms.CheckBox();
            this.CB_Metadata = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CB_Preset = new System.Windows.Forms.ComboBox();
            this.Num_COMP = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Num_QF = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.CB_Exact = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_COMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_QF)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.progressBar1);
            this.splitContainer1.Size = new System.Drawing.Size(763, 485);
            this.splitContainer1.SplitterDistance = 456;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.T_Work_file);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.button5);
            this.splitContainer2.Panel1.Controls.Add(this.button4);
            this.splitContainer2.Panel1.Controls.Add(this.button2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.button3);
            this.splitContainer2.Panel1.Controls.Add(this.T_Save_Path);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label8);
            this.splitContainer2.Panel2.Controls.Add(this.CB_Exact);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.CB_Lossless);
            this.splitContainer2.Panel2.Controls.Add(this.CB_Metadata);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.CB_Preset);
            this.splitContainer2.Panel2.Controls.Add(this.Num_COMP);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.Num_QF);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(763, 456);
            this.splitContainer2.SplitterDistance = 573;
            this.splitContainer2.TabIndex = 0;
            // 
            // T_Work_file
            // 
            this.T_Work_file.Location = new System.Drawing.Point(65, 337);
            this.T_Work_file.Name = "T_Work_file";
            this.T_Work_file.ReadOnly = true;
            this.T_Work_file.Size = new System.Drawing.Size(484, 21);
            this.T_Work_file.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = "Working";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(87, 364);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 26);
            this.button5.TabIndex = 26;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 364);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 27);
            this.button4.TabIndex = 25;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(398, 364);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 27);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "Save Path";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(448, 411);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 20);
            this.button3.TabIndex = 22;
            this.button3.Text = "Select";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // T_Save_Path
            // 
            this.T_Save_Path.Location = new System.Drawing.Point(100, 411);
            this.T_Save_Path.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.T_Save_Path.Name = "T_Save_Path";
            this.T_Save_Path.Size = new System.Drawing.Size(333, 21);
            this.T_Save_Path.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 364);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 27);
            this.button1.TabIndex = 20;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 11);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(537, 317);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "Lossless";
            // 
            // CB_Lossless
            // 
            this.CB_Lossless.AutoSize = true;
            this.CB_Lossless.Location = new System.Drawing.Point(95, 222);
            this.CB_Lossless.Name = "CB_Lossless";
            this.CB_Lossless.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CB_Lossless.Size = new System.Drawing.Size(15, 14);
            this.CB_Lossless.TabIndex = 8;
            this.CB_Lossless.UseVisualStyleBackColor = true;
            this.CB_Lossless.CheckedChanged += new System.EventHandler(this.CB_Lossless_CheckedChanged);
            // 
            // CB_Metadata
            // 
            this.CB_Metadata.FormattingEnabled = true;
            this.CB_Metadata.Items.AddRange(new object[] {
            "all",
            "none",
            "exif",
            "icc",
            "xmp"});
            this.CB_Metadata.Location = new System.Drawing.Point(95, 180);
            this.CB_Metadata.Name = "CB_Metadata";
            this.CB_Metadata.Size = new System.Drawing.Size(77, 20);
            this.CB_Metadata.TabIndex = 7;
            this.CB_Metadata.Text = "None";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "Metadata";
            // 
            // CB_Preset
            // 
            this.CB_Preset.FormattingEnabled = true;
            this.CB_Preset.Items.AddRange(new object[] {
            "default",
            "photo",
            "picture",
            "drawing",
            "icon",
            "text"});
            this.CB_Preset.Location = new System.Drawing.Point(95, 136);
            this.CB_Preset.Name = "CB_Preset";
            this.CB_Preset.Size = new System.Drawing.Size(77, 20);
            this.CB_Preset.TabIndex = 5;
            this.CB_Preset.Text = "Default";
            // 
            // Num_COMP
            // 
            this.Num_COMP.Location = new System.Drawing.Point(95, 92);
            this.Num_COMP.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.Num_COMP.Name = "Num_COMP";
            this.Num_COMP.Size = new System.Drawing.Size(77, 21);
            this.Num_COMP.TabIndex = 4;
            this.Num_COMP.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Compression";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Preset";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quality Factor";
            // 
            // Num_QF
            // 
            this.Num_QF.Location = new System.Drawing.Point(95, 42);
            this.Num_QF.Name = "Num_QF";
            this.Num_QF.Size = new System.Drawing.Size(77, 21);
            this.Num_QF.TabIndex = 0;
            this.Num_QF.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(763, 25);
            this.progressBar1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "JPG|*.jpg|JPEG|*.jpeg|PNG|*.png|TIFF|*.tiff";
            this.openFileDialog1.Multiselect = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "Exact";
            // 
            // CB_Exact
            // 
            this.CB_Exact.AutoSize = true;
            this.CB_Exact.Enabled = false;
            this.CB_Exact.Location = new System.Drawing.Point(95, 250);
            this.CB_Exact.Name = "CB_Exact";
            this.CB_Exact.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CB_Exact.Size = new System.Drawing.Size(15, 14);
            this.CB_Exact.TabIndex = 10;
            this.CB_Exact.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 485);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image -> Webp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Num_COMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_QF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox T_Work_file;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox T_Save_Path;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox CB_Metadata;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CB_Preset;
        private System.Windows.Forms.NumericUpDown Num_COMP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Num_QF;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox CB_Lossless;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox CB_Exact;
    }
}