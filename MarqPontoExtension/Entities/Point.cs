using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MarqPontoExtension.Entities
{
    public class Point
    {
        public string companyId { get; set; }
        public string userId { get; set; }
        public string totalHour { get; set; }
        public string id { get; set; }
        public string userPointJson { get; set; }
      //  public UserPointJson[] userPointJson { get; set; }
        public int pointReference { get; set; }
        public int userPointAdjustmentStatus { get; set; }
        public string userPointDayStatusStr { get; set; }
        public EUserPointDayStatus userPointDayStatus { get; set; }
      //public string userPointDayStatus { get; set; }
        public User user { get; set; }
        public bool isSync { get; set; }
    }
}
