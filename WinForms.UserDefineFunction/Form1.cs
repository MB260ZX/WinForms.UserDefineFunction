namespace WinForms.UserDefineFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string firstname;
        string lastname;
        string username;
        string password;

        private void checkName(string name)//สร้างฟังก์ชันตรวจสอบชื่อ
        {
            if (string.IsNullOrWhiteSpace(name))//ตรวจสอบค่าว่างโดยใช้คำสั่งIsNullOrEmpty
            {
                MessageBox.Show("กำหนดให้ชื่อไม่เป็นค่าว่าง");
                return;//ออกจากฟังก์ชันทันที
            }
            if (name.Length < 2)
            {
                MessageBox.Show("กำหนดให้ชื่อมีความยาวอย่างน้อย 2 ตัวอักษร");
            }
        }

        private void checkfirstname()
        {
            firstname = textBox1.Text;
            if (string.IsNullOrWhiteSpace(firstname))//ตรวจสอบค่าว่างโดยใช้คำสั่งIsNullOrEmpty
            {
                MessageBox.Show("กำหนดให้ชื่อไม่เป็นค่าว่าง");
                textBox1.Focus();
                return;//ออกจากฟังก์ชันทันที
            }
            if (firstname.Length < 2)
            {
                MessageBox.Show("กำหนดให้ชื่อมีความยาวอย่างน้อย 2 ตัวอักษร");
                textBox1.Focus();

            }
        }
        private void checklastname()
        {
            lastname = textBox5.Text;
            if (string.IsNullOrWhiteSpace(lastname))
            {
                MessageBox.Show("กำหนดให้นามสกุลไม่เป็นค่าว่าง");
                textBox5.Focus();
                return;
            }
            if (lastname.Length < 2)
            {
                MessageBox.Show("กำหนดให้นามสกุลมีความยาวอย่างน้อย 2 ตัวอักษร");
                textBox5.Focus();
            }
        }   
        private void checkusername()
        {
            username = textBox2.Text;
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("กำหนดให้ชื่อผู้ใช้ไม่เป็นค่าว่าง");
                textBox2.Focus();
                return;
            }
            if (username.Length > 20)
            {
                MessageBox.Show("กำหนดให้ชื่อผู้ใช้มีความยาวอย่างน้อย 20 ตัวอักษร");
                textBox2.Focus();
            }
        }
        private void checkpassword(TextBox Password,TextBox cofirmPassword)
        {
           
            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(cofirmPassword.Text))
            {
                MessageBox.Show("กำหนดให้รหัสผ่านไม่เป็นค่าว่าง");
                textBox3.Focus();
                return;
            }
            if (Password.Text.Length < 8 )
            {
                MessageBox.Show("กำหนดให้รหัสผ่านมีความยาวอย่างน้อย 8 ตัวอักษร");
                textBox3.Focus();
            }
            if (Password.Text != cofirmPassword.Text)
            {
                MessageBox.Show("รหัสผ่านไม่ตรงกัน");
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            // checkfirstname(); 
            // checklastname();
            firstname = textBox1.Text;
            lastname = textBox5.Text;
            checkName(firstname);//เรียกใช้ฟังก์ชันในcheckName
            checkName(lastname);//เรียกใช้ฟังก์ชันตรวจสอบนามสกุลในcheckName
            checkusername();
            checkpassword(textBox3, textBox4);
        }
    }
}
