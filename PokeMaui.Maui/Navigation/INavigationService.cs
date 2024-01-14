
namespace PokeMaui.Maui.Navigation
{
    /// <summary>
    /// Interface to Define any Navigation Requirements
    /// </summary>
    public interface INavigationService
    {
        Task NavigateToAsync(string route, Dictionary<string, object> parameters = null);
    }
}
