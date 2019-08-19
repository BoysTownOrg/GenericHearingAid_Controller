namespace GenericHearingAid_Controller
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDSLPrescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAFCFilterLength = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRHO = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMU = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEPS = new System.Windows.Forms.TextBox();
            this.AFCcomboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Plotbutton = new System.Windows.Forms.Button();
            this.Loadbutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Uploadbutton = new System.Windows.Forms.Button();
            this.Directorybutton = new System.Windows.Forms.Button();
            this.txtWorkingDirectory = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChunkSize = new System.Windows.Forms.TextBox();
            this.txtMaxdB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numUDchannels = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRelease = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAttack = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dGV = new System.Windows.Forms.DataGridView();
            this.CrossFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TKgain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bolt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zedGC = new ZedGraph.ZedGraphControl();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDchannels)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Cornsilk;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(781, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.plotToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.UploadToolStripMenuItem,
            this.loadDSLPrescriptionToolStripMenuItem,
            this.clearAllToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // plotToolStripMenuItem
            // 
            this.plotToolStripMenuItem.Name = "plotToolStripMenuItem";
            this.plotToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.plotToolStripMenuItem.Text = "Plot";
            this.plotToolStripMenuItem.Click += new System.EventHandler(this.plotToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // UploadToolStripMenuItem
            // 
            this.UploadToolStripMenuItem.Name = "UploadToolStripMenuItem";
            this.UploadToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.UploadToolStripMenuItem.Text = "Upload";
            this.UploadToolStripMenuItem.Click += new System.EventHandler(this.UploadToolStripMenuItem_Click);
            // 
            // loadDSLPrescriptionToolStripMenuItem
            // 
            this.loadDSLPrescriptionToolStripMenuItem.Name = "loadDSLPrescriptionToolStripMenuItem";
            this.loadDSLPrescriptionToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.loadDSLPrescriptionToolStripMenuItem.Text = "Load DSL Prescription";
            this.loadDSLPrescriptionToolStripMenuItem.Click += new System.EventHandler(this.loadDSLPrescriptionToolStripMenuItem_Click);
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.clearAllToolStripMenuItem.Text = "Clear all";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.helpToolStripMenuItem.Text = "About";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 792);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(781, 22);
            this.statusStrip1.TabIndex = 4;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.Directorybutton);
            this.splitContainer1.Panel1.Controls.Add(this.txtWorkingDirectory);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtChunkSize);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaxdB);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.numUDchannels);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtRelease);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtAttack);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(781, 768);
            this.splitContainer1.SplitterDistance = 292;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtAFCFilterLength);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtRHO);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMU);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEPS);
            this.groupBox1.Controls.Add(this.AFCcomboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(19, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 165);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adaptive Feedback Cancellation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 51);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 49;
            this.label11.Text = "Adaptive Filter Length:";
            // 
            // txtAFCFilterLength
            // 
            this.txtAFCFilterLength.Location = new System.Drawing.Point(185, 48);
            this.txtAFCFilterLength.Margin = new System.Windows.Forms.Padding(2);
            this.txtAFCFilterLength.Name = "txtAFCFilterLength";
            this.txtAFCFilterLength.Size = new System.Drawing.Size(41, 20);
            this.txtAFCFilterLength.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 124);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Forgetting Factor (rho):";
            // 
            // txtRHO
            // 
            this.txtRHO.Location = new System.Drawing.Point(185, 121);
            this.txtRHO.Margin = new System.Windows.Forms.Padding(2);
            this.txtRHO.Name = "txtRHO";
            this.txtRHO.Size = new System.Drawing.Size(41, 20);
            this.txtRHO.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 99);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Step Size (mu):";
            // 
            // txtMU
            // 
            this.txtMU.Location = new System.Drawing.Point(185, 96);
            this.txtMU.Margin = new System.Windows.Forms.Padding(2);
            this.txtMU.Name = "txtMU";
            this.txtMU.Size = new System.Drawing.Size(41, 20);
            this.txtMU.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Power Threshold (eps):";
            // 
            // txtEPS
            // 
            this.txtEPS.Location = new System.Drawing.Point(185, 72);
            this.txtEPS.Margin = new System.Windows.Forms.Padding(2);
            this.txtEPS.Name = "txtEPS";
            this.txtEPS.Size = new System.Drawing.Size(41, 20);
            this.txtEPS.TabIndex = 1;
            // 
            // AFCcomboBox
            // 
            this.AFCcomboBox.FormattingEnabled = true;
            this.AFCcomboBox.Items.AddRange(new object[] {
            "On",
            "Off"});
            this.AFCcomboBox.Location = new System.Drawing.Point(185, 22);
            this.AFCcomboBox.Name = "AFCcomboBox";
            this.AFCcomboBox.Size = new System.Drawing.Size(41, 21);
            this.AFCcomboBox.TabIndex = 0;
            this.AFCcomboBox.Text = "On";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Status:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.Plotbutton);
            this.panel1.Controls.Add(this.Loadbutton);
            this.panel1.Controls.Add(this.Savebutton);
            this.panel1.Controls.Add(this.Updatebutton);
            this.panel1.Controls.Add(this.Uploadbutton);
            this.panel1.Location = new System.Drawing.Point(19, 415);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 148);
            this.panel1.TabIndex = 40;
            // 
            // Plotbutton
            // 
            this.Plotbutton.BackColor = System.Drawing.Color.Cornsilk;
            this.Plotbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plotbutton.Location = new System.Drawing.Point(12, 44);
            this.Plotbutton.Name = "Plotbutton";
            this.Plotbutton.Size = new System.Drawing.Size(90, 27);
            this.Plotbutton.TabIndex = 1;
            this.Plotbutton.Text = "Plot";
            this.Plotbutton.UseVisualStyleBackColor = false;
            this.Plotbutton.Click += new System.EventHandler(this.Plotbutton_Click);
            // 
            // Loadbutton
            // 
            this.Loadbutton.BackColor = System.Drawing.Color.Cornsilk;
            this.Loadbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadbutton.Location = new System.Drawing.Point(12, 110);
            this.Loadbutton.Name = "Loadbutton";
            this.Loadbutton.Size = new System.Drawing.Size(90, 27);
            this.Loadbutton.TabIndex = 3;
            this.Loadbutton.Text = "Load";
            this.Loadbutton.UseVisualStyleBackColor = false;
            this.Loadbutton.Click += new System.EventHandler(this.Loadbutton_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.BackColor = System.Drawing.Color.Cornsilk;
            this.Savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebutton.Location = new System.Drawing.Point(12, 77);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(90, 27);
            this.Savebutton.TabIndex = 2;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = false;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.Color.Cornsilk;
            this.Updatebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.Location = new System.Drawing.Point(12, 11);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(90, 27);
            this.Updatebutton.TabIndex = 0;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Uploadbutton
            // 
            this.Uploadbutton.BackColor = System.Drawing.Color.Cornsilk;
            this.Uploadbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uploadbutton.Location = new System.Drawing.Point(141, 77);
            this.Uploadbutton.Name = "Uploadbutton";
            this.Uploadbutton.Size = new System.Drawing.Size(90, 60);
            this.Uploadbutton.TabIndex = 4;
            this.Uploadbutton.Text = "Upload";
            this.Uploadbutton.UseVisualStyleBackColor = false;
            this.Uploadbutton.Click += new System.EventHandler(this.Uploadbutton_Click);
            // 
            // Directorybutton
            // 
            this.Directorybutton.BackColor = System.Drawing.Color.Cornsilk;
            this.Directorybutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Directorybutton.Location = new System.Drawing.Point(180, 200);
            this.Directorybutton.Name = "Directorybutton";
            this.Directorybutton.Size = new System.Drawing.Size(65, 27);
            this.Directorybutton.TabIndex = 6;
            this.Directorybutton.Text = "Browse";
            this.Directorybutton.UseVisualStyleBackColor = false;
            this.Directorybutton.Click += new System.EventHandler(this.Directorybutton_Click);
            // 
            // txtWorkingDirectory
            // 
            this.txtWorkingDirectory.Location = new System.Drawing.Point(26, 175);
            this.txtWorkingDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.txtWorkingDirectory.Name = "txtWorkingDirectory";
            this.txtWorkingDirectory.Size = new System.Drawing.Size(219, 20);
            this.txtWorkingDirectory.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Working Directory:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 128);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Chunk Size:";
            // 
            // txtChunkSize
            // 
            this.txtChunkSize.Location = new System.Drawing.Point(204, 125);
            this.txtChunkSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtChunkSize.Name = "txtChunkSize";
            this.txtChunkSize.Size = new System.Drawing.Size(41, 20);
            this.txtChunkSize.TabIndex = 4;
            // 
            // txtMaxdB
            // 
            this.txtMaxdB.Location = new System.Drawing.Point(204, 101);
            this.txtMaxdB.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaxdB.Name = "txtMaxdB";
            this.txtMaxdB.Size = new System.Drawing.Size(41, 20);
            this.txtMaxdB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Max Level (dB SPL):";
            // 
            // numUDchannels
            // 
            this.numUDchannels.Location = new System.Drawing.Point(206, 24);
            this.numUDchannels.Margin = new System.Windows.Forms.Padding(2);
            this.numUDchannels.Name = "numUDchannels";
            this.numUDchannels.Size = new System.Drawing.Size(39, 20);
            this.numUDchannels.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Number of Channels:";
            // 
            // txtRelease
            // 
            this.txtRelease.Location = new System.Drawing.Point(204, 75);
            this.txtRelease.Margin = new System.Windows.Forms.Padding(2);
            this.txtRelease.Name = "txtRelease";
            this.txtRelease.Size = new System.Drawing.Size(41, 20);
            this.txtRelease.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Release Time (ms):";
            // 
            // txtAttack
            // 
            this.txtAttack.Location = new System.Drawing.Point(204, 51);
            this.txtAttack.Margin = new System.Windows.Forms.Padding(2);
            this.txtAttack.Name = "txtAttack";
            this.txtAttack.Size = new System.Drawing.Size(41, 20);
            this.txtAttack.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Attack Time (ms):";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dGV);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.zedGC);
            this.splitContainer2.Size = new System.Drawing.Size(486, 768);
            this.splitContainer2.SplitterDistance = 372;
            this.splitContainer2.TabIndex = 0;
            // 
            // dGV
            // 
            this.dGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CrossFrequency,
            this.TK,
            this.TKgain,
            this.CR,
            this.Bolt});
            this.dGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV.Location = new System.Drawing.Point(0, 0);
            this.dGV.Margin = new System.Windows.Forms.Padding(2);
            this.dGV.Name = "dGV";
            this.dGV.RowTemplate.Height = 24;
            this.dGV.Size = new System.Drawing.Size(486, 372);
            this.dGV.TabIndex = 0;
            // 
            // CrossFrequency
            // 
            this.CrossFrequency.HeaderText = "Crossover Frequency (Hz)";
            this.CrossFrequency.Name = "CrossFrequency";
            this.CrossFrequency.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TK
            // 
            this.TK.HeaderText = "Knee point";
            this.TK.Name = "TK";
            this.TK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TKgain
            // 
            this.TKgain.HeaderText = "Knee point Gain (dB)";
            this.TKgain.Name = "TKgain";
            this.TKgain.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CR
            // 
            this.CR.HeaderText = "Compression Ratio";
            this.CR.Name = "CR";
            this.CR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Bolt
            // 
            this.Bolt.HeaderText = "BOLT";
            this.Bolt.Name = "Bolt";
            this.Bolt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // zedGC
            // 
            this.zedGC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGC.Location = new System.Drawing.Point(0, 0);
            this.zedGC.Margin = new System.Windows.Forms.Padding(4);
            this.zedGC.Name = "zedGC";
            this.zedGC.ScrollGrace = 0;
            this.zedGC.ScrollMaxX = 0;
            this.zedGC.ScrollMaxY = 0;
            this.zedGC.ScrollMaxY2 = 0;
            this.zedGC.ScrollMinX = 0;
            this.zedGC.ScrollMinY = 0;
            this.zedGC.ScrollMinY2 = 0;
            this.zedGC.Size = new System.Drawing.Size(486, 392);
            this.zedGC.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(781, 814);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Generic Hearing Aid Controller";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUDchannels)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem loadDSLPrescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UploadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Plotbutton;
        private System.Windows.Forms.Button Loadbutton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Uploadbutton;
        private System.Windows.Forms.Button Directorybutton;
        private System.Windows.Forms.TextBox txtWorkingDirectory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChunkSize;
        private System.Windows.Forms.TextBox txtMaxdB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numUDchannels;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRelease;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAttack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CrossFrequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn TK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TKgain;
        private System.Windows.Forms.DataGridViewTextBoxColumn CR;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bolt;
        private ZedGraph.ZedGraphControl zedGC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox AFCcomboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRHO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEPS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAFCFilterLength;
    }
}

