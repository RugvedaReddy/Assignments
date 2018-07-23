namespace ADOExample
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblname = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblmember = new System.Windows.Forms.Label();
            this.lblshoppingpreference = new System.Windows.Forms.Label();
            this.lblcod = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.cbgender = new System.Windows.Forms.ComboBox();
            this.rbfree = new System.Windows.Forms.RadioButton();
            this.rbpaid = new System.Windows.Forms.RadioButton();
            this.clbshop = new System.Windows.Forms.CheckedListBox();
            this.cbcod = new System.Windows.Forms.CheckBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.rb1 = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.lbselect = new System.Windows.Forms.ListBox();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.registerShoppingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainingDBDataSet = new ADOExample.TrainingDBDataSet();
            this.btnDelete = new System.Windows.Forms.Button();
            this.registerShoppingTableAdapter = new ADOExample.TrainingDBDataSetTableAdapters.RegisterShoppingTableAdapter();
            this.btnupdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(128, 129);
            this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(104, 20);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Enter Name";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(128, 213);
            this.lblgender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(125, 20);
            this.lblgender.TabIndex = 1;
            this.lblgender.Text = "Select Gender";
            // 
            // lblmember
            // 
            this.lblmember.AutoSize = true;
            this.lblmember.Location = new System.Drawing.Point(128, 303);
            this.lblmember.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmember.Name = "lblmember";
            this.lblmember.Size = new System.Drawing.Size(162, 20);
            this.lblmember.TabIndex = 2;
            this.lblmember.Text = "Select Membership";
            // 
            // lblshoppingpreference
            // 
            this.lblshoppingpreference.AutoSize = true;
            this.lblshoppingpreference.Location = new System.Drawing.Point(128, 398);
            this.lblshoppingpreference.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblshoppingpreference.Name = "lblshoppingpreference";
            this.lblshoppingpreference.Size = new System.Drawing.Size(234, 20);
            this.lblshoppingpreference.TabIndex = 3;
            this.lblshoppingpreference.Text = "Select Shopping Preference";
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Location = new System.Drawing.Point(128, 513);
            this.lblcod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(101, 20);
            this.lblcod.TabIndex = 4;
            this.lblcod.Text = "Prefer COD";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(128, 602);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(135, 20);
            this.lblpassword.TabIndex = 5;
            this.lblpassword.Text = "Enter Password";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(417, 128);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 26);
            this.txtname.TabIndex = 6;
            // 
            // cbgender
            // 
            this.cbgender.FormattingEnabled = true;
            this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbgender.Location = new System.Drawing.Point(417, 213);
            this.cbgender.Name = "cbgender";
            this.cbgender.Size = new System.Drawing.Size(121, 28);
            this.cbgender.TabIndex = 7;
            this.cbgender.Text = "select";
            // 
            // rbfree
            // 
            this.rbfree.AutoSize = true;
            this.rbfree.Location = new System.Drawing.Point(367, 303);
            this.rbfree.Name = "rbfree";
            this.rbfree.Size = new System.Drawing.Size(59, 24);
            this.rbfree.TabIndex = 8;
            this.rbfree.TabStop = true;
            this.rbfree.Text = "free";
            this.rbfree.UseVisualStyleBackColor = true;
            // 
            // rbpaid
            // 
            this.rbpaid.AutoSize = true;
            this.rbpaid.Location = new System.Drawing.Point(544, 301);
            this.rbpaid.Name = "rbpaid";
            this.rbpaid.Size = new System.Drawing.Size(61, 24);
            this.rbpaid.TabIndex = 9;
            this.rbpaid.TabStop = true;
            this.rbpaid.Text = "paid";
            this.rbpaid.UseVisualStyleBackColor = true;
            // 
            // clbshop
            // 
            this.clbshop.FormattingEnabled = true;
            this.clbshop.Items.AddRange(new object[] {
            "Apparels",
            "Cosmetics",
            "Shoes",
            "Mobiles",
            "Laptops",
            "Electronic Gadgets",
            "Kitchen Items"});
            this.clbshop.Location = new System.Drawing.Point(404, 398);
            this.clbshop.Name = "clbshop";
            this.clbshop.Size = new System.Drawing.Size(120, 88);
            this.clbshop.TabIndex = 10;
            // 
            // cbcod
            // 
            this.cbcod.AutoSize = true;
            this.cbcod.Location = new System.Drawing.Point(417, 513);
            this.cbcod.Name = "cbcod";
            this.cbcod.Size = new System.Drawing.Size(76, 24);
            this.cbcod.TabIndex = 11;
            this.cbcod.Text = "COD?";
            this.cbcod.UseVisualStyleBackColor = true;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(404, 591);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(100, 26);
            this.txtpassword.TabIndex = 12;
            // 
            // rb1
            // 
            this.rb1.Location = new System.Drawing.Point(178, 659);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(75, 23);
            this.rb1.TabIndex = 13;
            this.rb1.Text = "register";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.Click += new System.EventHandler(this.rb1_Click);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(305, 659);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(75, 23);
            this.btnselect.TabIndex = 14;
            this.btnselect.Text = "select";
            this.btnselect.UseVisualStyleBackColor = true;
            this.btnselect.Click += new System.EventHandler(this.btnselect_Click);
            // 
            // lbselect
            // 
            this.lbselect.FormattingEnabled = true;
            this.lbselect.ItemHeight = 20;
            this.lbselect.Location = new System.Drawing.Point(798, 104);
            this.lbselect.Name = "lbselect";
            this.lbselect.Size = new System.Drawing.Size(120, 84);
            this.lbselect.TabIndex = 15;
            // 
            // cbID
            // 
            this.cbID.DataSource = this.registerShoppingBindingSource;
            this.cbID.DisplayMember = "Name";
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(417, 44);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(121, 28);
            this.cbID.TabIndex = 16;
            this.cbID.ValueMember = "Id";
            // 
            // registerShoppingBindingSource
            // 
            this.registerShoppingBindingSource.DataMember = "RegisterShopping";
            this.registerShoppingBindingSource.DataSource = this.trainingDBDataSet;
            // 
            // trainingDBDataSet
            // 
            this.trainingDBDataSet.DataSetName = "TrainingDBDataSet";
            this.trainingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(429, 659);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // registerShoppingTableAdapter
            // 
            this.registerShoppingTableAdapter.ClearBeforeFill = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(548, 661);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(99, 23);
            this.btnupdate.TabIndex = 18;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 709);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.lbselect);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.cbcod);
            this.Controls.Add(this.clbshop);
            this.Controls.Add(this.rbpaid);
            this.Controls.Add(this.rbfree);
            this.Controls.Add(this.cbgender);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.lblshoppingpreference);
            this.Controls.Add(this.lblmember);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblname);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registerShoppingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblmember;
        private System.Windows.Forms.Label lblshoppingpreference;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.ComboBox cbgender;
        private System.Windows.Forms.RadioButton rbfree;
        private System.Windows.Forms.RadioButton rbpaid;
        private System.Windows.Forms.CheckedListBox clbshop;
        private System.Windows.Forms.CheckBox cbcod;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button rb1;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.ListBox lbselect;
        private System.Windows.Forms.ComboBox cbID;
        private System.Windows.Forms.Button btnDelete;
        private TrainingDBDataSet trainingDBDataSet;
        private System.Windows.Forms.BindingSource registerShoppingBindingSource;
        private TrainingDBDataSetTableAdapters.RegisterShoppingTableAdapter registerShoppingTableAdapter;
        private System.Windows.Forms.Button btnupdate;
    }
}

