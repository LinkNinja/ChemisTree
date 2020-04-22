namespace Chemistree_GUI_V1
{
    partial class IoCompoundScreen
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
            this.navigation_panal = new System.Windows.Forms.Panel();
            this.result_panel = new System.Windows.Forms.Panel();
            this.ionicCompound_label = new System.Windows.Forms.Label();
            this.ionicName_label = new System.Windows.Forms.Label();
            this.reset_btn = new System.Windows.Forms.Button();
            this.nav_exit_btn = new System.Windows.Forms.Button();
            this.compount_panel = new System.Windows.Forms.Panel();
            this.anions_panel = new Chemistree_GUI_V1.RoundedPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.anions_label = new System.Windows.Forms.Label();
            this.anionChg_txt = new System.Windows.Forms.TextBox();
            this.anion_input = new System.Windows.Forms.TextBox();
            this.create_compound_btn = new Chemistree_GUI_V1.RoundedButton();
            this.cations_panel = new Chemistree_GUI_V1.RoundedPanel();
            this.charge_lbl = new System.Windows.Forms.Label();
            this.cation_label = new System.Windows.Forms.Label();
            this.cationChg_txt = new System.Windows.Forms.TextBox();
            this.cation_input = new System.Windows.Forms.TextBox();
            this.compound_choice_label = new System.Windows.Forms.Label();
            this.nav_menu_btn = new System.Windows.Forms.Button();
            this.result_label_panel = new System.Windows.Forms.Panel();
            this.result_label = new System.Windows.Forms.Label();
            this.lblCompoundScreen = new System.Windows.Forms.Label();
            this.AppTitle = new System.Windows.Forms.Label();
            this.navigation_panal.SuspendLayout();
            this.result_panel.SuspendLayout();
            this.compount_panel.SuspendLayout();
            this.anions_panel.SuspendLayout();
            this.cations_panel.SuspendLayout();
            this.result_label_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigation_panal
            // 
            this.navigation_panal.AutoSize = true;
            this.navigation_panal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.navigation_panal.Controls.Add(this.result_panel);
            this.navigation_panal.Controls.Add(this.nav_exit_btn);
            this.navigation_panal.Controls.Add(this.compount_panel);
            this.navigation_panal.Controls.Add(this.nav_menu_btn);
            this.navigation_panal.Controls.Add(this.result_label_panel);
            this.navigation_panal.Controls.Add(this.lblCompoundScreen);
            this.navigation_panal.Controls.Add(this.AppTitle);
            this.navigation_panal.Location = new System.Drawing.Point(-3, 0);
            this.navigation_panal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.navigation_panal.Name = "navigation_panal";
            this.navigation_panal.Size = new System.Drawing.Size(1461, 596);
            this.navigation_panal.TabIndex = 0;
            this.navigation_panal.Paint += new System.Windows.Forms.PaintEventHandler(this.navigation_panal_Paint);
            // 
            // result_panel
            // 
            this.result_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.result_panel.Controls.Add(this.ionicCompound_label);
            this.result_panel.Controls.Add(this.ionicName_label);
            this.result_panel.Controls.Add(this.reset_btn);
            this.result_panel.Location = new System.Drawing.Point(1051, 150);
            this.result_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.result_panel.Name = "result_panel";
            this.result_panel.Size = new System.Drawing.Size(407, 441);
            this.result_panel.TabIndex = 3;
            this.result_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.result_panel_Paint);
            // 
            // ionicCompound_label
            // 
            this.ionicCompound_label.AutoSize = true;
            this.ionicCompound_label.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ionicCompound_label.ForeColor = System.Drawing.Color.White;
            this.ionicCompound_label.Location = new System.Drawing.Point(33, 41);
            this.ionicCompound_label.Name = "ionicCompound_label";
            this.ionicCompound_label.Size = new System.Drawing.Size(0, 48);
            this.ionicCompound_label.TabIndex = 8;
            // 
            // ionicName_label
            // 
            this.ionicName_label.AutoSize = true;
            this.ionicName_label.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ionicName_label.ForeColor = System.Drawing.Color.White;
            this.ionicName_label.Location = new System.Drawing.Point(36, 110);
            this.ionicName_label.Name = "ionicName_label";
            this.ionicName_label.Size = new System.Drawing.Size(0, 36);
            this.ionicName_label.TabIndex = 7;
            // 
            // reset_btn
            // 
            this.reset_btn.BackColor = System.Drawing.Color.White;
            this.reset_btn.FlatAppearance.BorderSize = 0;
            this.reset_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_btn.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.reset_btn.Location = new System.Drawing.Point(235, 381);
            this.reset_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(157, 46);
            this.reset_btn.TabIndex = 6;
            this.reset_btn.Text = "TRY AGAIN";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // nav_exit_btn
            // 
            this.nav_exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.nav_exit_btn.FlatAppearance.BorderSize = 0;
            this.nav_exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nav_exit_btn.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.nav_exit_btn.ForeColor = System.Drawing.Color.White;
            this.nav_exit_btn.Location = new System.Drawing.Point(1351, 20);
            this.nav_exit_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nav_exit_btn.Name = "nav_exit_btn";
            this.nav_exit_btn.Size = new System.Drawing.Size(85, 53);
            this.nav_exit_btn.TabIndex = 5;
            this.nav_exit_btn.Text = "EXIT";
            this.nav_exit_btn.UseVisualStyleBackColor = false;
            this.nav_exit_btn.Click += new System.EventHandler(this.nav_exit_btn_Click_1);
            // 
            // compount_panel
            // 
            this.compount_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.compount_panel.Controls.Add(this.anions_panel);
            this.compount_panel.Controls.Add(this.create_compound_btn);
            this.compount_panel.Controls.Add(this.cations_panel);
            this.compount_panel.Controls.Add(this.compound_choice_label);
            this.compount_panel.Location = new System.Drawing.Point(0, 97);
            this.compount_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.compount_panel.Name = "compount_panel";
            this.compount_panel.Size = new System.Drawing.Size(1051, 497);
            this.compount_panel.TabIndex = 1;
            this.compount_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.compount_panel_Paint);
            // 
            // anions_panel
            // 
            this.anions_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.anions_panel.Controls.Add(this.label2);
            this.anions_panel.Controls.Add(this.anions_label);
            this.anions_panel.Controls.Add(this.anionChg_txt);
            this.anions_panel.Controls.Add(this.anion_input);
            this.anions_panel.Location = new System.Drawing.Point(507, 74);
            this.anions_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.anions_panel.Name = "anions_panel";
            this.anions_panel.Size = new System.Drawing.Size(384, 324);
            this.anions_panel.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(323, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "-";
            // 
            // anions_label
            // 
            this.anions_label.AutoSize = true;
            this.anions_label.Font = new System.Drawing.Font("Bahnschrift", 17F);
            this.anions_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.anions_label.Location = new System.Drawing.Point(139, 39);
            this.anions_label.Name = "anions_label";
            this.anions_label.Size = new System.Drawing.Size(119, 35);
            this.anions_label.TabIndex = 7;
            this.anions_label.Text = "ANIONS";
            // 
            // anionChg_txt
            // 
            this.anionChg_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.anionChg_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.anionChg_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anionChg_txt.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.anionChg_txt.ForeColor = System.Drawing.Color.White;
            this.anionChg_txt.Location = new System.Drawing.Point(274, 106);
            this.anionChg_txt.Margin = new System.Windows.Forms.Padding(11, 20, 11, 10);
            this.anionChg_txt.Multiline = true;
            this.anionChg_txt.Name = "anionChg_txt";
            this.anionChg_txt.Size = new System.Drawing.Size(50, 25);
            this.anionChg_txt.TabIndex = 2;
            // 
            // anion_input
            // 
            this.anion_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.anion_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.anion_input.Cursor = System.Windows.Forms.Cursors.Hand;
            this.anion_input.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.anion_input.ForeColor = System.Drawing.Color.White;
            this.anion_input.Location = new System.Drawing.Point(70, 106);
            this.anion_input.Margin = new System.Windows.Forms.Padding(11, 20, 11, 10);
            this.anion_input.Multiline = true;
            this.anion_input.Name = "anion_input";
            this.anion_input.Size = new System.Drawing.Size(188, 95);
            this.anion_input.TabIndex = 2;
            this.anion_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // create_compound_btn
            // 
            this.create_compound_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(255)))), ((int)(((byte)(64)))));
            this.create_compound_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.create_compound_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_compound_btn.Font = new System.Drawing.Font("Bahnschrift Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_compound_btn.Location = new System.Drawing.Point(95, 415);
            this.create_compound_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.create_compound_btn.Name = "create_compound_btn";
            this.create_compound_btn.Size = new System.Drawing.Size(796, 47);
            this.create_compound_btn.TabIndex = 8;
            this.create_compound_btn.Text = "CREATE COMPOUND";
            this.create_compound_btn.UseVisualStyleBackColor = false;
            this.create_compound_btn.Click += new System.EventHandler(this.create_compound_btn_Click);
            // 
            // cations_panel
            // 
            this.cations_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(175)))), ((int)(((byte)(255)))));
            this.cations_panel.Controls.Add(this.charge_lbl);
            this.cations_panel.Controls.Add(this.cation_label);
            this.cations_panel.Controls.Add(this.cationChg_txt);
            this.cations_panel.Controls.Add(this.cation_input);
            this.cations_panel.Location = new System.Drawing.Point(95, 74);
            this.cations_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cations_panel.Name = "cations_panel";
            this.cations_panel.Size = new System.Drawing.Size(384, 324);
            this.cations_panel.TabIndex = 6;
            // 
            // charge_lbl
            // 
            this.charge_lbl.AutoSize = true;
            this.charge_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.charge_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.charge_lbl.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charge_lbl.ForeColor = System.Drawing.Color.White;
            this.charge_lbl.Location = new System.Drawing.Point(322, 105);
            this.charge_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.charge_lbl.Name = "charge_lbl";
            this.charge_lbl.Size = new System.Drawing.Size(23, 26);
            this.charge_lbl.TabIndex = 7;
            this.charge_lbl.Text = "+";
            // 
            // cation_label
            // 
            this.cation_label.AutoSize = true;
            this.cation_label.Font = new System.Drawing.Font("Bahnschrift", 17F);
            this.cation_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cation_label.Location = new System.Drawing.Point(125, 39);
            this.cation_label.Name = "cation_label";
            this.cation_label.Size = new System.Drawing.Size(130, 35);
            this.cation_label.TabIndex = 6;
            this.cation_label.Text = "CATIONS";
            // 
            // cationChg_txt
            // 
            this.cationChg_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.cationChg_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cationChg_txt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cationChg_txt.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.cationChg_txt.ForeColor = System.Drawing.Color.White;
            this.cationChg_txt.Location = new System.Drawing.Point(273, 105);
            this.cationChg_txt.Margin = new System.Windows.Forms.Padding(11, 20, 11, 10);
            this.cationChg_txt.Multiline = true;
            this.cationChg_txt.Name = "cationChg_txt";
            this.cationChg_txt.Size = new System.Drawing.Size(50, 25);
            this.cationChg_txt.TabIndex = 1;
            // 
            // cation_input
            // 
            this.cation_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.cation_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cation_input.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cation_input.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.cation_input.ForeColor = System.Drawing.Color.White;
            this.cation_input.Location = new System.Drawing.Point(67, 106);
            this.cation_input.Margin = new System.Windows.Forms.Padding(11, 20, 11, 10);
            this.cation_input.Multiline = true;
            this.cation_input.Name = "cation_input";
            this.cation_input.Size = new System.Drawing.Size(188, 95);
            this.cation_input.TabIndex = 0;
            this.cation_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cation_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // compound_choice_label
            // 
            this.compound_choice_label.AutoSize = true;
            this.compound_choice_label.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F);
            this.compound_choice_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.compound_choice_label.Location = new System.Drawing.Point(364, 26);
            this.compound_choice_label.Name = "compound_choice_label";
            this.compound_choice_label.Size = new System.Drawing.Size(266, 23);
            this.compound_choice_label.TabIndex = 5;
            this.compound_choice_label.Text = "Pick one cation and one anion.";
            // 
            // nav_menu_btn
            // 
            this.nav_menu_btn.BackColor = System.Drawing.Color.White;
            this.nav_menu_btn.FlatAppearance.BorderSize = 0;
            this.nav_menu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nav_menu_btn.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.nav_menu_btn.Location = new System.Drawing.Point(1254, 20);
            this.nav_menu_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nav_menu_btn.Name = "nav_menu_btn";
            this.nav_menu_btn.Size = new System.Drawing.Size(85, 53);
            this.nav_menu_btn.TabIndex = 4;
            this.nav_menu_btn.Text = "MENU";
            this.nav_menu_btn.UseVisualStyleBackColor = false;
            this.nav_menu_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // result_label_panel
            // 
            this.result_label_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.result_label_panel.Controls.Add(this.result_label);
            this.result_label_panel.Location = new System.Drawing.Point(1051, 97);
            this.result_label_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.result_label_panel.Name = "result_label_panel";
            this.result_label_panel.Size = new System.Drawing.Size(407, 53);
            this.result_label_panel.TabIndex = 2;
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F);
            this.result_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.result_label.Location = new System.Drawing.Point(9, 17);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(65, 23);
            this.result_label.TabIndex = 3;
            this.result_label.Text = "Result";
            // 
            // lblCompoundScreen
            // 
            this.lblCompoundScreen.AutoSize = true;
            this.lblCompoundScreen.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompoundScreen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCompoundScreen.Location = new System.Drawing.Point(551, 32);
            this.lblCompoundScreen.Name = "lblCompoundScreen";
            this.lblCompoundScreen.Size = new System.Drawing.Size(340, 29);
            this.lblCompoundScreen.TabIndex = 2;
            this.lblCompoundScreen.Text = "CREATE AN IONIC COMPOUND";
            this.lblCompoundScreen.Click += new System.EventHandler(this.label1_Click);
            // 
            // AppTitle
            // 
            this.AppTitle.AutoSize = true;
            this.AppTitle.Font = new System.Drawing.Font("Bahnschrift", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AppTitle.Location = new System.Drawing.Point(23, 21);
            this.AppTitle.Name = "AppTitle";
            this.AppTitle.Size = new System.Drawing.Size(190, 40);
            this.AppTitle.TabIndex = 1;
            this.AppTitle.Text = "ChemisTree";
            // 
            // IoCompoundScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 592);
            this.Controls.Add(this.navigation_panal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IoCompoundScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChemisTree";
            this.Load += new System.EventHandler(this.IoCompoundScreen_Load);
            this.navigation_panal.ResumeLayout(false);
            this.navigation_panal.PerformLayout();
            this.result_panel.ResumeLayout(false);
            this.result_panel.PerformLayout();
            this.compount_panel.ResumeLayout(false);
            this.compount_panel.PerformLayout();
            this.anions_panel.ResumeLayout(false);
            this.anions_panel.PerformLayout();
            this.cations_panel.ResumeLayout(false);
            this.cations_panel.PerformLayout();
            this.result_label_panel.ResumeLayout(false);
            this.result_label_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navigation_panal;
        private System.Windows.Forms.Panel compount_panel;
        private System.Windows.Forms.Panel result_label_panel;
        private System.Windows.Forms.Panel result_panel;
        private System.Windows.Forms.Label lblCompoundScreen;
        private System.Windows.Forms.Label AppTitle;
        private System.Windows.Forms.Button nav_menu_btn;
        private System.Windows.Forms.Label compound_choice_label;
        private System.Windows.Forms.Label result_label;
        private RoundedPanel cations_panel;
        private RoundedButton create_compound_btn;
        private System.Windows.Forms.Button nav_exit_btn;
        private RoundedPanel anions_panel;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.TextBox cation_input;
        private System.Windows.Forms.TextBox cationChg_txt;
        private System.Windows.Forms.TextBox anion_input;
        private System.Windows.Forms.Label anions_label;
        private System.Windows.Forms.TextBox anionChg_txt;
        private System.Windows.Forms.Label cation_label;
        private System.Windows.Forms.Label ionicName_label;
        private System.Windows.Forms.Label ionicCompound_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label charge_lbl;
    }
}