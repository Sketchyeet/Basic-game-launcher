using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;

//Rename "example.exe" to your game exe (make sure you have the .exe at the end or it may not work)


namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //shows the "settings" menu
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }
        //hides the "settings" menu
        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }
        //Finds the "launcher" directory and searchs for the "client" from that string
        private void button1_Click(object sender, EventArgs e)
        {
            //finds the path of the launcher
            string myPath = System.Reflection.Assembly.GetEntryAssembly().Location;
            string myDir = System.IO.Path.GetDirectoryName(myPath);
            
            //appends the location of the launcher with the "EXE" you want to find
            string path = System.IO.Path.Combine(myDir, "Example.exe");
            
            //Starts the "EXE"
            Process.Start(path);


                       
        }
    }
}