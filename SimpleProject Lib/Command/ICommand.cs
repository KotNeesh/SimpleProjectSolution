using System;

namespace SimpleProject
{
    public interface ICommand
    {
        void Do(IParameters parameters);
    }
}
