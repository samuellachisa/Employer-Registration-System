namespace Employer_Registration_System
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employementDBDataSet1 = new Employer_Registration_System.employementDBDataSet1();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lastN = new System.Windows.Forms.Label();
            this.firstN = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.HNMsg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.KebeleMsg = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NatMsg = new System.Windows.Forms.Label();
            this.CityMsg = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SalaryMsg = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.AccountMsg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Boxmsg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sexMsg = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.phoneMsg = new System.Windows.Forms.Label();
            this.EmailMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.employeTblTableAdapter = new Employer_Registration_System.employementDBDataSet1TableAdapters.EmployeTblTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employementDBDataSet1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 547);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeTblBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(459, 537);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dataGridView_CellStateChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // employeTblBindingSource
            // 
            this.employeTblBindingSource.DataMember = "EmployeTbl";
            this.employeTblBindingSource.DataSource = this.employementDBDataSet1;
            // 
            // employementDBDataSet1
            // 
            this.employementDBDataSet1.DataSetName = "employementDBDataSet1";
            this.employementDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.54945F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.45055F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(639, 32);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(89, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(289, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(466, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lastN);
            this.panel2.Controls.Add(this.firstN);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(658, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 577);
            this.panel2.TabIndex = 2;
            // 
            // lastN
            // 
            this.lastN.AutoSize = true;
            this.lastN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastN.ForeColor = System.Drawing.Color.Red;
            this.lastN.Location = new System.Drawing.Point(201, 183);
            this.lastN.Name = "lastN";
            this.lastN.Size = new System.Drawing.Size(0, 20);
            this.lastN.TabIndex = 4;
            // 
            // firstN
            // 
            this.firstN.AutoSize = true;
            this.firstN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstN.ForeColor = System.Drawing.Color.Red;
            this.firstN.Location = new System.Drawing.Point(140, 183);
            this.firstN.Name = "firstN";
            this.firstN.Size = new System.Drawing.Size(0, 20);
            this.firstN.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(131, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Contact Info";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.HNMsg);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.KebeleMsg);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.NatMsg);
            this.panel4.Controls.Add(this.CityMsg);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(23, 437);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(372, 131);
            this.panel4.TabIndex = 3;
            // 
            // HNMsg
            // 
            this.HNMsg.AutoSize = true;
            this.HNMsg.BackColor = System.Drawing.Color.White;
            this.HNMsg.ForeColor = System.Drawing.Color.Red;
            this.HNMsg.Location = new System.Drawing.Point(140, 98);
            this.HNMsg.Name = "HNMsg";
            this.HNMsg.Size = new System.Drawing.Size(0, 13);
            this.HNMsg.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "House No : ";
            // 
            // KebeleMsg
            // 
            this.KebeleMsg.AutoSize = true;
            this.KebeleMsg.BackColor = System.Drawing.Color.White;
            this.KebeleMsg.ForeColor = System.Drawing.Color.Red;
            this.KebeleMsg.Location = new System.Drawing.Point(140, 71);
            this.KebeleMsg.Name = "KebeleMsg";
            this.KebeleMsg.Size = new System.Drawing.Size(0, 13);
            this.KebeleMsg.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Kebele : ";
            // 
            // NatMsg
            // 
            this.NatMsg.AutoSize = true;
            this.NatMsg.BackColor = System.Drawing.Color.White;
            this.NatMsg.ForeColor = System.Drawing.Color.Red;
            this.NatMsg.Location = new System.Drawing.Point(140, 14);
            this.NatMsg.Name = "NatMsg";
            this.NatMsg.Size = new System.Drawing.Size(0, 13);
            this.NatMsg.TabIndex = 2;
            // 
            // CityMsg
            // 
            this.CityMsg.AutoSize = true;
            this.CityMsg.BackColor = System.Drawing.Color.White;
            this.CityMsg.ForeColor = System.Drawing.Color.Red;
            this.CityMsg.Location = new System.Drawing.Point(140, 41);
            this.CityMsg.Name = "CityMsg";
            this.CityMsg.Size = new System.Drawing.Size(0, 13);
            this.CityMsg.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nationality : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "City : ";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.SalaryMsg);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.AccountMsg);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.Boxmsg);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.sexMsg);
            this.panel3.Controls.Add(this.label);
            this.panel3.Controls.Add(this.phoneMsg);
            this.panel3.Controls.Add(this.EmailMsg);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(23, 238);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 180);
            this.panel3.TabIndex = 3;
            // 
            // SalaryMsg
            // 
            this.SalaryMsg.AutoSize = true;
            this.SalaryMsg.BackColor = System.Drawing.Color.White;
            this.SalaryMsg.ForeColor = System.Drawing.Color.Red;
            this.SalaryMsg.Location = new System.Drawing.Point(140, 124);
            this.SalaryMsg.Name = "SalaryMsg";
            this.SalaryMsg.Size = new System.Drawing.Size(0, 13);
            this.SalaryMsg.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Salary:";
            // 
            // AccountMsg
            // 
            this.AccountMsg.BackColor = System.Drawing.Color.White;
            this.AccountMsg.ForeColor = System.Drawing.Color.Red;
            this.AccountMsg.Location = new System.Drawing.Point(140, 151);
            this.AccountMsg.Name = "AccountMsg";
            this.AccountMsg.Size = new System.Drawing.Size(0, 13);
            this.AccountMsg.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Account No ";
            // 
            // Boxmsg
            // 
            this.Boxmsg.AutoSize = true;
            this.Boxmsg.BackColor = System.Drawing.Color.White;
            this.Boxmsg.ForeColor = System.Drawing.Color.Red;
            this.Boxmsg.Location = new System.Drawing.Point(140, 98);
            this.Boxmsg.Name = "Boxmsg";
            this.Boxmsg.Size = new System.Drawing.Size(0, 13);
            this.Boxmsg.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "P. box no : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // sexMsg
            // 
            this.sexMsg.AutoSize = true;
            this.sexMsg.BackColor = System.Drawing.Color.White;
            this.sexMsg.ForeColor = System.Drawing.Color.Red;
            this.sexMsg.Location = new System.Drawing.Point(140, 71);
            this.sexMsg.Name = "sexMsg";
            this.sexMsg.Size = new System.Drawing.Size(0, 13);
            this.sexMsg.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(16, 71);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(32, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Sex:";
            // 
            // phoneMsg
            // 
            this.phoneMsg.AutoSize = true;
            this.phoneMsg.BackColor = System.Drawing.Color.White;
            this.phoneMsg.ForeColor = System.Drawing.Color.Red;
            this.phoneMsg.Location = new System.Drawing.Point(140, 14);
            this.phoneMsg.Name = "phoneMsg";
            this.phoneMsg.Size = new System.Drawing.Size(0, 13);
            this.phoneMsg.TabIndex = 2;
            this.phoneMsg.Click += new System.EventHandler(this.label17_Click);
            // 
            // EmailMsg
            // 
            this.EmailMsg.AutoSize = true;
            this.EmailMsg.BackColor = System.Drawing.Color.White;
            this.EmailMsg.ForeColor = System.Drawing.Color.Red;
            this.EmailMsg.Location = new System.Drawing.Point(140, 41);
            this.EmailMsg.Name = "EmailMsg";
            this.EmailMsg.Size = new System.Drawing.Size(0, 13);
            this.EmailMsg.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email : ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(674, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // employeTblTableAdapter
            // 
            this.employeTblTableAdapter.ClearBeforeFill = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 656);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employer Registration System";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employementDBDataSet1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label firstN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label HNMsg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label KebeleMsg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label NatMsg;
        private System.Windows.Forms.Label CityMsg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Boxmsg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sexMsg;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label phoneMsg;
        private System.Windows.Forms.Label EmailMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lastN;
        private System.Windows.Forms.Label AccountMsg;
        private System.Windows.Forms.Label label4;
        private employementDBDataSet1 employementDBDataSet1;
        private System.Windows.Forms.BindingSource employeTblBindingSource;
        private employementDBDataSet1TableAdapters.EmployeTblTableAdapter employeTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label SalaryMsg;
        private System.Windows.Forms.Label label12;
    }
}

