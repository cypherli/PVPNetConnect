﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PVPNetConnect.RiotObjects.Statistics
{
    public class PlayerStatSummaries : RiotGamesObject
    {
        #region Constructors and Callbacks

        public PlayerStatSummaries(TypedObject result)
        {
            base.SetFields<PlayerStatSummaries>(this, result);
        }

        #endregion

        #region Member Properties

        /// <summary>
        /// The list of all player stat summaries for each queue type (ranked, normal, etc)
        /// </summary>
        [InternalName("playerStatSummarySet")]
        public List<PlayerStatSummary> PlayerStatSummaryList { get; set; }

        /// <summary>
        /// The Acount ID number.
        /// </summary>
        [InternalName("userId")]
        public int AccountID { get; set; }

        #endregion

    }
}