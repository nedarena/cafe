using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // гор€чие блюда 
        {
            Form2 form2 = new Form2();
            
            form2.checkBox1.Checked = true;
            form2.checkBox2.Checked = true;
            form2.checkBox3.Checked = true;
            form2.checkBox4.Checked = true;
            form2.ShowDialog();
            int a = (int)form2.numericUpDown1.Value;
            int b = (int)form2.numericUpDown2.Value;
            int c = (int)form2.numericUpDown3.Value;
            int d = (int)form2.numericUpDown4.Value;
            if (form2.checkBox1.Checked == true) a *= 440;
            if (form2.checkBox2.Checked == true) b *= 470; 
            if (form2.checkBox3.Checked == true) c *= 630; 
            if (form2.checkBox4.Checked == true) d *= 570;
            textBox1.Clear();
            textBox1.Text = Sum(a, b, c, d).ToString();
        }
        private void button2_Click(object sender, EventArgs e) // роллы
        {//’айбрахманова и захарова
            Form3 form3 = new Form3();
            form3.checkBox1.Checked = true;
            form3.checkBox2.Checked = true;
            form3.checkBox3.Checked = true;
            form3.checkBox4.Checked = true;
            form3.ShowDialog();
            int a = (int)form3.numericUpDown1.Value; 
            int b = (int)form3.numericUpDown2.Value;
            int c = (int)form3.numericUpDown3.Value;
            int d = (int)form3.numericUpDown4.Value;
            if (form3.checkBox1.Checked == true)a *= 390; 
            if (form3.checkBox2.Checked == true)b *= 590;  
            if (form3.checkBox3.Checked == true)c *= 420; 
            if (form3.checkBox4.Checked == true)d *= 770;  
            textBox2.Clear();   
            textBox2.Text = Sum(a, b, c, d).ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.checkBox1.Checked = true;
            form4.checkBox2.Checked = true;
            form4.checkBox3.Checked = true;
            form4.checkBox4.Checked = true;
            form4.ShowDialog();
            int a = (int)form4.numericUpDown1.Value;  
            int b = (int)form4.numericUpDown2.Value;
            int c = (int)form4.numericUpDown3.Value;
            int d = (int)form4.numericUpDown4.Value;
            if (form4.checkBox1.Checked == true) a *= 570; 
            if (form4.checkBox2.Checked == true) b *= 570; 
            if (form4.checkBox3.Checked == true) c *= 440; 
            if (form4.checkBox4.Checked == true) d *= 500;
            textBox3.Clear();
            textBox3.Text = Sum(a, b, c, d).ToString();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.checkBox1.Checked = true;
            form5.checkBox2.Checked = true;
            form5.checkBox3.Checked = true;
            form5.checkBox4.Checked = true;
            form5.ShowDialog();
            int a = (int)form5.numericUpDown1.Value;  
            int b = (int)form5.numericUpDown2.Value;
            int c = (int)form5.numericUpDown3.Value;
            int d = (int)form5.numericUpDown4.Value;
            if (form5.checkBox1.Checked == true) a *= 270; 
            if (form5.checkBox2.Checked == true) b *= 310; 
            if (form5.checkBox3.Checked == true) c *= 290; 
            if (form5.checkBox4.Checked == true) d *= 270;
            textBox4.Clear();
            textBox4.Text = Sum(a, b, c, d).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.checkBox1.Checked = true;
            form6.checkBox2.Checked = true;
            form6.checkBox3.Checked = true;
            form6.checkBox4.Checked = true;
            form6.ShowDialog();
            int a = (int)form6.numericUpDown1.Value;  
            int b = (int)form6.numericUpDown2.Value;
            int c = (int)form6.numericUpDown3.Value;
            int d = (int)form6.numericUpDown4.Value;
            if (form6.checkBox1.Checked == true) a *= 119;
            if (form6.checkBox2.Checked == true) b *= 125;
            if (form6.checkBox3.Checked == true) c *= 125;
            if (form6.checkBox4.Checked == true) d *= 125;
            textBox5.Clear();
            textBox5.Text = Sum(a, b, c, d).ToString();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text); 
            int b = Convert.ToInt32(textBox2.Text); 
            int c = Convert.ToInt32(textBox3.Text); 
            int d = Convert.ToInt32(textBox4.Text); 
            int f = Convert.ToInt32(textBox5.Text); 
            label18.Text = Sum(a, b, c, d, f).ToString() + " –уб";
        }
        private int Sum(int a, int b, int c, int d)
        {
            int z = a + b + c + d;
            return z;
        }
        private int Sum(int a, int b, int c, int d, int f)
        {
            int z = a + b + c + d + f;
            return z;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}