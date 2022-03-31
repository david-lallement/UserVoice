using GroupeIsa.Neos.Application.UI;

namespace UserVoice.CSharpAbstractions
{
    /// <inheritdoc/>
    public abstract class ViewModel<TUIView> : GroupeIsa.Neos.Designer.UIAbstractions.ViewModel<TUIView>
        where TUIView : class, IUIView
    {
    }
}