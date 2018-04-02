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
using RDotNet;

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
            if (String.IsNullOrEmpty(txtboxRCommands.Text))
            {
                btnClear.Enabled = false;
                btnSubmit.Enabled = false;
            }

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            MyFunctions.InitializeRDotNet();
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


                //MyFunctions._engine.Evaluate("ggplot(dataset, aes(X,Y)) + geom_point() + geom_smooth()");
                var graph = MyFunctions._engine.Evaluate("plot(dataset)");
                //MyFunctions._engine.Evaluate("qplot(X, Y, data=dataset, geom=c('point', 'smooth'))");
                
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

            catch
            {
                MessageBox.Show(@"Sonmething went wrong.");
            }

            // put R code execute here.
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxRCommands.Text = "";
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            try
            {
                // get contents of datagrid


                //MyFunctions._engine.Evaluate("\"" + txtboxRCommands.Text + "\"");
                //Console.WriteLine(MyFunctions._engine.Evaluate("aggregate(. ~GRP, data=dataset, FUN=sum)"));
            }

            catch
            {
                MessageBox.Show(@"Sonmething went wrong.");
            }

        }

        private void frm1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //MyFunctions._engine.Dispose();
        }
    }


    public static class MyFunctions
    {
        public static REngine _engine;
        internal static void InitializeRDotNet()
        {
            try
            {

                //string rHome = @"C:\Program Files\R\R-3.4.3";
                //string rPath = @"C:\Program Files\R\R-3.4.3\bin\x64";
                ////string rPath = Path.Combine(rHome, @"bin\x64");
                //REngine.SetEnvironmentVariables(rPath, rHome);
                //_engine = REngine.GetInstance();

                REngine.SetEnvironmentVariables();
                _engine = REngine.GetInstance();

                _engine.Initialize();

                foreach (string sRSession in MyFunctions._engine.Evaluate("sessionInfo()").AsCharacter())
                {
                    Console.WriteLine("Current session info: " + sRSession);
                }


                //foreach (string sPackages in MyFunctions._engine.Evaluate("installed.packages(.Library)").AsCharacter())
                //{
                //    Console.WriteLine("Installed packages on local machine are: " + sPackages);
                //}

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Initializing RDotNet: " + ex.Message);
            }
        }
    }
}
