namespace TopML
{
    partial class TopKeysCode
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Look of the keys codes:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "SHIFT = +",
            "CTRL = ^",
            "ALT = %",
            "BACKSPACE = {BACKSPACE}, {BS} ou {BKSP}",
            "BREAK = {BREAK}",
            "CAPS LOCK = {CAPSLOCK}",
            "DEL ou DELETE = {DELETE} ou {DEL}",
            "SETA PARA BAIXO = {DOWN}",
            "END = {END}",
            "ENTER = {ENTER} ou ~",
            "ESC = {ESC}",
            "HELP = {HELP}",
            "HOME = {HOME}",
            "INS ou inserir = {INSERT} ou {INS}",
            "SETA À ESQUERDA = {LEFT}",
            "NUM LOCK = {NUMLOCK}",
            "PAGE DOWN = {PGDN}",
            "PAGE UP = {PGUP}",
            "PRINT SCREEN = {PRTSC} (reservado para uso futuro)",
            "SETA À DIREITA = {RIGHT}",
            "SCROLL LOCK = {SCROLLLOCK}",
            "TAB = {TAB}",
            "SETA PARA CIMA = {UP}",
            "F1 = {F1}",
            "F2 = {F2}",
            "F3 = {F3}",
            "........",
            "Adicionar de teclado = {ADD}",
            "Subtrair do teclado numérico = {SUBTRACT}",
            "Multiplicar de teclado = {MULTIPLY}",
            "Divisão do teclado numérico = {DIVIDE}"});
            this.listBox1.Location = new System.Drawing.Point(10, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(310, 446);
            this.listBox1.TabIndex = 2;
            // 
            // TopKeysCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "TopKeysCode";
            this.Text = "Keys Code";
            this.Load += new System.EventHandler(this.TopKeysCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}