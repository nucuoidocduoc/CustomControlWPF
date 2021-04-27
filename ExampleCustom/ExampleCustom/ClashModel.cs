using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleCustom
{
    public class ClashModel
    {
        public Guid Id { get; set; }
        public string ClashTitle { get; set; }
        public string Tolerance { get; set; }
        public string ClashName { get; set; }
        public string Assign { get; set; }
        public string GridLocation { get; set; }
        public string DateFound { get; set; }
        public string Status { get; set; }
        public string LastUpdate { get; set; }
        public string UpdateInfo { get; set; }

        public string ElementId1 { get; set; }
        public string Layer1 { get; set; }
        public string ItemType1 { get; set; }
        public string ItemName1 { get; set; }
        public string Path1 { get; set; }

        public string ElementId2 { get; set; }
        public string Layer2 { get; set; }
        public string ItemType2 { get; set; }
        public string ItemName2 { get; set; }
        public string Path2 { get; set; }
    }
}