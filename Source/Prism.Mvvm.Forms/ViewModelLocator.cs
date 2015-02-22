using Microsoft.Practices.Prism.Mvvm;
using Xamarin.Forms;

namespace Microsoft.Practices.Prism.Mvvm
{
    public static class ViewModelLocator
    {
        public static readonly BindableProperty AutowireViewModelProperty = BindableProperty.CreateAttached<BindableObject, bool>(
            p => ViewModelLocator.GetAutowireViewModel(p),
            default(bool),
            BindingMode.OneWay,
            null,
            OnAutowireViewModelChanged,
            null,
            null,
            null);

        public static bool GetAutowireViewModel(BindableObject bo)
        {
            return (bool)bo.GetValue(ViewModelLocator.AutowireViewModelProperty);
        }
        public static void SetAutowireViewModel(BindableObject bo, bool value)
        {
            bo.SetValue(ViewModelLocator.AutowireViewModelProperty, value);
        }

        public static void OnAutowireViewModelChanged(BindableObject bo, bool oldValue, bool newValue)
        {
            if (newValue)
                ViewModelLocationProvider.AutoWireViewModelChanged(bo, Bind);
        }

        static void Bind(object view, object viewModel)
        {
            var page = view as BindableObject;
            if (page != null)
                page.BindingContext = viewModel;
        }
    }
}
