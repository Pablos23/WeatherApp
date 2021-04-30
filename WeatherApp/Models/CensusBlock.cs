// <copyright file="CensusBlock.cs" company="Weather App.">
// Copyright (c) Weather App.. All rights reserved.
// </copyright>

namespace WeatherApp.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// CensusBlock.
    /// </summary>
    public partial class CensusBlock
    {
        /// <summary>
        /// Gets or sets the suffix.
        /// </summary>
        /// <value>
        /// The suffix.
        /// </value>
        [JsonProperty("SUFFIX", NullValueHandling = NullValueHandling.Ignore)]
        public string Suffix { get; set; }

        /// <summary>
        /// Gets or sets the pop100.
        /// </summary>
        /// <value>
        /// The pop100.
        /// </value>
        [JsonProperty("POP100")]
        public long Pop100 { get; set; }

        /// <summary>
        /// Gets or sets the geoid.
        /// </summary>
        /// <value>
        /// The geoid.
        /// </value>
        [JsonProperty("GEOID")]
        public string Geoid { get; set; }

        /// <summary>
        /// Gets or sets the centlat.
        /// </summary>
        /// <value>
        /// The centlat.
        /// </value>
        [JsonProperty("CENTLAT")]
        public string Centlat { get; set; }

        /// <summary>
        /// Gets or sets the block.
        /// </summary>
        /// <value>
        /// The block.
        /// </value>
        [JsonProperty("BLOCK", NullValueHandling = NullValueHandling.Ignore)]
        public string Block { get; set; }

        /// <summary>
        /// Gets or sets the areawater.
        /// </summary>
        /// <value>
        /// The areawater.
        /// </value>
        [JsonProperty("AREAWATER")]
        public long Areawater { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        [JsonProperty("STATE")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the basename.
        /// </summary>
        /// <value>
        /// The basename.
        /// </value>
        [JsonProperty("BASENAME")]
        public string Basename { get; set; }

        /// <summary>
        /// Gets or sets the oid.
        /// </summary>
        /// <value>
        /// The oid.
        /// </value>
        [JsonProperty("OID")]
        public long Oid { get; set; }

        /// <summary>
        /// Gets or sets the lsadc.
        /// </summary>
        /// <value>
        /// The lsadc.
        /// </value>
        [JsonProperty("LSADC")]
        public string Lsadc { get; set; }

        /// <summary>
        /// Gets or sets the funcstat.
        /// </summary>
        /// <value>
        /// The funcstat.
        /// </value>
        [JsonProperty("FUNCSTAT")]
        public string Funcstat { get; set; }

        /// <summary>
        /// Gets or sets the intptlat.
        /// </summary>
        /// <value>
        /// The intptlat.
        /// </value>
        [JsonProperty("INTPTLAT")]
        public string Intptlat { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonProperty("NAME")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the objectid.
        /// </summary>
        /// <value>
        /// The objectid.
        /// </value>
        [JsonProperty("OBJECTID")]
        public long Objectid { get; set; }

        /// <summary>
        /// Gets or sets the tract.
        /// </summary>
        /// <value>
        /// The tract.
        /// </value>
        [JsonProperty("TRACT", NullValueHandling = NullValueHandling.Ignore)]
        public string Tract { get; set; }

        /// <summary>
        /// Gets or sets the centlon.
        /// </summary>
        /// <value>
        /// The centlon.
        /// </value>
        [JsonProperty("CENTLON")]
        public string Centlon { get; set; }

        /// <summary>
        /// Gets or sets the BLKGRP.
        /// </summary>
        /// <value>
        /// The BLKGRP.
        /// </value>
        [JsonProperty("BLKGRP", NullValueHandling = NullValueHandling.Ignore)]
        public string Blkgrp { get; set; }

        /// <summary>
        /// Gets or sets the arealand.
        /// </summary>
        /// <value>
        /// The arealand.
        /// </value>
        [JsonProperty("AREALAND")]
        public long Arealand { get; set; }

        /// <summary>
        /// Gets or sets the hu100.
        /// </summary>
        /// <value>
        /// The hu100.
        /// </value>
        [JsonProperty("HU100")]
        public long Hu100 { get; set; }

        /// <summary>
        /// Gets or sets the intptlon.
        /// </summary>
        /// <value>
        /// The intptlon.
        /// </value>
        [JsonProperty("INTPTLON")]
        public string Intptlon { get; set; }

        /// <summary>
        /// Gets or sets the MTFCC.
        /// </summary>
        /// <value>
        /// The MTFCC.
        /// </value>
        [JsonProperty("MTFCC")]
        public string Mtfcc { get; set; }

        /// <summary>
        /// Gets or sets the lwblktyp.
        /// </summary>
        /// <value>
        /// The lwblktyp.
        /// </value>
        [JsonProperty("LWBLKTYP", NullValueHandling = NullValueHandling.Ignore)]
        public string Lwblktyp { get; set; }

        /// <summary>
        /// Gets or sets the ur.
        /// </summary>
        /// <value>
        /// The ur.
        /// </value>
        [JsonProperty("UR")]
        public string Ur { get; set; }

        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        /// <value>
        /// The county.
        /// </value>
        [JsonProperty("COUNTY", NullValueHandling = NullValueHandling.Ignore)]
        public string County { get; set; }

        /// <summary>
        /// Gets or sets the countycc.
        /// </summary>
        /// <value>
        /// The countycc.
        /// </value>
        [JsonProperty("COUNTYCC", NullValueHandling = NullValueHandling.Ignore)]
        public string Countycc { get; set; }

        /// <summary>
        /// Gets or sets the countyns.
        /// </summary>
        /// <value>
        /// The countyns.
        /// </value>
        [JsonProperty("COUNTYNS", NullValueHandling = NullValueHandling.Ignore)]
        public string Countyns { get; set; }

        /// <summary>
        /// Gets or sets the statens.
        /// </summary>
        /// <value>
        /// The statens.
        /// </value>
        [JsonProperty("STATENS", NullValueHandling = NullValueHandling.Ignore)]
        public string Statens { get; set; }

        /// <summary>
        /// Gets or sets the stusab.
        /// </summary>
        /// <value>
        /// The stusab.
        /// </value>
        [JsonProperty("STUSAB", NullValueHandling = NullValueHandling.Ignore)]
        public string Stusab { get; set; }

        /// <summary>
        /// Gets or sets the division.
        /// </summary>
        /// <value>
        /// The division.
        /// </value>
        [JsonProperty("DIVISION", NullValueHandling = NullValueHandling.Ignore)]
        public string Division { get; set; }

        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        /// <value>
        /// The region.
        /// </value>
        [JsonProperty("REGION", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }
    }
}
