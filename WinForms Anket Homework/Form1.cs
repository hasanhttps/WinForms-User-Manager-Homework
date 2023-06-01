using Anket.models;
using static Anket.models.JsonHandling;

namespace Anket {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void SaveButton_Click(object sender, EventArgs e) {
            Gender gender = new();
            if (Male.Checked == true) {
                gender = Gender.Male;
            }
            else gender = Gender.Female;

            try {
                Anket.models.Anket anket = new(nameBox.Text, surnameBox.Text, fathernameBox.Text,
                    countryBox.Text, cityBox.Text, phoneBox.Text, Birthday.Text, gender);
                WriteData<Anket.models.Anket>(anket, nameBox.Text);
                MessageBox.Show("You have saved successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadButton_Click(object sender, EventArgs e) {
            Anket.models.Anket anket;
            try {
                anket = ReadData<Anket.models.Anket>(loadBox.Text)!;
                nameBox.Text = anket.Name;
                surnameBox.Text = anket.Surname;
                fathernameBox.Text = anket.FatherName;
                countryBox.Text = anket.Country;
                cityBox.Text = anket.City;
                phoneBox.Text = anket.Phone;
                Birthday.Text = anket.Datetime;
                if (anket.Gender == Gender.Male) Male.Checked = true;
                else Female.Checked = true;
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}