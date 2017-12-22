using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Web;

namespace SwiftClinicModels
{
    public class StaffAcademicHistory
    {
        public int StaffAcademicHistoryId { get; set; }

        public string StaffNumber { get; set; }

        [Display(Name = "Qualification Type")]
        [Required(ErrorMessage = "Qualification Type is Required")]
        public PopUp.Qualifications QualificationType { get; set; }

        [Display(Name = "Name of Qualification")]
        [Required(ErrorMessage = "Qualification is Required")]
        public string QualificationName { get; set; }

        [Display(Name = "School Name")]
        [StringLength(70, ErrorMessage = "Your School name is too long")]
        public string SchoolName { get; set; }

        [Display(Name = "Result Grade")]
        [StringLength(70, ErrorMessage = "Your Result Grade is too long")]
        public string ResultGrade { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime DateObtained { get; set; }

        public byte[] Certificate { get; set; }

        [Display(Name = "Upload the Certificate")]
        [ValidateFile(ErrorMessage = "Please select a PNG/JPEG image smaller than 20kb")]
        [NotMapped]
        public HttpPostedFileBase File
        {
            get
            {
                return null;
            }

            set
            {
                try
                {
                    MemoryStream target = new MemoryStream();

                    if (value.InputStream == null)
                        return;

                    value.InputStream.CopyTo(target);
                    Certificate = target.ToArray();
                }
                catch (Exception)
                {
                    //logger.Error(ex.Message);
                    //logger.Error(ex.StackTrace);
                }
            }
        }

        public virtual Staff Staff { get; set; }
    }
}
