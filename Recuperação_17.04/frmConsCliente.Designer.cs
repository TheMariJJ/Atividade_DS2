namespace Recuperação_17._04
{
    partial class frmConsCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsCliente));
            this.dtCliente = new System.Windows.Forms.DataGridView();
            this.btnCadCli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dtCliente
            // 
            this.dtCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtCliente.Location = new System.Drawing.Point(13, 13);
            this.dtCliente.Name = "dtCliente";
            this.dtCliente.Size = new System.Drawing.Size(481, 150);
            this.dtCliente.TabIndex = 0;
            // 
            // btnCadCli
            // 
            this.btnCadCli.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadCli.Location = new System.Drawing.Point(348, 174);
            this.btnCadCli.Name = "btnCadCli";
            this.btnCadCli.Size = new System.Drawing.Size(146, 23);
            this.btnCadCli.TabIndex = 1;
            this.btnCadCli.Text = "Cadastrar Cliente";
            this.btnCadCli.UseVisualStyleBackColor = true;
            this.btnCadCli.Click += new System.EventHandler(this.btnCadCli_Click);
            // 
            // frmConsCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(506, 209);
            this.Controls.Add(this.btnCadCli);
            this.Controls.Add(this.dtCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsCliente";
            this.Text = "Consultar Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsCliente_FormClosing);
            this.Load += new System.EventHandler(this.frmConsCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtCliente;
        private System.Windows.Forms.Button btnCadCli;
    }
}