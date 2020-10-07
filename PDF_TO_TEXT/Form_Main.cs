using org.apache.pdfbox;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.apache.pdfbox.pdmodel;
using org.apache.pdfbox.util;


namespace PDF_TO_TEXT
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            
        }
        private Timer timer = new Timer();
        private string inputPDF;
        private string outputTxt;
        
        
        private string Convert_PDFtoText(string path)
        {
            PDDocument doc = PDDocument.load(path);
            PDFTextStripper stripper = new PDFTextStripper();
            return stripper.getText(doc);
        }

        private void timer_wait()
        {
            int interval = 2000;
            timer.Interval = interval;
            timer.Enabled = true;
            if (timer.Interval == interval)
            {
                timer.Enabled = false;
            }
        }

        private void saveInFile()
        {
            
            lab_info.Text = "WORKING";
            this.Refresh();
            timer_wait();
            inputPDF = Txt_InputPdf.Text;
            outputTxt = Txt_OutputTxt.Text;
            try
            {
                string txtinfile = Convert_PDFtoText(@inputPDF);
                File.WriteAllText(@outputTxt, txtinfile, Encoding.Unicode);
                Txt_InputPdf.Text = "";
                Txt_OutputTxt.Text = "";
                timer.Enabled = true;
                timer.Enabled = false;
                timer_wait();
            }catch
            {
                lab_info.Text = "ERROR";
            }
            lab_info.Text = "DONE";
                        
        }
        private void btn_Convert_Click(object sender, EventArgs e)
        {
            saveInFile();
        }
    }
}
