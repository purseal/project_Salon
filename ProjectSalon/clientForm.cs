using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSalon
{
    public partial class ClientForm : Form
    {
        Controller mainController;
        bool edit;
        Client inputClient;
        public ClientForm(Controller controller, bool edit, Client client)
        {
            InitializeComponent();
            mainController = controller;
            this.edit = edit;
            inputClient = client;
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (textBoxClientName.Text.Length < 1 || !textBoxClientBirth.MaskCompleted)
            {
                MessageBox.Show("Необходимо полностью заполнить все поля", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            if (edit)
            {
                String name = textBoxClientName.Text;
                String birth = textBoxClientBirth.Text;
                String number = textBoxClientNumber.Text;
                mainController.changeClient(name, birth, number, inputClient);
                this.Close();
            }
            else
            {
                String name = textBoxClientName.Text;
                String birth = textBoxClientBirth.Text;
                String number = textBoxClientNumber.Text;
                mainController.registerClient(name, birth, number);
                this.Close();
            }
            
        }

        private void textBoxClientBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
