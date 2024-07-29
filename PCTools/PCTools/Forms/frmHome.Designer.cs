namespace PCTools.Forms
{
    partial class frmHome
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
            btnRestaurar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupParams = new GroupBox();
            chkDesgramentar = new CheckBox();
            chkAlterarDesemMax = new CheckBox();
            chkLimparTemp = new CheckBox();
            chkDesabilitarIniPast = new CheckBox();
            chkDesativarSearch = new CheckBox();
            chkDesabilitarIniReg = new CheckBox();
            chkDesativarUpdate = new CheckBox();
            chkUtilizarMaxProcessadores = new CheckBox();
            btnOtimizar = new Button();
            progress = new ProgressBar();
            groupParams.SuspendLayout();
            SuspendLayout();
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRestaurar.BackColor = Color.Goldenrod;
            btnRestaurar.Font = new Font("Nirmala UI Semilight", 10F, FontStyle.Bold);
            btnRestaurar.ForeColor = Color.White;
            btnRestaurar.Image = Properties.Resources.de_volta;
            btnRestaurar.ImageAlign = ContentAlignment.MiddleRight;
            btnRestaurar.Location = new Point(237, 269);
            btnRestaurar.Margin = new Padding(3, 4, 3, 4);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Padding = new Padding(0, 0, 10, 0);
            btnRestaurar.Size = new Size(341, 42);
            btnRestaurar.TabIndex = 26;
            btnRestaurar.Text = "   Restaurar Configurações Originais";
            btnRestaurar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.SteelBlue;
            label3.Location = new Point(155, 30);
            label3.Name = "label3";
            label3.Size = new Size(37, 19);
            label3.TabIndex = 25;
            label3.Text = "v1.0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 10F);
            label2.ForeColor = Color.SteelBlue;
            label2.Location = new Point(19, 55);
            label2.Name = "label2";
            label2.Size = new Size(292, 19);
            label2.TabIndex = 24;
            label2.Text = "Ferramentas de otimização rápida para seu PC";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 25F, FontStyle.Bold);
            label1.ForeColor = Color.SteelBlue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(154, 46);
            label1.TabIndex = 23;
            label1.Text = "PC Tools";
            // 
            // groupParams
            // 
            groupParams.Controls.Add(chkDesgramentar);
            groupParams.Controls.Add(chkAlterarDesemMax);
            groupParams.Controls.Add(chkLimparTemp);
            groupParams.Controls.Add(chkDesabilitarIniPast);
            groupParams.Controls.Add(chkDesativarSearch);
            groupParams.Controls.Add(chkDesabilitarIniReg);
            groupParams.Controls.Add(chkDesativarUpdate);
            groupParams.Controls.Add(chkUtilizarMaxProcessadores);
            groupParams.Font = new Font("Nirmala UI Semilight", 9F);
            groupParams.Location = new Point(12, 87);
            groupParams.Name = "groupParams";
            groupParams.Size = new Size(922, 148);
            groupParams.TabIndex = 19;
            groupParams.TabStop = false;
            groupParams.Text = "Parâmetros de Otimização";
            // 
            // chkDesgramentar
            // 
            chkDesgramentar.AutoSize = true;
            chkDesgramentar.Location = new Point(454, 43);
            chkDesgramentar.Name = "chkDesgramentar";
            chkDesgramentar.Size = new Size(156, 19);
            chkDesgramentar.TabIndex = 9;
            chkDesgramentar.Text = "Desfragmentar o disco C:";
            chkDesgramentar.UseVisualStyleBackColor = true;
            // 
            // chkAlterarDesemMax
            // 
            chkAlterarDesemMax.AutoSize = true;
            chkAlterarDesemMax.Location = new Point(454, 20);
            chkAlterarDesemMax.Name = "chkAlterarDesemMax";
            chkAlterarDesemMax.Size = new Size(304, 19);
            chkAlterarDesemMax.TabIndex = 3;
            chkAlterarDesemMax.Text = "Alterar para o plano de energia Desempenho Máximo";
            chkAlterarDesemMax.UseVisualStyleBackColor = true;
            // 
            // chkLimparTemp
            // 
            chkLimparTemp.AutoSize = true;
            chkLimparTemp.Location = new Point(454, 68);
            chkLimparTemp.Name = "chkLimparTemp";
            chkLimparTemp.Size = new Size(176, 19);
            chkLimparTemp.TabIndex = 7;
            chkLimparTemp.Text = "Limpar arquivos temporários";
            chkLimparTemp.UseVisualStyleBackColor = true;
            // 
            // chkDesabilitarIniPast
            // 
            chkDesabilitarIniPast.AutoSize = true;
            chkDesabilitarIniPast.Location = new Point(7, 68);
            chkDesabilitarIniPast.Name = "chkDesabilitarIniPast";
            chkDesabilitarIniPast.Size = new Size(389, 19);
            chkDesabilitarIniPast.TabIndex = 2;
            chkDesabilitarIniPast.Text = "Desabilitar a inicialização com Windows de todos programas via pasta";
            chkDesabilitarIniPast.UseVisualStyleBackColor = true;
            // 
            // chkDesativarSearch
            // 
            chkDesativarSearch.AutoSize = true;
            chkDesativarSearch.Location = new Point(7, 118);
            chkDesativarSearch.Name = "chkDesativarSearch";
            chkDesativarSearch.Size = new Size(172, 19);
            chkDesativarSearch.TabIndex = 5;
            chkDesativarSearch.Text = "Desativar o Windows Search";
            chkDesativarSearch.UseVisualStyleBackColor = true;
            // 
            // chkDesabilitarIniReg
            // 
            chkDesabilitarIniReg.AutoSize = true;
            chkDesabilitarIniReg.Location = new Point(7, 45);
            chkDesabilitarIniReg.Name = "chkDesabilitarIniReg";
            chkDesabilitarIniReg.Size = new Size(401, 19);
            chkDesabilitarIniReg.TabIndex = 1;
            chkDesabilitarIniReg.Text = "Desabilitar a inicialização com Windows de todos programas via registro";
            chkDesabilitarIniReg.UseVisualStyleBackColor = true;
            // 
            // chkDesativarUpdate
            // 
            chkDesativarUpdate.AutoSize = true;
            chkDesativarUpdate.Location = new Point(7, 93);
            chkDesativarUpdate.Name = "chkDesativarUpdate";
            chkDesativarUpdate.Size = new Size(176, 19);
            chkDesativarUpdate.TabIndex = 4;
            chkDesativarUpdate.Text = "Desativar o Windows Update";
            chkDesativarUpdate.UseVisualStyleBackColor = true;
            // 
            // chkUtilizarMaxProcessadores
            // 
            chkUtilizarMaxProcessadores.AutoSize = true;
            chkUtilizarMaxProcessadores.Location = new Point(7, 22);
            chkUtilizarMaxProcessadores.Name = "chkUtilizarMaxProcessadores";
            chkUtilizarMaxProcessadores.Size = new Size(243, 19);
            chkUtilizarMaxProcessadores.TabIndex = 0;
            chkUtilizarMaxProcessadores.Text = "Utilizar o maior número de processadores";
            chkUtilizarMaxProcessadores.UseVisualStyleBackColor = true;
            // 
            // btnOtimizar
            // 
            btnOtimizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOtimizar.BackColor = Color.SteelBlue;
            btnOtimizar.Font = new Font("Nirmala UI Semilight", 10F, FontStyle.Bold);
            btnOtimizar.ForeColor = Color.White;
            btnOtimizar.Image = Properties.Resources.confirme;
            btnOtimizar.ImageAlign = ContentAlignment.MiddleRight;
            btnOtimizar.Location = new Point(581, 269);
            btnOtimizar.Margin = new Padding(3, 4, 3, 4);
            btnOtimizar.Name = "btnOtimizar";
            btnOtimizar.Padding = new Padding(0, 0, 10, 0);
            btnOtimizar.Size = new Size(355, 42);
            btnOtimizar.TabIndex = 18;
            btnOtimizar.Text = "   Aplicar Otimizações";
            btnOtimizar.UseVisualStyleBackColor = false;
            btnOtimizar.Click += btnOtimizar_Click;
            // 
            // progress
            // 
            progress.Location = new Point(12, 241);
            progress.Name = "progress";
            progress.Size = new Size(922, 23);
            progress.TabIndex = 27;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 321);
            Controls.Add(progress);
            Controls.Add(btnRestaurar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupParams);
            Controls.Add(btnOtimizar);
            Font = new Font("Segoe Script", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmHome";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " PC Tools";
            groupParams.ResumeLayout(false);
            groupParams.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRestaurar;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupParams;
        private Button btnOtimizar;
        private CheckBox chkUtilizarMaxProcessadores;
        private CheckBox chkDesabilitarIniReg;
        private CheckBox chkDesabilitarIniPast;
        private CheckBox chkAlterarDesemMax;
        private CheckBox chkDesativarSearch;
        private CheckBox chkDesativarUpdate;
        private CheckBox chkLimparTemp;
        private CheckBox chkDesgramentar;
        private ProgressBar progress;
    }
}