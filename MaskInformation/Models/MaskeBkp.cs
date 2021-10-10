using System;
using System.Collections.Generic;

namespace MaskInformation.Models
{
    public partial class MaskeBkp
    {
        public int Id { get; set; }
        public string Kategori { get; set; }
        public string Renk { get; set; }
        public string Dil { get; set; }
        public string Tip { get; set; }
        public string Boyut { get; set; }
        public string Ambalaj { get; set; }
        public string Kutu { get; set; }
        public string Koli { get; set; }
        public string Barkod { get; set; }
    }
}
