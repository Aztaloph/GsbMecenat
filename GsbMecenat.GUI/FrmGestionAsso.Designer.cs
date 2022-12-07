namespace GsbMecenat.GUI
{
    partial class FrmGestionAsso
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
            this.btnSupprimerAssociation = new System.Windows.Forms.Button();
            this.btnAjouterAssociation = new System.Windows.Forms.Button();
            this.btnModifierAssociation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSupprimerAssociation
            // 
            this.btnSupprimerAssociation.Location = new System.Drawing.Point(567, 188);
            this.btnSupprimerAssociation.Name = "btnSupprimerAssociation";
            this.btnSupprimerAssociation.Size = new System.Drawing.Size(104, 44);
            this.btnSupprimerAssociation.TabIndex = 0;
            this.btnSupprimerAssociation.Text = "Supprimer association";
            this.btnSupprimerAssociation.UseVisualStyleBackColor = true;
            // 
            // btnAjouterAssociation
            // 
            this.btnAjouterAssociation.Location = new System.Drawing.Point(82, 188);
            this.btnAjouterAssociation.Name = "btnAjouterAssociation";
            this.btnAjouterAssociation.Size = new System.Drawing.Size(103, 44);
            this.btnAjouterAssociation.TabIndex = 1;
            this.btnAjouterAssociation.Text = "Ajouter association";
            this.btnAjouterAssociation.UseVisualStyleBackColor = true;
            this.btnAjouterAssociation.Click += new System.EventHandler(this.btnAjouterAssociation_Click);
            // 
            // btnModifierAssociation
            // 
            this.btnModifierAssociation.Location = new System.Drawing.Point(342, 188);
            this.btnModifierAssociation.Name = "btnModifierAssociation";
            this.btnModifierAssociation.Size = new System.Drawing.Size(96, 44);
            this.btnModifierAssociation.TabIndex = 2;
            this.btnModifierAssociation.Text = "Modifier association";
            this.btnModifierAssociation.UseVisualStyleBackColor = true;
            // 
            // FrmGestionAsso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModifierAssociation);
            this.Controls.Add(this.btnAjouterAssociation);
            this.Controls.Add(this.btnSupprimerAssociation);
            this.Name = "FrmGestionAsso";
            this.Text = "FrmGestionAsso";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSupprimerAssociation;
        private System.Windows.Forms.Button btnAjouterAssociation;
        private System.Windows.Forms.Button btnModifierAssociation;
    }
}