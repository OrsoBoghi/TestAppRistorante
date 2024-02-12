extern alias swf;


using System;
using System.Collections.Generic;
using System.Drawing;
using Wisej.Web;

namespace TestAppRistorante.UI
{
    public partial class wMenuPage : Form { 
    private const string IMMAGINE_DEFAULT = "UI/Photo/no-product-found.jpg";
        wMenuPiattoDettaglio piatto;
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

                FlowLayoutPanel pnl = CreateObject(p);
                switch (p.IDCategoria) {
                    case 1:
                        pnlAntipasti.Controls.Add(pnl);
                        break;
                    case 2:
                        pnlContorni.Controls.Add(pnl);
                        break;
                    case 3:
                        pnlPrimi.Controls.Add(pnl);
                        break;
                    case 4:
                        pnlSecondi.Controls.Add(pnl);
                        break;
                    case 5:
                        pnlPizze.Controls.Add(pnl);
                        break;
                    case 6:
                        pnlVini.Controls.Add(pnl);
                        break;
                    case 7:
                        pnlBevande.Controls.Add(pnl);
                        break;
                    case 8:
                        pnlDolci.Controls.Add(pnl);
                        break;
                  


                }
            }

        }

        public FlowLayoutPanel CreateObject(Prodotto p) {
            FlowLayoutPanel pnl = new FlowLayoutPanel();
            pnl.Height = 200;


            //TODO FIXARE BUG GRAFICO CON TANTI ELEMENTI


            pnl.Controls.Add(new Label()
            {
                Name = "lblProdotto",
                Text = $"{p.Descrizione}-{p.Prezzo}€",
                TextAlign =  ContentAlignment.MiddleCenter
            }) ;
           

            pnl.Controls.Add(new Spacer() { Name = "spacerDestra" });
            pnl.Controls.Add(new PictureBox()
            {
                Name = "ImgProduct",
                ImageSource = string.IsNullOrEmpty(p.Immagine) ? IMMAGINE_DEFAULT:p.Immagine,
                SizeMode = PictureBoxSizeMode.StretchImage
            });
            pnl.Controls.Add(new Spacer() { Name = "spacerSinistra" });
            NumericUpDown txtNumber = new NumericUpDown() { Name = "txtNumber", Text = "0", BorderStyle = BorderStyle.Solid, TextAlign = HorizontalAlignment.Center };
            txtNumber.ValueChanged += NumericUpDown_ValueChanged;
            Button btnInfo = new Button() { Name = "btnInfo", Text = "i", BorderStyle = BorderStyle.Solid };
            btnInfo.Click += ButtonInfo_Click;
            pnl.Controls.Add(txtNumber);

            pnl.Controls.Add(btnInfo);
            pnl.SetFillWeight(pnl.Controls["txtNumber"], 2);
            pnl.SetFillWeight(pnl.Controls["btnInfo"], 1);
            pnl.SetFillWeight(pnl.Controls["spacerDestra"], 1);
            pnl.SetFillWeight(pnl.Controls["ImgProduct"], 2);
            pnl.SetFillWeight(pnl.Controls["spacerSinistra"], 1);
          
            pnl.SetFillWeight(pnl.Controls["lblProdotto"], 1);
            


            pnl.SetFlowBreak(pnl.Controls["lblProdotto"], true);
            pnl.SetFlowBreak(pnl.Controls["SpacerSinistra"], true);

            // pnl.SetFlowBreak(pnl.Controls["ImgProduct"], true);
            pnl.BorderStyle = BorderStyle.Solid;
            return pnl; 
        }
        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            // Logica da eseguire quando il valore del NumericUpDown cambia
            MessageBox.Show($"Nuovo valore: {numericUpDown.Value}");
        }

        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            // Logica da eseguire quando il button viene cliccato
            if (piatto == null || piatto.IsDisposed) piatto = new wMenuPiattoDettaglio();
            piatto.Show();
        }

    }
}
