using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Drawing.Imaging;
using System.Web;

namespace SwiftClinicModels
{
    public class ValidateFileAttribute : RequiredAttribute
    {
        public override bool IsValid(object value)
        {
            if (!(value is HttpPostedFileBase file))
            {
                return true;
            }

            if (file.ContentLength > 1 * 150 * 150)
            {
                return false;
            }

            try
            {
                using (var img = Image.FromStream(file.InputStream))
                {
                    return img.RawFormat.Equals(img.RawFormat.Equals(ImageFormat.Png) ? ImageFormat.Png : ImageFormat.Jpeg);
                }
            }
            catch
            {
                // ignored
            }
            return false;
        }
    }
}