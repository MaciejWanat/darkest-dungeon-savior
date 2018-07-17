namespace darkest_dungeon_savegame
{
    partial class MainForm
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
            this.SaveGame_bt = new System.Windows.Forms.Button();
            this.LoadGame_bt = new System.Windows.Forms.Button();
            this.LoadPath_tb = new System.Windows.Forms.TextBox();
            this.SetLoadPath_bt = new System.Windows.Forms.Button();
            this.Output_lb = new System.Windows.Forms.Label();
            this.CurrentLoadPath_lb = new System.Windows.Forms.Label();
            this.Slot1_rb = new System.Windows.Forms.RadioButton();
            this.Slot2_rb = new System.Windows.Forms.RadioButton();
            this.Slot3_rb = new System.Windows.Forms.RadioButton();
            this.Slots_gb = new System.Windows.Forms.GroupBox();
            this.Slots_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveGame_bt
            // 
            this.SaveGame_bt.Location = new System.Drawing.Point(12, 183);
            this.SaveGame_bt.Name = "SaveGame_bt";
            this.SaveGame_bt.Size = new System.Drawing.Size(75, 23);
            this.SaveGame_bt.TabIndex = 0;
            this.SaveGame_bt.Text = "Save Game";
            this.SaveGame_bt.UseVisualStyleBackColor = true;
            this.SaveGame_bt.Click += new System.EventHandler(this.SaveGame_bt_Click);
            // 
            // LoadGame_bt
            // 
            this.LoadGame_bt.Location = new System.Drawing.Point(93, 183);
            this.LoadGame_bt.Name = "LoadGame_bt";
            this.LoadGame_bt.Size = new System.Drawing.Size(75, 23);
            this.LoadGame_bt.TabIndex = 1;
            this.LoadGame_bt.Text = "Load Game";
            this.LoadGame_bt.UseVisualStyleBackColor = true;
            this.LoadGame_bt.Click += new System.EventHandler(this.LoadGame_bt_Click);
            // 
            // LoadPath_tb
            // 
            this.LoadPath_tb.Location = new System.Drawing.Point(12, 212);
            this.LoadPath_tb.Name = "LoadPath_tb";
            this.LoadPath_tb.Size = new System.Drawing.Size(338, 20);
            this.LoadPath_tb.TabIndex = 2;
            // 
            // SetLoadPath_bt
            // 
            this.SetLoadPath_bt.Location = new System.Drawing.Point(368, 212);
            this.SetLoadPath_bt.Name = "SetLoadPath_bt";
            this.SetLoadPath_bt.Size = new System.Drawing.Size(117, 23);
            this.SetLoadPath_bt.TabIndex = 3;
            this.SetLoadPath_bt.Text = "Set saves path";
            this.SetLoadPath_bt.UseVisualStyleBackColor = true;
            this.SetLoadPath_bt.Click += new System.EventHandler(this.SetLoadPath_bt_Click);
            // 
            // Output_lb
            // 
            this.Output_lb.AutoSize = true;
            this.Output_lb.Location = new System.Drawing.Point(15, 34);
            this.Output_lb.Name = "Output_lb";
            this.Output_lb.Size = new System.Drawing.Size(35, 13);
            this.Output_lb.TabIndex = 4;
            this.Output_lb.Text = "label1";
            // 
            // CurrentLoadPath_lb
            // 
            this.CurrentLoadPath_lb.AutoSize = true;
            this.CurrentLoadPath_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CurrentLoadPath_lb.Location = new System.Drawing.Point(16, 9);
            this.CurrentLoadPath_lb.Name = "CurrentLoadPath_lb";
            this.CurrentLoadPath_lb.Size = new System.Drawing.Size(109, 13);
            this.CurrentLoadPath_lb.TabIndex = 5;
            this.CurrentLoadPath_lb.Text = "Current load path:";
            this.CurrentLoadPath_lb.Click += new System.EventHandler(this.CurrentLoadPath_lb_Click);
            // 
            // Slot1_rb
            // 
            this.Slot1_rb.AutoSize = true;
            this.Slot1_rb.Checked = true;
            this.Slot1_rb.Location = new System.Drawing.Point(6, 19);
            this.Slot1_rb.Name = "Slot1_rb";
            this.Slot1_rb.Size = new System.Drawing.Size(52, 17);
            this.Slot1_rb.TabIndex = 6;
            this.Slot1_rb.TabStop = true;
            this.Slot1_rb.Text = "Slot 1";
            this.Slot1_rb.UseVisualStyleBackColor = true;
            this.Slot1_rb.CheckedChanged += new System.EventHandler(this.Slot1_rb_CheckedChanged);
            // 
            // Slot2_rb
            // 
            this.Slot2_rb.AutoSize = true;
            this.Slot2_rb.Location = new System.Drawing.Point(6, 42);
            this.Slot2_rb.Name = "Slot2_rb";
            this.Slot2_rb.Size = new System.Drawing.Size(52, 17);
            this.Slot2_rb.TabIndex = 7;
            this.Slot2_rb.Text = "Slot 2";
            this.Slot2_rb.UseVisualStyleBackColor = true;
            this.Slot2_rb.CheckedChanged += new System.EventHandler(this.Slot2_rb_CheckedChanged);
            // 
            // Slot3_rb
            // 
            this.Slot3_rb.AutoSize = true;
            this.Slot3_rb.Location = new System.Drawing.Point(7, 65);
            this.Slot3_rb.Name = "Slot3_rb";
            this.Slot3_rb.Size = new System.Drawing.Size(52, 17);
            this.Slot3_rb.TabIndex = 8;
            this.Slot3_rb.Text = "Slot 3";
            this.Slot3_rb.UseVisualStyleBackColor = true;
            this.Slot3_rb.CheckedChanged += new System.EventHandler(this.Slot3_rb_CheckedChanged);
            // 
            // Slots_gb
            // 
            this.Slots_gb.Controls.Add(this.Slot1_rb);
            this.Slots_gb.Controls.Add(this.Slot3_rb);
            this.Slots_gb.Controls.Add(this.Slot2_rb);
            this.Slots_gb.Location = new System.Drawing.Point(12, 90);
            this.Slots_gb.Name = "Slots_gb";
            this.Slots_gb.Size = new System.Drawing.Size(72, 87);
            this.Slots_gb.TabIndex = 9;
            this.Slots_gb.TabStop = false;
            this.Slots_gb.Text = "Slots";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 257);
            this.Controls.Add(this.Slots_gb);
            this.Controls.Add(this.CurrentLoadPath_lb);
            this.Controls.Add(this.Output_lb);
            this.Controls.Add(this.SetLoadPath_bt);
            this.Controls.Add(this.LoadPath_tb);
            this.Controls.Add(this.LoadGame_bt);
            this.Controls.Add(this.SaveGame_bt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Darkest Dungeon GameSaver";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Slots_gb.ResumeLayout(false);
            this.Slots_gb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveGame_bt;
        private System.Windows.Forms.Button LoadGame_bt;
        private System.Windows.Forms.TextBox LoadPath_tb;
        private System.Windows.Forms.Button SetLoadPath_bt;
        private System.Windows.Forms.Label Output_lb;
        private System.Windows.Forms.Label CurrentLoadPath_lb;
        private System.Windows.Forms.RadioButton Slot1_rb;
        private System.Windows.Forms.RadioButton Slot2_rb;
        private System.Windows.Forms.RadioButton Slot3_rb;
        private System.Windows.Forms.GroupBox Slots_gb;
    }
}

