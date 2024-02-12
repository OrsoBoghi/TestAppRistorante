extern alias swf;


using System;
using System.Collections.Generic;
using Wisej.Web;

namespace TestAppRistorante.UI
{
    public partial class wMenuPage : Form
    {
        public wMenuPage()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {

            DBA dba = new DBA();
            List<Prodotto> list = dba.GetMenu();

            foreach (Prodotto p in list)
            {
                FlowLayoutPanel pnl = new FlowLayoutPanel();
                pnl.Height = 150;


                // Aggiungi la PictureBox al FlowLayoutPanel
                pnl.Controls.Add(new PictureBox()
                {
                    Name = "ImgProduct",
                    ImageSource = "UI/Photo/no-product-found.jpg",
                    SizeMode = PictureBoxSizeMode.StretchImage
                }) ;

                pnl.Controls.Add(new Button() { Name = "btnPlus",Text="+",BorderStyle=BorderStyle.Solid });
                pnl.Controls.Add(new TextBox() { Name = "txtNumber", Text = "0", BorderStyle = BorderStyle.Solid });
                pnl.Controls.Add(new Button() { Name = "btnMinun", Text = "-", BorderStyle = BorderStyle.Solid });
                pnl.Controls.Add(new Button() { Name = "btnInfo", Text = "i", BorderStyle = BorderStyle.Solid });
                pnl.SetFillWeight(pnl.Controls["btnPlus"], 1);
                pnl.SetFillWeight(pnl.Controls["txtNumber"], 1);
                pnl.SetFillWeight(pnl.Controls["btnMinun"], 1);
                pnl.SetFillWeight(pnl.Controls["btnInfo"], 1);
                

                pnl.SetFlowBreak(pnl.Controls["ImgProduct"], true);
                pnl.SetFlowBreak(pnl.Controls["ImgProduct"], true);
                pnl.BorderStyle=BorderStyle.Solid;
                pnlContorni.Controls.Add(pnl);
                //TODO verificare questo calcolo
                pnlContorni.MinimumSize = new System.Drawing.Size(Screen.Bounds.Width, 150 * (pnlContorni.Controls.Count/6));
            }
        
        }
    }
}
