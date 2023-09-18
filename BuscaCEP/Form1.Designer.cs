namespace BuscaCEP
{
    partial class Form1
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
            btn_buscarCep = new Button();
            tb_CEP = new TextBox();
            label1 = new Label();
            lb_MostrarDados = new ListBox();
            SuspendLayout();
            // 
            // btn_buscarCep
            // 
            btn_buscarCep.Location = new Point(327, 122);
            btn_buscarCep.Name = "btn_buscarCep";
            btn_buscarCep.Size = new Size(108, 43);
            btn_buscarCep.TabIndex = 0;
            btn_buscarCep.Text = "Buscar";
            btn_buscarCep.UseVisualStyleBackColor = true;
            btn_buscarCep.Click += BuscarCEP;
            // 
            // tb_CEP
            // 
            tb_CEP.Location = new Point(241, 80);
            tb_CEP.Name = "tb_CEP";
            tb_CEP.Size = new Size(300, 23);
            tb_CEP.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(241, 31);
            label1.Name = "label1";
            label1.Size = new Size(303, 25);
            label1.TabIndex = 2;
            label1.Text = "INSIRA O CEP NO ESPAÇO ABAIXO:";
            // 
            // lb_MostrarDados
            // 
            lb_MostrarDados.FormattingEnabled = true;
            lb_MostrarDados.ItemHeight = 15;
            lb_MostrarDados.Location = new Point(214, 213);
            lb_MostrarDados.Name = "lb_MostrarDados";
            lb_MostrarDados.Size = new Size(351, 184);
            lb_MostrarDados.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aqua;
            ClientSize = new Size(800, 450);
            Controls.Add(lb_MostrarDados);
            Controls.Add(label1);
            Controls.Add(tb_CEP);
            Controls.Add(btn_buscarCep);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_buscarCep;
        private TextBox tb_CEP;
        private Label label1;
        private ListBox lb_MostrarDados;
    }
}