using ImageEditApi.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace ImageEditApi.Services
{
    public class EditorClass
    {
        private Bitmap sourceImage;

        public EditDetail ManageEdit(RequestDetail detail)
        {
            EditDetail editDetail = new EditDetail();
            editDetail.IsEditSuccess = false;

            sourceImage = GetImage(detail.SourceLocation);
            if(sourceImage != null) {
                if (detail.Effect1 == true)
                {
                    sourceImage = Effect1Setting(sourceImage);
                }

                if (detail.Effect2 == true)
                {
                    sourceImage = Effect2Setting(sourceImage);
                }

                if (detail.Effect3 == true)
                {
                    sourceImage = Effect3Setting(sourceImage);
                }

                if (detail.RadiusSize != 0)
                {
                    sourceImage = RadiusArrangeSetting(sourceImage);
                }

                if (detail.ResizeSize != 0)
                {
                    sourceImage = ResizeImageSetting(sourceImage);
                }
                editDetail.FileLocation = SaveFile(sourceImage, detail.SourceLocation);
                editDetail.IsEditSuccess = true;
            }
            else
            {
                editDetail.IsEditSuccess = false;
            }

            return editDetail;

        }

        private Bitmap GetImage(string sourceLocation)
        {
            try
            {
                var img = new Bitmap(sourceLocation);
                return img;
            }
            catch (Exception)
            {
                Console.WriteLine("Image Location is not correct");
            }

            return null;
        }

        private string SaveFile(Bitmap bitmap, string sourceName)
        {
            string savefileName = GetSourceName(sourceName);
            bitmap.Save(savefileName);
            return savefileName;
        }

        private string GetSourceName(string sourceLocation)
        {

            string sourceName = sourceLocation.Split('.').First();
            string fileType = sourceLocation.Split('.').Last();
            string format = "Mddyyyyhhmmsstt";

            string savefileName = sourceName + "_" + String.Format("{0}." + fileType, DateTime.Now.ToString(format));
            return savefileName;
        }



        private Bitmap Effect1Setting(Bitmap bitmap)
        {
            //do something
            return bitmap;
        }

        private Bitmap Effect2Setting(Bitmap bitmap)
        {
            //do something
            return bitmap;
        }

        private Bitmap Effect3Setting(Bitmap bitmap)
        {
            //do something
            return bitmap;
        }

        private Bitmap RadiusArrangeSetting(Bitmap bitmap)
        {
            //do radius change to image
            return bitmap;
        }


        private Bitmap ResizeImageSetting(Bitmap bitmap)
        {
            //radius rearrange Image
            return bitmap;
        }
    }
}
