using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicer
{
    public partial class Invoicer : Form
    {
        WindowManager WindowManagement;
        private enum DatabaseSearches
        {
            customerName = 0,
            customerNumber = 1,
            invoiceNumber = 2
        }

        DatabaseSearches currentDBSelection;

        public Invoicer()
        {
            InitializeComponent();

            //assign initial window          WindowManagement = new WindowManager(loginPanel);

            //List and add all windows from the app that will be allowed to switch too. 
            //to improve modularity this could be changed to automatically assign new panels on initiation.
            WindowManagement.addToPanelList(mainProgram);
            WindowManagement.addToPanelList(searchPanel);
            WindowManagement.addToPanelList(CreatePanel);

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            //Perform DB check to ensure login details are correct.
            loginPanel.Visible = false;
            mainProgram.Visible = true;
        }

        private void Logout()
        {
            mainProgram.Visible = false;
            loginPanel.Visible = true;
        }

        private void setSearchPanel(string s)
        {
            if (!searchPanel.Visible)
            {
                WindowManagement.showPanel(searchPanel);
                searchLabel.Text = s;
            }
            else
            {
                searchLabel.Text = s;
            }
        }

        private void customerNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setSearchPanel("Customer Number: ");
            currentDBSelection = DatabaseSearches.customerNumber;
        }

        private void customerNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setSearchPanel("Customer Name: ");
            currentDBSelection = DatabaseSearches.customerName;
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setSearchPanel("Invoice Number: ");
            currentDBSelection = DatabaseSearches.invoiceNumber;
        }


        private void Search_Click(object sender, EventArgs e)
        {
            searchDatabase(currentDBSelection);
        }


        private void searchDatabase(DatabaseSearches searchType)
        {

            switch (searchType)
            {
                case DatabaseSearches.customerName:
                    MessageBox.Show("Customer Name");
                    break;

                case DatabaseSearches.customerNumber:
                    MessageBox.Show("Customer Number");
                    break;

                case DatabaseSearches.invoiceNumber:
                    MessageBox.Show("Invoice Number");
                    break;
            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void addAddress_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this will display a separate window for adding address separated into fields for number, first, second line town and zip/post code.");
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowManagement.showPanel(CreatePanel);
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created Customer with customer number of: A001");
        }

        private void invoiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WindowManagement.showPanel(invoicePanel);
        }

        private void addInvoiceButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created invoice for customer");
        }
    }



    public partial class createPanel : Panel
    {
        
        public createPanel()
        {

        }

        public void setPanelText()
        {

        }
    }



// *************************************(New Class)***************************************** //

    public partial class WindowManager
    {
        Panel currentPanel;

        List<Panel> panelList = new List<Panel>();

        public WindowManager(Panel startingPanel)
        {
            MessageBox.Show("Window Manager Initialised.");
            addToPanelList(startingPanel);
            startingPanel.Visible = true;
            currentPanel = startingPanel;

        }

        public bool addToPanelList(Panel panel)
        {

            if (panelList.Contains(panel))
            {
                //already added panel
                return false;
            }else
            {
                panelList.Add(panel);
                return true;
            }
        }

        public bool removeFromPanelList(Panel panel)
        {
            if (panelList.Contains(panel))
            {
               panelList.Remove(panel);
               return true;
            }else
            {
                //cannot remove - doesnt exist
                return false;
            }
        }

        public void showPanel(Panel panel)
        {
            currentPanel.Visible = false;
            currentPanel = panel;
            panel.Visible = true;

        }

        public void showPanel(Panel panel, bool showOnly)
        {
            if (showOnly)
            {
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }

        }


    }
}
