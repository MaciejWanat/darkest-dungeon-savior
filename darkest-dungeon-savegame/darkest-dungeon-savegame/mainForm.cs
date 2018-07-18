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

            if (!File.Exists(Config.ConfigString))
            {
                //Create blank config file
                Output_lb.Text = "Creating new config. Please set Darkest Dungeon directory with SaveGames (262060).";
                dynamic json = JsonConvert.DeserializeObject("{}");

                json.LoadString = "None";                

                string configString = JsonConvert.SerializeObject(json);
                File.WriteAllText(Config.ConfigString, configString);

                Config.LoadString = json.LoadString;
            }
            else
            {
                //Load config from file
                Output_lb.Text = "Config loaded from file.";
                string configString = File.ReadAllText(Config.ConfigString);
                dynamic json = JsonConvert.DeserializeObject(configString);

                Config.LoadString = json.LoadString;               
                
                if(Config.LoadString == "None")
                {
                    Output_lb.Text += " Please set Darkest Dungeon directory with SaveGames.";
                }
            }
            CurrentLoadPath_lb.Text = "Current load path: " + Config.LoadString;

            if (!Directory.Exists(Config.LocalSavesLocation))
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
                    Output_lb.Text = "Copying savegames from Darkest Dungeon failed.";
                }
            }
        }

        private void LoadGame_bt_Click(object sender, EventArgs e)
        {
            DialogResult prompt = MessageBox.Show("Do you really want to load local save copy to the game? This will overwrite your current game progress.",
               "Loading savegames", MessageBoxButtons.YesNo);

            if (prompt == DialogResult.Yes)
            {
                var radioBtn = this.Slots_gb.Controls.OfType<RadioButton>()
                                       .FirstOrDefault(x => x.Checked);
                if (radioBtn != null)
                {
                    string targetDir;
                    Output_lb.Text = "Loading gamesaves from " + radioBtn.Text + "...";

                    try
                    {
                        switch (radioBtn.Name)
                        {
                            case "Slot1_rb":

                                targetDir = Path.Combine(Config.LocalSavesLocation, @"slot_1");
                                Directory.CreateDirectory(targetDir);
                                FileHelper.LoadSaveGames(targetDir);
                                break;

                            case "Slot2_rb":
                                targetDir = Path.Combine(Config.LocalSavesLocation, @"slot_2");
                                Directory.CreateDirectory(targetDir);
                                FileHelper.LoadSaveGames(targetDir);
                                break;

                            case "Slot3_rb":
                                targetDir = Path.Combine(Config.LocalSavesLocation, @"slot_3");
                                Directory.CreateDirectory(targetDir);
                                FileHelper.LoadSaveGames(targetDir);
                                break;

                        }
                        Output_lb.Text = "Saves loaded succesfuly from " + radioBtn.Text + "!"
                            + "\n\nTime of loading: " + DateTime.Now;
                    }
                    catch
                    {
                        Output_lb.Text = "Loading savegames into Darkest Dungeon failed.";
                    }
                }
            }
        }

        private void SetLoadPath_bt_Click(object sender, EventArgs e)
        {
            try
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    var path = folderBrowserDialog1.SelectedPath;
                    bool promptResult = true;
                    if (Directory.Exists(path))
                    {
                        if (!FileHelper.ValidatePath(path))
                        {
                            DialogResult prompt = MessageBox.Show("This folder doesn't look like it contains DD savegames. Are you sure you want to set it as a directory?",
                            "Setting directory", MessageBoxButtons.YesNo);

                            if (prompt == DialogResult.No)
                            {
                                promptResult = false;
                            }
                        }
                        
                        if(promptResult)
                        {
                            Config.SetLoadString(path);

                            string configString = File.ReadAllText(Config.ConfigString).TrimEnd('\\');
                            dynamic json = JsonConvert.DeserializeObject(configString);

                            json.LoadString = Config.LoadString;

                            configString = JsonConvert.SerializeObject(json);
                            File.WriteAllText(Config.ConfigString, configString);
                            Output_lb.Text = "New load path set up succesfuly.";
                            CurrentLoadPath_lb.Text = "Current load path: " + Config.LoadString;
                        }
                    }
                    else
                    {
                        Output_lb.Text = "Your input isn't a directory.";
                    }
                    
                }                
            }
            catch(Exception)
            {
                Output_lb.Text = "Setting load path failed.";
            }
            
        }

        private void howToFindSavesPathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult prompt = MessageBox.Show("There are few typical locations for DD savegames. " +
                "\nSteam usually stores it in a folder \"262060\\remote\". \nFolder should contain \"profile_0\" folder. \n\nFew possible locations:\n"+
                "\n- C:\\Program Files (x86)\\Steam\\userdata\\<your_user_id>\\262060\\remote (Steam)" +
                "\n- C:\\Users\\<your username>\\Documents\\Darkest (GOG)" +
                "\n- /Users/<username>/Library/Application Support/Darkest (MAC)",
                "How to find DD saves path", MessageBoxButtons.OK);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult prompt = MessageBox.Show("This is the application for managing savegames of the Darkest Dungeon game.\n" +
                "Interface:\n\n" +
                "- Save savegame copy: Make local copy of DD saves at selected slot\n" +
                "- Load savegame copy: Load local copy from selected slot to DD saves\n" +
                "- Set saves path: Set path where DD stores savegames, to copy/paste to.\n\n" +
                "In memory of my lvl 5 ocultist who died from two spider bites, which got me triggered enough to write this app.",
            "Instructions", MessageBoxButtons.OK);
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

        private void Output_lb_Click(object sender, EventArgs e)
        {

        }

    }
}
