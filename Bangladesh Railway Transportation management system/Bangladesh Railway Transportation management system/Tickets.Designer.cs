namespace Bangladesh_Railway_Transportation_management_system
{
    partial class Tickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tickets));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.traindestinationcomboBox = new System.Windows.Forms.ComboBox();
            this.book = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trainnocombobox = new System.Windows.Forms.ComboBox();
            this.bangladeshRailwayManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangladeshRailwayManagementDataSet = new Bangladesh_Railway_Transportation_management_system.BangladeshRailwayManagementDataSet();
            this.bangladeshRailwayManagementDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.emailtxtbox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangladeshRailwayManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangladeshRailwayManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangladeshRailwayManagementDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tickets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bangladesh Railway";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Train Destination :";
            // 
            // traindestinationcomboBox
            // 
            this.traindestinationcomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.traindestinationcomboBox.FormattingEnabled = true;
            this.traindestinationcomboBox.Items.AddRange(new object[] {
            "Khulna",
            "Rajshahi",
            "Sylhet",
            "Dhaka",
            "Chittagong",
            "Barisal"});
            this.traindestinationcomboBox.Location = new System.Drawing.Point(538, 100);
            this.traindestinationcomboBox.Name = "traindestinationcomboBox";
            this.traindestinationcomboBox.Size = new System.Drawing.Size(157, 21);
            this.traindestinationcomboBox.TabIndex = 12;
            this.traindestinationcomboBox.SelectedIndexChanged += new System.EventHandler(this.traindestinationcomboBox_SelectedIndexChanged_1);
            // 
            // book
            // 
            this.book.BackColor = System.Drawing.Color.Green;
            this.book.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book.Location = new System.Drawing.Point(422, 220);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(93, 41);
            this.book.TabIndex = 17;
            this.book.Text = "Book";
            this.book.UseVisualStyleBackColor = false;
            this.book.Click += new System.EventHandler(this.book_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Red;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(521, 220);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(93, 41);
            this.back.TabIndex = 18;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(188, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 152);
            this.dataGridView1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Booked Information : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Train No. :";
            // 
            // trainnocombobox
            // 
            this.trainnocombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.trainnocombobox.FormattingEnabled = true;
            this.trainnocombobox.Items.AddRange(new object[] {
            "1001",
            "1002",
            "1003",
            "1004",
            "1005",
            "1006",
            "1007",
            "1234"});
            this.trainnocombobox.Location = new System.Drawing.Point(162, 105);
            this.trainnocombobox.Name = "trainnocombobox";
            this.trainnocombobox.Size = new System.Drawing.Size(157, 21);
            this.trainnocombobox.TabIndex = 23;
            this.trainnocombobox.SelectedIndexChanged += new System.EventHandler(this.trainnocombobox_SelectedIndexChanged);
            // 
            // bangladeshRailwayManagementDataSetBindingSource
            // 
            this.bangladeshRailwayManagementDataSetBindingSource.DataSource = this.bangladeshRailwayManagementDataSet;
            this.bangladeshRailwayManagementDataSetBindingSource.Position = 0;
            // 
            // bangladeshRailwayManagementDataSet
            // 
            this.bangladeshRailwayManagementDataSet.DataSetName = "BangladeshRailwayManagementDataSet";
            this.bangladeshRailwayManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangladeshRailwayManagementDataSetBindingSource1
            // 
            this.bangladeshRailwayManagementDataSetBindingSource1.DataSource = this.bangladeshRailwayManagementDataSet;
            this.bangladeshRailwayManagementDataSetBindingSource1.Position = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Bangladesh_Railway_Transportation_management_system.Properties.Resources._3166614;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "User Name  :";
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(162, 147);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.ReadOnly = true;
            this.usernametxt.Size = new System.Drawing.Size(157, 20);
            this.usernametxt.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(446, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Email  :";
            // 
            // emailtxtbox
            // 
            this.emailtxtbox.Location = new System.Drawing.Point(538, 147);
            this.emailtxtbox.Name = "emailtxtbox";
            this.emailtxtbox.ReadOnly = true;
            this.emailtxtbox.Size = new System.Drawing.Size(157, 20);
            this.emailtxtbox.TabIndex = 27;
            this.emailtxtbox.TextChanged += new System.EventHandler(this.emailtxtbox_TextChanged_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(620, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 41);
            this.button1.TabIndex = 28;
            this.button1.Text = "Cancel Booking";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.emailtxtbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trainnocombobox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.book);
            this.Controls.Add(this.traindestinationcomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Tickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Tickets_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangladeshRailwayManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangladeshRailwayManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangladeshRailwayManagementDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox traindestinationcomboBox;
        private System.Windows.Forms.Button book;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox trainnocombobox;
        private System.Windows.Forms.BindingSource bangladeshRailwayManagementDataSetBindingSource;
        private BangladeshRailwayManagementDataSet bangladeshRailwayManagementDataSet;
        private System.Windows.Forms.BindingSource bangladeshRailwayManagementDataSetBindingSource1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailtxtbox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Button button1;
    }
}