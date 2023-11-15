namespace Projeto
{
    partial class TelaPedidosFinalizados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtGridPedidosFinalizados = new System.Windows.Forms.DataGridView();
            this.botaoAtualizar = new System.Windows.Forms.Button();
            this.dataIncio = new System.Windows.Forms.DateTimePicker();
            this.dataFim = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPedidosFinalizados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtGridPedidosFinalizados
            // 
            this.dtGridPedidosFinalizados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(13)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(23)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridPedidosFinalizados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtGridPedidosFinalizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridPedidosFinalizados.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtGridPedidosFinalizados.EnableHeadersVisualStyles = false;
            this.dtGridPedidosFinalizados.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtGridPedidosFinalizados.Location = new System.Drawing.Point(0, 32);
            this.dtGridPedidosFinalizados.Name = "dtGridPedidosFinalizados";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(23)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridPedidosFinalizados.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtGridPedidosFinalizados.Size = new System.Drawing.Size(1050, 640);
            this.dtGridPedidosFinalizados.TabIndex = 1;
            this.dtGridPedidosFinalizados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridPedidosFinalizados_CellContentClick);
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
            // dataIncio
            // 
            this.dataIncio.CustomFormat = "yyyy-MM-dd";
            this.dataIncio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataIncio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataIncio.Location = new System.Drawing.Point(248, 5);
            this.dataIncio.Name = "dataIncio";
            this.dataIncio.Size = new System.Drawing.Size(113, 23);
            this.dataIncio.TabIndex = 3;
            // 
            // dataFim
            // 
            this.dataFim.CustomFormat = "yyyy-MM-dd";
            this.dataFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataFim.Location = new System.Drawing.Point(731, 6);
            this.dataFim.Name = "dataFim";
            this.dataFim.Size = new System.Drawing.Size(113, 23);
            this.dataFim.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(640, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data Fim:";
            // 
            // TelaPedidosFinalizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(13)))), ((int)(((byte)(161)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataFim);
            this.Controls.Add(this.dataIncio);
            this.Controls.Add(this.botaoAtualizar);
            this.Controls.Add(this.dtGridPedidosFinalizados);
            this.Name = "TelaPedidosFinalizados";
            this.Size = new System.Drawing.Size(1050, 710);
            this.Load += new System.EventHandler(this.TelaPedidosFinalizados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridPedidosFinalizados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridPedidosFinalizados;
        private System.Windows.Forms.Button botaoAtualizar;
        private System.Windows.Forms.DateTimePicker dataIncio;
        private System.Windows.Forms.DateTimePicker dataFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
