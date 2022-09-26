namespace CityLauncher
{
    internal class ImageTooltip : ToolTip
    {
        public ImageTooltip()
        {
            this.OwnerDraw = true;
            this.Popup += new PopupEventHandler(this.OnPopup);
            this.Draw += new DrawToolTipEventHandler(this.OnDraw);
        }

        private void OnPopup(object sender, PopupEventArgs e)
        {
            e.ToolTipSize = new Size(512, 512);
        }

        private void OnDraw(object sender, DrawToolTipEventArgs e)
        {
            Graphics g = e.Graphics;

            SolidBrush b = new(Color.LightGray);
            g.FillRectangle(b, e.Bounds);

            var img = SelectImage(e);
            var scaledimg = ScaleImage(img, 512, 512);
            g.DrawImage(scaledimg, 0, 0);

            b.Dispose();
        }


        private Image SelectImage(DrawToolTipEventArgs e)
        {
            if (e.AssociatedControl == Program.MainWindow.DefaultColorButton)
            {
                return (Image)Properties.Resources.Default_2;
            }
            if (e.AssociatedControl == Program.MainWindow.NoirColorButton)
            {
                return (Image)Properties.Resources.Monochrome_2;
            }
            if (e.AssociatedControl == Program.MainWindow.MutedColorButton)
            {
                return (Image)Properties.Resources.Muted_2;
            }
            if (e.AssociatedControl == Program.MainWindow.LowContrastColorButton)
            {
                return (Image)Properties.Resources.Log_1_2;
            }
            if (e.AssociatedControl == Program.MainWindow.VividColorButton)
            {
                return (Image)Properties.Resources.Log_2_2;
            }
            else
            {
                return (Image)Properties.Resources.High_Contrast_2;
            }
        }

        private Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(maxWidth, maxHeight);
            using (var graphics = Graphics.FromImage(newImage))
            {
                // Calculate x and y which center the image
                int y = (maxHeight / 2) - (newHeight / 2);
                int x = (maxWidth / 2) - (newWidth / 2);

                // Draw image on x and y with newWidth and newHeight
                graphics.DrawImage(image, x, y, newWidth, newHeight);
            }

            return newImage;
        }
    }
}
