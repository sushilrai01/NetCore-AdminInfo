using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NetCoreAdminInfo.ViewModel
{
        #nullable disable
        public class GenderModel
        {
            public int GenderId { get; set; }
            public string Category { get; set; }
        }

        public class ActivityModel
        {
            public int ActiveId { get; set; }
            public string Available { get; set; }
        }

        public class HobbyModel
        {
            public int HobbyId { get; set; }
            public string Hobby { get; set; }
            //public Nullable<bool> IsActive { get; set; }
            public bool IsActive { get; set; }
        }

        public class MappingModel
        {
            public int MapId { get; set; }
            public int AdminId { get; set; }
            public int HobbyId { get; set; }
        }

        public class ImageMapModel
        {
            public int ImageId { get; set; }
            public int DriverId { get; set; }
            public string Filepath { get; set; }
            public string Filename { get; set; }
        }
    public class DocMapModel
    {
        public int DocumentId { get; set; }
        public int AdminId { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
    }
    public class DropdownModel
        {
            public int ID { get; set; }
            public string TEXT { get; set; }
        }

        public class HobbiesModel
        {
            public List<DriverInfoModel> thuloModel { get; set; }
            public bool Football { get; set; }
            public bool Cricket { get; set; }
            public bool Basketball { get; set; }
            public bool Singing { get; set; }
            public bool Dancing { get; set; }
            public bool Reading { get; set; }
            public bool Travelling { get; set; }
        }

    #nullable disable
    public class DriverInfoModel
        {
            public int DriverId { get; set; }
            public string DriverName { get; set; }
            public string ContactNo { get; set; }
            public int GenderId { get; set; }
            public string Category { get; set; }
            public int ActiveId { get; set; }
            public string Available { get; set; }
            public int ImageId { get; set; }
            public string ImageFilePath { get; set; }   //To show Image
            public string DocsFilePath { get; set; }   //To show Documents

            //Hobbies.......
            public bool Football { get; set; }
            public bool Cricket { get; set; }
            public bool Basketball { get; set; }
            public bool Singing { get; set; }
            public bool Dancing { get; set; }
            public bool Reading { get; set; }
            public bool Travelling { get; set; }

            //[Required(ErrorMessage = "Please Select A Hobby.")]
            public string Hobby { get; set; } //$ >_Concatenated hobbies here
            public int MapId { get; set; }

            public List<ImageMapModel> FileList { get; set; }
            public List<HobbiesModel> HobbyList { get; set; }
            public List<HobbyModel> HobList { get; set; }
            public List<DropdownModel> GenList { get; set; }
            public List<DropdownModel> ActList { get; set; }

            internal object AddModelError()
            {
                throw new NotImplementedException("!!Please Select a hobby!");
            }
        }

    #nullable disable
    public class AdminInfoModel
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        //public string ContactNo { get; set; }
        public int GenderId { get; set; }
        public string Category { get; set; }
        public int ActiveId { get; set; }
        public string ImageFilePath { get; set; }   //To show Image
        public string DocFilePath { get; set; }   //To show Documents

        //Hobbies.......
        public bool Football { get; set; }
        public bool Cricket { get; set; }
        public bool Basketball { get; set; }
        public bool Singing { get; set; }
        public bool Dancing { get; set; }
        public bool Reading { get; set; }
        public bool Travelling { get; set; }

        //[Required(ErrorMessage = "Please Select A Hobby.")]
        public string Hobby { get; set; } //$ >_Concatenated hobbies here
        public int MapId { get; set; }

        public List<ImageMapModel> FileList { get; set; }
        public List<HobbiesModel> HobbyList { get; set; }
        public List<HobbyModel> HobList { get; set; }
        public List<DropdownModel> GenList { get; set; }
        public List<DropdownModel> ActList { get; set; }

        internal object AddModelError()
        {
            throw new NotImplementedException("!!Please Select a hobby!");
        }
    }



}
