namespace exercicios
{
    partial class ex1A
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
            btn_cancel = new Button();
            dg1 = new DataGridView();
            txt_name = new TextBox();
            cb_teams = new ComboBox();
            number_player = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btn_insert = new Button();
            btn_showPlayer = new Button();
            btn_deletePlayer = new Button();
            ((System.ComponentModel.ISupportInitialize)dg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)number_player).BeginInit();
            SuspendLayout();
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(12, 312);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 0;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // dg1
            // 
            dg1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg1.Location = new Point(95, 12);
            dg1.Name = "dg1";
            dg1.RowTemplate.Height = 25;
            dg1.Size = new Size(240, 150);
            dg1.TabIndex = 1;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(235, 180);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(100, 23);
            txt_name.TabIndex = 2;
            // 
            // cb_teams
            // 
            cb_teams.FormattingEnabled = true;
            cb_teams.Location = new Point(235, 209);
            cb_teams.Name = "cb_teams";
            cb_teams.Size = new Size(100, 23);
            cb_teams.TabIndex = 4;
            // 
            // number_player
            // 
            number_player.Location = new Point(235, 238);
            number_player.Name = "number_player";
            number_player.Size = new Size(100, 23);
            number_player.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 183);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 212);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 7;
            label2.Text = "Team";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(171, 240);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 8;
            label3.Text = "Number";
            label3.Click += label3_Click;
            // 
            // btn_insert
            // 
            btn_insert.Location = new Point(235, 276);
            btn_insert.Name = "btn_insert";
            btn_insert.Size = new Size(100, 23);
            btn_insert.TabIndex = 9;
            btn_insert.Text = "Insert Player";
            btn_insert.UseVisualStyleBackColor = true;
            btn_insert.Click += btn_insert_Click;
            // 
            // btn_showPlayer
            // 
            btn_showPlayer.Location = new Point(12, 70);
            btn_showPlayer.Name = "btn_showPlayer";
            btn_showPlayer.Size = new Size(75, 39);
            btn_showPlayer.TabIndex = 10;
            btn_showPlayer.Text = "Show Player";
            btn_showPlayer.UseVisualStyleBackColor = true;
            btn_showPlayer.Click += btn_showPlayer_Click;
            // 
            // btn_deletePlayer
            // 
            btn_deletePlayer.Location = new Point(14, 123);
            btn_deletePlayer.Name = "btn_deletePlayer";
            btn_deletePlayer.Size = new Size(75, 39);
            btn_deletePlayer.TabIndex = 11;
            btn_deletePlayer.Text = "Delete Player";
            btn_deletePlayer.UseVisualStyleBackColor = true;
            btn_deletePlayer.Click += btn_deletePlayer_Click;
            // 
            // ex1A
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 347);
            Controls.Add(btn_deletePlayer);
            Controls.Add(btn_showPlayer);
            Controls.Add(btn_insert);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(number_player);
            Controls.Add(cb_teams);
            Controls.Add(txt_name);
            Controls.Add(dg1);
            Controls.Add(btn_cancel);
            Name = "ex1A";
            Text = "ex1A";
            Load += ex1A_Load;
            ((System.ComponentModel.ISupportInitialize)dg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)number_player).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_cancel;
        private DataGridView dg1;
        private TextBox txt_name;
        private ComboBox cb_teams;
        private NumericUpDown number_player;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btn_insert;
        private Button btn_showPlayer;
        private Button btn_deletePlayer;
    }
}