namespace Toets_dubbele_klasse
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblTotaalDoelpunten = new Label();
            lblTopSchutter = new Label();
            txtNaamPloeg = new TextBox();
            txtNaamSpeler = new TextBox();
            txtRugnummer = new TextBox();
            label7 = new Label();
            btnPloegAanmaken = new Button();
            btnSpelerAanmaken = new Button();
            lstPloeg = new ListBox();
            lstSpeler = new ListBox();
            btnDoelPunt = new Button();
            btnVerwijder = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 30);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "Ploeg";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(439, 42);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Speler";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 91);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 2;
            label3.Text = "Naam ploeg:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(439, 87);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 3;
            label4.Text = "Naam:";
            // 
            // lblTotaalDoelpunten
            // 
            lblTotaalDoelpunten.AutoSize = true;
            lblTotaalDoelpunten.Location = new Point(42, 370);
            lblTotaalDoelpunten.Name = "lblTotaalDoelpunten";
            lblTotaalDoelpunten.Size = new Size(0, 20);
            lblTotaalDoelpunten.TabIndex = 4;
            // 
            // lblTopSchutter
            // 
            lblTopSchutter.AutoSize = true;
            lblTopSchutter.Location = new Point(42, 411);
            lblTopSchutter.Name = "lblTopSchutter";
            lblTopSchutter.Size = new Size(0, 20);
            lblTopSchutter.TabIndex = 5;
            // 
            // txtNaamPloeg
            // 
            txtNaamPloeg.Location = new Point(130, 91);
            txtNaamPloeg.Name = "txtNaamPloeg";
            txtNaamPloeg.Size = new Size(125, 27);
            txtNaamPloeg.TabIndex = 6;
            // 
            // txtNaamSpeler
            // 
            txtNaamSpeler.Location = new Point(539, 84);
            txtNaamSpeler.Name = "txtNaamSpeler";
            txtNaamSpeler.Size = new Size(125, 27);
            txtNaamSpeler.TabIndex = 7;
            // 
            // txtRugnummer
            // 
            txtRugnummer.Location = new Point(539, 128);
            txtRugnummer.Name = "txtRugnummer";
            txtRugnummer.Size = new Size(125, 27);
            txtRugnummer.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(439, 135);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 9;
            label7.Text = "Rugnummer:";
            // 
            // btnPloegAanmaken
            // 
            btnPloegAanmaken.Location = new Point(52, 146);
            btnPloegAanmaken.Name = "btnPloegAanmaken";
            btnPloegAanmaken.Size = new Size(168, 29);
            btnPloegAanmaken.TabIndex = 10;
            btnPloegAanmaken.Text = "Maak ploeg aan";
            btnPloegAanmaken.UseVisualStyleBackColor = true;
            btnPloegAanmaken.Click += btnPloegAanmaken_Click;
            // 
            // btnSpelerAanmaken
            // 
            btnSpelerAanmaken.Location = new Point(458, 173);
            btnSpelerAanmaken.Name = "btnSpelerAanmaken";
            btnSpelerAanmaken.Size = new Size(148, 29);
            btnSpelerAanmaken.TabIndex = 11;
            btnSpelerAanmaken.Text = "Voeg speler toe";
            btnSpelerAanmaken.UseVisualStyleBackColor = true;
            btnSpelerAanmaken.Click += btnSpelerAanmaken_Click;
            // 
            // lstPloeg
            // 
            lstPloeg.FormattingEnabled = true;
            lstPloeg.Location = new Point(29, 185);
            lstPloeg.Name = "lstPloeg";
            lstPloeg.Size = new Size(224, 164);
            lstPloeg.TabIndex = 12;
            // 
            // lstSpeler
            // 
            lstSpeler.FormattingEnabled = true;
            lstSpeler.Location = new Point(439, 209);
            lstSpeler.Name = "lstSpeler";
            lstSpeler.Size = new Size(238, 144);
            lstSpeler.TabIndex = 13;
            // 
            // btnDoelPunt
            // 
            btnDoelPunt.Location = new Point(438, 366);
            btnDoelPunt.Name = "btnDoelPunt";
            btnDoelPunt.Size = new Size(109, 29);
            btnDoelPunt.TabIndex = 14;
            btnDoelPunt.Text = "Doelpunt+1";
            btnDoelPunt.UseVisualStyleBackColor = true;
            btnDoelPunt.Click += btnDoelPunt_Click;
            // 
            // btnVerwijder
            // 
            btnVerwijder.Location = new Point(553, 366);
            btnVerwijder.Name = "btnVerwijder";
            btnVerwijder.Size = new Size(124, 29);
            btnVerwijder.TabIndex = 15;
            btnVerwijder.Text = "Verwijder speler";
            btnVerwijder.UseVisualStyleBackColor = true;
            btnVerwijder.Click += btnVerwijder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerwijder);
            Controls.Add(btnDoelPunt);
            Controls.Add(lstSpeler);
            Controls.Add(lstPloeg);
            Controls.Add(btnSpelerAanmaken);
            Controls.Add(btnPloegAanmaken);
            Controls.Add(label7);
            Controls.Add(txtRugnummer);
            Controls.Add(txtNaamSpeler);
            Controls.Add(txtNaamPloeg);
            Controls.Add(lblTopSchutter);
            Controls.Add(lblTotaalDoelpunten);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblTotaalDoelpunten;
        private Label lblTopSchutter;
        private TextBox txtNaamPloeg;
        private TextBox txtNaamSpeler;
        private TextBox txtRugnummer;
        private Label label7;
        private Button btnPloegAanmaken;
        private Button btnSpelerAanmaken;
        private ListBox lstPloeg;
        private ListBox lstSpeler;
        private Button btnDoelPunt;
        private Button btnVerwijder;
    }
}
