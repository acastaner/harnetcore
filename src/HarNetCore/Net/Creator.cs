﻿namespace Harnet.Net
{
    /// <summary>
    /// This object contains information about the log creator application.
    /// </summary>
    public class Creator
    {
        #region Properties
        /// <summary>
        /// Required. The name of the application that created the log.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Required. The version number of the application that created the log.
        /// </summary>
        public float Version { get; set; }
        /// <summary>
        /// Optional. A comment provided by the user or the application.
        /// </summary>
        public string Comment { get; set; }
        #endregion
        #region Constructors
        public Creator() { }
        /// <summary>
        /// Constructor including all the required properties.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="version"></param>
        public Creator(string name, string version)
        {
            Name = name;
            Version = float.Parse(version);
        }
        public Creator(string name, float version)
        {
            Name = name;
            Version = version;
        }
        #endregion
    }
}
