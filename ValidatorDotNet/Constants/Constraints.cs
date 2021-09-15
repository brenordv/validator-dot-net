using System;

namespace Raccoon.Ninja.ValidatorDotNet.Constants
{
    /// <summary>
    ///     Constants used to restrict values of a variable.
    /// </summary>
    public static class Constraints
    {
        /// <summary>
        ///     Minimum acceptable value for DateTime variables, when using a database.
        /// </summary>
        public static class MinDateForDatabase
        {
            private const string MinDateCommon = "0001-01-01T00:00:00.000Z";

            /// <summary>
            ///     Minimum timestamp for Sql Server
            /// </summary>
            public static readonly DateTime
                SqlServer = DateTime.Parse("1753-01-01T00:00:00.000Z").ToUniversalTime();
        
            /// <summary>
            ///     Minimum timestamp for Oracle
            /// </summary>
            public static readonly DateTime
                Oracle = DateTime.Parse("1000-01-01T00:00:00.000Z").ToUniversalTime();
        
            /// <summary>
            ///     Minimum timestamp for MySql
            /// </summary>
            public static readonly DateTime
                MySql = DateTime.Parse("1000-01-01T00:00:00.000Z").ToUniversalTime();
            
            /// <summary>
            ///     Minimum timestamp for Postgres
            ///     Actually, Postgres can handle timestamps as lower as 4713 BC, but C# can't, so...
            /// </summary>
            public static readonly DateTime
                Postgres = DateTime.Parse(MinDateCommon).ToUniversalTime();     
            
            /// <summary>
            ///     Minimum timestamp for MariaDb
            /// </summary>
            public static readonly DateTime
                MariaDb = DateTime.Parse("1000-01-01T00:00:00.000Z").ToUniversalTime();
            
            /// <summary>
            ///     Minimum timestamp for Sqlite
            /// </summary>
            public static readonly DateTime
                Sqlite = DateTime.Parse(MinDateCommon).ToUniversalTime();    
        }

        /// <summary>
        ///     Limit values when dealing with UTC.
        /// </summary>
        public static class Utc
        {
            /// <summary>
            ///     Minimum acceptable value for UTC
            /// </summary>
            public const int MinValue = 1;
            
            /// <summary>
            ///     Maximum acceptable value for UTC
            ///     The Howland islands, an unincorporated unorganized territory of the United States, use a time zone of -12 hours UTC on the far west of the earth. The Republic of Kiribati’s Line Islands, which have a time zone of +14 hours UTC, are on the far east of the earth. These two places, therefore, have the biggest time difference of 26 hours. 
            /// </summary>
            public const int MaxValue = 1560;
        }
        
    }
}