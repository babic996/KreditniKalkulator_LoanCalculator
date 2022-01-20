namespace KreditniKalkulatorTrackBar
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.podešavanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.izlazIzAplikacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblUkupnoKamate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUkupnoZaduzenje = new System.Windows.Forms.Label();
            this.lblIzosRate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trbIznosKredita = new System.Windows.Forms.TrackBar();
            this.trbBrojMjeseci = new System.Windows.Forms.TrackBar();
            this.txtIznosKredita = new System.Windows.Forms.TextBox();
            this.txtBrojMjeseci = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbLos = new System.Windows.Forms.RadioButton();
            this.rdbDobar = new System.Windows.Forms.RadioButton();
            this.rdbOdlican = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbIznosKredita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBrojMjeseci)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniToolStripMenuItem
            // 
            this.meniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.podešavanjaToolStripMenuItem,
            this.toolStripSeparator1,
            this.izlazIzAplikacijeToolStripMenuItem});
            this.meniToolStripMenuItem.Name = "meniToolStripMenuItem";
            this.meniToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.meniToolStripMenuItem.Text = "Meni";
            // 
            // podešavanjaToolStripMenuItem
            // 
            this.podešavanjaToolStripMenuItem.Image = global::KreditniKalkulatorTrackBar.Properties.Resources.podesavanja_meni;
            this.podešavanjaToolStripMenuItem.Name = "podešavanjaToolStripMenuItem";
            this.podešavanjaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.podešavanjaToolStripMenuItem.Text = "Podešavanja";
            this.podešavanjaToolStripMenuItem.Click += new System.EventHandler(this.podešavanjaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // izlazIzAplikacijeToolStripMenuItem
            // 
            this.izlazIzAplikacijeToolStripMenuItem.Image = global::KreditniKalkulatorTrackBar.Properties.Resources.izlaz_meni;
            this.izlazIzAplikacijeToolStripMenuItem.Name = "izlazIzAplikacijeToolStripMenuItem";
            this.izlazIzAplikacijeToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.izlazIzAplikacijeToolStripMenuItem.Text = "Izlaz iz aplikacije";
            this.izlazIzAplikacijeToolStripMenuItem.Click += new System.EventHandler(this.izlazIzAplikacijeToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.Controls.Add(this.lblUkupnoKamate, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblUkupnoZaduzenje, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblIzosRate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.trbIznosKredita, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.trbBrojMjeseci, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtIznosKredita, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBrojMjeseci, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 134);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.80315F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.80315F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.83464F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.55906F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(676, 172);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblUkupnoKamate
            // 
            this.lblUkupnoKamate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUkupnoKamate.AutoSize = true;
            this.lblUkupnoKamate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupnoKamate.ForeColor = System.Drawing.Color.Teal;
            this.lblUkupnoKamate.Location = new System.Drawing.Point(608, 138);
            this.lblUkupnoKamate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUkupnoKamate.Name = "lblUkupnoKamate";
            this.lblUkupnoKamate.Size = new System.Drawing.Size(0, 18);
            this.lblUkupnoKamate.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(580, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ukupno kamate";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUkupnoZaduzenje
            // 
            this.lblUkupnoZaduzenje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUkupnoZaduzenje.AutoSize = true;
            this.lblUkupnoZaduzenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupnoZaduzenje.ForeColor = System.Drawing.Color.Teal;
            this.lblUkupnoZaduzenje.Location = new System.Drawing.Point(473, 138);
            this.lblUkupnoZaduzenje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUkupnoZaduzenje.Name = "lblUkupnoZaduzenje";
            this.lblUkupnoZaduzenje.Size = new System.Drawing.Size(0, 18);
            this.lblUkupnoZaduzenje.TabIndex = 10;
            // 
            // lblIzosRate
            // 
            this.lblIzosRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIzosRate.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblIzosRate, 2);
            this.lblIzosRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIzosRate.ForeColor = System.Drawing.Color.Teal;
            this.lblIzosRate.Location = new System.Drawing.Point(541, 54);
            this.lblIzosRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIzosRate.Name = "lblIzosRate";
            this.lblIzosRate.Size = new System.Drawing.Size(0, 18);
            this.lblIzosRate.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(409, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ukupno zaduženje";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(116, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Broj mjeseci";
            // 
            // trbIznosKredita
            // 
            this.trbIznosKredita.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trbIznosKredita.AutoSize = false;
            this.trbIznosKredita.LargeChange = 1000;
            this.trbIznosKredita.Location = new System.Drawing.Point(2, 44);
            this.trbIznosKredita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trbIznosKredita.Maximum = 400000;
            this.trbIznosKredita.Name = "trbIznosKredita";
            this.trbIznosKredita.Size = new System.Drawing.Size(335, 38);
            this.trbIznosKredita.SmallChange = 100;
            this.trbIznosKredita.TabIndex = 0;
            this.trbIznosKredita.TickFrequency = 1000;
            this.trbIznosKredita.Scroll += new System.EventHandler(this.trbIznosKredita_Scroll);
            // 
            // trbBrojMjeseci
            // 
            this.trbBrojMjeseci.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trbBrojMjeseci.LargeChange = 12;
            this.trbBrojMjeseci.Location = new System.Drawing.Point(2, 125);
            this.trbBrojMjeseci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trbBrojMjeseci.Maximum = 120;
            this.trbBrojMjeseci.Minimum = 12;
            this.trbBrojMjeseci.Name = "trbBrojMjeseci";
            this.trbBrojMjeseci.Size = new System.Drawing.Size(335, 45);
            this.trbBrojMjeseci.SmallChange = 6;
            this.trbBrojMjeseci.TabIndex = 1;
            this.trbBrojMjeseci.Value = 12;
            this.trbBrojMjeseci.Scroll += new System.EventHandler(this.trbBrojMjeseci_Scroll);
            // 
            // txtIznosKredita
            // 
            this.txtIznosKredita.BackColor = System.Drawing.Color.White;
            this.txtIznosKredita.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtIznosKredita.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIznosKredita.Location = new System.Drawing.Point(341, 44);
            this.txtIznosKredita.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIznosKredita.Name = "txtIznosKredita";
            this.txtIznosKredita.ReadOnly = true;
            this.txtIznosKredita.Size = new System.Drawing.Size(64, 23);
            this.txtIznosKredita.TabIndex = 3;
            // 
            // txtBrojMjeseci
            // 
            this.txtBrojMjeseci.BackColor = System.Drawing.Color.White;
            this.txtBrojMjeseci.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBrojMjeseci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojMjeseci.Location = new System.Drawing.Point(341, 125);
            this.txtBrojMjeseci.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBrojMjeseci.Name = "txtBrojMjeseci";
            this.txtBrojMjeseci.ReadOnly = true;
            this.txtBrojMjeseci.Size = new System.Drawing.Size(64, 23);
            this.txtBrojMjeseci.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(80, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ukupan iznos kredita";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 2);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(471, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Iznos mjesečne rate";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdbLos);
            this.groupBox1.Controls.Add(this.rdbDobar);
            this.groupBox1.Controls.Add(this.rdbOdlican);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(395, 101);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vrsta klijenta (Kamatna stopa)";
            // 
            // rdbLos
            // 
            this.rdbLos.AutoSize = true;
            this.rdbLos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLos.Location = new System.Drawing.Point(4, 73);
            this.rdbLos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbLos.Name = "rdbLos";
            this.rdbLos.Size = new System.Drawing.Size(195, 19);
            this.rdbLos.TabIndex = 2;
            this.rdbLos.TabStop = true;
            this.rdbLos.Text = "Loš klijent (Kamatna stopa 6%)";
            this.rdbLos.UseVisualStyleBackColor = true;
            this.rdbLos.CheckedChanged += new System.EventHandler(this.rdbLos_CheckedChanged);
            // 
            // rdbDobar
            // 
            this.rdbDobar.AutoSize = true;
            this.rdbDobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDobar.Location = new System.Drawing.Point(4, 50);
            this.rdbDobar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbDobar.Name = "rdbDobar";
            this.rdbDobar.Size = new System.Drawing.Size(207, 19);
            this.rdbDobar.TabIndex = 1;
            this.rdbDobar.TabStop = true;
            this.rdbDobar.Text = "Dobar klijent (kamatna stopa 5%)";
            this.rdbDobar.UseVisualStyleBackColor = true;
            this.rdbDobar.CheckedChanged += new System.EventHandler(this.rdbDobar_CheckedChanged);
            // 
            // rdbOdlican
            // 
            this.rdbOdlican.AutoSize = true;
            this.rdbOdlican.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOdlican.Location = new System.Drawing.Point(4, 27);
            this.rdbOdlican.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbOdlican.Name = "rdbOdlican";
            this.rdbOdlican.Size = new System.Drawing.Size(217, 19);
            this.rdbOdlican.TabIndex = 0;
            this.rdbOdlican.TabStop = true;
            this.rdbOdlican.Text = "Odličan klijent (Kamatna stopa 3%)";
            this.rdbOdlican.UseVisualStyleBackColor = true;
            this.rdbOdlican.CheckedChanged += new System.EventHandler(this.rdbOdlican_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lblSat);
            this.panel1.Location = new System.Drawing.Point(407, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.MaximumSize = new System.Drawing.Size(267, 83);
            this.panel1.MinimumSize = new System.Drawing.Size(267, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 83);
            this.panel1.TabIndex = 3;
            // 
            // lblSat
            // 
            this.lblSat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSat.ForeColor = System.Drawing.Color.Teal;
            this.lblSat.Location = new System.Drawing.Point(0, 0);
            this.lblSat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSat.Name = "lblSat";
            this.lblSat.Size = new System.Drawing.Size(267, 83);
            this.lblSat.TabIndex = 0;
            this.lblSat.Text = "Ovdje ce biti sat";
            this.lblSat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 306);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(705, 371);
            this.MinimumSize = new System.Drawing.Size(672, 339);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kreditni kalkulator by Aleksandar Babic";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbIznosKredita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBrojMjeseci)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem podešavanjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem izlazIzAplikacijeToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TrackBar trbIznosKredita;
        private System.Windows.Forms.TrackBar trbBrojMjeseci;
        private System.Windows.Forms.TextBox txtIznosKredita;
        private System.Windows.Forms.TextBox txtBrojMjeseci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbLos;
        private System.Windows.Forms.RadioButton rdbDobar;
        private System.Windows.Forms.RadioButton rdbOdlican;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUkupnoZaduzenje;
        private System.Windows.Forms.Label lblIzosRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSat;
        private System.Windows.Forms.Label lblUkupnoKamate;
        private System.Windows.Forms.Timer timer1;
    }
}

