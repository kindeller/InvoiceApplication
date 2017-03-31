namespace Invoicer
{
    partial class CustomerSelection
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
            this.label1 = new System.Windows.Forms.Label();
            this.selectCustomer = new System.Windows.Forms.Button();
            this.customerListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a Customer...";
            // 
            // selectCustomer
            // 
            this.selectCustomer.Location = new System.Drawing.Point(125, 356);
            this.selectCustomer.Name = "selectCustomer";
            this.selectCustomer.Size = new System.Drawing.Size(75, 23);
            this.selectCustomer.TabIndex = 2;
            this.selectCustomer.Text = "Select";
            this.selectCustomer.UseVisualStyleBackColor = true;
            this.selectCustomer.Click += new System.EventHandler(this.selectCustomer_Click);
            // 
            // customerListBox
            // 
            this.customerListBox.FormattingEnabled = true;
            this.customerListBox.Location = new System.Drawing.Point(12, 37);
            this.customerListBox.Name = "customerListBox";
            this.customerListBox.Size = new System.Drawing.Size(313, 304);
            this.customerListBox.Sorted = true;
            this.customerListBox.TabIndex = 3;
            this.customerListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.customerListBox_ItemCheck);
            // 
            // CustomerSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 391);
            this.Controls.Add(this.customerListBox);
            this.Controls.Add(this.selectCustomer);
            this.Controls.Add(this.label1);
            this.Name = "CustomerSelection";
            this.Text = "CustomerSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectCustomer;
        private System.Windows.Forms.CheckedListBox customerListBox;
    }
}