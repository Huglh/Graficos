using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Pratica5 {
    public partial class FormOrdenacao : Form {
        int[] vet = new int[500]; // vetor interno para a animação

        public FormOrdenacao() {
            InitializeComponent();
            panel.Paint += new PaintEventHandler(panel_Paint);
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel, new object[] { true });
        }

        private void panel_Paint(object sender, PaintEventArgs e) {
            for (int i = 0; i < vet.Length; i++) {
                e.Graphics.DrawLine(Pens.DarkGreen, i, 299, i, 299 - vet[i]);
            }
        }

        private void bolhaToolStripMenuItem_Click(object sender, EventArgs e) {
            iniciaAnimacao(() => OrdenacaoGrafica.Bolha(vet, panel));
        }

        // TODO: animação e estatísticas dos demais métodos de ordenação

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show(this,
                "Prática 5 2024/1 - Métodos de Ordenação\n\n" +
                "Desenvolvido por:\n72300566 - Hugo Thiago Lima Menezes\n" +
                "Prof. Virgílio Borges de Oliveira\n\n" +
                "Algoritmos e Estruturas de Dados\n" +
                "Faculdade COTEMIG\n" +
                "Apenas para fins didáticos.",
                "Sobre o trabalho...",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void iniciaAnimacao(Action a) {
            if (bgw.IsBusy != true) {
                Preenchimento.Aleatorio(vet, 300);
                bgw.RunWorkerAsync(a);
            }
            else {
                MessageBox.Show(this,
                   "Aguarde o fim da execução atual...",
                   "Prática 5 2024/1 - Métodos de Ordenação",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);
            }
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e) {
            Action a = (Action)e.Argument;
            a();
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            MessageBox.Show(this,
               "Animação concluída!",
               "Prática 5 2024/1 - Métodos de Ordenação",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }

        private void bolhaToolStripMenuItem1_Click_1(object sender, EventArgs e) {
            
            
        }

        private void seleçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.Selecao(vet, panel));
        }

        private void inserçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.Insercao(vet, panel));
        }

        private void shellSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.ShellSort(vet, panel));
        }

        private void quickSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.quickSort(vet, vet[0], vet.Length - 1, panel));
        }

        private void heapSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.HeapSort(vet, panel));
        }

        private void mergeSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.mergeSort(vet, vet[0], vet.Length -1, panel));
        }

        private void vetorAleatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[1000]; // TODO (tamanho deverá ser escolhido pelo usuário)
            Preenchimento.Aleatorio(vetor, 1000); 
            var stopwatch = new Stopwatch();
            stopwatch.Start(); 
            OrdenacaoEstatistica.Bolha(vetor);
            stopwatch.Stop(); 
            long elapsed_time = stopwatch.ElapsedMilliseconds; 
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vet.Length +
                  "\nOrdenação inicial: " +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método Bolha - Vetor aleatório",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void vetorCescesnteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[1000]; // TODO (tamanho deverá ser escolhido pelo usuário)
            Preenchimento.Crescente(vetor); 
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            OrdenacaoEstatistica.Bolha(vetor);
            stopwatch.Stop(); 
            long elapsed_time = stopwatch.ElapsedMilliseconds; 
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vet.Length +
                  "\nOrdenação inicial: " +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método Bolha - Vetor Crescente",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void vetorDecrescenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[1000]; // TODO (tamanho deverá ser escolhido pelo usuário)
            Preenchimento.Decrescente(vetor); 
            var stopwatch = new Stopwatch();
            stopwatch.Start(); 
            OrdenacaoEstatistica.Bolha(vetor);
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds; 
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vet.Length +
                  "\nOrdenação inicial: " +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método Bolha  - Vetor Decrescente",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void vetorAleatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[1000]; // TODO (tamanho deverá ser escolhido pelo usuário)
            Preenchimento.Aleatorio(vetor, 1000); 
            var stopwatch = new Stopwatch();
            stopwatch.Start(); 
            OrdenacaoEstatistica.Selecao(vetor);
            stopwatch.Stop(); 
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vet.Length +
                  "\nOrdenação inicial: " +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método Seleçao - Vetor aleatório",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void vetorCrescenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[1000]; // TODO (tamanho deverá ser escolhido pelo usuário)
            Preenchimento.Crescente(vetor);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            OrdenacaoEstatistica.Selecao(vetor);
            stopwatch.Stop(); 
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vet.Length +
                  "\nOrdenação inicial: " +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método Seleção - Vetor Crescente",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void vetorDecrescenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[1000]; // TODO (tamanho deverá ser escolhido pelo usuário)
            Preenchimento.Decrescente(vetor);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            OrdenacaoEstatistica.Selecao(vetor);
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vet.Length +
                  "\nOrdenação inicial: " +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método Seleção - Vetor Decrescente",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void vetorAleatórioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[1000]; // TODO (tamanho deverá ser escolhido pelo usuário)
            Preenchimento.Aleatorio(vetor, 1000);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            OrdenacaoEstatistica.Insercao(vetor);
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vet.Length +
                  "\nOrdenação inicial: " +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método Inserção - Vetor Aleatório",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void vetorCrescenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[1000]; // TODO (tamanho deverá ser escolhido pelo usuário)
            Preenchimento.Crescente(vetor);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            OrdenacaoEstatistica.Insercao(vetor);
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vet.Length +
                  "\nOrdenação inicial: " +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método Inserção - Vetor Crescente",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void vetorDecrescenteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[1000]; // TODO (tamanho deverá ser escolhido pelo usuário)
            Preenchimento.Decrescente(vetor);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            OrdenacaoEstatistica.Insercao(vetor);
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vet.Length +
                  "\nOrdenação inicial: " +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método Inserção - Vetor Decrescente",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void vetorAleatórioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[1000]; // TODO (tamanho deverá ser escolhido pelo usuário)
            Preenchimento.Aleatorio(vetor, 1000);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            OrdenacaoEstatistica.ShellSort(vetor);
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vet.Length +
                  "\nOrdenação inicial: " +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método Shellsort - Vetor Aleatório",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void vetorCrescenteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[1000]; // TODO (tamanho deverá ser escolhido pelo usuário)
            Preenchimento.Crescente(vetor);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            OrdenacaoEstatistica.ShellSort(vetor);
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vet.Length +
                  "\nOrdenação inicial: " +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método ShellSort - Vetor Crescente",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void vetorDescrescenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[1000]; // TODO (tamanho deverá ser escolhido pelo usuário)
            Preenchimento.Decrescente(vetor);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            OrdenacaoEstatistica.ShellSort(vetor);
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vet.Length +
                  "\nOrdenação inicial: " +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método ShellSort - Vetor Decrescente",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void vetorAleatórioToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[1000]; // TODO (tamanho deverá ser escolhido pelo usuário)
            Preenchimento.Aleatorio(vetor, 1000);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            OrdenacaoEstatistica.QuickSort(vetor);
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vet.Length +
                  "\nOrdenação inicial: " +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método QuickSort - Vetor Aleatório",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);

        }

        private void vetorCrescenteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[1000]; // TODO (tamanho deverá ser escolhido pelo usuário)
            Preenchimento.Crescente(vetor);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            OrdenacaoEstatistica.QuickSort(vetor);
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vet.Length +
                  "\nOrdenação inicial: " +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método QuickSort - Vetor Crescente",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void vetorDecrescenteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[1000]; // TODO (tamanho deverá ser escolhido pelo usuário)
            Preenchimento.Decrescente(vetor);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            OrdenacaoEstatistica.QuickSort(vetor);
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vet.Length +
                  "\nOrdenação inicial: " +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método QuickSort - Vetor Decrescente",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void vetorAleatórioToolStripMenuItem4_Click(object sender, EventArgs e)
        {

            int[] vetor = new int[1000]; // TODO (tamanho deverá ser escolhido pelo usuário)
            Preenchimento.Aleatorio(vetor, 1000);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            OrdenacaoEstatistica.HeapSort(vetor);
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vet.Length +
                  "\nOrdenação inicial: " +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método HeapSort - Vetor Aleatório",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);

        }

        private void vetorCrescenteToolStripMenuItem4_Click(object sender, EventArgs e)
        {

            int[] vetor = new int[1000]; // TODO (tamanho deverá ser escolhido pelo usuário)
            Preenchimento.Crescente(vetor);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            OrdenacaoEstatistica.HeapSort(vetor);
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vet.Length +
                  "\nOrdenação inicial: " +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método HeapSort - Vetor Crescente",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void vetorDecrescenteToolStripMenuItem4_Click(object sender, EventArgs e)
        {

            int[] vetor = new int[1000]; // TODO (tamanho deverá ser escolhido pelo usuário)
            Preenchimento.Decrescente(vetor);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            OrdenacaoEstatistica.HeapSort(vetor);
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vet.Length +
                  "\nOrdenação inicial: " +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método HeapSort - Vetor Decrescente",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void vetorAleatórioToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[1000]; // TODO (tamanho deverá ser escolhido pelo usuário)
            Preenchimento.Aleatorio(vetor, 1000);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            OrdenacaoEstatistica.mergeSort(vetor, vet[0], vet.Length-1);
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vet.Length +
                  "\nOrdenação inicial: " +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método MergeSort - Vetor Aleatório",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void vetorCrescenteToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[1000]; // TODO (tamanho deverá ser escolhido pelo usuário)
            Preenchimento.Crescente(vetor);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            OrdenacaoEstatistica.mergeSort(vetor, vet[0], vet.Length - 1);
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vet.Length +
                  "\nOrdenação inicial: " +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método MergeSort - Vetor Crescente",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void vetorDecrescenteToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[1000]; // TODO (tamanho deverá ser escolhido pelo usuário)
            Preenchimento.Decrescente(vetor);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            OrdenacaoEstatistica.mergeSort(vetor, vet[0], vet.Length - 1);
            stopwatch.Stop();
            long elapsed_time = stopwatch.ElapsedMilliseconds;
            MessageBox.Show(this,
                  "Tamanho do vetor: " + vet.Length +
                  "\nOrdenação inicial: " +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cont_c +
                  "\nNº de trocas: " + OrdenacaoEstatistica.cont_t,
                  "Estatísticas do Método MergeSort - Vetor Decrescente",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }
    }
}
