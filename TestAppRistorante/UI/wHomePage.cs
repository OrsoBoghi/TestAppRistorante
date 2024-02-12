
using System;
using System.Drawing;
using System.Net.NetworkInformation;
using Wisej.Web;
using TestAppRistorante.UI;
namespace TestAppRistorante
{
	public partial class wHomePage : Form 
	{
       public wMenuPage wMenuPage ;
        public wHomePage()
		{
			InitializeComponent();
		}

        private void HomePage_Load(object sender, EventArgs e)
        {
            string imagePaths = "UI/Photo/HomePagePhoto1.jpg";
            string DeviceInfo = $@"Browser: {Screen.DeviceName}
                                   Risoluzione schermo: {Screen.Bounds.Width} x {Screen.Bounds.Height}";
            lblInfoDevice.Text = DeviceInfo;
            pictureBox1.ImageSource=imagePaths;
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
           // wMenuPage= new wMenuPage();
            
        }

        private void btnInizio_Click(object sender, EventArgs e)
        {
            if(wMenuPage==null|| wMenuPage.IsDisposed) wMenuPage = new wMenuPage();
            wMenuPage.Show();
        }
    }
}
