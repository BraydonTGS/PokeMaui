namespace PokeMaui.Maui.Navigation
{
    public class ShellNavigationService : INavigationService
    {
        public ShellNavigationService() { }

        #region NavigateToAsync
        /// <summary>
        /// Navigate to the Specified Route with the Specified Parameters if Any
        /// </summary>
        /// <param name="route"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public async Task NavigateToAsync(string route, Dictionary<string, object> parameters = null)
        {
            var shell = Shell.Current;

            if (shell == null)
            {
                throw new InvalidOperationException("Shell is not initialized.");
            }

            await shell.GoToAsync(route, true, parameters);
        }
        #endregion
    }
}
