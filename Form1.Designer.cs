namespace FormsCalculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuEncabezado = new System.Windows.Forms.MenuStrip();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estándarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarCtrlVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeLaAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeLaCalculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBoxVentana = new System.Windows.Forms.TextBox();
            this.btnRetroceso = new System.Windows.Forms.Button();
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnClearTextBox = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnExponenciacion = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnRadicacion = new System.Windows.Forms.Button();
            this.menuEncabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuEncabezado
            // 
            this.menuEncabezado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuEncabezado.Location = new System.Drawing.Point(0, 0);
            this.menuEncabezado.Name = "menuEncabezado";
            this.menuEncabezado.Size = new System.Drawing.Size(215, 24);
            this.menuEncabezado.TabIndex = 0;
            this.menuEncabezado.Text = "menuEncabezado";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estándarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // estándarToolStripMenuItem
            // 
            this.estándarToolStripMenuItem.Name = "estándarToolStripMenuItem";
            this.estándarToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.estándarToolStripMenuItem.Text = "Estándar";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.pegarCtrlVToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.editarToolStripMenuItem.Text = "Edición";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.copiarToolStripMenuItem.Text = "Copiar ctrl + c";
            // 
            // pegarCtrlVToolStripMenuItem
            // 
            this.pegarCtrlVToolStripMenuItem.Name = "pegarCtrlVToolStripMenuItem";
            this.pegarCtrlVToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.pegarCtrlVToolStripMenuItem.Text = "Pegar ctrl + v";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeLaAyudaToolStripMenuItem,
            this.acercaDeLaCalculadoraToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeLaAyudaToolStripMenuItem
            // 
            this.acercaDeLaAyudaToolStripMenuItem.Name = "acercaDeLaAyudaToolStripMenuItem";
            this.acercaDeLaAyudaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.acercaDeLaAyudaToolStripMenuItem.Text = "Ver la Ayuda";
            // 
            // acercaDeLaCalculadoraToolStripMenuItem
            // 
            this.acercaDeLaCalculadoraToolStripMenuItem.Name = "acercaDeLaCalculadoraToolStripMenuItem";
            this.acercaDeLaCalculadoraToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.acercaDeLaCalculadoraToolStripMenuItem.Text = "Acerca de la Calculadora";
            // 
            // txtBoxVentana
            // 
            this.txtBoxVentana.Enabled = false;
            this.txtBoxVentana.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxVentana.Location = new System.Drawing.Point(12, 27);
            this.txtBoxVentana.Multiline = true;
            this.txtBoxVentana.Name = "txtBoxVentana";
            this.txtBoxVentana.ReadOnly = true;
            this.txtBoxVentana.Size = new System.Drawing.Size(185, 90);
            this.txtBoxVentana.TabIndex = 1;
            this.txtBoxVentana.Text = "0";
            this.txtBoxVentana.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRetroceso
            // 
            this.btnRetroceso.Location = new System.Drawing.Point(18, 144);
            this.btnRetroceso.Name = "btnRetroceso";
            this.btnRetroceso.Size = new System.Drawing.Size(68, 32);
            this.btnRetroceso.TabIndex = 2;
            this.btnRetroceso.Text = "←";
            this.btnRetroceso.UseVisualStyleBackColor = true;
            this.btnRetroceso.Click += new System.EventHandler(this.btnRetroceso_Click);
            // 
            // btnNum7
            // 
            this.btnNum7.Location = new System.Drawing.Point(18, 182);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(31, 32);
            this.btnNum7.TabIndex = 3;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.btnNum7_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Location = new System.Drawing.Point(18, 220);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(31, 32);
            this.btnNum4.TabIndex = 4;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.Location = new System.Drawing.Point(18, 258);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(31, 32);
            this.btnNum1.TabIndex = 5;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.Location = new System.Drawing.Point(18, 296);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(68, 32);
            this.btnNum0.TabIndex = 6;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Location = new System.Drawing.Point(55, 258);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(31, 32);
            this.btnNum2.TabIndex = 10;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Location = new System.Drawing.Point(55, 220);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(31, 32);
            this.btnNum5.TabIndex = 9;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.btnNum5_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Location = new System.Drawing.Point(55, 182);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(31, 32);
            this.btnNum8.TabIndex = 8;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.btnNum8_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Location = new System.Drawing.Point(92, 296);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(31, 32);
            this.btnPunto.TabIndex = 16;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            // 
            // btnNum3
            // 
            this.btnNum3.Location = new System.Drawing.Point(92, 258);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(31, 32);
            this.btnNum3.TabIndex = 15;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.Location = new System.Drawing.Point(92, 220);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(31, 32);
            this.btnNum6.TabIndex = 14;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Location = new System.Drawing.Point(92, 182);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(31, 32);
            this.btnNum9.TabIndex = 13;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.btnNum9_Click);
            // 
            // btnClearTextBox
            // 
            this.btnClearTextBox.Location = new System.Drawing.Point(92, 144);
            this.btnClearTextBox.Name = "btnClearTextBox";
            this.btnClearTextBox.Size = new System.Drawing.Size(31, 32);
            this.btnClearTextBox.TabIndex = 12;
            this.btnClearTextBox.Text = "C";
            this.btnClearTextBox.UseVisualStyleBackColor = true;
            this.btnClearTextBox.Click += new System.EventHandler(this.btnClearTextBox_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(129, 258);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(31, 70);
            this.btnSuma.TabIndex = 21;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(129, 220);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(31, 32);
            this.btnResta.TabIndex = 19;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Location = new System.Drawing.Point(129, 182);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(31, 32);
            this.btnMultiplicacion.TabIndex = 18;
            this.btnMultiplicacion.Text = "*";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnExponenciacion
            // 
            this.btnExponenciacion.Location = new System.Drawing.Point(129, 144);
            this.btnExponenciacion.Name = "btnExponenciacion";
            this.btnExponenciacion.Size = new System.Drawing.Size(31, 32);
            this.btnExponenciacion.TabIndex = 17;
            this.btnExponenciacion.Text = "^2";
            this.btnExponenciacion.UseVisualStyleBackColor = true;
            this.btnExponenciacion.Click += new System.EventHandler(this.btnExponenciacion_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(166, 220);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(31, 108);
            this.btnIgual.TabIndex = 26;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(166, 182);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(31, 32);
            this.btnDivision.TabIndex = 23;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnRadicacion
            // 
            this.btnRadicacion.Location = new System.Drawing.Point(166, 144);
            this.btnRadicacion.Name = "btnRadicacion";
            this.btnRadicacion.Size = new System.Drawing.Size(31, 32);
            this.btnRadicacion.TabIndex = 22;
            this.btnRadicacion.Text = "2√";
            this.btnRadicacion.UseVisualStyleBackColor = true;
            this.btnRadicacion.Click += new System.EventHandler(this.btnRadicacion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(215, 354);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnRadicacion);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnExponenciacion);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnClearTextBox);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnNum7);
            this.Controls.Add(this.btnRetroceso);
            this.Controls.Add(this.txtBoxVentana);
            this.Controls.Add(this.menuEncabezado);
            this.MainMenuStrip = this.menuEncabezado;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Calculadora";
            this.menuEncabezado.ResumeLayout(false);
            this.menuEncabezado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuEncabezado;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estándarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarCtrlVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeLaAyudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeLaCalculadoraToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBoxVentana;
        private System.Windows.Forms.Button btnRetroceso;
        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnClearTextBox;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnExponenciacion;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnRadicacion;
    }
}

