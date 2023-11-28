using System;

namespace hotel_v2
{
    internal class VariableData
    {
        public static class UserInformation
        {
            public static int ClientId { get; set; }
            public static string ClientName { get; set; }
        }

        public static class DayInformation
        {
            public static string Day { get; set; }
            public static DateTime DateIn { get; set; }
            public static DateTime DateOut { get; set; }
        }

        public static class CategoryInformation
        {
            public static string CategoryId { get; set; }
            public static string CategoryName { get; set; }
            public static string CategoryPrice { get; set; }
        }

        public static class RoomInformation
        {
            public static string RoomNumber { get; set; }
            public static string RoomPhone { get; set; }
        }
    }
}
