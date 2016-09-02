using System;
namespace LifeCycleExample
{
    public interface IUIFunctions
    {
        void Alert(string message);
        void Alert(string message, string title, string okButtonText, string cancelButtonText);
    }
}

