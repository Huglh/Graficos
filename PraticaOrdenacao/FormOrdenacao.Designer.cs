namespace Pratica5
{
    partial class FormOrdenacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algoritmoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heapSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bolhaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vetorAleatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vetorCescesnteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vetorDecrescenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seleçaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vetorAleatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vetorCrescenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vetorDecrescenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inserçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vetorAleatórioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vetorCrescenteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vetorDecrescenteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.shellSortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vetorAleatórioToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.vetorCrescenteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.vetorDescrescenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vetorAleatórioToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.vetorCrescenteToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.vetorDecrescenteToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.heapSortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vetorAleatórioToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.vetorCrescenteToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.vetorDecrescenteToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeSortToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vetorAleatórioToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.vetorCrescenteToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.vetorDecrescenteToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 56);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(500, 300);
            this.panel.TabIndex = 0;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmoToolStripMenuItem,
            this.estatísticasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algoritmoToolStripMenuItem
            // 
            this.algoritmoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bolhaToolStripMenuItem,
            this.seleçãoToolStripMenuItem,
            this.inserçãoToolStripMenuItem,
            this.shellSortToolStripMenuItem,
            this.quickSortToolStripMenuItem,
            this.heapSortToolStripMenuItem,
            this.mergeSortToolStripMenuItem});
            this.algoritmoToolStripMenuItem.Name = "algoritmoToolStripMenuItem";
            this.algoritmoToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.algoritmoToolStripMenuItem.Text = "Animações";
            // 
            // bolhaToolStripMenuItem
            // 
            this.bolhaToolStripMenuItem.Name = "bolhaToolStripMenuItem";
            this.bolhaToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.bolhaToolStripMenuItem.Text = "Bolha";
            this.bolhaToolStripMenuItem.Click += new System.EventHandler(this.bolhaToolStripMenuItem_Click);
            // 
            // seleçãoToolStripMenuItem
            // 
            this.seleçãoToolStripMenuItem.Name = "seleçãoToolStripMenuItem";
            this.seleçãoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.seleçãoToolStripMenuItem.Text = "Seleção";
            this.seleçãoToolStripMenuItem.Click += new System.EventHandler(this.seleçãoToolStripMenuItem_Click);
            // 
            // inserçãoToolStripMenuItem
            // 
            this.inserçãoToolStripMenuItem.Name = "inserçãoToolStripMenuItem";
            this.inserçãoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.inserçãoToolStripMenuItem.Text = "Inserção";
            this.inserçãoToolStripMenuItem.Click += new System.EventHandler(this.inserçãoToolStripMenuItem_Click);
            // 
            // shellSortToolStripMenuItem
            // 
            this.shellSortToolStripMenuItem.Name = "shellSortToolStripMenuItem";
            this.shellSortToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.shellSortToolStripMenuItem.Text = "ShellSort";
            this.shellSortToolStripMenuItem.Click += new System.EventHandler(this.shellSortToolStripMenuItem_Click);
            // 
            // quickSortToolStripMenuItem
            // 
            this.quickSortToolStripMenuItem.Name = "quickSortToolStripMenuItem";
            this.quickSortToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.quickSortToolStripMenuItem.Text = "QuickSort";
            this.quickSortToolStripMenuItem.Click += new System.EventHandler(this.quickSortToolStripMenuItem_Click);
            // 
            // heapSortToolStripMenuItem
            // 
            this.heapSortToolStripMenuItem.Name = "heapSortToolStripMenuItem";
            this.heapSortToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.heapSortToolStripMenuItem.Text = "HeapSort";
            this.heapSortToolStripMenuItem.Click += new System.EventHandler(this.heapSortToolStripMenuItem_Click);
            // 
            // mergeSortToolStripMenuItem
            // 
            this.mergeSortToolStripMenuItem.Name = "mergeSortToolStripMenuItem";
            this.mergeSortToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.mergeSortToolStripMenuItem.Text = "MergeSort";
            this.mergeSortToolStripMenuItem.Click += new System.EventHandler(this.mergeSortToolStripMenuItem_Click);
            // 
            // estatísticasToolStripMenuItem
            // 
            this.estatísticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bolhaToolStripMenuItem1,
            this.seleçaoToolStripMenuItem,
            this.inserçãoToolStripMenuItem1,
            this.shellSortToolStripMenuItem1,
            this.quickSortToolStripMenuItem1,
            this.heapSortToolStripMenuItem1,
            this.mergeSortToolStripMenuItem1});
            this.estatísticasToolStripMenuItem.Name = "estatísticasToolStripMenuItem";
            this.estatísticasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.estatísticasToolStripMenuItem.Text = "Estatísticas";
            // 
            // bolhaToolStripMenuItem1
            // 
            this.bolhaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vetorAleatorioToolStripMenuItem,
            this.vetorCescesnteToolStripMenuItem,
            this.vetorDecrescenteToolStripMenuItem});
            this.bolhaToolStripMenuItem1.Name = "bolhaToolStripMenuItem1";
            this.bolhaToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.bolhaToolStripMenuItem1.Text = "Bolha";
            this.bolhaToolStripMenuItem1.Click += new System.EventHandler(this.bolhaToolStripMenuItem1_Click_1);
            // 
            // vetorAleatorioToolStripMenuItem
            // 
            this.vetorAleatorioToolStripMenuItem.Name = "vetorAleatorioToolStripMenuItem";
            this.vetorAleatorioToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.vetorAleatorioToolStripMenuItem.Text = "Vetor aleatorio";
            this.vetorAleatorioToolStripMenuItem.Click += new System.EventHandler(this.vetorAleatorioToolStripMenuItem_Click);
            // 
            // vetorCescesnteToolStripMenuItem
            // 
            this.vetorCescesnteToolStripMenuItem.Name = "vetorCescesnteToolStripMenuItem";
            this.vetorCescesnteToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.vetorCescesnteToolStripMenuItem.Text = "Vetor cescesnte";
            this.vetorCescesnteToolStripMenuItem.Click += new System.EventHandler(this.vetorCescesnteToolStripMenuItem_Click);
            // 
            // vetorDecrescenteToolStripMenuItem
            // 
            this.vetorDecrescenteToolStripMenuItem.Name = "vetorDecrescenteToolStripMenuItem";
            this.vetorDecrescenteToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.vetorDecrescenteToolStripMenuItem.Text = "Vetor decrescente";
            this.vetorDecrescenteToolStripMenuItem.Click += new System.EventHandler(this.vetorDecrescenteToolStripMenuItem_Click);
            // 
            // seleçaoToolStripMenuItem
            // 
            this.seleçaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vetorAleatórioToolStripMenuItem,
            this.vetorCrescenteToolStripMenuItem,
            this.vetorDecrescenteToolStripMenuItem1});
            this.seleçaoToolStripMenuItem.Name = "seleçaoToolStripMenuItem";
            this.seleçaoToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.seleçaoToolStripMenuItem.Text = "Seleçao";
            // 
            // vetorAleatórioToolStripMenuItem
            // 
            this.vetorAleatórioToolStripMenuItem.Name = "vetorAleatórioToolStripMenuItem";
            this.vetorAleatórioToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.vetorAleatórioToolStripMenuItem.Text = "Vetor Aleatório";
            this.vetorAleatórioToolStripMenuItem.Click += new System.EventHandler(this.vetorAleatórioToolStripMenuItem_Click);
            // 
            // vetorCrescenteToolStripMenuItem
            // 
            this.vetorCrescenteToolStripMenuItem.Name = "vetorCrescenteToolStripMenuItem";
            this.vetorCrescenteToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.vetorCrescenteToolStripMenuItem.Text = "Vetor Crescente";
            this.vetorCrescenteToolStripMenuItem.Click += new System.EventHandler(this.vetorCrescenteToolStripMenuItem_Click);
            // 
            // vetorDecrescenteToolStripMenuItem1
            // 
            this.vetorDecrescenteToolStripMenuItem1.Name = "vetorDecrescenteToolStripMenuItem1";
            this.vetorDecrescenteToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.vetorDecrescenteToolStripMenuItem1.Text = "Vetor Decrescente";
            this.vetorDecrescenteToolStripMenuItem1.Click += new System.EventHandler(this.vetorDecrescenteToolStripMenuItem1_Click);
            // 
            // inserçãoToolStripMenuItem1
            // 
            this.inserçãoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vetorAleatórioToolStripMenuItem1,
            this.vetorCrescenteToolStripMenuItem1,
            this.vetorDecrescenteToolStripMenuItem2});
            this.inserçãoToolStripMenuItem1.Name = "inserçãoToolStripMenuItem1";
            this.inserçãoToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.inserçãoToolStripMenuItem1.Text = "Inserção";
            // 
            // vetorAleatórioToolStripMenuItem1
            // 
            this.vetorAleatórioToolStripMenuItem1.Name = "vetorAleatórioToolStripMenuItem1";
            this.vetorAleatórioToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.vetorAleatórioToolStripMenuItem1.Text = "Vetor Aleatório";
            this.vetorAleatórioToolStripMenuItem1.Click += new System.EventHandler(this.vetorAleatórioToolStripMenuItem1_Click);
            // 
            // vetorCrescenteToolStripMenuItem1
            // 
            this.vetorCrescenteToolStripMenuItem1.Name = "vetorCrescenteToolStripMenuItem1";
            this.vetorCrescenteToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.vetorCrescenteToolStripMenuItem1.Text = "Vetor Crescente";
            this.vetorCrescenteToolStripMenuItem1.Click += new System.EventHandler(this.vetorCrescenteToolStripMenuItem1_Click);
            // 
            // vetorDecrescenteToolStripMenuItem2
            // 
            this.vetorDecrescenteToolStripMenuItem2.Name = "vetorDecrescenteToolStripMenuItem2";
            this.vetorDecrescenteToolStripMenuItem2.Size = new System.Drawing.Size(168, 22);
            this.vetorDecrescenteToolStripMenuItem2.Text = "Vetor Decrescente";
            this.vetorDecrescenteToolStripMenuItem2.Click += new System.EventHandler(this.vetorDecrescenteToolStripMenuItem2_Click);
            // 
            // shellSortToolStripMenuItem1
            // 
            this.shellSortToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vetorAleatórioToolStripMenuItem2,
            this.vetorCrescenteToolStripMenuItem2,
            this.vetorDescrescenteToolStripMenuItem});
            this.shellSortToolStripMenuItem1.Name = "shellSortToolStripMenuItem1";
            this.shellSortToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.shellSortToolStripMenuItem1.Text = "ShellSort";
            // 
            // vetorAleatórioToolStripMenuItem2
            // 
            this.vetorAleatórioToolStripMenuItem2.Name = "vetorAleatórioToolStripMenuItem2";
            this.vetorAleatórioToolStripMenuItem2.Size = new System.Drawing.Size(173, 22);
            this.vetorAleatórioToolStripMenuItem2.Text = "Vetor Aleatório";
            this.vetorAleatórioToolStripMenuItem2.Click += new System.EventHandler(this.vetorAleatórioToolStripMenuItem2_Click);
            // 
            // vetorCrescenteToolStripMenuItem2
            // 
            this.vetorCrescenteToolStripMenuItem2.Name = "vetorCrescenteToolStripMenuItem2";
            this.vetorCrescenteToolStripMenuItem2.Size = new System.Drawing.Size(173, 22);
            this.vetorCrescenteToolStripMenuItem2.Text = "Vetor Crescente";
            this.vetorCrescenteToolStripMenuItem2.Click += new System.EventHandler(this.vetorCrescenteToolStripMenuItem2_Click);
            // 
            // vetorDescrescenteToolStripMenuItem
            // 
            this.vetorDescrescenteToolStripMenuItem.Name = "vetorDescrescenteToolStripMenuItem";
            this.vetorDescrescenteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.vetorDescrescenteToolStripMenuItem.Text = "Vetor Descrescente";
            this.vetorDescrescenteToolStripMenuItem.Click += new System.EventHandler(this.vetorDescrescenteToolStripMenuItem_Click);
            // 
            // quickSortToolStripMenuItem1
            // 
            this.quickSortToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vetorAleatórioToolStripMenuItem3,
            this.vetorCrescenteToolStripMenuItem3,
            this.vetorDecrescenteToolStripMenuItem3});
            this.quickSortToolStripMenuItem1.Name = "quickSortToolStripMenuItem1";
            this.quickSortToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.quickSortToolStripMenuItem1.Text = "QuickSort";
            // 
            // vetorAleatórioToolStripMenuItem3
            // 
            this.vetorAleatórioToolStripMenuItem3.Name = "vetorAleatórioToolStripMenuItem3";
            this.vetorAleatórioToolStripMenuItem3.Size = new System.Drawing.Size(168, 22);
            this.vetorAleatórioToolStripMenuItem3.Text = "Vetor Aleatório";
            this.vetorAleatórioToolStripMenuItem3.Click += new System.EventHandler(this.vetorAleatórioToolStripMenuItem3_Click);
            // 
            // vetorCrescenteToolStripMenuItem3
            // 
            this.vetorCrescenteToolStripMenuItem3.Name = "vetorCrescenteToolStripMenuItem3";
            this.vetorCrescenteToolStripMenuItem3.Size = new System.Drawing.Size(168, 22);
            this.vetorCrescenteToolStripMenuItem3.Text = "Vetor Crescente";
            this.vetorCrescenteToolStripMenuItem3.Click += new System.EventHandler(this.vetorCrescenteToolStripMenuItem3_Click);
            // 
            // vetorDecrescenteToolStripMenuItem3
            // 
            this.vetorDecrescenteToolStripMenuItem3.Name = "vetorDecrescenteToolStripMenuItem3";
            this.vetorDecrescenteToolStripMenuItem3.Size = new System.Drawing.Size(168, 22);
            this.vetorDecrescenteToolStripMenuItem3.Text = "Vetor Decrescente";
            this.vetorDecrescenteToolStripMenuItem3.Click += new System.EventHandler(this.vetorDecrescenteToolStripMenuItem3_Click);
            // 
            // heapSortToolStripMenuItem1
            // 
            this.heapSortToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vetorAleatórioToolStripMenuItem4,
            this.vetorCrescenteToolStripMenuItem4,
            this.vetorDecrescenteToolStripMenuItem4});
            this.heapSortToolStripMenuItem1.Name = "heapSortToolStripMenuItem1";
            this.heapSortToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.heapSortToolStripMenuItem1.Text = "HeapSort";
            // 
            // vetorAleatórioToolStripMenuItem4
            // 
            this.vetorAleatórioToolStripMenuItem4.Name = "vetorAleatórioToolStripMenuItem4";
            this.vetorAleatórioToolStripMenuItem4.Size = new System.Drawing.Size(168, 22);
            this.vetorAleatórioToolStripMenuItem4.Text = "Vetor Aleatório";
            this.vetorAleatórioToolStripMenuItem4.Click += new System.EventHandler(this.vetorAleatórioToolStripMenuItem4_Click);
            // 
            // vetorCrescenteToolStripMenuItem4
            // 
            this.vetorCrescenteToolStripMenuItem4.Name = "vetorCrescenteToolStripMenuItem4";
            this.vetorCrescenteToolStripMenuItem4.Size = new System.Drawing.Size(168, 22);
            this.vetorCrescenteToolStripMenuItem4.Text = "Vetor Crescente";
            this.vetorCrescenteToolStripMenuItem4.Click += new System.EventHandler(this.vetorCrescenteToolStripMenuItem4_Click);
            // 
            // vetorDecrescenteToolStripMenuItem4
            // 
            this.vetorDecrescenteToolStripMenuItem4.Name = "vetorDecrescenteToolStripMenuItem4";
            this.vetorDecrescenteToolStripMenuItem4.Size = new System.Drawing.Size(168, 22);
            this.vetorDecrescenteToolStripMenuItem4.Text = "Vetor Decrescente";
            this.vetorDecrescenteToolStripMenuItem4.Click += new System.EventHandler(this.vetorDecrescenteToolStripMenuItem4_Click);
            // 
            // mergeSortToolStripMenuItem1
            // 
            this.mergeSortToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vetorAleatórioToolStripMenuItem5,
            this.vetorCrescenteToolStripMenuItem5,
            this.vetorDecrescenteToolStripMenuItem5});
            this.mergeSortToolStripMenuItem1.Name = "mergeSortToolStripMenuItem1";
            this.mergeSortToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.mergeSortToolStripMenuItem1.Text = "MergeSort";
            // 
            // vetorAleatórioToolStripMenuItem5
            // 
            this.vetorAleatórioToolStripMenuItem5.Name = "vetorAleatórioToolStripMenuItem5";
            this.vetorAleatórioToolStripMenuItem5.Size = new System.Drawing.Size(168, 22);
            this.vetorAleatórioToolStripMenuItem5.Text = "Vetor Aleatório";
            this.vetorAleatórioToolStripMenuItem5.Click += new System.EventHandler(this.vetorAleatórioToolStripMenuItem5_Click);
            // 
            // vetorCrescenteToolStripMenuItem5
            // 
            this.vetorCrescenteToolStripMenuItem5.Name = "vetorCrescenteToolStripMenuItem5";
            this.vetorCrescenteToolStripMenuItem5.Size = new System.Drawing.Size(168, 22);
            this.vetorCrescenteToolStripMenuItem5.Text = "Vetor Crescente";
            this.vetorCrescenteToolStripMenuItem5.Click += new System.EventHandler(this.vetorCrescenteToolStripMenuItem5_Click);
            // 
            // vetorDecrescenteToolStripMenuItem5
            // 
            this.vetorDecrescenteToolStripMenuItem5.Name = "vetorDecrescenteToolStripMenuItem5";
            this.vetorDecrescenteToolStripMenuItem5.Size = new System.Drawing.Size(168, 22);
            this.vetorDecrescenteToolStripMenuItem5.Text = "Vetor Decrescente";
            this.vetorDecrescenteToolStripMenuItem5.Click += new System.EventHandler(this.vetorDecrescenteToolStripMenuItem5_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // bgw
            // 
            this.bgw.WorkerSupportsCancellation = true;
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // FormOrdenacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 361);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormOrdenacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prática 5 2023/1 - Métodos de Ordenação";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem algoritmoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bolhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatísticasToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.ToolStripMenuItem bolhaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seleçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shellSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heapSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vetorAleatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vetorCescesnteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vetorDecrescenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleçaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vetorAleatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vetorCrescenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vetorDecrescenteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inserçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vetorAleatórioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vetorCrescenteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vetorDecrescenteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem shellSortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vetorAleatórioToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem vetorCrescenteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem vetorDescrescenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickSortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vetorAleatórioToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem vetorCrescenteToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem vetorDecrescenteToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem heapSortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vetorAleatórioToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem vetorCrescenteToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem vetorDecrescenteToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mergeSortToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vetorAleatórioToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem vetorCrescenteToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem vetorDecrescenteToolStripMenuItem5;
    }
}

