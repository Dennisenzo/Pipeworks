using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Denga.Pipeworks.Views.ModelFactories
{
    public class SimpleModelFactory<T> : IInputModelFactory<T>, IViewModelFactory<T>
    {
        private readonly Action<T> _inputHandler;
        private readonly Func<T> _viewBuilder;

        public SimpleModelFactory(Func<T> viewBuilder, Action<T> inputHandler)
        {
            _inputHandler = inputHandler;
            _viewBuilder = viewBuilder;
        }

        public virtual void HandleInput(T inputModel)
        {
            _inputHandler?.Invoke(inputModel);
        }

        public virtual T BuildView()
        {
            return _viewBuilder.Invoke();
            }
    }
}