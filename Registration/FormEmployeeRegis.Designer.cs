namespace Supermarket.Registration
{
    partial class FormEmployeeRegis
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.maskBirth = new System.Windows.Forms.MaskedTextBox();
            this.dateJoining = new System.Windows.Forms.DateTimePicker();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblJoining = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbJob = new System.Windows.Forms.ComboBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.bntAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bntClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bntClear);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.bntAdd);
            this.panel1.Controls.Add(this.txtAccount);
            this.panel1.Controls.Add(this.cmbJob);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddCity);
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Controls.Add(this.cmbCity);
            this.panel1.Controls.Add(this.maskBirth);
            this.panel1.Controls.Add(this.dateJoining);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.lblContact);
            this.panel1.Controls.Add(this.lblJoining);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.lblBirth);
            this.panel1.Controls.Add(this.lblCity);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 575);
            this.panel1.TabIndex = 0;
            // 
            // btnAddCity
            // 
            this.btnAddCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCity.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddCity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCity.Location = new System.Drawing.Point(426, 152);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(115, 23);
            this.btnAddCity.TabIndex = 8;
            this.btnAddCity.Text = "Adicionar";
            this.btnAddCity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddCity.UseCompatibleTextRendering = true;
            this.btnAddCity.UseVisualStyleBackColor = true;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outros"});
            this.cmbGender.Location = new System.Drawing.Point(248, 230);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(163, 23);
            this.cmbGender.TabIndex = 5;
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(248, 152);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(163, 23);
            this.cmbCity.TabIndex = 3;
            // 
            // maskBirth
            // 
            this.maskBirth.Location = new System.Drawing.Point(248, 191);
            this.maskBirth.Name = "maskBirth";
            this.maskBirth.Size = new System.Drawing.Size(163, 23);
            this.maskBirth.TabIndex = 4;
            // 
            // dateJoining
            // 
            this.dateJoining.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateJoining.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateJoining.Location = new System.Drawing.Point(248, 261);
            this.dateJoining.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dateJoining.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateJoining.Name = "dateJoining";
            this.dateJoining.Size = new System.Drawing.Size(111, 25);
            this.dateJoining.TabIndex = 6;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(248, 304);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(163, 23);
            this.txtContact.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(248, 114);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(415, 23);
            this.txtName.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(248, 76);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(163, 23);
            this.txtID.TabIndex = 1;
            // 
            // lblContact
            // 
            this.lblContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContact.Location = new System.Drawing.Point(35, 302);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(69, 21);
            this.lblContact.TabIndex = 0;
            this.lblContact.Text = "Contato";
            // 
            // lblJoining
            // 
            this.lblJoining.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJoining.AutoSize = true;
            this.lblJoining.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJoining.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblJoining.Location = new System.Drawing.Point(35, 264);
            this.lblJoining.Name = "lblJoining";
            this.lblJoining.Size = new System.Drawing.Size(141, 21);
            this.lblJoining.TabIndex = 0;
            this.lblJoining.Text = "Data de Admissão";
            // 
            // lblGender
            // 
            this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGender.Location = new System.Drawing.Point(35, 226);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(46, 21);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Sexo";
            // 
            // lblBirth
            // 
            this.lblBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBirth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBirth.Location = new System.Drawing.Point(35, 188);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(134, 21);
            this.lblBirth.TabIndex = 0;
            this.lblBirth.Text = "Data Nascimento";
            // 
            // lblCity
            // 
            this.lblCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCity.Location = new System.Drawing.Point(35, 150);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(61, 21);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "Cidade";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(35, 112);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(168, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome do Funcionário";
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblID.Location = new System.Drawing.Point(35, 74);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(139, 21);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID do Funcionário";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "N° da Conta";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(337, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(204, 45);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Cadastro de Funcionário";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(35, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cargo";
            // 
            // cmbJob
            // 
            this.cmbJob.FormattingEnabled = true;
            this.cmbJob.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outros"});
            this.cmbJob.Location = new System.Drawing.Point(248, 380);
            this.cmbJob.Name = "cmbJob";
            this.cmbJob.Size = new System.Drawing.Size(163, 23);
            this.cmbJob.TabIndex = 12;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(248, 342);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(163, 23);
            this.txtAccount.TabIndex = 13;
            // 
            // bntAdd
            // 
            this.bntAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntAdd.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntAdd.Location = new System.Drawing.Point(248, 423);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(115, 23);
            this.bntAdd.TabIndex = 14;
            this.bntAdd.Text = "Cadastrar";
            this.bntAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntAdd.UseCompatibleTextRendering = true;
            this.bntAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(382, 423);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.UseCompatibleTextRendering = true;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // bntClear
            // 
            this.bntClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntClear.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntClear.Location = new System.Drawing.Point(517, 423);
            this.bntClear.Name = "bntClear";
            this.bntClear.Size = new System.Drawing.Size(115, 23);
            this.bntClear.TabIndex = 16;
            this.bntClear.Text = "Limpar";
            this.bntClear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntClear.UseCompatibleTextRendering = true;
            this.bntClear.UseVisualStyleBackColor = true;
            // 
            // FormEmployeeRegis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(918, 575);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmployeeRegis";
            this.Text = "FormEmployeeRegis";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnAddCity;
        private ComboBox cmbGender;
        private ComboBox cmbCity;
        private MaskedTextBox maskBirth;
        private DateTimePicker dateJoining;
        private TextBox txtContact;
        private TextBox txtName;
        private TextBox txtID;
        private Label lblContact;
        private Label lblJoining;
        private Label lblGender;
        private Label lblBirth;
        private Label lblCity;
        private Label lblName;
        private Label lblID;
        private TextBox txtAccount;
        private ComboBox cmbJob;
        private Label label2;
        private Label lblTitle;
        private Label label1;
        private Button bntClear;
        private Button btnCancel;
        private Button bntAdd;
    }
}