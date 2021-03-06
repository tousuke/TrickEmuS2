﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricksterMap.Data
{
    public class RangeObject
    {
        public static int[] ValidTypes =
        {
            0x00, 0x01, 0x02, 0x05, 0x06, 0x09, 0x0A
        };

        /// <summary>
        /// Range object type
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// Range object ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Warp portal destination ZoneID
        /// </summary>
        public int Destination { get; set; }

        public int X1 { get; set; }
        public int Y1 { get; set; }

        public int X2 { get; set; }
        public int Y2 { get; set; }

        /// <summary>
        /// Options (unconfirmed, is this always 0?)
        /// </summary>
        public int Options { get; set; } = 0;
    }
}
