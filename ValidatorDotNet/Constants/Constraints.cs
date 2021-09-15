using System;

namespace Raccoon.Ninja.ValidatorDotNet.Constants
{
    public static class Constraints
    {
        public static class MinDateForDatabase
        {
            private const string MinDateCommon = "0001-01-01T00:00:00.000Z";
            
            public static readonly DateTime
                SqlServer = DateTime.Parse("1753-01-01T00:00:00.000Z").ToUniversalTime();
        
            public static readonly DateTime
                Oracle = DateTime.Parse("1000-01-01T00:00:00.000Z").ToUniversalTime();
        
            public static readonly DateTime
                MySql = DateTime.Parse("1000-01-01T00:00:00.000Z").ToUniversalTime();
            
            /// <summary>
            ///     Actually, Postgres can handle timestamps as lower as 4713 BC, but C# can't, so...
            /// </summary>
            public static readonly DateTime
                Postgres = DateTime.Parse(MinDateCommon).ToUniversalTime();     
            
            public static readonly DateTime
                MariaDb = DateTime.Parse("1000-01-01T00:00:00.000Z").ToUniversalTime();
            
            public static readonly DateTime
                Sqlite = DateTime.Parse(MinDateCommon).ToUniversalTime();    
        }

        public static class Utc
        {
            public const int MinValue = 1;
            
            /// <summary>
            /// The Howland islands, an unincorporated unorganized territory of the United States, use a time zone of -12 hours UTC on the far west of the earth. The Republic of Kiribati’s Line Islands, which have a time zone of +14 hours UTC, are on the far east of the earth. These two places, therefore, have the biggest time difference of 26 hours. 
            /// </summary>
            public const int MaxValue = 1560;
        }
        
    }
}