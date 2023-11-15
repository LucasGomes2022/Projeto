namespace Projeto
{
    partial class TelaPedidosPendentes
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtGridPendentes = new System.Windows.Forms.DataGridView();
            this.ColFinalizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.botaoAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPendentes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridPendentes
            // 
            this.dtGridPendentes.AllowUserToOrderColumns = true;
            this.dtGridPendentes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(13)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(23)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridPendentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridPendentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFinalizar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridPendentes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridPendentes.EnableHeadersVisualStyles = false;
            this.dtGridPendentes.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtGridPendentes.Location = new System.Drawing.Point(0, 0);
            this.dtGridPendentes.Name = "dtGridPendentes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(23)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridPendentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGridPendentes.Size = new System.Drawing.Size(1050, 670);
            this.dtGridPendentes.TabIndex = 1;
            this.dtGridPendentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridPendentes_CellContentClick);
            // 
            // ColFinalizar
            // 
            this.ColFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColFinalizar.HeaderText = "Finalizar";
            this.ColFinalizar.Name = "ColFinalizar";
            this.ColFinalizar.ReadOnly = true;
            this.ColFinalizar.Text = "Finalizar";
            this.ColFinalizar.ToolTipText = "Finalizar";
            this.ColFinalizar.UseColumnTextForButtonValue = true;
            // 
            // botaoAtualizar
            // 
            this.botaoAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoAtualizar.Location = new System.Drawing.Point(0, 671);
            this.botaoAtualizar.Name = "botaoAtualizar";
            this.botaoAtualizar.Size = new System.Drawing.Size(1050, 40);
            this.botaoAtualizar.TabIndex = 2;
            this.botaoAtualizar.Text = "Atualizar";
            this.botaoAtualizar.UseVisualStyleBackColor = true;
            this.botaoAtualizar.Click += new System.EventHandler(this.botaoAtualizar_Click);
            // 
            // TelaPedidosPendentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.botaoAtualizar);
            this.Controls.Add(this.dtGridPendentes);
            this.Name = "TelaPedidosPendentes";
            this.Size = new System.Drawing.Size(1050, 710);
            this.Load += new System.EventHandler(this.TelaPedidosPendentes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPendentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridPendentes;
        private System.Windows.Forms.Button botaoAtualizar;
        private System.Windows.Forms.DataGridViewButtonColumn ColFinalizar;
    }
}
