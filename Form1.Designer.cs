namespace PaletaDeColores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            Aqua = new Button();
            Lime = new Button();
            Green = new Button();
            GreenYellow = new Button();
            Azul = new Button();
            Pink = new Button();
            Purple = new Button();
            Orange = new Button();
            Black = new Button();
            Yellow = new Button();
            Gray = new Button();
            Rojo = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            Paleta = new Panel();
            paletaText = new Label();
            limpiarPaleta = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Paleta.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Aqua);
            panel1.Controls.Add(limpiarPaleta);
            panel1.Controls.Add(Lime);
            panel1.Controls.Add(Green);
            panel1.Controls.Add(GreenYellow);
            panel1.Controls.Add(Azul);
            panel1.Controls.Add(Pink);
            panel1.Controls.Add(Purple);
            panel1.Controls.Add(Orange);
            panel1.Controls.Add(Black);
            panel1.Controls.Add(Yellow);
            panel1.Controls.Add(Gray);
            panel1.Controls.Add(Rojo);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(199, 513);
            panel1.TabIndex = 0;
            // 
            // Aqua
            // 
            Aqua.BackColor = Color.Aqua;
            Aqua.Location = new Point(3, 338);
            Aqua.Name = "Aqua";
            Aqua.Size = new Size(93, 47);
            Aqua.TabIndex = 13;
            Aqua.UseVisualStyleBackColor = false;
            Aqua.Click += button12_Click;
            // 
            // Lime
            // 
            Lime.BackColor = Color.Lime;
            Lime.Location = new Point(102, 338);
            Lime.Name = "Lime";
            Lime.Size = new Size(93, 47);
            Lime.TabIndex = 12;
            Lime.UseVisualStyleBackColor = false;
            Lime.Click += Lime_Click;
            // 
            // Green
            // 
            Green.BackColor = Color.Green;
            Green.Location = new Point(3, 391);
            Green.Name = "Green";
            Green.Size = new Size(93, 47);
            Green.TabIndex = 11;
            Green.UseVisualStyleBackColor = false;
            Green.Click += Green_Click;
            // 
            // GreenYellow
            // 
            GreenYellow.BackColor = Color.GreenYellow;
            GreenYellow.Location = new Point(102, 391);
            GreenYellow.Name = "GreenYellow";
            GreenYellow.Size = new Size(93, 47);
            GreenYellow.TabIndex = 10;
            GreenYellow.UseVisualStyleBackColor = false;
            GreenYellow.Click += GreenYellow_Click;
            // 
            // Azul
            // 
            Azul.BackColor = Color.FromArgb(0, 0, 192);
            Azul.Location = new Point(102, 131);
            Azul.Name = "Azul";
            Azul.Size = new Size(93, 47);
            Azul.TabIndex = 8;
            Azul.UseVisualStyleBackColor = false;
            Azul.Click += Azul_Click;
            // 
            // Pink
            // 
            Pink.BackColor = Color.Pink;
            Pink.Location = new Point(3, 184);
            Pink.Name = "Pink";
            Pink.Size = new Size(93, 47);
            Pink.TabIndex = 7;
            Pink.UseVisualStyleBackColor = false;
            Pink.Click += Pink_Click;
            // 
            // Purple
            // 
            Purple.BackColor = Color.Purple;
            Purple.Location = new Point(102, 184);
            Purple.Name = "Purple";
            Purple.Size = new Size(93, 47);
            Purple.TabIndex = 6;
            Purple.UseVisualStyleBackColor = false;
            Purple.Click += Purple_Click;
            // 
            // Orange
            // 
            Orange.BackColor = Color.FromArgb(255, 128, 0);
            Orange.Location = new Point(3, 285);
            Orange.Name = "Orange";
            Orange.Size = new Size(93, 47);
            Orange.TabIndex = 5;
            Orange.UseVisualStyleBackColor = false;
            Orange.Click += Orange_Click;
            // 
            // Black
            // 
            Black.BackColor = Color.Black;
            Black.Location = new Point(102, 285);
            Black.Name = "Black";
            Black.Size = new Size(93, 47);
            Black.TabIndex = 4;
            Black.UseVisualStyleBackColor = false;
            Black.Click += Black_Click;
            // 
            // Yellow
            // 
            Yellow.BackColor = Color.Yellow;
            Yellow.Location = new Point(3, 232);
            Yellow.Name = "Yellow";
            Yellow.Size = new Size(93, 47);
            Yellow.TabIndex = 3;
            Yellow.UseVisualStyleBackColor = false;
            Yellow.Click += Yellow_Click;
            // 
            // Gray
            // 
            Gray.BackColor = Color.Gray;
            Gray.Location = new Point(102, 232);
            Gray.Name = "Gray";
            Gray.Size = new Size(93, 47);
            Gray.TabIndex = 2;
            Gray.UseVisualStyleBackColor = false;
            Gray.Click += Gray_Click;
            // 
            // Rojo
            // 
            Rojo.BackColor = Color.Red;
            Rojo.Location = new Point(3, 131);
            Rojo.Name = "Rojo";
            Rojo.Size = new Size(93, 47);
            Rojo.TabIndex = 1;
            Rojo.UseVisualStyleBackColor = false;
            Rojo.Click += Rojo_Click;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.paleta_de_colores;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(197, 125);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Paleta
            // 
            Paleta.BorderStyle = BorderStyle.Fixed3D;
            Paleta.Controls.Add(paletaText);
            Paleta.Location = new Point(397, 87);
            Paleta.Name = "Paleta";
            Paleta.Size = new Size(283, 352);
            Paleta.TabIndex = 1;
            Paleta.Paint += Paleta_Paint;
            // 
            // paletaText
            // 
            paletaText.AutoSize = true;
            paletaText.BackColor = Color.Transparent;
            paletaText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            paletaText.ForeColor = SystemColors.ButtonHighlight;
            paletaText.Location = new Point(102, 160);
            paletaText.Name = "paletaText";
            paletaText.Size = new Size(81, 31);
            paletaText.TabIndex = 0;
            paletaText.Text = "label1";
            paletaText.Visible = false;
            // 
            // limpiarPaleta
            // 
            limpiarPaleta.BackColor = Color.Pink;
            limpiarPaleta.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            limpiarPaleta.Location = new Point(27, 453);
            limpiarPaleta.Name = "limpiarPaleta";
            limpiarPaleta.Size = new Size(140, 31);
            limpiarPaleta.TabIndex = 2;
            limpiarPaleta.Text = "Limpiar Paleta";
            limpiarPaleta.UseVisualStyleBackColor = false;
            limpiarPaleta.Click += limpiarPaleta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(385, 23);
            label1.Name = "label1";
            label1.Size = new Size(306, 37);
            label1.TabIndex = 3;
            label1.Text = "Paleta de colores";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 513);
            Controls.Add(label1);
            Controls.Add(Paleta);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "PaletaDeColores";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Paleta.ResumeLayout(false);
            Paleta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel Paleta;
        private Button Rojo;
        private Button Aqua;
        private Button Lime;
        private Button Green;
        private Button GreenYellow;
        private Button Azul;
        private Button Pink;
        private Button Purple;
        private Button Orange;
        private Button Black;
        private Button Yellow;
        private Button Gray;
        private PictureBox pictureBox1;
        private Label paletaText;
        private Button limpiarPaleta;
        private Label label1;
    }
}
