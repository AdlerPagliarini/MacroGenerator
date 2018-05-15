namespace MSDN_TeclasForm
{
    partial class TopMacro
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeJanela = new System.Windows.Forms.TextBox();
            this.txtXLC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYLC = new System.Windows.Forms.TextBox();
            this.txtYRC = new System.Windows.Forms.TextBox();
            this.txtXRC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btnMouse = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddOpen = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lstComandos = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddLeftClick = new System.Windows.Forms.Button();
            this.btnAddRightClick = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddSMove = new System.Windows.Forms.Button();
            this.btnGetSY = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtXSLC = new System.Windows.Forms.TextBox();
            this.txtYSLC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtXMoveTo = new System.Windows.Forms.TextBox();
            this.txtYMoveTo = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSRepeat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRepeat = new System.Windows.Forms.TextBox();
            this.btnEndRepeat = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnResetSelect = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHelpCodes = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPressKey = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPKey = new System.Windows.Forms.TextBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.btnAutoRestart = new System.Windows.Forms.CheckBox();
            this.btnWait = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtWait = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Open Window - Ex: WindowProcess|My Name is";
            // 
            // txtNomeJanela
            // 
            this.txtNomeJanela.Location = new System.Drawing.Point(23, 36);
            this.txtNomeJanela.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeJanela.MaxLength = 48;
            this.txtNomeJanela.Name = "txtNomeJanela";
            this.txtNomeJanela.Size = new System.Drawing.Size(317, 22);
            this.txtNomeJanela.TabIndex = 4;
            // 
            // txtXLC
            // 
            this.txtXLC.Location = new System.Drawing.Point(23, 159);
            this.txtXLC.Margin = new System.Windows.Forms.Padding(4);
            this.txtXLC.MaxLength = 5;
            this.txtXLC.Name = "txtXLC";
            this.txtXLC.Size = new System.Drawing.Size(83, 22);
            this.txtXLC.TabIndex = 6;
            this.txtXLC.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mouse left click:";
            // 
            // txtYLC
            // 
            this.txtYLC.Location = new System.Drawing.Point(117, 159);
            this.txtYLC.Margin = new System.Windows.Forms.Padding(4);
            this.txtYLC.MaxLength = 5;
            this.txtYLC.Name = "txtYLC";
            this.txtYLC.Size = new System.Drawing.Size(83, 22);
            this.txtYLC.TabIndex = 7;
            this.txtYLC.Text = "0";
            // 
            // txtYRC
            // 
            this.txtYRC.Location = new System.Drawing.Point(117, 223);
            this.txtYRC.Margin = new System.Windows.Forms.Padding(4);
            this.txtYRC.MaxLength = 5;
            this.txtYRC.Name = "txtYRC";
            this.txtYRC.Size = new System.Drawing.Size(83, 22);
            this.txtYRC.TabIndex = 10;
            this.txtYRC.Text = "0";
            // 
            // txtXRC
            // 
            this.txtXRC.Location = new System.Drawing.Point(23, 223);
            this.txtXRC.Margin = new System.Windows.Forms.Padding(4);
            this.txtXRC.MaxLength = 5;
            this.txtXRC.Name = "txtXRC";
            this.txtXRC.Size = new System.Drawing.Size(83, 22);
            this.txtXRC.TabIndex = 9;
            this.txtXRC.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mouse right click:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(496, 633);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(163, 38);
            this.btnStart.TabIndex = 20;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(667, 633);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(163, 38);
            this.btnStop.TabIndex = 22;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(443, 693);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(404, 24);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "www.tagcode.com.br - Adler Pagliarini";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 633);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Current mouse position X,Y";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(205, 629);
            this.txtX.Margin = new System.Windows.Forms.Padding(4);
            this.txtX.Name = "txtX";
            this.txtX.ReadOnly = true;
            this.txtX.Size = new System.Drawing.Size(76, 22);
            this.txtX.TabIndex = 25;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(291, 629);
            this.txtY.Margin = new System.Windows.Forms.Padding(4);
            this.txtY.Name = "txtY";
            this.txtY.ReadOnly = true;
            this.txtY.Size = new System.Drawing.Size(76, 22);
            this.txtY.TabIndex = 26;
            // 
            // btnMouse
            // 
            this.btnMouse.Location = new System.Drawing.Point(19, 692);
            this.btnMouse.Margin = new System.Windows.Forms.Padding(4);
            this.btnMouse.Name = "btnMouse";
            this.btnMouse.Size = new System.Drawing.Size(403, 28);
            this.btnMouse.TabIndex = 27;
            this.btnMouse.Text = "GET Position X, Y";
            this.btnMouse.UseVisualStyleBackColor = true;
            this.btnMouse.Click += new System.EventHandler(this.btnMouse_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 662);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(409, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Attention : Click on \"GET\" and move the mouse to the position...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 599);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(432, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "_____________________________________________________";
            // 
            // btnAddOpen
            // 
            this.btnAddOpen.Location = new System.Drawing.Point(349, 33);
            this.btnAddOpen.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddOpen.Name = "btnAddOpen";
            this.btnAddOpen.Size = new System.Drawing.Size(116, 28);
            this.btnAddOpen.TabIndex = 30;
            this.btnAddOpen.Text = "open window";
            this.btnAddOpen.UseVisualStyleBackColor = true;
            this.btnAddOpen.Click += new System.EventHandler(this.btnAddOpen_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lstComandos
            // 
            this.lstComandos.FormattingEnabled = true;
            this.lstComandos.ItemHeight = 16;
            this.lstComandos.Location = new System.Drawing.Point(476, 114);
            this.lstComandos.Margin = new System.Windows.Forms.Padding(4);
            this.lstComandos.Name = "lstComandos";
            this.lstComandos.Size = new System.Drawing.Size(352, 420);
            this.lstComandos.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(472, 82);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Command Sequence:";
            // 
            // btnAddLeftClick
            // 
            this.btnAddLeftClick.Location = new System.Drawing.Point(209, 156);
            this.btnAddLeftClick.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddLeftClick.Name = "btnAddLeftClick";
            this.btnAddLeftClick.Size = new System.Drawing.Size(100, 28);
            this.btnAddLeftClick.TabIndex = 33;
            this.btnAddLeftClick.Text = "left click";
            this.btnAddLeftClick.UseVisualStyleBackColor = true;
            this.btnAddLeftClick.Click += new System.EventHandler(this.btnAddLeftClick_Click);
            // 
            // btnAddRightClick
            // 
            this.btnAddRightClick.Location = new System.Drawing.Point(209, 222);
            this.btnAddRightClick.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRightClick.Name = "btnAddRightClick";
            this.btnAddRightClick.Size = new System.Drawing.Size(100, 28);
            this.btnAddRightClick.TabIndex = 34;
            this.btnAddRightClick.Text = "right click";
            this.btnAddRightClick.UseVisualStyleBackColor = true;
            this.btnAddRightClick.Click += new System.EventHandler(this.btnAddRightClick_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox1.Controls.Add(this.btnAddSMove);
            this.groupBox1.Controls.Add(this.btnGetSY);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtXSLC);
            this.groupBox1.Controls.Add(this.txtYSLC);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtXMoveTo);
            this.groupBox1.Controls.Add(this.txtYMoveTo);
            this.groupBox1.Location = new System.Drawing.Point(20, 263);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(321, 196);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select and move:";
            // 
            // btnAddSMove
            // 
            this.btnAddSMove.Location = new System.Drawing.Point(24, 149);
            this.btnAddSMove.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSMove.Name = "btnAddSMove";
            this.btnAddSMove.Size = new System.Drawing.Size(287, 28);
            this.btnAddSMove.TabIndex = 37;
            this.btnAddSMove.Text = "Select and move to";
            this.btnAddSMove.UseVisualStyleBackColor = true;
            this.btnAddSMove.Click += new System.EventHandler(this.btnAddSMove_Click);
            // 
            // btnGetSY
            // 
            this.btnGetSY.Location = new System.Drawing.Point(211, 111);
            this.btnGetSY.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetSY.Name = "btnGetSY";
            this.btnGetSY.Size = new System.Drawing.Size(100, 28);
            this.btnGetSY.TabIndex = 36;
            this.btnGetSY.Text = "GET X,Y";
            this.btnGetSY.UseVisualStyleBackColor = true;
            this.btnGetSY.Click += new System.EventHandler(this.btnGetSY_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mouse left click:";
            // 
            // txtXSLC
            // 
            this.txtXSLC.Location = new System.Drawing.Point(24, 54);
            this.txtXSLC.Margin = new System.Windows.Forms.Padding(4);
            this.txtXSLC.MaxLength = 5;
            this.txtXSLC.Name = "txtXSLC";
            this.txtXSLC.Size = new System.Drawing.Size(83, 22);
            this.txtXSLC.TabIndex = 18;
            this.txtXSLC.Text = "0";
            // 
            // txtYSLC
            // 
            this.txtYSLC.Location = new System.Drawing.Point(119, 54);
            this.txtYSLC.Margin = new System.Windows.Forms.Padding(4);
            this.txtYSLC.MaxLength = 5;
            this.txtYSLC.Name = "txtYSLC";
            this.txtYSLC.Size = new System.Drawing.Size(83, 22);
            this.txtYSLC.TabIndex = 19;
            this.txtYSLC.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "... and move to:";
            // 
            // txtXMoveTo
            // 
            this.txtXMoveTo.Location = new System.Drawing.Point(27, 112);
            this.txtXMoveTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtXMoveTo.MaxLength = 5;
            this.txtXMoveTo.Name = "txtXMoveTo";
            this.txtXMoveTo.Size = new System.Drawing.Size(83, 22);
            this.txtXMoveTo.TabIndex = 21;
            this.txtXMoveTo.Text = "0";
            // 
            // txtYMoveTo
            // 
            this.txtYMoveTo.Location = new System.Drawing.Point(119, 112);
            this.txtYMoveTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtYMoveTo.MaxLength = 5;
            this.txtYMoveTo.Name = "txtYMoveTo";
            this.txtYMoveTo.Size = new System.Drawing.Size(83, 22);
            this.txtYMoveTo.TabIndex = 22;
            this.txtYMoveTo.Text = "0";
            // 
            // btnSRepeat
            // 
            this.btnSRepeat.Location = new System.Drawing.Point(112, 94);
            this.btnSRepeat.Margin = new System.Windows.Forms.Padding(4);
            this.btnSRepeat.Name = "btnSRepeat";
            this.btnSRepeat.Size = new System.Drawing.Size(100, 28);
            this.btnSRepeat.TabIndex = 39;
            this.btnSRepeat.Text = "start repeat";
            this.btnSRepeat.UseVisualStyleBackColor = true;
            this.btnSRepeat.Click += new System.EventHandler(this.btnSRepeat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Repeat for X times:";
            // 
            // txtRepeat
            // 
            this.txtRepeat.Location = new System.Drawing.Point(20, 95);
            this.txtRepeat.Margin = new System.Windows.Forms.Padding(4);
            this.txtRepeat.MaxLength = 30;
            this.txtRepeat.Name = "txtRepeat";
            this.txtRepeat.Size = new System.Drawing.Size(83, 22);
            this.txtRepeat.TabIndex = 37;
            this.txtRepeat.Text = "1";
            // 
            // btnEndRepeat
            // 
            this.btnEndRepeat.Location = new System.Drawing.Point(220, 94);
            this.btnEndRepeat.Margin = new System.Windows.Forms.Padding(4);
            this.btnEndRepeat.Name = "btnEndRepeat";
            this.btnEndRepeat.Size = new System.Drawing.Size(100, 28);
            this.btnEndRepeat.TabIndex = 40;
            this.btnEndRepeat.Text = "stop repeat";
            this.btnEndRepeat.UseVisualStyleBackColor = true;
            this.btnEndRepeat.Click += new System.EventHandler(this.btnEndRepeat_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(731, 76);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(99, 28);
            this.btnRemove.TabIndex = 41;
            this.btnRemove.Text = "remove line";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnResetSelect
            // 
            this.btnResetSelect.Location = new System.Drawing.Point(625, 76);
            this.btnResetSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetSelect.Name = "btnResetSelect";
            this.btnResetSelect.Size = new System.Drawing.Size(97, 28);
            this.btnResetSelect.TabIndex = 42;
            this.btnResetSelect.Text = "reset select";
            this.btnResetSelect.UseVisualStyleBackColor = true;
            this.btnResetSelect.Click += new System.EventHandler(this.btnResetSelect_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(667, 543);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(163, 38);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Save Script";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(496, 543);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(163, 38);
            this.btnLoad.TabIndex = 47;
            this.btnLoad.Text = "Load Script";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox2.Controls.Add(this.btnHelpCodes);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnPressKey);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtPKey);
            this.groupBox2.Location = new System.Drawing.Point(20, 468);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(321, 137);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Press Key";
            // 
            // btnHelpCodes
            // 
            this.btnHelpCodes.Location = new System.Drawing.Point(205, 52);
            this.btnHelpCodes.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelpCodes.Name = "btnHelpCodes";
            this.btnHelpCodes.Size = new System.Drawing.Size(100, 28);
            this.btnHelpCodes.TabIndex = 51;
            this.btnHelpCodes.Text = "Help Codes";
            this.btnHelpCodes.UseVisualStyleBackColor = true;
            this.btnHelpCodes.Click += new System.EventHandler(this.btnHelpCodes_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 69);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 17);
            this.label13.TabIndex = 50;
            this.label13.Text = "CTRL+F1 = ^{F1}";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 46);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 17);
            this.label12.TabIndex = 49;
            this.label12.Text = "CTRL,SHIFT,ALT = ^  +  %  ";
            // 
            // btnPressKey
            // 
            this.btnPressKey.Location = new System.Drawing.Point(140, 92);
            this.btnPressKey.Margin = new System.Windows.Forms.Padding(4);
            this.btnPressKey.Name = "btnPressKey";
            this.btnPressKey.Size = new System.Drawing.Size(123, 28);
            this.btnPressKey.TabIndex = 48;
            this.btnPressKey.Text = "Press KEY";
            this.btnPressKey.UseVisualStyleBackColor = true;
            this.btnPressKey.Click += new System.EventHandler(this.btnPressKey_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Ex: A = {A}, F = {F1}, Text = {/wHello}";
            // 
            // txtPKey
            // 
            this.txtPKey.Location = new System.Drawing.Point(12, 95);
            this.txtPKey.Margin = new System.Windows.Forms.Padding(4);
            this.txtPKey.MaxLength = 50;
            this.txtPKey.Name = "txtPKey";
            this.txtPKey.Size = new System.Drawing.Size(119, 22);
            this.txtPKey.TabIndex = 46;
            this.txtPKey.Text = "{F1}";
            // 
            // btnAutoRestart
            // 
            this.btnAutoRestart.AutoSize = true;
            this.btnAutoRestart.Location = new System.Drawing.Point(496, 601);
            this.btnAutoRestart.Margin = new System.Windows.Forms.Padding(4);
            this.btnAutoRestart.Name = "btnAutoRestart";
            this.btnAutoRestart.Size = new System.Drawing.Size(105, 21);
            this.btnAutoRestart.TabIndex = 50;
            this.btnAutoRestart.Text = "Auto-restart";
            this.btnAutoRestart.UseVisualStyleBackColor = true;
            // 
            // btnWait
            // 
            this.btnWait.Location = new System.Drawing.Point(584, 34);
            this.btnWait.Margin = new System.Windows.Forms.Padding(4);
            this.btnWait.Name = "btnWait";
            this.btnWait.Size = new System.Drawing.Size(100, 28);
            this.btnWait.TabIndex = 53;
            this.btnWait.Text = "put time";
            this.btnWait.UseVisualStyleBackColor = true;
            this.btnWait.Click += new System.EventHandler(this.btnWait_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(488, 11);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(192, 17);
            this.label14.TabIndex = 52;
            this.label14.Text = "Wait for X/ms: (1000 = 1 sec)";
            // 
            // txtWait
            // 
            this.txtWait.Location = new System.Drawing.Point(492, 36);
            this.txtWait.Margin = new System.Windows.Forms.Padding(4);
            this.txtWait.MaxLength = 30;
            this.txtWait.Name = "txtWait";
            this.txtWait.Size = new System.Drawing.Size(83, 22);
            this.txtWait.TabIndex = 51;
            this.txtWait.Text = "1000";
            // 
            // TopMacro
            // 
            this.AcceptButton = this.btnPressKey;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 738);
            this.Controls.Add(this.btnWait);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtWait);
            this.Controls.Add(this.btnAutoRestart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnResetSelect);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEndRepeat);
            this.Controls.Add(this.btnSRepeat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRepeat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddRightClick);
            this.Controls.Add(this.btnAddLeftClick);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lstComandos);
            this.Controls.Add(this.btnAddOpen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnMouse);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtYRC);
            this.Controls.Add(this.txtXRC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYLC);
            this.Controls.Add(this.txtXLC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeJanela);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TopMacro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TOP Macro - by tagcode.com.br";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TopMacro_FormClosing);
            this.Load += new System.EventHandler(this.TopMacro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeJanela;
        private System.Windows.Forms.TextBox txtXLC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYLC;
        private System.Windows.Forms.TextBox txtYRC;
        private System.Windows.Forms.TextBox txtXRC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button btnMouse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnAddOpen;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnAddRightClick;
        private System.Windows.Forms.Button btnAddLeftClick;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lstComandos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtXSLC;
        private System.Windows.Forms.TextBox txtYSLC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtXMoveTo;
        private System.Windows.Forms.TextBox txtYMoveTo;
        private System.Windows.Forms.Button btnGetSY;
        private System.Windows.Forms.Button btnAddSMove;
        private System.Windows.Forms.Button btnEndRepeat;
        private System.Windows.Forms.Button btnSRepeat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRepeat;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnResetSelect;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPressKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPKey;
        private System.Windows.Forms.Button btnHelpCodes;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.CheckBox btnAutoRestart;
        private System.Windows.Forms.Button btnWait;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtWait;
    }
}