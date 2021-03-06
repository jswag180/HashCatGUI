﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashCatGUI
{
    public partial class Form1 : Form
    {
        static bool isAlreadyCracked = false;
        string appPath = Application.StartupPath;
        String conOut = null;
        BackgroundWorker bw = null;
        static String args = "";
        static List<String> ConLines = new List<String>();
        MethodInvoker status;
        MethodInvoker pause;
        MethodInvoker resume;
        MethodInvoker bypass;
        MethodInvoker checkpoint;
        MethodInvoker exit;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrack_Click(object sender, EventArgs e)
        {
            
            //clear file and put the new hash in
            string path = appPath + @"\hash.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(inputHashTxt.Text);
                }
            }
            else
            {
                File.Delete(path);

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(inputHashTxt.Text);
                }

            }
            //Clear output file
            string output = appPath + @"\cracked.txt";
            if (!File.Exists(output))
            {
                // Create a file to write to.
                using (StreamWriter sw2 = File.CreateText(output))
                {
                    sw2.WriteLine("");
                }
            }
            else
            {
                File.Delete(output);

                using (StreamWriter sw2 = File.CreateText(output))
                {
                    sw2.WriteLine("");
                }

            }


            if (bruteForceRad.Checked)
            {
                args = args + "-a3 ";
            }

            if (md5Rad.Checked)
            {
                args = args + "-m0 ";
            }

            if (autoRad.Checked)
            {
                AutoCracker(); //args = args + "-a3 ";
            }

            if (manualRad.Checked)
            {
                args = args + "-a" + manualTxt.Text + " ";
            }

            args = args + "-o cracked.txt hash.txt";

            string filename = Path.Combine(appPath, "hashcat64.exe");

            MethodInvoker inv = delegate
            {
                lblCon.Text = lblCon.Text + "\n" +conOut;

            };

            bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(
         async delegate (object o, DoWorkEventArgs argss)
         {

             using (Process p = new Process())
             {
                 // set start info
                 p.StartInfo = new ProcessStartInfo("hashcat64.exe", args)
                 {
                     RedirectStandardInput = true,
                     UseShellExecute = false,
                     WorkingDirectory = appPath,
                     RedirectStandardOutput = true,
                     CreateNoWindow = true
                 };

                 // start process
                 p.Start();
                 //get the consoule output
                 StreamReader consuleOut = p.StandardOutput;
                 StreamWriter consuleIn = p.StandardInput;
                 //conOut = await consuleOut.ReadToEndAsync();

                 status = delegate
                 {
                     consuleIn.Write("s");

                 };

                 pause = delegate
                 {
                     consuleIn.Write("p");

                 };

                 resume = delegate
                 {
                     consuleIn.Write("r");

                 };

                 bypass = delegate
                 {
                     consuleIn.Write("b");

                 };

                 checkpoint = delegate
                 {
                     consuleIn.Write("c");

                 };

                 exit = delegate
                 {
                     //consuleIn.WriteLine("q" + "\r");
                         p.StandardInput.WriteLine("q");
                         p.StandardInput.Flush();
                 };

                 while (!p.HasExited)
                 {
                     conOut = await consuleOut.ReadLineAsync();
                     ConLines.Add(conOut);
                     Console.WriteLine(conOut);
                     Invoke(inv);
                     
                 }

                 //wait
                 p.WaitForExit();


                 

                 string ConOutpath = appPath + @"\ConOut.txt";
                 if (!File.Exists(ConOutpath))
                 {
                     // Create a file to write to.
                     using (StreamWriter sw = File.CreateText(ConOutpath))
                     {
                         for (int i = 0; i < ConLines.Count; i++)
                         {
                             sw.WriteLine(ConLines[i]);
                         }
                     }
                 }
                 else
                 {
                     File.Delete(ConOutpath);

                     using (StreamWriter sw = File.CreateText(ConOutpath))
                     {
                         for (int x = 0; x < ConLines.Count; x++)
                         {
                             sw.WriteLine(ConLines[x]);
                         }
                     }

                 }


                 if (ConLines.Contains("INFO: All hashes found in potfile! Use --show to display them."))
                 {
                     Process.Start("notepad.exe", appPath + @"\hashcat.potfile");
                 }
                 else
                 {
                     if (ConLines.Contains("exception"))
                     {

                     }
                     else { Process.Start("notepad.exe", output);}
                    
                 }

             }

         });
            bw.RunWorkerAsync();


        }

        private void AutoCracker()
        {

            args = args + "-a900 ";//MD4

            //bw.RunWorkerAsync();

        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            string historyPath = appPath + @"\hashcat.potfile";
            if (!File.Exists(historyPath))
            {
                // Create a file to write to.
                using (StreamWriter sw3 = File.CreateText(historyPath))
                {
                    sw3.WriteLine("");
                }
            }
            else
            {
                File.Delete(historyPath);

                using (StreamWriter sw3 = File.CreateText(historyPath))
                {
                    sw3.WriteLine("");
                }

            }
        }

        private void manualRad_CheckedChanged(object sender, EventArgs e)
        {
            if (manualRad.Checked)
            {
                manualTxt.Visible = true;
            }
            else
            {
                manualTxt.Visible = false;
            }
            
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            Invoke(status);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Invoke(pause);
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            Invoke(resume);
        }

        private void btnBypass_Click(object sender, EventArgs e)
        {
            Invoke(bypass);
        }

        private void btnCheckpoint_Click(object sender, EventArgs e)
        {
            Invoke(checkpoint);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Invoke(exit);
        }
    }
      
    }
