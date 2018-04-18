namespace Recuperação_17._04
{
    partial class frmConsVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsVeiculo));
            this.btnCadVeiculo = new System.Windows.Forms.Button();
            this.dtVeiculo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtVeiculo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadVeiculo
            // 
            this.btnCadVeiculo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadVeiculo.Location = new System.Drawing.Point(251, 182);
            this.btnCadVeiculo.Name = "btnCadVeiculo";
            this.btnCadVeiculo.Size = new System.Drawing.Size(146, 23);
            this.btnCadVeiculo.TabIndex = 2;
            this.btnCadVeiculo.Text = "Cadastrar Veiculo";
            this.btnCadVeiculo.UseVisualStyleBackColor = true;
            this.btnCadVeiculo.Click += new System.EventHandler(this.btnCadVeiculo_Click);
            // 
            // dtVeiculo
            // 
            this.dtVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtVeiculo.Location = new System.Drawing.Point(13, 13);
            this.dtVeiculo.Name = "dtVeiculo";
            this.dtVeiculo.Size = new System.Drawing.Size(384, 150);
            this.dtVeiculo.TabIndex = 3;
            // 
            // frmConsVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(409, 217);
            this.Controls.Add(this.dtVeiculo);
            this.Controls.Add(this.btnCadVeiculo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsVeiculo";
            this.Text = "Consultar Veiculo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsVeiculo_FormClosing);
            this.Load += new System.EventHandler(this.frmConsVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtVeiculo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadVeiculo;
        private System.Windows.Forms.DataGridView dtVeiculo;
    }
}