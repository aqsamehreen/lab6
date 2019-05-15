namespace WindowsFormsApp2
{
    partial class Displayform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Displayform));
            this.recieptbox = new System.Windows.Forms.Panel();
            this.recieptbx = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exitbtn = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.recieptbtn = new System.Windows.Forms.Button();
            this.signoutbtn = new System.Windows.Forms.Button();
            this.totalbtn = new System.Windows.Forms.Button();
            this.placeorderlbl = new System.Windows.Forms.Label();
            this.pepsilbl = new System.Windows.Forms.Panel();
            this.pepsitxt = new System.Windows.Forms.TextBox();
            this.slicetxt = new System.Windows.Forms.TextBox();
            this.icecreamtxt = new System.Windows.Forms.TextBox();
            this.kitkattxt = new System.Windows.Forms.TextBox();
            this.wafferstxt = new System.Windows.Forms.TextBox();
            this.nimkotxt = new System.Windows.Forms.TextBox();
            this.fantatxt = new System.Windows.Forms.TextBox();
            this.sevenuptxt = new System.Windows.Forms.TextBox();
            this.riotxt = new System.Windows.Forms.TextBox();
            this.slantytxt = new System.Windows.Forms.TextBox();
            this.nimkolbl = new System.Windows.Forms.Label();
            this.fantalbl = new System.Windows.Forms.Label();
            this.sevenuplbl = new System.Windows.Forms.Label();
            this.slicelbl = new System.Windows.Forms.Label();
            this.icecreamlbl = new System.Windows.Forms.Label();
            this.kitkatlbl = new System.Windows.Forms.Label();
            this.wafferslbl = new System.Windows.Forms.Label();
            this.peplbl = new System.Windows.Forms.Label();
            this.riolbl = new System.Windows.Forms.Label();
            this.slantylbl = new System.Windows.Forms.Label();
            this.nimkochk = new System.Windows.Forms.CheckBox();
            this.fantachk = new System.Windows.Forms.CheckBox();
            this.sevenupchk = new System.Windows.Forms.CheckBox();
            this.Pepsichk = new System.Windows.Forms.CheckBox();
            this.wafferschk = new System.Windows.Forms.CheckBox();
            this.kitkatchk = new System.Windows.Forms.CheckBox();
            this.icecreamchk = new System.Windows.Forms.CheckBox();
            this.slicejchk = new System.Windows.Forms.CheckBox();
            this.riochk = new System.Windows.Forms.CheckBox();
            this.slantychk = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timelbl = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.tucshplbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.recieptbox.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pepsilbl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // recieptbox
            // 
            this.recieptbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.recieptbox.Controls.Add(this.label1);
            this.recieptbox.Controls.Add(this.recieptbx);
            this.recieptbox.Controls.Add(this.toolStrip1);
            this.recieptbox.Location = new System.Drawing.Point(608, 87);
            this.recieptbox.Name = "recieptbox";
            this.recieptbox.Size = new System.Drawing.Size(310, 366);
            this.recieptbox.TabIndex = 7;
            // 
            // recieptbx
            // 
            this.recieptbx.Location = new System.Drawing.Point(3, 28);
            this.recieptbx.Name = "recieptbx";
            this.recieptbx.Size = new System.Drawing.Size(296, 323);
            this.recieptbx.TabIndex = 1;
            this.recieptbx.Text = "";
            this.recieptbx.TextChanged += new System.EventHandler(this.recieptbx_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(310, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.exitbtn);
            this.panel4.Controls.Add(this.resetbtn);
            this.panel4.Controls.Add(this.recieptbtn);
            this.panel4.Controls.Add(this.signoutbtn);
            this.panel4.Controls.Add(this.totalbtn);
            this.panel4.Controls.Add(this.placeorderlbl);
            this.panel4.Location = new System.Drawing.Point(325, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(277, 387);
            this.panel4.TabIndex = 6;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(166, 229);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 14;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.Location = new System.Drawing.Point(166, 146);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(75, 23);
            this.resetbtn.TabIndex = 13;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // recieptbtn
            // 
            this.recieptbtn.Location = new System.Drawing.Point(41, 229);
            this.recieptbtn.Name = "recieptbtn";
            this.recieptbtn.Size = new System.Drawing.Size(75, 23);
            this.recieptbtn.TabIndex = 12;
            this.recieptbtn.Text = "Reciept";
            this.recieptbtn.UseVisualStyleBackColor = true;
            this.recieptbtn.Click += new System.EventHandler(this.recieptbtn_Click);
            // 
            // signoutbtn
            // 
            this.signoutbtn.Location = new System.Drawing.Point(91, 305);
            this.signoutbtn.Name = "signoutbtn";
            this.signoutbtn.Size = new System.Drawing.Size(75, 23);
            this.signoutbtn.TabIndex = 11;
            this.signoutbtn.Text = "Sign Out";
            this.signoutbtn.UseVisualStyleBackColor = true;
            this.signoutbtn.Click += new System.EventHandler(this.signoutbtn_Click);
            // 
            // totalbtn
            // 
            this.totalbtn.Location = new System.Drawing.Point(41, 146);
            this.totalbtn.Name = "totalbtn";
            this.totalbtn.Size = new System.Drawing.Size(75, 23);
            this.totalbtn.TabIndex = 10;
            this.totalbtn.Text = "Total";
            this.totalbtn.UseVisualStyleBackColor = true;
            this.totalbtn.Click += new System.EventHandler(this.totalbtn_Click);
            // 
            // placeorderlbl
            // 
            this.placeorderlbl.AutoSize = true;
            this.placeorderlbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeorderlbl.Location = new System.Drawing.Point(61, 18);
            this.placeorderlbl.Name = "placeorderlbl";
            this.placeorderlbl.Size = new System.Drawing.Size(118, 24);
            this.placeorderlbl.TabIndex = 3;
            this.placeorderlbl.Text = "Place Order";
            this.placeorderlbl.Click += new System.EventHandler(this.placeorderlbl_Click);
            // 
            // pepsilbl
            // 
            this.pepsilbl.Controls.Add(this.label3);
            this.pepsilbl.Controls.Add(this.pepsitxt);
            this.pepsilbl.Controls.Add(this.label2);
            this.pepsilbl.Controls.Add(this.slicetxt);
            this.pepsilbl.Controls.Add(this.Name);
            this.pepsilbl.Controls.Add(this.icecreamtxt);
            this.pepsilbl.Controls.Add(this.kitkattxt);
            this.pepsilbl.Controls.Add(this.wafferstxt);
            this.pepsilbl.Controls.Add(this.nimkotxt);
            this.pepsilbl.Controls.Add(this.fantatxt);
            this.pepsilbl.Controls.Add(this.sevenuptxt);
            this.pepsilbl.Controls.Add(this.riotxt);
            this.pepsilbl.Controls.Add(this.slantytxt);
            this.pepsilbl.Controls.Add(this.nimkolbl);
            this.pepsilbl.Controls.Add(this.fantalbl);
            this.pepsilbl.Controls.Add(this.sevenuplbl);
            this.pepsilbl.Controls.Add(this.slicelbl);
            this.pepsilbl.Controls.Add(this.icecreamlbl);
            this.pepsilbl.Controls.Add(this.kitkatlbl);
            this.pepsilbl.Controls.Add(this.wafferslbl);
            this.pepsilbl.Controls.Add(this.peplbl);
            this.pepsilbl.Controls.Add(this.riolbl);
            this.pepsilbl.Controls.Add(this.slantylbl);
            this.pepsilbl.Controls.Add(this.nimkochk);
            this.pepsilbl.Controls.Add(this.fantachk);
            this.pepsilbl.Controls.Add(this.sevenupchk);
            this.pepsilbl.Controls.Add(this.Pepsichk);
            this.pepsilbl.Controls.Add(this.wafferschk);
            this.pepsilbl.Controls.Add(this.kitkatchk);
            this.pepsilbl.Controls.Add(this.icecreamchk);
            this.pepsilbl.Controls.Add(this.slicejchk);
            this.pepsilbl.Controls.Add(this.riochk);
            this.pepsilbl.Controls.Add(this.slantychk);
            this.pepsilbl.Controls.Add(this.label7);
            this.pepsilbl.Location = new System.Drawing.Point(4, 90);
            this.pepsilbl.Name = "pepsilbl";
            this.pepsilbl.Size = new System.Drawing.Size(315, 397);
            this.pepsilbl.TabIndex = 5;
            this.pepsilbl.Paint += new System.Windows.Forms.PaintEventHandler(this.pepsilbl_Paint);
            // 
            // pepsitxt
            // 
            this.pepsitxt.Location = new System.Drawing.Point(202, 223);
            this.pepsitxt.Name = "pepsitxt";
            this.pepsitxt.Size = new System.Drawing.Size(75, 20);
            this.pepsitxt.TabIndex = 34;
            // 
            // slicetxt
            // 
            this.slicetxt.Location = new System.Drawing.Point(202, 80);
            this.slicetxt.Name = "slicetxt";
            this.slicetxt.Size = new System.Drawing.Size(75, 20);
            this.slicetxt.TabIndex = 33;
            // 
            // icecreamtxt
            // 
            this.icecreamtxt.Location = new System.Drawing.Point(202, 110);
            this.icecreamtxt.Name = "icecreamtxt";
            this.icecreamtxt.Size = new System.Drawing.Size(75, 20);
            this.icecreamtxt.TabIndex = 32;
            // 
            // kitkattxt
            // 
            this.kitkattxt.Location = new System.Drawing.Point(202, 146);
            this.kitkattxt.Name = "kitkattxt";
            this.kitkattxt.Size = new System.Drawing.Size(75, 20);
            this.kitkattxt.TabIndex = 31;
            // 
            // wafferstxt
            // 
            this.wafferstxt.Location = new System.Drawing.Point(202, 185);
            this.wafferstxt.Name = "wafferstxt";
            this.wafferstxt.Size = new System.Drawing.Size(75, 20);
            this.wafferstxt.TabIndex = 30;
            // 
            // nimkotxt
            // 
            this.nimkotxt.Location = new System.Drawing.Point(202, 352);
            this.nimkotxt.Name = "nimkotxt";
            this.nimkotxt.Size = new System.Drawing.Size(75, 20);
            this.nimkotxt.TabIndex = 29;
            // 
            // fantatxt
            // 
            this.fantatxt.Location = new System.Drawing.Point(202, 302);
            this.fantatxt.Name = "fantatxt";
            this.fantatxt.Size = new System.Drawing.Size(75, 20);
            this.fantatxt.TabIndex = 28;
            // 
            // sevenuptxt
            // 
            this.sevenuptxt.Location = new System.Drawing.Point(202, 265);
            this.sevenuptxt.Name = "sevenuptxt";
            this.sevenuptxt.Size = new System.Drawing.Size(75, 20);
            this.sevenuptxt.TabIndex = 27;
            // 
            // riotxt
            // 
            this.riotxt.Location = new System.Drawing.Point(202, 51);
            this.riotxt.Name = "riotxt";
            this.riotxt.Size = new System.Drawing.Size(75, 20);
            this.riotxt.TabIndex = 26;
            // 
            // slantytxt
            // 
            this.slantytxt.Location = new System.Drawing.Point(202, 22);
            this.slantytxt.Name = "slantytxt";
            this.slantytxt.Size = new System.Drawing.Size(75, 20);
            this.slantytxt.TabIndex = 25;
            // 
            // nimkolbl
            // 
            this.nimkolbl.AutoSize = true;
            this.nimkolbl.Location = new System.Drawing.Point(99, 355);
            this.nimkolbl.Name = "nimkolbl";
            this.nimkolbl.Size = new System.Drawing.Size(41, 13);
            this.nimkolbl.TabIndex = 24;
            this.nimkolbl.Text = "label17";
            this.nimkolbl.Click += new System.EventHandler(this.label17_Click);
            // 
            // fantalbl
            // 
            this.fantalbl.AutoSize = true;
            this.fantalbl.Location = new System.Drawing.Point(96, 313);
            this.fantalbl.Name = "fantalbl";
            this.fantalbl.Size = new System.Drawing.Size(41, 13);
            this.fantalbl.TabIndex = 23;
            this.fantalbl.Text = "label16";
            this.fantalbl.Click += new System.EventHandler(this.milolbl_Click);
            // 
            // sevenuplbl
            // 
            this.sevenuplbl.AutoSize = true;
            this.sevenuplbl.Location = new System.Drawing.Point(96, 268);
            this.sevenuplbl.Name = "sevenuplbl";
            this.sevenuplbl.Size = new System.Drawing.Size(41, 13);
            this.sevenuplbl.TabIndex = 22;
            this.sevenuplbl.Text = "label15";
            this.sevenuplbl.Click += new System.EventHandler(this.tridentlbl_Click);
            // 
            // slicelbl
            // 
            this.slicelbl.AutoSize = true;
            this.slicelbl.Location = new System.Drawing.Point(96, 86);
            this.slicelbl.Name = "slicelbl";
            this.slicelbl.Size = new System.Drawing.Size(41, 13);
            this.slicelbl.TabIndex = 21;
            this.slicelbl.Text = "label14";
            this.slicelbl.Click += new System.EventHandler(this.slicelbl_Click);
            // 
            // icecreamlbl
            // 
            this.icecreamlbl.AutoSize = true;
            this.icecreamlbl.Location = new System.Drawing.Point(96, 117);
            this.icecreamlbl.Name = "icecreamlbl";
            this.icecreamlbl.Size = new System.Drawing.Size(41, 13);
            this.icecreamlbl.TabIndex = 20;
            this.icecreamlbl.Text = "label13";
            this.icecreamlbl.Click += new System.EventHandler(this.cupcakelbl_Click);
            // 
            // kitkatlbl
            // 
            this.kitkatlbl.AutoSize = true;
            this.kitkatlbl.Location = new System.Drawing.Point(96, 153);
            this.kitkatlbl.Name = "kitkatlbl";
            this.kitkatlbl.Size = new System.Drawing.Size(41, 13);
            this.kitkatlbl.TabIndex = 19;
            this.kitkatlbl.Text = "label12";
            this.kitkatlbl.Click += new System.EventHandler(this.kitkatlbl_Click);
            // 
            // wafferslbl
            // 
            this.wafferslbl.AutoSize = true;
            this.wafferslbl.Location = new System.Drawing.Point(96, 192);
            this.wafferslbl.Name = "wafferslbl";
            this.wafferslbl.Size = new System.Drawing.Size(41, 13);
            this.wafferslbl.TabIndex = 18;
            this.wafferslbl.Text = "label11";
            this.wafferslbl.Click += new System.EventHandler(this.wafferslbl_Click);
            // 
            // peplbl
            // 
            this.peplbl.AutoSize = true;
            this.peplbl.Location = new System.Drawing.Point(96, 226);
            this.peplbl.Name = "peplbl";
            this.peplbl.Size = new System.Drawing.Size(41, 13);
            this.peplbl.TabIndex = 17;
            this.peplbl.Text = "label10";
            this.peplbl.Click += new System.EventHandler(this.label10_Click);
            // 
            // riolbl
            // 
            this.riolbl.AutoSize = true;
            this.riolbl.Location = new System.Drawing.Point(96, 54);
            this.riolbl.Name = "riolbl";
            this.riolbl.Size = new System.Drawing.Size(35, 13);
            this.riolbl.TabIndex = 15;
            this.riolbl.Text = "label8";
            this.riolbl.Click += new System.EventHandler(this.oreolbl_Click);
            // 
            // slantylbl
            // 
            this.slantylbl.AutoSize = true;
            this.slantylbl.Location = new System.Drawing.Point(96, 25);
            this.slantylbl.Name = "slantylbl";
            this.slantylbl.Size = new System.Drawing.Size(35, 13);
            this.slantylbl.TabIndex = 14;
            this.slantylbl.Text = "label3";
            this.slantylbl.Click += new System.EventHandler(this.layslbl_Click);
            // 
            // nimkochk
            // 
            this.nimkochk.AutoSize = true;
            this.nimkochk.Location = new System.Drawing.Point(0, 355);
            this.nimkochk.Name = "nimkochk";
            this.nimkochk.Size = new System.Drawing.Size(56, 17);
            this.nimkochk.TabIndex = 13;
            this.nimkochk.Text = "Nimko";
            this.nimkochk.UseVisualStyleBackColor = true;
            this.nimkochk.CheckedChanged += new System.EventHandler(this.freshupchk_CheckedChanged);
            // 
            // fantachk
            // 
            this.fantachk.AutoSize = true;
            this.fantachk.Location = new System.Drawing.Point(-1, 309);
            this.fantachk.Name = "fantachk";
            this.fantachk.Size = new System.Drawing.Size(53, 17);
            this.fantachk.TabIndex = 12;
            this.fantachk.Text = "Fanta";
            this.fantachk.UseVisualStyleBackColor = true;
            this.fantachk.CheckedChanged += new System.EventHandler(this.milochk_CheckedChanged);
            // 
            // sevenupchk
            // 
            this.sevenupchk.AutoSize = true;
            this.sevenupchk.Location = new System.Drawing.Point(-1, 272);
            this.sevenupchk.Name = "sevenupchk";
            this.sevenupchk.Size = new System.Drawing.Size(74, 17);
            this.sevenupchk.TabIndex = 11;
            this.sevenupchk.Text = "Seven Up";
            this.sevenupchk.UseVisualStyleBackColor = true;
            this.sevenupchk.CheckedChanged += new System.EventHandler(this.tridentchk_CheckedChanged);
            // 
            // Pepsichk
            // 
            this.Pepsichk.AutoSize = true;
            this.Pepsichk.Location = new System.Drawing.Point(-1, 226);
            this.Pepsichk.Name = "Pepsichk";
            this.Pepsichk.Size = new System.Drawing.Size(52, 17);
            this.Pepsichk.TabIndex = 10;
            this.Pepsichk.Text = "Pepsi";
            this.Pepsichk.UseVisualStyleBackColor = true;
            this.Pepsichk.CheckedChanged += new System.EventHandler(this.Pepsichk_CheckedChanged);
            // 
            // wafferschk
            // 
            this.wafferschk.AutoSize = true;
            this.wafferschk.Location = new System.Drawing.Point(-1, 188);
            this.wafferschk.Name = "wafferschk";
            this.wafferschk.Size = new System.Drawing.Size(63, 17);
            this.wafferschk.TabIndex = 9;
            this.wafferschk.Text = "Waffers";
            this.wafferschk.UseVisualStyleBackColor = true;
            this.wafferschk.CheckedChanged += new System.EventHandler(this.wafferschk_CheckedChanged);
            // 
            // kitkatchk
            // 
            this.kitkatchk.AutoSize = true;
            this.kitkatchk.Location = new System.Drawing.Point(-3, 149);
            this.kitkatchk.Name = "kitkatchk";
            this.kitkatchk.Size = new System.Drawing.Size(54, 17);
            this.kitkatchk.TabIndex = 8;
            this.kitkatchk.Text = "KitKat";
            this.kitkatchk.UseVisualStyleBackColor = true;
            this.kitkatchk.CheckedChanged += new System.EventHandler(this.kitkatchk_CheckedChanged);
            // 
            // icecreamchk
            // 
            this.icecreamchk.AutoSize = true;
            this.icecreamchk.Location = new System.Drawing.Point(-1, 117);
            this.icecreamchk.Name = "icecreamchk";
            this.icecreamchk.Size = new System.Drawing.Size(74, 17);
            this.icecreamchk.TabIndex = 7;
            this.icecreamchk.Text = "Ice Cream";
            this.icecreamchk.UseVisualStyleBackColor = true;
            this.icecreamchk.CheckedChanged += new System.EventHandler(this.cupcakechk_CheckedChanged);
            // 
            // slicejchk
            // 
            this.slicejchk.AutoSize = true;
            this.slicejchk.Location = new System.Drawing.Point(1, 82);
            this.slicejchk.Name = "slicejchk";
            this.slicejchk.Size = new System.Drawing.Size(51, 17);
            this.slicejchk.TabIndex = 6;
            this.slicejchk.Text = "Juice";
            this.slicejchk.UseVisualStyleBackColor = true;
            this.slicejchk.CheckedChanged += new System.EventHandler(this.slicejchk_CheckedChanged);
            // 
            // riochk
            // 
            this.riochk.AutoSize = true;
            this.riochk.Location = new System.Drawing.Point(1, 50);
            this.riochk.Name = "riochk";
            this.riochk.Size = new System.Drawing.Size(42, 17);
            this.riochk.TabIndex = 5;
            this.riochk.Text = "Rio";
            this.riochk.UseVisualStyleBackColor = true;
            this.riochk.CheckedChanged += new System.EventHandler(this.oreochk_CheckedChanged);
            // 
            // slantychk
            // 
            this.slantychk.AutoSize = true;
            this.slantychk.Location = new System.Drawing.Point(1, 22);
            this.slantychk.Name = "slantychk";
            this.slantychk.Size = new System.Drawing.Size(55, 17);
            this.slantychk.TabIndex = 4;
            this.slantychk.Text = "Slanty";
            this.slantychk.UseVisualStyleBackColor = true;
            this.slantychk.CheckedChanged += new System.EventHandler(this.layschk_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.timelbl);
            this.panel2.Controls.Add(this.datelbl);
            this.panel2.Controls.Add(this.tucshplbl);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(1, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(917, 77);
            this.panel2.TabIndex = 4;
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Location = new System.Drawing.Point(812, 53);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(35, 13);
            this.timelbl.TabIndex = 7;
            this.timelbl.Text = "label6";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(692, 53);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(35, 13);
            this.datelbl.TabIndex = 6;
            this.datelbl.Text = "label5";
            // 
            // tucshplbl
            // 
            this.tucshplbl.AutoSize = true;
            this.tucshplbl.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tucshplbl.Location = new System.Drawing.Point(365, 5);
            this.tucshplbl.Name = "tucshplbl";
            this.tucshplbl.Size = new System.Drawing.Size(138, 42);
            this.tucshplbl.TabIndex = 4;
            this.tucshplbl.Text = "ITEMS";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 387);
            this.panel3.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(3, 3);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(49, 16);
            this.Name.TabIndex = 8;
            this.Name.Text = "Name";
            this.Name.Click += new System.EventHandler(this.Name_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Price";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantity";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order Details";
            // 
            // Displayform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 465);
            this.Controls.Add(this.pepsilbl);
            this.Controls.Add(this.recieptbox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "Displayform";
            this.Text = "Display";
            this.Load += new System.EventHandler(this.Display_Load);
            this.recieptbox.ResumeLayout(false);
            this.recieptbox.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.pepsilbl.ResumeLayout(false);
            this.pepsilbl.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel recieptbox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Button recieptbtn;
        private System.Windows.Forms.Button signoutbtn;
        private System.Windows.Forms.Button totalbtn;
        private System.Windows.Forms.Label placeorderlbl;
        private System.Windows.Forms.Panel pepsilbl;
        private System.Windows.Forms.TextBox pepsitxt;
        private System.Windows.Forms.TextBox slicetxt;
        private System.Windows.Forms.TextBox icecreamtxt;
        private System.Windows.Forms.TextBox kitkattxt;
        private System.Windows.Forms.TextBox wafferstxt;
        private System.Windows.Forms.TextBox nimkotxt;
        private System.Windows.Forms.TextBox fantatxt;
        private System.Windows.Forms.TextBox sevenuptxt;
        private System.Windows.Forms.TextBox riotxt;
        private System.Windows.Forms.TextBox slantytxt;
        private System.Windows.Forms.Label nimkolbl;
        private System.Windows.Forms.Label fantalbl;
        private System.Windows.Forms.Label sevenuplbl;
        private System.Windows.Forms.Label slicelbl;
        private System.Windows.Forms.Label icecreamlbl;
        private System.Windows.Forms.Label kitkatlbl;
        private System.Windows.Forms.Label wafferslbl;
        private System.Windows.Forms.Label peplbl;
        private System.Windows.Forms.Label riolbl;
        private System.Windows.Forms.Label slantylbl;
        private System.Windows.Forms.CheckBox nimkochk;
        private System.Windows.Forms.CheckBox fantachk;
        private System.Windows.Forms.CheckBox sevenupchk;
        private System.Windows.Forms.CheckBox Pepsichk;
        private System.Windows.Forms.CheckBox wafferschk;
        private System.Windows.Forms.CheckBox kitkatchk;
        private System.Windows.Forms.CheckBox icecreamchk;
        private System.Windows.Forms.CheckBox slicejchk;
        private System.Windows.Forms.CheckBox riochk;
        private System.Windows.Forms.CheckBox slantychk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label tucshplbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox recieptbx;
        private System.Windows.Forms.Timer timer1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label1;
    }
}