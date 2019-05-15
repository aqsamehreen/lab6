using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary4;

namespace WindowsFormsApp2
{
    public partial class Displayform : Form
    {
        public Displayform()
        {
            InitializeComponent();
        }

        private void taxtxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void layschk_CheckedChanged(object sender, EventArgs e)
        {
            if (slantychk.Checked == true)
            {
                slantytxt.Enabled = true;
                slantytxt.Text = "";
            }
            if (slantychk.Checked == false)
            {
                slantytxt.Enabled = false;
                slantytxt.Text = "0";
            }
        }

        private void oreochk_CheckedChanged(object sender, EventArgs e)
        {
            if (riochk.Checked == true)
            {
                riotxt.Enabled = true;
                riotxt.Text = "";
            }
            if (riochk.Checked == false)
            {
                riotxt.Enabled = false;
                riotxt.Text = "0";
            }
        }

        private void slicejchk_CheckedChanged(object sender, EventArgs e)
        {
            if (slicejchk.Checked == true)
            {
                slicetxt.Enabled = true;
                slicetxt.Text = "";
            }
            if (slicejchk.Checked == false)
            {
                slicetxt.Enabled = false;
               slicetxt.Text = "0";
            }
        }

        private void cupcakechk_CheckedChanged(object sender, EventArgs e)
        {
            if (icecreamchk.Checked == true)
            {
                icecreamtxt.Enabled = true;
                icecreamtxt.Text = "";
            }
            if (icecreamchk.Checked == false)
            {
                icecreamtxt.Enabled = false;
                icecreamtxt.Text = "0";
            }
        }

        private void kitkatchk_CheckedChanged(object sender, EventArgs e)
        {
            if (kitkatchk.Checked == true)
            {
                kitkattxt.Enabled = true;
                kitkattxt.Text = "";
            }
            if (kitkatchk.Checked == false)
            {
                kitkattxt.Enabled = false;
                kitkattxt.Text = "0";
            }
        }

        private void Display_Load(object sender, EventArgs e)
        {
            datelbl.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

            slantytxt.Text = "0";
            riotxt.Text = "0";
            slicetxt.Text = "0";
            icecreamtxt.Text = "0";
            kitkattxt.Text = "0";
            wafferstxt.Text = "0";
            pepsitxt.Text = "0";
            sevenuptxt.Text = "0";
            fantatxt.Text = "0";
            nimkotxt.Text = "0";

            slantytxt.Enabled = false;
            riotxt.Enabled = false;
            slicetxt.Enabled = false;
            icecreamtxt.Enabled = false;
            kitkattxt.Enabled = false;
            wafferstxt.Enabled = false;
            pepsitxt.Enabled = false;
            sevenuptxt.Enabled = false;
            fantatxt.Enabled = false;
            nimkotxt.Enabled = false;

            slantychk.Checked = false;
            riochk.Checked = false;
            slicejchk.Checked = false;
            icecreamchk.Checked = false;
            kitkatchk.Checked = false;
            wafferschk.Checked = false;
            Pepsichk.Checked = false;
            sevenupchk.Checked = false;
            fantachk.Checked = false;
            nimkochk.Checked = false;

            slantylbl.Text = "30";
            riolbl.Text = "20";
            slicelbl.Text = "25";
            kitkatlbl.Text = "70";
            icecreamlbl.Text = "10";
            wafferslbl.Text = "20";
            peplbl.Text = "50";
            fantalbl.Text = "50";
            sevenuplbl.Text = "50";
            nimkolbl.Text = "50";

        }

        private void label17_Click(object sender, EventArgs e)
        {
            nimkolbl.Text = "50";
        }

        private void wafferschk_CheckedChanged(object sender, EventArgs e)
        {
            if (wafferschk.Checked == true)
            {
                wafferstxt.Enabled = true;
                wafferstxt.Text = "";
            }
            if (wafferschk.Checked == false)
            {
                wafferstxt.Enabled = false;
                wafferstxt.Text = "";
            }
        }

        private void Pepsichk_CheckedChanged(object sender, EventArgs e)
        {
            if (Pepsichk.Checked == true)
            {
                pepsitxt.Enabled = true;
                pepsitxt.Text = "";
            }
            if (Pepsichk.Checked == false)
            {
                pepsitxt.Enabled = false;
                pepsitxt.Text = "0";
            }
        }

        private void tridentchk_CheckedChanged(object sender, EventArgs e)
        {
            if (sevenupchk.Checked == true)
            {
                sevenuptxt.Enabled = true;
                sevenuptxt.Text = "";
            }
            if (sevenupchk.Checked == false)
            {
                sevenuptxt.Enabled = false;
                sevenuptxt.Text = "0";
            }
        }

        private void milochk_CheckedChanged(object sender, EventArgs e)
        {
            if (fantachk.Checked == true)
            {
                fantatxt.Enabled = true;
                fantatxt.Text = "";
            }
            if (fantachk.Checked == false)
            {
                fantatxt.Enabled = false;
                fantatxt.Text = "0";
            }
        }

        private void freshupchk_CheckedChanged(object sender, EventArgs e)
        {
            if (nimkochk.Checked == true)
            {
                nimkotxt.Enabled = true;
                nimkotxt.Text = "";
            }
            if (nimkochk.Checked == false)
            {
                nimkotxt.Enabled = false;
                nimkotxt.Text = "0";
            }
        }

        private void recieptbtn_Click(object sender, EventArgs e)
        {
            recieptbx.Clear();
            recieptbx.AppendText(Environment.NewLine);
            recieptbx.AppendText("******************************************************************"+Environment.NewLine);
            recieptbx.AppendText("\t\t\t"+"Food Items"+Environment.NewLine);
            recieptbx.AppendText("******************************************************************" + Environment.NewLine);
            recieptbx.AppendText("\tItems\tPrice per unit\tQuantity" + Environment.NewLine);
            recieptbx.AppendText("slanty\t\t"+slantylbl.Text+"\t\t"+slantytxt.Text.ToString() + Environment.NewLine);
            recieptbx.AppendText("rio\t\t" + riolbl.Text + "\t\t" + riotxt.Text.ToString() + Environment.NewLine);
            recieptbx.AppendText("juice\t\t" + slicelbl.Text + "\t\t" + slicetxt.Text.ToString() + Environment.NewLine);
            recieptbx.AppendText("icecreamcake\t\t" + icecreamlbl.Text + "\t\t" + icecreamtxt.Text.ToString() + Environment.NewLine);
            recieptbx.AppendText("kitkat\t\t" + kitkatlbl.Text + "\t\t" + kitkattxt.Text.ToString() + Environment.NewLine);
            recieptbx.AppendText("waffers\t\t" + wafferslbl.Text + "\t\t" + wafferstxt.Text.ToString() + Environment.NewLine);
            recieptbx.AppendText("pepsi\t\t" + peplbl.Text + "\t\t" + pepsitxt.Text.ToString() + Environment.NewLine);
            recieptbx.AppendText("seven up\t\t" + sevenuplbl.Text + "\t\t" + sevenuptxt.Text.ToString() + Environment.NewLine);
            recieptbx.AppendText("fanta\t\t" + fantalbl.Text + "\t\t" + fantatxt.Text.ToString() + Environment.NewLine);
            recieptbx.AppendText("nimko\t\t" + nimkolbl.Text + "\t\t" + nimkotxt.Text.ToString() + Environment.NewLine);
            recieptbx.AppendText("****************************************************************" + Environment.NewLine);
            recieptbx.AppendText("Tax \t\t\t\t" + tax.Text+ Environment.NewLine);
            recieptbx.AppendText("Subtotal \t\t\t\t" + subtotal.Text+ Environment.NewLine);
            recieptbx.AppendText("Total \t\t\t\t" + total.Text+Environment.NewLine);
            
            recieptbx.AppendText("*****************************************************************" + Environment.NewLine);
            recieptbx.AppendText( timelbl.Text+"\t" + datelbl.Text);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void totalbtn_Click(object sender, EventArgs e)
        {
           double tax = 1.0;
            double slanty, icecream, slicejuice, sevenup, nimko, fanta, rio, kitkat, waffers, pepsi;
            slanty = Convert.ToDouble(slantytxt.Text);
            icecream = Convert.ToDouble(icecreamtxt.Text);
            slicejuice = Convert.ToDouble(slicetxt.Text);
             sevenup = Convert.ToDouble(sevenuptxt.Text);
            nimko = Convert.ToDouble(nimkotxt.Text);
             fanta = Convert.ToDouble(fantatxt.Text);
            rio = Convert.ToDouble(riotxt.Text);
            kitkat = Convert.ToDouble(kitkattxt.Text);
            waffers = Convert.ToDouble(wafferstxt.Text);
            pepsi = Convert.ToDouble(pepsitxt.Text);

           double nsslanty = Convert.ToDouble(slantylbl.Text);
            double nicecream = Convert.ToDouble(icecreamlbl.Text);
            double nslicejuice = Convert.ToDouble(slicelbl.Text);
            double ntrident = Convert.ToDouble(sevenuplbl.Text);
            double nfreshup = Convert.ToDouble(nimkolbl.Text);
            double nfanta = Convert.ToDouble(fantalbl.Text);
            double noreo = Convert.ToDouble(riolbl.Text);
            double nkitkat = Convert.ToDouble(kitkatlbl.Text);
            double nwaffers = Convert.ToDouble(wafferslbl.Text);
            double npepsi = Convert.ToDouble(peplbl.Text);
         
            double sttl = (slanty*nsslanty) + (icecream*nicecream) + (slicejuice*nslicejuice) + (icecream*ntrident)
                + (sevenup*nfreshup) + (pepsi*npepsi) + (fanta*nfreshup) + (kitkat*nkitkat) + (waffers*nwaffers) + (rio*noreo);
            subtotal.Text = sttl.ToString();
            double t = Convert.ToDouble(tax);
            double ttotal = sttl + t;
            total.Text = ttotal.ToString();
  
            
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            slantytxt.Text = "0";
            riotxt.Text = "0";
            slicetxt.Text = "0";
            icecreamtxt.Text = "0";
            kitkattxt.Text = "0";
            wafferstxt.Text = "0";
            pepsitxt.Text = "0";
            sevenuptxt.Text = "0";
            fantatxt.Text = "0";
            nimkotxt.Text = "0";

            slantytxt.Enabled = false;
            riotxt.Enabled = false;
            slicetxt.Enabled = false;
            icecreamtxt.Enabled = false;
            kitkattxt.Enabled = false;
            wafferstxt.Enabled = false;
            pepsitxt.Enabled = false;
            sevenuptxt.Enabled = false;
            fantatxt.Enabled = false;
            nimkotxt.Enabled = false;

            slantychk.Checked = false;
            riochk.Checked = false;
            slicejchk.Checked = false;
            icecreamchk.Checked = false;
            kitkatchk.Checked = false;
            wafferschk.Checked = false;
            Pepsichk.Checked = false;
            sevenupchk.Checked = false;
            fantachk.Checked = false;
            nimkochk.Checked = false;
            recieptbx.Clear();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signoutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void subtotallbl_Click(object sender, EventArgs e)
        {

        }

        private void subtotaltxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void totaltxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void layslbl_Click(object sender, EventArgs e)
        {
            slantylbl.Text = "30";
        }

        private void oreolbl_Click(object sender, EventArgs e)
        {
            riolbl.Text = "20";
            

        }

        private void slicelbl_Click(object sender, EventArgs e)
        {
            slicelbl.Text = "25";
           
        }

        private void cupcakelbl_Click(object sender, EventArgs e)
        {
            icecreamlbl.Text = "10";
        }

        private void kitkatlbl_Click(object sender, EventArgs e)
        {
            kitkatlbl.Text = "70";
        }

        private void wafferslbl_Click(object sender, EventArgs e)
        {
            wafferslbl.Text = "20";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            peplbl.Text = "50";
        }

        private void tridentlbl_Click(object sender, EventArgs e)
        {
            sevenuplbl.Text = "50";

        }

        private void milolbl_Click(object sender, EventArgs e)
        {
            fantalbl.Text = "50";
        }

        private void namelbl_Click(object sender, EventArgs e)
        {
           
        }

        private void counterlbl_Click(object sender, EventArgs e)
        {
           
        }

        private void recieptbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void tax_Click(object sender, EventArgs e)
        {
           
        }

        private void tax_Click_1(object sender, EventArgs e)
        {
          
        }

        private void subtotal_Click(object sender, EventArgs e)
        {

        }

        private void total_Click(object sender, EventArgs e)
        {

        }

        private void taxlbl_Click(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pepsilbl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void placeorderlbl_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
