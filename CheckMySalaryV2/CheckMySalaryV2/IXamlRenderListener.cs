using Microsoft.UI.Xaml;

namespace CheckMySalaryV2
{
    public interface IXamlRenderListener
    {
        void OnXamlRendered(FrameworkElement control);
    }
}
