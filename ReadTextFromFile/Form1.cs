using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadTextFromFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Label title = new Label();
        TextBox userInput = new TextBox();
        Button InputText = new Button();
        Label confirmation = new Label();

        private void Form1_Load(object sender, EventArgs e)
        {
            title.SetBounds(10, 10, 180, 25);
            title.Text = "Input Text To Insert Into File";
            this.Controls.Add(title);

            userInput.SetBounds(10, 45, 180, 25);
            this.Controls.Add(userInput);

            InputText.SetBounds(10, 80, 180, 25);
            InputText.Text = "Input text";
            this.InputText.Click += new System.EventHandler(this.InputText_Click);
            this.Controls.Add(InputText);

            confirmation.SetBounds(10, 115, 180, 25);
            confirmation.Text = "";
            this.Controls.Add(confirmation);
        }

        private void InputText_Click(object sender, EventArgs e)
        {
            confirmation.Text = "Task complete? Or is it?";
            userInput.Text = "";
            // NO u CHANGING FOR GITHUN
        }

    }
}
