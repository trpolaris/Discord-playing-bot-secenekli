using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client_Project.Discord;

namespace DiscordPlaying_BOT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox8.Text == "OFF")
            {
                this.handlers = default(DiscordRpc.EventHandlers);
                DiscordRpc.Initialize(comboBox1.Text, ref this.handlers, true, null);
                this.handlers = default(DiscordRpc.EventHandlers);
                DiscordRpc.Initialize(comboBox1.Text, ref this.handlers, true, null);
                this.presence.details = comboBox2.Text;
                this.presence.state = comboBox3.Text;
                this.presence.largeImageKey = comboBox4.Text;
                this.presence.largeImageText = comboBox5.Text;
                this.presence.smallImageKey = comboBox6.Text;
                this.presence.smallImageText = comboBox7.Text;
                DiscordRpc.UpdatePresence(ref this.presence);
            }


            if (comboBox8.Text == "ON")
            {
                this.handlers = default(DiscordRpc.EventHandlers);
                DiscordRpc.Initialize(comboBox1.Text, ref this.handlers, true, null);
                this.handlers = default(DiscordRpc.EventHandlers);
                DiscordRpc.Initialize(comboBox1.Text, ref this.handlers, true, null);
                this.presence.details = comboBox2.Text;
                this.presence.state = comboBox3.Text;
                this.presence.largeImageKey = comboBox4.Text;
                this.presence.largeImageText = comboBox5.Text;
                this.presence.smallImageKey = comboBox6.Text;
                this.presence.smallImageText = comboBox7.Text;
                this.presence.startTimestamp = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds;
                DiscordRpc.UpdatePresence(ref this.presence);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
