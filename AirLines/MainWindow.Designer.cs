namespace AirLines
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassengerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAuth = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comboBoxAdd = new System.Windows.Forms.ComboBox();
            this.buttonArrivalTime = new System.Windows.Forms.Button();
            this.buttonLifetime = new System.Windows.Forms.Button();
            this.buttonIncome = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PassengerID,
            this.FlightID});
            this.dataGridView1.Location = new System.Drawing.Point(25, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(944, 707);
            this.dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // PassengerID
            // 
            this.PassengerID.DataPropertyName = "PasName";
            this.PassengerID.HeaderText = "PassengerID";
            this.PassengerID.Name = "PassengerID";
            // 
            // FlightID
            // 
            this.FlightID.DataPropertyName = "FlightID";
            this.FlightID.HeaderText = "FlightID";
            this.FlightID.Name = "FlightID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.labelAuth);
            this.panel1.Location = new System.Drawing.Point(-3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1577, 75);
            this.panel1.TabIndex = 2;
            // 
            // labelAuth
            // 
            this.labelAuth.AutoSize = true;
            this.labelAuth.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuth.ForeColor = System.Drawing.Color.White;
            this.labelAuth.Location = new System.Drawing.Point(554, 0);
            this.labelAuth.Name = "labelAuth";
            this.labelAuth.Size = new System.Drawing.Size(389, 71);
            this.labelAuth.TabIndex = 1;
            this.labelAuth.Text = "POLETAERO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.labelRole);
            this.panel2.Controls.Add(this.labelUsername);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1002, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 195);
            this.panel2.TabIndex = 5;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRole.ForeColor = System.Drawing.Color.White;
            this.labelRole.Location = new System.Drawing.Point(25, 130);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(67, 25);
            this.labelRole.TabIndex = 2;
            this.labelRole.Text = "Роль:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(25, 83);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(203, 25);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Имя пользователя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(88, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Добро пожаловать!";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.panelAdmin);
            this.panel3.Controls.Add(this.buttonArrivalTime);
            this.panel3.Controls.Add(this.buttonLifetime);
            this.panel3.Controls.Add(this.buttonIncome);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(1002, 324);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 492);
            this.panel3.TabIndex = 6;
            // 
            // panelAdmin
            // 
            this.panelAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAdmin.Controls.Add(this.label6);
            this.panelAdmin.Controls.Add(this.label3);
            this.panelAdmin.Controls.Add(this.buttonAdd);
            this.panelAdmin.Controls.Add(this.comboBoxAdd);
            this.panelAdmin.Location = new System.Drawing.Point(30, 63);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(402, 209);
            this.panelAdmin.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Location = new System.Drawing.Point(72, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Панель администратора";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Добавление записи в таблицу:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(228, 80);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(159, 29);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // comboBoxAdd
            // 
            this.comboBoxAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAdd.FormattingEnabled = true;
            this.comboBoxAdd.Items.AddRange(new object[] {
            "Commander",
            "Flight",
            "Passenger",
            "Plane",
            "Role",
            "Route",
            "Ticket",
            "Users"});
            this.comboBoxAdd.Location = new System.Drawing.Point(21, 80);
            this.comboBoxAdd.Name = "comboBoxAdd";
            this.comboBoxAdd.Size = new System.Drawing.Size(201, 28);
            this.comboBoxAdd.TabIndex = 5;
            // 
            // buttonArrivalTime
            // 
            this.buttonArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonArrivalTime.Location = new System.Drawing.Point(19, 314);
            this.buttonArrivalTime.Name = "buttonArrivalTime";
            this.buttonArrivalTime.Size = new System.Drawing.Size(413, 50);
            this.buttonArrivalTime.TabIndex = 3;
            this.buttonArrivalTime.Text = "Время прибытия рейсов";
            this.buttonArrivalTime.UseVisualStyleBackColor = true;
            this.buttonArrivalTime.Click += new System.EventHandler(this.buttonArrivalTime_Click);
            // 
            // buttonLifetime
            // 
            this.buttonLifetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLifetime.Location = new System.Drawing.Point(19, 370);
            this.buttonLifetime.Name = "buttonLifetime";
            this.buttonLifetime.Size = new System.Drawing.Size(413, 50);
            this.buttonLifetime.TabIndex = 2;
            this.buttonLifetime.Text = "Срок эксплуатации техники";
            this.buttonLifetime.UseVisualStyleBackColor = true;
            this.buttonLifetime.Click += new System.EventHandler(this.buttonLifetime_Click);
            // 
            // buttonIncome
            // 
            this.buttonIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonIncome.Location = new System.Drawing.Point(19, 426);
            this.buttonIncome.Name = "buttonIncome";
            this.buttonIncome.Size = new System.Drawing.Size(413, 50);
            this.buttonIncome.TabIndex = 1;
            this.buttonIncome.Text = "Доходы компании";
            this.buttonIncome.UseVisualStyleBackColor = true;
            this.buttonIncome.Click += new System.EventHandler(this.buttonIncome_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(70, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(317, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Доступный функционал";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(25, 832);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1321, 91);
            this.panel4.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Commander",
            "Flight",
            "Passenger",
            "Plane",
            "Role",
            "Route",
            "Ticket",
            "Users"});
            this.comboBox1.Location = new System.Drawing.Point(264, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(216, 32);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Таблица для просмотра:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(43, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Таблица для просмотра:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AirLines.Properties.Resources.planeLogo;
            this.pictureBox1.Location = new System.Drawing.Point(1352, 832);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1474, 935);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "POLET";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassengerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAuth;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonIncome;
        private System.Windows.Forms.Button buttonLifetime;
        private System.Windows.Forms.Button buttonArrivalTime;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox comboBoxAdd;
    }
}