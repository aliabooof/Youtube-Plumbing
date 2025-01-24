using CoreLayer.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.WebApplication.Entities
{
    public class AboutUs : BaseEntity
    {
        
        public string Header { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Clients { get; set; } = null!;
        public string HoursOfsupport { get; set; } = null!;
        public string HardWorkers { get; set; } = null!;
        public string FileName { get; set; } = null!;
        public string FileType { get; set; } = null!;

        public int SocialMediaId { get; set; }
        public SocialMedia SocialMedia { get; set; } = null!;
    }

}
