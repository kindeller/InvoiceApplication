namespace Invoicer
{
    partial class Invoicer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainProgram = new System.Windows.Forms.Panel();
            this.invoicePanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.addInvoiceButton = new System.Windows.Forms.Button();
            this.CreatePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.addAddress = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerNameTextbox = new System.Windows.Forms.TextBox();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.Search = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchResultsTitle = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.customerNameResults = new System.Windows.Forms.TextBox();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainProgram.SuspendLayout();
            this.invoicePanel.SuspendLayout();
            this.CreatePanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.searchPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(90, 195);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(100, 20);
            this.usernameField.TabIndex = 0;
            this.usernameField.Text = "lister";
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(90, 221);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(100, 20);
            this.passwordField.TabIndex = 1;
            this.passwordField.Text = "1472";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(66, 247);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password: ";
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.pictureBox1);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.usernameField);
            this.loginPanel.Controls.Add(this.passwordField);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Location = new System.Drawing.Point(459, 114);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(209, 287);
            this.loginPanel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Invoicer.Properties.Resources.clipboard;
            this.pictureBox1.Location = new System.Drawing.Point(22, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // mainProgram
            // 
            this.mainProgram.Controls.Add(this.panel1);
            this.mainProgram.Controls.Add(this.invoicePanel);
            this.mainProgram.Controls.Add(this.CreatePanel);
            this.mainProgram.Controls.Add(this.menuStrip1);
            this.mainProgram.Controls.Add(this.searchPanel);
            this.mainProgram.Location = new System.Drawing.Point(12, 12);
            this.mainProgram.Name = "mainProgram";
            this.mainProgram.Size = new System.Drawing.Size(1129, 512);
            this.mainProgram.TabIndex = 6;
            this.mainProgram.Visible = false;
            // 
            // invoicePanel
            // 
            this.invoicePanel.Controls.Add(this.label7);
            this.invoicePanel.Controls.Add(this.button1);
            this.invoicePanel.Controls.Add(this.label8);
            this.invoicePanel.Controls.Add(this.textBox5);
            this.invoicePanel.Controls.Add(this.textBox6);
            this.invoicePanel.Controls.Add(this.label9);
            this.invoicePanel.Controls.Add(this.textBox7);
            this.invoicePanel.Controls.Add(this.label10);
            this.invoicePanel.Controls.Add(this.textBox8);
            this.invoicePanel.Controls.Add(this.label11);
            this.invoicePanel.Controls.Add(this.textBox9);
            this.invoicePanel.Controls.Add(this.label12);
            this.invoicePanel.Controls.Add(this.addInvoiceButton);
            this.invoicePanel.Location = new System.Drawing.Point(13, 27);
            this.invoicePanel.Name = "invoicePanel";
            this.invoicePanel.Size = new System.Drawing.Size(439, 214);
            this.invoicePanel.TabIndex = 13;
            this.invoicePanel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Create Invoice";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 31);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Decription:";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox5.Location = new System.Drawing.Point(76, 130);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(134, 67);
            this.textBox5.TabIndex = 9;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "My Description";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(324, 89);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Payment Date:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(110, 89);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Cost:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(324, 46);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(230, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Description:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(110, 46);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Customer Number:";
            // 
            // addInvoiceButton
            // 
            this.addInvoiceButton.Location = new System.Drawing.Point(331, 174);
            this.addInvoiceButton.Name = "addInvoiceButton";
            this.addInvoiceButton.Size = new System.Drawing.Size(93, 23);
            this.addInvoiceButton.TabIndex = 0;
            this.addInvoiceButton.Text = "Add Invoice";
            this.addInvoiceButton.UseVisualStyleBackColor = true;
            this.addInvoiceButton.Click += new System.EventHandler(this.addInvoiceButton_Click);
            // 
            // CreatePanel
            // 
            this.CreatePanel.Controls.Add(this.titleLabel);
            this.CreatePanel.Controls.Add(this.addAddress);
            this.CreatePanel.Controls.Add(this.label6);
            this.CreatePanel.Controls.Add(this.textBox4);
            this.CreatePanel.Controls.Add(this.textBox3);
            this.CreatePanel.Controls.Add(this.label5);
            this.CreatePanel.Controls.Add(this.textBox2);
            this.CreatePanel.Controls.Add(this.label4);
            this.CreatePanel.Controls.Add(this.textBox1);
            this.CreatePanel.Controls.Add(this.label3);
            this.CreatePanel.Controls.Add(this.CustomerNameTextbox);
            this.CreatePanel.Controls.Add(this.CustomerNameLabel);
            this.CreatePanel.Controls.Add(this.addCustomerButton);
            this.CreatePanel.Location = new System.Drawing.Point(13, 27);
            this.CreatePanel.Name = "CreatePanel";
            this.CreatePanel.Size = new System.Drawing.Size(439, 214);
            this.CreatePanel.TabIndex = 8;
            this.CreatePanel.Visible = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(15, 10);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(145, 20);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "Create Customer";
            // 
            // addAddress
            // 
            this.addAddress.Location = new System.Drawing.Point(19, 156);
            this.addAddress.Name = "addAddress";
            this.addAddress.Size = new System.Drawing.Size(45, 31);
            this.addAddress.TabIndex = 11;
            this.addAddress.Text = "Add";
            this.addAddress.UseVisualStyleBackColor = true;
            this.addAddress.Click += new System.EventHandler(this.addAddress_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox4.Location = new System.Drawing.Point(76, 130);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(134, 67);
            this.textBox4.TabIndex = 9;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "42 WALLABY WAY, SYDNEY";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(324, 89);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mobile Telephone: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Home Telephone: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(324, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name: ";
            // 
            // CustomerNameTextbox
            // 
            this.CustomerNameTextbox.Location = new System.Drawing.Point(110, 46);
            this.CustomerNameTextbox.Name = "CustomerNameTextbox";
            this.CustomerNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.CustomerNameTextbox.TabIndex = 2;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(16, 49);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(63, 13);
            this.CustomerNameLabel.TabIndex = 1;
            this.CustomerNameLabel.Text = "First Name: ";
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(331, 174);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(93, 23);
            this.addCustomerButton.TabIndex = 0;
            this.addCustomerButton.Text = "Add Customer";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.createToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1129, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerNumberToolStripMenuItem,
            this.customerNameToolStripMenuItem,
            this.invoiceToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.searchToolStripMenuItem.Text = "Search...";
            // 
            // customerNumberToolStripMenuItem
            // 
            this.customerNumberToolStripMenuItem.Name = "customerNumberToolStripMenuItem";
            this.customerNumberToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.customerNumberToolStripMenuItem.Text = "Customer Number";
            this.customerNumberToolStripMenuItem.Click += new System.EventHandler(this.customerNumberToolStripMenuItem_Click);
            // 
            // customerNameToolStripMenuItem
            // 
            this.customerNameToolStripMenuItem.Name = "customerNameToolStripMenuItem";
            this.customerNameToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.customerNameToolStripMenuItem.Text = "Customer Name";
            this.customerNameToolStripMenuItem.Click += new System.EventHandler(this.customerNameToolStripMenuItem_Click);
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            this.invoiceToolStripMenuItem.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.invoiceToolStripMenuItem1});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.createToolStripMenuItem.Text = "Create...";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // invoiceToolStripMenuItem1
            // 
            this.invoiceToolStripMenuItem1.Name = "invoiceToolStripMenuItem1";
            this.invoiceToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.invoiceToolStripMenuItem1.Text = "Invoice";
            this.invoiceToolStripMenuItem1.Click += new System.EventHandler(this.invoiceToolStripMenuItem1_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.Search);
            this.searchPanel.Controls.Add(this.searchLabel);
            this.searchPanel.Controls.Add(this.searchBox);
            this.searchPanel.Location = new System.Drawing.Point(13, 27);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(319, 50);
            this.searchPanel.TabIndex = 6;
            this.searchPanel.Visible = false;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(218, 11);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(87, 23);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(12, 16);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(65, 13);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "searchLabel";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(112, 13);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 20);
            this.searchBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.customerNameResults);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.searchResultsTitle);
            this.panel1.Location = new System.Drawing.Point(13, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 410);
            this.panel1.TabIndex = 14;
            // 
            // searchResultsTitle
            // 
            this.searchResultsTitle.AutoSize = true;
            this.searchResultsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResultsTitle.Location = new System.Drawing.Point(19, 19);
            this.searchResultsTitle.Name = "searchResultsTitle";
            this.searchResultsTitle.Size = new System.Drawing.Size(132, 20);
            this.searchResultsTitle.TabIndex = 0;
            this.searchResultsTitle.Text = "Search Results";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Customer Name:";
            // 
            // customerNameResults
            // 
            this.customerNameResults.Location = new System.Drawing.Point(110, 55);
            this.customerNameResults.Name = "customerNameResults";
            this.customerNameResults.Size = new System.Drawing.Size(100, 20);
            this.customerNameResults.TabIndex = 2;
            // 
            // Invoicer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 536);
            this.Controls.Add(this.mainProgram);
            this.Controls.Add(this.loginPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Invoicer";
            this.Text = "Invoicer";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainProgram.ResumeLayout(false);
            this.mainProgram.PerformLayout();
            this.invoicePanel.ResumeLayout(false);
            this.invoicePanel.PerformLayout();
            this.CreatePanel.ResumeLayout(false);
            this.CreatePanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel mainProgram;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem1;
        private System.Windows.Forms.Panel CreatePanel;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CustomerNameTextbox;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Button addAddress;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel invoicePanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button addInvoiceButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox customerNameResults;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label searchResultsTitle;
    }
}

