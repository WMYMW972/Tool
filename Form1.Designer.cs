namespace tool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.image = new System.Windows.Forms.Button();
            this.redio = new System.Windows.Forms.Button();
            this.video = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.index = new System.Windows.Forms.Panel();
            this.music_dw_index = new System.Windows.Forms.Button();
            this.resolve_B = new System.Windows.Forms.Button();
            this.imge = new System.Windows.Forms.Panel();
            this.ima_1 = new System.Windows.Forms.Button();
            this.del_ima = new System.Windows.Forms.Button();
            this.ima_2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.OpenFile = new System.Windows.Forms.Button();
            this.label_ima = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.radio = new System.Windows.Forms.Panel();
            this.del_ra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ra_1 = new System.Windows.Forms.Button();
            this.ra_2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.OF_ra = new System.Windows.Forms.Button();
            this.label_ra = new System.Windows.Forms.Label();
            this.video_P = new System.Windows.Forms.Panel();
            this.del_vid = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.vid_label = new System.Windows.Forms.Label();
            this.vid_bu2 = new System.Windows.Forms.Button();
            this.vid_bu1 = new System.Windows.Forms.Button();
            this.vid_bu = new System.Windows.Forms.Button();
            this.resolve = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.res_dwn = new System.Windows.Forms.Button();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.res_del_button = new System.Windows.Forms.Button();
            this.res_button = new System.Windows.Forms.Button();
            this.res = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.music_dw = new System.Windows.Forms.Panel();
            this.sousuo = new System.Windows.Forms.Button();
            this.m_dw_b = new System.Windows.Forms.Button();
            this.m_B_index = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.index.SuspendLayout();
            this.imge.SuspendLayout();
            this.radio.SuspendLayout();
            this.video_P.SuspendLayout();
            this.resolve.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.music_dw.SuspendLayout();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.image.Location = new System.Drawing.Point(119, 182);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(80, 34);
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            this.image.Text = "图片";
            this.image.UseVisualStyleBackColor = true;
            this.image.Click += new System.EventHandler(this.image_Click);
            // 
            // redio
            // 
            this.redio.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.redio.Location = new System.Drawing.Point(259, 182);
            this.redio.Name = "redio";
            this.redio.Size = new System.Drawing.Size(80, 34);
            this.redio.TabIndex = 1;
            this.redio.TabStop = false;
            this.redio.Text = "音频";
            this.redio.UseVisualStyleBackColor = true;
            this.redio.Click += new System.EventHandler(this.redio_Click);
            // 
            // video
            // 
            this.video.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.video.Location = new System.Drawing.Point(399, 182);
            this.video.Name = "video";
            this.video.Size = new System.Drawing.Size(80, 34);
            this.video.TabIndex = 2;
            this.video.TabStop = false;
            this.video.Text = "视频";
            this.video.UseVisualStyleBackColor = true;
            this.video.Click += new System.EventHandler(this.video_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(226, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "选择功能";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // index
            // 
            this.index.Controls.Add(this.music_dw_index);
            this.index.Controls.Add(this.resolve_B);
            this.index.Controls.Add(this.image);
            this.index.Controls.Add(this.redio);
            this.index.Controls.Add(this.video);
            this.index.Controls.Add(this.label1);
            this.index.Location = new System.Drawing.Point(3, 3);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(617, 439);
            this.index.TabIndex = 4;
            this.index.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // music_dw_index
            // 
            this.music_dw_index.Font = new System.Drawing.Font("宋体", 18F);
            this.music_dw_index.Location = new System.Drawing.Point(232, 298);
            this.music_dw_index.Name = "music_dw_index";
            this.music_dw_index.Size = new System.Drawing.Size(131, 34);
            this.music_dw_index.TabIndex = 5;
            this.music_dw_index.TabStop = false;
            this.music_dw_index.Text = "音乐下载";
            this.music_dw_index.UseVisualStyleBackColor = true;
            this.music_dw_index.Click += new System.EventHandler(this.music_dw_index_Click);
            // 
            // resolve_B
            // 
            this.resolve_B.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.resolve_B.Location = new System.Drawing.Point(261, 240);
            this.resolve_B.Name = "resolve_B";
            this.resolve_B.Size = new System.Drawing.Size(80, 34);
            this.resolve_B.TabIndex = 4;
            this.resolve_B.TabStop = false;
            this.resolve_B.Text = "解析";
            this.resolve_B.UseVisualStyleBackColor = true;
            this.resolve_B.Click += new System.EventHandler(this.resolve_B_Click);
            // 
            // imge
            // 
            this.imge.Controls.Add(this.ima_1);
            this.imge.Controls.Add(this.del_ima);
            this.imge.Controls.Add(this.ima_2);
            this.imge.Controls.Add(this.comboBox1);
            this.imge.Controls.Add(this.listBox2);
            this.imge.Controls.Add(this.OpenFile);
            this.imge.Controls.Add(this.label_ima);
            this.imge.Location = new System.Drawing.Point(0, 0);
            this.imge.Name = "imge";
            this.imge.Size = new System.Drawing.Size(623, 439);
            this.imge.TabIndex = 4;
            this.imge.Visible = false;
            // 
            // ima_1
            // 
            this.ima_1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ima_1.Location = new System.Drawing.Point(75, 79);
            this.ima_1.Name = "ima_1";
            this.ima_1.Size = new System.Drawing.Size(75, 38);
            this.ima_1.TabIndex = 7;
            this.ima_1.TabStop = false;
            this.ima_1.Text = "返回";
            this.ima_1.UseVisualStyleBackColor = true;
            this.ima_1.Click += new System.EventHandler(this.button2_Click);
            // 
            // del_ima
            // 
            this.del_ima.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.del_ima.Location = new System.Drawing.Point(75, 257);
            this.del_ima.Name = "del_ima";
            this.del_ima.Size = new System.Drawing.Size(96, 34);
            this.del_ima.TabIndex = 10;
            this.del_ima.Text = "取消选择";
            this.del_ima.UseVisualStyleBackColor = true;
            this.del_ima.Click += new System.EventHandler(this.del_ima_Click);
            // 
            // ima_2
            // 
            this.ima_2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ima_2.Location = new System.Drawing.Point(466, 254);
            this.ima_2.Name = "ima_2";
            this.ima_2.Size = new System.Drawing.Size(90, 37);
            this.ima_2.TabIndex = 6;
            this.ima_2.TabStop = false;
            this.ima_2.Text = "转换";
            this.ima_2.UseVisualStyleBackColor = true;
            this.ima_2.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "JPG",
            "PNG",
            "BMP",
            "GIF",
            "TIFF",
            "WEBP"});
            this.comboBox1.Location = new System.Drawing.Point(466, 189);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 29);
            this.comboBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 19;
            this.listBox2.Location = new System.Drawing.Point(214, 189);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(207, 194);
            this.listBox2.TabIndex = 3;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // OpenFile
            // 
            this.OpenFile.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenFile.Location = new System.Drawing.Point(75, 189);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(96, 34);
            this.OpenFile.TabIndex = 2;
            this.OpenFile.TabStop = false;
            this.OpenFile.Text = "选择文件";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // label_ima
            // 
            this.label_ima.AutoSize = true;
            this.label_ima.Font = new System.Drawing.Font("宋体", 26F);
            this.label_ima.Location = new System.Drawing.Point(208, 62);
            this.label_ima.Name = "label_ima";
            this.label_ima.Size = new System.Drawing.Size(225, 35);
            this.label_ima.TabIndex = 0;
            this.label_ima.Text = "图片格式转换";
            this.label_ima.Click += new System.EventHandler(this.label2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // radio
            // 
            this.radio.Controls.Add(this.del_ra);
            this.radio.Controls.Add(this.label2);
            this.radio.Controls.Add(this.ra_1);
            this.radio.Controls.Add(this.ra_2);
            this.radio.Controls.Add(this.comboBox2);
            this.radio.Controls.Add(this.listBox1);
            this.radio.Controls.Add(this.OF_ra);
            this.radio.Controls.Add(this.label_ra);
            this.radio.Location = new System.Drawing.Point(0, 0);
            this.radio.Name = "radio";
            this.radio.Size = new System.Drawing.Size(623, 439);
            this.radio.TabIndex = 4;
            this.radio.Visible = false;
            this.radio.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // del_ra
            // 
            this.del_ra.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.del_ra.Location = new System.Drawing.Point(75, 257);
            this.del_ra.Name = "del_ra";
            this.del_ra.Size = new System.Drawing.Size(96, 34);
            this.del_ra.TabIndex = 11;
            this.del_ra.Text = "取消选择";
            this.del_ra.UseVisualStyleBackColor = true;
            this.del_ra.Click += new System.EventHandler(this.del_ra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(201, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "(NCM可转为其他格式，不能互转)";
            // 
            // ra_1
            // 
            this.ra_1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ra_1.Location = new System.Drawing.Point(466, 254);
            this.ra_1.Name = "ra_1";
            this.ra_1.Size = new System.Drawing.Size(90, 37);
            this.ra_1.TabIndex = 8;
            this.ra_1.TabStop = false;
            this.ra_1.Text = "转换";
            this.ra_1.UseVisualStyleBackColor = true;
            this.ra_1.Click += new System.EventHandler(this.ra_1_Click);
            // 
            // ra_2
            // 
            this.ra_2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ra_2.Location = new System.Drawing.Point(75, 79);
            this.ra_2.Name = "ra_2";
            this.ra_2.Size = new System.Drawing.Size(75, 38);
            this.ra_2.TabIndex = 8;
            this.ra_2.TabStop = false;
            this.ra_2.Text = "返回";
            this.ra_2.UseVisualStyleBackColor = true;
            this.ra_2.Click += new System.EventHandler(this.ra_2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "MP3",
            "AAC",
            "FLAC",
            "WAV",
            "M4A",
            "OGG",
            "WMA",
            "Opus",
            "AMR",
            "AC3",
            "DTS"});
            this.comboBox2.Location = new System.Drawing.Point(466, 189);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(90, 29);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.TabStop = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(214, 189);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(207, 194);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_2);
            // 
            // OF_ra
            // 
            this.OF_ra.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OF_ra.Location = new System.Drawing.Point(75, 189);
            this.OF_ra.Name = "OF_ra";
            this.OF_ra.Size = new System.Drawing.Size(96, 34);
            this.OF_ra.TabIndex = 8;
            this.OF_ra.TabStop = false;
            this.OF_ra.Text = "选择文件";
            this.OF_ra.UseVisualStyleBackColor = true;
            this.OF_ra.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label_ra
            // 
            this.label_ra.AutoSize = true;
            this.label_ra.Font = new System.Drawing.Font("宋体", 26F);
            this.label_ra.Location = new System.Drawing.Point(208, 56);
            this.label_ra.Name = "label_ra";
            this.label_ra.Size = new System.Drawing.Size(225, 35);
            this.label_ra.TabIndex = 8;
            this.label_ra.Text = "音频格式转换";
            // 
            // video_P
            // 
            this.video_P.Controls.Add(this.del_vid);
            this.video_P.Controls.Add(this.listBox3);
            this.video_P.Controls.Add(this.comboBox3);
            this.video_P.Controls.Add(this.vid_label);
            this.video_P.Controls.Add(this.vid_bu2);
            this.video_P.Controls.Add(this.vid_bu1);
            this.video_P.Controls.Add(this.vid_bu);
            this.video_P.Location = new System.Drawing.Point(0, 0);
            this.video_P.Name = "video_P";
            this.video_P.Size = new System.Drawing.Size(626, 442);
            this.video_P.TabIndex = 4;
            this.video_P.Visible = false;
            this.video_P.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // del_vid
            // 
            this.del_vid.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.del_vid.Location = new System.Drawing.Point(75, 257);
            this.del_vid.Name = "del_vid";
            this.del_vid.Size = new System.Drawing.Size(96, 34);
            this.del_vid.TabIndex = 9;
            this.del_vid.Text = "取消选择";
            this.del_vid.UseVisualStyleBackColor = true;
            this.del_vid.Click += new System.EventHandler(this.del_vid_Click);
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.HorizontalScrollbar = true;
            this.listBox3.ItemHeight = 19;
            this.listBox3.Location = new System.Drawing.Point(214, 189);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(207, 194);
            this.listBox3.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "MP4",
            "AVI",
            "MKV",
            "MOV",
            "WebM",
            "FLV",
            "WMV",
            "M4V",
            "TS",
            "MTS",
            "3GP",
            "OGV"});
            this.comboBox3.Location = new System.Drawing.Point(466, 189);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(90, 29);
            this.comboBox3.TabIndex = 8;
            // 
            // vid_label
            // 
            this.vid_label.AutoSize = true;
            this.vid_label.Font = new System.Drawing.Font("宋体", 26F);
            this.vid_label.Location = new System.Drawing.Point(208, 62);
            this.vid_label.Name = "vid_label";
            this.vid_label.Size = new System.Drawing.Size(225, 35);
            this.vid_label.TabIndex = 8;
            this.vid_label.Text = "视频格式转换";
            // 
            // vid_bu2
            // 
            this.vid_bu2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vid_bu2.Location = new System.Drawing.Point(466, 254);
            this.vid_bu2.Name = "vid_bu2";
            this.vid_bu2.Size = new System.Drawing.Size(90, 37);
            this.vid_bu2.TabIndex = 2;
            this.vid_bu2.Text = "转换";
            this.vid_bu2.UseVisualStyleBackColor = true;
            this.vid_bu2.Click += new System.EventHandler(this.vid_bu2_Click);
            // 
            // vid_bu1
            // 
            this.vid_bu1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vid_bu1.Location = new System.Drawing.Point(75, 189);
            this.vid_bu1.Name = "vid_bu1";
            this.vid_bu1.Size = new System.Drawing.Size(96, 34);
            this.vid_bu1.TabIndex = 1;
            this.vid_bu1.Text = "选择文件";
            this.vid_bu1.UseVisualStyleBackColor = true;
            this.vid_bu1.Click += new System.EventHandler(this.vid_bu1_Click);
            // 
            // vid_bu
            // 
            this.vid_bu.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vid_bu.Location = new System.Drawing.Point(75, 79);
            this.vid_bu.Name = "vid_bu";
            this.vid_bu.Size = new System.Drawing.Size(75, 38);
            this.vid_bu.TabIndex = 0;
            this.vid_bu.Text = "返回";
            this.vid_bu.UseVisualStyleBackColor = true;
            this.vid_bu.Click += new System.EventHandler(this.vid_bu_Click);
            // 
            // resolve
            // 
            this.resolve.Controls.Add(this.label6);
            this.resolve.Controls.Add(this.label5);
            this.resolve.Controls.Add(this.checkedListBox1);
            this.resolve.Controls.Add(this.res_dwn);
            this.resolve.Controls.Add(this.comboBox5);
            this.resolve.Controls.Add(this.label4);
            this.resolve.Controls.Add(this.pictureBox1);
            this.resolve.Controls.Add(this.checkBox1);
            this.resolve.Controls.Add(this.res_del_button);
            this.resolve.Controls.Add(this.res_button);
            this.resolve.Controls.Add(this.res);
            this.resolve.Controls.Add(this.label3);
            this.resolve.Location = new System.Drawing.Point(0, 0);
            this.resolve.Name = "resolve";
            this.resolve.Size = new System.Drawing.Size(626, 442);
            this.resolve.TabIndex = 5;
            this.resolve.Visible = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(36, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(563, 41);
            this.label6.TabIndex = 21;
            this.label6.Text = "注:在使用音轨视频分开功能时建议选中单个视频再进行操作。不建议在同时选中2个以上视频时使用音轨与视频分开功能，虽然在测试中运行正常，但该功能未经过严格的压力测试，" +
    "这可能会导致不可预料的BUG\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 18F);
            this.label5.Location = new System.Drawing.Point(68, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 20;
            this.label5.Text = "视频标题:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(156, 266);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(318, 148);
            this.checkedListBox1.TabIndex = 19;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // res_dwn
            // 
            this.res_dwn.Font = new System.Drawing.Font("宋体", 18F);
            this.res_dwn.Location = new System.Drawing.Point(480, 266);
            this.res_dwn.Name = "res_dwn";
            this.res_dwn.Size = new System.Drawing.Size(132, 37);
            this.res_dwn.TabIndex = 18;
            this.res_dwn.Text = "下载";
            this.res_dwn.UseVisualStyleBackColor = true;
            this.res_dwn.Click += new System.EventHandler(this.res_dwn_Click);
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.Font = new System.Drawing.Font("宋体", 9F);
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(480, 309);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(132, 20);
            this.comboBox5.TabIndex = 17;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.label4.Location = new System.Drawing.Point(188, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(429, 36);
            this.label4.TabIndex = 15;
            this.label4.Text = "视频标题";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(485, 198);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 16);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "音轨与视频分开生成";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // res_del_button
            // 
            this.res_del_button.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.res_del_button.Location = new System.Drawing.Point(39, 147);
            this.res_del_button.Name = "res_del_button";
            this.res_del_button.Size = new System.Drawing.Size(75, 37);
            this.res_del_button.TabIndex = 11;
            this.res_del_button.TabStop = false;
            this.res_del_button.Text = "返回";
            this.res_del_button.UseVisualStyleBackColor = true;
            this.res_del_button.Click += new System.EventHandler(this.res_del_button_Click);
            // 
            // res_button
            // 
            this.res_button.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.res_button.Location = new System.Drawing.Point(522, 147);
            this.res_button.Name = "res_button";
            this.res_button.Size = new System.Drawing.Size(90, 37);
            this.res_button.TabIndex = 2;
            this.res_button.Text = "解析";
            this.res_button.UseVisualStyleBackColor = true;
            this.res_button.Click += new System.EventHandler(this.res_button_Click);
            // 
            // res
            // 
            this.res.Font = new System.Drawing.Font("宋体", 10F);
            this.res.Location = new System.Drawing.Point(131, 155);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(372, 23);
            this.res.TabIndex = 1;
            this.res.TabStop = false;
            this.res.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 26F);
            this.label3.Location = new System.Drawing.Point(241, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "视频解析";
            // 
            // music_dw
            // 
            this.music_dw.Controls.Add(this.sousuo);
            this.music_dw.Controls.Add(this.m_dw_b);
            this.music_dw.Controls.Add(this.m_B_index);
            this.music_dw.Controls.Add(this.listBox4);
            this.music_dw.Controls.Add(this.textBox1);
            this.music_dw.Controls.Add(this.label7);
            this.music_dw.Location = new System.Drawing.Point(0, 0);
            this.music_dw.Name = "music_dw";
            this.music_dw.Size = new System.Drawing.Size(626, 442);
            this.music_dw.TabIndex = 5;
            this.music_dw.Paint += new System.Windows.Forms.PaintEventHandler(this.music_dw_Paint);
            // 
            // sousuo
            // 
            this.sousuo.Font = new System.Drawing.Font("宋体", 18F);
            this.sousuo.Location = new System.Drawing.Point(498, 99);
            this.sousuo.Name = "sousuo";
            this.sousuo.Size = new System.Drawing.Size(80, 34);
            this.sousuo.TabIndex = 10;
            this.sousuo.Text = "搜索";
            this.sousuo.UseVisualStyleBackColor = true;
            this.sousuo.Click += new System.EventHandler(this.sousuo_Click);
            // 
            // m_dw_b
            // 
            this.m_dw_b.Font = new System.Drawing.Font("宋体", 18F);
            this.m_dw_b.Location = new System.Drawing.Point(498, 139);
            this.m_dw_b.Name = "m_dw_b";
            this.m_dw_b.Size = new System.Drawing.Size(80, 34);
            this.m_dw_b.TabIndex = 9;
            this.m_dw_b.Text = "下载";
            this.m_dw_b.UseVisualStyleBackColor = true;
            this.m_dw_b.Click += new System.EventHandler(this.m_dw_b_Click);
            // 
            // m_B_index
            // 
            this.m_B_index.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_B_index.Location = new System.Drawing.Point(64, 117);
            this.m_B_index.Name = "m_B_index";
            this.m_B_index.Size = new System.Drawing.Size(75, 38);
            this.m_B_index.TabIndex = 8;
            this.m_B_index.TabStop = false;
            this.m_B_index.Text = "返回";
            this.m_B_index.UseVisualStyleBackColor = true;
            this.m_B_index.Click += new System.EventHandler(this.m_B_index_Click);
            // 
            // listBox4
            // 
            this.listBox4.Font = new System.Drawing.Font("宋体", 10F);
            this.listBox4.FormattingEnabled = true;
            this.listBox4.HorizontalScrollbar = true;
            this.listBox4.Location = new System.Drawing.Point(64, 179);
            this.listBox4.Name = "listBox4";
            this.listBox4.ScrollAlwaysVisible = true;
            this.listBox4.Size = new System.Drawing.Size(514, 238);
            this.listBox4.TabIndex = 4;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 18F);
            this.textBox1.Location = new System.Drawing.Point(177, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 35);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 18F);
            this.label7.Location = new System.Drawing.Point(269, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "音乐下载";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.music_dw);
            this.Controls.Add(this.index);
            this.Controls.Add(this.imge);
            this.Controls.Add(this.radio);
            this.Controls.Add(this.video_P);
            this.Controls.Add(this.resolve);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.index.ResumeLayout(false);
            this.index.PerformLayout();
            this.imge.ResumeLayout(false);
            this.imge.PerformLayout();
            this.radio.ResumeLayout(false);
            this.radio.PerformLayout();
            this.video_P.ResumeLayout(false);
            this.video_P.PerformLayout();
            this.resolve.ResumeLayout(false);
            this.resolve.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.music_dw.ResumeLayout(false);
            this.music_dw.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button image;
        private System.Windows.Forms.Button redio;
        private System.Windows.Forms.Button video;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel index;
        private System.Windows.Forms.Panel imge;
        private System.Windows.Forms.Label label_ima;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ima_2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button ima_1;
        private System.Windows.Forms.Panel radio;
        private System.Windows.Forms.Button ra_1;
        private System.Windows.Forms.Button ra_2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label_ra;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button OF_ra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel video_P;
        private System.Windows.Forms.Button vid_bu1;
        private System.Windows.Forms.Button vid_bu;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label vid_label;
        private System.Windows.Forms.Button vid_bu2;
        private System.Windows.Forms.Button del_ima;
        private System.Windows.Forms.Button del_ra;
        private System.Windows.Forms.Button del_vid;
        private System.Windows.Forms.Button resolve_B;
        private System.Windows.Forms.Panel resolve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button res_button;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.Button res_del_button;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button res_dwn;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel music_dw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Button music_dw_index;
        private System.Windows.Forms.Button m_B_index;
        private System.Windows.Forms.Button m_dw_b;
        private System.Windows.Forms.Button sousuo;
    }
}

