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
            this.bntClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.cmbJob = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.maskBirth = new System.Windows.Forms.MaskedTextBox();
            this.dateJoining = new System.Windows.Forms.DateTimePicker();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblJoining = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCity = new System.Windows.Forms.Button();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCity);
            this.panel1.Controls.Add(this.btnCity);
            this.panel1.Controls.Add(this.cmbCity);
            this.panel1.Controls.Add(this.bntClear);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSignUp);
            this.panel1.Controls.Add(this.txtAccount);
            this.panel1.Controls.Add(this.cmbJob);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Controls.Add(this.cmbState);
            this.panel1.Controls.Add(this.maskBirth);
            this.panel1.Controls.Add(this.dateJoining);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblContact);
            this.panel1.Controls.Add(this.lblJoining);
            this.panel1.Controls.Add(this.lblGender);
            this.panel1.Controls.Add(this.lblBirth);
            this.panel1.Controls.Add(this.lblState);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 575);
            this.panel1.TabIndex = 0;
            // 
            // bntClear
            // 
            this.bntClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntClear.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bntClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntClear.Location = new System.Drawing.Point(507, 376);
            this.bntClear.Name = "bntClear";
            this.bntClear.Size = new System.Drawing.Size(115, 23);
            this.bntClear.TabIndex = 16;
            this.bntClear.Text = "Limpar";
            this.bntClear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bntClear.UseCompatibleTextRendering = true;
            this.bntClear.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(372, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.UseCompatibleTextRendering = true;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSignUp
            // 
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSignUp.Location = new System.Drawing.Point(238, 376);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(115, 23);
            this.btnSignUp.TabIndex = 14;
            this.btnSignUp.Text = "Cadastrar";
            this.btnSignUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSignUp.UseCompatibleTextRendering = true;
            this.btnSignUp.UseVisualStyleBackColor = true;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(238, 295);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(163, 23);
            this.txtAccount.TabIndex = 13;
            // 
            // cmbJob
            // 
            this.cmbJob.FormattingEnabled = true;
            this.cmbJob.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outros"});
            this.cmbJob.Location = new System.Drawing.Point(238, 333);
            this.cmbJob.Name = "cmbJob";
            this.cmbJob.Size = new System.Drawing.Size(163, 23);
            this.cmbJob.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(25, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cargo";
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(25, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "N° da Conta";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outros"});
            this.cmbGender.Location = new System.Drawing.Point(238, 183);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(163, 23);
            this.cmbGender.TabIndex = 5;
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(238, 105);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(163, 23);
            this.cmbState.TabIndex = 3;
            // 
            // maskBirth
            // 
            this.maskBirth.Location = new System.Drawing.Point(238, 144);
            this.maskBirth.Name = "maskBirth";
            this.maskBirth.Size = new System.Drawing.Size(163, 23);
            this.maskBirth.TabIndex = 4;
            // 
            // dateJoining
            // 
            this.dateJoining.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateJoining.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateJoining.Location = new System.Drawing.Point(238, 214);
            this.dateJoining.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.dateJoining.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateJoining.Name = "dateJoining";
            this.dateJoining.Size = new System.Drawing.Size(111, 25);
            this.dateJoining.TabIndex = 6;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(238, 257);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(163, 23);
            this.txtContact.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(238, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(415, 23);
            this.txtName.TabIndex = 2;
            // 
            // lblContact
            // 
            this.lblContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblContact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblContact.Location = new System.Drawing.Point(25, 255);
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
            this.lblJoining.Location = new System.Drawing.Point(25, 217);
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
            this.lblGender.Location = new System.Drawing.Point(25, 179);
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
            this.lblBirth.Location = new System.Drawing.Point(25, 141);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(134, 21);
            this.lblBirth.TabIndex = 0;
            this.lblBirth.Text = "Data Nascimento";
            // 
            // lblState
            // 
            this.lblState.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblState.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblState.Location = new System.Drawing.Point(25, 103);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(59, 21);
            this.lblState.TabIndex = 0;
            this.lblState.Text = "Estado";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(25, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(168, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nome do Funcionário";
            // 
            // btnCity
            // 
            this.btnCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCity.Font = new System.Drawing.Font("Gabriola", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCity.Location = new System.Drawing.Point(659, 105);
            this.btnCity.Name = "btnCity";
            this.btnCity.Size = new System.Drawing.Size(80, 23);
            this.btnCity.TabIndex = 18;
            this.btnCity.Text = "Adicionar";
            this.btnCity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCity.UseCompatibleTextRendering = true;
            this.btnCity.UseVisualStyleBackColor = true;
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(474, 105);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(179, 23);
            this.cmbCity.TabIndex = 17;
            // 
            // lblCity
            // 
            this.lblCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCity.Location = new System.Drawing.Point(407, 105);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(61, 21);
            this.lblCity.TabIndex = 19;
            this.lblCity.Text = "Cidade";
            // 
            // FormEmployeeRegis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(918, 575);
            this.Controls.Add(this.panel1);
            this.Name = "FormEmployeeRegis";
            this.Text = "Área de Cadastro";
            this.Load += new System.EventHandler(this.FormEmployeeRegis_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ComboBox cmbGender;
        private ComboBox cmbState;
        private MaskedTextBox maskBirth;
        private DateTimePicker dateJoining;
        private TextBox txtContact;
        private TextBox txtName;
        private Label lblContact;
        private Label lblJoining;
        private Label lblGender;
        private Label lblBirth;
        private Label lblState;
        private Label lblName;
        private TextBox txtAccount;
        private ComboBox cmbJob;
        private Label label2;
        private Label lblTitle;
        private Label label1;
        private Button bntClear;
        private Button btnCancel;
        private Button btnSignUp;
        private Label lblCity;
        private Button btnCity;
        private ComboBox cmbCity;
    }
}