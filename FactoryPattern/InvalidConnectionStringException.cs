using System;

namespace FactoryPattern
{
    /**
    * A custom exception that our factory will throw if passed an invalid connection string.
    */
    internal sealed class InvalidConnectionStringException : Exception
    {
    }
}