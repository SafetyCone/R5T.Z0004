using System;


namespace R5T.Z0004
{
    public class Examples : IExamples
    {
        #region Infrastructure

        public static Examples Instance { get; } = new();

        private Examples()
        {
        }

        #endregion
    }
}