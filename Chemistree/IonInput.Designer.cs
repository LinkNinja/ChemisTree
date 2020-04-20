namespace Chemistree_GUI_V1
{
    partial class IonInput
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
            this.lblChemisttree = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAbbreviation = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCharge = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtbxIonAbbr = new System.Windows.Forms.TextBox();
            this.txtbxIonName = new System.Windows.Forms.TextBox();
            this.txtbxIonCharge = new System.Windows.Forms.TextBox();
            this.txtbxIonType = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClearTextBoxes = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.lblChemisttree);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(559, 34);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 39);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.White;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(459, 34);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 39);
            this.btnMenu.TabIndex = 16;
            this.btnMenu.Text = "MENU";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblChemisttree
            // 
            this.lblChemisttree.AutoSize = true;
            this.lblChemisttree.Font = new System.Drawing.Font("Bahnschrift", 19.8F);
            this.lblChemisttree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChemisttree.Location = new System.Drawing.Point(53, 34);
            this.lblChemisttree.Name = "lblChemisttree";
            this.lblChemisttree.Size = new System.Drawing.Size(154, 33);
            this.lblChemisttree.TabIndex = 1;
            this.lblChemisttree.Text = "Chemistree";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bahnschrift", 13.8F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(246, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(167, 23);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Ion Database Input";
            // 
            // lblAbbreviation
            // 
            this.lblAbbreviation.AutoSize = true;
            this.lblAbbreviation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAbbreviation.ForeColor = System.Drawing.Color.White;
            this.lblAbbreviation.Location = new System.Drawing.Point(161, 163);
            this.lblAbbreviation.Name = "lblAbbreviation";
            this.lblAbbreviation.Size = new System.Drawing.Size(87, 17);
            this.lblAbbreviation.TabIndex = 2;
            this.lblAbbreviation.Text = "Abbreviation";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblName.Location = new System.Drawing.Point(161, 205);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblCharge
            // 
            this.lblCharge.AutoSize = true;
            this.lblCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCharge.ForeColor = System.Drawing.Color.White;
            this.lblCharge.Location = new System.Drawing.Point(161, 243);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(54, 17);
            this.lblCharge.TabIndex = 4;
            this.lblCharge.Text = "Charge";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblType.ForeColor = System.Drawing.Color.White;
            this.lblType.Location = new System.Drawing.Point(161, 282);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 17);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Type";
            // 
            // txtbxIonAbbr
            // 
            this.txtbxIonAbbr.Location = new System.Drawing.Point(266, 163);
            this.txtbxIonAbbr.Name = "txtbxIonAbbr";
            this.txtbxIonAbbr.Size = new System.Drawing.Size(116, 20);
            this.txtbxIonAbbr.TabIndex = 9;
            // 
            // txtbxIonName
            // 
            this.txtbxIonName.Location = new System.Drawing.Point(266, 202);
            this.txtbxIonName.Name = "txtbxIonName";
            this.txtbxIonName.Size = new System.Drawing.Size(116, 20);
            this.txtbxIonName.TabIndex = 10;
            // 
            // txtbxIonCharge
            // 
            this.txtbxIonCharge.Location = new System.Drawing.Point(266, 240);
            this.txtbxIonCharge.Name = "txtbxIonCharge";
            this.txtbxIonCharge.Size = new System.Drawing.Size(116, 20);
            this.txtbxIonCharge.TabIndex = 11;
            // 
            // txtbxIonType
            // 
            this.txtbxIonType.Location = new System.Drawing.Point(266, 279);
            this.txtbxIonType.Name = "txtbxIonType";
            this.txtbxIonType.Size = new System.Drawing.Size(116, 20);
            this.txtbxIonType.TabIndex = 12;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.White;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubmit.Location = new System.Drawing.Point(282, 328);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClearTextBoxes
            // 
            this.btnClearTextBoxes.Location = new System.Drawing.Point(266, 415);
            this.btnClearTextBoxes.Name = "btnClearTextBoxes";
            this.btnClearTextBoxes.Size = new System.Drawing.Size(101, 23);
            this.btnClearTextBoxes.TabIndex = 16;
            this.btnClearTextBoxes.Text = "Clear Text Boxes";
            this.btnClearTextBoxes.UseVisualStyleBackColor = true;
            this.btnClearTextBoxes.Click += new System.EventHandler(this.btnClearTextBoxes_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(278, 370);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 23);
            this.lblResult.TabIndex = 17;
            // 
            // IonInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnClearTextBoxes);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtbxIonType);
            this.Controls.Add(this.txtbxIonCharge);
            this.Controls.Add(this.txtbxIonName);
            this.Controls.Add(this.txtbxIonAbbr);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblCharge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAbbreviation);
            this.Controls.Add(this.panel1);
            this.Name = "IonInput";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblChemisttree;
        private System.Windows.Forms.Label lblAbbreviation;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtbxIonAbbr;
        private System.Windows.Forms.TextBox txtbxIonName;
        private System.Windows.Forms.TextBox txtbxIonCharge;
        private System.Windows.Forms.TextBox txtbxIonType;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClearTextBoxes;
        private System.Windows.Forms.Label lblResult;
    }
}