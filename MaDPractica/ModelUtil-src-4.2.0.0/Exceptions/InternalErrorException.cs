using System;

namespace Es.Udc.DotNet.ModelUtil.Exceptions
{
    public class InternalErrorException : Exception
    {
        private Exception encapsulatedException;

        public InternalErrorException(Exception exception)
        {
            encapsulatedException = exception;
        }

        public InternalErrorException(String msg) : base(msg)
        {
        }

        #region Properties Region

        public override String Message
        {
            get
            {
                if (encapsulatedException == null)
                    return this.Message;
                else
                    return encapsulatedException.Message;
            }
        }

        public Exception EncapsulatedException
        {
            get { return encapsulatedException; }
        }

        #endregion Properties Region

        #region Test Code Region

        //public static void Main(String[] args)
        //{
        //    try
        //    {
        //        throw new InternalErrorException(
        //            new System.DivideByZeroException("Operation Exception"));

        // } catch (InternalErrorException e) { System.Console.WriteLine("Message: " + e.Message);
        // System.Console.WriteLine("StackTrace: " + e.encapsulatedException.StackTrace);
        // System.Console.ReadLine(); }

        //}

        #endregion Test Code Region
    }
}