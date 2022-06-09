using System;


namespace R5T.Z0004
{
    public class Example : IExample
    {
        #region Infrastructure

        public static Example Instance { get; } = new();

        private Example()
        {
        }

        #endregion
    }
}