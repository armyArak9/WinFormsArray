namespace WinFormsArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] student = new string[5];
            student[0] = "test1";
            student[1] = "test2";
            student[2] = "test3";
            student[3] = "test4";
            student[4] = "test5";
            string test = "";

            for (int i = 0; i < student.Length; i++) // student.Lenght หาจำนวนรอบ
            {
                test += student[i] + Environment.NewLine;
            }
            MessageBox.Show(test);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Fruits = { "test1", "test2", "test3", "test4", "test5" };
            string myFruits = "";
            foreach (string f in Fruits) //Array แบบไม่ต้องรู้จำนวนรอบ
            {
                myFruits += f + ", " + Environment.NewLine;
            }
            MessageBox.Show(myFruits, "Mytest");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines; //นำข้อมูลแต่ละบรรทัลไปใส่ในArray
            string result = "";
            foreach (string s in data)
            {
                if (s != "")
                {
                    result += s + Environment.NewLine;
                }

            }
            label1.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines;
            string result = "";
            int x = 0;
            int Sum = 0;
            foreach (var str in data)
            {

                if (int.TryParse(str, out x))
                {
                    result += x.ToString() + Environment.NewLine;
                    Sum += x;
                }

            }
            MessageBox.Show(Sum.ToString(), "ผลราม");
            label1.Text = result;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[,] student = new string[3, 2];
            student[0, 0] = "test1";
            student[0, 1] = "test2";
            student[1, 0] = "test3";
            student[1, 1] = "test4";
            student[2, 0] = "test5";
            student[2, 1] = "test6";
            string ResultData = "";
            int m = student.GetLength(0);
            int n = student.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    if (j == 0)
                    {
                        ResultData += student[i, j] + "-";
                    }
                    if (j != 0)
                    {
                        ResultData += student[i, j];
                    }

                }
                ResultData += Environment.NewLine;
            }
            MessageBox.Show(ResultData, "แสดงข้อมูลใน Array 2 มิติ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Fruits = { "ส้ม", "ทุเรียน", "มะกอก", "บักแง้ว", "หมากเม่า" };
            comboBox1.Items.AddRange(Fruits);
            listBox1.Items.AddRange(Fruits);
            checkedListBox1.Items.AddRange(Fruits);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBox1.SelectedIndex.ToString() + "-";
            str += comboBox1.SelectedItem;
            MessageBox.Show(str);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = listBox1.SelectedIndex.ToString();
            str += comboBox1.SelectedItem;
            MessageBox.Show(str);
        }
    }
}
