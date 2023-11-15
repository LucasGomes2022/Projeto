namespace Projeto
{
    partial class TelaVender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaVender));
            this.botaoInserir = new System.Windows.Forms.Button();
            this.dtGridListaProdutos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.saldoCliente = new System.Windows.Forms.TextBox();
            this.dataVenda = new System.Windows.Forms.DateTimePicker();
            this.botaoDeletar = new System.Windows.Forms.Button();
            this.botaoFinalizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.botaoAdGranulado = new System.Windows.Forms.Button();
            this.botaoAdJujuba = new System.Windows.Forms.Button();
            this.botaoAdPacoca = new System.Windows.Forms.Button();
            this.botaoAdChocoBall = new System.Windows.Forms.Button();
            this.botaoAdLeiteEmPo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.botaoInGranulado = new System.Windows.Forms.Button();
            this.botaoInJujuba = new System.Windows.Forms.Button();
            this.botaoInPacoca = new System.Windows.Forms.Button();
            this.botaoInChocoBall = new System.Windows.Forms.Button();
            this.botaoInLeiteEmPo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoMil = new System.Windows.Forms.Button();
            this.botaoQuinhetos = new System.Windows.Forms.Button();
            this.botaoQuatrocentos = new System.Windows.Forms.Button();
            this.botaoTrezentos = new System.Windows.Forms.Button();
            this.botaoDuzentos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colPruduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridListaProdutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoInserir
            // 
            this.botaoInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoInserir.Location = new System.Drawing.Point(400, 625);
            this.botaoInserir.Name = "botaoInserir";
            this.botaoInserir.Size = new System.Drawing.Size(276, 53);
            this.botaoInserir.TabIndex = 54;
            this.botaoInserir.Text = "Inserir Produto";
            this.botaoInserir.UseVisualStyleBackColor = true;
            this.botaoInserir.Click += new System.EventHandler(this.botaoInserir_Click);
            // 
            // dtGridListaProdutos
            // 
            this.dtGridListaProdutos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(13)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGridListaProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridListaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPruduto,
            this.colDescricao});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(13)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridListaProdutos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridListaProdutos.Location = new System.Drawing.Point(696, 260);
            this.dtGridListaProdutos.Name = "dtGridListaProdutos";
            this.dtGridListaProdutos.Size = new System.Drawing.Size(318, 316);
            this.dtGridListaProdutos.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(82, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 25);
            this.label5.TabIndex = 52;
            this.label5.Text = "NOME CLIENTE";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(57, 154);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(219, 26);
            this.txtNomeCliente.TabIndex = 51;
            this.txtNomeCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(395, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 25);
            this.label4.TabIndex = 50;
            this.label4.Text = "VALOR TOTAL";
            // 
            // saldoCliente
            // 
            this.saldoCliente.Enabled = false;
            this.saldoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldoCliente.Location = new System.Drawing.Point(366, 154);
            this.saldoCliente.Name = "saldoCliente";
            this.saldoCliente.Size = new System.Drawing.Size(219, 26);
            this.saldoCliente.TabIndex = 49;
            this.saldoCliente.Text = "R$:";
            this.saldoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataVenda
            // 
            this.dataVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataVenda.Location = new System.Drawing.Point(696, 153);
            this.dataVenda.Name = "dataVenda";
            this.dataVenda.Size = new System.Drawing.Size(318, 24);
            this.dataVenda.TabIndex = 48;
            // 
            // botaoDeletar
            // 
            this.botaoDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoDeletar.Location = new System.Drawing.Point(696, 625);
            this.botaoDeletar.Name = "botaoDeletar";
            this.botaoDeletar.Size = new System.Drawing.Size(318, 53);
            this.botaoDeletar.TabIndex = 47;
            this.botaoDeletar.Text = "Deletar Pedido";
            this.botaoDeletar.UseVisualStyleBackColor = true;
            this.botaoDeletar.Click += new System.EventHandler(this.botaoDeletar_Click);
            // 
            // botaoFinalizar
            // 
            this.botaoFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoFinalizar.Location = new System.Drawing.Point(36, 625);
            this.botaoFinalizar.Name = "botaoFinalizar";
            this.botaoFinalizar.Size = new System.Drawing.Size(275, 53);
            this.botaoFinalizar.TabIndex = 46;
            this.botaoFinalizar.Text = "Finalizar Pedido";
            this.botaoFinalizar.UseVisualStyleBackColor = true;
            this.botaoFinalizar.Click += new System.EventHandler(this.botaoFinalizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(287, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "ADICIONAIS";
            // 
            // botaoAdGranulado
            // 
            this.botaoAdGranulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoAdGranulado.Location = new System.Drawing.Point(570, 523);
            this.botaoAdGranulado.Name = "botaoAdGranulado";
            this.botaoAdGranulado.Size = new System.Drawing.Size(106, 53);
            this.botaoAdGranulado.TabIndex = 44;
            this.botaoAdGranulado.Text = "Granulado";
            this.botaoAdGranulado.UseVisualStyleBackColor = true;
            this.botaoAdGranulado.Click += new System.EventHandler(this.botaoAdGranulado_Click);
            // 
            // botaoAdJujuba
            // 
            this.botaoAdJujuba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoAdJujuba.Location = new System.Drawing.Point(437, 523);
            this.botaoAdJujuba.Name = "botaoAdJujuba";
            this.botaoAdJujuba.Size = new System.Drawing.Size(106, 53);
            this.botaoAdJujuba.TabIndex = 43;
            this.botaoAdJujuba.Text = "Jujuba";
            this.botaoAdJujuba.UseVisualStyleBackColor = true;
            this.botaoAdJujuba.Click += new System.EventHandler(this.botaoAdJujuba_Click);
            // 
            // botaoAdPacoca
            // 
            this.botaoAdPacoca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoAdPacoca.Location = new System.Drawing.Point(303, 523);
            this.botaoAdPacoca.Name = "botaoAdPacoca";
            this.botaoAdPacoca.Size = new System.Drawing.Size(106, 53);
            this.botaoAdPacoca.TabIndex = 42;
            this.botaoAdPacoca.Text = "Paçoca";
            this.botaoAdPacoca.UseVisualStyleBackColor = true;
            this.botaoAdPacoca.Click += new System.EventHandler(this.botaoAdPacoca_Click);
            // 
            // botaoAdChocoBall
            // 
            this.botaoAdChocoBall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoAdChocoBall.Location = new System.Drawing.Point(170, 523);
            this.botaoAdChocoBall.Name = "botaoAdChocoBall";
            this.botaoAdChocoBall.Size = new System.Drawing.Size(106, 53);
            this.botaoAdChocoBall.TabIndex = 41;
            this.botaoAdChocoBall.Text = "Choco Ball";
            this.botaoAdChocoBall.UseVisualStyleBackColor = true;
            this.botaoAdChocoBall.Click += new System.EventHandler(this.botaoAdChocoBall_Click);
            // 
            // botaoAdLeiteEmPo
            // 
            this.botaoAdLeiteEmPo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoAdLeiteEmPo.Location = new System.Drawing.Point(36, 523);
            this.botaoAdLeiteEmPo.Name = "botaoAdLeiteEmPo";
            this.botaoAdLeiteEmPo.Size = new System.Drawing.Size(106, 53);
            this.botaoAdLeiteEmPo.TabIndex = 40;
            this.botaoAdLeiteEmPo.Text = "Leite em Pó";
            this.botaoAdLeiteEmPo.UseVisualStyleBackColor = true;
            this.botaoAdLeiteEmPo.Click += new System.EventHandler(this.botaoAdLeiteEmPo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(268, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "INGREDIENTES";
            // 
            // botaoInGranulado
            // 
            this.botaoInGranulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoInGranulado.Location = new System.Drawing.Point(570, 389);
            this.botaoInGranulado.Name = "botaoInGranulado";
            this.botaoInGranulado.Size = new System.Drawing.Size(106, 53);
            this.botaoInGranulado.TabIndex = 38;
            this.botaoInGranulado.Text = "Granulado";
            this.botaoInGranulado.UseVisualStyleBackColor = true;
            this.botaoInGranulado.Click += new System.EventHandler(this.botaoInGranulado_Click);
            // 
            // botaoInJujuba
            // 
            this.botaoInJujuba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoInJujuba.Location = new System.Drawing.Point(437, 389);
            this.botaoInJujuba.Name = "botaoInJujuba";
            this.botaoInJujuba.Size = new System.Drawing.Size(106, 53);
            this.botaoInJujuba.TabIndex = 37;
            this.botaoInJujuba.Text = "Jujuba";
            this.botaoInJujuba.UseVisualStyleBackColor = true;
            this.botaoInJujuba.Click += new System.EventHandler(this.botaoInJujuba_Click);
            // 
            // botaoInPacoca
            // 
            this.botaoInPacoca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoInPacoca.Location = new System.Drawing.Point(303, 389);
            this.botaoInPacoca.Name = "botaoInPacoca";
            this.botaoInPacoca.Size = new System.Drawing.Size(106, 53);
            this.botaoInPacoca.TabIndex = 36;
            this.botaoInPacoca.Text = "Paçoca";
            this.botaoInPacoca.UseVisualStyleBackColor = true;
            this.botaoInPacoca.Click += new System.EventHandler(this.botaoInPacoca_Click_1);
            // 
            // botaoInChocoBall
            // 
            this.botaoInChocoBall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoInChocoBall.Location = new System.Drawing.Point(170, 389);
            this.botaoInChocoBall.Name = "botaoInChocoBall";
            this.botaoInChocoBall.Size = new System.Drawing.Size(106, 53);
            this.botaoInChocoBall.TabIndex = 35;
            this.botaoInChocoBall.Text = "Chobo Ball";
            this.botaoInChocoBall.UseVisualStyleBackColor = true;
            this.botaoInChocoBall.Click += new System.EventHandler(this.botaoInChocoBall_Click);
            // 
            // botaoInLeiteEmPo
            // 
            this.botaoInLeiteEmPo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoInLeiteEmPo.Location = new System.Drawing.Point(36, 389);
            this.botaoInLeiteEmPo.Name = "botaoInLeiteEmPo";
            this.botaoInLeiteEmPo.Size = new System.Drawing.Size(106, 53);
            this.botaoInLeiteEmPo.TabIndex = 34;
            this.botaoInLeiteEmPo.Text = "Leite em Pó";
            this.botaoInLeiteEmPo.UseVisualStyleBackColor = true;
            this.botaoInLeiteEmPo.Click += new System.EventHandler(this.botaoInLeiteEmPo_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(246, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "TAMANHO DO POTE";
            // 
            // botaoMil
            // 
            this.botaoMil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoMil.Location = new System.Drawing.Point(570, 260);
            this.botaoMil.Name = "botaoMil";
            this.botaoMil.Size = new System.Drawing.Size(106, 53);
            this.botaoMil.TabIndex = 32;
            this.botaoMil.Text = "1000ML";
            this.botaoMil.UseVisualStyleBackColor = true;
            this.botaoMil.Click += new System.EventHandler(this.botaoMil_Click);
            // 
            // botaoQuinhetos
            // 
            this.botaoQuinhetos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoQuinhetos.Location = new System.Drawing.Point(437, 260);
            this.botaoQuinhetos.Name = "botaoQuinhetos";
            this.botaoQuinhetos.Size = new System.Drawing.Size(106, 53);
            this.botaoQuinhetos.TabIndex = 31;
            this.botaoQuinhetos.Text = "500ML";
            this.botaoQuinhetos.UseVisualStyleBackColor = true;
            this.botaoQuinhetos.Click += new System.EventHandler(this.botaoQuinhetos_Click);
            // 
            // botaoQuatrocentos
            // 
            this.botaoQuatrocentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoQuatrocentos.Location = new System.Drawing.Point(303, 260);
            this.botaoQuatrocentos.Name = "botaoQuatrocentos";
            this.botaoQuatrocentos.Size = new System.Drawing.Size(106, 53);
            this.botaoQuatrocentos.TabIndex = 30;
            this.botaoQuatrocentos.Text = "400ML";
            this.botaoQuatrocentos.UseVisualStyleBackColor = true;
            this.botaoQuatrocentos.Click += new System.EventHandler(this.botaoQuatrocentos_Click);
            // 
            // botaoTrezentos
            // 
            this.botaoTrezentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoTrezentos.Location = new System.Drawing.Point(170, 260);
            this.botaoTrezentos.Name = "botaoTrezentos";
            this.botaoTrezentos.Size = new System.Drawing.Size(106, 53);
            this.botaoTrezentos.TabIndex = 29;
            this.botaoTrezentos.Text = "300ML";
            this.botaoTrezentos.UseVisualStyleBackColor = true;
            this.botaoTrezentos.Click += new System.EventHandler(this.botaoTrezentos_Click_1);
            // 
            // botaoDuzentos
            // 
            this.botaoDuzentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoDuzentos.Location = new System.Drawing.Point(36, 260);
            this.botaoDuzentos.Name = "botaoDuzentos";
            this.botaoDuzentos.Size = new System.Drawing.Size(106, 53);
            this.botaoDuzentos.TabIndex = 28;
            this.botaoDuzentos.Text = "200ML";
            this.botaoDuzentos.UseVisualStyleBackColor = true;
            this.botaoDuzentos.Click += new System.EventHandler(this.botaoDuzentos_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(429, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // colPruduto
            // 
            this.colPruduto.HeaderText = "Produtos";
            this.colPruduto.Name = "colPruduto";
            this.colPruduto.Width = 135;
            // 
            // colDescricao
            // 
            this.colDescricao.HeaderText = "Descrição";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.Width = 140;
            // 
            // TelaVender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(13)))), ((int)(((byte)(161)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.botaoInserir);
            this.Controls.Add(this.dtGridListaProdutos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saldoCliente);
            this.Controls.Add(this.dataVenda);
            this.Controls.Add(this.botaoDeletar);
            this.Controls.Add(this.botaoFinalizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botaoAdGranulado);
            this.Controls.Add(this.botaoAdJujuba);
            this.Controls.Add(this.botaoAdPacoca);
            this.Controls.Add(this.botaoAdChocoBall);
            this.Controls.Add(this.botaoAdLeiteEmPo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botaoInGranulado);
            this.Controls.Add(this.botaoInJujuba);
            this.Controls.Add(this.botaoInPacoca);
            this.Controls.Add(this.botaoInChocoBall);
            this.Controls.Add(this.botaoInLeiteEmPo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoMil);
            this.Controls.Add(this.botaoQuinhetos);
            this.Controls.Add(this.botaoQuatrocentos);
            this.Controls.Add(this.botaoTrezentos);
            this.Controls.Add(this.botaoDuzentos);
            this.Name = "TelaVender";
            this.Size = new System.Drawing.Size(1050, 740);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridListaProdutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoInserir;
        private System.Windows.Forms.DataGridView dtGridListaProdutos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox saldoCliente;
        private System.Windows.Forms.DateTimePicker dataVenda;
        private System.Windows.Forms.Button botaoDeletar;
        private System.Windows.Forms.Button botaoFinalizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botaoAdGranulado;
        private System.Windows.Forms.Button botaoAdJujuba;
        private System.Windows.Forms.Button botaoAdPacoca;
        private System.Windows.Forms.Button botaoAdChocoBall;
        private System.Windows.Forms.Button botaoAdLeiteEmPo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botaoInGranulado;
        private System.Windows.Forms.Button botaoInJujuba;
        private System.Windows.Forms.Button botaoInPacoca;
        private System.Windows.Forms.Button botaoInChocoBall;
        private System.Windows.Forms.Button botaoInLeiteEmPo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoMil;
        private System.Windows.Forms.Button botaoQuinhetos;
        private System.Windows.Forms.Button botaoQuatrocentos;
        private System.Windows.Forms.Button botaoTrezentos;
        private System.Windows.Forms.Button botaoDuzentos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPruduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
    }
}
