namespace Chemistree_GUI_V1
{
    partial class DBInput
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblDBInput = new System.Windows.Forms.Label();
            this.lblChemistree = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAbbr = new System.Windows.Forms.Label();
            this.lblAtomicNumber = new System.Windows.Forms.Label();
            this.lblPeriodicGroup = new System.Windows.Forms.Label();
            this.lblPeriodicPeriod = new System.Windows.Forms.Label();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.txtbxAbbr = new System.Windows.Forms.TextBox();
            this.txtbxAtomicNumber = new System.Windows.Forms.TextBox();
            this.txtbxPeriodicGroup = new System.Windows.Forms.TextBox();
            this.txtbxPeriodicPeriod = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblElectronConfiguration = new System.Windows.Forms.Label();
            this.txtbxElectronConfiguration = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.lblDBInput);
            this.panel1.Controls.Add(this.lblChemistree);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(511, 32);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 39);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(430, 32);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 39);
            this.btnMenu.TabIndex = 15;
            this.btnMenu.Text = "MENU";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblDBInput
            // 
            this.lblDBInput.AutoSize = true;
            this.lblDBInput.Font = new System.Drawing.Font("Bahnschrift", 13.8F);
            this.lblDBInput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDBInput.Location = new System.Drawing.Point(229, 39);
            this.lblDBInput.Name = "lblDBInput";
            this.lblDBInput.Size = new System.Drawing.Size(136, 23);
            this.lblDBInput.TabIndex = 1;
            this.lblDBInput.Text = "Database Input";
            // 
            // lblChemistree
            // 
            this.lblChemistree.AutoSize = true;
            this.lblChemistree.Font = new System.Drawing.Font("Bahnschrift", 19.8F);
            this.lblChemistree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChemistree.Location = new System.Drawing.Point(12, 32);
            this.lblChemistree.Name = "lblChemistree";
            this.lblChemistree.Size = new System.Drawing.Size(156, 33);
            this.lblChemistree.TabIndex = 0;
            this.lblChemistree.Text = "ChemisTree";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(158, 167);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lblAbbr
            // 
            this.lblAbbr.AutoSize = true;
            this.lblAbbr.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbbr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAbbr.Location = new System.Drawing.Point(158, 129);
            this.lblAbbr.Name = "lblAbbr";
            this.lblAbbr.Size = new System.Drawing.Size(73, 13);
            this.lblAbbr.TabIndex = 2;
            this.lblAbbr.Text = "Abbreviation:";
            // 
            // lblAtomicNumber
            // 
            this.lblAtomicNumber.AutoSize = true;
            this.lblAtomicNumber.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtomicNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAtomicNumber.Location = new System.Drawing.Point(158, 209);
            this.lblAtomicNumber.Name = "lblAtomicNumber";
            this.lblAtomicNumber.Size = new System.Drawing.Size(85, 13);
            this.lblAtomicNumber.TabIndex = 4;
            this.lblAtomicNumber.Text = "Atomic Number:";
            // 
            // lblPeriodicGroup
            // 
            this.lblPeriodicGroup.AutoSize = true;
            this.lblPeriodicGroup.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodicGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPeriodicGroup.Location = new System.Drawing.Point(158, 250);
            this.lblPeriodicGroup.Name = "lblPeriodicGroup";
            this.lblPeriodicGroup.Size = new System.Drawing.Size(39, 13);
            this.lblPeriodicGroup.TabIndex = 5;
            this.lblPeriodicGroup.Text = "Group:";
            // 
            // lblPeriodicPeriod
            // 
            this.lblPeriodicPeriod.AutoSize = true;
            this.lblPeriodicPeriod.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodicPeriod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPeriodicPeriod.Location = new System.Drawing.Point(158, 293);
            this.lblPeriodicPeriod.Name = "lblPeriodicPeriod";
            this.lblPeriodicPeriod.Size = new System.Drawing.Size(42, 13);
            this.lblPeriodicPeriod.TabIndex = 6;
            this.lblPeriodicPeriod.Text = "Period:";
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(280, 164);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(157, 20);
            this.txtbxName.TabIndex = 9;
            // 
            // txtbxAbbr
            // 
            this.txtbxAbbr.Location = new System.Drawing.Point(280, 126);
            this.txtbxAbbr.Name = "txtbxAbbr";
            this.txtbxAbbr.Size = new System.Drawing.Size(157, 20);
            this.txtbxAbbr.TabIndex = 8;
            // 
            // txtbxAtomicNumber
            // 
            this.txtbxAtomicNumber.Location = new System.Drawing.Point(280, 206);
            this.txtbxAtomicNumber.Name = "txtbxAtomicNumber";
            this.txtbxAtomicNumber.Size = new System.Drawing.Size(157, 20);
            this.txtbxAtomicNumber.TabIndex = 10;
            // 
            // txtbxPeriodicGroup
            // 
            this.txtbxPeriodicGroup.Location = new System.Drawing.Point(280, 247);
            this.txtbxPeriodicGroup.Name = "txtbxPeriodicGroup";
            this.txtbxPeriodicGroup.Size = new System.Drawing.Size(157, 20);
            this.txtbxPeriodicGroup.TabIndex = 11;
            // 
            // txtbxPeriodicPeriod
            // 
            this.txtbxPeriodicPeriod.Location = new System.Drawing.Point(280, 290);
            this.txtbxPeriodicPeriod.Name = "txtbxPeriodicPeriod";
            this.txtbxPeriodicPeriod.Size = new System.Drawing.Size(157, 20);
            this.txtbxPeriodicPeriod.TabIndex = 12;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubmit.Location = new System.Drawing.Point(280, 383);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.ClickBtnSubmit);
            // 
            // lblElectronConfiguration
            // 
            this.lblElectronConfiguration.AutoSize = true;
            this.lblElectronConfiguration.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblElectronConfiguration.Location = new System.Drawing.Point(158, 331);
            this.lblElectronConfiguration.Name = "lblElectronConfiguration";
            this.lblElectronConfiguration.Size = new System.Drawing.Size(114, 13);
            this.lblElectronConfiguration.TabIndex = 7;
            this.lblElectronConfiguration.Text = "Electron Configuration:";
            // 
            // txtbxElectronConfiguration
            // 
            this.txtbxElectronConfiguration.Location = new System.Drawing.Point(280, 328);
            this.txtbxElectronConfiguration.Name = "txtbxElectronConfiguration";
            this.txtbxElectronConfiguration.Size = new System.Drawing.Size(157, 20);
            this.txtbxElectronConfiguration.TabIndex = 13;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResult.Location = new System.Drawing.Point(282, 416);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 23);
            this.lblResult.TabIndex = 15;
            // 
            // DBInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtbxElectronConfiguration);
            this.Controls.Add(this.lblElectronConfiguration);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtbxPeriodicPeriod);
            this.Controls.Add(this.txtbxPeriodicGroup);
            this.Controls.Add(this.txtbxAtomicNumber);
            this.Controls.Add(this.txtbxAbbr);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.lblPeriodicPeriod);
            this.Controls.Add(this.lblPeriodicGroup);
            this.Controls.Add(this.lblAtomicNumber);
            this.Controls.Add(this.lblAbbr);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel1);
            this.Name = "DBInput";
            this.Text = "DBInput";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblChemistree;
        private System.Windows.Forms.Label lblDBInput;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAbbr;
        private System.Windows.Forms.Label lblAtomicNumber;
        private System.Windows.Forms.Label lblPeriodicGroup;
        private System.Windows.Forms.Label lblPeriodicPeriod;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.TextBox txtbxAbbr;
        private System.Windows.Forms.TextBox txtbxAtomicNumber;
        private System.Windows.Forms.TextBox txtbxPeriodicGroup;
        private System.Windows.Forms.TextBox txtbxPeriodicPeriod;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblElectronConfiguration;
        private System.Windows.Forms.TextBox txtbxElectronConfiguration;
        private System.Windows.Forms.Label lblResult;
    }
}