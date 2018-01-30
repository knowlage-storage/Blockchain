﻿using BlockchainExplorerDesktop.BlockchainService;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockchainExplorerDesktop
{
    public partial class Form1 : Form
    {
        BlockchainServiceClient client = new BlockchainServiceClient();

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadAsync();
        }

        private async Task<bool> LoadAsync()
        {
            return await Task.Run(() =>
            {
                var blocks = client.GetChain();
                foreach (var block in blocks)
                {
                    listBox1.BeginInvoke((Action)delegate { listBox1.Items.Add(block); });
                }
                return true;
            });
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem is BlockService item)
            {
                textBox3.Text = item.CreatedOn.ToLocalTime().ToString();
                textBox4.Text = item.Hash;
                textBox5.Text = item.PreviousHash;
                textBox6.Text = item.User;
                textBox7.Text = item.Data;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var block = await client.AddDataAsync(textBox1.Text);
            listBox1.Items.Add(block);
        }
    }
}
