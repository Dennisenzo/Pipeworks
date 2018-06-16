using System;
using System.Collections.Generic;
using System.Text;

namespace Denga.Pipeworks.Views.ModelFactories
{
    public interface IViewModelFactory<out T>:IModelFactory
    {
        T BuildView();
    }

    public interface IInputModelFactory<T> : IModelFactory
    {
        void HandleInput(T inputModel);
    }

    public interface IModelFactory
    {
    }
}
