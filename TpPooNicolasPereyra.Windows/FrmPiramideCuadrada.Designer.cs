namespace TpPooNicolasPereyra.Windows
{
    partial class FrmPiramideCuadrada
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLado = new TextBox();
            txtAltura = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnOK = new Button();
            btnCancelar = new Button();
            LstPiramideCuadrada = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtLado
            // 
            txtLado.Location = new Point(79, 40);
            txtLado.Name = "txtLado";
            txtLado.Size = new Size(100, 23);
            txtLado.TabIndex = 0;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(79, 90);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 43);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 2;
            label1.Text = "Lado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 93);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Altura:";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(35, 143);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(83, 42);
            btnOK.TabIndex = 4;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(176, 143);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(83, 42);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // LstPiramideCuadrada
            // 
            LstPiramideCuadrada.FormattingEnabled = true;
            LstPiramideCuadrada.ItemHeight = 15;
            LstPiramideCuadrada.Location = new Point(35, 229);
            LstPiramideCuadrada.Name = "LstPiramideCuadrada";
            LstPiramideCuadrada.Size = new Size(206, 94);
            LstPiramideCuadrada.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 211);
            label3.Name = "label3";
            label3.Size = new Size(161, 15);
            label3.TabIndex = 7;
            label3.Text = "Lista de Pirámides Cuadradas";
            // 
            // FrmPiramideCuadrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 349);
            Controls.Add(label3);
            Controls.Add(LstPiramideCuadrada);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAltura);
            Controls.Add(txtLado);
            Name = "FrmPiramideCuadrada";
            Text = "Pirámide Cuadrada";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLado;
        private TextBox txtAltura;
        private Label label1;
        private Label label2;
        private Button btnOK;
        private Button btnCancelar;
        private ListBox LstPiramideCuadrada;
        private Label label3;
    }
}
