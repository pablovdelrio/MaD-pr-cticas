using System;

namespace Es.Udc.DotNet.ModelUtil.Exceptions
{
    /**
     * The root exception of all exceptions in the "Model".
     */

    public abstract class ModelException : Exception
    {
        protected ModelException()
        {
        }

        protected ModelException(String message) : base(message)
        {
        }
    }
}