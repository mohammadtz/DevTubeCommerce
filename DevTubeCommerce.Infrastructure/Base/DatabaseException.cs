﻿namespace DevTubeCommerce.Infrastructure.Base;

public class DatabaseException : Exception
{
    public DatabaseException(string message) : base(message)
    {

    }
}
