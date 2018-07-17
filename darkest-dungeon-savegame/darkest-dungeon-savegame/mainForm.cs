using darkest_dungeon_savegame.Logic;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace darkest_dungeon_savegame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if(!File.Exists(Config.ConfigString))
            {
                //Create blank config file
                Output_lb.Text = "Creating new config. Please set Darkest Dungeon directory with SaveGames (262060).";
                dynamic json = JsonConvert.DeserializeObject("{}");

                json.LoadString = "";

                string configString = JsonConvert.SerializeObject(json);
                File.WriteAllText(Config.ConfigString, configString);
                CurrentLoadPath_lb.Text = "Current load path: None";
            }
            else
            {
                //Load config from file
                Output_lb.Text = "Config loaded from file.";
                string configString = File.ReadAllText(Config.ConfigString);
                dynamic json = JsonConvert.DeserializeObject(configString);

                Config.LoadString = json.LoadString;
                CurrentLoadPath_lb.Text = "Current load path: " + Config.LoadString;
            }

            if(!Directory.Exists(Config.LocalSavesLocation))
            {
                Directory.CreateDirectory(Config.LocalSavesLocation);
            }
        }

        private void SaveGame_bt_Click(object sender, EventArgs e)
        {
            var radioBtn = this.Slots_gb.Controls.OfType<RadioButton>()
                                       .FirstOrDefault(x => x.Checked);
            if(radioBtn != null)
            {
                string targetDir;
                Output_lb.Text = "Creating local copy at " + radioBtn.Text + "...";

                try
                {
                    switch (radioBtn.Name)
                    {
                        case "Slot1_rb":

                            targetDir = Path.Combine(Config.LocalSavesLocation, @"slot_1\");
                            Directory.CreateDirectory(targetDir);
                            FileHelper.CopySaveGames(targetDir);
                            break;

                        case "Slot2_rb":
                            targetDir = Path.Combine(Config.LocalSavesLocation, @"slot_2\");
                            Directory.CreateDirectory(targetDir);
                            FileHelper.CopySaveGames(targetDir);
                            break;

                        case "Slot3_rb":
                            targetDir = Path.Combine(Config.LocalSavesLocation, @"slot_3\");
                            Directory.CreateDirectory(targetDir);
                            FileHelper.CopySaveGames(targetDir);
                            break;

                    }
                    Output_lb.Text = "Saves copied succesfuly at " + radioBtn.Text + "!"
                        + "\n\nTime of copy: " + DateTime.Now;
                }
                catch
                {
                    Output_lb.Text = "Copying saves failed.";
                }

            }
        }

        private void LoadGame_bt_Click(object sender, EventArgs e)
        {

        }

        private void SetLoadPath_bt_Click(object sender, EventArgs e)
        {
            try
            {
                Config.SetLoadString(LoadPath_tb.Text);

                string configString = File.ReadAllText(Config.ConfigString).TrimEnd('\\');
                dynamic json = JsonConvert.DeserializeObject(configString);

                json.LoadString = Config.LoadString;

                configString = JsonConvert.SerializeObject(json);
                File.WriteAllText(Config.ConfigString, configString);
                Output_lb.Text = "New load path set up succesfuly.";
                CurrentLoadPath_lb.Text = "Current load path: " + Config.LoadString;
            }
            catch(Exception)
            {
                Output_lb.Text = "Setting load path failed.";
            }
            
        }

        private void Slot1_rb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Slot2_rb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Slot3_rb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CurrentLoadPath_lb_Click(object sender, EventArgs e)
        {

        }
    }
}
