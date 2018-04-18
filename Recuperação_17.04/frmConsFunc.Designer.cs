namespace Recuperação_17._04
{
    partial class frmConsFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsFunc));
            this.btnCadFun = new System.Windows.Forms.Button();
            this.dtFuncionario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCadFun
            // 
            this.btnCadFun.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadFun.Location = new System.Drawing.Point(346, 178);
            this.btnCadFun.Name = "btnCadFun";
            this.btnCadFun.Size = new System.Drawing.Size(170, 27);
            this.btnCadFun.TabIndex = 2;
            this.btnCadFun.Text = "Cadastrar Funcionario";
            this.btnCadFun.UseVisualStyleBackColor = true;
            this.btnCadFun.Click += new System.EventHandler(this.btnCadFun_Click);
            // 
            // dtFuncionario
            // 
            this.dtFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtFuncionario.Location = new System.Drawing.Point(13, 13);
            this.dtFuncionario.Name = "dtFuncionario";
            this.dtFuncionario.Size = new System.Drawing.Size(503, 150);
            this.dtFuncionario.TabIndex = 3;
            // 
            // frmConsFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(528, 217);
            this.Controls.Add(this.dtFuncionario);
            this.Controls.Add(this.btnCadFun);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsFunc";
            this.Text = "Consulta Funcionario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConsFunc_FormClosing);
            this.Load += new System.EventHandler(this.frmConsFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtFuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadFun;
        private System.Windows.Forms.DataGridView dtFuncionario;
    }
}