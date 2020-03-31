namespace Chemistree_GUI_V1
{
    partial class ElectronConfigScreen
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
            this.nav_exit_btn = new System.Windows.Forms.Button();
            this.nav_menu_btn = new System.Windows.Forms.Button();
            this.result_label_panel = new System.Windows.Forms.Panel();
            this.result_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AppTitle = new System.Windows.Forms.Label();
            this.elem_table_panel = new System.Windows.Forms.Panel();
            this.element_choice_label = new System.Windows.Forms.Label();
            this.result_panel = new System.Windows.Forms.Panel();
            this.navigation_panal.SuspendLayout();
            this.result_label_panel.SuspendLayout();
            this.elem_table_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigation_panal
            // 
            this.navigation_panal.AutoSize = true;
            this.navigation_panal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.navigation_panal.Controls.Add(this.nav_exit_btn);
            this.navigation_panal.Controls.Add(this.nav_menu_btn);
            this.navigation_panal.Controls.Add(this.label1);
            this.navigation_panal.Controls.Add(this.AppTitle);
            this.navigation_panal.Location = new System.Drawing.Point(0, -1);
            this.navigation_panal.Name = "navigation_panal";
            this.navigation_panal.Size = new System.Drawing.Size(880, 89);
            this.navigation_panal.TabIndex = 1;
            this.navigation_panal.Paint += new System.Windows.Forms.PaintEventHandler(this.navigation_panal_Paint);
            // 
            // nav_exit_btn
            // 
            this.nav_exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.nav_exit_btn.FlatAppearance.BorderSize = 0;
            this.nav_exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nav_exit_btn.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.nav_exit_btn.ForeColor = System.Drawing.Color.White;
            this.nav_exit_btn.Location = new System.Drawing.Point(764, 19);
            this.nav_exit_btn.Name = "nav_exit_btn";
            this.nav_exit_btn.Size = new System.Drawing.Size(85, 53);
            this.nav_exit_btn.TabIndex = 5;
            this.nav_exit_btn.Text = "EXIT";
            this.nav_exit_btn.UseVisualStyleBackColor = false;
            // 
            // nav_menu_btn
            // 
            this.nav_menu_btn.BackColor = System.Drawing.Color.White;
            this.nav_menu_btn.FlatAppearance.BorderSize = 0;
            this.nav_menu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nav_menu_btn.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.nav_menu_btn.Location = new System.Drawing.Point(667, 19);
            this.nav_menu_btn.Name = "nav_menu_btn";
            this.nav_menu_btn.Size = new System.Drawing.Size(85, 53);
            this.nav_menu_btn.TabIndex = 4;
            this.nav_menu_btn.Text = "MENU";
            this.nav_menu_btn.UseVisualStyleBackColor = false;
            // 
            // result_label_panel
            // 
            this.result_label_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.result_label_panel.Controls.Add(this.result_label);
            this.result_label_panel.Location = new System.Drawing.Point(0, 283);
            this.result_label_panel.Name = "result_label_panel";
            this.result_label_panel.Size = new System.Drawing.Size(874, 53);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(301, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create an Ionic Compound";
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
            // elem_table_panel
            // 
            this.elem_table_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.elem_table_panel.Controls.Add(this.result_panel);
            this.elem_table_panel.Controls.Add(this.element_choice_label);
            this.elem_table_panel.Controls.Add(this.result_label_panel);
            this.elem_table_panel.Location = new System.Drawing.Point(0, 86);
            this.elem_table_panel.Name = "elem_table_panel";
            this.elem_table_panel.Size = new System.Drawing.Size(877, 446);
            this.elem_table_panel.TabIndex = 2;
            // 
            // element_choice_label
            // 
            this.element_choice_label.AutoSize = true;
            this.element_choice_label.Font = new System.Drawing.Font("Bahnschrift Light", 10.8F);
            this.element_choice_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.element_choice_label.Location = new System.Drawing.Point(357, 15);
            this.element_choice_label.Name = "element_choice_label";
            this.element_choice_label.Size = new System.Drawing.Size(156, 23);
            this.element_choice_label.TabIndex = 5;
            this.element_choice_label.Text = "Pick one element";
            this.element_choice_label.Click += new System.EventHandler(this.compound_choice_label_Click);
            // 
            // result_panel
            // 
            this.result_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.result_panel.Location = new System.Drawing.Point(0, 336);
            this.result_panel.Name = "result_panel";
            this.result_panel.Size = new System.Drawing.Size(866, 110);
            this.result_panel.TabIndex = 6;
            // 
            // ElectronConfigScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 530);
            this.Controls.Add(this.elem_table_panel);
            this.Controls.Add(this.navigation_panal);
            this.Name = "ElectronConfigScreen";
            this.Text = "ElectronConfigScreen";
            this.navigation_panal.ResumeLayout(false);
            this.navigation_panal.PerformLayout();
            this.result_label_panel.ResumeLayout(false);
            this.result_label_panel.PerformLayout();
            this.elem_table_panel.ResumeLayout(false);
            this.elem_table_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navigation_panal;
        private System.Windows.Forms.Button nav_exit_btn;
        private System.Windows.Forms.Button nav_menu_btn;
        private System.Windows.Forms.Panel result_label_panel;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AppTitle;
        private System.Windows.Forms.Panel elem_table_panel;
        private System.Windows.Forms.Label element_choice_label;
        private System.Windows.Forms.Panel result_panel;
    }
}