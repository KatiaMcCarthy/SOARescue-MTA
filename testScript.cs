using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System;
using UnityEngine.UI;

#if UNITY_EDITOR || UNITY_STANDALONE
//using System.Windows.Forms;
#endif

public class testScript : MonoBehaviour {

   /// private string pdfName = "testPDF(" + System.DateTime.Now.ToString("yyy-MM-dd_HH-mm-ss") + ")";
    private string path = "";
    private string path2 = "";

    public Text inputText;

    // Use this for initialization
    void Start () {
		
	}
	
    public void onButtonPress()
    {
        
        

        GeneratePDF();
    }

    public void GeneratePDF()
    {
        //#if UNITY_EDITOR || UNITY_STANDALONE
        //        SaveFileDialog dlg = new SaveFileDialog();
        //        dlg.DefaultExt = ".pdf";
        //        dlg.InitialDirectory = UnityEngine.Application.dataPath;
        //        dlg.Filter = "Pdf documents (.pdf)|*.pdf";

        //        if(dlg.ShowDialog() == DialogResult.OK)
        //        {
        //            path = dlg.FileName;
        //            print("user has selected a path ");
        //        }
        //        else if(dlg.ShowDialog() == DialogResult.Cancel || dlg.ShowDialog() == DialogResult.Abort)
        //        {
        //            path = "";
        //            print("user has closed the window");
        //        }

        //        /////////

        //        if(path !="")
        //        {
        //            createPDF(pdfName);
        //            print("pdf is saved!");
        //        }
        //#endif

       // this works
        //string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        //path2 = Path.Combine(path, "testPDFWrite.pdf");

        //string pdfName = path2 + "\test.pdf";


        string path = Application.persistentDataPath;
        path2 = Path.Combine(path, "testPDFWrite.pdf");

        string pdfName = path2 + "\test.pdf";
        Debug.Log(path2);
        createPDF(pdfName, inputText.text);

        Debug.Log(inputText.text);
    }


    public void createPDF(string filename, string textToWrite)
    {
        MemoryStream stream = new MemoryStream();

        Document doc = new Document(PageSize.A4);
        PdfWriter pdfWriter = PdfWriter.GetInstance(doc, stream);   //initalize the pdf

        PdfWriter.GetInstance(doc, new FileStream(path2, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None));  //open the pdf

        BaseFont bfHelv = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
        iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(bfHelv, 10, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK);
        iTextSharp.text.Font fontBold = new iTextSharp.text.Font(bfHelv, 10, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);

        doc.Open();
        doc.NewPage();

        PdfPTable mainTable = new PdfPTable(1); // the table of the document
        mainTable.HorizontalAlignment = Element.ALIGN_CENTER;


        PdfPCell tmpCell = new PdfPCell(); // a cell for the tital
        tmpCell.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER;
        tmpCell.BorderWidth = 1;
        tmpCell.AddElement(new Phrase(textToWrite, fontBold));

        mainTable.AddCell(tmpCell);

        PdfPCell tmpCell2 = new PdfPCell(); // a cell for the normaltext
        tmpCell2.Border = iTextSharp.text.Rectangle.BOTTOM_BORDER;
        tmpCell2.BorderWidth = 1;
        tmpCell2.AddElement(new Phrase(textToWrite, fontNormal));

        mainTable.AddCell(tmpCell2);

        doc.Add(mainTable);
        doc.Close();

        pdfWriter.Close();
        stream.Close();
    }




	// Update is called once per frame
	void Update () {
		
	}
}
