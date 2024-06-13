using System;

public class TestFixture : IDisposable
{
    // Any resources managed by this class
    private bool _disposed = false;

    // Dispose method to release resources
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    // Protected dispose method
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                // Dispose managed resources here
                Console.WriteLine("Disposing managed resources in TestFixture.");
            }

            // Dispose unmanaged resources here

            // Mark as disposed
            _disposed = true;
        }
    }

    // Finalizer (destructor)
    ~TestFixture()
    {
        Dispose(false);
    }
}
