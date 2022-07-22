namespace BlazorApp.WASM.Client.StateManagers
{
    public class SnackbarStateManager
    {
        public event Func<Task>? OnShowSnackbar;
        public event Action OnHideSnackbar;
        public event Action OnCancelDisposal;

        internal void ShowSnackbar() => OnShowSnackbar?.Invoke();
        internal void HideSnackbar() => OnHideSnackbar?.Invoke();
        internal void CancelDisposal() => OnCancelDisposal?.Invoke();
    }
}
