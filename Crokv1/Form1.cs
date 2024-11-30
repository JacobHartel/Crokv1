namespace Crokv1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class SettingsForm : Form
        {
            public SettingsForm()
            {
                InitializeComponent(saveButton);
            }

            private void InitializeComponent(Button saveButton)
            {
                this.Text = "Settings";
                this.Width = 250;
                this.Height = 200;

                Button btnSave = new Button();
                {
                    Text = "Save";
                    Location = new Point(100, 120);
                    Size = new Size(70, 30);
                }

                btnSave.Click += (sender, e) => MessageBox.Show("Settings Saved");

                this.Controls.Add(btnSave);
            }

           

        }
    
    }
}
