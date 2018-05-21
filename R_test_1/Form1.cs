using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using RDotNet;
using RDotNet.NativeLibrary;

//test out git

namespace R_test_1
{

    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void frm1_Load(object sender, EventArgs e)
        {
            Console.SetOut(new ControlWriter(txtboxResults));

            MyFunctions.InitializeRDotNet();
            
            if (String.IsNullOrEmpty(txtboxRCommands.Text))
            {
                btnClear.Enabled = false;
                //btnClearResults.Enabled = false;
                btnSubmit.Enabled = false;
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            
            try
            {
                // import csv file using native R methods 
                //MyFunctions._engine.Evaluate("dataset<-read.csv(file.choose(), header=TRUE, sep = ',', stringsAsFactors = FALSE)");
                MyFunctions._engine.Evaluate("dataset<-read.csv(file.choose(), sep = ',', stringsAsFactors = FALSE)");
                //Console.WriteLine("Summary by group: " + results);
                //var results = MyFunctions._engine.Evaluate("aggregate(. ~GRP, data=dataset, FUN=sum)").AsList();
                //var filepath = MyFunctions._engine.Evaluate("getwd()");
                //var normalpath = MyFunctions._engine.Evaluate("eval(parse(text=filepath))");
                //Console.WriteLine("Path of chosen file is: " + normalpath);
                //var names = engine.Evaluate("dataset").GetAttributeNames();
                //txtboxFName.Text = engine.Evaluate("dataset").GetAttribute.Text;
                //var moreNames = engine.Evaluate("dataset").GetAttribute("row.names");

                //var libraries = MyFunctions._engine.Evaluate("library(lib = .Library)").AsFunction() ;
                //Console.WriteLine("Path of chosen file is: " + libraries.ToString());


                //var graph = MyFunctions._engine.Evaluate("ggplot(dataset, aes(X0,X36)) + geom_point() + geom_smooth()");
                //var graph = MyFunctions._engine.Evaluate("plot(dataset)");
                //var graph = MyFunctions._engine.Evaluate("qplot(X, Y, data=dataset, geom=c('point', 'smooth'))");

                // retrieve the data frame
                DataFrame df = MyFunctions._engine.Evaluate("dataset").AsDataFrame();


                for (int i = 0; i < df.ColumnCount; ++i)
                {
                    dataGridView1.ColumnCount++;
                    dataGridView1.Columns[i].Name = df.ColumnNames[i];
                }

                for (int i = 0; i < df.RowCount; ++i)
                {
                    dataGridView1.RowCount++;
                    dataGridView1.Rows[i].HeaderCell.Value = df.RowNames[i];

                    for (int k = 0; k < df.ColumnCount; ++k)
                    {
                        dataGridView1[k, i].Value = df[i, k];
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error loading data: " + ex.Message);
            }

            // put R code execute here.

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxRCommands.Text = "";
        }

        private void btnClearResults_Click(object sender, EventArgs e)
        {
            txtboxResults.Text = "";
        }
        private void txtboxRCommands_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtboxRCommands.Text))
            {
                btnClear.Enabled = false;
                btnSubmit.Enabled = false;
            }
            else
            {
                btnClear.Enabled = true;
                btnSubmit.Enabled = true;
            }
        }

        //private void txtboxResults_TextChanged(object sender, EventArgs e)
        //{
        //    if (String.IsNullOrEmpty(txtboxResults.Text))
        //    {
        //        btnClearResults.Enabled = false;
        //    }
        //    else
        //    {
        //        btnClearResults.Enabled = true;
        //    }
        //}

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                SymbolicExpression expression = MyFunctions._engine.Evaluate(txtboxRCommands.Text.Trim());
                
                if (expression == null) return;

                CharacterVector vector = expression.AsCharacter();

                foreach (var sSubmitThis in vector)
                {
                    //if (sSubmitThis is string)
                    {
                        Console.WriteLine(sSubmitThis);
                    }
                }
            }

            catch
            {
                
            }

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.StackTrace);
            //}

        }

        private void frm1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //MyFunctions._engine.Dispose();
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            foreach (string sRSession in MyFunctions._engine.Evaluate("sessionInfo()").AsCharacter())
            {
                Console.WriteLine("Current session info: " + sRSession + "\r\n");
            }
        }

        private void btnTestCode_Click(object sender, EventArgs e)
        {
            try
            {
                MyFunctions._engine.Evaluate("library(ggplot2)");
                MyFunctions._engine.Evaluate("ggplot(dataset, aes(X0,X36)) + geom_point() + geom_smooth()");
                
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error in testing code: " + ex.Message);
            }
        }

        private void btnRunPgm_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtRunRFile.Text))
                {
                    MessageBox.Show("Please enter the file location", "No File!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string sPath = txtRunRFile.Text.Trim();
                    sPath = sPath.Replace(@"\", @"\\");
                    MyFunctions._engine.Evaluate("source('" + sPath + "')");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing R code: " + ex.Message);
            }

        }

        private void btnFileSearch_Click(object sender, EventArgs e)
        {
            if (ofdRPath.ShowDialog() == DialogResult.OK)
            {
                txtRunRFile.Text = ofdRPath.FileName;
            }
        }
    }



    public static class MyFunctions
    {
        public static REngine _engine;
        public static void InitializeRDotNet()
        {
            try
            {
                //  Check for Path and R_Home
                using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\R-core\R"))
                {
                    string sEnvPath = Environment.GetEnvironmentVariable("Path");
                    string sRInstallPath = (string)registryKey.GetValue("InstallPath");
                    string sRInstallVersion = (string)registryKey.GetValue("Current Version");

                    // Check to see which instance of R is installed
                    if (!string.IsNullOrEmpty(sRInstallPath))
                    {
                        string sRBinPath = System.Environment.Is64BitProcess ? sRInstallPath + @"bin\x64\" : sRInstallPath + @"bin\i386\";
                        Environment.SetEnvironmentVariable("Path", sEnvPath + sRInstallPath);
                        //Console.WriteLine("Env Path: " + sOrigPath + "\r\n" + "R Bin Path: " + sBinPath + "\r\n" + "R Version: " + sVersion);
                        string sNewPath = Environment.GetEnvironmentVariable("Path");
                        //var logInfo = RDotNet.NativeLibrary.NativeUtility.GetRHomeEnvironmentVariable();
                        //var rLib = RDotNet.NativeLibrary.NativeUtility.GetRLibraryFileName();
                        Console.WriteLine("Original Env Path: " + sEnvPath);
                        Console.WriteLine("     New Env Path: " + sNewPath);


                        REngine.SetEnvironmentVariables(sRBinPath,sRInstallPath);  // Leave these out for system default.
                        _engine = REngine.GetInstance();
                        _engine.Initialize();
                    }
                    else
                    {
                        MessageBox.Show("You do not have the R software installed.  Please install version 3.43.",
                        "Critical Warning",
                        MessageBoxButtons.OKCancel, 
                        MessageBoxIcon.Warning, 
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.RightAlign,
                        true);
                        
                    }
                    //Console.WriteLine("R Home: " + logInfo + "\r\n");
                    //Console.WriteLine("R Library: " + rLib + "\r\n");
                    //foreach (string sPackages in MyFunctions._engine.Evaluate("installed.packages(.Library)").AsCharacter())
                    //    Console.WriteLine("Installed packages on local machine are: " + sPackages);

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error Initializing RDotNet: " + ex.Message);
            }
        }
    }

    

    public class ControlWriter : TextWriter
    {
        private Control textbox;
        public ControlWriter(Control textbox)
        {
            this.textbox = textbox;
        }

        public override void Write(char value)
        {
            textbox.Text += value;
        }

        public override void Write(string value)
        {
            //if (value != null);
            {
                textbox.Text += value;
            }
        }

        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }
    }
}
