using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConsoleApplication1
{
	public partial class Form1 : Form
	{
        private char repBrk { get; set; }

        private string[] befRep { get; set; }

        private string[] aftRep { get; set; }

		private string par1,par2,par3;

        public Form1()
		{
			InitializeComponent();
		}

		private void btnFormat_Click(object sender, EventArgs e)
		{
			rtbResult.Text = "";
			SqlString str = new SqlString(rtbInput.Lines);
			rtbResult.Text += "class "+ txt1.Text + txt2.Text + "\n{";
           // foreach (string c in str.trim(txt3.Text.Split(char.Parse(txt5.Text)))){
			//	rtbResult.Text += "\n	public string " + c + "{ get; set; }\n";
			//}
			//rtbResult.Text += "}";
		}

		private void button1_Click(object sender, EventArgs e)
		{
            this.setAttr();
			SqlString str = new SqlString(rtbInput.Lines);
            string otp;
            
            //otp = str.removeLineBreak(txt3.Text.Split(repBrk));
            //rtbResult.Text = otp.Substring(0,otp.Length-1)+(txt2.Text!=""?",["+txt2.Text+"])":")");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			rtbResult.Text = "";
			SqlString str = new SqlString(rtbInput.Lines);
			foreach (string c in str.format2())
			{
				rtbResult.Text += "\n	"+ txt2.Text + "." + c + ",";
			}
		}

        private void btnFormat_Click_1(object sender, EventArgs e)
        {
			SqlString input;
            this.setAttr();
            switch (cmbOperation.SelectedIndex)
            {
                case 0:
                    input = new SqlString(rtbInput.Lines);
                    rtbResult.Lines = input.replace(befRep,aftRep);
                    break;
				case 1:
					input = new SqlString(rtbInput.Lines);
					rtbResult.Text = input.removeLineBreak();
					break;
				case 2:
					input = new SqlString(rtbInput.Lines);
					input.text = input.replace(befRep, aftRep);
					rtbResult.Text = input.removeLineBreak();
					break;
				case 3:
					input = new SqlString(rtbInput.Lines);
					rtbResult.Text = input.classToDao(rtbInput.Lines,par2,par1,par3);
					break;
				case 4:
					input = new SqlString(rtbInput.Lines);
					rtbResult.Text = input.classToCaseXml(rtbInput.Lines, par2, par1);
					break;
				default:
                    break;
            }
        }

        private void setAttr()
        {
            repBrk = char.Parse(txt5.Text);
            befRep = txt4.Text.Split(repBrk);
            aftRep = txt3.Text.Split(repBrk);
			par1 = txt1.Text;
			par2 = txt2.Text;
			par3 = txt3.Text;

        }
    }
}
