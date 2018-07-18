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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Slots_gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveGame_bt
            // 
            this.SaveGame_bt.Location = new System.Drawing.Point(16, 225);
            this.SaveGame_bt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveGame_bt.Name = "SaveGame_bt";
            this.SaveGame_bt.Size = new System.Drawing.Size(100, 28);
            this.SaveGame_bt.TabIndex = 0;
            this.SaveGame_bt.Text = "Save Game";
            this.SaveGame_bt.UseVisualStyleBackColor = true;
            this.SaveGame_bt.Click += new System.EventHandler(this.SaveGame_bt_Click);
            // 
            // LoadGame_bt
            // 
            this.LoadGame_bt.Location = new System.Drawing.Point(124, 225);
            this.LoadGame_bt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadGame_bt.Name = "LoadGame_bt";
            this.LoadGame_bt.Size = new System.Drawing.Size(100, 28);
            this.LoadGame_bt.TabIndex = 1;
            this.LoadGame_bt.Text = "Load Game";
            this.LoadGame_bt.UseVisualStyleBackColor = true;
            this.LoadGame_bt.Click += new System.EventHandler(this.LoadGame_bt_Click);
            // 
            // LoadPath_tb
            // 
            this.LoadPath_tb.Location = new System.Drawing.Point(16, 261);
            this.LoadPath_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadPath_tb.Name = "LoadPath_tb";
            this.LoadPath_tb.Size = new System.Drawing.Size(449, 22);
            this.LoadPath_tb.TabIndex = 2;
            // 
            // SetLoadPath_bt
            // 
            this.SetLoadPath_bt.Location = new System.Drawing.Point(487, 258);
            this.SetLoadPath_bt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SetLoadPath_bt.Name = "SetLoadPath_bt";
            this.SetLoadPath_bt.Size = new System.Drawing.Size(156, 28);
            this.SetLoadPath_bt.TabIndex = 3;
            this.SetLoadPath_bt.Text = "Set saves path";
            this.SetLoadPath_bt.UseVisualStyleBackColor = true;
            this.SetLoadPath_bt.Click += new System.EventHandler(this.SetLoadPath_bt_Click);
            // 
            // Output_lb
            // 
            this.Output_lb.AutoSize = true;
            this.Output_lb.Location = new System.Drawing.Point(21, 42);
            this.Output_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Output_lb.Name = "Output_lb";
            this.Output_lb.Size = new System.Drawing.Size(190, 17);
            this.Output_lb.TabIndex = 4;
            this.Output_lb.Text = "Communication with user text";
            this.Output_lb.Click += new System.EventHandler(this.Output_lb_Click);
            // 
            // CurrentLoadPath_lb
            // 
            this.CurrentLoadPath_lb.AutoSize = true;
            this.CurrentLoadPath_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CurrentLoadPath_lb.Location = new System.Drawing.Point(21, 11);
            this.CurrentLoadPath_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentLoadPath_lb.Name = "CurrentLoadPath_lb";
            this.CurrentLoadPath_lb.Size = new System.Drawing.Size(140, 17);
            this.CurrentLoadPath_lb.TabIndex = 5;
            this.CurrentLoadPath_lb.Text = "Current load path:";
            this.CurrentLoadPath_lb.Click += new System.EventHandler(this.CurrentLoadPath_lb_Click);
            // 
            // Slot1_rb
            // 
            this.Slot1_rb.AutoSize = true;
            this.Slot1_rb.Checked = true;
            this.Slot1_rb.Location = new System.Drawing.Point(8, 23);
            this.Slot1_rb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Slot1_rb.Name = "Slot1_rb";
            this.Slot1_rb.Size = new System.Drawing.Size(65, 21);
            this.Slot1_rb.TabIndex = 6;
            this.Slot1_rb.TabStop = true;
            this.Slot1_rb.Text = "Slot 1";
            this.Slot1_rb.UseVisualStyleBackColor = true;
            this.Slot1_rb.CheckedChanged += new System.EventHandler(this.Slot1_rb_CheckedChanged);
            // 
            // Slot2_rb
            // 
            this.Slot2_rb.AutoSize = true;
            this.Slot2_rb.Location = new System.Drawing.Point(8, 52);
            this.Slot2_rb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Slot2_rb.Name = "Slot2_rb";
            this.Slot2_rb.Size = new System.Drawing.Size(65, 21);
            this.Slot2_rb.TabIndex = 7;
            this.Slot2_rb.Text = "Slot 2";
            this.Slot2_rb.UseVisualStyleBackColor = true;
            this.Slot2_rb.CheckedChanged += new System.EventHandler(this.Slot2_rb_CheckedChanged);
            // 
            // Slot3_rb
            // 
            this.Slot3_rb.AutoSize = true;
            this.Slot3_rb.Location = new System.Drawing.Point(9, 80);
            this.Slot3_rb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Slot3_rb.Name = "Slot3_rb";
            this.Slot3_rb.Size = new System.Drawing.Size(65, 21);
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
            this.Slots_gb.Location = new System.Drawing.Point(16, 111);
            this.Slots_gb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Slots_gb.Name = "Slots_gb";
            this.Slots_gb.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Slots_gb.Size = new System.Drawing.Size(96, 107);
            this.Slots_gb.TabIndex = 9;
            this.Slots_gb.TabStop = false;
            this.Slots_gb.Text = "Slots";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 305);
            this.Controls.Add(this.Slots_gb);
            this.Controls.Add(this.CurrentLoadPath_lb);
            this.Controls.Add(this.Output_lb);
            this.Controls.Add(this.SetLoadPath_bt);
            this.Controls.Add(this.LoadPath_tb);
            this.Controls.Add(this.LoadGame_bt);
            this.Controls.Add(this.SaveGame_bt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

