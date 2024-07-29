using PCTools.Utils;

namespace PCTools.Forms
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnOtimizar_Click(object sender, EventArgs e)
        {
            try
            {
                progress.Value = 0;
                SetActiveForm(false);

                //Opções de Boot
                progress.Value = 10;
                OptimizerBootOptions();

                //Opções de Serviços
                progress.Value = 30;
                OptimizerServicesOptions();

                //Opções de Energia
                progress.Value = 40;
                OptimizerEnergyOptions();

                //Opções de pastas
                progress.Value = 60;
                OptimizerFolderOptions();

                //Opções de Disco
                progress.Value = 80;
                OptimizerDiskOptions();

                //Finaliza
                progress.Value = 100;
                SetActiveForm(true);

                MessageBox.Show($"Otimizações realizadas com sucesso! ", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar realizar o processo!\r\nErro: {ex.Message}", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OptimizerBootOptions()
        {
            if (chkUtilizarMaxProcessadores.Checked)
                BootOptions.SetTheHighestProcessors();

            if (chkDesabilitarIniReg.Checked)
                BootOptions.DisableStartupProgramsInRegistry();

            if (chkDesabilitarIniPast.Checked)
                BootOptions.DisableStartupProgramsInStartupFolder();
        }

        private void OptimizerServicesOptions()
        {
            if(chkDesativarUpdate.Checked)
                WindowsServices.DisableWindowsUpdate();

            if (chkDesativarSearch.Checked)
                WindowsServices.DisableWindowsSearch();        
        }

        private void OptimizerEnergyOptions()
        {
            if (chkAlterarDesemMax.Checked)
                EnergyOptions.SetPowerModeMaxPerformance();
        }

        private void OptimizerFolderOptions()
        {
            if(chkLimparTemp.Checked)
                FoldersOptions.ClearTempFolder();
        }

        private void OptimizerDiskOptions()
        {
            if (chkDesgramentar.Checked)
                DiskOptions.DiskDefragment("C:");
        }

        private void SetActiveForm(bool active)
        {
            groupParams.Enabled = active;
            btnOtimizar.Enabled = active;
            btnRestaurar.Enabled = active;
        }
    }
}
