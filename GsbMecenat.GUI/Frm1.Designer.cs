namespace GsbMecenat.GUI
{
    partial class Frm1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGestionAsso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionAsso
            // 
            this.btnGestionAsso.Location = new System.Drawing.Point(572, 54);
            this.btnGestionAsso.Name = "btnGestionAsso";
            this.btnGestionAsso.Size = new System.Drawing.Size(117, 52);
            this.btnGestionAsso.TabIndex = 0;
            this.btnGestionAsso.Text = "Gestion d\'association";
            this.btnGestionAsso.UseVisualStyleBackColor = true;
            this.btnGestionAsso.Click += new System.EventHandler(this.btnGestionAsso_Click);
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGestionAsso);
            this.Name = "Frm1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionAsso;
    }
}

