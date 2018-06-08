namespace PP
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbBezSilnia = new System.Windows.Forms.TextBox();
            this.tbWartoscSilnia = new System.Windows.Forms.TextBox();
            this.tbRefSilnia = new System.Windows.Forms.TextBox();
            this.btnLiczSilnie = new System.Windows.Forms.Button();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.linkWykresy = new System.Windows.Forms.LinkLabel();
            this.linkFibonacci = new System.Windows.Forms.LinkLabel();
            this.linkSilnia = new System.Windows.Forms.LinkLabel();
            this.linkSortowanie = new System.Windows.Forms.LinkLabel();
            this.lblTytul = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numeric = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRefSort = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLiczSort = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbWartoscSort = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbBezSort = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numericSilnia = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.numericK = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.numericN = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbRefNew = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnLiczFib = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tbWartoscNew = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbBezNew = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tab.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSilnia)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericN)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Porównanie czasów działania programów liczących silnię\r\n(w podwójnej pętli)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bez podprogramów ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Z podprogramami";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(330, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "- z przekazaniem parametrów przez wartość";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(357, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "- z przekazaniem parametrów przez referencję";
            // 
            // tbBezSilnia
            // 
            this.tbBezSilnia.Enabled = false;
            this.tbBezSilnia.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBezSilnia.Location = new System.Drawing.Point(473, 132);
            this.tbBezSilnia.Name = "tbBezSilnia";
            this.tbBezSilnia.ReadOnly = true;
            this.tbBezSilnia.Size = new System.Drawing.Size(100, 22);
            this.tbBezSilnia.TabIndex = 7;
            // 
            // tbWartoscSilnia
            // 
            this.tbWartoscSilnia.Enabled = false;
            this.tbWartoscSilnia.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWartoscSilnia.Location = new System.Drawing.Point(473, 233);
            this.tbWartoscSilnia.Name = "tbWartoscSilnia";
            this.tbWartoscSilnia.ReadOnly = true;
            this.tbWartoscSilnia.Size = new System.Drawing.Size(100, 22);
            this.tbWartoscSilnia.TabIndex = 9;
            // 
            // tbRefSilnia
            // 
            this.tbRefSilnia.Enabled = false;
            this.tbRefSilnia.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRefSilnia.Location = new System.Drawing.Point(473, 291);
            this.tbRefSilnia.Name = "tbRefSilnia";
            this.tbRefSilnia.ReadOnly = true;
            this.tbRefSilnia.Size = new System.Drawing.Size(100, 22);
            this.tbRefSilnia.TabIndex = 10;
            // 
            // btnLiczSilnie
            // 
            this.btnLiczSilnie.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiczSilnie.Location = new System.Drawing.Point(234, 101);
            this.btnLiczSilnie.Name = "btnLiczSilnie";
            this.btnLiczSilnie.Size = new System.Drawing.Size(140, 23);
            this.btnLiczSilnie.TabIndex = 15;
            this.btnLiczSilnie.Text = "Licz wszystko";
            this.btnLiczSilnie.UseVisualStyleBackColor = true;
            this.btnLiczSilnie.Click += new System.EventHandler(this.btnLiczSilnie_Click);
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPage3);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Controls.Add(this.tabPage1);
            this.tab.Controls.Add(this.tabPage4);
            this.tab.Controls.Add(this.tabPage5);
            this.tab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tab.Location = new System.Drawing.Point(83, 12);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(630, 425);
            this.tab.TabIndex = 16;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.linkWykresy);
            this.tabPage3.Controls.Add(this.linkFibonacci);
            this.tabPage3.Controls.Add(this.linkSilnia);
            this.tabPage3.Controls.Add(this.linkSortowanie);
            this.tabPage3.Controls.Add(this.lblTytul);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(622, 396);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Strona główna";
            // 
            // linkWykresy
            // 
            this.linkWykresy.AutoSize = true;
            this.linkWykresy.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkWykresy.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkWykresy.LinkColor = System.Drawing.Color.Black;
            this.linkWykresy.Location = new System.Drawing.Point(281, 292);
            this.linkWykresy.Name = "linkWykresy";
            this.linkWykresy.Size = new System.Drawing.Size(63, 15);
            this.linkWykresy.TabIndex = 4;
            this.linkWykresy.TabStop = true;
            this.linkWykresy.Text = "Wykresy";
            this.linkWykresy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkFibonacci
            // 
            this.linkFibonacci.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.linkFibonacci.AutoSize = true;
            this.linkFibonacci.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkFibonacci.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkFibonacci.LinkColor = System.Drawing.Color.Black;
            this.linkFibonacci.Location = new System.Drawing.Point(250, 231);
            this.linkFibonacci.Name = "linkFibonacci";
            this.linkFibonacci.Size = new System.Drawing.Size(119, 15);
            this.linkFibonacci.TabIndex = 3;
            this.linkFibonacci.TabStop = true;
            this.linkFibonacci.Text = "Symbol Newtona";
            this.linkFibonacci.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkSilnia
            // 
            this.linkSilnia.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.linkSilnia.AutoSize = true;
            this.linkSilnia.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSilnia.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkSilnia.LinkColor = System.Drawing.Color.Black;
            this.linkSilnia.Location = new System.Drawing.Point(281, 170);
            this.linkSilnia.Name = "linkSilnia";
            this.linkSilnia.Size = new System.Drawing.Size(55, 15);
            this.linkSilnia.TabIndex = 2;
            this.linkSilnia.TabStop = true;
            this.linkSilnia.Text = "Silnia";
            this.linkSilnia.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkSortowanie
            // 
            this.linkSortowanie.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.linkSortowanie.AutoSize = true;
            this.linkSortowanie.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSortowanie.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkSortowanie.LinkColor = System.Drawing.Color.Black;
            this.linkSortowanie.Location = new System.Drawing.Point(269, 116);
            this.linkSortowanie.Name = "linkSortowanie";
            this.linkSortowanie.Size = new System.Drawing.Size(87, 15);
            this.linkSortowanie.TabIndex = 1;
            this.linkSortowanie.TabStop = true;
            this.linkSortowanie.Text = "Sortowanie";
            this.linkSortowanie.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSortowanie_LinkClicked);
            // 
            // lblTytul
            // 
            this.lblTytul.AutoSize = true;
            this.lblTytul.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTytul.Location = new System.Drawing.Point(57, 50);
            this.lblTytul.Name = "lblTytul";
            this.lblTytul.Size = new System.Drawing.Size(498, 17);
            this.lblTytul.TabIndex = 0;
            this.lblTytul.Text = "Program do wyliczania czasów działania algorytmów";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.numeric);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tbRefSort);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.btnLiczSort);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tbWartoscSort);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tbBezSort);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(622, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sortowanie";
            // 
            // numeric
            // 
            this.numeric.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numeric.Location = new System.Drawing.Point(223, 75);
            this.numeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeric.Name = "numeric";
            this.numeric.Size = new System.Drawing.Size(65, 22);
            this.numeric.TabIndex = 27;
            this.numeric.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(294, 80);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 15);
            this.label16.TabIndex = 26;
            this.label16.Text = "elementów";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(446, 34);
            this.label3.TabIndex = 16;
            this.label3.Text = "Porównanie czasów działania programów sortujących\r\n(metoda przez wstawianie)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(357, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "- z przekazaniem parametrów przez referencję";
            // 
            // tbRefSort
            // 
            this.tbRefSort.Cursor = System.Windows.Forms.Cursors.No;
            this.tbRefSort.Enabled = false;
            this.tbRefSort.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRefSort.Location = new System.Drawing.Point(480, 310);
            this.tbRefSort.Name = "tbRefSort";
            this.tbRefSort.ReadOnly = true;
            this.tbRefSort.Size = new System.Drawing.Size(100, 22);
            this.tbRefSort.TabIndex = 23;
            this.tbRefSort.TextChanged += new System.EventHandler(this.tbRefSort_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(330, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "- z przekazaniem parametrów przez wartość";
            // 
            // btnLiczSort
            // 
            this.btnLiczSort.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiczSort.Location = new System.Drawing.Point(233, 115);
            this.btnLiczSort.Name = "btnLiczSort";
            this.btnLiczSort.Size = new System.Drawing.Size(140, 23);
            this.btnLiczSort.TabIndex = 24;
            this.btnLiczSort.Text = "Licz wszystko";
            this.btnLiczSort.UseVisualStyleBackColor = true;
            this.btnLiczSort.Click += new System.EventHandler(this.btnLiczSort_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Z podprogramami";
            // 
            // tbWartoscSort
            // 
            this.tbWartoscSort.Cursor = System.Windows.Forms.Cursors.No;
            this.tbWartoscSort.Enabled = false;
            this.tbWartoscSort.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWartoscSort.Location = new System.Drawing.Point(480, 250);
            this.tbWartoscSort.Name = "tbWartoscSort";
            this.tbWartoscSort.ReadOnly = true;
            this.tbWartoscSort.Size = new System.Drawing.Size(100, 22);
            this.tbWartoscSort.TabIndex = 22;
            this.tbWartoscSort.TextChanged += new System.EventHandler(this.tbWartoscSort_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Bez podprogramów ";
            // 
            // tbBezSort
            // 
            this.tbBezSort.Cursor = System.Windows.Forms.Cursors.No;
            this.tbBezSort.Enabled = false;
            this.tbBezSort.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbBezSort.Location = new System.Drawing.Point(480, 155);
            this.tbBezSort.Name = "tbBezSort";
            this.tbBezSort.ReadOnly = true;
            this.tbBezSort.Size = new System.Drawing.Size(100, 22);
            this.tbBezSort.TabIndex = 21;
            this.tbBezSort.TextChanged += new System.EventHandler(this.tbBezSort_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.numericSilnia);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tbRefSilnia);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnLiczSilnie);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tbWartoscSilnia);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbBezSilnia);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(622, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Silnia";
            // 
            // numericSilnia
            // 
            this.numericSilnia.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericSilnia.Location = new System.Drawing.Point(307, 64);
            this.numericSilnia.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericSilnia.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericSilnia.Name = "numericSilnia";
            this.numericSilnia.Size = new System.Drawing.Size(87, 22);
            this.numericSilnia.TabIndex = 17;
            this.numericSilnia.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(199, 68);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 15);
            this.label17.TabIndex = 16;
            this.label17.Text = "dla liczby";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.numericK);
            this.tabPage4.Controls.Add(this.label19);
            this.tabPage4.Controls.Add(this.numericN);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.tbRefNew);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.btnLiczFib);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.tbWartoscNew);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.tbBezNew);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(622, 396);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Symbol Newtona";
            // 
            // numericK
            // 
            this.numericK.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericK.Location = new System.Drawing.Point(340, 67);
            this.numericK.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericK.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericK.Name = "numericK";
            this.numericK.Size = new System.Drawing.Size(83, 22);
            this.numericK.TabIndex = 28;
            this.numericK.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(307, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 15);
            this.label19.TabIndex = 27;
            this.label19.Text = "k =";
            // 
            // numericN
            // 
            this.numericN.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericN.Location = new System.Drawing.Point(207, 67);
            this.numericN.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericN.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericN.Name = "numericN";
            this.numericN.Size = new System.Drawing.Size(76, 22);
            this.numericN.TabIndex = 26;
            this.numericN.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(173, 69);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 15);
            this.label18.TabIndex = 25;
            this.label18.Text = "n =";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(100, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(437, 34);
            this.label11.TabIndex = 16;
            this.label11.Text = "Porównanie czasów działania programów liczących \r\nsymbol Newtona (w potrójnej pęt" +
    "li)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 328);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(357, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "- z przekazaniem parametrów przez referencję";
            // 
            // tbRefNew
            // 
            this.tbRefNew.Enabled = false;
            this.tbRefNew.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRefNew.Location = new System.Drawing.Point(492, 325);
            this.tbRefNew.Name = "tbRefNew";
            this.tbRefNew.ReadOnly = true;
            this.tbRefNew.Size = new System.Drawing.Size(100, 22);
            this.tbRefNew.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 276);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(330, 15);
            this.label13.TabIndex = 19;
            this.label13.Text = "- z przekazaniem parametrów przez wartość";
            // 
            // btnLiczFib
            // 
            this.btnLiczFib.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiczFib.Location = new System.Drawing.Point(248, 107);
            this.btnLiczFib.Name = "btnLiczFib";
            this.btnLiczFib.Size = new System.Drawing.Size(140, 23);
            this.btnLiczFib.TabIndex = 24;
            this.btnLiczFib.Text = "Licz wszystko";
            this.btnLiczFib.UseVisualStyleBackColor = true;
            this.btnLiczFib.Click += new System.EventHandler(this.btnLiczNewton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 15);
            this.label14.TabIndex = 18;
            this.label14.Text = "Z podprogramami";
            // 
            // tbWartoscNew
            // 
            this.tbWartoscNew.Enabled = false;
            this.tbWartoscNew.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWartoscNew.Location = new System.Drawing.Point(492, 273);
            this.tbWartoscNew.Name = "tbWartoscNew";
            this.tbWartoscNew.ReadOnly = true;
            this.tbWartoscNew.Size = new System.Drawing.Size(100, 22);
            this.tbWartoscNew.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 153);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 15);
            this.label15.TabIndex = 17;
            this.label15.Text = "Bez podprogramów ";
            // 
            // tbBezNew
            // 
            this.tbBezNew.Enabled = false;
            this.tbBezNew.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBezNew.Location = new System.Drawing.Point(492, 150);
            this.tbBezNew.Name = "tbBezNew";
            this.tbBezNew.ReadOnly = true;
            this.tbBezNew.Size = new System.Drawing.Size(100, 22);
            this.tbBezNew.TabIndex = 21;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.button4);
            this.tabPage5.Controls.Add(this.button3);
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Controls.Add(this.chart);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(622, 396);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Wykresy";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(241, 27);
            this.button4.TabIndex = 4;
            this.button4.Text = "Wszystkich";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(241, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "Rysuj dla Symbolu Newtona";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Rysuj dla silni";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Rysuj dla sortowania";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(250, 35);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.LegendText = "Sortowanie";
            series1.Name = "Bez podprogramów";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.LegendText = "Silnia";
            series2.Name = "Z pp z przekazaniem argumentu przez wartość";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.LegendText = "Symol Newtona";
            series3.Name = "Z pp z przekazaniem arg przez ref";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(355, 358);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PP.Properties.Resources.ob;
            this.ClientSize = new System.Drawing.Size(807, 494);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.Text = "Obliczanie czasu działania";
            this.tab.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSilnia)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericN)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbBezSilnia;
        private System.Windows.Forms.TextBox tbWartoscSilnia;
        private System.Windows.Forms.TextBox tbRefSilnia;
        private System.Windows.Forms.Button btnLiczSilnie;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblTytul;
        private System.Windows.Forms.LinkLabel linkWykresy;
        private System.Windows.Forms.LinkLabel linkFibonacci;
        private System.Windows.Forms.LinkLabel linkSilnia;
        private System.Windows.Forms.LinkLabel linkSortowanie;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRefSort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLiczSort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbWartoscSort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbBezSort;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbRefNew;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnLiczFib;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbWartoscNew;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbBezNew;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numeric;
        private System.Windows.Forms.NumericUpDown numericSilnia;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.NumericUpDown numericK;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numericN;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

