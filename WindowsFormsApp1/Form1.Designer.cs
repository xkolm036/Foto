namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Zrcadlit = new System.Windows.Forms.Button();
            this.textBox_Zdroj = new System.Windows.Forms.TextBox();
            this.textBox_Cil = new System.Windows.Forms.TextBox();
            this.textBox_Kopirovat = new System.Windows.Forms.TextBox();
            this.label_zdroj = new System.Windows.Forms.Label();
            this.label_Cil = new System.Windows.Forms.Label();
            this.label_Kopirovat = new System.Windows.Forms.Label();
            this.button_kopirovat = new System.Windows.Forms.Button();
            this.button_mega = new System.Windows.Forms.Button();
            this.button_Duplicity = new System.Windows.Forms.Button();
            this.button_zobrazNove = new System.Windows.Forms.Button();
            this.checkBox_move = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button_prehod = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_ulozitList = new System.Windows.Forms.Button();
            this.button_nacistlist = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox_list = new System.Windows.Forms.CheckBox();
            this.button_odebratList = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Zrcadlit
            // 
            this.button_Zrcadlit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Zrcadlit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Zrcadlit.FlatAppearance.BorderSize = 0;
            this.button_Zrcadlit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Zrcadlit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Zrcadlit.ForeColor = System.Drawing.Color.Black;
            this.button_Zrcadlit.Location = new System.Drawing.Point(0, 42);
            this.button_Zrcadlit.Margin = new System.Windows.Forms.Padding(0);
            this.button_Zrcadlit.Name = "button_Zrcadlit";
            this.button_Zrcadlit.Size = new System.Drawing.Size(210, 30);
            this.button_Zrcadlit.TabIndex = 0;
            this.button_Zrcadlit.Text = "Zrcadlit";
            this.button_Zrcadlit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Zrcadlit.UseVisualStyleBackColor = false;
            this.button_Zrcadlit.Click += new System.EventHandler(this.button_Zrcadlit_Click);
            this.button_Zrcadlit.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_Zrcadlit.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // textBox_Zdroj
            // 
            this.textBox_Zdroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Zdroj.Location = new System.Drawing.Point(8, 28);
            this.textBox_Zdroj.Name = "textBox_Zdroj";
            this.textBox_Zdroj.Size = new System.Drawing.Size(591, 31);
            this.textBox_Zdroj.TabIndex = 5;
            this.textBox_Zdroj.TextChanged += new System.EventHandler(this.textBox_Zdroj_TextChanged);
            // 
            // textBox_Cil
            // 
            this.textBox_Cil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Cil.Location = new System.Drawing.Point(6, 39);
            this.textBox_Cil.Name = "textBox_Cil";
            this.textBox_Cil.Size = new System.Drawing.Size(591, 31);
            this.textBox_Cil.TabIndex = 6;
            this.textBox_Cil.TextChanged += new System.EventHandler(this.textBox_Cil_TextChanged);
            // 
            // textBox_Kopirovat
            // 
            this.textBox_Kopirovat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Kopirovat.Location = new System.Drawing.Point(8, 37);
            this.textBox_Kopirovat.Name = "textBox_Kopirovat";
            this.textBox_Kopirovat.Size = new System.Drawing.Size(591, 31);
            this.textBox_Kopirovat.TabIndex = 7;
            this.textBox_Kopirovat.TextChanged += new System.EventHandler(this.textBox_Kopirovat_TextChanged);
            // 
            // label_zdroj
            // 
            this.label_zdroj.AutoSize = true;
            this.label_zdroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_zdroj.Location = new System.Drawing.Point(6, -1);
            this.label_zdroj.Name = "label_zdroj";
            this.label_zdroj.Size = new System.Drawing.Size(127, 25);
            this.label_zdroj.TabIndex = 8;
            this.label_zdroj.Text = "Nové Fotky:";
            // 
            // label_Cil
            // 
            this.label_Cil.AutoSize = true;
            this.label_Cil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Cil.Location = new System.Drawing.Point(6, 7);
            this.label_Cil.Name = "label_Cil";
            this.label_Cil.Size = new System.Drawing.Size(169, 25);
            this.label_Cil.TabIndex = 9;
            this.label_Cil.Text = "Záloha(odděl ; ):";
            // 
            // label_Kopirovat
            // 
            this.label_Kopirovat.AutoSize = true;
            this.label_Kopirovat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Kopirovat.Location = new System.Drawing.Point(6, 9);
            this.label_Kopirovat.Name = "label_Kopirovat";
            this.label_Kopirovat.Size = new System.Drawing.Size(260, 25);
            this.label_Kopirovat.TabIndex = 10;
            this.label_Kopirovat.Text = "Kam kopírovat nové fotky:";
            // 
            // button_kopirovat
            // 
            this.button_kopirovat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_kopirovat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_kopirovat.FlatAppearance.BorderSize = 0;
            this.button_kopirovat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kopirovat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_kopirovat.ForeColor = System.Drawing.Color.Black;
            this.button_kopirovat.Location = new System.Drawing.Point(0, 81);
            this.button_kopirovat.Margin = new System.Windows.Forms.Padding(0);
            this.button_kopirovat.Name = "button_kopirovat";
            this.button_kopirovat.Size = new System.Drawing.Size(210, 61);
            this.button_kopirovat.TabIndex = 11;
            this.button_kopirovat.Text = "Kopírovat nové do složky";
            this.button_kopirovat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kopirovat.UseVisualStyleBackColor = false;
            this.button_kopirovat.Click += new System.EventHandler(this.button_kopirovat_Click);
            this.button_kopirovat.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_kopirovat.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button_mega
            // 
            this.button_mega.BackColor = System.Drawing.SystemColors.Control;
            this.button_mega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_mega.FlatAppearance.BorderSize = 0;
            this.button_mega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_mega.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_mega.ForeColor = System.Drawing.Color.Black;
            this.button_mega.Location = new System.Drawing.Point(205, -1);
            this.button_mega.Margin = new System.Windows.Forms.Padding(0);
            this.button_mega.Name = "button_mega";
            this.button_mega.Size = new System.Drawing.Size(173, 33);
            this.button_mega.TabIndex = 12;
            this.button_mega.Text = "Zálohovat na mega";
            this.button_mega.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_mega.UseVisualStyleBackColor = false;
            this.button_mega.Click += new System.EventHandler(this.button_mega_Click);
            this.button_mega.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_mega.MouseLeave += new System.EventHandler(this.button_MouseLeavew);
            // 
            // button_Duplicity
            // 
            this.button_Duplicity.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Duplicity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Duplicity.FlatAppearance.BorderSize = 0;
            this.button_Duplicity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Duplicity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Duplicity.ForeColor = System.Drawing.Color.Black;
            this.button_Duplicity.Location = new System.Drawing.Point(0, 150);
            this.button_Duplicity.Margin = new System.Windows.Forms.Padding(0);
            this.button_Duplicity.Name = "button_Duplicity";
            this.button_Duplicity.Size = new System.Drawing.Size(210, 30);
            this.button_Duplicity.TabIndex = 13;
            this.button_Duplicity.Text = "Zobrazit dublicity";
            this.button_Duplicity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Duplicity.UseVisualStyleBackColor = false;
            this.button_Duplicity.Click += new System.EventHandler(this.button_Duplicity_Click);
            this.button_Duplicity.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_Duplicity.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button_zobrazNove
            // 
            this.button_zobrazNove.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_zobrazNove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_zobrazNove.FlatAppearance.BorderSize = 0;
            this.button_zobrazNove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_zobrazNove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_zobrazNove.ForeColor = System.Drawing.Color.Black;
            this.button_zobrazNove.Location = new System.Drawing.Point(0, 0);
            this.button_zobrazNove.Margin = new System.Windows.Forms.Padding(0);
            this.button_zobrazNove.Name = "button_zobrazNove";
            this.button_zobrazNove.Size = new System.Drawing.Size(210, 32);
            this.button_zobrazNove.TabIndex = 15;
            this.button_zobrazNove.Text = "Zobrazit nové";
            this.button_zobrazNove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_zobrazNove.UseVisualStyleBackColor = false;
            this.button_zobrazNove.Click += new System.EventHandler(this.button2_Click);
            this.button_zobrazNove.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_zobrazNove.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // checkBox_move
            // 
            this.checkBox_move.AutoSize = true;
            this.checkBox_move.Checked = true;
            this.checkBox_move.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_move.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_move.Location = new System.Drawing.Point(6, 74);
            this.checkBox_move.Name = "checkBox_move";
            this.checkBox_move.Size = new System.Drawing.Size(105, 24);
            this.checkBox_move.TabIndex = 16;
            this.checkBox_move.Text = "Přesunout";
            this.checkBox_move.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel1.Location = new System.Drawing.Point(506, 77);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(130, 24);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.mega.nz";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button_prehod
            // 
            this.button_prehod.FlatAppearance.BorderSize = 0;
            this.button_prehod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_prehod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_prehod.Location = new System.Drawing.Point(205, 6);
            this.button_prehod.Name = "button_prehod";
            this.button_prehod.Size = new System.Drawing.Size(163, 30);
            this.button_prehod.TabIndex = 18;
            this.button_prehod.Text = "Přehodit cíl a zdroj";
            this.button_prehod.UseVisualStyleBackColor = true;
            this.button_prehod.Click += new System.EventHandler(this.button_prehod_Click);
            this.button_prehod.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_prehod.MouseLeave += new System.EventHandler(this.button_MouseLeavew);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(132, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "▼";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(173, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "▼";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(269, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "▼";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.button_ulozitList);
            this.panel1.Controls.Add(this.button_nacistlist);
            this.panel1.Controls.Add(this.button_zobrazNove);
            this.panel1.Controls.Add(this.button_Zrcadlit);
            this.panel1.Controls.Add(this.button_kopirovat);
            this.panel1.Controls.Add(this.button_Duplicity);
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 258);
            this.panel1.TabIndex = 22;
            // 
            // button_ulozitList
            // 
            this.button_ulozitList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_ulozitList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ulozitList.FlatAppearance.BorderSize = 0;
            this.button_ulozitList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ulozitList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_ulozitList.ForeColor = System.Drawing.Color.Black;
            this.button_ulozitList.Location = new System.Drawing.Point(0, 222);
            this.button_ulozitList.Margin = new System.Windows.Forms.Padding(0);
            this.button_ulozitList.Name = "button_ulozitList";
            this.button_ulozitList.Size = new System.Drawing.Size(210, 36);
            this.button_ulozitList.TabIndex = 17;
            this.button_ulozitList.Text = "Uložit list";
            this.button_ulozitList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ulozitList.UseVisualStyleBackColor = false;
            this.button_ulozitList.Click += new System.EventHandler(this.button_ulozitList_Click);
            this.button_ulozitList.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_ulozitList.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button_nacistlist
            // 
            this.button_nacistlist.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_nacistlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_nacistlist.FlatAppearance.BorderSize = 0;
            this.button_nacistlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nacistlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_nacistlist.ForeColor = System.Drawing.Color.Black;
            this.button_nacistlist.Location = new System.Drawing.Point(0, 187);
            this.button_nacistlist.Margin = new System.Windows.Forms.Padding(0);
            this.button_nacistlist.Name = "button_nacistlist";
            this.button_nacistlist.Size = new System.Drawing.Size(210, 30);
            this.button_nacistlist.TabIndex = 16;
            this.button_nacistlist.Text = "Načíst list";
            this.button_nacistlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nacistlist.UseVisualStyleBackColor = false;
            this.button_nacistlist.Click += new System.EventHandler(this.button_nacistlist_Click);
            this.button_nacistlist.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_nacistlist.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.label_zdroj);
            this.panel2.Controls.Add(this.textBox_Zdroj);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button_mega);
            this.panel2.Location = new System.Drawing.Point(212, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 72);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.checkBox_list);
            this.panel3.Controls.Add(this.button_odebratList);
            this.panel3.Controls.Add(this.button_prehod);
            this.panel3.Controls.Add(this.label_Cil);
            this.panel3.Controls.Add(this.textBox_Cil);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(212, 73);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(648, 78);
            this.panel3.TabIndex = 24;
            // 
            // checkBox_list
            // 
            this.checkBox_list.AutoSize = true;
            this.checkBox_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_list.Location = new System.Drawing.Point(497, 11);
            this.checkBox_list.Name = "checkBox_list";
            this.checkBox_list.Size = new System.Drawing.Size(102, 24);
            this.checkBox_list.TabIndex = 22;
            this.checkBox_list.Text = "Pouze list";
            this.checkBox_list.UseVisualStyleBackColor = true;
            this.checkBox_list.Visible = false;
            this.checkBox_list.CheckedChanged += new System.EventHandler(this.checkBox_list_CheckedChanged);
            // 
            // button_odebratList
            // 
            this.button_odebratList.FlatAppearance.BorderSize = 0;
            this.button_odebratList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_odebratList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_odebratList.Location = new System.Drawing.Point(374, 7);
            this.button_odebratList.Name = "button_odebratList";
            this.button_odebratList.Size = new System.Drawing.Size(115, 30);
            this.button_odebratList.TabIndex = 21;
            this.button_odebratList.Text = "Odebrat List";
            this.button_odebratList.UseVisualStyleBackColor = true;
            this.button_odebratList.Visible = false;
            this.button_odebratList.Click += new System.EventHandler(this.button_odebratList_Click);
            this.button_odebratList.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_odebratList.MouseLeave += new System.EventHandler(this.button_MouseLeavew);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.checkBox_move);
            this.panel4.Controls.Add(this.textBox_Kopirovat);
            this.panel4.Controls.Add(this.label_Kopirovat);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.linkLabel1);
            this.panel4.Location = new System.Drawing.Point(212, 151);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(647, 102);
            this.panel4.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(860, 254);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foto Tools";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Zrcadlit;
        private System.Windows.Forms.TextBox textBox_Zdroj;
        private System.Windows.Forms.TextBox textBox_Cil;
        private System.Windows.Forms.TextBox textBox_Kopirovat;
        private System.Windows.Forms.Label label_zdroj;
        private System.Windows.Forms.Label label_Cil;
        private System.Windows.Forms.Label label_Kopirovat;
        private System.Windows.Forms.Button button_kopirovat;
        private System.Windows.Forms.Button button_mega;
        private System.Windows.Forms.Button button_Duplicity;
        private System.Windows.Forms.Button button_zobrazNove;
        private System.Windows.Forms.CheckBox checkBox_move;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button_prehod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_ulozitList;
        private System.Windows.Forms.Button button_nacistlist;
        private System.Windows.Forms.Button button_odebratList;
        private System.Windows.Forms.CheckBox checkBox_list;
    }
}

