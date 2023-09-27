namespace sifreUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(txtParola, "Lütfen Şifrenizi belirlerken 6 karakter kullanın ve içinde en az bir sayı ve özel karakter bulundurun.");
        }

        private void txtParola_MouseEnter(object sender, EventArgs e)
        {

        }
        private void txtParola_TextChanged(object sender, EventArgs e)
        {
            string password = txtParola.Text;
            txtParola.BackColor = Color.Yellow;
            txtParola.MaxLength = 25;

            if (IsHighSecurity(password))
            {
                txtSifreDuzeyi.ForeColor = Color.Red;
                txtSifreDuzeyi.Text = "Yüksek Güvenlikli";
            }
            else if (IsMediumSecurity(password))
            {
                txtSifreDuzeyi.ForeColor = Color.Blue;
                txtSifreDuzeyi.Text = "Orta Güvenlikli";
            }
            else
            {
                txtSifreDuzeyi.Text = "Düşük Güvenlikli";
            }
        }

        private bool IsMediumSecurity(string password)
        {
            return password.Length >= 6 && password.Any(char.IsDigit) || password.Any(IsSpecialCharacter);
        }

        private bool IsHighSecurity(string password)
        {
            return password.Length >= 6 && password.Any(char.IsDigit) && password.Any(IsSpecialCharacter);
        }

        private bool IsSpecialCharacter(char c)
        {
            char[] ozelKarater = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+', '-' };
            return ozelKarater.Contains(c);
        }


    }
}