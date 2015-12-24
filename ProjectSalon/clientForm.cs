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
        public ClientForm(Controller controller, bool edit)
        {
            InitializeComponent();
            mainController = controller;
            this.edit = edit;
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                String name = textBoxClientName.Text;
                String birth = textBoxClientBirth.Text;
                String number = textBoxClientNumber.Text;
                mainController.changeClient(name, birth, number, mainController.getClient(number));
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
    }
}
